namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float data1, data2;
        string pheptinh;

        // Number Buttons
        private void button1_Click(object sender, EventArgs e)
        {
            hienthi2.Text = hienthi2.Text + "7";  // Append 7 to the second display
        }

        private void button9_Click(object sender, EventArgs e)
        {
            hienthi2.Text = hienthi2.Text + "5";  // Append 5
        }

        private void button18_Click(object sender, EventArgs e)
        {
            hienthi2.Text = hienthi2.Text + "0";  // Append 0
        }

        private void button10_Click(object sender, EventArgs e)
        {
            hienthi2.Text = hienthi2.Text + "4";  // Append 4
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hienthi2.Text = hienthi2.Text + "8";  // Append 8
        }

        private void button14_Click(object sender, EventArgs e)
        {
            hienthi2.Text = hienthi2.Text + "1";  // Append 1
        }

        private void button13_Click(object sender, EventArgs e)
        {
            hienthi2.Text = hienthi2.Text + "2";  // Append 2
        }

        private void button12_Click(object sender, EventArgs e)
        {
            hienthi2.Text = hienthi2.Text + "3";  // Append 3
        }

        private void button8_Click(object sender, EventArgs e)
        {
            hienthi2.Text = hienthi2.Text + "6";  // Append 6
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hienthi2.Text = hienthi2.Text + "9";  // Append 9
        }

        private void button16_Click(object sender, EventArgs e)
        {
            hienthi2.Text = hienthi2.Text + ".";  // Append a decimal point
        }

        // Operation Buttons
        private void button15_Click(object sender, EventArgs e)
        {
            // Set operation to addition and store the first number (from hienthi2)
            pheptinh = "cong";
            data1 = float.Parse(hienthi2.Text);
            hienthi2.Clear();  // Clear the input after saving the first number
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pheptinh = "nhan";  // Multiplication
            data1 = float.Parse(hienthi2.Text);
            hienthi2.Clear();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            pheptinh = "tru";  // Subtraction
            data1 = float.Parse(hienthi2.Text);
            hienthi2.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pheptinh = "chia";  // Division
            data1 = float.Parse(hienthi2.Text);
            hienthi2.Clear();
        }

        // Clear Button
        private void button6_Click(object sender, EventArgs e)
        {
            hienthi2.Clear();  // Clear both displays
            hienthi1.Clear();
        }

        // Equals Button
        private void button19_Click(object sender, EventArgs e)
        {
            // Parse the second value from hienthi2
            data2 = float.Parse(hienthi2.Text);

            // Perform the operation based on the value of pheptinh
            switch (pheptinh)
            {
                case "cong":
                    data1 = data1 + data2;
                    break;
                case "tru":
                    data1 = data1 - data2;
                    break;
                case "nhan":
                    data1 = data1 * data2;
                    break;
                case "chia":
                    if (data2 != 0)
                    {
                        data1 = data1 / data2;
                    }
                    else
                    {
                        hienthi1.Text = "Cannot divide by 0";
                        return;
                    }
                    break;
                default:
                    hienthi1.Text = "Error";
                    return;
            }

            // Display the result
            hienthi1.Text = data1.ToString();

            // Clear the second input display, but keep the result for accumulation
            hienthi2.Clear();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            hienthi2.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
