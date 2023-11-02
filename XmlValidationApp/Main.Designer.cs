namespace XmlValidationApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            openXMLDialog = new OpenFileDialog();
            XmlFilePathTextBox = new TextBox();
            XmlFileLabel = new Label();
            XmlSchemaFileLabel = new Label();
            XmlSchemaFilePathTextBox = new TextBox();
            browseXmlFileButton = new Button();
            browseSchemaFileButton = new Button();
            validateResultLabel = new Label();
            validateButton = new Button();
            openSchemaDialog = new OpenFileDialog();
            SuspendLayout();
            // 
            // openXMLDialog
            // 
            openXMLDialog.FileName = "openFileDialog1";
            // 
            // XmlFilePathTextBox
            // 
            XmlFilePathTextBox.Location = new Point(12, 42);
            XmlFilePathTextBox.Name = "XmlFilePathTextBox";
            XmlFilePathTextBox.Size = new Size(408, 23);
            XmlFilePathTextBox.TabIndex = 0;
            // 
            // XmlFileLabel
            // 
            XmlFileLabel.AutoSize = true;
            XmlFileLabel.Location = new Point(12, 24);
            XmlFileLabel.Name = "XmlFileLabel";
            XmlFileLabel.Size = new Size(52, 15);
            XmlFileLabel.TabIndex = 1;
            XmlFileLabel.Text = "XML File";
            // 
            // XmlSchemaFileLabel
            // 
            XmlSchemaFileLabel.AutoSize = true;
            XmlSchemaFileLabel.Location = new Point(12, 79);
            XmlSchemaFileLabel.Name = "XmlSchemaFileLabel";
            XmlSchemaFileLabel.Size = new Size(97, 15);
            XmlSchemaFileLabel.TabIndex = 2;
            XmlSchemaFileLabel.Text = "XML Schema File";
            // 
            // XmlSchemaFilePathTextBox
            // 
            XmlSchemaFilePathTextBox.Location = new Point(12, 97);
            XmlSchemaFilePathTextBox.Name = "XmlSchemaFilePathTextBox";
            XmlSchemaFilePathTextBox.Size = new Size(408, 23);
            XmlSchemaFilePathTextBox.TabIndex = 3;
            // 
            // browseXmlFileButton
            // 
            browseXmlFileButton.Location = new Point(426, 42);
            browseXmlFileButton.Name = "browseXmlFileButton";
            browseXmlFileButton.Size = new Size(75, 23);
            browseXmlFileButton.TabIndex = 4;
            browseXmlFileButton.Text = "Browse";
            browseXmlFileButton.UseVisualStyleBackColor = true;
            browseXmlFileButton.Click += browseXmlFileButton_Click;
            // 
            // browseSchemaFileButton
            // 
            browseSchemaFileButton.Location = new Point(426, 96);
            browseSchemaFileButton.Name = "browseSchemaFileButton";
            browseSchemaFileButton.Size = new Size(75, 23);
            browseSchemaFileButton.TabIndex = 5;
            browseSchemaFileButton.Text = "Browse";
            browseSchemaFileButton.UseVisualStyleBackColor = true;
            browseSchemaFileButton.Click += browseSchemaFileButton_Click;
            // 
            // validateResultLabel
            // 
            validateResultLabel.AutoSize = true;
            validateResultLabel.Location = new Point(200, 152);
            validateResultLabel.Name = "validateResultLabel";
            validateResultLabel.Size = new Size(0, 15);
            validateResultLabel.TabIndex = 6;
            // 
            // validateButton
            // 
            validateButton.Location = new Point(60, 148);
            validateButton.Name = "validateButton";
            validateButton.Size = new Size(113, 23);
            validateButton.TabIndex = 7;
            validateButton.Text = "Validate";
            validateButton.UseVisualStyleBackColor = true;
            validateButton.Click += validateButton_Click;
            // 
            // openSchemaDialog
            // 
            openSchemaDialog.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 198);
            Controls.Add(XmlFileLabel);
            Controls.Add(XmlFilePathTextBox);
            Controls.Add(browseXmlFileButton);
            Controls.Add(XmlSchemaFileLabel);
            Controls.Add(XmlSchemaFilePathTextBox);
            Controls.Add(browseSchemaFileButton);
            Controls.Add(validateButton);
            Controls.Add(validateResultLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "XML Validation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openXMLDialog;
        private TextBox XmlFilePathTextBox;
        private Label XmlFileLabel;
        private Label XmlSchemaFileLabel;
        private TextBox XmlSchemaFilePathTextBox;
        private Button browseXmlFileButton;
        private Button browseSchemaFileButton;
        private Label validateResultLabel;
        private Button validateButton;
        private OpenFileDialog openSchemaDialog;
    }
}