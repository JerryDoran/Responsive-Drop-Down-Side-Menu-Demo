using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuUI
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void customizeDesign()
        {
            panelMediaSubMenu.Visible = false;
            panelPlaylistSubMenu.Visible = false;
            panelToolsSubMenu.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelMediaSubMenu.Visible == true)            
                panelMediaSubMenu.Visible = false;
            if (panelPlaylistSubMenu.Visible == true)
                panelPlaylistSubMenu.Visible = false;
            if (panelToolsSubMenu.Visible == true)
                panelToolsSubMenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void buttonMedia_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMediaSubMenu);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new formChild());
            hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Code goes here
            hideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Code goes here
            hideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Code goes here
            hideSubMenu();
        }

        private void buttonPlaylist_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPlaylistSubMenu);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // Code goes here
            hideSubMenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Code goes here
            hideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Code goes here
            hideSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Code goes here
            hideSubMenu();
        }

        private void buttonEqualizer_Click(object sender, EventArgs e)
        {
            openChildForm(new formChild2());
            hideSubMenu();
        }

        private void buttonTools_Click(object sender, EventArgs e)
        {
            showSubMenu(panelToolsSubMenu);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            // Code goes here
            hideSubMenu();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            // Code goes here
            hideSubMenu();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            // Code goes here
            hideSubMenu();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            // Code goes here
            hideSubMenu();
        }

        private Form activeForm = null;

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
