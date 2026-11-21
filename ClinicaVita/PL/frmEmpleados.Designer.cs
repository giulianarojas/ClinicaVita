namespace ClinicaVita.PL
{
    partial class frmEmpleados
    {
        private System.ComponentModel.IContainer components = null;
        private Panel headerPanel;
        private Panel formPanel;
        private Panel tablePanel;
        private Label titleLabel;
        private Label subtitleLabel;
        private Label formTitleLabel;
        private Label tableTitleLabel;
        private Label emptyStateLabel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox4;
        private TextBox departamentoTextBox;
        private TextBox cargoTextBox;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnLimpiar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            headerPanel = new Panel();
            subtitleLabel = new Label();
            titleLabel = new Label();
            formPanel = new Panel();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            textBox4 = new TextBox();
            cargoTextBox = new TextBox();
            departamentoTextBox = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            formTitleLabel = new Label();
            tablePanel = new Panel();
            emptyStateLabel = new Label();
            dataGridView1 = new DataGridView();
            tableTitleLabel = new Label();
            comboBox1 = new ComboBox();
            headerPanel.SuspendLayout();
            formPanel.SuspendLayout();
            tablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(21, 101, 112);
            headerPanel.Controls.Add(subtitleLabel);
            headerPanel.Controls.Add(titleLabel);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(1050, 92);
            headerPanel.TabIndex = 2;
            // 
            // subtitleLabel
            // 
            subtitleLabel.AutoSize = true;
            subtitleLabel.Font = new Font("Segoe UI", 10F);
            subtitleLabel.ForeColor = Color.FromArgb(204, 239, 237);
            subtitleLabel.Location = new Point(32, 57);
            subtitleLabel.Name = "subtitleLabel";
            subtitleLabel.Size = new Size(347, 19);
            subtitleLabel.TabIndex = 0;
            subtitleLabel.Text = "Administra el equipo que hace posible nuestra atención";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 23F, FontStyle.Bold);
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(28, 12);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(454, 42);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "Administración de empleados";
            // 
            // formPanel
            // 
            formPanel.BackColor = Color.White;
            formPanel.BorderStyle = BorderStyle.FixedSingle;
            formPanel.Controls.Add(btnLimpiar);
            formPanel.Controls.Add(btnEliminar);
            formPanel.Controls.Add(btnModificar);
            formPanel.Controls.Add(btnAgregar);
            formPanel.Controls.Add(textBox4);
            formPanel.Controls.Add(cargoTextBox);
            formPanel.Controls.Add(departamentoTextBox);
            formPanel.Controls.Add(dateTimePicker1);
            formPanel.Controls.Add(textBox3);
            formPanel.Controls.Add(textBox2);
            formPanel.Controls.Add(textBox1);
            formPanel.Controls.Add(label5);
            formPanel.Controls.Add(label7);
            formPanel.Controls.Add(label6);
            formPanel.Controls.Add(label4);
            formPanel.Controls.Add(label3);
            formPanel.Controls.Add(label2);
            formPanel.Controls.Add(label1);
            formPanel.Controls.Add(formTitleLabel);
            formPanel.Location = new Point(28, 112);
            formPanel.Name = "formPanel";
            formPanel.Size = new Size(994, 210);
            formPanel.TabIndex = 1;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(232, 238, 239);
            btnLimpiar.FlatAppearance.BorderColor = Color.FromArgb(155, 170, 173);
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLimpiar.ForeColor = Color.FromArgb(71, 87, 92);
            btnLimpiar.Location = new Point(793, 160);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(118, 34);
            btnLimpiar.TabIndex = 0;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(190, 74, 74);
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(663, 160);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(118, 34);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(76, 151, 148);
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(793, 120);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(118, 34);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(21, 101, 112);
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(663, 120);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(118, 34);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(783, 75);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(185, 23);
            textBox4.TabIndex = 4;
            // 
            // cargoTextBox
            // 
            cargoTextBox.Location = new Point(343, 127);
            cargoTextBox.Name = "cargoTextBox";
            cargoTextBox.Size = new Size(300, 23);
            cargoTextBox.TabIndex = 6;
            // 
            // departamentoTextBox
            // 
            departamentoTextBox.Location = new Point(23, 127);
            departamentoTextBox.Name = "departamentoTextBox";
            departamentoTextBox.Size = new Size(300, 23);
            departamentoTextBox.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(613, 75);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(150, 23);
            dateTimePicker1.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(443, 75);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 23);
            textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(233, 75);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(190, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(23, 75);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(190, 23);
            textBox1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(71, 87, 92);
            label5.Location = new Point(783, 54);
            label5.Name = "label5";
            label5.Size = new Size(111, 15);
            label5.TabIndex = 7;
            label5.Text = "Correo electrónico";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(71, 87, 92);
            label7.Location = new Point(343, 106);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 8;
            label7.Text = "Cargo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(71, 87, 92);
            label6.Location = new Point(23, 106);
            label6.Name = "label6";
            label6.Size = new Size(89, 15);
            label6.TabIndex = 9;
            label6.Text = "Departamento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(71, 87, 92);
            label4.Location = new Point(613, 54);
            label4.Name = "label4";
            label4.Size = new Size(100, 15);
            label4.TabIndex = 10;
            label4.Text = "Fecha de ingreso";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(71, 87, 92);
            label3.Location = new Point(443, 54);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 11;
            label3.Text = "DNI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(71, 87, 92);
            label2.Location = new Point(233, 54);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 12;
            label2.Text = "Apellido";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(71, 87, 92);
            label1.Location = new Point(23, 54);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 13;
            label1.Text = "Nombre";
            // 
            // formTitleLabel
            // 
            formTitleLabel.AutoSize = true;
            formTitleLabel.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            formTitleLabel.ForeColor = Color.FromArgb(21, 101, 112);
            formTitleLabel.Location = new Point(22, 16);
            formTitleLabel.Name = "formTitleLabel";
            formTitleLabel.Size = new Size(181, 25);
            formTitleLabel.TabIndex = 14;
            formTitleLabel.Text = "Datos del empleado";
            // 
            // tablePanel
            // 
            tablePanel.BackColor = Color.White;
            tablePanel.BorderStyle = BorderStyle.FixedSingle;
            tablePanel.Controls.Add(comboBox1);
            tablePanel.Controls.Add(emptyStateLabel);
            tablePanel.Controls.Add(dataGridView1);
            tablePanel.Controls.Add(tableTitleLabel);
            tablePanel.Location = new Point(28, 340);
            tablePanel.Name = "tablePanel";
            tablePanel.Size = new Size(994, 300);
            tablePanel.TabIndex = 0;
            // 
            // emptyStateLabel
            // 
            emptyStateLabel.AutoSize = true;
            emptyStateLabel.BackColor = Color.White;
            emptyStateLabel.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            emptyStateLabel.ForeColor = Color.FromArgb(130, 145, 149);
            emptyStateLabel.Location = new Point(370, 150);
            emptyStateLabel.Name = "emptyStateLabel";
            emptyStateLabel.Size = new Size(201, 19);
            emptyStateLabel.TabIndex = 0;
            emptyStateLabel.Text = "No hay empleados registrados";
            emptyStateLabel.Visible = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeight = 36;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(22, 58);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(948, 215);
            dataGridView1.TabIndex = 0;
            // 
            // tableTitleLabel
            // 
            tableTitleLabel.AutoSize = true;
            tableTitleLabel.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            tableTitleLabel.ForeColor = Color.FromArgb(21, 101, 112);
            tableTitleLabel.Location = new Point(22, 15);
            tableTitleLabel.Name = "tableTitleLabel";
            tableTitleLabel.Size = new Size(204, 25);
            tableTitleLabel.TabIndex = 1;
            tableTitleLabel.Text = "Empleados registrados";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(193, 274);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 2;
            // 
            // frmEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 249, 250);
            ClientSize = new Size(1050, 670);
            Controls.Add(tablePanel);
            Controls.Add(formPanel);
            Controls.Add(headerPanel);
            Font = new Font("Segoe UI", 9F);
            MinimumSize = new Size(900, 600);
            Name = "frmEmpleados";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Clínica Vita | Empleados";
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            formPanel.ResumeLayout(false);
            formPanel.PerformLayout();
            tablePanel.ResumeLayout(false);
            tablePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBox1;
    }
}
