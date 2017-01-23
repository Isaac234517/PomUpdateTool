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
        public String updateDigit;
        public Processor()
        {
            fileList = new List<String>();
            propertiesList = new List<String>();
            updateDigit = "";
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

        public void ApplyTargetVersion(String version)
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
                    String newFileName = fileName;
                    if (updateDigit != String.Empty)
                    {
                        String newVersion = updateSelfVersion(xmlDoc, updateDigit);
                        if (fileName.LastIndexOf('.') >0 && fileName.Substring(fileName.LastIndexOf('.')+1) == "pom"){
                            String artifactID = "";
                            foreach(XmlNode node in root.ChildNodes)
                            {
                                if(node.Name == "artifactId")
                                {
                                    artifactID = node.InnerText;
                                } 
                            }
                            String newName = artifactID + "-" + newVersion;
                            newFileName = fileName.Substring(0, fileName.LastIndexOf('\\') + 1) + newName + ".pom";
                        }
                        
                        
                    }
                    xmlDoc.Save(newFileName);
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

        private String updateSelfVersion(XmlDocument xmlDoc, String updateDigit)
        {
            XmlNode root = xmlDoc.LastChild;
            String[] versionDigit = new String[3];
            String[] versionName = new String[2];
            String version = "";
            foreach (XmlNode node in root.ChildNodes)
            {
                if(node.Name == "version")
                {
                    version = node.InnerText;
                    // version[0]=xx.xx.xx version[1]= null or snapshot
                    versionName = version.Split('-');
                    versionDigit = versionName[0].Split('.');
                    switch (updateDigit)
                    {
                        case "first":
                            UpdateDigit(versionDigit, 0);
                            break;
                        case "middle":
                            UpdateDigit(versionDigit, 1);
                            break;
                        case "last":
                            UpdateDigit(versionDigit, 2);
                            break;
                    }
                    version = versionName.Length > 1 ? String.Join(".", versionDigit) + "-" + versionName[1] : String.Join(".", versionDigit);
                    node.InnerText = version;
                    break;
                }
            }
            return version;
        }

        private void UpdateDigit(String[] versionDigit, int index)
        {
           if ( index !=0 && int.Parse(versionDigit[index]) >= 99)
           {
               UpdateDigit(versionDigit, index - 1);
           }
           else
           {
               versionDigit[index] = (int.Parse(versionDigit[index]) + 1).ToString();
                for(int i = index+1; i<versionDigit.Length; i++)
                {
                    versionDigit[i] = "0";
                }
           }
        }

        public void clearSelectVersion()
        {
            updateDigit = "";
            propertiesList.Clear();
        }
    }
}
