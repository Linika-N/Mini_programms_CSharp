namespace My_Utilities
{
    public partial class My_Utilities : Form
    {
        int count = 0;
        Random rnd;
        char[] spec_chars = new char[] {'@', '%', '*', '~', '?', '#', '$', '&', '^', '!'};
        Dictionary<string, double> metrica;

        public My_Utilities()
        {
            rnd = new Random();
            InitializeComponent();
            metrica= new Dictionary<string, double>();
            metrica.Add("mm", 1);
            metrica.Add("cm", 10);
            metrica.Add("dm", 100);
            metrica.Add("m", 1000);
            metrica.Add("km", 1000000);
            metrica.Add("mile", 1609344);
        }

        private void tsmi_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmi_about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа \"Мои утилиты\" содержит ряд небольших программ, которые могут пригодится в жизни.\nА главное научить меня основам программирования на C#.\nАвтор - Гончарова Л.С.", "О программе");
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            count++;
            lblCount.Text = count.ToString();
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            count--;
            lblCount.Text = count.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            count=0;
            lblCount.Text = count.ToString();
        }

        private void btn_random_Click(object sender, EventArgs e)
        {
            int n;
            n=rnd.Next(Convert.ToInt32(nud_lower.Value), Convert.ToInt32(nud_upper.Value)+1);
            lbl_rnd_number.Text = n.ToString();
            if (cb_repeat_rnd.Checked)
            {
                int i = 0;
                while (tb_rnd_text.Text.IndexOf(n.ToString()) != -1)
                {
                    n = rnd.Next(Convert.ToInt32(nud_lower.Value), Convert.ToInt32(nud_upper.Value) + 1);
                    i++;
                    if (i > 1000) break;
                }
                if (i<=1000) tb_rnd_text.AppendText(n + Environment.NewLine);
            }
            else tb_rnd_text.AppendText(n + Environment.NewLine);
        }

        private void btn_clear_rnd_Click(object sender, EventArgs e)
        {
            tb_rnd_text.Clear();
        }

        private void btn_copy_rnd_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tb_rnd_text.ToString());
        }

        private void tsmi_insert_date_Click(object sender, EventArgs e)
        {
            rtb_notepad.AppendText(DateTime.Now.ToShortDateString()+Environment.NewLine);
        }

        private void tsmi_insert_time_Click(object sender, EventArgs e)
        {
            rtb_notepad.AppendText(DateTime.Now.ToShortTimeString() + Environment.NewLine);
        }

        private void tsmi_save_Click(object sender, EventArgs e)
        {
            try
            {
                rtb_notepad.SaveFile("notepad.rtf");
            }
            catch
            {
                MessageBox.Show("Ошибка при сохранении");
            }
        }

        void Load_notepad()
        {
            try
            {
                rtb_notepad.LoadFile("notepad.rtf");
            }
            catch
            {
                MessageBox.Show("Ошибка при загрузке");
            }

        }
        private void tsmi_load_Click(object sender, EventArgs e)
        {
            Load_notepad();
        }

        private void My_Utilities_Load(object sender, EventArgs e)
        {
            Load_notepad();
            clb_password.SetItemChecked(0, true);
            clb_password.SetItemChecked(1, true);
            clb_password.SetItemChecked(2, true);
        }

        private void btn_create_password_Click(object sender, EventArgs e)
        {
            if (clb_password.CheckedItems.Count == 0)
                return;
            string password = "";
            for (int i=0; i < nud_password_length.Value; i++)
            {
                int n = rnd.Next(0, clb_password.CheckedItems.Count);
                string s = Convert.ToString(clb_password.CheckedItems[n]);
                switch (s){
                    case "Цифры": 
                        password += rnd.Next(10).ToString();
                        break;
                    case "Прописные буквы":
                        password += Convert.ToChar(rnd.Next(65,90));
                        break;
                    case "Строчные буквы":
                        password += Convert.ToChar(rnd.Next(97,122));
                        break;
                    default:
                        password += spec_chars[rnd.Next(spec_chars.Length)];
                        break;
                }
                tb_password.Text= password;
                Clipboard.SetText(password);
            }

        }

        private void btn_convert_Click(object sender, EventArgs e)
        {
            double m1 = metrica[cb_from.Text];
            double m2 = metrica[cb_to.Text];
            double n = Convert.ToDouble(tb_from.Text);
            tb_to.Text = (n * m1 / m2).ToString();
        }

        private void btn_swap_Click(object sender, EventArgs e)
        {
            string t = cb_from.Text;
            cb_from.Text = cb_to.Text;
            cb_to.Text = t;
        }

        private void cb_metric_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cb_metric.Text)
            {
                case "длина":
                    metrica.Clear();
                    metrica.Add("mm", 1);
                    metrica.Add("cm", 10);
                    metrica.Add("dm", 100);
                    metrica.Add("m", 1000);
                    metrica.Add("km", 1000000);
                    metrica.Add("mile", 1609344);
                    cb_from.Items.Clear();
                    cb_from.Items.Add("mm");
                    cb_from.Items.Add("cm");
                    cb_from.Items.Add("dm");
                    cb_from.Items.Add("m");
                    cb_from.Items.Add("km");
                    cb_from.Items.Add("mile");
                    cb_to.Items.Clear();
                    cb_to.Items.Add("mm");
                    cb_to.Items.Add("cm");
                    cb_to.Items.Add("dm");
                    cb_to.Items.Add("m");
                    cb_to.Items.Add("km");
                    cb_to.Items.Add("mile");
                    cb_from.Text = "mm";
                    cb_to.Text = "mm";
                    break;

                case "вес":
                    metrica.Clear();
                    metrica.Add("g", 1);
                    metrica.Add("kg", 1000);
                    metrica.Add("t", 1000000);
                    metrica.Add("lb", 453.6);
                    metrica.Add("oz", 283);
                    cb_from.Items.Clear();
                    cb_from.Items.Add("g");
                    cb_from.Items.Add("kg");
                    cb_from.Items.Add("t");
                    cb_from.Items.Add("lb");
                    cb_from.Items.Add("oz");
                    cb_to.Items.Clear();
                    cb_to.Items.Add("g");
                    cb_to.Items.Add("kg");
                    cb_to.Items.Add("t");
                    cb_to.Items.Add("lb");
                    cb_to.Items.Add("oz");

                    cb_from.Text = "g";
                    cb_to.Text = "g";
                    break;

                default:
                    break;
            }
        }
    }
}