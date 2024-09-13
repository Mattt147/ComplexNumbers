namespace ComplexNumbers
{
    /// <summary>
    /// Класс, который представляет комплексное число, состоящее из действительной и мнимой частей.
    /// Предоставляет методы для выполнения арифметических операций над комплексными числами,
    /// включая сложение, вычитание, умножение и деление
    /// </summary>
    public class ComplexNumber
    {
        private double x;
        private double y;

        /// <summary>
        /// Инициализирует новый экземпляр класса
        /// </summary>
        /// <param name="x">Действительная часть комплексного числа</param>
        /// <param name="y">Мнимая часть комплексного числа</param>
        public ComplexNumber(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        /// <summary>
        /// Складывает текущее комплексное число с указанным комплексным числом
        /// </summary>
        /// <param name="number">Комплексное число, которое нужно сложить с текущим</param>
        /// <returns>Комплексное число, представляющее результат сложения</returns>
        public ComplexNumber Add(ComplexNumber number)
        {
            return new ComplexNumber(x + number.getX(), y + number.getY());
        }

        /// <summary>
        /// Вычитает указанное комплексное число из текущего комплексного числа
        /// </summary>
        /// <param name="number">Комплексное число, которое нужно вычесть из текущего</param>
        /// <returns>Комплексное число, представляющее результат вычитания</returns>
        public ComplexNumber Dif(ComplexNumber number)
        {
            return new ComplexNumber(x - number.getX(), y - number.getY());
        }

        /// <summary>
        /// Умножает текущее комплексное число на указанное комплексное число
        /// </summary>
        /// <param name="number">Комплексное число, на которое нужно умножить текущее</param>
        /// <returns>Комплексное число, представляющее результат умножения</returns>
        public ComplexNumber Mul(ComplexNumber number)
        {
            double newX = x * number.getX() - y * number.getY();
            double newY = x * number.getY() + y * number.getX();
            return new ComplexNumber(newX, newY);
        }

        /// <summary>
        /// Делит текущее комплексное число на указанное комплексное число
        /// </summary>
        /// <param name="number">Комплексное число, на которое нужно разделить текущее</param>
        /// <returns>Комплексное число, представляющее результат деления</returns>
        public ComplexNumber Div(ComplexNumber number)
        {
            double newX = (x * number.getX() + y * number.getY()) / (number.getX() * number.getX() + number.getY() * number.getY());
            double newY = (y * number.getX() - x * number.getY()) / (number.getX() * number.getX() + number.getY() * number.getY());
            return new ComplexNumber(Math.Round(newX,3), Math.Round(newY,3));
        }


        /// <summary>
        /// Переопределяет метод ToString для представления комплексного числа в виде строки
        /// </summary>
        /// <returns>Строковое представление комплексного числа в формате "x ± yi", 
        /// где x - действительная часть, y - мнимая часть.</returns>
        public override string ToString()
        {
            string stry = "";
            if (y < 0)
                stry = y.ToString() + "i";
            if (y > 0 && x!=0)
                stry = "+ " + y.ToString() + "i";
            if (y > 0 && x == 0)
                stry = y.ToString() + "i";
            if (x == 0)
                return stry;
            return x.ToString() + " " + stry;
        }

        /// <summary>
        /// Возвращает значение действительной части комплексного числа
        /// </summary>
        /// <returns>Действительная часть комплексного числа</returns>
        public double getX()
        {
            return x;
        }

        /// <summary>
        /// Возвращает значение мнимой части комплексного числа
        /// </summary>
        /// <returns>Мнимая часть комплексного числа</returns>
        public double getY()
        {
            return y;
        }

        /// <summary>
        /// Переопределяет метод Equals для сравнения двух комплексных чисел.
        /// </summary>
        /// <param name="o">Объект, с которым нужно сравнить текущее комплексное число</param>
        /// <returns>true, если текущее комплексное число равно указанному объекту, иначе false</returns>
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

