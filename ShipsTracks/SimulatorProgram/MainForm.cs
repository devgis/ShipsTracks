using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using ShipsTracks.Common;

namespace SimulatorProgram
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void miHelp_Click(object sender, EventArgs e)
        {

        }

        private void miAbout_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }

        private void miExit_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void miShip_Click(object sender, EventArgs e)
        {
            ShipsManager shipsManager = new ShipsManager();
            shipsManager.ShowDialog();
        }

        private void miBS_Click(object sender, EventArgs e)
        {
            BSManager bsManager = new BSManager();
            bsManager.ShowDialog();
        }

        int timesleep = 10;
        private void MainForm_Load(object sender, EventArgs e)
        {
            ThreadPool.QueueUserWorkItem(o =>
            {
                while (true)
                {
                    if (cbSim.Checked)
                    {
                        ShipsSim.SimData(); //模拟数据
                        //执行模拟
                    }
                    Thread.Sleep(timesleep * 1000);
                }
            });
        }

        private void tbTicks_TextChanged(object sender, EventArgs e)
        {
            try
            {
                timesleep = Convert.ToInt32(tbTicks.Text);
            }
            catch
            {
                tbTicks.Text = "10";
                //timesleep = 10;
            }
        }
    }
}
