using System;
using System.Windows.Forms;

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
            PictureBox output = (PictureBox)sender;
            EditParameters edit = new EditParameters(this);
            edit.Name = "EditParameters for port" + this.Index;
            edit.Text = edit.Name;
            edit.Show();
        }
    }
}
