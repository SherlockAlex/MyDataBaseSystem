using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDataBaseSystem
{
    public partial class DataViewForm : Form
    {
        public DataViewForm()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            //搜索按钮按下的时候，查询相关内容
            string searchColumn = (columnTextBox.Text == "" ? "*": columnTextBox.Text);
            string searchTable = (tableTextBox.Text == ""?"student":tableTextBox.Text);
            DataBaseSystem.Select(searchColumn, searchTable);
            UpdateDataGrid();
        }

        public void UpdateDataGrid()
        {
            DataGridView gridView = this.GetDataGridView;

            //更新
            gridView.Rows.Clear();
            gridView.Columns.Clear();

            for (int j = 0; j < DataBaseSystem.Result()[0].Count; j++)
            {
                DataGridViewTextBoxColumn dataColumn = new DataGridViewTextBoxColumn();
                gridView.Columns.Add(dataColumn);
                gridView.Columns[j].HeaderText = DataBaseSystem.Result()[0][j];
                gridView.Columns[j].ReadOnly = true;                             //只读
            }

            for (int i = 1; i < DataBaseSystem.Result().Count; i++)
            {
                //添加一行
                int index = gridView.Rows.Add();
                for (int j = 0; j < DataBaseSystem.Result()[0].Count; j++)
                {
                    gridView.Rows[index].Cells[j].Value = DataBaseSystem.Result()[i][j];
                }
            }
        }

    }
}
