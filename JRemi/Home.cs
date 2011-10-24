using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
namespace JRemi
{
    public partial class Home : Form
    {
        private int searchWhere = 0;
        private string query_table = "select * from tbl_words";
        private string query_start_win_select = "select start_win from tbl_settings where id=1";
        private string query_time1 = "select time1 from tbl_settings where id=1";
        private string query_time2 = "select time2 from tbl_settings where id=1";
        private DataTable db = new DataTable();
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

            Int64 time1 = (Int64)DBAccess.executeScalar(query_time1);
            Int64 time2 = (Int64)DBAccess.executeScalar(query_time2);

            txtTimeShow.Text = time1 + "";
            txtTimeChange.Text = time2 + "";

            db = DBAccess.getDataTable(query_table);
            dataTable.DataSource = db;
            dataTable.Columns[0].HeaderText = "ID";
            dataTable.Columns[0].Width = 50;
            dataTable.Columns[1].HeaderText = "Tiếng nhật";
            dataTable.Columns[1].Width = 100;
            dataTable.Columns[2].HeaderText = "Romaji";
            dataTable.Columns[2].Width = 100;
            dataTable.Columns[3].HeaderText = "Nghĩa tiếng Việt";
            dataTable.Columns[3].Width = 120;
            dataTable.Columns[4].HeaderText = "Chú thích";
            dataTable.Columns[4].Width = 285;
            bool check = (bool)DBAccess.executeScalar(query_start_win_select);
            checkBox1.Checked = check;
            txtID_Edit.DataBindings.Add("Text", db, "id");
            txtNihon_Edit.DataBindings.Add("Text", db, "nihongo");
            txtRomaji_Edit.DataBindings.Add("Text", db, "romaji");
            txtBetonamugo_Edit.DataBindings.Add("Text", db, "betonamugo");
            txtNouto_Edit.DataBindings.Add("Text", db, "nouto");

        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            string nihon = txtNihon_Add.Text;
            string beto = txtBetonamugo_Add.Text;
            string romaji = txtRomaji_Add.Text;
            string nouto = txtNouto_Add.Text;
            if ( nihon == "" || beto == "") {
                MessageBox.Show("Không thể thêm từ mà không có nghĩa tiếng việt hoặc không có tiếng nhật");
                return;
            }
            string query = "Insert into tbl_words (nihongo, romaji, betonamugo, nouto) values ('" + nihon + "','" + romaji + "', '" + beto + "','" + nouto +"')";
            int result = DBAccess.executeNonQuery(query);
            if (result == -1) MessageBox.Show("Error!");
            else
            {
                MessageBox.Show("Thêm thành công");
                txtNihon_Add.Text = "";
                txtBetonamugo_Add.Text = "";
                txtRomaji_Add.Text = "";
                txtNouto_Add.Text = "";
            }
            update();
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (checkBox1.Checked == true)
            {
                String sql = "update tbl_settings set start_win=1 where id=1";
                DBAccess.executeNonQuery(sql);
                rkApp.SetValue("JRemi", Application.ExecutablePath.ToString());
            }
            else
            {
                String sql = "update tbl_settings set start_win=0 where id=1";
                DBAccess.executeNonQuery(sql);
                rkApp.DeleteValue("JRemi", false);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string id = txtID_Edit.Text;
            string nihon = txtNihon_Edit.Text;
            string beto = txtBetonamugo_Edit.Text;
            string romaji = txtRomaji_Edit.Text;
            string nouto = txtNouto_Edit.Text;
            string query = "Update tbl_words set nihongo='"+nihon+"', romaji='"+romaji+"', betonamugo='"+beto+"', nouto='"+nouto+"' Where id ='"+id+"'";
            //MessageBox.Show(query);
            int result = DBAccess.executeNonQuery(query);
            if (result == -1) MessageBox.Show("Error!");
            else
            {
                MessageBox.Show("Thay đổi thành công");
            }
            update();
        }

        private void exit()
        {
            int i = (int)MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thoát", MessageBoxButtons.YesNo);
            if (i == 6)
            {
                Application.Exit();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            exit();
        }


        private void update()
        {
            db = DBAccess.getDataTable(query_table);
            dataTable.DataSource = db;
            txtID_Edit.DataBindings.Clear();
            txtID_Edit.DataBindings.Add("Text", db, "id");
            txtNihon_Edit.DataBindings.Clear();
            txtNihon_Edit.DataBindings.Add("Text", db, "nihongo");
            txtRomaji_Edit.DataBindings.Clear();
            txtRomaji_Edit.DataBindings.Add("Text", db, "romaji");
            txtBetonamugo_Edit.DataBindings.Clear();
            txtBetonamugo_Edit.DataBindings.Add("Text", db, "betonamugo");
            txtNouto_Edit.DataBindings.Clear();
            txtNouto_Edit.DataBindings.Add("Text", db, "nouto");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql = "";
            switch (searchWhere)
            {
                case 0:
                    sql = query_table;
                    break;
                case 1:
//                    sql = "select * from tbl_words where id='" + txtSearch_ID.Text + "'";
                    sql = "select * from tbl_words where id like '" + txtSearch_ID.Text + "%'";
                    break;
                case 2:
                    sql = "select * from tbl_words where nihongo like '" + txtSearch_Nihongo.Text + "%'";
                    break;
                case 3:
                    sql = "select * from tbl_words where betonamugo like '" + txtSearch_Betonamugo.Text + "%'";
                    break;
                case 4:
                    sql = "select * from tbl_words where romaji like '" + txtSearch_Romaji.Text + "%'";
                    break;
            }
            DataTable db = DBAccess.getDataTable(sql);
            if (db.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy");
                db = DBAccess.getDataTable(query_table);
            }
            dataTable.DataSource = db;
        }

        private void txtSearch_ID_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch_ID.Text == "")
            {
                txtSearch_Betonamugo.Enabled = true;
                txtSearch_Nihongo.Enabled = true;
                txtSearch_Romaji.Enabled = true;
                searchWhere = 0;
            }
            else
            {
                txtSearch_Betonamugo.Enabled = false;
                txtSearch_Nihongo.Enabled = false;
                txtSearch_Romaji.Enabled = false;
                searchWhere = 1;
            }

        }

        private void txtSearch_Nihongo_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch_Nihongo.Text == "")
            {
                txtSearch_Betonamugo.Enabled = true;
                txtSearch_ID.Enabled = true;
                txtSearch_Romaji.Enabled = true;
                searchWhere = 0;
            }
            else
            {
                txtSearch_Betonamugo.Enabled = false;
                txtSearch_ID.Enabled = false;
                txtSearch_Romaji.Enabled = false;
                searchWhere = 2;
            }
        }

        private void txtSearch_Betonamugo_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch_Betonamugo.Text == "")
            {
                txtSearch_ID.Enabled = true;
                txtSearch_Nihongo.Enabled = true;
                txtSearch_Romaji.Enabled = true;
                searchWhere = 0;
            }
            else
            {
                txtSearch_ID.Enabled = false;
                txtSearch_Nihongo.Enabled = false;
                txtSearch_Romaji.Enabled = false;
                searchWhere = 3;
            }
        }

        private void txtSearch_Romaji_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch_Romaji.Text == "")
            {
                txtSearch_Betonamugo.Enabled = true;
                txtSearch_Nihongo.Enabled = true;
                txtSearch_ID.Enabled = true;
                searchWhere = 0;
            }
            else
            {
                txtSearch_Betonamugo.Enabled = false;
                txtSearch_Nihongo.Enabled = false;
                txtSearch_ID.Enabled = false;
                searchWhere = 4;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = (int)MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Delete", MessageBoxButtons.YesNo);
            if (i == 6)
            {
                string id = txtID_Edit.Text;
                string sql = "DELETE FROM tbl_words WHERE id="+id;
                DBAccess.executeNonQuery(sql);
                update();
            }
        }

        private void showForm(bool state)
        {
            if (state)
            {
                Show();
                Activate();
                WindowState = FormWindowState.Normal;
                timer2.Stop();
                timer2.Enabled = false;
            }
            else
            {
                Hide();
                WindowState = FormWindowState.Minimized;
                timer2.Enabled = true;
                timer2.Start();
            }
        }

        private void mainProc()
        {
            string nihongo = "";
            string betonamugo = "";
            string romaji = "";
            string nouto = "";
            string sql = "SELECT * FROM tbl_words ORDER BY RANDOM() LIMIT 1";
            DataTable db = DBAccess.getDataTable(sql);
            Int64 i = (Int64)DBAccess.executeScalar(query_time1);
            int ii = Convert.ToInt32(i) * 1000;
            nihongo = (string)db.Rows[0][1];
            betonamugo = (string)db.Rows[0][3];
            romaji = (string)db.Rows[0][2];
            nouto = (string)db.Rows[0][4];
            noIcon.BalloonTipTitle = nihongo;
            noIcon.BalloonTipText = "" + romaji + "\n" + "" + betonamugo + "\n" + "" + nouto;
            noIcon.ShowBalloonTip(ii);
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            noIcon.Visible = true;
            showForm(false);
        }

        private void txtTimeShow_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string s = txtTimeShow.Text;
                int i = Int32.Parse(s);
                string sql = "update tbl_settings set time1='" + i + "'";
                DBAccess.executeNonQuery(sql);
            }
            catch
            {
                txtTimeShow.Text = "1";
                string sql = "update tbl_settings set time1=1";
                DBAccess.executeNonQuery(sql);
            }
        }

        private void txtTimeChange_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string s = txtTimeChange.Text;
                int i = Int32.Parse(s);
                int ii = i * 1000;
                timer2.Interval = ii;
                string sql = "update tbl_settings set time2='" + i + "'";
                DBAccess.executeNonQuery(sql);
            }
            catch
            {
                txtTimeChange.Text = "1";
                timer2.Interval = 1;
                string sql = "update tbl_settings set time2=1";
                DBAccess.executeNonQuery(sql);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exit();
        }

        private void manageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            noIcon.Visible = false;
            showForm(true);
        }

        private void noIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            noIcon.Visible = false;
            showForm(true);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Int64 i = (Int64)DBAccess.executeScalar(query_time2);
            int ii = Convert.ToInt32(i) * 1000;
            if (timer2.Interval == ii)
            {
                mainProc();
            }
        }
    }
}
