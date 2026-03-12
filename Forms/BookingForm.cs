using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusTicketSystem.Forms
{
    public partial class BookingForm : Form
    {

        public BookingForm()
        {
            InitializeComponent();

            dgvCustomer.Columns.Add("name", "Customer Name");
            dgvCustomer.Columns.Add("phone", "Contact Number");
            dgvCustomer.Columns.Add("history", "Booking History");

            dgvCustomer.Rows.Add("Alice Brown", "0301235383", "Booking History 1");
            dgvCustomer.Rows.Add("Bob Smith", "0371237383", "Booking History 2");
            dgvCustomer.Rows.Add("John Lee", "012987654", "Booking History 3");
            dgvCustomer.Rows.Add("David Kim", "097654321", "Booking History 4");
            dgvCustomer.Rows.Add("Emma Wilson", "015333444", "Booking History 5");
            dgvCustomer.Rows.Add("Michael Tan", "011222333", "Booking History 6");

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
