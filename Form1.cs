using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace RSAAppDestop
{
    public partial class Form1 : Form
    {
        BigInteger p;
        BigInteger q;
        BigInteger eNumber;
        BigInteger d;
        BigInteger n;
        BigInteger phi;
        List<BigInteger> ciphertext = new List<BigInteger>();


        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        public Form1()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            createKey_Btn.Region = Region.FromHrgn(CreateRoundRectRgn(0,0,createKey_Btn.Width,createKey_Btn.Height,10,10));
            encryt_Btn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, encryt_Btn.Width, encryt_Btn.Height, 10, 10));
            decrypt_Btn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, decrypt_Btn.Width, decrypt_Btn.Height, 10, 10));
            Reset_Btn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Reset_Btn.Width, Reset_Btn.Height, 10, 10));
        }

        private void encryt_Btn_Click(object sender, EventArgs e)
        {
            if (IsAnyTextBoxEmpty())
            {
                MessageBox.Show("Vui lòng tạo khóa trước khi mã hóa mesage", "Thông báo", MessageBoxButtons.OKCancel);
                numberP_Txt.Focus();
                return;
            }
            if (messageEncryt_Rtb.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập message để mã hóa", "Thông báo", MessageBoxButtons.OKCancel);
                messageEncryt_Rtb.Focus();
                return;
            }

            foreach (char c in messageEncryt_Rtb.Text)
            {
                BigInteger encrypted = ModExp(c, eNumber, n);
                ciphertext.Add(encrypted);
            }
            encryt_Rtb.Text = string.Join(" ", ciphertext);
            encryt_Rtb.ReadOnly = true;
            encryt_Btn.Enabled = false;
        }

        private void CreateRandomKey()
        {
            //GeneratePrime(100000000, 1000000000);
            p = GeneratePrime(50000000, 900000000);
            do
            {
                q = GeneratePrime(50000000, 900000000);
            } while (p == q);

            //Tính n
            n = p * q;

            // Tinh phi
            phi = (p - 1) * (q - 1);

            // Tim uoc chung ln giua e va q
            do
            {
                eNumber = GenerateRandomBigInteger(2, phi - 1);
            } while (GCD(eNumber, phi) != 1);

            // Tinh d
            d = ModInverse(eNumber, phi);


            numberP_Txt.Text = p.ToString();
            numberQ_Txt.Text = q.ToString();
            numberPhi_Txt.Text = phi.ToString();
            numberN_Txt.Text = n.ToString();
            numberE_Txt.Text = eNumber.ToString();
            numberD_Txt.Text = d.ToString();
            messageEncryt_Rtb.Focus();
        }

        private void CreateKey()
        {
            if (string.IsNullOrEmpty(numberP_Txt.Text) || string.IsNullOrEmpty(numberQ_Txt.Text))
            {
                MessageBox.Show("Vui lòng nhập các chỉ số cần thiết để tạo mã khóa", "Thông báo", MessageBoxButtons.OKCancel);
                numberP_Txt.Focus();
                createKey_Btn.Enabled = true;
                return;
            }

           
            p =  BigInteger.Parse(numberP_Txt.Text);
            q = BigInteger.Parse(numberQ_Txt.Text);

            if (p == q || !isPrime(p) || !isPrime(q)) {
                MessageBox.Show("Vui lòng chọn p và q là hai số nguyên tố và khác nhau", "Thông báo", MessageBoxButtons.OKCancel); ;
                numberP_Txt.Focus();
                return;
            }
            n = p * q;

            phi = (p - 1) * (q - 1);

            // Tim uoc chung ln giua e va q
            do
            {
                eNumber = GenerateRandomBigInteger(2, phi - 1);
            } while (GCD(eNumber, phi) != 1);

            // Tinh d
            d = ModInverse(eNumber, phi);


            numberP_Txt.Text = p.ToString();
            numberQ_Txt.Text = q.ToString();
            numberE_Txt.Text = eNumber.ToString();
            numberPhi_Txt.Text = phi.ToString();
            numberN_Txt.Text = n.ToString();
            numberD_Txt.Text = d.ToString();
            messageEncryt_Rtb.Focus();

        }

        private void createKey_Btn_Click(object sender, EventArgs e)
        {
            if(!randomNumber_Btn.Checked && !createNumber_Btn.Checked)
            {
                MessageBox.Show("Vui  lòng chọn hình thức tạo khóa (Random khóa hoặc Tự tạo khóa)", "Thông báo",MessageBoxButtons.OKCancel);
                return;
            }
            if (randomNumber_Btn.Checked)
            {
                CreateRandomKey();
                createNumber_Btn.Enabled = false;
            }
            else
            {
                CreateKey();
                randomNumber_Btn.Enabled = false;
            }
            createKey_Btn.Enabled = false;
        }

        

        private void decrypt_Btn_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(decrypt_Rtb.Text))
            {
                MessageBox.Show("Bạn chưa nhập message để mã hóa", "Thông báo", MessageBoxButtons.OKCancel);
                messageDecryt_Rtb.Focus();
                return;
            }
            string decryptedText = "";
            foreach (BigInteger c in ciphertext)
            {
                char decrypted = (char)ModExp(c, d, n);
                decryptedText += decrypted;
            }
            messageDecryt_Rtb.Text = decryptedText;
            decrypt_Btn.Enabled = false;
        }


        private bool isPrime(BigInteger n)
        {
            for (int i = 2; i <= CalSqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }


        private BigInteger CalSqrt(BigInteger val)
        {
            if (val == 1) return val;
            BigInteger low = 1;
            BigInteger high = val;
            BigInteger mid = 0;
            while (low < high)
            {
                while (low < high)
                {
                    mid = (low + high + 1) / 2;
                    if (mid * mid <= val)
                        low = mid;
                    else
                        high = mid - 1;
                }

            }
            return low;
        }

        private BigInteger ModInverse(BigInteger e, BigInteger phi)
        {
            BigInteger t = 0, newT = 1;
            BigInteger r = phi, newR = e;
            while (newR != 0)
            {
                BigInteger quotient = r / newR;
                BigInteger tempT = t - quotient * newT;
                t = newT;
                newT = tempT;
                BigInteger tempR = r - quotient * newR;
                r = newR;
                newR = tempR;
            }
            if (r > 1) return -1; // Không có nghịch đảo
            if (t < 0) t += phi;
            return t;
        }

        // Hàm mũ modulo
        private BigInteger ModExp(BigInteger baseVal, BigInteger exp, BigInteger mod)
        {
            BigInteger result = 1;
            baseVal %= mod;
            while (exp > 0)
            {
                if (exp % 2 == 1)
                {
                    result = (result * baseVal) % mod;
                }
                baseVal = (baseVal * baseVal) % mod;
                exp /= 2;
            }
            return result;
        }

        private BigInteger GeneratePrime(BigInteger min, BigInteger max)
        {
            Random rand = new Random();
            BigInteger prime;
            do
            {
                prime = new BigInteger(rand.NextDouble() * (double)(max - min) + (double)min);
            } while (!isPrime(prime));
            return prime;
        }


        BigInteger GenerateRandomBigInteger(BigInteger min, BigInteger max)
        {
            Random rand = new Random();
            byte[] bytes = max.ToByteArray();
            BigInteger result;
            do
            {
                rand.NextBytes(bytes);
                result = new BigInteger(bytes);
            } while (result < min || result > max);
            return result;
        }

        BigInteger GCD(BigInteger a, BigInteger b)
        {
            BigInteger tmp;
            while (b != 0)
            {
                tmp = a % b;
                a = b;
                b = tmp;
            }
            return a;
        }


        private void randomNumber_Btn_CheckedChanged(object sender, EventArgs e)
        {
            numberP_Txt.ReadOnly = true;
            numberQ_Txt.ReadOnly = true;
            numberPhi_Txt.ReadOnly = true;
            numberN_Txt.ReadOnly = true;
            numberE_Txt.ReadOnly = true;
            numberD_Txt.ReadOnly = true;
        }

        private void createNumber_Btn_CheckedChanged(object sender, EventArgs e)
        {
            numberP_Txt.ReadOnly = false;
            numberQ_Txt.ReadOnly = false;
            numberPhi_Txt.ReadOnly = true;
            numberN_Txt.ReadOnly = true;
            numberE_Txt.ReadOnly = true;
            numberD_Txt.ReadOnly = true;
            
        }

        private bool IsAnyTextBoxEmpty()
        {

            return string.IsNullOrWhiteSpace(numberP_Txt.Text) ||
                   string.IsNullOrWhiteSpace(numberQ_Txt.Text) ||
                   string.IsNullOrWhiteSpace(numberPhi_Txt.Text) ||
                   string.IsNullOrWhiteSpace(numberN_Txt.Text) ||
                   string.IsNullOrWhiteSpace(numberE_Txt.Text) ||
                   string.IsNullOrWhiteSpace(numberD_Txt.Text);
        }


        private void Reset()
        {
            numberP_Txt.Clear();
            numberQ_Txt.Clear();
            numberPhi_Txt.Clear();
            numberN_Txt.Clear();
            numberE_Txt.Clear();
            numberD_Txt.Clear();
            ciphertext.Clear();
            messageEncryt_Rtb.Clear();
            messageDecryt_Rtb.Clear();
            encryt_Rtb.Clear();
            decrypt_Rtb.Clear();
            createKey_Btn.Enabled = true;
            encryt_Btn.Enabled = true;
            decrypt_Btn.Enabled = true;
            createNumber_Btn.Enabled = true;
            randomNumber_Btn.Enabled=true;
            randomNumber_Btn.Checked = false;
            createNumber_Btn.Checked = false;
        }

        private void Reset_Btn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        
    }
}
