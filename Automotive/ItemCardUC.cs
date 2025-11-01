using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Automotive
{
    public partial class ItemCardUC : UserControl
    {
        public event Action<ItemCardUC, string> OnItemSelected;

        private string itemId;
        private bool isSelected = false;
        private Color borderColor = Color.White;

        public ItemCardUC()
        {
            InitializeComponent();

            this.MouseEnter += ItemCardUC_MouseEnter;
            this.MouseLeave += ItemCardUC_MouseLeave;
            this.MouseDown += ItemCardUC_MouseDown;

            foreach (Control c in Controls)
            {
                c.MouseEnter += ItemCardUC_MouseEnter;
                c.MouseLeave += ItemCardUC_MouseLeave;
                c.MouseDown += ItemCardUC_MouseDown;
            }

            this.Paint += ItemCardUC_Paint;
        }

        public void setData(string id, string name, double price, int stock, string img)
        {
            itemId = id;
            lblID.Text = id;
            lblName.Text = name;
            lblPrice.Text = "P " + price.ToString("N0");
            lblStock.Text = stock.ToString();

            lblPrice.ForeColor = Color.Green;
            lblStock.ForeColor = stock <= 5 ? Color.Red : Color.Green;

            if (!string.IsNullOrWhiteSpace(img) && File.Exists(img))
            {
                picItem.Image = Image.FromFile(img);
            }

            if (lblOutofStock.Visible == false && stock <= 0)
            {
                lblOutofStock.Visible = true;
            }
            else
                lblOutofStock.Visible = false;

            borderColor = Color.White;
            this.Invalidate();
        }

        private void ItemCardUC_MouseEnter(object sender, EventArgs e)
        {
            if (!isSelected)
            {
                borderColor = Color.LightBlue;
                this.Invalidate();
            }
        }

        private void ItemCardUC_MouseLeave(object sender, EventArgs e)
        {
            if (!isSelected)
            {
                borderColor = Color.White;
                this.Invalidate();
            }
        }

        private void ItemCardUC_MouseDown(object sender, MouseEventArgs e)
        {
            OnItemSelected?.Invoke(this, itemId);
        }

        private void ItemCardUC_Paint(object sender, PaintEventArgs e)
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
    }
}
