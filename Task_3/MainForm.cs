using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_3
{
    public partial class MainForm : Form
    {
        private string[] tasks = null;

        private List<Department> departments = null;
        private List<Employee> employees = null;

        public MainForm()
        {
            InitializeComponent();

            this.Load += MainForm_Load;
            this.textBoxDescriptionOfRequest.TextChanged += TextBoxDescriptionOfRequest_TextChanged;
        }

        private void TextBoxDescriptionOfRequest_TextChanged(object sender, EventArgs e)
        {
            this.dataGridViewQueryResult.DataSource = null;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.tasks = new string[] {
                "Упорядочить имена и фамилии сотрудников по алфавиту, "
                + "которые проживают в Украине.",
                "Отсортировать сотрудников по возрастам, по убыванию."
                + "Вывести Id, FirstName, LastName, Age.",
                "Сгруппировать студентов по возрасту."
                + "Вывести возраст и сколько раз он встречается в списке."
            };

            this.departments = new List<Department>()
            {
                new Department(1, "Ukraine", "Donetsk"),
                new Department(2, "Ukraine", "Kyiv"),
                new Department(3, "France", "Paris"),
                new Department(4, "Russia", "Moscow")
            };

            this.employees = new List<Employee>()
            {
                new Employee(1, "Nikola", "Tesla", 58, 2),
                new Employee(2, "Tamara", "Ivanova", 22, 2),
                new Employee(3, "Nikita", "Larin", 33, 1),
                new Employee(4, "Alica", "Ivanova", 43, 3),
                new Employee(5, "Lida", "Marusyk", 22, 2),
                new Employee(6, "Lida", "Voron", 36, 4),
                new Employee(7, "Ivan", "Kalyta", 22, 2),
                new Employee(8, "Nikita", "Krotov", 27, 4)
            };


            this.dataGridViewAllDataDepartment.DataSource = this.departments;
            this.dataGridViewAllDataEmployees.DataSource = this.employees;
        }

        private void buttonLinqFirst_Click(object sender, EventArgs e)
        {
            this.textBoxDescriptionOfRequest.Text = this.tasks[0];

            this.dataGridViewQueryResult.DataSource
                = (
                from worker in employees
                join dept in departments
                  on worker.DepId equals dept.Id
                where dept.Country == "Ukraine"
                orderby worker.FirstName, worker.LastName
                select new {worker.FirstName, worker.LastName, dept.Country}
                ).ToList();
        }

        private void buttonLinqSecond_Click(object sender, EventArgs e)
        {
            this.textBoxDescriptionOfRequest.Text = this.tasks[1];

            this.dataGridViewQueryResult.DataSource
                = (
                from worker in employees
                orderby worker.Age descending
                select new { worker.Id, worker.FirstName, worker.LastName, worker.Age }
                ).ToList();
        }

        private void buttonLinqTheThird_Click(object sender, EventArgs e)
        {
            this.textBoxDescriptionOfRequest.Text = this.tasks[2];

            this.dataGridViewQueryResult.DataSource
                = (
                from worker in employees
                group worker by worker.Age into g
                select new { Age = g.Key, Quantity = g.Count() }
                ).ToList();
        }

        private void buttonMethodFirst_Click(object sender, EventArgs e)
        {
            this.textBoxDescriptionOfRequest.Text = this.tasks[0];

            // example #1
            //this.dataGridViewQueryResult.DataSource
            //    = this.employees
            //    .SelectMany(emp => departments
            //        .Where(dept => dept.Id == emp.DepId
            //            && dept.Country == "Ukraine")
            //            .Select(worker => emp)
            //    ).Select(employ => new { employ.FirstName, employ.LastName, employ.DepId})
            //    .OrderBy(w => w.FirstName)
            //    .ThenBy(w => w.LastName)
            //    .ToList();

            // example #2
            this.dataGridViewQueryResult.DataSource
                = this.employees.Join(departments, emp => emp.DepId, d => d.Id,
                    (emp, d) => new
                    {
                        FirstName = emp.FirstName,
                        LastName = emp.LastName,
                        Country = d.Country
                    })
                    .Where(c => c.Country == "Ukraine")
                    .OrderBy(w => w.FirstName)
                    .ThenBy(w => w.LastName)
                    .ToList();
        }

        private void buttonMethodSecond_Click(object sender, EventArgs e)
        {
            this.textBoxDescriptionOfRequest.Text = this.tasks[1];

            this.dataGridViewQueryResult.DataSource
                = this.employees
                .OrderByDescending(emp => emp.Age)
                .Select(emp => new { emp.Id, emp.FirstName, emp.LastName, emp.Age })
                .ToList();
        }

        private void buttonMethodTheThird_Click(object sender, EventArgs e)
        {
            this.textBoxDescriptionOfRequest.Text = this.tasks[2];

            this.dataGridViewQueryResult.DataSource
                = this.employees
                .GroupBy(emp => emp.Age)
                .Select(g => new { Age = g.Key, Quantity = g.Count() })
                .ToList();
        }
    }
}
