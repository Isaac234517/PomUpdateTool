using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Handlers;

namespace UpdatePomVersion
{
    public partial class PomUpdate : Form
    {
        public Processor processor;
        public enum selfVersion{
            last,middle,first
        };

        public PomUpdate()
        {
            InitializeComponent();
            processor = new Processor();
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            processor.OpenFile(sender, e);
            FileListsArea.Items.Clear();
            foreach (string filename in processor.fileList)
            {
                FileListsArea.Items.Add(filename);
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            ClearFile();
        }

        private void ClearFile()
        {
            FileListsArea.Items.Clear();
            processor.fileList.Clear();
        }

        private void Apply_Click(object sender, EventArgs e)
        {
            if (Validator.CheckTextBoxNull(TargetVersion.Text))
            {
                MessageBox.Show("Target version should not be empty");
                return;
            }

            if (Validator.noPropertiesChoose(processor.propertiesList))
            {
                MessageBox.Show("At lease choose one properties");
                return;
            }

            if (Validator.noFileChoose(processor.fileList))
            {
                MessageBox.Show("At least select one xml or pom file");
                return;
            }

            processor.ApplyTargetVersion(TargetVersion.Text);
        }

        private void selfVersion_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton digit = sender as RadioButton;
            if(digit != null)
            {
                switch (digit.Name)
                {
                    case "first":
                        setSelfTargetVersion(digit.Checked, Enum.GetName(typeof(selfVersion), selfVersion.first));
                        break;
                    case "middle":
                        setSelfTargetVersion(digit.Checked, Enum.GetName(typeof(selfVersion), selfVersion.middle));
                        break;
                    case "last":
                        setSelfTargetVersion(digit.Checked, Enum.GetName(typeof(selfVersion), selfVersion.last));
                        break;
                }
            }
        }

        private void setSelfTargetVersion(Boolean choose, string name)
        {
            if(choose == true)
            {
                processor.updateDigit = name;
            }
            else
            {
                processor.updateDigit = "";
            }
        }

        private void properties_SelectedIndexChanged(object sender, EventArgs e)
        {
            processor.propertiesList.Clear();
            foreach (Object checkedItem in properties.CheckedItems)
            {
                processor.propertiesList.Add(checkedItem.ToString());
            }
        }

        private void ClearAllSelection(object sender, EventArgs e)
        {
            first.Checked = false;
            middle.Checked = false;
            last.Checked = false;
            for(int i = 0; i < properties.Items.Count; i++)
            {
                properties.SetItemChecked(i, false);
            }
            processor.clearSelectVersion();
        }

        private void DelItem(object sender, EventArgs e)
        {
           while (FileListsArea.SelectedIndices.Count > 0)
            {
                int i = FileListsArea.SelectedIndices[0];
                FileListsArea.Items.RemoveAt(i);
                processor.fileList.RemoveAt(i);
            }
        }
    }
}
