using LibraryControl.User.Lib.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LibraryControl.User.Lib
{
   public class ServiceXmLDocument
    {
        private string pathDocument { get; set; }
        public ServiceXmLDocument() { }
        public ServiceXmLDocument(string pathDocument)
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
                            XmlElement root = doc.CreateElement("user");
                            doc.AppendChild(root);
                            doc.Save(pathDocument);
                        }
                    }

                    if (doc.DocumentElement != null)
                        return doc;
                    else
                    {
                        XmlElement root = doc.CreateElement("user");
                        doc.AppendChild(root);

                        doc.Save(pathDocument);
                        return doc;
                    }
                }
                else
                {
                    using (Stream stream = file.Create())
                    {
                        XmlElement root = doc.CreateElement("user");
                        doc.AppendChild(root);
                    }
                    doc.Save(pathDocument);
                    return doc;
                }
            }
            else
                throw new FileNotFoundException();
        }

        public void CreateUser(Users user)
        {
            string guidUser = Guid.NewGuid().ToString();
            pathDocument = pathDocument + @"\" + guidUser + ".xml";
            XmlDocument doc = GetDocument();

            XmlElement xUser = doc.CreateElement("user");

            XmlElement xUserId = doc.CreateElement("userId");
            xUserId.InnerText = guidUser;
            xUser.AppendChild(xUserId);

            XmlElement xLogin = doc.CreateElement("name");
            xLogin.InnerText = user.name;
            xUser.AppendChild(xLogin);

            XmlElement xPassword = doc.CreateElement("password");
            xPassword.InnerText = user.password;
            xUser.AppendChild(xPassword);

            XmlElement xAddress = doc.CreateElement("address");
            xLogin.InnerText = user.address;
            xUser.AppendChild(xAddress);

            XmlElement xContact = doc.CreateElement("contact");
            xPassword.InnerText = user.contact;
            xUser.AppendChild(xContact);

            XmlElement xEmail = doc.CreateElement("email");
            xEmail.InnerText = user.email;
            xUser.AppendChild(xEmail);

            XmlElement xIssueTag = doc.CreateElement("issuetag");
            xPassword.InnerText = user.issueTag;
            xUser.AppendChild(xIssueTag);

            //XmlElement xtagsUsed = doc.CreateElement("tagsused");
            //xEmail.InnerText = user.tagsUsed;
            //xUser.AppendChild(xtagsUsed);

            doc.DocumentElement.AppendChild(xUser);
            doc.Save(pathDocument);

        }
    }
}
