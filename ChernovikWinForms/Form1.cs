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
                TextDeleteFlag=false;
                ResultBtn.Text = "";
            }

            Button ClickedButt = (Button)sender;
            ResultBtn.Text = ResultBtn.Text + ClickedButt.Text;

        }

        private void BtnCE_Click(object sender, EventArgs e)
        {
            ResultBtn.Text = "";
        }

        private void PlusBtn_Click(object sender, EventArgs e)
        {
            Button ClickedButt = (Button)sender;
            Compare = ClickedButt.Text;
            FirstNumber = ResultBtn.Text;
            TextDeleteFlag = true;
        }

        private void EqualsBtn_Click(object sender, EventArgs e)
        {
            double Matchone, Matchtwo, MatchResult;
            Matchone = Convert.ToDouble(FirstNumber);
            Matchtwo = Convert.ToDouble(ResultBtn.Text);
            if(Compare == "+")
            {
                MatchResult = Matchone + Matchtwo;
                ResultBtn.Text = Convert.ToString(MatchResult);
            }
            if (Compare == "-")
            {
                MatchResult = Matchone - Matchtwo;
                ResultBtn.Text = Convert.ToString(MatchResult);
            }
            if (Compare == "/")
            {
                MatchResult = Matchone / Matchtwo;
                ResultBtn.Text = Convert.ToString(MatchResult);
                

            }
            if (Compare == "*")
            {
                MatchResult = Matchone * Matchtwo;
                ResultBtn.Text = Convert.ToString(MatchResult);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button ClickedButt = (Button)sender;
            ResultBtn.Text = ResultBtn.Text + ClickedButt.Text;
        }
    }
}