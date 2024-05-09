using Rucon.Properties;

namespace Rucon
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.siticonePictureBox3 = new ns1.SiticonePictureBox();
            this.siticonePictureBox2 = new ns1.SiticonePictureBox();
            this.siticonePictureBox1 = new ns1.SiticonePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // siticonePictureBox3
            // 
            this.siticonePictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.siticonePictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("siticonePictureBox3.BackgroundImage")));
            this.siticonePictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.siticonePictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.siticonePictureBox3.Location = new System.Drawing.Point(186, 12);
            this.siticonePictureBox3.Name = "siticonePictureBox3";
            this.siticonePictureBox3.ShadowDecoration.Parent = this.siticonePictureBox3;
            this.siticonePictureBox3.Size = new System.Drawing.Size(75, 75);
            this.siticonePictureBox3.TabIndex = 2;
            this.siticonePictureBox3.TabStop = false;
            this.siticonePictureBox3.UseTransparentBackground = true;
            this.siticonePictureBox3.Click += new System.EventHandler(this.siticonePictureBox3_Click);
            // 
            // siticonePictureBox2
            // 
            this.siticonePictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.siticonePictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("siticonePictureBox2.BackgroundImage")));
            this.siticonePictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.siticonePictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.siticonePictureBox2.Location = new System.Drawing.Point(99, 12);
            this.siticonePictureBox2.Name = "siticonePictureBox2";
            this.siticonePictureBox2.ShadowDecoration.Parent = this.siticonePictureBox2;
            this.siticonePictureBox2.Size = new System.Drawing.Size(75, 75);
            this.siticonePictureBox2.TabIndex = 1;
            this.siticonePictureBox2.TabStop = false;
            this.siticonePictureBox2.UseTransparentBackground = true;
            this.siticonePictureBox2.Click += new System.EventHandler(this.siticonePictureBox2_Click);
            // 
            // siticonePictureBox1
            // 
            this.siticonePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.siticonePictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("siticonePictureBox1.BackgroundImage")));
            this.siticonePictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.siticonePictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.siticonePictureBox1.Location = new System.Drawing.Point(12, 12);
            this.siticonePictureBox1.Name = "siticonePictureBox1";
            this.siticonePictureBox1.ShadowDecoration.Parent = this.siticonePictureBox1;
            this.siticonePictureBox1.Size = new System.Drawing.Size(75, 75);
            this.siticonePictureBox1.TabIndex = 0;
            this.siticonePictureBox1.TabStop = false;
            this.siticonePictureBox1.UseTransparentBackground = true;
            this.siticonePictureBox1.Click += new System.EventHandler(this.siticonePictureBox1_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(274, 99);
            this.ControlBox = false;
            this.Controls.Add(this.siticonePictureBox3);
            this.Controls.Add(this.siticonePictureBox2);
            this.Controls.Add(this.siticonePictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "MenuForm";
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ns1.SiticonePictureBox siticonePictureBox1;
        private ns1.SiticonePictureBox siticonePictureBox2;
        private ns1.SiticonePictureBox siticonePictureBox3;
    }
}