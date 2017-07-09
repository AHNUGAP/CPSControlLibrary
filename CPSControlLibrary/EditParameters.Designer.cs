namespace CPSControlLibrary
{
    partial class EditParameters
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_width = new System.Windows.Forms.TextBox();
            this.label_width = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_cancle = new System.Windows.Forms.Button();
            this.button_help = new System.Windows.Forms.Button();
            this.button_references = new System.Windows.Forms.Button();
            this.button_defaults = new System.Windows.Forms.Button();
            this.button_remove = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.button_commit = new System.Windows.Forms.Button();
            this.textBox_value = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_width
            // 
            this.textBox_width.Location = new System.Drawing.Point(180, 55);
            this.textBox_width.Name = "textBox_width";
            this.textBox_width.Size = new System.Drawing.Size(472, 21);
            this.textBox_width.TabIndex = 35;
            this.textBox_width.Text = "-1";
            this.textBox_width.Visible = false;
            // 
            // label_width
            // 
            this.label_width.AutoSize = true;
            this.label_width.Location = new System.Drawing.Point(132, 64);
            this.label_width.Name = "label_width";
            this.label_width.Size = new System.Drawing.Size(41, 12);
            this.label_width.TabIndex = 34;
            this.label_width.Text = "width:";
            this.label_width.Visible = false;
            // 
            // label2
            // 
            this.label2.Image = global::CPSControlLibrary.Properties.Resources.wenhao;
            this.label2.Location = new System.Drawing.Point(21, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 41);
            this.label2.TabIndex = 33;
            // 
            // button_cancle
            // 
            this.button_cancle.Location = new System.Drawing.Point(587, 94);
            this.button_cancle.Name = "button_cancle";
            this.button_cancle.Size = new System.Drawing.Size(75, 23);
            this.button_cancle.TabIndex = 32;
            this.button_cancle.Text = "Cancle";
            this.button_cancle.UseVisualStyleBackColor = true;
            // 
            // button_help
            // 
            this.button_help.Location = new System.Drawing.Point(497, 94);
            this.button_help.Name = "button_help";
            this.button_help.Size = new System.Drawing.Size(75, 23);
            this.button_help.TabIndex = 31;
            this.button_help.Text = "Help";
            this.button_help.UseVisualStyleBackColor = true;
            // 
            // button_references
            // 
            this.button_references.Location = new System.Drawing.Point(406, 94);
            this.button_references.Name = "button_references";
            this.button_references.Size = new System.Drawing.Size(75, 23);
            this.button_references.TabIndex = 30;
            this.button_references.Text = "Preferences";
            this.button_references.UseVisualStyleBackColor = true;
            // 
            // button_defaults
            // 
            this.button_defaults.Location = new System.Drawing.Point(316, 94);
            this.button_defaults.Name = "button_defaults";
            this.button_defaults.Size = new System.Drawing.Size(75, 23);
            this.button_defaults.TabIndex = 29;
            this.button_defaults.Text = "Defaults";
            this.button_defaults.UseVisualStyleBackColor = true;
            // 
            // button_remove
            // 
            this.button_remove.Location = new System.Drawing.Point(226, 94);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(75, 23);
            this.button_remove.TabIndex = 28;
            this.button_remove.Text = "Remove";
            this.button_remove.UseVisualStyleBackColor = true;
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(134, 94);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 23);
            this.button_add.TabIndex = 27;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            // 
            // button_commit
            // 
            this.button_commit.Location = new System.Drawing.Point(40, 94);
            this.button_commit.Name = "button_commit";
            this.button_commit.Size = new System.Drawing.Size(75, 23);
            this.button_commit.TabIndex = 26;
            this.button_commit.Text = "Commit";
            this.button_commit.UseVisualStyleBackColor = true;
            this.button_commit.Click += new System.EventHandler(this.button_commit_Click);
            // 
            // textBox_value
            // 
            this.textBox_value.Location = new System.Drawing.Point(180, 32);
            this.textBox_value.Name = "textBox_value";
            this.textBox_value.Size = new System.Drawing.Size(472, 21);
            this.textBox_value.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 24;
            this.label1.Text = "defaultValue:";
            // 
            // EditParameters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 149);
            this.Controls.Add(this.textBox_width);
            this.Controls.Add(this.label_width);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_cancle);
            this.Controls.Add(this.button_help);
            this.Controls.Add(this.button_references);
            this.Controls.Add(this.button_defaults);
            this.Controls.Add(this.button_remove);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.button_commit);
            this.Controls.Add(this.textBox_value);
            this.Controls.Add(this.label1);
            this.Name = "EditParameters";
            this.Text = "EditParameters";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox textBox_width;
        public System.Windows.Forms.Label label_width;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_cancle;
        private System.Windows.Forms.Button button_help;
        private System.Windows.Forms.Button button_references;
        private System.Windows.Forms.Button button_defaults;
        private System.Windows.Forms.Button button_remove;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_commit;
        private System.Windows.Forms.TextBox textBox_value;
        private System.Windows.Forms.Label label1;
    }
}