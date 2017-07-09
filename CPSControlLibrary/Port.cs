using System.Drawing;
using System.Windows.Forms;

namespace CPSControlLibrary
{
    public abstract class Port : UserControl
<<<<<<< HEAD
    { 
=======
    {
        private int index;
        private double data;
        //Index属性
        public int Index
        {
            get
            {
                return index;
            }
            set
            {
                index = value;
            }
        }
        //Value属性
        public double Value
        {
            get
            {
                return data;
            }
            set
            {
                data = value;
            }
        }
>>>>>>> dec066efce2025b51169f1e24e50c6d6c73fa187
        protected System.ComponentModel.IContainer components = null;
        Point pPoint, cPoint;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        public void InitializeComponent()
        {
            this.label = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.Location = new System.Drawing.Point(0, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(70, 30);
            this.label.TabIndex = 0;

            this.label.Text = "port";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(0, 25);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(50, 50);
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;

            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            // 
            // Port
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.label);

            this.Name = "Port";
            this.Size = new System.Drawing.Size(50, 70);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

            this.AllowDrop = true;
            this.pictureBox.MouseDown += Mouse_Down;
            this.pictureBox.MouseMove += Mouse_Move;
            this.pictureBox.MouseUp += Mouse_Up;
        }
        private void Mouse_Down(object sender, MouseEventArgs e)
        {
            pPoint = Cursor.Position;
        }
        
        private void Mouse_Move(object sender, MouseEventArgs e)
        {
            //当鼠标左键按下时才触发
            if (e.Button == MouseButtons.Left)
            {
                cPoint = Cursor.Position; //获得当前鼠标位置
                int x = cPoint.X - pPoint.X;
                int y = cPoint.Y - pPoint.Y;
                this.Location = new Point(this.Location.X + x, this.Location.Y + y);
                pPoint = cPoint;
            }
        }

        private void Mouse_Up(object sender, MouseEventArgs e)
        {

        }
        protected void Initial_Context()
        {

        }
        public System.Windows.Forms.Label label;
        public System.Windows.Forms.PictureBox pictureBox;

    }

}
