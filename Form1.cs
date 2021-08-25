using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormPrac
{
    public partial class Form1 : Form
    {
        enum OrderState { Ordered, Paymented, Prepared, Sended }
        enum Course { NewmdeiaSoftware, Newmediasolution, Newmediadesign };
        enum CFood { 짜장면, 짬뽕, 볶음밥 };

        public Form1()
        {
            InitializeComponent();
        }

        private void btnMessageBox1_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            DialogResult result = DialogResult.None;

            if (btn.Name == "btnMessageBox1")
            {
                result = MessageBox.Show("안녕하세요~");  // 말
            }
            else if (btn.Name == "btnMessageBox2")
            {
                result = MessageBox.Show("안녕하세요~", "격하게 환영인사");  // 제목
            }
            else if (btn.Name == "btnMessageBox3")
            {
                result = MessageBox.Show("안녕하세요~", "격하게 환영인사",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Information);  // MessageBox버튼, 아이콘
            }
            switch (result)
            {
                case DialogResult.OK:
                    MessageBox.Show("나도 반가워요~ 😊");
                    break;
                case DialogResult.Cancel:
                    MessageBox.Show("나도 안반가워요~ 😂");
                    break;

            }

        }
    }
}
