using System;
using System.Windows.Forms;
using System.Text;

namespace Hard_Drive_Info
{
    public partial class DiskInfoDisplay : UserControl
    {
        private DriveInformation driveInfo;
        

        public DriveInformation DriveInfo
        {
            get { return driveInfo; }
            set
            {
                driveInfo = value;
                RefreshDisplay();
            }
        }

        public DiskInfoDisplay()
        {
            InitializeComponent();

            bindingNavigator1.DeleteItem.Enabled = false;
        }

        public void RefreshDisplay()
        {
            bindingNavigator1.BindingSource = null;
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Refresh();

            txtErrors.Clear();

            if (driveInfo == null)
                return;

            BindingSource bsDrives = new BindingSource { DataSource = driveInfo.Drives, AllowNew = false };

            dataGridView1.DataSource = bsDrives;
            bindingNavigator1.BindingSource = bsDrives;
            dataGridView1.Refresh();

            foreach (string errmsg in driveInfo.Messages)
            {
                if (txtErrors.Text.Length > 0)
                    txtErrors.AppendText("\r\n");

                txtErrors.AppendText(errmsg);
            }
        }

        private void cmdRefresh_Click(object sender, EventArgs e)
        {
            driveInfo.Refresh();
            RefreshDisplay();
        }

        private void cmdCopy_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == null || dataGridView1.Columns.Count == 0)
                return;

            StringBuilder clipData = new StringBuilder("");
            int currentRow = -1;

            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                if(currentRow < 0)
                {
                    currentRow = 0;
                    clipData.AppendLine(GetColumnNames(dataGridView1.Columns));
                }

                clipData.AppendLine(GetRow(row));

                currentRow++;
            }

            Clipboard.SetText(clipData.ToString());
        }

        private string GetColumnNames(DataGridViewColumnCollection cols)
        {
            string retVal = "";

            foreach(DataGridViewColumn col in cols)
            {
                if (!string.IsNullOrEmpty(retVal))
                    retVal += "\t";

                retVal += col.HeaderText;
            }

            return retVal;
        }

        private string GetRow(DataGridViewRow row)
        {
            string retVal = "";

            foreach (DataGridViewCell cell in row.Cells)
            {
                if (!string.IsNullOrEmpty(retVal))
                    retVal += "\t";

                retVal += cell.Value.ToString();
            }

            return retVal;
        }
    }
}
