using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyStoreSystem
{
    public partial class LoadingScreenForm : Form
    {
        public LoadingScreenForm()
        {
            InitializeComponent();
            LoadingTimer1.Start();
        }

// For incrementing and progressing the progressbar upto value 100
        private void LoadingTimer1_Tick(object sender, EventArgs e)
        {
            LoadingFlat.Value += 1;
            int progressvalue = Convert.ToInt32(Progresslabel.Text.ToString());
            progressvalue++;
            Progresslabel.Text = progressvalue.ToString();

            if(LoadingFlat.Value == 100 || progressvalue == 100)
            {
                progressvalue = 100;
                Progresslabel.Text = progressvalue.ToString();
                LoadingFlat.Value = 100;
                LoadingTimer1.Stop();

                LoginForm login = new LoginForm();
                this.Hide();
                login.Show();

            }
        }

        private void LoadingScreen_Load(object sender, EventArgs e)
        {

        }

    }
}
