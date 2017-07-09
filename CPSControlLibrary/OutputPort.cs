using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPSControlLibrary
{
    public class OutputPort : Port
    {


        public OutputPort()
        {
            base.InitializeComponent();
            this.pictureBox.DoubleClick += new System.EventHandler(this.Output_DoubleClick);
            this.pictureBox.Image = CPSControlLibrary.Properties.Resources.outputPort;
            this.Name = "OutputPort";
        }




        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void Output_DoubleClick(object sender, EventArgs e)
        {
            EditParameters edit = new EditParameters();
            edit.Show();
        }
    }
}
