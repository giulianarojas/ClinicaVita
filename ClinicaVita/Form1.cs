using ClinicaVita.DAL;
using ClinicaVita.PL;

namespace ClinicaVita
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (var con = Conexion.ObtenerConexion())
                {
                    con.Open();
                    MessageBox.Show("La conexión con la base de datos fue exitosa.", "Clínica Vita", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión: " + ex.Message, "Clínica Vita", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Error de conexión: " + ex.Message, "Clínica Vita", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using var formulario = new frmDepartamentos();
            formulario.ShowDialog(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using var formulario = new frmEmpleados();
            formulario.ShowDialog(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void employeesCard_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
