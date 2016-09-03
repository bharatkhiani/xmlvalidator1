namespace xmlvalidator1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txbXmlFile = new System.Windows.Forms.TextBox();
            this.txbExternalDtdFile = new System.Windows.Forms.TextBox();
            this.btnValidate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txbResults = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lnkClearMessages = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Xml File:";
            // 
            // txbXmlFile
            // 
            this.txbXmlFile.Location = new System.Drawing.Point(94, 14);
            this.txbXmlFile.Margin = new System.Windows.Forms.Padding(5);
            this.txbXmlFile.Name = "txbXmlFile";
            this.txbXmlFile.ReadOnly = true;
            this.txbXmlFile.Size = new System.Drawing.Size(463, 26);
            this.txbXmlFile.TabIndex = 1;
            this.txbXmlFile.Text = "Click here to choose...";
            this.txbXmlFile.Click += new System.EventHandler(this.txbXmlFile_Click);
            // 
            // txbExternalDtdFile
            // 
            this.txbExternalDtdFile.Location = new System.Drawing.Point(175, 65);
            this.txbExternalDtdFile.Margin = new System.Windows.Forms.Padding(5);
            this.txbExternalDtdFile.Name = "txbExternalDtdFile";
            this.txbExternalDtdFile.ReadOnly = true;
            this.txbExternalDtdFile.Size = new System.Drawing.Size(382, 26);
            this.txbExternalDtdFile.TabIndex = 4;
            this.txbExternalDtdFile.Text = "Click here to choose...";
            this.txbExternalDtdFile.Click += new System.EventHandler(this.txbExternalDtdFile_Click);
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(12, 134);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(173, 44);
            this.btnValidate.TabIndex = 5;
            this.btnValidate.Text = "&Validate";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Results: ";
            // 
            // txbResults
            // 
            this.txbResults.Location = new System.Drawing.Point(16, 226);
            this.txbResults.Margin = new System.Windows.Forms.Padding(5);
            this.txbResults.Multiline = true;
            this.txbResults.Name = "txbResults";
            this.txbResults.ReadOnly = true;
            this.txbResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbResults.Size = new System.Drawing.Size(541, 225);
            this.txbResults.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "External DTD File:";
            // 
            // lnkClearMessages
            // 
            this.lnkClearMessages.AutoSize = true;
            this.lnkClearMessages.Location = new System.Drawing.Point(98, 201);
            this.lnkClearMessages.Name = "lnkClearMessages";
            this.lnkClearMessages.Size = new System.Drawing.Size(137, 20);
            this.lnkClearMessages.TabIndex = 9;
            this.lnkClearMessages.TabStop = true;
            this.lnkClearMessages.Text = "Clear Messages";
            this.lnkClearMessages.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkClearMessages_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 454);
            this.Controls.Add(this.lnkClearMessages);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbResults);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.txbExternalDtdFile);
            this.Controls.Add(this.txbXmlFile);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbXmlFile;
        private System.Windows.Forms.TextBox txbExternalDtdFile;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbResults;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel lnkClearMessages;
    }
}

