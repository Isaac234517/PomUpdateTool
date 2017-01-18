using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Xml;

namespace Handlers
{
    public class Processor
    {
        public List<String> fileList;
        public List<String> propertiesList;
        public Processor()
        {
            fileList = new List<String>();
            propertiesList = new List<String>();
        }

        public void OpenFile(object sender, System.EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = true;
            dialog.Filter = "XML Files(*.xml)|*.xml|POM files (*.pom)|*.pom";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Console.WriteLine("Open Files");
                foreach (String file in dialog.FileNames)
                {
                    if (!fileList.Contains(file))
                        fileList.Add(file);
                }
            }
        }

        public void ApplyTargetVersion(String version, String updateDigit)
        {
            foreach (String fileName in fileList)
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(fileName);
                XmlNode root = xmlDoc.LastChild;
                Boolean hasChange = false;
                foreach (String name in propertiesList)
                {
                   Boolean change =  processRootLayer(root, name, version);
                   if(hasChange == false && change == true)
                    {
                        hasChange = true;
                    }
                }
                if(hasChange == true)
                {
                    if(updateDigit!=null || updateDigit != String.Empty)
                    {

                    }
                    xmlDoc.Save(fileName);
                }
            }
        }

        private Boolean processRootLayer(XmlNode root, String name,String version)
        {
            Boolean change = false;
            if (root.HasChildNodes)
            {
                foreach (XmlNode node in root.ChildNodes)
                {
                    if(name == "parent" && node.Name == "parent")
                    {
                        XmlNodeList parentNodes = node.ChildNodes;
                        foreach (XmlNode subNode in parentNodes)
                        {
                            if(subNode.Name == "version")
                            {
                                subNode.InnerText = version;
                                change = true;
                                break;
                            }
                        }
                        break;
                    }
                    else if (name!="parent" && node.Name == "properties")
                    {
                        XmlNodeList propertiesNodes = node.ChildNodes;
                        foreach (XmlNode subNode in propertiesNodes)
                        {
                            if(subNode.Name == name)
                            {
                                subNode.InnerText = version;
                                change = true;
                                break;
                            }
                        }
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            return change;
        }
    }
}
