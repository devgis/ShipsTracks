using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ShipsTracks.Common.Entites;
using ShipsTracks.Common;

namespace SimulatorProgram
{
    public partial class AddEditBS : Form
    {
        public string ID = string.Empty;
        public AddEditBS(string id = "")
        {
            InitializeComponent();
            if (!string.IsNullOrEmpty(id))
            {
                ID = id;
                LoadModel(id);
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                if (string.IsNullOrEmpty(ID))
                {
                    if (BSDal.Add(GetModel()))
                    {
                        MessageHelper.ShowInfo("添加成功");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageHelper.ShowError("添加失败");
                    }
                }
                else
                {
                    if (BSDal.Edit(GetModel()))
                    {
                        MessageHelper.ShowInfo("修改成功");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageHelper.ShowError("修改失败");
                    }
                }
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public BS GetModel()
        {
            BS bs = new BS();
            bs.BSID = ID;
            bs.BSNO = tbNO.Text;
            bs.BSName = tbName.Text;
            bs.Contact = tbContact.Text;
            bs.Range = Convert.ToSingle(tbRange.Text);
            bs.Lon = Convert.ToSingle(tbLon.Text);
            bs.Lat = Convert.ToSingle(tbLat.Text);
            return bs;
        }

        public void LoadModel(string id)
        {
            this.Text = "修改";
            btAdd.Text = "修改";
            BS bs = BSDal.Get(id);
            tbNO.Text = bs.BSNO;
            tbName.Text = bs.BSName;
            tbContact.Text = bs.Contact;
            tbRange.Text = bs.Range.ToString();
            tbLon.Text = bs.Lon.ToString();
            tbLat.Text = bs.Lat.ToString();
        }

        public bool Check()
        {
            if (string.IsNullOrEmpty(tbNO.Text.Trim()))
            {
                MessageHelper.ShowError("编号不能为空！");
                tbNO.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(tbName.Text.Trim()))
            {
                MessageHelper.ShowError("名称不能为空！");
                tbName.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(tbRange.Text.Trim()))
            {
                MessageHelper.ShowError("范围不能为空！");
                tbRange.Focus();
                return false;
            }
            else
            {
                try
                {
                    float f = Convert.ToSingle(tbLon.Text);
                    if (f <=0)
                    {
                        MessageHelper.ShowError("范围必须大于0！");
                        tbRange.Focus();
                        return false;
                    }
                }
                catch
                {
                    MessageHelper.ShowError("范围必须为数字！");
                    tbRange.Focus();
                    return false;
                }
            }

            if (string.IsNullOrEmpty(tbLon.Text.Trim()))
            {
                MessageHelper.ShowError("经度不能为空！");
                tbLon.Focus();
                return false;
            }
            else
            {
                try
                {
                    float f = Convert.ToSingle(tbLon.Text);
                    if (f > 180 || f < -180) 
                    {
                        MessageHelper.ShowError("经度必须在-180~180之间！");
                        tbLon.Focus();
                        return false;
                    }
                }
                catch
                {
                    MessageHelper.ShowError("经度必须为数字！");
                    tbLon.Focus();
                    return false;
                }
            }

            if (string.IsNullOrEmpty(tbLat.Text.Trim()))
            {
                MessageHelper.ShowError("纬度不能为空！");
                tbLat.Focus();
                return false;
            }
            else
            {
                try
                {
                    float f = Convert.ToSingle(tbLat.Text);
                    if (f > 90 || f < -90)
                    {
                        MessageHelper.ShowError("纬度必须在-90~90之间！");
                        tbLon.Focus();
                        return false;
                    }
                }
                catch
                {
                    MessageHelper.ShowError("纬度必须为数字！");
                    tbLat.Focus();
                    return false;
                }
            }
            return true;
        }
    }
}
