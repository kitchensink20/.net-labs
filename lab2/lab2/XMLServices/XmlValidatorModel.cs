using System;
using System.Xml;
using System.Xml.Schema;

namespace lab2
{
    public static class XmlValidatorModel
    { 
        private static XmlSchemaSet schemaSet = new XmlSchemaSet();

        public static bool Validate(string xmlFilePath)
        {
            bool isValid = true;
            try
            {
                XmlDocument xmlDoc = XmlLoaderModel.LoadXMLFile(xmlFilePath);
                xmlDoc.Schemas = schemaSet;
                xmlDoc.Validate(ValidationEventHandler);
                Console.WriteLine($"Xml документ {xmlFilePath} є валідним відповідно до XSD схеми.");
            }
            catch
            {
                isValid = false;
                Console.WriteLine($"Xml документ {xmlFilePath} не є валідним відповідно до XSD схеми.");
            }
            return isValid;
        }

        public static void AddNewXmlSchema(string schemaFilePath)
        {
            schemaSet.Add("", schemaFilePath);
        }

        private static void ValidationEventHandler(object sender, ValidationEventArgs e)
        {
            throw new XmlSchemaValidationException(e.Message);
        }
    }
}

/*
    XmlSchemaSet клас це колекція XML схем, яка може бути використана для того, 
    щоб валідувати XML документи. Містить кеш схем мови визначення схем XML(XSD).
    Містить метод Add, який приймає 2 параметри: цільове пространство імен та 
    шлях до XML файлу.
    XmlDocument's Schemas властивість використовується для того, щоб вказати які 
    XML схеми необхідно використовувати для валідації.
 */
