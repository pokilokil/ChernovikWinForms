namespace ChernovikWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TextDeleteFlag = false;
        }
        public string Compare;
        public string FirstNumber;
        public bool TextDeleteFlag;


            /// „то тут за параметры и за что они отвечают
        
        private void Btn0_Click(object sender, EventArgs e)
        {
            if(TextDeleteFlag == true)
            {
                TextDeleteFlag = false;
                ResultTextbox.Text = "";
            }

            Button ClickedButt = (Button)sender;
            ResultTextbox.Text = ResultTextbox.Text + ClickedButt.Text;

        }

        private void BtnCE_Click(object sender, EventArgs e)
        {
            ResultTextbox.Text = "";
        }

        private void PlusBtn_Click(object sender, EventArgs e)
        {
            Button ClickedButt = (Button)sender;
            Compare = ClickedButt.Text;
            FirstNumber = ResultTextbox.Text;
            TextDeleteFlag = true;
        }

        private void EqualsBtn_Click(object sender, EventArgs e)
        {
            double Matchone, Matchtwo, MatchResult;
            Matchone = Convert.ToDouble(FirstNumber);
            Matchtwo = Convert.ToDouble(ResultTextbox.Text);
            if(Compare == "+")
            {
                MatchResult = Matchone + Matchtwo;
                ResultTextbox.Text = Convert.ToString(MatchResult);
            }
            if (Compare == "-")
            {
                MatchResult = Matchone - Matchtwo;
                ResultTextbox.Text = Convert.ToString(MatchResult);
            }
            if (Compare == "/")
            {
                MatchResult = Matchone / Matchtwo;
                ResultTextbox.Text = Convert.ToString(MatchResult);
                

            }
            if (Compare == "*")
            {
                MatchResult = Matchone * Matchtwo;
                ResultTextbox.Text = Convert.ToString(MatchResult);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button ClickedButt = (Button)sender;
            ResultTextbox.Text = ResultTextbox.Text + ClickedButt.Text;
        }
    }
}