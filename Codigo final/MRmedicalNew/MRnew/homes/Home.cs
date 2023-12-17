namespace MRnew
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void butIngresoSistem_Click(object sender, EventArgs e)
        {
            LogUsuario form = new LogUsuario();
            form.Show();
            this.Hide();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}