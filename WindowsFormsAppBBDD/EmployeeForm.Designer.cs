namespace WindowsFormsAppBBDD
{
    partial class EmployeeForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.addNewEmployeeBtn = new System.Windows.Forms.Button();
            this.nameEmployeeTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lastNameEmployeeTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.emailEmployeeTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.phoneNumberEmployeeTB = new System.Windows.Forms.TextBox();
            this.hireDateEmployeeDP = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.salaryEmployeeNUD = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.jobCB = new System.Windows.Forms.ComboBox();
            this.departmentCB = new System.Windows.Forms.ComboBox();
            this.managerCB = new System.Windows.Forms.ComboBox();
            this.employeesComboBox = new System.Windows.Forms.ComboBox();
            this.butUpdateEmployee = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.salaryEmployeeNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // addNewEmployeeBtn
            // 
            this.addNewEmployeeBtn.Location = new System.Drawing.Point(281, 360);
            this.addNewEmployeeBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addNewEmployeeBtn.Name = "addNewEmployeeBtn";
            this.addNewEmployeeBtn.Size = new System.Drawing.Size(169, 49);
            this.addNewEmployeeBtn.TabIndex = 3;
            this.addNewEmployeeBtn.Text = "Añadir Empleado";
            this.addNewEmployeeBtn.UseVisualStyleBackColor = true;
            this.addNewEmployeeBtn.Click += new System.EventHandler(this.addNewEmployeeBtn_Click);
            // 
            // nameEmployeeTB
            // 
            this.nameEmployeeTB.Location = new System.Drawing.Point(49, 117);
            this.nameEmployeeTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nameEmployeeTB.Name = "nameEmployeeTB";
            this.nameEmployeeTB.Size = new System.Drawing.Size(188, 22);
            this.nameEmployeeTB.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 99);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 36);
            this.label2.TabIndex = 6;
            this.label2.Text = "Empleado Nuevo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 99);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Apellidos";
            // 
            // lastNameEmployeeTB
            // 
            this.lastNameEmployeeTB.Location = new System.Drawing.Point(270, 117);
            this.lastNameEmployeeTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lastNameEmployeeTB.Name = "lastNameEmployeeTB";
            this.lastNameEmployeeTB.Size = new System.Drawing.Size(188, 22);
            this.lastNameEmployeeTB.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 166);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Correo";
            // 
            // emailEmployeeTB
            // 
            this.emailEmployeeTB.Location = new System.Drawing.Point(49, 184);
            this.emailEmployeeTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.emailEmployeeTB.Name = "emailEmployeeTB";
            this.emailEmployeeTB.Size = new System.Drawing.Size(188, 22);
            this.emailEmployeeTB.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(267, 166);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Numero Telefono";
            // 
            // phoneNumberEmployeeTB
            // 
            this.phoneNumberEmployeeTB.Location = new System.Drawing.Point(270, 184);
            this.phoneNumberEmployeeTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.phoneNumberEmployeeTB.Name = "phoneNumberEmployeeTB";
            this.phoneNumberEmployeeTB.Size = new System.Drawing.Size(188, 22);
            this.phoneNumberEmployeeTB.TabIndex = 11;
            // 
            // hireDateEmployeeDP
            // 
            this.hireDateEmployeeDP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.hireDateEmployeeDP.Location = new System.Drawing.Point(49, 256);
            this.hireDateEmployeeDP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.hireDateEmployeeDP.Name = "hireDateEmployeeDP";
            this.hireDateEmployeeDP.Size = new System.Drawing.Size(188, 22);
            this.hireDateEmployeeDP.TabIndex = 13;
            this.hireDateEmployeeDP.Value = new System.DateTime(2024, 7, 9, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 238);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Fecha Contratado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(267, 238);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Trabajo";
            // 
            // salaryEmployeeNUD
            // 
            this.salaryEmployeeNUD.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.salaryEmployeeNUD.Location = new System.Drawing.Point(49, 323);
            this.salaryEmployeeNUD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.salaryEmployeeNUD.Maximum = new decimal(new int[] {
            705032704,
            1,
            0,
            0});
            this.salaryEmployeeNUD.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.salaryEmployeeNUD.Name = "salaryEmployeeNUD";
            this.salaryEmployeeNUD.Size = new System.Drawing.Size(187, 22);
            this.salaryEmployeeNUD.TabIndex = 19;
            this.salaryEmployeeNUD.Value = new decimal(new int[] {
            400,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 303);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Salario";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(267, 303);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "Manager";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(46, 369);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "Departamento";
            // 
            // jobCB
            // 
            this.jobCB.FormattingEnabled = true;
            this.jobCB.Location = new System.Drawing.Point(270, 257);
            this.jobCB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.jobCB.Name = "jobCB";
            this.jobCB.Size = new System.Drawing.Size(188, 24);
            this.jobCB.TabIndex = 24;
            // 
            // departmentCB
            // 
            this.departmentCB.FormattingEnabled = true;
            this.departmentCB.Location = new System.Drawing.Point(49, 387);
            this.departmentCB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.departmentCB.Name = "departmentCB";
            this.departmentCB.Size = new System.Drawing.Size(188, 24);
            this.departmentCB.TabIndex = 25;
            // 
            // managerCB
            // 
            this.managerCB.FormattingEnabled = true;
            this.managerCB.Location = new System.Drawing.Point(270, 323);
            this.managerCB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.managerCB.Name = "managerCB";
            this.managerCB.Size = new System.Drawing.Size(188, 24);
            this.managerCB.TabIndex = 26;
            // 
            // employeesComboBox
            // 
            this.employeesComboBox.FormattingEnabled = true;
            this.employeesComboBox.Location = new System.Drawing.Point(151, 461);
            this.employeesComboBox.Name = "employeesComboBox";
            this.employeesComboBox.Size = new System.Drawing.Size(187, 24);
            this.employeesComboBox.TabIndex = 27;
            // 
            // butUpdateEmployee
            // 
            this.butUpdateEmployee.Location = new System.Drawing.Point(159, 526);
            this.butUpdateEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.butUpdateEmployee.Name = "butUpdateEmployee";
            this.butUpdateEmployee.Size = new System.Drawing.Size(169, 49);
            this.butUpdateEmployee.TabIndex = 28;
            this.butUpdateEmployee.Text = "Actualizar Empleado";
            this.butUpdateEmployee.UseVisualStyleBackColor = true;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 602);
            this.Controls.Add(this.butUpdateEmployee);
            this.Controls.Add(this.employeesComboBox);
            this.Controls.Add(this.managerCB);
            this.Controls.Add(this.departmentCB);
            this.Controls.Add(this.jobCB);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.salaryEmployeeNUD);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.hireDateEmployeeDP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.phoneNumberEmployeeTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.emailEmployeeTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lastNameEmployeeTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameEmployeeTB);
            this.Controls.Add(this.addNewEmployeeBtn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EmployeeForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.salaryEmployeeNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addNewEmployeeBtn;
        private System.Windows.Forms.TextBox nameEmployeeTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lastNameEmployeeTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox emailEmployeeTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox phoneNumberEmployeeTB;
        private System.Windows.Forms.DateTimePicker hireDateEmployeeDP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown salaryEmployeeNUD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox jobCB;
        private System.Windows.Forms.ComboBox departmentCB;
        private System.Windows.Forms.ComboBox managerCB;
        private System.Windows.Forms.ComboBox employeesComboBox;
        private System.Windows.Forms.Button butUpdateEmployee;
    }
}

