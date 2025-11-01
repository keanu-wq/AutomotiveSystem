using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automotive
{
    public partial class ClientCardUC : UserControl
    {
        public event Action<ClientCardUC, string> OnClientSelected;

        private string clientId;
        private bool isSelected = false;
        private Color borderColor = Color.White;
        public ClientCardUC()
        {
            InitializeComponent();

            this.MouseEnter += ClientCardUC_MouseEnter;
            this.MouseLeave += ClientCardUC_MouseLeave;
            this.MouseDown += ClientCardUC_MouseDown;

            foreach (Control c in Controls)
            {
                c.MouseEnter += ClientCardUC_MouseEnter;
                c.MouseLeave += ClientCardUC_MouseLeave;
                c.MouseDown += ClientCardUC_MouseDown;
            }

            this.Paint += ClientCardUC_Paint;
        }

        public void setData(string id, string name, string vehicle, string date, string img)
        {
            clientId = id;

            lblID.Text = id;
            lblName.Text = name;
            lblVehicle.Text = vehicle;
            lblDate.Text = date;

            if (!string.IsNullOrWhiteSpace(img) && File.Exists(img))
            {
                picItem.Image = Image.FromFile(img);
            }

            borderColor = Color.White;
            this.Invalidate();
        }

        private void ClientCardUC_MouseEnter(object sender, EventArgs e)
        {
            if (!isSelected)
            {
                borderColor = Color.LightBlue;
                this.Invalidate();
            }
        }

        private void ClientCardUC_MouseLeave(object sender, EventArgs e)
        {
            if (!isSelected)
            {
                borderColor = Color.White;
                this.Invalidate();
            }
        }

        private void ClientCardUC_MouseDown(object sender, MouseEventArgs e)
        {
            OnClientSelected?.Invoke(this, clientId);
        }

        private void ClientCardUC_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(borderColor, 3))
            {
                e.Graphics.DrawRectangle(pen, 0, 0, this.Width - 1, this.Height - 1);
            }
        }

        public void SetSelected(bool selected)
        {
            isSelected = selected;
            borderColor = selected ? Color.CornflowerBlue : Color.White;
            this.Invalidate();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (clientId == null)
                return;

            ClientInformation info = new ClientInformation(clientId);
            info.ShowDialog();
        }
    }
}
