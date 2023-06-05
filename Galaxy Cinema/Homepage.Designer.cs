namespace Galaxy_Cinema
{
    partial class Homepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage));
            this.pnlNav = new System.Windows.Forms.Panel();
            this.pnlComing = new System.Windows.Forms.Panel();
            this.btnComing = new System.Windows.Forms.Button();
            this.pnlShowing = new System.Windows.Forms.Panel();
            this.btnShowing = new System.Windows.Forms.Button();
            this.pnlHome = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.pnlHead = new System.Windows.Forms.Panel();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.pBComing = new System.Windows.Forms.PictureBox();
            this.pBShowing = new System.Windows.Forms.PictureBox();
            this.pBHome = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ucTextBox1 = new Galaxy_Cinema.Controls.UCTextBox();
            this.pnlNav.SuspendLayout();
            this.pnlHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBComing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBShowing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlNav
            // 
            this.pnlNav.Controls.Add(this.pBComing);
            this.pnlNav.Controls.Add(this.pnlComing);
            this.pnlNav.Controls.Add(this.btnComing);
            this.pnlNav.Controls.Add(this.pBShowing);
            this.pnlNav.Controls.Add(this.pnlShowing);
            this.pnlNav.Controls.Add(this.btnShowing);
            this.pnlNav.Controls.Add(this.pBHome);
            this.pnlNav.Controls.Add(this.pnlHome);
            this.pnlNav.Controls.Add(this.pictureBox3);
            this.pnlNav.Controls.Add(this.btnHome);
            this.pnlNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlNav.Location = new System.Drawing.Point(0, 106);
            this.pnlNav.Margin = new System.Windows.Forms.Padding(0);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(219, 944);
            this.pnlNav.TabIndex = 1;
            // 
            // pnlComing
            // 
            this.pnlComing.Location = new System.Drawing.Point(0, 194);
            this.pnlComing.Name = "pnlComing";
            this.pnlComing.Size = new System.Drawing.Size(10, 87);
            this.pnlComing.TabIndex = 11;
            this.pnlComing.Visible = false;
            // 
            // btnComing
            // 
            this.btnComing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComing.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComing.ForeColor = System.Drawing.Color.White;
            this.btnComing.Location = new System.Drawing.Point(0, 194);
            this.btnComing.Name = "btnComing";
            this.btnComing.Size = new System.Drawing.Size(219, 87);
            this.btnComing.TabIndex = 9;
            this.btnComing.Text = "Sắp chiếu";
            this.btnComing.UseVisualStyleBackColor = true;
            this.btnComing.Visible = false;
            this.btnComing.Click += new System.EventHandler(this.btnComing_Click);
            // 
            // pnlShowing
            // 
            this.pnlShowing.Location = new System.Drawing.Point(0, 106);
            this.pnlShowing.Name = "pnlShowing";
            this.pnlShowing.Size = new System.Drawing.Size(10, 87);
            this.pnlShowing.TabIndex = 8;
            this.pnlShowing.Visible = false;
            // 
            // btnShowing
            // 
            this.btnShowing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowing.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowing.ForeColor = System.Drawing.Color.White;
            this.btnShowing.Location = new System.Drawing.Point(0, 106);
            this.btnShowing.Name = "btnShowing";
            this.btnShowing.Size = new System.Drawing.Size(219, 87);
            this.btnShowing.TabIndex = 6;
            this.btnShowing.Text = "Đang chiếu";
            this.btnShowing.UseVisualStyleBackColor = true;
            this.btnShowing.Visible = false;
            this.btnShowing.Click += new System.EventHandler(this.btnShowing_Click);
            // 
            // pnlHome
            // 
            this.pnlHome.Location = new System.Drawing.Point(0, 22);
            this.pnlHome.Name = "pnlHome";
            this.pnlHome.Size = new System.Drawing.Size(10, 87);
            this.pnlHome.TabIndex = 5;
            // 
            // btnHome
            // 
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(0, 22);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(219, 87);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Trang chủ";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.Home_Click);
            // 
            // pnlHead
            // 
            this.pnlHead.Controls.Add(this.ucTextBox1);
            this.pnlHead.Controls.Add(this.pictureBox2);
            this.pnlHead.Controls.Add(this.pictureBox1);
            this.pnlHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHead.Location = new System.Drawing.Point(0, 0);
            this.pnlHead.Margin = new System.Windows.Forms.Padding(0);
            this.pnlHead.Name = "pnlHead";
            this.pnlHead.Size = new System.Drawing.Size(1924, 106);
            this.pnlHead.TabIndex = 0;
            // 
            // pnlContainer
            // 
            this.pnlContainer.AutoScroll = true;
            this.pnlContainer.Location = new System.Drawing.Point(219, 106);
            this.pnlContainer.Margin = new System.Windows.Forms.Padding(0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1705, 944);
            this.pnlContainer.TabIndex = 2;
            // 
            // pBComing
            // 
            this.pBComing.Image = global::Galaxy_Cinema.Properties.Resources.icon_comming;
            this.pBComing.Location = new System.Drawing.Point(16, 219);
            this.pBComing.Name = "pBComing";
            this.pBComing.Size = new System.Drawing.Size(38, 35);
            this.pBComing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBComing.TabIndex = 10;
            this.pBComing.TabStop = false;
            this.pBComing.Visible = false;
            // 
            // pBShowing
            // 
            this.pBShowing.Image = global::Galaxy_Cinema.Properties.Resources.icon_showing;
            this.pBShowing.Location = new System.Drawing.Point(16, 131);
            this.pBShowing.Name = "pBShowing";
            this.pBShowing.Size = new System.Drawing.Size(38, 35);
            this.pBShowing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBShowing.TabIndex = 7;
            this.pBShowing.TabStop = false;
            this.pBShowing.Visible = false;
            // 
            // pBHome
            // 
            this.pBHome.Image = global::Galaxy_Cinema.Properties.Resources.icon_home;
            this.pBHome.Location = new System.Drawing.Point(16, 47);
            this.pBHome.Name = "pBHome";
            this.pBHome.Size = new System.Drawing.Size(38, 35);
            this.pBHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBHome.TabIndex = 4;
            this.pBHome.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Galaxy_Cinema.Properties.Resources.GalaxyPlay;
            this.pictureBox3.Location = new System.Drawing.Point(49, 756);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(131, 106);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Galaxy_Cinema.Properties.Resources.GalaxyCinema;
            this.pictureBox2.Location = new System.Drawing.Point(49, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(131, 106);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Galaxy_Cinema.Properties.Resources.icon_profile;
            this.pictureBox1.Location = new System.Drawing.Point(1808, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // ucTextBox1
            // 
            this.ucTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ucTextBox1.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(212)))), ((int)(((byte)(47)))));
            this.ucTextBox1.BorderRadius = 10;
            this.ucTextBox1.BorderSize = 2;
            this.ucTextBox1.Location = new System.Drawing.Point(283, 43);
            this.ucTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.ucTextBox1.Multiline = false;
            this.ucTextBox1.Name = "ucTextBox1";
            this.ucTextBox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.ucTextBox1.PasswordChar = false;
            this.ucTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.ucTextBox1.PlaceholderText = "";
            this.ucTextBox1.Size = new System.Drawing.Size(479, 35);
            this.ucTextBox1.TabIndex = 4;
            this.ucTextBox1.Texts = "";
            this.ucTextBox1.UnderlinedStyle = false;
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.pnlNav);
            this.Controls.Add(this.pnlHead);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Homepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Galaxy Cinema";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Homepage_Load);
            this.pnlNav.ResumeLayout(false);
            this.pnlHead.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBComing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBShowing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Panel pnlHead;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pBHome;
        private System.Windows.Forms.Panel pnlHome;
        private System.Windows.Forms.PictureBox pBComing;
        private System.Windows.Forms.Panel pnlComing;
        private System.Windows.Forms.Button btnComing;
        private System.Windows.Forms.PictureBox pBShowing;
        private System.Windows.Forms.Panel pnlShowing;
        private System.Windows.Forms.Button btnShowing;
        private Controls.UCTextBox ucTextBox1;
    }
}