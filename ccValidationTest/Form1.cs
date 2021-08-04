using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ccValidation;

namespace ccValidationTest
{
    public partial class Form1 : Form
    {
        /* Dichiarazioni ************************************************************ */

        ccValidation.ccValidation v = new ccValidation.ccValidation();


        /* Codice ******************************************************************* */
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_test_Click(object sender, EventArgs e)
        {
            //Validazione campi
            string mess1 = ": Formato del campo non valido.";
            string mess2 = ": Il campo contiene caratteri non validi";
            string mess3 = ": Dimensione del campo non valido";

            //txt_login
            if (!v.required(txt_login.Text))
            {
                MessageBox.Show(lb_login.Text + mess1);
                txt_login.Focus();
                return;
            }
            if (!v.pattern_login(txt_login.Text))
            {
                MessageBox.Show(lb_login.Text + mess2);
                txt_login.Focus();
                return;
            }
            //txt_alpha
            if (!v.pattern_alpha(txt_alpha.Text))
            {
                MessageBox.Show(lb_alpha.Text + mess2);
                txt_alpha.Focus();
                return;
            }
            //txt_alphanum
            if (!v.pattern_alphanum(txt_alphanum.Text))
            {
                MessageBox.Show(lb_alphanum.Text + mess2);
                txt_alphanum.Focus();
                return;
            }
            //txt_all
            if (!v.pattern_all(txt_all.Text))
            {
                MessageBox.Show(lb_all.Text + mess2);
                txt_all.Focus();
                return;
            }
            //txt_cap
            if (!v.minmax_char(txt_cap.Text, 5, 5))
            {
                MessageBox.Show(lb_cap.Text + mess3);
                txt_cap.Focus();
                return;
            }
            if (!v.pattern_cap(txt_cap.Text))
            {
                MessageBox.Show(lb_cap.Text + mess2);
                txt_cap.Focus();
                return;
            }
            //txt_zip
            if (!v.pattern_zip(txt_zip.Text))
            {
                MessageBox.Show(lb_zip.Text + mess2);
                txt_zip.Focus();
                return;
            }
            //txt_phone
            if (!v.pattern_phone(txt_phone.Text))
            {
                MessageBox.Show(lb_phone.Text + mess2);
                txt_phone.Focus();
                return;
            }
            //txt_integer
            if (!v.pattern_integer(txt_integer.Text))
            {
                MessageBox.Show(lb_integer.Text + mess2);
                txt_integer.Focus();
                return;
            }
            //txt_decimal
            if (!v.pattern_decimal(txt_decimal.Text))
            {
                MessageBox.Show(lb_decimal.Text + mess2);
                txt_decimal.Focus();
                return;
            }
            //txt_currency
            if (!v.pattern_currency(txt_currency.Text))
            {
                MessageBox.Show(lb_currency.Text + mess2);
                txt_currency.Focus();
                return;
            }
            //txt_email
            if (!v.pattern_mail(txt_email.Text))
            {
                MessageBox.Show(lb_email.Text + mess2);
                txt_email.Focus();
                return;
            }
            //txt_url
            if (!v.pattern_url(txt_url.Text))
            {
                MessageBox.Show(lb_url.Text + mess2);
                txt_url.Focus();
                return;
            }
            //txt_date
            if (!v.check_date(txt_date.Text))
            {
                MessageBox.Show(lb_date.Text + mess1);
                txt_date.Focus();
                return;
            }
            //txt_custom
            if (!v.mypattern(txt_custom.Text, @"^[A-Z0-9\-]+$"))
            {
                MessageBox.Show(lb_custom.Text + mess2);
                txt_custom.Focus();
                return;
            }

            MessageBox.Show("Perfect !");

        }

        private void btn_fill1_Click(object sender, EventArgs e)
        {
            txt_login.Text = "example";
            txt_alpha.Text = "example";
            txt_alphanum.Text = "example";
            txt_all.Text = "example";
            txt_cap.Text = "example";
            txt_zip.Text = "example";
            txt_phone.Text = "example";
            txt_integer.Text = "example";
            txt_decimal.Text = "example";
            txt_currency.Text = "example";
            txt_email.Text = "example";
            txt_url.Text = "example";
            txt_date.Text = "01/01/2021";
            txt_custom.Text = "example";
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_login.Text = "";
            txt_alpha.Text = "";
            txt_alphanum.Text = "";
            txt_all.Text = "";
            txt_cap.Text = "";
            txt_zip.Text = "";
            txt_phone.Text = "";
            txt_integer.Text = "";
            txt_decimal.Text = "";
            txt_currency.Text = "";
            txt_email.Text = "";
            txt_url.Text = "";
            txt_date.Text = "";
            txt_custom.Text = "";
        }

        private void btn_fill2_Click(object sender, EventArgs e)
        {
            txt_login.Text = "MyLogin01+";
            txt_alpha.Text = "Example";
            txt_alphanum.Text = "Example 10";
            txt_all.Text = "Example 10 (Tèst)";
            txt_cap.Text = "01234";
            txt_zip.Text = "01234-56789";
            txt_phone.Text = "+39 0123456789";
            txt_integer.Text = "150";
            txt_decimal.Text = "-1234.5678901";
            txt_currency.Text = "12345.89";
            txt_email.Text = "example@mailtest.com";
            txt_url.Text = "http://www.codicicaotici.it";
            txt_date.Text = "01/01/2021";
            txt_custom.Text = "";
        }


        /* **************************************************** */

    }//public partial class Form1 : Form
}//namespace TextValidation
