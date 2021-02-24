using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapsLock
{
    public partial class CapsLock : Form
    {
        public CapsLock()
        {
            InitializeComponent();
        }

        int WindowHeight = 10;
        int WindowWidth = 90;
        int WindowRightIndent = 140;
        int WindowActiveHeight = 32;
        Color PassiveColor = Color.FromArgb(132, 151, 176);
        Color ActiveColor = Color.White;
        Color LightRedColor = Color.FromArgb(255, 64, 64);

        private void CapsLock_Load(object sender, EventArgs e)
        {
            this.Height = WindowHeight;
            this.Width = WindowWidth;
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - WindowWidth - WindowRightIndent, 0);
            this.TopMost = true;
            KeyLockController();
        }

        private void CapsLock_Activated(object sender, EventArgs e)
        {
            ShowIcons();
            label_close.BackColor = LightRedColor;
        }

        private void CapsLock_Deactivate(object sender, EventArgs e)
        {
            HideIcons();
        }

        private void ShowIcons()
        {
            this.Height = WindowActiveHeight;
        }

        private  void HideIcons()
        {
            this.Height = WindowHeight;
        }

        private void label_closeIcon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void KeyLockController()
        {
            while (true)
            {
                label_capsLock.BackColor = Control.IsKeyLocked(Keys.CapsLock) ? ActiveColor : PassiveColor;
                label_numLock.BackColor = Control.IsKeyLocked(Keys.NumLock) ? ActiveColor : PassiveColor;
                label_scrollLock.BackColor = Control.IsKeyLocked(Keys.Scroll) ? ActiveColor : PassiveColor;
                await Task.Delay(100);
            }
        }
    }
}
