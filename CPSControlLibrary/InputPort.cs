using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            EditParameters edit = new EditParameters();
            edit.Show();
        }
    }
}
