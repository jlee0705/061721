using carFixMgr.model;
using carFixMgr.ui;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carFixMgr
{
    public partial class MainForm : MaterialForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void mainExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void custFixView_Click(object sender, EventArgs e)
        {

        }

        private void custFixAdmin_Click(object sender, EventArgs e)
        {

        }

        private void custFixRand_Click(object sender, EventArgs e)
        {

        }

        private void custFixInfo_Click(object sender, EventArgs e)
        {

        }

        private void custfixAdd_Click_1(object sender, EventArgs e)
        {
            new ReceiptForm().ShowDialog();
        }
    }
}
