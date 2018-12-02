using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manger
{             
    public partial class Form1 : Form
    {
        public Form1()    
        {                                     
            InitializeComponent();
        }
        public static bool timetf = false;//时间变量
        const String serverConnectionString = "Data Source = 101.200.45.217; Initial Catalog = dustmonitor_sh; Persist Security Info=True;User ID = root; Password=c9ra@86hhd; characterset=utf8;sslmode=none";

        BindingSource mySourceQueryData = new BindingSource();
         
        private void Form1_Load(object sender, EventArgs e)
        {    

            try
            {
                bindGvwNowAll();
                gvwNow.ReadOnly = true;
                gvwAll.ReadOnly = true;
                chkall.Checked = true;
                
                chkall.Enabled = true;
            }
            catch (MySqlException et)
            {
                MessageBox.Show(et.Message);
            }


        }

        private void bindGvwNowAll()
        {
            try
            {

                //string sqlString = "SELECT b.`Device_Code` AS '设备编号',a.`Date` AS '数据时间',b.`Project_Name` AS '工作名称',a.`Dust` AS '粉尘',a.`Noise` AS '噪音',a.`PM01` AS 'PM01',a.`PM10` AS 'PM10',a.`PM25` AS 'PM25',b.`Project_isOnline` AS '在线' FROM `tb_project` b INNER JOIN `tb_monitordata01` a ON b.`Project_ID`= a.`Project_ID` order by a.date desc LIMIT 50";
                string sqlString = "SELECT a.`Device_Code` AS '设备编号',a.`Date` AS '时间',a.`Dust` AS '粉尘',a.`Noise` AS '噪音',b.`Project_Name` AS '工地名称',b.Project_isOnline  as '是否在线' FROM tb_monitordata01 a INNER JOIN tb_project b ON a.Project_ID=b.Project_ID RIGHT JOIN (SELECT Device_Code, MAX(`Date`) AS DataTime FROM tb_monitordata01 WHERE `Date` > DATE(NOW()) GROUP BY Project_ID) AS M ON a.`Device_Code`=M.Device_Code AND a.Date = M.DataTime ORDER BY a.`Device_Code`";

                using (MySqlConnection connPi = new MySqlConnection(serverConnectionString))
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(sqlString, connPi);
                    MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(adapter);
                    DataTable table = new DataTable();
                    table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                    adapter.Fill(table);
                    gvwNow.DataSource = mySourceQueryData;
                    mySourceQueryData.DataSource = table;
                    gvwNow.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);

                }
            }
            catch (MySqlException et)
            {
                MessageBox.Show(et.Message);
            }
        }

        /// <summary>
        /// 绑定下拉框comboBoxProjectName
        /// </summary>
        private void bindcomboBoxProjectName()
        {
            string sql = string.Format("SELECT Project_ID, Project_Name FROM tb_project  LIMIT 50;");
            MySqlConnection connPi = new MySqlConnection(serverConnectionString);
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connPi);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "table1");
            comboBoxProjectName.DataSource = ds.Tables["table1"];
            comboBoxProjectName.DisplayMember = "Project_Name";
            comboBoxProjectName.ValueMember = "Project_ID";
        }
        /// <summary>
        /// 绑定下拉框comboBoxDevice_Code
        /// </summary>
        private void bindcomboBoxDevice_Code()
        {

            string sql = string.Format("SELECT Project_ID, Device_Code FROM tb_monitordata01 limit 50");
            MySqlConnection connPi = new MySqlConnection(serverConnectionString);
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connPi);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "table1");

            comboBoxDevice_Code.DataSource = ds.Tables["table1"];
            comboBoxDevice_Code.DisplayMember = "Device_Code";
            comboBoxDevice_Code.ValueMember = "Project_ID";
        }
        /// <summary>
        /// 绑定统计数据
        /// </summary>
        private void bindgvwAll()
        {

            string sql = "SELECT a.`Device_Code` AS '设备编号',a.`Date` AS '时间',a.`Dust` AS '粉尘',a.`Noise` AS '噪音',b.`Project_Name` AS '工地名称' FROM tb_monitordata01 a INNER JOIN tb_project b ON a.Project_ID=b.Project_ID RIGHT JOIN (SELECT Device_Code, MAX(`Date`) AS DataTime FROM tb_monitordata01 WHERE `Date` > DATE(NOW()) GROUP BY Project_ID) AS M ON a.`Device_Code`=M.Device_Code AND a.Date = M.DataTime ORDER BY a.`Device_Code`";
            using (MySqlConnection connPi = new MySqlConnection(serverConnectionString))
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connPi);
                MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(adapter);
                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                adapter.Fill(table);
                gvwAll.DataSource = mySourceQueryData;
                mySourceQueryData.DataSource = table;
                gvwAll.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            }

        }
        /// <summary>
        /// 绑定实时数据是否在线（控件已经删除）
        /// </summary>
        //private void bindgvwNowByYES()
        //{


        //    try
        //    {
        //        string sqlString = "";
        //        if (chkbox.Checked == true)
        //        {
        //            sqlString = "SELECT b.`Device_Code` AS '设备编号',a.`Date` AS '数据时间',b.`Project_Name` AS '工作名称',a.`Dust` AS '粉尘',a.`Noise` AS '噪音',a.`PM01` AS 'PM01',a.`PM10` AS 'PM10',a.`PM25` AS 'PM25',b.`Project_isOnline` AS '在线' FROM `tb_project` b INNER JOIN `tb_monitordata01` a ON b.`Project_ID`= a.`Project_ID` WHERE b.`Project_isOnline`=1  LIMIT 50";
        //        }
        //        else
        //        {
        //            sqlString = "SELECT b.`Device_Code` AS '设备编号',a.`Date` AS '数据时间',b.`Project_Name` AS '工作名称',a.`Dust` AS '粉尘',a.`Noise` AS '噪音',a.`PM01` AS 'PM01',a.`PM10` AS 'PM10',a.`PM25` AS 'PM25',b.`Project_isOnline` AS '不在线' FROM `tb_project` b INNER JOIN `tb_monitordata01` a ON b.`Project_ID`= a.`Project_ID` WHERE b.`Project_isOnline`=0 order by a.date desc LIMIT 50";

        //        }
        //        using (MySqlConnection connPi = new MySqlConnection(serverConnectionString))
        //        {
        //            MySqlDataAdapter adapter = new MySqlDataAdapter(sqlString, connPi);
        //            MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(adapter);
        //            DataTable table = new DataTable();
        //            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
        //            adapter.Fill(table);
        //            gvwNow.DataSource = mySourceQueryData;
        //            mySourceQueryData.DataSource = table;
        //            gvwNow.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
        //        }
        //    }
        //    catch (MySqlException et)
        //    {
        //        MessageBox.Show(et.Message);

        //    }
        //}
        /// <summary>
        /// 绑定工地清单
        /// </summary>
        private void bindgvwConstrution()
        {
            try
            {
                string sqlString = "SELECT b.Project_isOnline as 是否在线,b.`Project_Code` as 工地编号,b.`Device_Code` as 设备编号,b.`Device_MNCode` as MN码,b.`Project_beginDate` as 开工时间,b.`Project_endDate` as 结束时间 ,b.`Project_Name` 工地名称 FROM `tb_project` b order by b.`Project_beginDate` desc";
                using (MySqlConnection connPi = new MySqlConnection(serverConnectionString))
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(sqlString, connPi);
                    MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(adapter);
                    DataTable table = new DataTable();
                    table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                    adapter.Fill(table);
                    gvwConstrution.DataSource = mySourceQueryData;
                    mySourceQueryData.DataSource = table;
                    gvwConstrution.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);

                    //DataGridViewCheckBoxColumn
                    //gvw
                }
            }
            catch (MySqlException et)
            {
                MessageBox.Show(et.Message);
            }

        }

        /// <summary>
        /// tabpage之间跳转
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPageIndex == 0)
            {
                bindGvwNowAll();
             
                chkall.Visible = true;
                btnExcl.Enabled = false;

            }
            if (e.TabPageIndex == 1)
            {
                bindgvwAll();
                //radNew.Checked = true;
               
                chkall.Visible = false;
                bindcomboBoxDevice_Code();
                bindcomboBoxProjectName();
                btnExcl.Enabled = true;



            }
            else if (e.TabPageIndex == 2)
            {
                bindgvwConstrution();
             
                chkall.Visible = false;
                btnExcl.Enabled = false;
            }
        }



        /// <summary>
        /// 选中所有设备触发事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chBoxAllDevice_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxAllDevice.Checked)//如果选中所有数据
            {
                chkSearchByDate.Checked = true;
                label2.Visible = false;
                comboBoxDevice_Code.Visible = false;
                label3.Visible = false;
                comboBoxProjectName.Visible = false;

            }
            else
            {
                label2.Visible = true;
                comboBoxDevice_Code.Visible = true;
                label3.Visible = true;
                comboBoxProjectName.Visible = true;

            }
        }
        /// <summary>
        /// 选中实时数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radNew_CheckedChanged(object sender, EventArgs e)
        {
            if (radNew.Checked)//若果选中的是实时数据
            {
                label4.Visible = true;
                numericUpDown1.Visible = true;
                bindgvwAll();
                btnnSearch.Visible = false;
                btnSearch.Visible = true;
                chkday.Visible = false;
                chkhour.Visible = false;
            }
        }

        /// <summary>
        /// 选中统计数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radAll_CheckedChanged(object sender, EventArgs e)
        {
            if (radAll.Checked)//若果选中的是实时数据
            {
                label4.Visible = false;
                numericUpDown1.Visible = false;
                btnnSearch.Visible = true;
                btnSearch.Visible = false;
                chkday.Visible = true;
                chkhour.Visible = true;
                chBoxAllDevice.Checked = true;
                chkSearchByDate.Checked = true;
                
            }
        }
        //查询功能
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //string datetime = dateTimePicker1.Text;
            int num = Convert.ToInt32(numericUpDown1.Value);
            string Device_Code = comboBoxDevice_Code.Text;//取出设备编号
            string projiectName = comboBoxProjectName.Text;//取出工地名称

            if (chBoxAllDevice.Checked == true)//如果全部设备被选中
            {
                if (chkSearchByDate.Checked)//如果选中按照时间查询，则按照时间查询(默认按照时间查询被选中）
                {
                    bindDateWhereall();
                }
                else//否则查询所有的，没有任何条件
                {
                    bindgvwAll();
                }

            }
            else//否则就是按照时间和两个commbox来查询
            {
                if (chkSearchByDate.Checked == true)//如果选中时间查询就做时间，和两个下拉框的查询
                {
                    bindgvwAllByDate();
                }
                else//否则就是做两个下拉框的模糊查询
                {
                    if (Device_Code == "" && projiectName == "")
                    {
                        MessageBox.Show("请输入正确的关键字");
                        bindgvwAll();
                        return;
                    }
                    else if (projiectName == "")
                    {
                        string sqlString = "SELECT a.`Device_Code` as '设备编号',a.`Date` as '时间',a.`Dust` as '粉尘',a.`Noise` as '噪音',b.Project_Name as '工地名称' FROM `tb_project` b INNER JOIN `tb_monitordata01` a on a.`Project_ID`=b.`Project_ID` where a.`Device_Code`like '%" + Device_Code + "%' limit " + num + "";

                        using (MySqlConnection connPi = new MySqlConnection(serverConnectionString))
                        {
                            MySqlDataAdapter adapter = new MySqlDataAdapter(sqlString, connPi);
                            MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(adapter);
                            DataTable table = new DataTable();
                            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                            adapter.Fill(table);
                            gvwAll.DataSource = mySourceQueryData;
                            mySourceQueryData.DataSource = table;
                            gvwAll.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
                        }
                    }
                    else if (Device_Code == "")
                    {
                        string sqlString = "SELECT a.`Device_Code` as '设备编号',a.`Date` as '时间',a.`Dust` as '粉尘',a.`Noise` as '噪音',b.Project_Name as '工地名称' FROM `tb_project` b INNER JOIN `tb_monitordata01` a on a.`Project_ID`=b.`Project_ID` where b.`Project_Name`like '%" + projiectName + "%' limit " + num + "";

                        using (MySqlConnection connPi = new MySqlConnection(serverConnectionString))
                        {
                            MySqlDataAdapter adapter = new MySqlDataAdapter(sqlString, connPi);
                            MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(adapter);
                            DataTable table = new DataTable();
                            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                            adapter.Fill(table);
                            gvwAll.DataSource = mySourceQueryData;
                            mySourceQueryData.DataSource = table;
                            gvwAll.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
                        }
                    }
                    else
                    {
                        string sqlString = "SELECT a.`Device_Code` as '设备编号',a.`Date` as '时间',a.`Dust` as '粉尘',a.`Noise` as '噪音',b.Project_Name as '工地名称' FROM `tb_project` b INNER JOIN `tb_monitordata01` a on a.`Project_ID`=b.`Project_ID` where b.`Project_Name`like '%" + projiectName + "%' and a.`Device_Code`like '%" + Device_Code + "%' limit " + num + "";
                        using (MySqlConnection connPi = new MySqlConnection(serverConnectionString))
                        {
                            MySqlDataAdapter adapter = new MySqlDataAdapter(sqlString, connPi);
                            MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(adapter);
                            DataTable table = new DataTable();
                            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                            adapter.Fill(table);
                            gvwAll.DataSource = mySourceQueryData;
                            mySourceQueryData.DataSource = table;
                            gvwAll.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
                        }

                    }
                }

            }

        }
        /// <summary>
        /// 当选中全部设备时候查询
        /// </summary>
        private void bindDateWhereall()
        {
            string timeBegin = dateTimePicker1.Value.ToShortDateString() + " " + dateTimePicker2.Value.ToShortTimeString();
            string timeEnd = dateTimePicker3.Value.ToShortDateString() + " " + dateTimePicker4.Value.ToShortTimeString();

            //string sqlString = "SELECT a.`Device_Code` AS '设备编号',b.`Project_beginDate` AS '时间',a.`Dust` AS '粉尘',a.`Noise` AS '噪音',b.Project_Name as '工地名称' FROM `tb_project` b INNER JOIN `tb_monitordata01` a ON a.`Project_ID`=b.`Project_ID` limit 50";
            string sqlString = string.Format("SELECT a.`Device_Code` AS '设备编号',a.`Date` AS '时间',a.`Dust` AS '粉尘',a.`Noise` AS '噪音',b.Project_Name as '工地名称' FROM `tb_project` b INNER JOIN `tb_monitordata01` a ON a.`Project_ID`=b.`Project_ID` WHERE a.DATE BETWEEN('" + timeBegin + "')AND('" + timeEnd + "') limit " + numericUpDown1.Value + "");

            using (MySqlConnection connPi = new MySqlConnection(serverConnectionString))
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(sqlString, connPi);
                MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(adapter);
                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                adapter.Fill(table);
                gvwAll.DataSource = mySourceQueryData;
                mySourceQueryData.DataSource = table;
                gvwAll.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            }
        }

        //统计数据中当全部设备按钮选中，按照时间查询
        private void bindgvwAllByDate()
        {
            string projiectName = comboBoxProjectName.Text;
            string Device_Code = comboBoxDevice_Code.Text;
            string timeBegin = dateTimePicker1.Value.ToShortDateString() + " " + dateTimePicker2.Value.ToShortTimeString();
            string timeEnd = dateTimePicker3.Value.ToShortDateString() + " " + dateTimePicker4.Value.ToShortTimeString();
            string sqlString = "SELECT a.`Device_Code` AS '设备编号',a.`Date` AS '时间',a.`Dust` AS '粉尘',a.`Noise` AS '噪音',b.Project_Name as '工地名称' FROM `tb_project` b INNER JOIN `tb_monitordata01` a ON a.`Project_ID`=b.`Project_ID` WHERE a.DATE BETWEEN('" + timeBegin + "')AND('" + timeEnd + "') and b.`Project_Name`like '%" + projiectName + "%' and a.`Device_Code`like '%" + Device_Code + "%' limit " + numericUpDown1.Value + "";
            using (MySqlConnection connPi = new MySqlConnection(serverConnectionString))
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(sqlString, connPi);
                MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(adapter);
                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                adapter.Fill(table);
                gvwAll.DataSource = mySourceQueryData;
                mySourceQueryData.DataSource = table;
                gvwAll.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            }
        }

        /// <summary>
        /// 修改数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int index = gvwConstrution.CurrentRow.Index;
            string deviceID = gvwConstrution.Rows[index].Cells[2].Value.ToString();//设备编号有问题，Cells[]中的数子与数据不对称
            string projectID = gvwConstrution.Rows[index].Cells[1].Value.ToString();
            string Mn = gvwConstrution.Rows[index].Cells[3].Value.ToString();
            string projectname = gvwConstrution.Rows[index].Cells[6].Value.ToString();
            string begin = gvwConstrution.Rows[index].Cells[4].Value.ToString();
            string end = gvwConstrution.Rows[index].Cells[5].Value.ToString();
            string isonline = gvwConstrution.Rows[index].Cells[0].Value.ToString();
            MessageBox.Show(projectID);
            if (gvwConstrution.Rows[index].Selected)//如果选中一整行，就弹框进行修改
            {

                addAndUpdate f = null;
                try
                {
                    f = new addAndUpdate(projectID, deviceID, Mn, begin, end, projectname, isonline);
                    f.ShowDialog();
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show("111");
                }
            }
            else
            {
                bindupdate();
            }
        }

        private void bindupdate()
        {
            if (gvwConstrution.ReadOnly == true)
            {
                gvwConstrution.ReadOnly = false;
                gvwConstrution.SelectionMode = DataGridViewSelectionMode.CellSelect;
            }
        }


        /// <summary>
        /// 增加数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            add f = null;
            try
            {
                f = new add();
                f.ShowDialog();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// 保存数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {

            string Gdsql = "SELECT Project_Code , Device_Code  ,Project_beginDate ,Project_endDate ,Project_isOnline , Project_Name   FROM tb_project LIMIT 100";
            try
            {

                using (MySqlConnection connPi = new MySqlConnection(serverConnectionString))
                {
                    connPi.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(Gdsql, connPi);
                    MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(adapter);
                    DataTable table = new DataTable();
                    table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                    adapter.Fill(table);
                    gvwConstrution.DataSource = mySourceQueryData;
                    mySourceQueryData.DataSource = table;
                    //dgvgjqd.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
                    connPi.Close();
                }
            }
            catch (MySqlException et)
            {
                MessageBox.Show(et.Message);
            }

        }
        /// <summary>
        /// 取消数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {

            return;
        }
        /// <summary>
        /// 选中行后，将数据呈现在文本框中 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gvwAll_SelectionChanged(object sender, EventArgs e)
        {
            int index = gvwAll.CurrentRow.Index; //获取选中行的行号
            if (radNew.Checked==true)
            {
                comboBoxDevice_Code.Text = gvwAll.Rows[index].Cells[0].Value.ToString();
                comboBoxProjectName.Text = gvwAll.Rows[index].Cells[4].Value.ToString();
            }
            else if (radAll.Checked==true)
            {
                comboBoxDevice_Code.Text = gvwAll.Rows[index].Cells[0].Value.ToString();
                comboBoxProjectName.Text = gvwAll.Rows[index].Cells[1].Value.ToString();
            }
           
        
            //dateTimePicker1.Text = gvwAll.Rows[index].Cells[1].Value.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timetf == true)
            {

                bindgvwConstrution();//数据绑定
                timetf = false;//绑定之后，设为FALSE，不然每秒都刷新，浪费资源
            }
        }

        /// <summary>
        /// 是否根据时间查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkSearchByDate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSearchByDate.Checked == false)
            {
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
                dateTimePicker3.Enabled = false;
                dateTimePicker4.Enabled = false;
            }
            else
            {
                dateTimePicker1.Enabled = true;
                dateTimePicker2.Enabled = true;
                dateTimePicker3.Enabled = true;
                dateTimePicker4.Enabled = true;
            }
        }





        private void gvwConstrution_DoubleClick(object sender, EventArgs e)
        {
            beginEdit();
        }


        private void beginEdit()
        {
            if (gvwConstrution.ReadOnly == true)
            {
                gvwConstrution.ReadOnly = false;
                gvwConstrution.SelectionMode = DataGridViewSelectionMode.CellSelect;
            }
        }

        private void gvwNow_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            int countOnLine, countNotOnLine, countDustError, countNoiseError;
            countOnLine = countNotOnLine = countDustError = countNoiseError = 0;

            for (int i = 0; i < this.gvwNow.RowCount; i++)
            {
                DateTime dataTime = Convert.ToDateTime(gvwNow.Rows[i].Cells[1].Value);
                if (dataTime < System.DateTime.Now.AddHours(-1))
                {
                    gvwNow.Rows[i].Cells[1].Style.BackColor = Color.Red;
                    countNotOnLine += 1;
                }
                else
                {
                    gvwNow.Rows[i].Cells[1].Style.BackColor = Color.White;
                    //myDataView.Rows[i].Cells[1].Style.BackColor = Color.FromKnownColor(KnownColor.AppWorkspace);
                    countOnLine += 1;
                }
                if (0 > Convert.ToSingle(gvwNow.Rows[i].Cells[2].Value))
                {
                    gvwNow.Rows[i].Cells[2].Style.BackColor = Color.Red;
                    countDustError += 1;//粉尘
                }
                else
                {
                    gvwNow.Rows[i].Cells[2].Style.BackColor = Color.White;
                }


                if (0 > Convert.ToSingle(gvwNow.Rows[i].Cells[3].Value))
                {
                    gvwNow.Rows[i].Cells[3].Style.BackColor = Color.Red;
                    countNoiseError += 1;
                }
                else
                {

                    gvwNow.Rows[i].Cells[3].Style.BackColor = Color.White;
                }
                if (Convert.ToSingle(gvwNow.Rows[i].Cells[5].Value)==0)
                {
                    gvwNow.Rows[i].Cells[5].Style.BackColor = Color.Red;
                    countNoiseError += 1;
                }
                else
                {
                    gvwNow.Rows[i].Cells[5].Style.BackColor = Color.White;
                }


            }

            toolStripStatusLabel1.Text = "在线设备数量：" + countOnLine.ToString() + "    ";
            toolStripStatusLabel2.Text = "断线设备数量：" + countNotOnLine.ToString() + "    ";
            toolStripStatusLabel3.Text = "粉尘仪故障数量：" + countDustError.ToString() + "    ";
            toolStripStatusLabel4.Text = "声级计故障数量：" + countNoiseError.ToString() + "    ";
        }

        private void chkall_CheckedChanged(object sender, EventArgs e)
        {
            if (chkall.Checked)
            {
               
                bindGvwNowAll();
            }
          

        }




        private void button2_Click(object sender, EventArgs e)
        {


            Curve f = null;

            f = new Curve();
            f.ShowDialog();

        }

        private void btnExcl_Click(object sender, EventArgs e)
        {
            string a = "D:" + "\\KKHMD.xls";

            ExportExcels(a, gvwAll);
        }

        private void ExportExcels(string fileName, DataGridView gvwAll)
        {
            string saveFileName = "";
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.DefaultExt = "xls";
            saveDialog.Filter = "Excel文件|*.xls";
            saveDialog.FileName = fileName;
            saveDialog.ShowDialog();
            saveFileName = saveDialog.FileName;
            if (saveFileName.IndexOf(":") < 0) return; //被点了取消
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            if (xlApp == null)
            {
                MessageBox.Show("无法创建Excel对象，可能您的电脑未安装Excel");
                return;
            }
            Microsoft.Office.Interop.Excel.Workbooks workbooks = xlApp.Workbooks;
            Microsoft.Office.Interop.Excel.Workbook workbook = workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets[1];//取得sheet1
                                                                                                                                  //写入标题
            for (int i = 0; i < gvwAll.ColumnCount; i++)
            {
                worksheet.Cells[1, i + 1] = gvwAll.Columns[i].HeaderText;
            }
            //写入数值
            for (int r = 0; r < gvwAll.Rows.Count; r++)
            {
                for (int i = 0; i < gvwAll.ColumnCount; i++)
                {
                    worksheet.Cells[r + 2, i + 1] = gvwAll.Rows[r].Cells[i].Value;
                }
                System.Windows.Forms.Application.DoEvents();
            }
            worksheet.Columns.EntireColumn.AutoFit();//列宽自适应
            if (saveFileName != "")
            {
                try
                {
                    workbook.Saved = true;
                    workbook.SaveCopyAs(saveFileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("导出文件时出错,文件可能正被打开！\n" + ex.Message);
                }
            }
            xlApp.Quit();
            GC.Collect();//强行销毁
            MessageBox.Show("文件： " + fileName + ".xls 保存成功", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnnSearch_Click(object sender, EventArgs e)
        {
            string Device_Code = comboBoxDevice_Code.Text;
            string ProjectName = comboBoxProjectName.Text;

          
            string timeBegin = dateTimePicker1.Value.ToShortDateString() + " " + dateTimePicker2.Value.ToShortTimeString();
            string timeEnd = dateTimePicker3.Value.ToShortDateString() + " " + dateTimePicker4.Value.ToShortTimeString();
            if (chkSearchByDate.Checked == true && chBoxAllDevice.Checked == true && chkhour.Checked == true)
            {
                string sql = "select a.device_code as '设备编号',b.project_Name as '工地名称',count(*) as '总数据',COUNT(IF(a.Dust>0,1, NULL)) as '粉尘',avg(Dust) as '粉尘平均值',min(Dust) as '粉尘最小值',max(Dust) as '粉尘最大值', COUNT(IF(a.Noise>0,1, NULL)) as '噪声',avg(Noise) as '噪音平均值',min(Noise) as '噪音最小值',max(Noise) as '噪音最大值' from `tb_monitordata01` a inner join `tb_project` b on a.project_id=b.project_id where a.date between '" + timeBegin + "' and '" + timeEnd + "'";
                using (MySqlConnection connPi = new MySqlConnection(serverConnectionString))
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connPi);
                    MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(adapter);
                    DataTable table = new DataTable();
                    table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                    adapter.Fill(table);
                    gvwAll.DataSource = mySourceQueryData;
                    mySourceQueryData.DataSource = table;
                    gvwAll.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            
                }
            }
            else if (chkSearchByDate.Checked == true && chBoxAllDevice.Checked == false && chkhour.Checked == true)
            {
                string sql = "select a.device_code as '设备编号',b.project_Name as '工地名称',count(*) as '总数据',COUNT(IF(a.Dust>0,1, NULL)) as '粉尘',avg(Dust) as '粉尘平均值',min(Dust) as '粉尘最小值',max(Dust) as '粉尘最大值', COUNT(IF(a.Noise>0,1, NULL)) as '噪声',avg(Noise) as '噪音平均值',min(Noise) as '噪音最小值',max(Noise) as '噪音最大值' from `tb_monitordata01` a inner join `tb_project` b on a.project_id=b.project_id where a.Device_code='" + Device_Code + "' AND b.project_Name='" + ProjectName + "' and  a.date between '" + timeBegin + "' and '" + timeEnd + "'";
                using (MySqlConnection connPi = new MySqlConnection(serverConnectionString))
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connPi);
                    MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(adapter);
                    DataTable table = new DataTable();
                    table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                    adapter.Fill(table);
                    gvwAll.DataSource = mySourceQueryData;
                    mySourceQueryData.DataSource = table;
                    gvwAll.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
                }
             
            }
            else if (chkSearchByDate.Checked == true && chBoxAllDevice.Checked == true && chkday.Checked == true)
            {
                string starthour = dateTimePicker1.Value.ToString();
                string endhour = dateTimePicker3.Value.ToString();
                
                string sql = "select a.device_code as '设备编号',b.project_Name as '工地名称',count(*) as '总数据',COUNT(IF(a.Dust>0,1, NULL)) as '粉尘',avg(Dust) as '粉尘平均值',min(Dust) as '粉尘最小值',max(Dust) as '粉尘最大值', COUNT(IF(a.Noise>0,1, NULL)) as '噪声',avg(Noise) as '噪音平均值',min(Noise) as '噪音最小值',max(Noise) as '噪音最大值' from `tb_monitordata01` a inner join `tb_project` b on a.project_id=b.project_id where a.date between '" + starthour + "' and '" + endhour + "'";
                using (MySqlConnection connPi = new MySqlConnection(serverConnectionString))
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connPi);
                    MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(adapter);
                    DataTable table = new DataTable();
                    table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                    adapter.Fill(table);
                    gvwAll.DataSource = mySourceQueryData;
                    mySourceQueryData.DataSource = table;
                    gvwAll.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
                }
           
            }
            else if (chkSearchByDate.Checked == true && chBoxAllDevice.Checked == false && chkday.Checked == true)
            {
                string starthour = dateTimePicker1.Value.ToString();
                string endhour = dateTimePicker3.Value.ToString();
                
                string sql = "select a.device_code as '设备编号',b.project_Name as '工地名称',count(*) as '总数据',COUNT(IF(a.Dust>0,1, NULL)) as '粉尘',avg(Dust) as '粉尘平均值',min(Dust) as '粉尘最小值',max(Dust) as '粉尘最大值', COUNT(IF(a.Noise>0,1, NULL)) as '噪声',avg(Noise) as '噪音平均值',min(Noise) as '噪音最小值',max(Noise) as '噪音最大值' from `tb_monitordata01` a inner join `tb_project` b on a.project_id=b.project_id where a.Device_code='" + Device_Code + "' AND b.project_Name='" + ProjectName + "' and  a.date between '" + timeBegin + "' and '" + timeEnd + "'";
                using (MySqlConnection connPi = new MySqlConnection(serverConnectionString))
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connPi);
                    MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(adapter);
                    DataTable table = new DataTable();
                    table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                    adapter.Fill(table);
                    gvwAll.DataSource = mySourceQueryData;
                    mySourceQueryData.DataSource = table;
                    gvwAll.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
                }
         
            }

            


        }


        private void chkday_CheckedChanged(object sender, EventArgs e)
        {
            if (chkday.Checked == true)
            {
                chkhour.Checked = false;
                dateTimePicker2.Visible = false;
                dateTimePicker4.Visible = false;
            }
        }

        private void chkhour_CheckedChanged(object sender, EventArgs e)
        {
            if (chkhour.Checked == true)
            {
                chkday.Checked = false;
                dateTimePicker1.Visible = true;
                dateTimePicker3.Visible = true;
            }
        }

        private void btnnow_Click(object sender, EventArgs e)
        {
            return;
        }
    }
}

