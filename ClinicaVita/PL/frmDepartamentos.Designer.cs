namespace ClinicaVita.PL
{
    partial class frmDepartamentos
    {
        private System.ComponentModel.IContainer components = null;
        private Panel headerPanel;
        private Label titleLabel;
        private Label subtitleLabel;
        private Panel addPanel;
        private Label addTitleLabel; 
        private Label nameLabel;
        private TextBox txtNombreDepartamento;
        private Button btnAgregarDepartamento;
        private Panel listPanel;
        private Label listTitleLabel;
        private ListBox lstDepartamentos;

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
            components = new System.ComponentModel.Container();
            headerPanel = new Panel();
            titleLabel = new Label();
            subtitleLabel = new Label();
            addPanel = new Panel();
            addTitleLabel = new Label();
            nameLabel = new Label();
            txtNombreDepartamento = new TextBox();
            btnAgregarDepartamento = new Button();
            listPanel = new Panel();
            listTitleLabel = new Label();
            lstDepartamentos = new ListBox();
            headerPanel.SuspendLayout();
            addPanel.SuspendLayout();
            listPanel.SuspendLayout();
            SuspendLayout();
            // headerPanel
            headerPanel.BackColor = Color.FromArgb(21, 101, 112);
            headerPanel.Controls.Add(subtitleLabel);
            headerPanel.Controls.Add(titleLabel);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(780, 92);
            // titleLabel
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 23F, FontStyle.Bold);
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(28, 12);
            titleLabel.Name = "titleLabel";
            titleLabel.Text = "Departamentos";
            // subtitleLabel
            subtitleLabel.AutoSize = true;
            subtitleLabel.Font = new Font("Segoe UI", 10F);
            subtitleLabel.ForeColor = Color.FromArgb(204, 239, 237);
            subtitleLabel.Location = new Point(32, 57);
            subtitleLabel.Name = "subtitleLabel";
            subtitleLabel.Text = "Agrega y consulta los departamentos de la clínica";
            // addPanel
            addPanel.BackColor = Color.White;
            addPanel.BorderStyle = BorderStyle.FixedSingle;
            addPanel.Controls.Add(btnAgregarDepartamento);
            addPanel.Controls.Add(txtNombreDepartamento);
            addPanel.Controls.Add(nameLabel);
            addPanel.Controls.Add(addTitleLabel);
            addPanel.Location = new Point(28, 112);
            addPanel.Name = "addPanel";
            addPanel.Size = new Size(724, 132);
            // addTitleLabel
            addTitleLabel.AutoSize = true;
            addTitleLabel.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            addTitleLabel.ForeColor = Color.FromArgb(21, 101, 112);
            addTitleLabel.Location = new Point(22, 16);
            addTitleLabel.Name = "addTitleLabel";
            addTitleLabel.Text = "Agregar nuevo departamento";
            // nameLabel
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            nameLabel.ForeColor = Color.FromArgb(71, 87, 92);
            nameLabel.Location = new Point(23, 54);
            nameLabel.Name = "nameLabel";
            nameLabel.Text = "Nombre del departamento";
            // txtNombreDepartamento
            txtNombreDepartamento.Location = new Point(23, 75);
            txtNombreDepartamento.Name = "txtNombreDepartamento";
            txtNombreDepartamento.Size = new Size(390, 23);
            txtNombreDepartamento.TabIndex = 0;
            // btnAgregarDepartamento
            btnAgregarDepartamento.BackColor = Color.FromArgb(21, 101, 112);
            btnAgregarDepartamento.FlatAppearance.BorderSize = 0;
            btnAgregarDepartamento.FlatStyle = FlatStyle.Flat;
            btnAgregarDepartamento.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAgregarDepartamento.ForeColor = Color.White;
            btnAgregarDepartamento.Location = new Point(435, 68);
            btnAgregarDepartamento.Name = "btnAgregarDepartamento";
            btnAgregarDepartamento.Size = new Size(255, 34);
            btnAgregarDepartamento.TabIndex = 1;
            btnAgregarDepartamento.Text = "Agregar departamento";
            btnAgregarDepartamento.UseVisualStyleBackColor = false;
            // listPanel
            listPanel.BackColor = Color.White;
            listPanel.BorderStyle = BorderStyle.FixedSingle;
            listPanel.Controls.Add(lstDepartamentos);
            listPanel.Controls.Add(listTitleLabel);
            listPanel.Location = new Point(28, 264);
            listPanel.Name = "listPanel";
            listPanel.Size = new Size(724, 300);
            // listTitleLabel
            listTitleLabel.AutoSize = true;
            listTitleLabel.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            listTitleLabel.ForeColor = Color.FromArgb(21, 101, 112);
            listTitleLabel.Location = new Point(22, 15);
            listTitleLabel.Name = "listTitleLabel";
            listTitleLabel.Text = "Departamentos registrados";
            // lstDepartamentos
            lstDepartamentos.BorderStyle = BorderStyle.FixedSingle;
            lstDepartamentos.Font = new Font("Segoe UI", 10F);
            lstDepartamentos.FormattingEnabled = true;
            lstDepartamentos.ItemHeight = 17;
            lstDepartamentos.Location = new Point(22, 58);
            lstDepartamentos.Name = "lstDepartamentos";
            lstDepartamentos.Size = new Size(676, 220);
            lstDepartamentos.TabIndex = 0;
            // frmDepartamentos
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 249, 250);
            ClientSize = new Size(780, 600);
            Controls.Add(listPanel);
            Controls.Add(addPanel);
            Controls.Add(headerPanel);
            Font = new Font("Segoe UI", 9F);
            MinimumSize = new Size(780, 600);
            Name = "frmDepartamentos";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Clínica Vita | Departamentos";
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            addPanel.ResumeLayout(false);
            addPanel.PerformLayout();
            listPanel.ResumeLayout(false);
            listPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
    }
}