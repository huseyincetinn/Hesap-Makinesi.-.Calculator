namespace Hesap_Makinesi
{
    public partial class Form1 : Form
    {

        private char _islem;
        private bool _ekrantemizleme;
        private int _Ilksayý;


        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_ekrantemizleme)
            {
                ekranLabel.Text = "";
                _ekrantemizleme = false;

            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "2";
        }

        private void rakam1Button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizleme)
            {
                ekranLabel.Text = "";
                _ekrantemizleme = false;

            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "1";

        }

        private void rakam3Button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizleme)
            {
                ekranLabel.Text = "";
                _ekrantemizleme = false;

            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "3";
        }

        private void rakam4Button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizleme)
            {
                ekranLabel.Text = "";
                _ekrantemizleme = false;

            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "4";
        }

        private void rakam5Button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizleme)
            {
                ekranLabel.Text = "";
                _ekrantemizleme = false;

            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "5";
        }

        private void rakam6Button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizleme)
            {
                ekranLabel.Text = "";
                _ekrantemizleme = false;

            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "6";
        }

        private void rakam7Button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizleme)
            {
                ekranLabel.Text = "";
                _ekrantemizleme = false;

            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "7";
        }

        private void rakam8Button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizleme)
            {
                ekranLabel.Text = "";
                _ekrantemizleme = false;

            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "8";
        }

        private void rakam9Button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizleme)
            {
                ekranLabel.Text = "";
                _ekrantemizleme = false;

            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "9";
        }

        private void rakam0Button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizleme)
            {
                ekranLabel.Text = "";
                _ekrantemizleme = false;

            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "0";
        }

        private void toplamaButton_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _ekrantemizleme = true;
            _Ilksayý = Convert.ToInt32(ekranLabel.Text);

            //ekranLabel.Text = ekranLabel.Text + " + ";

        }

        private void esitButton_Click(object sender, EventArgs e)
        {
            int ikincisayý = Convert.ToInt32(ekranLabel.Text);
            int sonuc;
            switch (_islem)
            {
                case '+':
                    sonuc = _Ilksayý + ikincisayý;
                    break;
                case '-':
                    sonuc = _Ilksayý - ikincisayý;
                    break;
                case '*':
                    sonuc = _Ilksayý * ikincisayý;
                    break;
                case '/':
                    sonuc = _Ilksayý / ikincisayý;
                    break;
                default:
                    sonuc = 0;
                    break;


            }

            ekranLabel.Text = Convert.ToString(sonuc);

        }

        private void cýkarmaButton_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _ekrantemizleme = true;
            _Ilksayý = Convert.ToInt32(ekranLabel.Text);
        }

        private void carpmaButton_Click(object sender, EventArgs e)
        {
            _islem = '*';
            _ekrantemizleme = true;
            _Ilksayý = Convert.ToInt32(ekranLabel.Text);
        }

        private void bolmeButton_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _ekrantemizleme = true;
            _Ilksayý = Convert.ToInt32(ekranLabel.Text);
        }

        private void silmeButton_Click(object sender, EventArgs e)
        {
            ekranLabel.Text = "0";
        }

        private void ekranLabel_TextChanged(object sender, EventArgs e)
        {
            if (ekranLabel.Text.Length > 8)
                MessageBox.Show("Rakam sýnýrýna ulaþýldý!");



        }
    }

}