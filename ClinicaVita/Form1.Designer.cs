namespace ClinicaVita
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Panel headerPanel;
        private Panel navigationPanel;
        private Panel contentPanel;
        private Panel employeesCard;
        private Panel departmentsCard;
        private Label logoLabel;
        private Label subtitleLabel;
        private Label welcomeLabel;
        private Label descriptionLabel;
        private Label sectionLabel;
        private Label employeesTitleLabel;
        private Label employeesDescriptionLabel;
        private Label departmentsTitleLabel;
        private Label departmentsDescriptionLabel;
        private Label footerLabel;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;

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
            headerPanel = new Panel();
            subtitleLabel = new Label();
            logoLabel = new Label();
            navigationPanel = new Panel();
            button4 = new Button();
            button1 = new Button();
            contentPanel = new Panel();
            footerLabel = new Label();
            departmentsCard = new Panel();
            button2 = new Button();
            departmentsDescriptionLabel = new Label();
            departmentsTitleLabel = new Label();
            employeesCard = new Panel();
            button3 = new Button();
            employeesDescriptionLabel = new Label();
            employeesTitleLabel = new Label();
            sectionLabel = new Label();
            descriptionLabel = new Label();
            welcomeLabel = new Label();
            headerPanel.SuspendLayout();
            navigationPanel.SuspendLayout();
            contentPanel.SuspendLayout();
            departmentsCard.SuspendLayout();
            employeesCard.SuspendLayout();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(21, 101, 112);
            headerPanel.Controls.Add(subtitleLabel);
            headerPanel.Controls.Add(logoLabel);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Padding = new Padding(28, 16, 20, 10);
            headerPanel.Size = new Size(1023, 96);
            headerPanel.TabIndex = 2;
            // 
            // subtitleLabel
            // 
            subtitleLabel.AutoSize = true;
            subtitleLabel.Font = new Font("Segoe UI", 10F);
            subtitleLabel.ForeColor = Color.FromArgb(204, 239, 237);
            subtitleLabel.Location = new Point(32, 58);
            subtitleLabel.Name = "subtitleLabel";
            subtitleLabel.Size = new Size(238, 19);
            subtitleLabel.TabIndex = 0;
            subtitleLabel.Text = "Cuidamos de ti, cuidamos de tu salud";
            // 
            // logoLabel
            // 
            logoLabel.AutoSize = true;
            logoLabel.Font = new Font("Segoe UI", 23F, FontStyle.Bold);
            logoLabel.ForeColor = Color.White;
            logoLabel.Location = new Point(28, 12);
            logoLabel.Name = "logoLabel";
            logoLabel.Size = new Size(216, 42);
            logoLabel.TabIndex = 1;
            logoLabel.Text = "CLÍNICA VITA";
            // 
            // navigationPanel
            // 
            navigationPanel.BackColor = Color.FromArgb(37, 75, 82);
            navigationPanel.Controls.Add(button4);
            navigationPanel.Controls.Add(button1);
            navigationPanel.Dock = DockStyle.Left;
            navigationPanel.Location = new Point(0, 96);
            navigationPanel.Name = "navigationPanel";
            navigationPanel.Padding = new Padding(14, 28, 14, 16);
            navigationPanel.Size = new Size(205, 483);
            navigationPanel.TabIndex = 1;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button4.BackColor = Color.FromArgb(37, 75, 82);
            button4.FlatAppearance.BorderColor = Color.FromArgb(130, 155, 159);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 10F);
            button4.ForeColor = Color.White;
            button4.Location = new Point(14, 409);
            button4.Name = "button4";
            button4.Size = new Size(177, 44);
            button4.TabIndex = 1;
            button4.Text = "Cerrar aplicación";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(37, 75, 82);
            button1.FlatAppearance.BorderColor = Color.FromArgb(104, 183, 180);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(14, 28);
            button1.Name = "button1";
            button1.Size = new Size(177, 48);
            button1.TabIndex = 0;
            button1.Text = "  Comprobar conexión";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // contentPanel
            // 
            contentPanel.BackColor = Color.FromArgb(246, 249, 250);
            contentPanel.Controls.Add(footerLabel);
            contentPanel.Controls.Add(departmentsCard);
            contentPanel.Controls.Add(employeesCard);
            contentPanel.Controls.Add(sectionLabel);
            contentPanel.Controls.Add(descriptionLabel);
            contentPanel.Controls.Add(welcomeLabel);
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(205, 96);
            contentPanel.Name = "contentPanel";
            contentPanel.Padding = new Padding(42, 34, 42, 20);
            contentPanel.Size = new Size(818, 483);
            contentPanel.TabIndex = 0;
            // 
            // footerLabel
            // 
            footerLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            footerLabel.AutoSize = true;
            footerLabel.Font = new Font("Segoe UI", 9F);
            footerLabel.ForeColor = Color.FromArgb(130, 145, 149);
            footerLabel.Location = new Point(45, 459);
            footerLabel.Name = "footerLabel";
            footerLabel.Size = new Size(160, 15);
            footerLabel.TabIndex = 0;
            footerLabel.Text = "Clínica Vita  •  Gestión clínica";
            // 
            // departmentsCard
            // 
            departmentsCard.BackColor = Color.White;
            departmentsCard.BorderStyle = BorderStyle.FixedSingle;
            departmentsCard.Controls.Add(button2);
            departmentsCard.Controls.Add(departmentsDescriptionLabel);
            departmentsCard.Controls.Add(departmentsTitleLabel);
            departmentsCard.Location = new Point(418, 184);
            departmentsCard.Name = "departmentsCard";
            departmentsCard.Size = new Size(348, 190);
            departmentsCard.TabIndex = 2;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(76, 151, 148);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(24, 123);
            button2.Name = "button2";
            button2.Size = new Size(178, 40);
            button2.TabIndex = 0;
            button2.Text = "Ir a departamentos";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // departmentsDescriptionLabel
            // 
            departmentsDescriptionLabel.Font = new Font("Segoe UI", 10F);
            departmentsDescriptionLabel.ForeColor = Color.FromArgb(91, 108, 113);
            departmentsDescriptionLabel.Location = new Point(24, 58);
            departmentsDescriptionLabel.Name = "departmentsDescriptionLabel";
            departmentsDescriptionLabel.Size = new Size(295, 45);
            departmentsDescriptionLabel.TabIndex = 1;
            departmentsDescriptionLabel.Text = "Organiza las áreas de atención y consulta los departamentos disponibles.";
            // 
            // departmentsTitleLabel
            // 
            departmentsTitleLabel.AutoSize = true;
            departmentsTitleLabel.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            departmentsTitleLabel.ForeColor = Color.FromArgb(21, 101, 112);
            departmentsTitleLabel.Location = new Point(22, 20);
            departmentsTitleLabel.Name = "departmentsTitleLabel";
            departmentsTitleLabel.Size = new Size(159, 28);
            departmentsTitleLabel.TabIndex = 2;
            departmentsTitleLabel.Text = "Departamentos";
            // 
            // employeesCard
            // 
            employeesCard.BackColor = Color.White;
            employeesCard.BorderStyle = BorderStyle.FixedSingle;
            employeesCard.Controls.Add(button3);
            employeesCard.Controls.Add(employeesDescriptionLabel);
            employeesCard.Controls.Add(employeesTitleLabel);
            employeesCard.Location = new Point(46, 184);
            employeesCard.Name = "employeesCard";
            employeesCard.Size = new Size(348, 190);
            employeesCard.TabIndex = 3;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(21, 101, 112);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(24, 123);
            button3.Name = "button3";
            button3.Size = new Size(150, 40);
            button3.TabIndex = 0;
            button3.Text = "Ir a empleados";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // employeesDescriptionLabel
            // 
            employeesDescriptionLabel.Font = new Font("Segoe UI", 10F);
            employeesDescriptionLabel.ForeColor = Color.FromArgb(91, 108, 113);
            employeesDescriptionLabel.Location = new Point(24, 58);
            employeesDescriptionLabel.Name = "employeesDescriptionLabel";
            employeesDescriptionLabel.Size = new Size(295, 45);
            employeesDescriptionLabel.TabIndex = 1;
            employeesDescriptionLabel.Text = "Administra el personal y consulta la información de los profesionales de la clínica.";
            // 
            // employeesTitleLabel
            // 
            employeesTitleLabel.AutoSize = true;
            employeesTitleLabel.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            employeesTitleLabel.ForeColor = Color.FromArgb(21, 101, 112);
            employeesTitleLabel.Location = new Point(22, 20);
            employeesTitleLabel.Name = "employeesTitleLabel";
            employeesTitleLabel.Size = new Size(114, 28);
            employeesTitleLabel.TabIndex = 2;
            employeesTitleLabel.Text = "Empleados";
            // 
            // sectionLabel
            // 
            sectionLabel.AutoSize = true;
            sectionLabel.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            sectionLabel.ForeColor = Color.FromArgb(21, 101, 112);
            sectionLabel.Location = new Point(46, 142);
            sectionLabel.Name = "sectionLabel";
            sectionLabel.Size = new Size(177, 25);
            sectionLabel.TabIndex = 4;
            sectionLabel.Text = "Accesos principales";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new Font("Segoe UI", 11F);
            descriptionLabel.ForeColor = Color.FromArgb(91, 108, 113);
            descriptionLabel.Location = new Point(46, 80);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(430, 20);
            descriptionLabel.TabIndex = 5;
            descriptionLabel.Text = "Gestiona la información de tu clínica de forma rápida y sencilla.";
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            welcomeLabel.ForeColor = Color.FromArgb(31, 65, 72);
            welcomeLabel.Location = new Point(42, 34);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(389, 45);
            welcomeLabel.TabIndex = 6;
            welcomeLabel.Text = "Bienvenido a Clínica Vita";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 249, 250);
            ClientSize = new Size(1023, 579);
            Controls.Add(contentPanel);
            Controls.Add(navigationPanel);
            Controls.Add(headerPanel);
            Font = new Font("Segoe UI", 9F);
            MinimumSize = new Size(900, 600);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clínica Vita | Inicio";
            Load += Form1_Load;
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            navigationPanel.ResumeLayout(false);
            contentPanel.ResumeLayout(false);
            contentPanel.PerformLayout();
            departmentsCard.ResumeLayout(false);
            departmentsCard.PerformLayout();
            employeesCard.ResumeLayout(false);
            employeesCard.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
    }
}
