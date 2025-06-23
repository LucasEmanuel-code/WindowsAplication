namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            MessageBox.Show("Inicializando o formulário pelo construtor");
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            txtResult.Text = "Ola aluno, este é seu primeiro programa - " + ((Estado)cboEstado.SelectedItem).Id;
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            var form = new FrmShow();
            form.lblMensagem.Text = txtResult.Text;
            form.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblHoraAtual.Text = "Dia e Hora atual" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            //maneira simples de utilizar

            cboEstado.DataSource = Estado.Lista();
            cboEstado.Text = "[Selecione]";

            dataGridView.DataSource = Estado.Lista();

            /* foreach (Estado estado in Estado.Lista())
             {
                 cboEstado.Items.Add(estado.Nome);
             }*/
            /*==============================================================*/
            //maneira intermediaria de utilizar
            //utilizando Link
            /*
            var data = from estado in Estado.Lista()
                     //where estado.Id == 1 || estado.Id == 2
                     //orderby estado.Nome
                       select new { 
                           Id = estado.Id,
                           Nome = estado.Nome
                       };
            dataGridView.DataSource = data.ToList();
            */
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void novoTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmTexto().Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmSobre().Show();
        }

        private void licençaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmLicenca().Show();
        }

        private void colaboraçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmDoacao().Show();
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHoraAtual.Text = "Dia e Hora atual" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }
    }
}
