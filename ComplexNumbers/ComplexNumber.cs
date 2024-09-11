namespace ComplexNumbers
{
    public class ComplexNumber
    {
        private double x;
        private double y;

        public ComplexNumber(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public ComplexNumber Add(ComplexNumber number)
        {
            return new ComplexNumber(x + number.getX(), y + number.getY());
        }

        public ComplexNumber Dif(ComplexNumber number)
        {
            return new ComplexNumber(x - number.getX(), y - number.getY());
        }

        public ComplexNumber Mul(ComplexNumber number)
        {
            double newX = x * number.getX() - y * number.getY();
            double newY = x * number.getY() + y * number.getX();
            return new ComplexNumber(newX, newY);
        }

        public ComplexNumber Div(ComplexNumber number)
        {
            double newX = (x * number.getX() + y * number.getY()) / (number.getX() * number.getX() + number.getY() * number.getY());
            double newY = (y * number.getX() - x * number.getY()) / (number.getX() * number.getX() + number.getY() * number.getY());
            return new ComplexNumber(Math.Round(newX,3), Math.Round(newY,3));
        }

        public override string ToString()
        {
            string stry = "";
            if (y < 0)
            {
                stry = "- " + y.ToString() + "i";
            }
            else if (y > 0)
            {
                stry = "+ " + y.ToString() + "i";
            }
            if(x == 0)
            {
                return stry;
            }
            return x.ToString() + " " + stry;
        }


        public double getX()
        {
            return x;
        }
        public double getY()
        {
            return y;
        }
        public override bool Equals(object o)
        {
            ComplexNumber num  = (ComplexNumber)o;
            if (num.getX() == this.x && num.getY() == this.y)
            {
                return true;
            }
            return false;
        }
    }
}

