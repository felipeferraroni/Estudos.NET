using System.Runtime.InteropServices;
using System.Windows.Forms;
using Basic.Base;
using Basic.DataBase.DDL;

namespace Basic.Views.DDL
{
    public partial class FrmDDLTable : FrmBaseView
    {
        private BasicDDL ddl;

        public FrmDDLTable()
        {
            InitializeComponent();
            ddl = new BasicDDL();
        }

        private void FrmDDLTable_Load(object sender, System.EventArgs e)
        {
            dataGridView1.DataSource = ddl.GetallTables();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            using (FrmDDLCreate frm = new FrmDDLCreate())
            {
                frm.ShowDialog();
            }
            dataGridView1.DataSource = ddl.GetallTables();
        }

        private void dataGridView1_SelectionChanged(object sender, System.EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
                dataGridView2.DataSource = ddl.GetaAllFieldsTable(dataGridView1.CurrentRow.Cells["TABLE_NAME"].Value.ToString());
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
                ddl.Delete(dataGridView1.CurrentRow.Cells["TABLE_NAME"].Value.ToString());
            dataGridView1.DataSource = ddl.GetallTables();
        }
    }
}
