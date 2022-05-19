using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Xml; //Requerido para XML
using System.IO; //Requerido para XML

namespace proyectoApp_checkEmpleados
{
    class Persistent
    {
        //ruta predeterminada para archivos del programa
        string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), 
            "empleadosCTRL");
        string filePath;
        XmlDocument doc = new XmlDocument();

        public string traker()
        {
            string y = "";

            if (!Directory.Exists(path))
            {
                try
                {
                    Directory.CreateDirectory(path);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Se produjo un error en 'Persistent'\n No se pudo crear el " +
                        "directorio 'empleadosCTRL'\n\r" + e.ToString());
                    return "";
                }
            }

            filePath = Path.Combine(path, "conf.xml");

            if (!File.Exists(filePath))
            {
                try
                {
                    //Creacion de estructura 
                    XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
                    XmlNode root = doc.DocumentElement;

                    doc.InsertBefore(xmlDeclaration, root);

                    XmlNode element1 = doc.CreateElement("cfg");
                    doc.AppendChild(element1);
                    doc.Save(filePath);

                    //Estructura de puertos
                    doc.Load(filePath);

                    XmlNode puerto = doc.CreateElement("puerto");

                    XmlElement com = doc.CreateElement("com");
                    com.InnerText = "";
                    puerto.AppendChild(com);

                    XmlNode nodoRaiz = doc.DocumentElement;
                    nodoRaiz.InsertAfter(puerto, nodoRaiz.LastChild);

                    doc.Save(filePath);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Se produjo un error en 'Persistent'\n No se pudo crear el " +
                        "archivo 'conf.xml'\n\r" + e.ToString());
                    return "";
                }
            }
            else
            {
                try
                {
                    doc.Load(filePath);

                    XmlNodeList cfg = doc.GetElementsByTagName("cfg");
                    XmlNodeList puerto = ((XmlElement)cfg[0]).GetElementsByTagName("puerto");

                    foreach (XmlElement nodo in puerto) { y = nodo.SelectSingleNode("com").InnerText; }

                    doc.Save(filePath);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Se produjo un error en 'Persistent'\n No se pudo leer " +
                        "'conf.xml'\n\r" + e.ToString());
                    return "";
                }
            }

            return y;
        }

        public void setter(string data)
        {
            try
            {
                doc.Load(filePath);

                XmlNodeList cfg = doc.GetElementsByTagName("cfg");
                XmlNodeList puerto = ((XmlElement)cfg[0]).GetElementsByTagName("puerto");

                foreach (XmlElement nodo in puerto) { nodo.SelectSingleNode("com").InnerText = data; }

                doc.Save(filePath);
            }
            catch (Exception e)
            {
                MessageBox.Show("Se produjo un error en 'Persistent'\n No se pudo actualizar " +
                    "'com'\n\r" + e.ToString());
                return;
            }
        }

        public string getter()
        {
            string _out = "";

            if (traker() != "")
            {
                try
                {
                    doc.Load(filePath);

                    XmlNodeList cfg = doc.GetElementsByTagName("cfg");
                    XmlNodeList puerto = ((XmlElement)cfg[0]).GetElementsByTagName("puerto");

                    foreach (XmlElement nodo in puerto) { _out = nodo.SelectSingleNode("com").InnerText; }

                    doc.Save(filePath);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Se produjo un error en 'Persistent'\n No se pudo obtener " +
                        "'com'\n\r" + e.ToString());
                    return "";
                }
            }

            return _out;
        }

        public bool deleter()
        {
            if (traker() != "")
            {
                try
                {
                    doc.Load(filePath);

                    XmlNodeList cfg = doc.GetElementsByTagName("cfg");
                    XmlNodeList puerto = ((XmlElement)cfg[0]).GetElementsByTagName("puerto");

                    foreach (XmlElement nodo in puerto) {
                        if (nodo.SelectSingleNode("com").InnerText != "")
                        {
                            nodo.SelectSingleNode("com").InnerText = "";
                        }
                    }

                    doc.Save(filePath);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Se produjo un error en 'Persistent'\n No se pudo eliminar " +
                        "'com'\n\r" + e.ToString());
                    return false;
                }
            }

            return true;
        }
    }
}
