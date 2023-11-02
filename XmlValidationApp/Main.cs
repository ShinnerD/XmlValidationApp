using System.Text;
using System.Xml;
using System.Xml.Schema;

namespace XmlValidationApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void validateButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(XmlFilePathTextBox.Text))
                return;

            var output = new StringBuilder();

            if (IsWellFormedXml(XmlFilePathTextBox.Text))
                output.Append("XML file is well formed");

            if (IsValidXml(XmlFilePathTextBox.Text, XmlSchemaFilePathTextBox.Text))
                output.Append(" and valid against schema");

            if (output.Length <= 0)
                output.Append("File is invalid XML");

            output.Append('.');

            validateResultLabel.Text = output.ToString();
        }

        private static bool IsWellFormedXml(string xmlFilePath)
        {
            try
            {
                using var xmlReader = new XmlTextReader(xmlFilePath);
                while (xmlReader.Read()) ;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private static bool IsValidXml(string xmlFilePath, string xsdFilePath)
        {
            try
            {
                var xmlReaderSettings = new XmlReaderSettings();
                var xmlSchemaSet = new XmlSchemaSet();
                xmlSchemaSet.Add(null, xsdFilePath);
                xmlReaderSettings.ValidationType = ValidationType.None;
                xmlReaderSettings.Schemas.Add(xmlSchemaSet);

                using var xmlReader = XmlReader.Create(xmlFilePath, xmlReaderSettings);

                while (xmlReader.Read()) ;

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void browseXmlFileButton_Click(object sender, EventArgs e)
        {
            var dialogResult = openXMLDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                XmlFilePathTextBox.Text = openXMLDialog.FileName;
            }
        }

        private void browseSchemaFileButton_Click(object sender, EventArgs e)
        {
            var dialogResult = openXMLDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                XmlSchemaFilePathTextBox.Text = openXMLDialog.FileName;
            }
        }
    }
}