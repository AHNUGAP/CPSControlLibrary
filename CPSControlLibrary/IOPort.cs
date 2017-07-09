using System;
using System.Windows.Forms;


namespace CPSControlLibrary
{
    public  class IOport : Port
    {
        public IOport()
        {
            base.InitializeComponent();
            this.pictureBox.DoubleClick += new System.EventHandler(this.IOput_DoubleClick);
            this.pictureBox.Image = CPSControlLibrary.Properties.Resources.IOport;
            this.Name = "IOport";
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void IOput_DoubleClick(object sender, EventArgs e)
        {
            PictureBox io = (PictureBox)sender;
            EditParameters edit = new EditParameters(this);
            edit.Name = "EditParameters for port" + this.Index;
            edit.Text = edit.Name;
            edit.Show();
        }
    }
}
