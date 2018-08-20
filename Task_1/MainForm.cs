using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_1
{
    public partial class MainForm : Form
    {
        private string[] tasks = null;
        private List<Person> people = null;

        public MainForm()
        {
            InitializeComponent();

            this.Load += MainForm_Load;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.tasks = new string[] {
                "Выбрать людей, старших 25 лет.",
                "Выбрать людей, проживающих не в Киеве.",
                "Выбрать имена людей, проживающих в Киеве.",
                "Выбрать людей старших 35 лет с именем Sergey.",
                "Выбрать людей, проживающих в Москве."
            };

            this.people = new List<Person>()
            {
                new Person("Andrey", 24, "Kyiv"),
                new Person("Liza", 18, "Moscow"),
                new Person("Oleg", 15, "London"),
                new Person("Sergey", 55, "Kyiv"),
                new Person("Sergey", 32, "Kyiv"),
                new Person("Bender", 77, "New York")
            };

            this.dataGridViewAllData.DataSource = this.people;
        }

        private void buttonLinqFirst_Click(object sender, EventArgs e)
        {
            this.labelDescriptionOfRequest.Text = this.tasks[0];

            this.dataGridViewQueryResult.DataSource 
                = (
                from person in people
                where person.Age > 25
                select person
                ).ToList<Person>();
        }

        private void buttonLinqSecond_Click(object sender, EventArgs e)
        {
            this.labelDescriptionOfRequest.Text = this.tasks[1];

            this.dataGridViewQueryResult.DataSource 
                = (
                from person in people
                where person.City != "Kyiv"
                select person
                ).ToList<Person>();
        }

        private void buttonLinqTheThird_Click(object sender, EventArgs e)
        {
            this.labelDescriptionOfRequest.Text = this.tasks[2];

            this.dataGridViewQueryResult.DataSource
                = (
                from person in people
                where person.City == "Kyiv"
                select new {person.Name, person.City}
                ).ToList();
        }

        private void buttonLinqFourth_Click(object sender, EventArgs e)
        {
            this.labelDescriptionOfRequest.Text = this.tasks[3];

            this.dataGridViewQueryResult.DataSource
                = (
                from person in people
                where person.Age > 35
                where person.Name == "Sergey"
                select person
                ).ToList<Person>();
        }

        private void buttonLinqFifth_Click(object sender, EventArgs e)
        {
            this.labelDescriptionOfRequest.Text = this.tasks[4];

            this.dataGridViewQueryResult.DataSource
                = (
                from person in people
                where person.City == "Moscow"
                select person
                ).ToList<Person>();
        }

        private void buttonMethodFirst_Click(object sender, EventArgs e)
        {
            this.labelDescriptionOfRequest.Text = this.tasks[0];

            this.dataGridViewQueryResult.DataSource
                = people.Where(p => p.Age > 25)
                .ToList<Person>();
        }

        private void buttonMethodSecond_Click(object sender, EventArgs e)
        {
            this.labelDescriptionOfRequest.Text = this.tasks[1];

            this.dataGridViewQueryResult.DataSource
                = people.Where(p => p.City != "Kyiv")
                .ToList<Person>();
        }

        private void buttonMethodTheThird_Click(object sender, EventArgs e)
        {
            this.labelDescriptionOfRequest.Text = this.tasks[2];

            this.dataGridViewQueryResult.DataSource
                = people.Where(p => p.City == "Kyiv")
                .Select(p => new { p.Name, p.City })
                .ToList();
        }

        private void buttonMethodFourth_Click(object sender, EventArgs e)
        {
            this.labelDescriptionOfRequest.Text = this.tasks[3];

            this.dataGridViewQueryResult.DataSource
                = people.Where(p => p.Age > 35 && p.Name == "Sergey")
                .ToList<Person>();
        }

        private void buttonMethodFifth_Click(object sender, EventArgs e)
        {
            this.labelDescriptionOfRequest.Text = this.tasks[4];

            this.dataGridViewQueryResult.DataSource
                = people.Where(p => p.City == "Moscow")
                .ToList<Person>();
        }
    }
}
