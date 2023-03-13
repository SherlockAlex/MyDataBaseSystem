﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;

namespace MyDataBaseSystem
{

    internal class DataBaseSystem
    {

        static MySqlConnection connection=null;

        static List<string> result = new List<string>();

        public static List<string> Result()
        {
            return result;
        }

        public static int ConnectionToDataBase(
            string database,
            string server,
            int port,
            string passwd,
            string userID)
        {
            //0表示连接成功,非0表示失败
            try
            {
                connection = CreateConnection(database, server, port, passwd, userID);
                connection.Open();
                if (connection.State != ConnectionState.Open)
                {
                    //连接失败
                    return -1;
                }
            }
            catch(Exception ex)
            {
                return -1;
            }
            
            return 0;
        }

        

        public static MySqlConnection CreateConnection(
            string database,
            string server,
            int port,
            string passwd,
            string userID
            )
        {
            //创建一个连接
            string databaseInfo = "Database=" + database + ";";
            string serverInfo = "Server=" + server + ";";
            string portInfo = "Port=" + port + ";";
            string passwdInfo = "Password=" + passwd + ";";
            string userIDInfo = "UserID=" + userID + ";";
            string charSetInfo = "charset=utf8mb4;";
            return new MySqlConnection(databaseInfo+serverInfo+portInfo+passwdInfo+userIDInfo+charSetInfo);
        }

        public static void UseDataBase(string database)
        {
            //使用数据库
            MySqlCommand command = new MySqlCommand(
            //use database;select column from table;
                ("use "+database+";")
                );
        }

        /*从database，table查找colum中数据，成功返回0，否则非0*/
        public static void Select(string column,string table)
        {
            //当没有连接到数据库时
            if (connection.Database=="")
            {
                return;
            }
            //创建查询,单链表但输入查询
            MySqlCommand command = new MySqlCommand(
                //use database;select column from table;
                ("select "+column+" from "+table+";"),
                connection
                );

            //将返回的结果存到数组列表中
            MySqlDataReader dataReader= command.ExecuteReader();

            result.Clear();

            int columnCount = dataReader.FieldCount;            //返回的属性个数
            string columnsName = "";
            for (int i = 0; i < columnCount; i++)
            {
                columnsName += (dataReader.GetName(i) + " ");
            }
            result.Add(columnsName);

            //result.Add(dataReader.GetName(0) + "  " + dataReader.GetName(1));
            while (dataReader.Read())
            {
                string values = "";
                for (int i = 0; i < columnCount; i++)
                {
                    values += (dataReader.GetString(i) + " ");
                }
                result.Add(values);

                //result.Add(dataReader.GetString(0)+"  "+dataReader.GetString(1));
            }

        }
    }
}
