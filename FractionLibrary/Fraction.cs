

namespace FractionLibrary
{
    public class Fraction
    {
        private int numerator;                  //Teller (bovenaan)
        private int denominator;                // noemer (onderaan)

        public int Numerator
        {
            get { return numerator; }
            set { numerator = value; }
        }

        public int Denominator
        {
            get { return denominator; }
            set
            {
                if (value != 0)
                {
                    denominator = value;
                }
                else
                {
                    denominator = 1;
                }
            }
        }

        public Fraction()
        {
            Denominator = 0;
            Numerator = 0;
        }

        public Fraction(int numerator, int denominator)
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }

        public Fraction Add(Fraction right){
            int newNumerator = Numerator * right.Denominator + right.Numerator * Denominator;
            int newDenominator = Denominator * right.Denominator;
            return new Fraction(newNumerator, newDenominator).Simplify();
        }

        public Fraction Subtract(Fraction right)
        {
            int newNumerator = Numerator * right.Denominator - right.Numerator * Denominator;
            int newDenominator = Denominator * right.Denominator;
            return new Fraction(newNumerator, newDenominator).Simplify();
        }

        public Fraction Multiply(Fraction right)
        {
            int newNumerator = Numerator * right.Numerator;
            int newDenominator = Denominator * right.Denominator;
            return new Fraction(newNumerator, newDenominator).Simplify();
        }
        public Fraction Divide(Fraction right)
        {
            if(right.numerator == 0)
            {
                Console.WriteLine("error");
                right.numerator = 1;
                return new Fraction(0,0);
            }
            else
            {
                int newNumerator = Numerator * right.Denominator;
                int newDenominator = Denominator * right.Numerator;
                return new Fraction(newNumerator, newDenominator).Simplify();
            }
        }
        public Fraction ReciProcal()
        {
            int swapedNumerator = Denominator;
            int swapedDenominator = Numerator;
            return new Fraction(swapedNumerator, swapedDenominator);
        }
        public Fraction Invert(){
            return  new Fraction(-Numerator, Denominator);    
        }



        public Fraction Simplify() {

             int GCD(int a, int b)
            {
                while (b != 0)
                {
                    int temp = b;
                    b = a % b;
                    a = temp;
                }
                return a;
            }


            int gcd = GCD(Math.Abs(Numerator), Math.Abs(Denominator));

            int simplifiedNum = Numerator / gcd;
            int simplifiedDenom = Denominator / gcd;

            if (simplifiedNum < 0 && simplifiedDenom < 0)
            {
                simplifiedNum = Math.Abs(simplifiedNum);
                simplifiedDenom = Math.Abs(simplifiedDenom);
            }
            else if (simplifiedDenom < 0)
            {
                simplifiedNum = -Math.Abs(simplifiedNum);
                simplifiedDenom = Math.Abs(simplifiedDenom);
            }

            return new Fraction(simplifiedNum, simplifiedDenom);
        }

        public string Result() {
            double total = (double)  numerator / denominator;
            string v = total.ToString();
            return v;

        }

        public override string ToString() {

            return numerator + "/" + denominator;
        }
    }
}
