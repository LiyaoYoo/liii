using MySql.Data.MySqlClient;
using System;
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
    public partial class addAndUpdate : Form
    {   
        public addAndUpdate(string projectID,string deviceID,string Mn,string begin,string end,string projectname,string isonline)
        {

            InitializeComponent();
            txtProjectID.Text = projectID;
            txtDevuceID.Text = deviceID;
            
            TXTMn.Text = Mn;
           
            dateTimePicker1.Text = begin;
            dateTimePicker2.Text = end;
            txtProjectName.Text = projectname;hv
            comboBox1.Text = isonline;
        }
        const String serverConnectionString = "Data Source = 101.200.45.217; Initial Catalog = dustmonitor_sh; Persist Security Info=True;User ID = root; Password=c9ra@86hhd; characterset=utf8;sslmode=none";

        BindingSource mySourceQueryData = new BindingSource();
        private void btnFalse_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 确认修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE `tb_project` a SET a.`Device_Code`='" + txtDevuceID.Text + "',a.`Project_isOnline`="+comboBox1.Text+", a.`Device_MNCode`='" + TXTMn.Text + "',a.`Project_beginDate`='" + dateTimePicker1.Value.ToString() + "',a.`Project_endDate`='" + dateTimePicker2.Value.ToString() + "',a.`Project_Name`='" + txtProjectName.Text + "' WHERE a.`Project_Code`= '" + txtProjectID.Text + "'";
            try
            {
                MySqlConnection connPi = new MySqlConnection(serverConnectionString);
                connPi.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connPi);
                DataSet ds = new DataSet();
                adapter.Fill(ds,"table1");
                MessageBox.Show("修改成功");
                Form1.timetf = true;
               
                this.Visible = false;
                
            }
            catch
            {
                MessageBox.Show("修改失败");
                return;
            }
        }
    }
}
