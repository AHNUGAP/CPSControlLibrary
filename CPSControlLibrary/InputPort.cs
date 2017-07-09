using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPSControlLibrary
{
    public class InputPort : Port
    {


        public InputPort()
        {
            base.InitializeComponent();
            this.pictureBox.DoubleClick += new System.EventHandler(this.Input_DoubleClick);
            this.pictureBox.Image = CPSControlLibrary.Properties.Resources.inputPort;
            this.Name = "InputPort";
        }



        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void Input_DoubleClick(object sender, EventArgs e)
        {
            PictureBox input = (PictureBox)sender;
            EditParameters edit = new EditParameters(this);
            edit.Name = "EditParameters for port" + this.Index;
            edit.Text = edit.Name;
            edit.Show();
        }
    }
}
