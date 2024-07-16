using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppBBDD.BusinessLayer;

namespace WindowsFormsAppBBDD
{
    public partial class EmployeeForm : Form
    {
        private EmployeeService employeeService;
        private DepartmentService departmentService;
        private JobService jobService;
        public EmployeeForm()
        {
            InitializeComponent();
            employeeService = new EmployeeService();
            departmentService = new DepartmentService();
            jobService = new JobService();
            this.Load += new EventHandler(ListJobs_Load);
            this.Load += new EventHandler(ListDepartment_Load);
            this.Load += new EventHandler(ListEmployee_Load);
        }

        private void addNewEmployeeBtn_Click(object sender, EventArgs e)
        {
            ComboBoxItem jobSelected = (ComboBoxItem)this.jobCB.SelectedItem;
            ComboBoxItem managerSelected = (ComboBoxItem)this.managerCB.SelectedItem;
            ComboBoxItem departmentSelected = (ComboBoxItem)this.departmentCB.SelectedItem;

            // Convert the Text property of DateTimePicker to DateTime
            DateTime hireDate;
            bool isDateParsed = DateTime.TryParse(this.hireDateEmployeeDP.Text, out hireDate);

            if (CheckTextBox())
            {
                this.employeeService.InsertEmployee(this.nameEmployeeTB.Text, this.lastNameEmployeeTB.Text,
                                                    this.emailEmployeeTB.Text, this.phoneNumberEmployeeTB.Text,
                                                    hireDate, (int)jobSelected.Value,
                                                    (decimal)this.salaryEmployeeNUD.Value, (int?)managerSelected.Value,
                                                    (int?)departmentSelected.Value);
                MessageBox.Show("Se ha registrado el nuevo empleado!");
                ClearForm(this);
            }
        }

        private bool CheckTextBox()
        {
            if (string.IsNullOrWhiteSpace(this.nameEmployeeTB.Text))
            {
                MessageBox.Show("Introduce el nombre del empleado");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(this.lastNameEmployeeTB.Text))
            {
                MessageBox.Show("Introduce los apellidos del empleado");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(this.emailEmployeeTB.Text))
            {
                MessageBox.Show("Introduce el correo del empleado");
                return false;
            }
            else
                return true;
        }

        public void ClearForm(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
                else if (control is DateTimePicker)
                {
                    ((DateTimePicker)control).Value = DateTime.Now;
                }
                else if (control.HasChildren)
                {
                    ClearForm(control);
                }
            }
        }

        private void ListJobs_Load(object sender, EventArgs e)
        {
            // Use LINQ to create the list of ComboBoxItem objects
            var items = jobService.GetJobsList()
                                   .Select(j => 
                                   new ComboBoxItem(j.job_id, $"{j.job_title}"))
                                   .ToList();

            // Assign the list to the ComboBox
            this.jobCB.DataSource = items;
            this.jobCB.DisplayMember = "Text";
            this.jobCB.ValueMember = "Value";
        }
        private void ListDepartment_Load(object sender, EventArgs e)
        {
            // Use LINQ to create the list of ComboBoxItem objects
            var items = departmentService.GetDepartmentList()
                                   .Select(d =>
                                   new ComboBoxItem(d.department_id, 
                                   $"{d.department_name}"))
                                   .ToList();

            // Assign the list to the ComboBox
            this.departmentCB.DataSource = items;
            this.departmentCB.DisplayMember = "Text";
            this.departmentCB.ValueMember = "Value";

        }
        private void ListEmployee_Load(object sender, EventArgs e)
        {

            var items = employeeService.GetEmployeeList()
                                 .Select(x =>
                                 new ComboBoxItem(x.employee_id,
                                 $"{x.first_name}"))
                                 .ToList();

            // Asignar la lista al Combobox
            this.managerCB.DataSource = items;
            this.managerCB.DisplayMember = "Text";
            this.managerCB.ValueMember = "Value";

        }

    }
}
