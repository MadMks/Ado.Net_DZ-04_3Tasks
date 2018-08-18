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
                new Employee(6, "Ivan", "Kalyta", 22, 2),
                new Employee(7, "Nikita", "Krotov", 27, 4)
            };
        }
    }
}
