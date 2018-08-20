using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_2
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
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.tasks = new string[] {
                "Выбрать имена и фамилии сотрудников, работающих в Украине, но не в Донецке.",
                "Вывести список стран без повторений.",
                "Выбрать 3-x первых сотрудников, возраст которых превышает 25 лет.",
                "Выбрать имена, фамилии и возраст студентов из Киева, возраст которых превышает 23 года."
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
                new Employee(1, "Tamara", "Ivanova", 22, 2),
                new Employee(2, "Nikita", "Larin", 33, 1),
                new Employee(3, "Alica", "Ivanova", 43, 3),
                new Employee(4, "Lida", "Marusyk", 22, 2),
                new Employee(5, "Lida", "Voron", 36, 4),
                new Employee(6, "Ivan", "Kalyta", 24, 2),
                new Employee(7, "Nikita", "Krotov", 27, 4)
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
                where dept.City != "Donetsk"
                select new {worker.FirstName, worker.LastName}
                ).ToList();
        }

        private void buttonLinqSecond_Click(object sender, EventArgs e)
        {
            this.textBoxDescriptionOfRequest.Text = this.tasks[1];

            this.dataGridViewQueryResult.DataSource
                = (
                from dept in departments
                select new {dept.Country}
                ).Distinct().ToList();
        }

        private void buttonLinqTheThird_Click(object sender, EventArgs e)
        {
            this.textBoxDescriptionOfRequest.Text = this.tasks[2];

            this.dataGridViewQueryResult.DataSource
                = (
                from worker in employees
                where worker.Age > 25
                select worker
                ).Take(3).ToList<Employee>();
        }

        private void buttonLinqFourth_Click(object sender, EventArgs e)
        {
            this.textBoxDescriptionOfRequest.Text = this.tasks[3];

            this.dataGridViewQueryResult.DataSource
                = (
                from worker in employees
                join dept in departments
                on worker.DepId equals dept.Id
                where dept.City == "Kyiv"
                where worker.Age > 23
                select new {worker.FirstName, worker.LastName, worker.Age}
                ).ToList();
        }

        private void buttonMethodFirst_Click(object sender, EventArgs e)
        {
            this.textBoxDescriptionOfRequest.Text = this.tasks[0];

            this.dataGridViewQueryResult.DataSource
                =
                this.employees
                .SelectMany(emp => departments
                    .Where(dept => dept.Id == emp.DepId
                        && dept.Country == "Ukraine"
                        && dept.City != "Donetsk")
                        .Select(worker => new { emp.FirstName, emp.LastName})
                ).ToList();
        }

        private void buttonMethodSecond_Click(object sender, EventArgs e)
        {
            this.textBoxDescriptionOfRequest.Text = this.tasks[1];

            this.dataGridViewQueryResult.DataSource
                = this.departments
                .Select(dept => new { dept.Country})
                .Distinct().ToList();
        }

        private void buttonMethodTheThird_Click(object sender, EventArgs e)
        {
            this.textBoxDescriptionOfRequest.Text = this.tasks[2];

            this.dataGridViewQueryResult.DataSource
                = this.employees
                .Where(emp => emp.Age > 25)
                .Take(3).ToList<Employee>();
        }

        private void buttonMethodFourth_Click(object sender, EventArgs e)
        {
            this.textBoxDescriptionOfRequest.Text = this.tasks[3];

            this.dataGridViewQueryResult.DataSource
                = this.employees
                .SelectMany(emp => departments
                    .Where(dept => dept.Id == emp.DepId
                        && dept.City == "Kyiv"
                        && emp.Age > 23)
                        .Select(worker => new { emp.FirstName, emp.LastName, emp.Age })
                ).ToList();
        }
    }
}
