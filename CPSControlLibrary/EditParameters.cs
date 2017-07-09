using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPSControlLibrary
{
    public partial class EditParameters : Form
    {
        private Port callPort;
        public EditParameters()
        {
            InitializeComponent();
        }
        public EditParameters(Port p) {
            callPort = p;
            InitializeComponent();
        }
        private void button_commit_Click(object sender, EventArgs e)
        {
            callPort.Value = Convert.ToInt32(textBox_value.Text);
            MessageBox.Show(callPort.Value.ToString());
        }
    }
}
