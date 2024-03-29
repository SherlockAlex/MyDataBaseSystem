﻿using System;
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
        //DataViewForm dataViewForm;
        MainMenuForm mainMenuForm;

        public LoginForm()
        {
            //dataViewForm= new DataViewForm();
            mainMenuForm= new MainMenuForm();
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
            MessageBox.Show("登录成功");

            //下面代码是测试用的
            //主要时更新表格
            //隐藏登录页面

            //dataViewForm.Show();
            mainMenuForm.Show();
            //Program.SetCurrentForm(mainMenuForm);
            //Close();
            //将程序控制权交给mainMenuForm
        }
    }
}
