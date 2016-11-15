using Basic.Base;
using Basic.DataBase.DML;
using Basic.Functions;

namespace Basic.Views.DML
{
    public partial class FrmDMLTable : FrmBaseView
    {
        private BasicDML dml;
        public FrmDMLTable()
        {
            InitializeComponent();
            Modificatitulo("Tela DML");
            dml = new BasicDML();
            dml.DeleteTable();
            dml.CriarTable();
        }

        private void FrmDMLTable_Load(object sender, System.EventArgs e)
        {
            dataGridView1.DataSource = dml.LoadTable("Contato");
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            var frm = new FrmDMLContato();
            frm.ShowDialog();
            dataGridView1.DataSource = dml.LoadTable("Contato");
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Index > -1)
            {
                var frm = new FrmDMLTelefone(dataGridView1.CurrentRow.Cells["ContatoId"].Value.ToInt());
                frm.ShowDialog();
                dataGridView2.DataSource = dml.LoadTable("Telefone", dataGridView1.CurrentRow.Cells["ContatoId"].Value.ToInt(), "Contato");
            }
        }

        private void dataGridView1_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Index > -1)
            {
                dataGridView2.DataSource = dml.LoadTable("Telefone", dataGridView1.CurrentRow.Cells["ContatoId"].Value.ToInt(), "Contato");
            }
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Index > -1)
            {
                dml.Exclude("Contato",dataGridView1.CurrentRow.Cells["Contatoid"].Value.ToInt());

                dataGridView1.DataSource = dml.LoadTable("Contato");
            }
        }

        private void button4_Click(object sender, System.EventArgs e)
        {
            if (dataGridView2.CurrentRow != null && dataGridView2.CurrentRow.Index > -1)
            {
                dml.Exclude("Telefone", dataGridView2.CurrentRow.Cells["TelefoneId"].Value.ToInt());
                dataGridView2.DataSource = dml.LoadTable("Telefone", dataGridView1.CurrentRow.Cells["ContatoId"].Value.ToInt(), "Contato");
            }

        }
    }
}
