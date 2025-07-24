using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HTQLKS
{
    public partial class Form1 : Form
    {
        private List<Button> menuButtons;
        private Color activeColor = Color.FromArgb(0, 122, 204);
        private Color inactiveColor = Color.FromArgb(26, 32, 44);

        public Form1()
        {
            InitializeComponent();
            InitializeMenuButtons();
        }

        private void InitializeMenuButtons()
        {
            menuButtons = new List<Button> { btnQLPhong, btnQLCheckIn, btnQLCheckOut, btnQLDichVu, btnQLKhachHang, btnLapHoaDon, btnDangXuat };
        }

        private void SetActiveButton(Button activeButton)
        {
            foreach (var button in menuButtons)
            {
                if (button == activeButton)
                {
                    button.BackColor = activeColor;
                }
                else
                {
                    button.BackColor = inactiveColor;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Load the default user control on startup and set the active button
            btnQLPhong_Click(btnQLPhong, EventArgs.Empty);
        }
        private void btnQLPhong_Click(object sender, EventArgs e)
        {
            displayPanel.Controls.Clear();
            ucQuanLyPhong uc = new ucQuanLyPhong();
            uc.Dock = DockStyle.Fill;
            displayPanel.Controls.Add(uc);
            SetActiveButton(sender as Button);
        }

        private void btnQLCheckIn_Click(object sender, EventArgs e)
        {
            displayPanel.Controls.Clear();
            ucQuanLyCheckIn uc = new ucQuanLyCheckIn();
            uc.Dock = DockStyle.Fill;
            displayPanel.Controls.Add(uc);
            SetActiveButton(sender as Button);
        }

        private void btnQLCheckOut_Click(object sender, EventArgs e)
        {
            displayPanel.Controls.Clear();
            ucQuanLyCheckOut uc = new ucQuanLyCheckOut();
            uc.Dock = DockStyle.Fill;
            displayPanel.Controls.Add(uc);
            SetActiveButton(sender as Button);
        }
    }
}
