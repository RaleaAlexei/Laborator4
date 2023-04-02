namespace Triunghi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private double TrianglePerimeter(double Side1, double Side2, double Side3)
        {

            return (Side1 + Side2 + Side3);
        }
        private double HeronsFormula(double Side1, double Side2, double Side3)
        {
            double HalfPerimeter = TrianglePerimeter(Side1, Side2, Side3) / 2;
            double Area = HalfPerimeter * (HalfPerimeter - Side1) * (HalfPerimeter - Side2) * (HalfPerimeter - Side3);
            return Math.Sqrt(Area);
        }
        private void btCalculate_Click(object sender, EventArgs e)
        {
            int.TryParse(tbSide1.Text, out int Side1);
            int.TryParse(tbSide2.Text, out int Side2);
            int.TryParse(tbSide3.Text, out int Side3);
            // If any of the sides is 0 then return
            lbResult.Text = "Triunghiul nu este valid";
            if (Side1 == 0 || Side2 == 0 || Side3 == 0)
                return;
            if (Side1 + Side2 <= Side3)
                return;
            if (Side1 + Side3 <= Side2)
                return;
            if (Side2 + Side3 <= Side1)
                return;
            double Area = Math.Round(HeronsFormula(Side1, Side2, Side3), 2);

            lbResult.Text = $"Area of the triangle is: {Area} cm^2";


        }
    }
}