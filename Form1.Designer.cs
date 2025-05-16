namespace ZeroXLauncher
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dungeonForm1 = new ReaLTaiizor.Forms.DungeonForm();
            txtConsola = new ReaLTaiizor.Controls.MoonTextBox();
            cbRam = new ReaLTaiizor.Controls.DungeonComboBox();
            btnUpdateJava = new ReaLTaiizor.Controls.ParrotSuperButton();
            btnLaunch = new ReaLTaiizor.Controls.DreamButton();
            txtUser = new ReaLTaiizor.Controls.DungeonTextBox();
            cbVersion = new ReaLTaiizor.Controls.DungeonComboBox();
            cbPerfiles = new ReaLTaiizor.Controls.DungeonComboBox();
            parrotPictureBox1 = new ReaLTaiizor.Controls.ParrotPictureBox();
            dungeonForm1.SuspendLayout();
            SuspendLayout();
            // 
            // dungeonForm1
            // 
            dungeonForm1.BackColor = Color.Black;
            dungeonForm1.BorderColor = Color.FromArgb(38, 38, 38);
            dungeonForm1.Controls.Add(parrotPictureBox1);
            dungeonForm1.Controls.Add(cbPerfiles);
            dungeonForm1.Controls.Add(txtConsola);
            dungeonForm1.Controls.Add(cbRam);
            dungeonForm1.Controls.Add(btnUpdateJava);
            dungeonForm1.Controls.Add(btnLaunch);
            dungeonForm1.Controls.Add(txtUser);
            dungeonForm1.Controls.Add(cbVersion);
            dungeonForm1.Dock = DockStyle.Fill;
            dungeonForm1.FillEdgeColorA = Color.FromArgb(69, 68, 63);
            dungeonForm1.FillEdgeColorB = Color.FromArgb(69, 68, 63);
            dungeonForm1.Font = new Font("Segoe UI", 9F);
            dungeonForm1.FooterEdgeColor = Color.FromArgb(69, 68, 63);
            dungeonForm1.ForeColor = Color.FromArgb(223, 219, 210);
            dungeonForm1.HeaderEdgeColorA = Color.FromArgb(87, 85, 77);
            dungeonForm1.HeaderEdgeColorB = Color.FromArgb(69, 68, 63);
            dungeonForm1.Location = new Point(0, 0);
            dungeonForm1.Name = "dungeonForm1";
            dungeonForm1.Padding = new Padding(20, 56, 20, 16);
            dungeonForm1.RoundCorners = true;
            dungeonForm1.Sizable = true;
            dungeonForm1.Size = new Size(767, 450);
            dungeonForm1.SmartBounds = true;
            dungeonForm1.StartPosition = FormStartPosition.WindowsDefaultLocation;
            dungeonForm1.TabIndex = 0;
            dungeonForm1.Text = "ZeroXLauncher";
            dungeonForm1.TitleColor = Color.FromArgb(223, 219, 210);
            // 
            // txtConsola
            // 
            txtConsola.BackColor = Color.Black;
            txtConsola.BorderColor = Color.LightGray;
            txtConsola.BorderStyle = BorderStyle.FixedSingle;
            txtConsola.Font = new Font("Microsoft Sans Serif", 8F);
            txtConsola.ForeColor = Color.Lime;
            txtConsola.Location = new Point(268, 214);
            txtConsola.Multiline = true;
            txtConsola.Name = "txtConsola";
            txtConsola.ReadOnly = true;
            txtConsola.Size = new Size(476, 179);
            txtConsola.TabIndex = 6;
            // 
            // cbRam
            // 
            cbRam.BackColor = Color.FromArgb(246, 246, 246);
            cbRam.ColorA = Color.FromArgb(246, 132, 85);
            cbRam.ColorB = Color.FromArgb(231, 108, 57);
            cbRam.ColorC = Color.FromArgb(242, 241, 240);
            cbRam.ColorD = Color.FromArgb(253, 252, 252);
            cbRam.ColorE = Color.FromArgb(239, 237, 236);
            cbRam.ColorF = Color.FromArgb(180, 180, 180);
            cbRam.ColorG = Color.FromArgb(119, 119, 118);
            cbRam.ColorH = Color.FromArgb(224, 222, 220);
            cbRam.ColorI = Color.FromArgb(250, 249, 249);
            cbRam.DrawMode = DrawMode.OwnerDrawFixed;
            cbRam.DropDownHeight = 100;
            cbRam.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRam.Font = new Font("Segoe UI", 10F);
            cbRam.ForeColor = Color.FromArgb(76, 76, 97);
            cbRam.FormattingEnabled = true;
            cbRam.HoverSelectionColor = Color.Empty;
            cbRam.IntegralHeight = false;
            cbRam.ItemHeight = 20;
            cbRam.Location = new Point(23, 119);
            cbRam.Name = "cbRam";
            cbRam.Size = new Size(239, 26);
            cbRam.StartIndex = 0;
            cbRam.TabIndex = 4;
            // 
            // btnUpdateJava
            // 
            btnUpdateJava.BackgroundColor = Color.Maroon;
            btnUpdateJava.ButtonImage = Properties.Resources.descargar;
            btnUpdateJava.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            btnUpdateJava.ButtonStyle = ReaLTaiizor.Controls.ParrotSuperButton.Style.RoundedEdges;
            btnUpdateJava.ButtonText = "Update JAVA";
            btnUpdateJava.CornerRadius = 5;
            btnUpdateJava.Horizontal_Alignment = StringAlignment.Center;
            btnUpdateJava.HoverBackgroundColor = Color.FromArgb(102, 217, 174);
            btnUpdateJava.HoverTextColor = Color.White;
            btnUpdateJava.ImagePosition = ReaLTaiizor.Controls.ParrotSuperButton.ImgPosition.Left;
            btnUpdateJava.Location = new Point(628, 59);
            btnUpdateJava.Name = "btnUpdateJava";
            btnUpdateJava.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            btnUpdateJava.SelectedBackColor = Color.LimeGreen;
            btnUpdateJava.SelectedTextColor = Color.White;
            btnUpdateJava.Size = new Size(116, 40);
            btnUpdateJava.SuperSelected = false;
            btnUpdateJava.TabIndex = 3;
            btnUpdateJava.TextColor = Color.White;
            btnUpdateJava.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnUpdateJava.Vertical_Alignment = StringAlignment.Center;
            btnUpdateJava.Click += btnUpdateJava_Click;
            // 
            // btnLaunch
            // 
            btnLaunch.ColorA = Color.FromArgb(31, 31, 31);
            btnLaunch.ColorB = Color.FromArgb(41, 41, 41);
            btnLaunch.ColorC = Color.FromArgb(51, 51, 51);
            btnLaunch.ColorD = Color.FromArgb(0, 0, 0, 0);
            btnLaunch.ColorE = Color.FromArgb(25, 255, 255, 255);
            btnLaunch.ForeColor = Color.FromArgb(40, 218, 255);
            btnLaunch.Location = new Point(505, 159);
            btnLaunch.Name = "btnLaunch";
            btnLaunch.Size = new Size(239, 40);
            btnLaunch.TabIndex = 2;
            btnLaunch.Text = "Lanzar";
            btnLaunch.UseVisualStyleBackColor = true;
            btnLaunch.Click += btnLaunch_Click;
            // 
            // txtUser
            // 
            txtUser.BackColor = Color.Transparent;
            txtUser.BorderColor = Color.FromArgb(180, 180, 180);
            txtUser.EdgeColor = Color.White;
            txtUser.Font = new Font("Tahoma", 11F);
            txtUser.ForeColor = Color.DimGray;
            txtUser.Location = new Point(23, 165);
            txtUser.MaxLength = 32767;
            txtUser.Multiline = false;
            txtUser.Name = "txtUser";
            txtUser.ReadOnly = false;
            txtUser.Size = new Size(239, 28);
            txtUser.TabIndex = 1;
            txtUser.TextAlignment = HorizontalAlignment.Left;
            txtUser.UseSystemPasswordChar = false;
            // 
            // cbVersion
            // 
            cbVersion.BackColor = Color.FromArgb(246, 246, 246);
            cbVersion.ColorA = Color.FromArgb(246, 132, 85);
            cbVersion.ColorB = Color.FromArgb(231, 108, 57);
            cbVersion.ColorC = Color.FromArgb(242, 241, 240);
            cbVersion.ColorD = Color.FromArgb(253, 252, 252);
            cbVersion.ColorE = Color.FromArgb(239, 237, 236);
            cbVersion.ColorF = Color.FromArgb(180, 180, 180);
            cbVersion.ColorG = Color.FromArgb(119, 119, 118);
            cbVersion.ColorH = Color.FromArgb(224, 222, 220);
            cbVersion.ColorI = Color.FromArgb(250, 249, 249);
            cbVersion.DrawMode = DrawMode.OwnerDrawFixed;
            cbVersion.DropDownHeight = 100;
            cbVersion.DropDownStyle = ComboBoxStyle.DropDownList;
            cbVersion.Font = new Font("Segoe UI", 10F);
            cbVersion.ForeColor = Color.FromArgb(76, 76, 97);
            cbVersion.FormattingEnabled = true;
            cbVersion.HoverSelectionColor = Color.Empty;
            cbVersion.IntegralHeight = false;
            cbVersion.ItemHeight = 20;
            cbVersion.Location = new Point(23, 75);
            cbVersion.Name = "cbVersion";
            cbVersion.Size = new Size(239, 26);
            cbVersion.StartIndex = 0;
            cbVersion.TabIndex = 0;
            // 
            // cbPerfiles
            // 
            cbPerfiles.BackColor = Color.FromArgb(246, 246, 246);
            cbPerfiles.ColorA = Color.FromArgb(246, 132, 85);
            cbPerfiles.ColorB = Color.FromArgb(231, 108, 57);
            cbPerfiles.ColorC = Color.FromArgb(242, 241, 240);
            cbPerfiles.ColorD = Color.FromArgb(253, 252, 252);
            cbPerfiles.ColorE = Color.FromArgb(239, 237, 236);
            cbPerfiles.ColorF = Color.FromArgb(180, 180, 180);
            cbPerfiles.ColorG = Color.FromArgb(119, 119, 118);
            cbPerfiles.ColorH = Color.FromArgb(224, 222, 220);
            cbPerfiles.ColorI = Color.FromArgb(250, 249, 249);
            cbPerfiles.DrawMode = DrawMode.OwnerDrawFixed;
            cbPerfiles.DropDownHeight = 100;
            cbPerfiles.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPerfiles.Font = new Font("Segoe UI", 10F);
            cbPerfiles.ForeColor = Color.FromArgb(76, 76, 97);
            cbPerfiles.FormattingEnabled = true;
            cbPerfiles.HoverSelectionColor = Color.Empty;
            cbPerfiles.IntegralHeight = false;
            cbPerfiles.ItemHeight = 20;
            cbPerfiles.Location = new Point(268, 167);
            cbPerfiles.Name = "cbPerfiles";
            cbPerfiles.Size = new Size(100, 26);
            cbPerfiles.StartIndex = 0;
            cbPerfiles.TabIndex = 7;
            // 
            // parrotPictureBox1
            // 
            parrotPictureBox1.ColorLeft = Color.DodgerBlue;
            parrotPictureBox1.ColorRight = Color.DodgerBlue;
            parrotPictureBox1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            parrotPictureBox1.FilterAlpha = 200;
            parrotPictureBox1.FilterEnabled = true;
            parrotPictureBox1.Image = null;
            parrotPictureBox1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            parrotPictureBox1.IsElipse = false;
            parrotPictureBox1.IsParallax = false;
            parrotPictureBox1.Location = new Point(377, 165);
            parrotPictureBox1.Name = "parrotPictureBox1";
            parrotPictureBox1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            parrotPictureBox1.Size = new Size(36, 28);
            parrotPictureBox1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            parrotPictureBox1.TabIndex = 8;
            parrotPictureBox1.Text = "parrotPictureBox1";
            parrotPictureBox1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(767, 450);
            Controls.Add(dungeonForm1);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(261, 65);
            Name = "Form1";
            Text = "ZeroXLauncher";
            TransparencyKey = Color.Fuchsia;
            dungeonForm1.ResumeLayout(false);
            dungeonForm1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Forms.DungeonForm dungeonForm1;
        private ReaLTaiizor.Controls.DungeonComboBox cbVersion;
        private ReaLTaiizor.Controls.DungeonTextBox txtUser;
        private ReaLTaiizor.Controls.DreamButton btnLaunch;
        private ReaLTaiizor.Controls.ParrotSuperButton btnUpdateJava;
        private ReaLTaiizor.Controls.DungeonComboBox cbRam;
        private ReaLTaiizor.Controls.MoonTextBox txtConsola;
        private ReaLTaiizor.Controls.ParrotPictureBox parrotPictureBox1;
        private ReaLTaiizor.Controls.DungeonComboBox cbPerfiles;
    }
}
