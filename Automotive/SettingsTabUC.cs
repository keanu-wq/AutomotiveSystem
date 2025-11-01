using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automotive
{
    public partial class SettingsTabUC : UserControl
    {
        private int _userId;
        private SettingsTabAccountUC settingsTabAccountUC;
        public SettingsTabUC(int userId)
        {
            InitializeComponent();
            _userId = userId;
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            SettingsTabAccountUC settingsTab = new SettingsTabAccountUC(_userId);
            settingsTab.Dock = DockStyle.Fill;
            UCHolder.Controls.Add(settingsTab);
            btnAccount.StateCommon.Back.Color1 = Color.White;
            btnAccount.StateCommon.Back.Color2 = Color.White;
        }

        private void SettingsTabUC_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSystem_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
