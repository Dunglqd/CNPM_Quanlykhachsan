﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Management
{
    public partial class MAIN : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
         (
              int nLeftRect,
              int nTopRect,
              int nRightRect,
              int nBottomRect,
              int nWidthEllipse,
              int nHeightEllipse

          );
        private Form activateForm = null;
        private string MAQUYEN = "Q2";

        public MAIN(string MAQUYEN = "Q2")
        {
            this.MAQUYEN = MAQUYEN;
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
            pnlNavIndicator.Height = btnDashboard.Height;
            pnlNavIndicator.Top = btnDashboard.Top;
            pnlNavIndicator.Left = btnDashboard.Left;
            ButtonColorReset(btnDashboard);

            lblTabTitle.Text = "Dashboard";
            this.pnlContent.Controls.Clear();
            DASHBOARD FrmDashboard_Vrb = new DASHBOARD() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlContent.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
        }

        private void openChildForm(Form childForm)
        {
            if (activateForm != null)
            {
                activateForm.Close();
            }

            activateForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(childForm);
            pnlContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void ButtonColorReset(Button button)
        {
            Color activeColor = Color.FromArgb(31, 27, 48);
            Color btnColor = Color.FromArgb(26, 23, 40);
            btnDashboard.BackColor = btnColor;
            btnBookRoom.BackColor = btnColor;
            btnManage.BackColor = btnColor;
            btnPayment.BackColor = btnColor;
            btnReport.BackColor = btnColor;
            btnSearch.BackColor = btnColor;
            btnAccount.BackColor = btnColor;    
            btnSettings.BackColor = btnColor;
            button.BackColor = activeColor;
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            pnlNavIndicator.Height = btnDashboard.Height;
            pnlNavIndicator.Top = btnDashboard.Top;
            pnlNavIndicator.Left = btnDashboard.Left;
            ButtonColorReset(btnDashboard);

            lblTabTitle.Text = "Dashboard";
            openChildForm(new DASHBOARD());

            //this.pnlContent.Controls.Clear();
            //DASHBOARD FrmDashboard_Vrb = new DASHBOARD() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            //this.pnlContent.Controls.Add(FrmDashboard_Vrb);
            //FrmDashboard_Vrb.Show();
        }

        private void BtnBookRoom_Click(object sender, EventArgs e)
        {
            pnlNavIndicator.Height = btnBookRoom.Height;
            pnlNavIndicator.Top = btnBookRoom.Top;
            pnlNavIndicator.Left = btnBookRoom.Left;
            ButtonColorReset(btnBookRoom);

            lblTabTitle.Text = "BookRoom";
            openChildForm(new BOOK_ROOM());

            //this.pnlContent.Controls.Clear();
            //BOOKROOM FrmBOOKROOM_Vrb = new BOOKROOM() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            //this.pnlContent.Controls.Add(FrmBOOKROOM_Vrb);
            //FrmBOOKROOM_Vrb.Show();
        }
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            pnlNavIndicator.Height = btnSearch.Height;
            pnlNavIndicator.Top = btnSearch.Top;
            pnlNavIndicator.Left = btnSearch.Left;
            ButtonColorReset(btnSearch);

            lblTabTitle.Text = "Search";
            openChildForm(new SEARCH());

            //this.pnlContent.Controls.Clear();
            //SEARCH FrmSEARCH_Vrb = new SEARCH() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            //this.pnlContent.Controls.Add(FrmSEARCH_Vrb);
            //FrmSEARCH_Vrb.Show();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            pnlNavIndicator.Height = btnManage.Height;
            pnlNavIndicator.Top = btnManage.Top;
            pnlNavIndicator.Left = btnManage.Left;
            ButtonColorReset(btnManage);

            lblTabTitle.Text = "Manage";
            openChildForm(new MANAGE());

            //this.pnlContent.Controls.Clear();
            //MANAGE FrmMANAGE_Vrb = new MANAGE() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            //this.pnlContent.Controls.Add(FrmMANAGE_Vrb);
            //FrmMANAGE_Vrb.Show();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            pnlNavIndicator.Height = btnPayment.Height;
            pnlNavIndicator.Top = btnPayment.Top;
            pnlNavIndicator.Left = btnPayment.Left;
            ButtonColorReset(btnPayment);

            lblTabTitle.Text = "Payment";
            openChildForm(new HOADON());

            //this.pnlContent.Controls.Clear();
            //HOADON FrmHOADON_Vrb = new HOADON() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            //this.pnlContent.Controls.Add(FrmHOADON_Vrb);
            //FrmHOADON_Vrb.Show();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            pnlNavIndicator.Height = btnReport.Height;
            pnlNavIndicator.Top = btnReport.Top;
            pnlNavIndicator.Left = btnReport.Left;
            ButtonColorReset(btnReport);

            lblTabTitle.Text = "Report";
            openChildForm(new REPORT());

            //this.pnlContent.Controls.Clear();
            //REPORT FrmREPORT_Vrb = new REPORT() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            //this.pnlContent.Controls.Add(FrmREPORT_Vrb);
            //FrmREPORT_Vrb.Show();
        }
    }
}
