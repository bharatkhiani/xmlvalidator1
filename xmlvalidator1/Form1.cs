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

        private void txbXmlFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd1 = new OpenFileDialog();
            ofd1.InitialDirectory = Application.StartupPath;
            ofd1.Filter = "XML Files (*.xml)|*.xml";
            ofd1.ShowDialog();
            
            txbXmlFile.Text = ofd1.FileName;
        }

        void settings_ValidationEventHandler(object sender, System.Xml.Schema.ValidationEventArgs e)
        {
            validationError = true;
            ShowResults(e.Message);
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            validationError = false;
            string filename = txbXmlFile.Text;

            if (filename.Length == 0 || !File.Exists(filename))
            {
                txbResults.AppendText("Invalid filename/path" + seperator);
                return;
            }

            // Check if it has DOCTYPE
            string data = File.ReadAllText(filename);

            if (data.IndexOf("<!DOCTYPE") != -1)
            {
                XmlReaderSettings settings = new XmlReaderSettings();
                settings.ValidationType = ValidationType.DTD;
                settings.DtdProcessing = DtdProcessing.Parse;
                settings.ValidationEventHandler += settings_ValidationEventHandler;

                XmlReader reader = XmlReader.Create(filename, settings);
                while (reader.Read()) ; // traverse the xml file, validates dtd againg body.

                reader.Close();
                if(!validationError)
                    ShowResults("Document is valid and meets DTD requirements");
            }
            else
            {
                ShowResults("No DOCTYPE present in xml, pls include it or check the checkbox to select the dtd");
            }
            

           
        }

        private void ShowResults(string text)
        {
            txbResults.AppendText(text + seperator);
        }
    }
}
