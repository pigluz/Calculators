namespace WinForms.Calculator
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        String operatorPerformed = "";
        bool isOperationPerfomed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {
            if ((textBox_result.Text == "0" )|| (isOperationPerfomed))
                textBox_result.Clear();

            Button button = (Button)sender;
            if(button.Text == "." ) 
            {
                if(!textBox_result.Text.Contains("."))
                    textBox_result.Text = textBox_result.Text + button.Text;

            }   else
                textBox_result.Text = textBox_result.Text + button.Text;

            isOperationPerfomed = false;


        }

        private void textBox_result_TextChanged(object sender, EventArgs e)
        {

        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (resultValue != 0)
            {
                button_rowna.PerformClick();
                operatorPerformed = button.Text;
                isOperationPerfomed = true;
                labelCurrentOperation.Text = resultValue + " " + operatorPerformed;
            }
            else
            {

                operatorPerformed = button.Text;
                resultValue = Double.Parse(textBox_result.Text);
                isOperationPerfomed = true;
                labelCurrentOperation.Text = resultValue + " " + operatorPerformed;
            }
        }

        private void button_clearentry_Click(object sender, EventArgs e)
        {
            textBox_result.Text = "0";
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_result.Text = "0";
            resultValue = 0;
        }

        private void button_rowna_Click(object sender, EventArgs e)
        {
            switch (operatorPerformed)
            {
                case "+":
                    textBox_result.Text=(resultValue + Double.Parse(textBox_result.Text)).ToString(); 
                    break;

                case "-":
                    textBox_result.Text = (resultValue - Double.Parse(textBox_result.Text)).ToString();
                    break;

                case "/":
                    textBox_result.Text = (resultValue / Double.Parse(textBox_result.Text)).ToString();
                    break;

                case "*":
                    textBox_result.Text = (resultValue * Double.Parse(textBox_result.Text)).ToString();
                    break;

                default:
                    break;
            }
            resultValue = double.Parse(textBox_result.Text);
            labelCurrentOperation.Text = " ";
        }
    }
}