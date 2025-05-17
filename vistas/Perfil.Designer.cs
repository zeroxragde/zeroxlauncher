namespace ZeroXLauncher.vistas
{
    partial class Perfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Perfil));
            wForm = new ReaLTaiizor.Forms.ThemeForm();
            cbRam = new ReaLTaiizor.Controls.HopeComboBox();
            hopeTextBox2 = new ReaLTaiizor.Controls.HopeTextBox();
            txtUser = new ReaLTaiizor.Controls.HopeTextBox();
            btnSave = new ReaLTaiizor.Controls.ParrotPictureBox();
            btnDel = new ReaLTaiizor.Controls.ParrotPictureBox();
            btnClose = new ReaLTaiizor.Controls.ParrotPictureBox();
            btnUpdateUUID = new ReaLTaiizor.Controls.ParrotPictureBox();
            wForm.SuspendLayout();
            SuspendLayout();
            // 
            // wForm
            // 
            wForm.BackColor = Color.FromArgb(32, 41, 50);
            wForm.Controls.Add(btnUpdateUUID);
            wForm.Controls.Add(cbRam);
            wForm.Controls.Add(hopeTextBox2);
            wForm.Controls.Add(txtUser);
            wForm.Controls.Add(btnSave);
            wForm.Controls.Add(btnDel);
            wForm.Controls.Add(btnClose);
            wForm.Dock = DockStyle.Fill;
            wForm.Font = new Font("Microsoft Sans Serif", 9F);
            wForm.Image = (Image)resources.GetObject("wForm.Image");
            wForm.Location = new Point(0, 0);
            wForm.Name = "wForm";
            wForm.Padding = new Padding(10, 70, 10, 9);
            wForm.RoundCorners = true;
            wForm.Sizable = true;
            wForm.Size = new Size(308, 390);
            wForm.SmartBounds = true;
            wForm.StartPosition = FormStartPosition.CenterParent;
            wForm.TabIndex = 0;
            wForm.Text = "winPerfil";
            // 
            // cbRam
            // 
            cbRam.DrawMode = DrawMode.OwnerDrawFixed;
            cbRam.FlatStyle = FlatStyle.Flat;
            cbRam.Font = new Font("Segoe UI", 12F);
            cbRam.FormattingEnabled = true;
            cbRam.ItemHeight = 30;
            cbRam.Location = new Point(12, 201);
            cbRam.Name = "cbRam";
            cbRam.Size = new Size(114, 36);
            cbRam.TabIndex = 6;
            // 
            // hopeTextBox2
            // 
            hopeTextBox2.BackColor = Color.White;
            hopeTextBox2.BaseColor = Color.FromArgb(44, 55, 66);
            hopeTextBox2.BorderColorA = Color.FromArgb(64, 158, 255);
            hopeTextBox2.BorderColorB = Color.FromArgb(220, 223, 230);
            hopeTextBox2.Font = new Font("Segoe UI", 12F);
            hopeTextBox2.ForeColor = Color.FromArgb(48, 49, 51);
            hopeTextBox2.Hint = "UUID";
            hopeTextBox2.Location = new Point(12, 147);
            hopeTextBox2.MaxLength = 32767;
            hopeTextBox2.Multiline = false;
            hopeTextBox2.Name = "hopeTextBox2";
            hopeTextBox2.PasswordChar = '\0';
            hopeTextBox2.ScrollBars = ScrollBars.None;
            hopeTextBox2.SelectedText = "";
            hopeTextBox2.SelectionLength = 0;
            hopeTextBox2.SelectionStart = 0;
            hopeTextBox2.Size = new Size(238, 38);
            hopeTextBox2.TabIndex = 5;
            hopeTextBox2.TabStop = false;
            hopeTextBox2.UseSystemPasswordChar = false;
            // 
            // txtUser
            // 
            txtUser.BackColor = Color.White;
            txtUser.BaseColor = Color.FromArgb(44, 55, 66);
            txtUser.BorderColorA = Color.FromArgb(64, 158, 255);
            txtUser.BorderColorB = Color.FromArgb(220, 223, 230);
            txtUser.Font = new Font("Segoe UI", 12F);
            txtUser.ForeColor = Color.FromArgb(48, 49, 51);
            txtUser.Hint = "Nombre";
            txtUser.Location = new Point(12, 89);
            txtUser.MaxLength = 32767;
            txtUser.Multiline = false;
            txtUser.Name = "txtUser";
            txtUser.PasswordChar = '\0';
            txtUser.ScrollBars = ScrollBars.None;
            txtUser.SelectedText = "";
            txtUser.SelectionLength = 0;
            txtUser.SelectionStart = 0;
            txtUser.Size = new Size(212, 38);
            txtUser.TabIndex = 4;
            txtUser.TabStop = false;
            txtUser.UseSystemPasswordChar = false;
            // 
            // btnSave
            // 
            btnSave.ColorLeft = Color.DodgerBlue;
            btnSave.ColorRight = Color.DodgerBlue;
            btnSave.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            btnSave.FilterAlpha = 200;
            btnSave.FilterEnabled = false;
            btnSave.Image = Properties.Resources.save;
            btnSave.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            btnSave.IsElipse = false;
            btnSave.IsParallax = false;
            btnSave.Location = new Point(13, 293);
            btnSave.Name = "btnSave";
            btnSave.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            btnSave.Size = new Size(70, 68);
            btnSave.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            btnSave.TabIndex = 3;
            btnSave.Text = "parrotPictureBox2";
            btnSave.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // btnDel
            // 
            btnDel.ColorLeft = Color.DodgerBlue;
            btnDel.ColorRight = Color.DodgerBlue;
            btnDel.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            btnDel.FilterAlpha = 200;
            btnDel.FilterEnabled = false;
            btnDel.Image = Properties.Resources.del;
            btnDel.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            btnDel.IsElipse = false;
            btnDel.IsParallax = false;
            btnDel.Location = new Point(216, 279);
            btnDel.Name = "btnDel";
            btnDel.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            btnDel.Size = new Size(79, 82);
            btnDel.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            btnDel.TabIndex = 2;
            btnDel.Text = "parrotPictureBox1";
            btnDel.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // btnClose
            // 
            btnClose.ColorLeft = Color.DodgerBlue;
            btnClose.ColorRight = Color.DodgerBlue;
            btnClose.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            btnClose.FilterAlpha = 200;
            btnClose.FilterEnabled = false;
            btnClose.Image = Properties.Resources.close1;
            btnClose.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            btnClose.IsElipse = false;
            btnClose.IsParallax = false;
            btnClose.Location = new Point(265, 12);
            btnClose.Name = "btnClose";
            btnClose.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            btnClose.Size = new Size(31, 32);
            btnClose.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            btnClose.TabIndex = 0;
            btnClose.Text = "parrotPictureBox1";
            btnClose.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnClose.Click += btnClose_Click;
            // 
            // btnUpdateUUID
            // 
            btnUpdateUUID.ColorLeft = Color.DodgerBlue;
            btnUpdateUUID.ColorRight = Color.DodgerBlue;
            btnUpdateUUID.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            btnUpdateUUID.FilterAlpha = 200;
            btnUpdateUUID.FilterEnabled = false;
            btnUpdateUUID.Image = Properties.Resources.refresh;
            btnUpdateUUID.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            btnUpdateUUID.IsElipse = false;
            btnUpdateUUID.IsParallax = false;
            btnUpdateUUID.Location = new Point(256, 147);
            btnUpdateUUID.Name = "btnUpdateUUID";
            btnUpdateUUID.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            btnUpdateUUID.Size = new Size(40, 39);
            btnUpdateUUID.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            btnUpdateUUID.TabIndex = 7;
            btnUpdateUUID.Text = "parrotPictureBox1";
            btnUpdateUUID.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // Perfil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(308, 390);
            Controls.Add(wForm);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(261, 61);
            Name = "Perfil";
            StartPosition = FormStartPosition.CenterParent;
            Text = "winPerfil";
            TransparencyKey = Color.Fuchsia;
            wForm.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Forms.ThemeForm wForm;
        private ReaLTaiizor.Controls.ParrotPictureBox btnClose;
        private ReaLTaiizor.Controls.ParrotPictureBox btnSave;
        private ReaLTaiizor.Controls.ParrotPictureBox btnDel;
        private ReaLTaiizor.Controls.HopeTextBox hopeTextBox2;
        private ReaLTaiizor.Controls.HopeTextBox txtUser;
        private ReaLTaiizor.Controls.HopeComboBox cbRam;
        private ReaLTaiizor.Controls.ParrotPictureBox btnUpdateUUID;
    }
}