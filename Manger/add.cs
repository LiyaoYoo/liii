using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manger
{
    public partial class add : Form
    {
        public add()
        {
            InitializeComponent();
        }

        BindingSource mySourceQueryData = new BindingSource();
        const String serverConnectionString = "Data Source=101.200.45.217;Initial Catalog=dustmonitor_sh;Persist Security Info=True;User ID=root;Password=c9ra@86hhd; characterset=utf8;sslmode=none";
        private void btnOK_Click(object sender, EventArgs e)
        {
            string ProjectID = txtProjectID.Text;
            string DevuceID = txtDevuceID.Text;
            string Mn = TXTMn.Text;
            DateTime begintime = Convert.ToDateTime(dateTimePicker1.Text);
            DateTime endtime = Convert.ToDateTime(dateTimePicker2.Text);
            string ProjectName = txtProjectName.Text;
            if (ProjectID=="")
            {
                MessageBox.Show("请输入工地编号！");
                return;
            }
            if (DevuceID=="")
            {
                MessageBox.Show("请输入设备编号！");
                return;
            }
             if (Mn=="")
            {
                MessageBox.Show("请输入MN码！");
                return;
            }
             if (begintime>=endtime)
            {
                MessageBox.Show("请输入正确的开工时间和结束时间（开工时间要小于结束时间）！！！");
                return;
            }
            if (ProjectName=="")
            {
                MessageBox.Show("请输入工地名称");
                return;
            }

            string sql = string.Format("INSERT INTO tb_project SET Project_Code = '" + ProjectID + "', Device_Code = '" + DevuceID + "',Project_beginDate='" + begintime + "',Project_endDate='" + endtime + "',Project_Name='" + ProjectName + "',Project_Address='1111',Project_Type=1,Project_Linkman='123456',Project_Phone='111111'");
            try
            {
                MySqlConnection connPi = new MySqlConnection(serverConnectionString);
                connPi.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connPi);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "table1");
                MessageBox.Show("添加成功");
                Form1.timetf = true;
                this.Visible = false;
              
            }
            catch
            {
                MessageBox.Show("添加失败");
                return;
            }
        }

        private void btnFalse_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
