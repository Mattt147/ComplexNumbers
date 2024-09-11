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
            return new ComplexNumber(newX, newY);
        }

        public string toString()
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
            else if(x == 0)
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
    }
}

