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
    public partial class Form1 : Form
    {
        public Processor processor;
        public Form1()
        {
            InitializeComponent();
            processor = new Processor();

        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            if (Validator.CheckTextBoxNull(TargetVersion.Text))
            {
                MessageBox.Show("Target version should not be empty");
            }
            else
            {
                processor.OpenFile(sender, e);
            }
        }
    }
}
