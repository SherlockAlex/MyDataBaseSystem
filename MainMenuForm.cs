using Mysqlx.Cursor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDataBaseSystem
{
    public partial class MainMenuForm : Form
    {

        DataViewForm dataViewForm;

        public MainMenuForm()
        {
            
            InitializeComponent();
            if (dataViewForm==null)
            {
                dataViewForm= new DataViewForm();
            }

        }

        private void addTravellerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void selectTravellerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataViewForm==null||dataViewForm.IsDisposed)
            {
                dataViewForm= new DataViewForm();
            }
            DataBaseSystem.Select("*","student");
            dataViewForm.Show();
            dataViewForm.UpdateDataGrid();
        }
    }
}
