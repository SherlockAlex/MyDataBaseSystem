using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace MyDataBaseSystem
{
    public partial class LoginForm : Form
    {
        DataViewForm dataViewForm;
        public LoginForm()
        {
            dataViewForm= new DataViewForm();
            InitializeComponent();
            databaseSelect.Items.Add("test");
            databaseSelect.Items.Add("test1");
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            //登录到数据库系统，并且显示接下来的操作页面
            //使用单例模式，每次登录都创建一个对象


            string database = databaseSelect.Text;          //数据库名
            string server = "localhost";                    //服务器
            int port = 3306;                                //端口号
            string passwd = password.Text;                  //密码
            string userID = user.Text;                      //用户名

            int connect = DataBaseSystem.ConnectionToDataBase(database, server, port, passwd, userID);

            if (connect!=0)
            {
                MessageBox.Show("连接失败!!!\n请输入正确的用户名或密码");
                return;
            }
            MessageBox.Show("连接成功");

            //下面代码是测试用的


            DataBaseSystem.Select("*","student");

            dataViewForm.Show();

            DataGridView gridView = dataViewForm.GetDataGridView;
            for (int j = 0; j < DataBaseSystem.Result()[0].Count; j++)
            {
                DataGridViewTextBoxColumn dataColumn = new DataGridViewTextBoxColumn();
                gridView.Columns.Add(dataColumn);
                gridView.Columns[j].HeaderText = DataBaseSystem.Result()[0][j];
                gridView.Columns[j].ReadOnly= true;                             //只读
            }

            for (int i=1;i< DataBaseSystem.Result().Count;i++)
            {
                //添加一行
                int index = gridView.Rows.Add();
                for (int j=0;j< DataBaseSystem.Result()[0].Count;j++)
                {
                    gridView.Rows[index].Cells[j].Value = DataBaseSystem.Result()[i][j];
                }
            }

        }
    }
}
