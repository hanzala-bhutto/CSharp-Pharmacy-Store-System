
namespace PharmacyStoreSystem
{
    partial class LoadingScreenForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingScreenForm));
            this.LoadingElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.LoadingFlat = new Bunifu.UI.WinForms.BunifuProgressBar();
            this.PharmacyStorelabel = new System.Windows.Forms.Label();
            this.LoadingTimer1 = new System.Windows.Forms.Timer(this.components);
            this.Progresslabel = new System.Windows.Forms.Label();
            this.Percentlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoadingElipse1
            // 
            this.LoadingElipse1.ElipseRadius = 30;
            this.LoadingElipse1.TargetControl = this;
            // 
            // LoadingFlat
            // 
            this.LoadingFlat.AllowAnimations = false;
            this.LoadingFlat.Animation = 0;
            this.LoadingFlat.AnimationSpeed = 220;
            this.LoadingFlat.AnimationStep = 10;
            this.LoadingFlat.BackColor = System.Drawing.Color.Transparent;
            this.LoadingFlat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LoadingFlat.BackgroundImage")));
            this.LoadingFlat.BorderColor = System.Drawing.Color.DarkRed;
            this.LoadingFlat.BorderRadius = 30;
            this.LoadingFlat.BorderThickness = 2;
            this.LoadingFlat.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadingFlat.Location = new System.Drawing.Point(-7, 319);
            this.LoadingFlat.Maximum = 100;
            this.LoadingFlat.MaximumValue = 100;
            this.LoadingFlat.Minimum = 0;
            this.LoadingFlat.MinimumValue = 0;
            this.LoadingFlat.Name = "LoadingFlat";
            this.LoadingFlat.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LoadingFlat.ProgressBackColor = System.Drawing.Color.Transparent;
            this.LoadingFlat.ProgressColorLeft = System.Drawing.Color.Green;
            this.LoadingFlat.ProgressColorRight = System.Drawing.Color.Green;
            this.LoadingFlat.Size = new System.Drawing.Size(584, 30);
            this.LoadingFlat.TabIndex = 0;
            this.LoadingFlat.Value = 0;
            this.LoadingFlat.ValueByTransition = 0;
            // 
            // PharmacyStorelabel
            // 
            this.PharmacyStorelabel.AutoSize = true;
            this.PharmacyStorelabel.BackColor = System.Drawing.Color.Transparent;
            this.PharmacyStorelabel.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PharmacyStorelabel.ForeColor = System.Drawing.Color.White;
            this.PharmacyStorelabel.Location = new System.Drawing.Point(155, 9);
            this.PharmacyStorelabel.Name = "PharmacyStorelabel";
            this.PharmacyStorelabel.Size = new System.Drawing.Size(270, 42);
            this.PharmacyStorelabel.TabIndex = 17;
            this.PharmacyStorelabel.Text = "Pharmacy Store";
            // 
            // LoadingTimer1
            // 
            this.LoadingTimer1.Interval = 50;
            this.LoadingTimer1.Tick += new System.EventHandler(this.LoadingTimer1_Tick);
            // 
            // Progresslabel
            // 
            this.Progresslabel.AutoSize = true;
            this.Progresslabel.BackColor = System.Drawing.Color.Transparent;
            this.Progresslabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Progresslabel.ForeColor = System.Drawing.Color.Green;
            this.Progresslabel.Location = new System.Drawing.Point(272, 299);
            this.Progresslabel.Name = "Progresslabel";
            this.Progresslabel.Size = new System.Drawing.Size(17, 19);
            this.Progresslabel.TabIndex = 17;
            this.Progresslabel.Text = "0";
            // 
            // Percentlabel
            // 
            this.Percentlabel.AutoSize = true;
            this.Percentlabel.BackColor = System.Drawing.Color.Transparent;
            this.Percentlabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Percentlabel.ForeColor = System.Drawing.Color.Green;
            this.Percentlabel.Location = new System.Drawing.Point(304, 303);
            this.Percentlabel.Name = "Percentlabel";
            this.Percentlabel.Size = new System.Drawing.Size(17, 13);
            this.Percentlabel.TabIndex = 17;
            this.Percentlabel.Text = "%";
            // 
            // LoadingScreenForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(571, 347);
            this.Controls.Add(this.Percentlabel);
            this.Controls.Add(this.Progresslabel);
            this.Controls.Add(this.PharmacyStorelabel);
            this.Controls.Add(this.LoadingFlat);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoadingScreenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LoadingScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse LoadingElipse1;
        private Bunifu.UI.WinForms.BunifuProgressBar LoadingFlat;
        private System.Windows.Forms.Label PharmacyStorelabel;
        private System.Windows.Forms.Timer LoadingTimer1;
        private System.Windows.Forms.Label Progresslabel;
        private System.Windows.Forms.Label Percentlabel;
    }
}

