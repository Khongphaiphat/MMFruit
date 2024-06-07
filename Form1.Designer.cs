namespace MMFruit
{
    partial class menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            this.btn_start = new System.Windows.Forms.PictureBox();
            this.btn_exit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.Image = global::MMFruit.Properties.Resources.normal_start;
            this.btn_start.Location = new System.Drawing.Point(240, 286);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(304, 84);
            this.btn_start.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_start.TabIndex = 0;
            this.btn_start.TabStop = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            this.btn_start.MouseLeave += new System.EventHandler(this.btn_start_MouseLeave);
            this.btn_start.MouseHover += new System.EventHandler(this.btn_start_MouseHover);
            // 
            // btn_exit
            // 
            this.btn_exit.Image = global::MMFruit.Properties.Resources.normal_exit;
            this.btn_exit.Location = new System.Drawing.Point(240, 403);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(304, 84);
            this.btn_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_exit.TabIndex = 1;
            this.btn_exit.TabStop = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            this.btn_exit.MouseLeave += new System.EventHandler(this.btn_exit_MouseLeave);
            this.btn_exit.MouseHover += new System.EventHandler(this.btn_exit_MouseHover);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MMFruit.Properties.Resources.main_menu_png;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_start);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memory Matching Fruits";
            ((System.ComponentModel.ISupportInitialize)(this.btn_start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btn_start;
        private System.Windows.Forms.PictureBox btn_exit;
    }
}

