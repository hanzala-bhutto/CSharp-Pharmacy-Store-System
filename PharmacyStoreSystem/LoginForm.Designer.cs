
namespace PharmacyStoreSystem
{
    partial class LoginForm
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
            this.components = new System.ComponentModel.Container();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties13 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties14 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties15 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties16 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.LoginFormElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.UpperPanel = new System.Windows.Forms.Panel();
            this.PharmacyLogopic = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.PharmacyStorelabel = new System.Windows.Forms.Label();
            this.UserPassword = new Bunifu.UI.WinForms.BunifuTextBox();
            this.UserName = new Bunifu.UI.WinForms.BunifuTextBox();
            this.UserNamelabel = new System.Windows.Forms.Label();
            this.Passwordlabel = new System.Windows.Forms.Label();
            this.LoginButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ClearFieldslabel = new System.Windows.Forms.Label();
            this.Exitlabel = new System.Windows.Forms.Label();
            this.UpperPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PharmacyLogopic)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginFormElipse1
            // 
            this.LoginFormElipse1.ElipseRadius = 30;
            this.LoginFormElipse1.TargetControl = this;
            // 
            // UpperPanel
            // 
            this.UpperPanel.BackColor = System.Drawing.Color.White;
            this.UpperPanel.Controls.Add(this.PharmacyLogopic);
            this.UpperPanel.Controls.Add(this.PharmacyStorelabel);
            this.UpperPanel.Location = new System.Drawing.Point(1, 21);
            this.UpperPanel.Name = "UpperPanel";
            this.UpperPanel.Size = new System.Drawing.Size(365, 95);
            this.UpperPanel.TabIndex = 0;
            // 
            // PharmacyLogopic
            // 
            this.PharmacyLogopic.AllowFocused = false;
            this.PharmacyLogopic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PharmacyLogopic.AutoSizeHeight = true;
            this.PharmacyLogopic.BackColor = System.Drawing.Color.Transparent;
            this.PharmacyLogopic.BorderRadius = 0;
            this.PharmacyLogopic.Enabled = false;
            this.PharmacyLogopic.Image = ((System.Drawing.Image)(resources.GetObject("PharmacyLogopic.Image")));
            this.PharmacyLogopic.IsCircle = false;
            this.PharmacyLogopic.Location = new System.Drawing.Point(156, 45);
            this.PharmacyLogopic.Name = "PharmacyLogopic";
            this.PharmacyLogopic.Size = new System.Drawing.Size(47, 47);
            this.PharmacyLogopic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PharmacyLogopic.TabIndex = 19;
            this.PharmacyLogopic.TabStop = false;
            this.PharmacyLogopic.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // PharmacyStorelabel
            // 
            this.PharmacyStorelabel.AutoSize = true;
            this.PharmacyStorelabel.BackColor = System.Drawing.Color.Transparent;
            this.PharmacyStorelabel.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PharmacyStorelabel.ForeColor = System.Drawing.Color.Green;
            this.PharmacyStorelabel.Location = new System.Drawing.Point(67, 7);
            this.PharmacyStorelabel.Name = "PharmacyStorelabel";
            this.PharmacyStorelabel.Size = new System.Drawing.Size(235, 36);
            this.PharmacyStorelabel.TabIndex = 18;
            this.PharmacyStorelabel.Text = "Pharmacy Store";
            // 
            // UserPassword
            // 
            this.UserPassword.AcceptsReturn = false;
            this.UserPassword.AcceptsTab = false;
            this.UserPassword.AnimationSpeed = 200;
            this.UserPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.UserPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.UserPassword.AutoSizeHeight = true;
            this.UserPassword.BackColor = System.Drawing.Color.Transparent;
            this.UserPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UserPassword.BackgroundImage")));
            this.UserPassword.BorderColorActive = System.Drawing.Color.Lime;
            this.UserPassword.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.UserPassword.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.UserPassword.BorderColorIdle = System.Drawing.Color.White;
            this.UserPassword.BorderRadius = 30;
            this.UserPassword.BorderThickness = 2;
            this.UserPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.UserPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserPassword.DefaultFont = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserPassword.DefaultText = "";
            this.UserPassword.FillColor = System.Drawing.Color.White;
            this.UserPassword.ForeColor = System.Drawing.Color.Green;
            this.UserPassword.HideSelection = true;
            this.UserPassword.IconLeft = null;
            this.UserPassword.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.UserPassword.IconPadding = 10;
            this.UserPassword.IconRight = null;
            this.UserPassword.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.UserPassword.Lines = new string[0];
            this.UserPassword.Location = new System.Drawing.Point(143, 245);
            this.UserPassword.MaxLength = 32767;
            this.UserPassword.MinimumSize = new System.Drawing.Size(1, 1);
            this.UserPassword.Modified = false;
            this.UserPassword.Multiline = false;
            this.UserPassword.Name = "UserPassword";
            stateProperties13.BorderColor = System.Drawing.Color.Lime;
            stateProperties13.FillColor = System.Drawing.Color.Empty;
            stateProperties13.ForeColor = System.Drawing.Color.Empty;
            stateProperties13.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.UserPassword.OnActiveState = stateProperties13;
            stateProperties14.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties14.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties14.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.UserPassword.OnDisabledState = stateProperties14;
            stateProperties15.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties15.FillColor = System.Drawing.Color.Empty;
            stateProperties15.ForeColor = System.Drawing.Color.Empty;
            stateProperties15.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.UserPassword.OnHoverState = stateProperties15;
            stateProperties16.BorderColor = System.Drawing.Color.White;
            stateProperties16.FillColor = System.Drawing.Color.White;
            stateProperties16.ForeColor = System.Drawing.Color.Green;
            stateProperties16.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.UserPassword.OnIdleState = stateProperties16;
            this.UserPassword.Padding = new System.Windows.Forms.Padding(3);
            this.UserPassword.PasswordChar = '$';
            this.UserPassword.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.UserPassword.PlaceholderText = "";
            this.UserPassword.ReadOnly = false;
            this.UserPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.UserPassword.SelectedText = "";
            this.UserPassword.SelectionLength = 0;
            this.UserPassword.SelectionStart = 0;
            this.UserPassword.ShortcutsEnabled = true;
            this.UserPassword.Size = new System.Drawing.Size(195, 46);
            this.UserPassword.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.UserPassword.TabIndex = 1;
            this.UserPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.UserPassword.TextMarginBottom = 0;
            this.UserPassword.TextMarginLeft = 3;
            this.UserPassword.TextMarginTop = 1;
            this.UserPassword.TextPlaceholder = "";
            this.UserPassword.UseSystemPasswordChar = false;
            this.UserPassword.WordWrap = true;
            // 
            // UserName
            // 
            this.UserName.AcceptsReturn = false;
            this.UserName.AcceptsTab = false;
            this.UserName.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.UserName.AnimationSpeed = 200;
            this.UserName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.UserName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.UserName.AutoSizeHeight = true;
            this.UserName.BackColor = System.Drawing.Color.Transparent;
            this.UserName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UserName.BackgroundImage")));
            this.UserName.BorderColorActive = System.Drawing.Color.Lime;
            this.UserName.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.UserName.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.UserName.BorderColorIdle = System.Drawing.Color.White;
            this.UserName.BorderRadius = 30;
            this.UserName.BorderThickness = 2;
            this.UserName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.UserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserName.DefaultFont = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.DefaultText = "";
            this.UserName.FillColor = System.Drawing.Color.White;
            this.UserName.ForeColor = System.Drawing.Color.Green;
            this.UserName.HideSelection = true;
            this.UserName.IconLeft = null;
            this.UserName.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.UserName.IconPadding = 10;
            this.UserName.IconRight = null;
            this.UserName.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.UserName.Lines = new string[0];
            this.UserName.Location = new System.Drawing.Point(143, 170);
            this.UserName.MaxLength = 32767;
            this.UserName.MinimumSize = new System.Drawing.Size(1, 1);
            this.UserName.Modified = false;
            this.UserName.Multiline = false;
            this.UserName.Name = "UserName";
            stateProperties9.BorderColor = System.Drawing.Color.Lime;
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.UserName.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.UserName.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties11.FillColor = System.Drawing.Color.Empty;
            stateProperties11.ForeColor = System.Drawing.Color.Empty;
            stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.UserName.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.White;
            stateProperties12.FillColor = System.Drawing.Color.White;
            stateProperties12.ForeColor = System.Drawing.Color.Green;
            stateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.UserName.OnIdleState = stateProperties12;
            this.UserName.Padding = new System.Windows.Forms.Padding(3);
            this.UserName.PasswordChar = '$';
            this.UserName.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.UserName.PlaceholderText = "";
            this.UserName.ReadOnly = false;
            this.UserName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.UserName.SelectedText = "";
            this.UserName.SelectionLength = 0;
            this.UserName.SelectionStart = 0;
            this.UserName.ShortcutsEnabled = true;
            this.UserName.Size = new System.Drawing.Size(195, 46);
            this.UserName.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.UserName.TabIndex = 1;
            this.UserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.UserName.TextMarginBottom = 0;
            this.UserName.TextMarginLeft = 3;
            this.UserName.TextMarginTop = 1;
            this.UserName.TextPlaceholder = "";
            this.UserName.UseSystemPasswordChar = false;
            this.UserName.WordWrap = true;
            // 
            // UserNamelabel
            // 
            this.UserNamelabel.AutoSize = true;
            this.UserNamelabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNamelabel.ForeColor = System.Drawing.Color.White;
            this.UserNamelabel.Location = new System.Drawing.Point(12, 182);
            this.UserNamelabel.Name = "UserNamelabel";
            this.UserNamelabel.Size = new System.Drawing.Size(109, 24);
            this.UserNamelabel.TabIndex = 2;
            this.UserNamelabel.Text = "User Name";
            // 
            // Passwordlabel
            // 
            this.Passwordlabel.AutoSize = true;
            this.Passwordlabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passwordlabel.ForeColor = System.Drawing.Color.White;
            this.Passwordlabel.Location = new System.Drawing.Point(12, 257);
            this.Passwordlabel.Name = "Passwordlabel";
            this.Passwordlabel.Size = new System.Drawing.Size(96, 24);
            this.Passwordlabel.TabIndex = 2;
            this.Passwordlabel.Text = "Password";
            // 
            // LoginButton
            // 
            this.LoginButton.ActiveBorderThickness = 1;
            this.LoginButton.ActiveCornerRadius = 30;
            this.LoginButton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.LoginButton.ActiveForecolor = System.Drawing.Color.White;
            this.LoginButton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.LoginButton.BackColor = System.Drawing.Color.Green;
            this.LoginButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LoginButton.BackgroundImage")));
            this.LoginButton.ButtonText = "Login";
            this.LoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginButton.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.Color.Green;
            this.LoginButton.IdleBorderThickness = 1;
            this.LoginButton.IdleCornerRadius = 30;
            this.LoginButton.IdleFillColor = System.Drawing.Color.White;
            this.LoginButton.IdleForecolor = System.Drawing.Color.Green;
            this.LoginButton.IdleLineColor = System.Drawing.Color.Lime;
            this.LoginButton.Location = new System.Drawing.Point(90, 357);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(5);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(190, 47);
            this.LoginButton.TabIndex = 3;
            this.LoginButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // ClearFieldslabel
            // 
            this.ClearFieldslabel.AutoSize = true;
            this.ClearFieldslabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearFieldslabel.ForeColor = System.Drawing.Color.White;
            this.ClearFieldslabel.Location = new System.Drawing.Point(140, 294);
            this.ClearFieldslabel.Name = "ClearFieldslabel";
            this.ClearFieldslabel.Size = new System.Drawing.Size(74, 15);
            this.ClearFieldslabel.TabIndex = 4;
            this.ClearFieldslabel.Text = "Clear Fields";
            this.ClearFieldslabel.Click += new System.EventHandler(this.ClearField_Click);
            // 
            // Exitlabel
            // 
            this.Exitlabel.AutoSize = true;
            this.Exitlabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exitlabel.ForeColor = System.Drawing.Color.White;
            this.Exitlabel.Location = new System.Drawing.Point(166, 409);
            this.Exitlabel.Name = "Exitlabel";
            this.Exitlabel.Size = new System.Drawing.Size(28, 15);
            this.Exitlabel.TabIndex = 4;
            this.Exitlabel.Text = "Exit";
            this.Exitlabel.Click += new System.EventHandler(this.Exit_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Green;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(368, 450);
            this.Controls.Add(this.Exitlabel);
            this.Controls.Add(this.ClearFieldslabel);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.Passwordlabel);
            this.Controls.Add(this.UserNamelabel);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.UserPassword);
            this.Controls.Add(this.UpperPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.UpperPanel.ResumeLayout(false);
            this.UpperPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PharmacyLogopic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse LoginFormElipse1;
        private System.Windows.Forms.Panel UpperPanel;
        private System.Windows.Forms.Label PharmacyStorelabel;
        private Bunifu.UI.WinForms.BunifuTextBox UserPassword;
        private Bunifu.Framework.UI.BunifuThinButton2 LoginButton;
        private System.Windows.Forms.Label Passwordlabel;
        private System.Windows.Forms.Label UserNamelabel;
        private Bunifu.UI.WinForms.BunifuTextBox UserName;
        private System.Windows.Forms.Label ClearFieldslabel;
        private Bunifu.UI.WinForms.BunifuPictureBox PharmacyLogopic;
        private System.Windows.Forms.Label Exitlabel;
    }
}