using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinGuoCalc
{
    public partial class CalcMain : Form
    {
        public CalcMain()
        {
            InitializeComponent();
        }

        private void Convert_Click(object sender, EventArgs e)
        {
            int ADNum = 0;
            int yuan = 0;
            if (int.TryParse(ADNumber.Text, out ADNum))
            {
                ADNum = int.Parse(ADNumber.Text);
                if (ADNum <= 1911 && ADNum >= 1909)
                {
                    yuan = ADNum - 1908;
                    Minguo.Text = "宣统";
                    MinguoNumber.Text = caleYuan(yuan);
                    ADNum = 0;
                }
                else if(ADNum <= 1908 && ADNum >= 1875)
                {
                    yuan = ADNum - 1874;
                    Minguo.Text = "光绪";
                    MinguoNumber.Text = caleYuan(yuan);
                    ADNum = 0;
                } 
                else if(ADNum >= 1912)
                {
                    yuan = ADNum - 1911;
                    Minguo.Text = "民国";
                    MinguoNumber.Text = caleYuan(yuan);
                    ADNum = 0;
                }
                else
                {
                    MessageBox.Show("别算了别算了，太古老了", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("你家年份不用数字？中文的也不行！","错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Reverse_Click(object sender, EventArgs e)
        {
            int MGNum = 0;
            Minguo.Text = "民国";
            if (MinguoNumber.Text == "元")
            {
                MinguoNumber.Text = "1";
            }
            if (int.TryParse(MinguoNumber.Text, out MGNum))
            {
                MGNum = int.Parse(MinguoNumber.Text);
                if (MGNum <= 0)
                {
                    MessageBox.Show("你家民国有负的年份？0也不行！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ADNumber.Text = (MGNum + 1911).ToString();
                    MGNum = 0;
                }
            }
            else
            {
                MessageBox.Show("你家年份不用数字？中文的也不行！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public String caleYuan(int yuan)
        {
            String Year = "";
            if (yuan == 1)
            {
                Year = "元";
            }
            else
            {
                Year = yuan.ToString();
            }
            return Year;
        }

        private void MinguoNumber_Enter(object sender, EventArgs e)
        {
            Minguo.Text = "民国";
        }
    }
}
