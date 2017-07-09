using System;


namespace CPSControlLibrary
{
    class IOport : Port
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
            EditParameters edit = new EditParameters();
            edit.Show();
        }
    }
}
