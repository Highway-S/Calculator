namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //ข้อความตัวอักษร
            string inputNum1 = num1.Text;
            string inputNum2 = num2.Text;

            // convert string to number (interger)
            // int => interger เลขจำนวนเต็ม
            // double / float => เลขทศนิยม
            double iNum1 = double.Parse(inputNum1);
            double iNum2 = double.Parse(inputNum2);

            // int ทำให้เราสามารถทำการ + - * / ได้
            double iResult = iNum1 + iNum2;

            // ที่ตัวแปร result
            //มีคุณสมบัตชื่อ Text
            result.Text = iResult.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //ข้อความตัวอักษร
            string inputNum1 = num1.Text;
            string inputNum2 = num2.Text;

            // convert string to number (interger)
            // int => interger เลขจำนวนเต็ม
            // double / float => เลขทศนิยม
            double iNum1 = double.Parse(inputNum1);
            double iNum2 = double.Parse(inputNum2);

            // int ทำให้เราสามารถทำการ + - * / ได้
            double iResult = iNum1 - iNum2;

            // ที่ตัวแปร result
            //มีคุณสมบัตชื่อ Text
            result.Text = iResult.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //ข้อความตัวอักษร
            string inputNum1 = num1.Text;
            string inputNum2 = num2.Text;

            // convert string to number (interger)
            // int => interger เลขจำนวนเต็ม
            // double / float => เลขทศนิยม
            double iNum1 = double.Parse(inputNum1);
            double iNum2 = double.Parse(inputNum2);

            // int ทำให้เราสามารถทำการ + - * / ได้
            double iResult = iNum1 * iNum2;

            // ที่ตัวแปร result
            //มีคุณสมบัตชื่อ Text
            result.Text = iResult.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //ข้อความตัวอักษร
            string inputNum1 = num1.Text;
            string inputNum2 = num2.Text;

            // convert string to number (interger)
            // int => interger เลขจำนวนเต็ม
            // double / float => เลขทศนิยม
            double iNum1 = double.Parse(inputNum1);
            double iNum2 = double.Parse(inputNum2);

            // int ทำให้เราสามารถทำการ + - * / ได้
            double iResult = iNum1 / iNum2;

            // ที่ตัวแปร result
            //มีคุณสมบัตชื่อ Text
            result.Text = iResult.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            num1.Text = "";
            num2.Text = "";
            result.Text = "";
        }
    }
}
