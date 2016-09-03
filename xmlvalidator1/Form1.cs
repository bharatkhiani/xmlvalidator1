using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Xml;
using System.Diagnostics;

namespace xmlvalidator1
{
    public partial class Form1 : Form
    {
        bool validationError = false;
        string seperator = Environment.NewLine + "--------------------" + Environment.NewLine;

        public Form1()
        {
            InitializeComponent();
        }

        // Event Handlers
        private void txbXmlFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd1 = new OpenFileDialog();
            ofd1.InitialDirectory = Application.StartupPath;
            ofd1.Filter = "XML Files (*.xml)|*.xml";
            ofd1.ShowDialog();
            
            txbXmlFile.Text = ofd1.FileName;
        }

        private void txbExternalDtdFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd2 = new OpenFileDialog();
            ofd2.InitialDirectory = Application.StartupPath;
            ofd2.Filter = "DTD Files (*.dtd)|*.dtd";
            ofd2.ShowDialog();

            txbExternalDtdFile.Text = ofd2.FileName;
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            validationError = false;
            string xmlFilename = txbXmlFile.Text;

            if (xmlFilename.Length == 0 || !File.Exists(xmlFilename))
            {
                txbResults.AppendText("Invalid filename/path" + seperator);
                return;
            }

            // Check if it has DOCTYPE
            string data = File.ReadAllText(xmlFilename);

            if (data.IndexOf("<!DOCTYPE") != -1)
            {
                ValidateXmlFile(xmlFilename);
            }
            else if (txbExternalDtdFile.Text.Length > 0 
                && File.Exists(txbExternalDtdFile.Text))
            {
             // Can't do this directly unless i change the original xml file in some way
                // to include the DOCTYPE in it.
                // https://bytes.com/topic/net/answers/177215-xmlvalidatingreader-dtd-validation

                #region Code to create replica of xml file with DOCTYPE in it.
                XmlReader r = new XmlTextReader(xmlFilename);

                string newXmlFilename = xmlFilename.Substring(0,xmlFilename.Length-4) + "2.xml" ;
                Debug.WriteLine(newXmlFilename);
                XmlWriter w = new XmlTextWriter(newXmlFilename, Encoding.UTF8);
                bool hasDoctype = false, inProlog = true;
                while (r.Read())
                {
                    if (r.NodeType == XmlNodeType.DocumentType)
                        hasDoctype = true;
                    else if (inProlog && !hasDoctype && r.NodeType ==
                    XmlNodeType.Element)
                    {
                        //First element is about to be written - insert Doctype here
                        w.WriteDocType(r.Name, null, txbExternalDtdFile.Text, null);
                        inProlog = false;
                    }
                    w.WriteNode(r, false);
                }
                r.Close();
                w.Close();
                #endregion

                ValidateXmlFile(newXmlFilename);
            }
            else
            {
                ShowResults("No DOCTYPE present in xml, choose an External dtd or include DOCTYPE in the xml");
            }
        }

        void settings_ValidationEventHandler(object sender, System.Xml.Schema.ValidationEventArgs e)
        {
            validationError = true;
            ShowResults(e.Message);
        }

        private void lnkClearMessages_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txbResults.Clear();
        }

        // Methods called by event handlers
        private void ShowResults(string text)
        {
            txbResults.AppendText(text + seperator);
        }

        private void ValidateXmlFile(string xmlFilename)
        {
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.ValidationType = ValidationType.DTD;
            settings.DtdProcessing = DtdProcessing.Parse;
            settings.ValidationEventHandler += settings_ValidationEventHandler;

            XmlReader reader = XmlReader.Create(xmlFilename, settings);
            while (reader.Read()) ; // traverse the xml file, validates dtd againg body.

            reader.Close();
            if (!validationError)
                ShowResults("Document is valid and meets DTD requirements");
        }

        

    }
}
