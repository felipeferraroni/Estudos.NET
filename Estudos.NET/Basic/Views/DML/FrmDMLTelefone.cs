using System.Windows.Forms;
using Basic.DataBase.DML;

namespace Basic.Views.DML
{
    public class FrmDMLTelefone : Form
    {
        private BasicDML dml;
        private Label label1;
        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox maskedTextBox2;
        private Button button1;
        private int ContatoId;

        public FrmDMLTelefone(int id)
        {
            InitializeComponent();
            dml = new BasicDML();
            ContatoId = id;
        }


        private void button1_Click(object sender, System.EventArgs e)
        {
            string ddd = maskedTextBox1.Text.Replace("(", "").Replace(")", "").Replace("_", "");
            string numero = maskedTextBox2.Text.Replace("-", "").Replace("_", "");

            if (!string.IsNullOrWhiteSpace(ddd) && !string.IsNullOrWhiteSpace(numero))
            {
                dml.InsertTelefone(ddd,numero,ContatoId);
                Close();
            }

        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Telefone";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(90, 85);
            this.maskedTextBox1.Mask = "(00)";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(26, 20);
            this.maskedTextBox1.TabIndex = 1;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(133, 85);
            this.maskedTextBox2.Mask = "00000-0000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(69, 20);
            this.maskedTextBox2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(228, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmDMLTelefone
            // 
            this.ClientSize = new System.Drawing.Size(354, 200);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label1);
            this.Name = "FrmDMLTelefone";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}