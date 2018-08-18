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
        List<Person> people = null;

        public MainForm()
        {
            InitializeComponent();

            this.Load += MainForm_Load;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.people = new List<Person>()
            {
                new Person("Andrey", 24, "Kyiv"),
                new Person("Liza", 18, "Moscow"),
                new Person("Oleg", 15, "London"),
                new Person("Sergey", 55, "Kyiv"),
                new Person("Sergey", 32, "Kyiv")
            };

            this.dataGridViewAllData.DataSource = this.people;
        }
    }
}
