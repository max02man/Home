using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home
{
    public partial class Form1 : Form
    {
        public double calc(double x, int y)
        {
            return x / y;
        }
        double rent;
        double internet;
        double elec;
        double total;
        int roomate;
        public Form1()
        {
            InitializeComponent();
     
        }

        private void monthcala_button_Click(object sender, EventArgs e)
        {
            roomate = int.Parse(Roomates_textBox.Text);
            internet = double.Parse(m_int_textBox.Text);
            rent = double.Parse(m_rent_textBox.Text);
            elec = double.Parse(m_elc_textBox.Text);

            bymonth month = new bymonth(roomate, rent, internet, elec);
            total= (rent+ internet+ elec)/roomate;
            m_total_label.Text = total.ToString("C3");
            m_intperday_label.Text = (internet / roomate).ToString("C3");
            m_rentperday_label.Text = (rent / roomate).ToString("C3");
            m_eleperday_label.Text = (elec / roomate).ToString("C3");
        }

        private void dayscalc_button_Click(object sender, EventArgs e)
        {
            bydays_groupBox.Visible = true;
            int days;
            int month = 30;
            days = int.Parse(days_textBox.Text);
            double rent_total=calc(rent, roomate);
            double elec_total=calc(elec, roomate);
            double internet_total=calc(internet, roomate);
            double total;
            dayelec_label.Text = elec_total.ToString("C3");
          dayrent_label.Text = rent_total.ToString("C3");
          dayint_label.Text = internet_total.ToString("C3");
          renttotal_label.Text = (rent_total / month).ToString("C3");
          electotal_label.Text = (elec_total / month).ToString("C3");
          internettotal_label.Text = (internet_total / month).ToString("C3");
          total = ((rent_total / month) + (elec_total / month) + (internet_total / month));

          d_total_label.Text = total.ToString("c3");
          stay_label.Text = (total * days).ToString("c3");
        }


    }
}
