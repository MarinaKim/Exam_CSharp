using LibraryControl.Admin.Lib.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LibraryControl.User.Lib
{
   public class ServiceAdminXmLDocument
    {
        private string pathDocument { get; set; }
        public ServiceAdminXmLDocument() { }
        public ServiceAdminXmLDocument(string pathDocument)
        {
            this.pathDocument = pathDocument;
        }

        public XmlDocument GetDocument()
        {
            XmlDocument doc = new XmlDocument();

            if (!string.IsNullOrEmpty(pathDocument))
            {
                FileInfo file = new FileInfo(pathDocument);
                if (file.Exists)
                {
                    try
                    {
                        doc.Load(pathDocument);
                    }
                    catch (XmlException ex)
                    {
                        if (ex.HResult == -2146232000)
                        {
                            XmlElement root = doc.CreateElement("admin");
                            doc.AppendChild(root);
                            doc.Save(pathDocument);
                        }
                    }

                    if (doc.DocumentElement != null)
                        return doc;
                    else
                    {
                        XmlElement root = doc.CreateElement("admin");
                        doc.AppendChild(root);

                        doc.Save(pathDocument);
                        return doc;
                    }
                }
                else
                {
                    using (Stream stream = file.Create())
                    {
                        XmlElement root = doc.CreateElement("admin");
                        doc.AppendChild(root);
                    }
                    doc.Save(pathDocument);
                    return doc;
                }
            }
            else
                throw new FileNotFoundException();
        }

        public void CreateAdmin(Administrator admin)
        {
            string guidAdmin = Guid.NewGuid().ToString();
            pathDocument = pathDocument + @"\" + guidAdmin + ".xml";
            XmlDocument doc = GetDocument();

            XmlElement xAdmin = doc.CreateElement("admin");

            XmlElement xAdminId = doc.CreateElement("adminId");
            xAdminId.InnerText = guidAdmin;
            xAdmin.AppendChild(xAdminId);

            XmlElement xName = doc.CreateElement("name");
            xName.InnerText = admin.name;
            xAdmin.AppendChild(xName);

            XmlElement xPassword = doc.CreateElement("password");
            xPassword.InnerText = admin.password;
            xAdmin.AppendChild(xPassword);            

            doc.DocumentElement.AppendChild(xAdmin);
            doc.Save(pathDocument);
        }

        
    }
}
