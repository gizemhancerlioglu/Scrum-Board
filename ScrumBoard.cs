using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace dxExample
{
    public partial class ScrumTable : Form
    {
        public ScrumTable()
        {
            InitializeComponent();
            gridControl1.DataSource = GetData(50);
            
        }
        DataTable dt = new DataTable();
        
        DataTable GetData(int rows)
        {
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Info", typeof(string));
            dt.Columns.Add("Value", typeof(string));
            dt.Columns.Add("Date", typeof(DateTime));
            dt.Columns.Add("Type", typeof(string));
            dt.Columns.Add("Check", typeof(string));
            dt.Rows.Add(null, null,null, null, "xDone", null);
            dt.Rows.Add(null, null, null, null, "!!! In Progress", null);
            dt.Rows.Add(null, null, null, null, "!! Do Today", null);
            dt.Rows.Add(null, null, null, null, "! Not Started", null);
            if (dt.Rows.Count == 4)
            {
                dt.Rows[0].GetType();
            }

            return dt;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dt.Rows.Add(txtLevel.Text, txtStoryName.Text, cboxUsers.Text, dtdatetime.Text, cboxEklenecekYer.Text, txtStoryName.Text);
            tileView1.RefreshData();
        }
    }
}
