using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ShipsTracks.Common;

namespace SimulatorProgram
{
    public partial class ShipsManager : Form
    {
        public ShipsManager()
        {
            InitializeComponent();
        }

        private void ShipsManager_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void tsAdd_Click(object sender, EventArgs e)
        {
            AddEditShip dddEditShip = new AddEditShip();
            if (dddEditShip.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void tsEdit_Click(object sender, EventArgs e)
        {
            if (dgvList.SelectedRows.Count <= 0)
            {
                MessageHelper.ShowError("请选择！");
            }
            else
            {
                AddEditShip dddEditShip = new AddEditShip(dgvList.SelectedRows[0].Cells["CID"].Value.ToString());
                if (dddEditShip.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void tsDel_Click(object sender, EventArgs e)
        {
            if (dgvList.SelectedRows.Count <= 0)
            {
                MessageHelper.ShowError("请选择！");
            }
            else
            {
                List<string> list = new List<string>();
                list.Add(dgvList.SelectedRows[0].Cells["CID"].Value.ToString());
                if (ShipDal.Delete(list))
                {
                    LoadData();
                    MessageHelper.ShowInfo("删除成功！");
                }
                else
                {
                    MessageHelper.ShowError("请选择！");
                }
            }
        }

        private void LoadData()
        {
            dgvList.DataSource = ShipDal.Query("");
        }
    }
}
