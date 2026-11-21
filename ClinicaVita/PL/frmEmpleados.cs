using System;
using System.Windows.Forms;

namespace ClinicaVita.PL
{
    public partial class frmEmpleados : Form
    {
        public frmEmpleados()
        {
            InitializeComponent();
            ConfigurarEventos();
        }

        public frmEmpleados(bool modoAlta) : this()
        {
            if (modoAlta)
            {
                Text = "Clínica Vita | Agregar empleado";
                dataGridView1.ClearSelection();
                textBox1.Focus();
            }
        }

        private void ConfigurarEventos()
        {
            btnAgregar.Click += btnAgregar_Click;
            btnModificar.Click += btnModificar_Click;
            btnEliminar.Click += btnEliminar_Click;
            btnLimpiar.Click += btnLimpiar_Click;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
        }

        private void btnAgregar_Click(object? sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                return;
            }

            dataGridView1.Rows.Add(
                textBox1.Text.Trim(),
                textBox2.Text.Trim(),
                textBox3.Text.Trim(),
                dateTimePicker1.Value.ToShortDateString(),
                textBox4.Text.Trim(),
                departamentoTextBox.Text.Trim(),
                cargoTextBox.Text.Trim());

            LimpiarCampos();
        }

        private void btnModificar_Click(object? sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow is null || !ValidarCampos())
            {
                return;
            }

            var fila = dataGridView1.CurrentRow;
            fila.SetValues(
                textBox1.Text.Trim(),
                textBox2.Text.Trim(),
                textBox3.Text.Trim(),
                dateTimePicker1.Value.ToShortDateString(),
                textBox4.Text.Trim(),
                departamentoTextBox.Text.Trim(),
                cargoTextBox.Text.Trim());
        }

        private void btnEliminar_Click(object? sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow is not null)
            {
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                LimpiarCampos();
            }
        }

        private void btnLimpiar_Click(object? sender, EventArgs e)
        {
            LimpiarCampos();
            dataGridView1.ClearSelection();
        }

        private void dataGridView1_SelectionChanged(object? sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow is not DataGridViewRow fila ||
                fila.IsNewRow ||
                fila.Cells.Count < 7)
            {
                return;
            }

            textBox1.Text = fila.Cells[0].Value?.ToString() ?? string.Empty;
            textBox2.Text = fila.Cells[1].Value?.ToString() ?? string.Empty;
            textBox3.Text = fila.Cells[2].Value?.ToString() ?? string.Empty;
            textBox4.Text = fila.Cells[4].Value?.ToString() ?? string.Empty;
            departamentoTextBox.Text = fila.Cells[5].Value?.ToString() ?? string.Empty;
            cargoTextBox.Text = fila.Cells[6].Value?.ToString() ?? string.Empty;
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(departamentoTextBox.Text) ||
                string.IsNullOrWhiteSpace(cargoTextBox.Text))
            {
                MessageBox.Show(
                    "Completa el nombre, apellido, departamento y cargo.",
                    "Datos incompletos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return false;
            }

            return true;
        }

        private void LimpiarCampos()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            departamentoTextBox.Clear();
            cargoTextBox.Clear();
            dateTimePicker1.Value = DateTime.Today;
        }

    }
}