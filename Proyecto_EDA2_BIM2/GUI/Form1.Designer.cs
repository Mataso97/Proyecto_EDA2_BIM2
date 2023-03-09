namespace Proyecto_EDA2_BIM2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.siticoneTabControl1 = new Siticone.Desktop.UI.WinForms.SiticoneTabControl();
            this.encryptPage = new System.Windows.Forms.TabPage();
            this.encryptPageKeyLabel = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.encryptPageKeyTB = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.encryptButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.openFileButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.plainTextRTB = new System.Windows.Forms.RichTextBox();
            this.decryptPage = new System.Windows.Forms.TabPage();
            this.SaveFileDecryptedButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.encryptedTextRTB = new System.Windows.Forms.RichTextBox();
            this.decryptPageKeyLabel = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.decryptPageKeyTB = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.decryptButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.OpenEncryptedFileButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.decryptedTextRTB = new System.Windows.Forms.RichTextBox();
            this.siticoneTabControl1.SuspendLayout();
            this.encryptPage.SuspendLayout();
            this.decryptPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticoneTabControl1
            // 
            this.siticoneTabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.siticoneTabControl1.Controls.Add(this.encryptPage);
            this.siticoneTabControl1.Controls.Add(this.decryptPage);
            this.siticoneTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticoneTabControl1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneTabControl1.ItemSize = new System.Drawing.Size(180, 40);
            this.siticoneTabControl1.Location = new System.Drawing.Point(0, 0);
            this.siticoneTabControl1.Name = "siticoneTabControl1";
            this.siticoneTabControl1.SelectedIndex = 0;
            this.siticoneTabControl1.Size = new System.Drawing.Size(959, 700);
            this.siticoneTabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.siticoneTabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.siticoneTabControl1.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.siticoneTabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.siticoneTabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.siticoneTabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.siticoneTabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.siticoneTabControl1.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.siticoneTabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.siticoneTabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.siticoneTabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.siticoneTabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.siticoneTabControl1.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.siticoneTabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.siticoneTabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.siticoneTabControl1.TabButtonSize = new System.Drawing.Size(180, 40);
            this.siticoneTabControl1.TabIndex = 3;
            this.siticoneTabControl1.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            // 
            // encryptPage
            // 
            this.encryptPage.BackColor = System.Drawing.Color.White;
            this.encryptPage.Controls.Add(this.encryptPageKeyLabel);
            this.encryptPage.Controls.Add(this.encryptPageKeyTB);
            this.encryptPage.Controls.Add(this.encryptButton);
            this.encryptPage.Controls.Add(this.openFileButton);
            this.encryptPage.Controls.Add(this.plainTextRTB);
            this.encryptPage.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encryptPage.Location = new System.Drawing.Point(184, 4);
            this.encryptPage.Name = "encryptPage";
            this.encryptPage.Padding = new System.Windows.Forms.Padding(3);
            this.encryptPage.Size = new System.Drawing.Size(771, 692);
            this.encryptPage.TabIndex = 0;
            this.encryptPage.Text = "Encriptar";
            // 
            // encryptPageKeyLabel
            // 
            this.encryptPageKeyLabel.BackColor = System.Drawing.Color.Transparent;
            this.encryptPageKeyLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encryptPageKeyLabel.Location = new System.Drawing.Point(157, 31);
            this.encryptPageKeyLabel.Name = "encryptPageKeyLabel";
            this.encryptPageKeyLabel.Size = new System.Drawing.Size(148, 30);
            this.encryptPageKeyLabel.TabIndex = 9;
            this.encryptPageKeyLabel.Text = "Clave de cifrado";
            // 
            // encryptPageKeyTB
            // 
            this.encryptPageKeyTB.AutoRoundedCorners = true;
            this.encryptPageKeyTB.BorderRadius = 17;
            this.encryptPageKeyTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.encryptPageKeyTB.DefaultText = "";
            this.encryptPageKeyTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.encryptPageKeyTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.encryptPageKeyTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.encryptPageKeyTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.encryptPageKeyTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.encryptPageKeyTB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.encryptPageKeyTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.encryptPageKeyTB.Location = new System.Drawing.Point(340, 31);
            this.encryptPageKeyTB.Margin = new System.Windows.Forms.Padding(4);
            this.encryptPageKeyTB.Name = "encryptPageKeyTB";
            this.encryptPageKeyTB.PasswordChar = '●';
            this.encryptPageKeyTB.PlaceholderText = "";
            this.encryptPageKeyTB.SelectedText = "";
            this.encryptPageKeyTB.Size = new System.Drawing.Size(275, 36);
            this.encryptPageKeyTB.TabIndex = 8;
            this.encryptPageKeyTB.UseSystemPasswordChar = true;
            // 
            // encryptButton
            // 
            this.encryptButton.AutoRoundedCorners = true;
            this.encryptButton.BorderRadius = 23;
            this.encryptButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.encryptButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.encryptButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.encryptButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.encryptButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.encryptButton.ForeColor = System.Drawing.Color.White;
            this.encryptButton.Location = new System.Drawing.Point(157, 623);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(180, 48);
            this.encryptButton.TabIndex = 6;
            this.encryptButton.Text = "Encriptar";
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // openFileButton
            // 
            this.openFileButton.AutoRoundedCorners = true;
            this.openFileButton.BorderRadius = 23;
            this.openFileButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.openFileButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.openFileButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.openFileButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.openFileButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.openFileButton.ForeColor = System.Drawing.Color.White;
            this.openFileButton.Location = new System.Drawing.Point(435, 623);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(180, 48);
            this.openFileButton.TabIndex = 5;
            this.openFileButton.Text = "Abrir archivo a encriptar";
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // plainTextRTB
            // 
            this.plainTextRTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plainTextRTB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plainTextRTB.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.plainTextRTB.Location = new System.Drawing.Point(230, 96);
            this.plainTextRTB.Name = "plainTextRTB";
            this.plainTextRTB.Size = new System.Drawing.Size(329, 505);
            this.plainTextRTB.TabIndex = 4;
            this.plainTextRTB.Text = "";
            // 
            // decryptPage
            // 
            this.decryptPage.BackColor = System.Drawing.Color.White;
            this.decryptPage.Controls.Add(this.SaveFileDecryptedButton);
            this.decryptPage.Controls.Add(this.encryptedTextRTB);
            this.decryptPage.Controls.Add(this.decryptPageKeyLabel);
            this.decryptPage.Controls.Add(this.decryptPageKeyTB);
            this.decryptPage.Controls.Add(this.decryptButton);
            this.decryptPage.Controls.Add(this.OpenEncryptedFileButton);
            this.decryptPage.Controls.Add(this.decryptedTextRTB);
            this.decryptPage.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decryptPage.Location = new System.Drawing.Point(184, 4);
            this.decryptPage.Name = "decryptPage";
            this.decryptPage.Padding = new System.Windows.Forms.Padding(3);
            this.decryptPage.Size = new System.Drawing.Size(771, 692);
            this.decryptPage.TabIndex = 1;
            this.decryptPage.Text = "Desencriptar";
            // 
            // SaveFileDecryptedButton
            // 
            this.SaveFileDecryptedButton.AutoRoundedCorners = true;
            this.SaveFileDecryptedButton.BorderRadius = 23;
            this.SaveFileDecryptedButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SaveFileDecryptedButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SaveFileDecryptedButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SaveFileDecryptedButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SaveFileDecryptedButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.SaveFileDecryptedButton.ForeColor = System.Drawing.Color.White;
            this.SaveFileDecryptedButton.Location = new System.Drawing.Point(509, 624);
            this.SaveFileDecryptedButton.Name = "SaveFileDecryptedButton";
            this.SaveFileDecryptedButton.Size = new System.Drawing.Size(180, 48);
            this.SaveFileDecryptedButton.TabIndex = 16;
            this.SaveFileDecryptedButton.Text = "Guardar archivo desencriptado";
            this.SaveFileDecryptedButton.Click += new System.EventHandler(this.SaveFileDecryptedButton_Click);
            // 
            // encryptedTextRTB
            // 
            this.encryptedTextRTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.encryptedTextRTB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encryptedTextRTB.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.encryptedTextRTB.Location = new System.Drawing.Point(19, 103);
            this.encryptedTextRTB.Name = "encryptedTextRTB";
            this.encryptedTextRTB.Size = new System.Drawing.Size(329, 505);
            this.encryptedTextRTB.TabIndex = 15;
            this.encryptedTextRTB.Text = "";
            // 
            // decryptPageKeyLabel
            // 
            this.decryptPageKeyLabel.BackColor = System.Drawing.Color.Transparent;
            this.decryptPageKeyLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decryptPageKeyLabel.Location = new System.Drawing.Point(19, 36);
            this.decryptPageKeyLabel.Name = "decryptPageKeyLabel";
            this.decryptPageKeyLabel.Size = new System.Drawing.Size(148, 30);
            this.decryptPageKeyLabel.TabIndex = 14;
            this.decryptPageKeyLabel.Text = "Clave de cifrado";
            // 
            // decryptPageKeyTB
            // 
            this.decryptPageKeyTB.AutoRoundedCorners = true;
            this.decryptPageKeyTB.BorderRadius = 17;
            this.decryptPageKeyTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.decryptPageKeyTB.DefaultText = "";
            this.decryptPageKeyTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.decryptPageKeyTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.decryptPageKeyTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.decryptPageKeyTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.decryptPageKeyTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.decryptPageKeyTB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.decryptPageKeyTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.decryptPageKeyTB.Location = new System.Drawing.Point(201, 36);
            this.decryptPageKeyTB.Margin = new System.Windows.Forms.Padding(4);
            this.decryptPageKeyTB.Name = "decryptPageKeyTB";
            this.decryptPageKeyTB.PasswordChar = '●';
            this.decryptPageKeyTB.PlaceholderText = "";
            this.decryptPageKeyTB.SelectedText = "";
            this.decryptPageKeyTB.Size = new System.Drawing.Size(293, 36);
            this.decryptPageKeyTB.TabIndex = 13;
            this.decryptPageKeyTB.UseSystemPasswordChar = true;
            // 
            // decryptButton
            // 
            this.decryptButton.AutoRoundedCorners = true;
            this.decryptButton.BorderRadius = 23;
            this.decryptButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.decryptButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.decryptButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.decryptButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.decryptButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.decryptButton.ForeColor = System.Drawing.Color.White;
            this.decryptButton.Location = new System.Drawing.Point(91, 624);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(180, 48);
            this.decryptButton.TabIndex = 12;
            this.decryptButton.Text = "Desencriptar";
            this.decryptButton.Click += new System.EventHandler(this.decryptButton_Click);
            // 
            // OpenEncryptedFileButton
            // 
            this.OpenEncryptedFileButton.AutoRoundedCorners = true;
            this.OpenEncryptedFileButton.BorderRadius = 22;
            this.OpenEncryptedFileButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.OpenEncryptedFileButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.OpenEncryptedFileButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.OpenEncryptedFileButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.OpenEncryptedFileButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.OpenEncryptedFileButton.ForeColor = System.Drawing.Color.White;
            this.OpenEncryptedFileButton.Location = new System.Drawing.Point(573, 25);
            this.OpenEncryptedFileButton.Name = "OpenEncryptedFileButton";
            this.OpenEncryptedFileButton.Size = new System.Drawing.Size(180, 47);
            this.OpenEncryptedFileButton.TabIndex = 11;
            this.OpenEncryptedFileButton.Text = "Abrir archivo encriptado";
            this.OpenEncryptedFileButton.Click += new System.EventHandler(this.OpenEncryptedFileButton_Click);
            // 
            // decryptedTextRTB
            // 
            this.decryptedTextRTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.decryptedTextRTB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decryptedTextRTB.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.decryptedTextRTB.Location = new System.Drawing.Point(424, 103);
            this.decryptedTextRTB.Name = "decryptedTextRTB";
            this.decryptedTextRTB.Size = new System.Drawing.Size(329, 505);
            this.decryptedTextRTB.TabIndex = 10;
            this.decryptedTextRTB.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(959, 700);
            this.Controls.Add(this.siticoneTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cifrado GEDA";
            this.siticoneTabControl1.ResumeLayout(false);
            this.encryptPage.ResumeLayout(false);
            this.encryptPage.PerformLayout();
            this.decryptPage.ResumeLayout(false);
            this.decryptPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticoneTabControl siticoneTabControl1;
        private System.Windows.Forms.TabPage encryptPage;
        private System.Windows.Forms.TabPage decryptPage;
        private Siticone.Desktop.UI.WinForms.SiticoneButton encryptButton;
        private Siticone.Desktop.UI.WinForms.SiticoneButton openFileButton;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox encryptPageKeyTB;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel encryptPageKeyLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel decryptPageKeyLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox decryptPageKeyTB;
        private Siticone.Desktop.UI.WinForms.SiticoneButton decryptButton;
        private Siticone.Desktop.UI.WinForms.SiticoneButton OpenEncryptedFileButton;
        private System.Windows.Forms.RichTextBox decryptedTextRTB;
        private System.Windows.Forms.RichTextBox plainTextRTB;
        private Siticone.Desktop.UI.WinForms.SiticoneButton SaveFileDecryptedButton;
        private System.Windows.Forms.RichTextBox encryptedTextRTB;
    }
}

