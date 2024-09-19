using System.Numerics;
using System.Runtime.CompilerServices;

namespace ComplexNumbers
{
    /// <summary>
    /// Класс, который представляет комплексное число, состоящее из действительной и мнимой частей.
    /// Предоставляет методы для выполнения арифметических операций над комплексными числами,
    /// включая сложение, вычитание, умножение и деление
    /// </summary>
    public class ComplexNumber
    {
        //Действительная часть комплексного числа
        private double x;
        //Мнимая часть комплексного числа
        private double y;
        //Модуль (длина) комплексного числа
        private double rad;
        //Аргумент (угол) комплексного числа в радианах
        private double fi;


        /// <summary>
        /// Инициализирует новый экземпляр класса
        /// </summary>
        /// <param name="x">Действительная часть комплексного числа</param>
        /// <param name="y">Мнимая часть комплексного числа</param>
        public ComplexNumber(double x, double y)
        {
            this.x = x;
            this.y = y;
            rad = Math.Sqrt(x * x + y * y);
            fi = Math.Asin(y / rad);
        }

        /// <summary>
        /// Конструктор для создания комплексного числа в полярной форме
        /// </summary>
        /// <param name="rad">Модуль (длина) комплексного числа</param>
        /// <param name="fi">Аргумент (угол) комплексного числа в радианах</param>
        /// <param name="tip">Строка-идентификатор типа комплексного числа</param>
        public ComplexNumber(double rad, double fi, string tip)
        {
            this.rad = rad;
            this.fi = fi;
            x = Math.Round(Math.Cos(fi) * rad, 3);
            y = Math.Round(Math.Sin(fi) * rad, 3);
        }

        /// <summary>
        /// Конструктор без параметров, который создает комплексное число с действительной и мнимой частями, равными 1
        /// </summary>
        public ComplexNumber()
        {
            x = 1;
            y = 1;
            rad = Math.Sqrt(x + y);
            fi = Math.Asin(y / rad);
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
            return new ComplexNumber(rad * number.getRad(), fi + number.getFi(), "Privet");
        }

        /// <summary>
        /// Делит текущее комплексное число на указанное комплексное число
        /// </summary>
        /// <param name="number">Комплексное число, на которое нужно разделить текущее</param>
        /// <returns>Комплексное число, представляющее результат деления</returns>
        public ComplexNumber Div(ComplexNumber number)
        {
            return new ComplexNumber(rad / number.getRad(), fi - number.getFi(), "Privet");
        }

        /// <summary>
        /// Переопределяет метод ToString для представления комплексного числа в виде строки
        /// </summary>
        /// <returns>Строковое представление комплексного числа в формате "x ± yi", 
        /// где x - действительная часть, y - мнимая часть.</returns>
        public override string ToString()
        {
            x = Math.Round(x, 3);
            y = Math.Round(y, 3);
            string stry = "";
            if (y < 0)
                stry = y.ToString() + "i";
            if (y > 0 && x!=0)
                stry = "+ " + y.ToString() + "i";
            if (y > 0 && x == 0)
                stry = y.ToString() + "i";
            return x.ToString() + " " + stry;
        }

        /// <summary>
        /// Возвращает строковое представление комплексного числа в тригонометрической форме
        /// </summary>
        /// <returns>Строка в формате "r * (cos(phi) + i * sin(phi))", где:
        /// rad - модуль комплексного числа, округленный до 3 знаков после запятой
        /// fi - аргумент комплексного числа в радианах, округленный до 3 знаков после запятой</returns>
        public string ToStringPo()
        {
            rad = Math.Round(rad, 3);
            fi = Math.Round(fi, 3);
            if (rad == 0)
                return "";
            return $"{rad} * (cos({fi}) + i * sin({fi}))";
        }

        /// <summary>
        /// Возвращает строковое представление комплексного числа в экспоненциальной форме
        /// </summary>
        /// <returns>Строка в формате "r * e^(phi * i)", где:
        /// rad - модуль комплексного числа, округленный до 3 знаков после запятой
        /// fi - аргумент комплексного числа в радианах, округленный до 3 знаков после запятой</returns>
        public string ToStringExp()
        {
            rad = Math.Round(rad, 3);
            fi = Math.Round(fi, 3);
            if (rad == 0)
                return "";
            return $"{rad} * e ^ ({fi} * i)";
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
        /// Возвращает модуль (длину) текущего комплексного числа
        /// </summary>
        /// <returns>Модуль (длина) текущего комплексного числа</returns>
        public double getRad()
        {
            return rad;
        }

        /// <summary>
        /// Возвращает аргумент (угол) текущего комплексного числа
        /// </summary>
        /// <returns>Аргумент (угол) текущего комплексного числа</returns>
        public double getFi()
        {
            return fi;
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

        /// <summary>
        /// Реализует оператор сложения для двух комплексных чисел
        /// </summary>
        /// <param name="z1">Первое комплексное число для сложения</param>
        /// <param name="z2">Второе комплексное число для сложения</param>
        /// <returns>Новое комплексное число, являющееся результатом сложения</returns>
        public static ComplexNumber operator +(ComplexNumber z1, ComplexNumber z2)
        {
            return z1.Add(z2);
        }

        /// <summary>
        /// Реализует оператор вычитания для двух комплексных чисел
        /// </summary>
        /// <param name="z1">Первое комплексное число для вычитания</param>
        /// <param name="z2">Второе комплексное число для вычитания</param>
        /// <returns>Новое комплексное число, являющееся результатом вычитания</returns>
        public static ComplexNumber operator -(ComplexNumber z1, ComplexNumber z2)
        {
            return z1.Dif(z2);
        }

        /// <summary>
        /// Реализует оператор умножения для двух комплексных чисел
        /// </summary>
        /// <param name="z1">Первое комплексное число для умножения</param>
        /// <param name="z2">Второе комплексное число для умножения</param>
        /// <returns>Новое комплексное число, являющееся результатом умножения</returns>
        public static ComplexNumber operator *(ComplexNumber z1, ComplexNumber z2)
        {
            return z1.Mul(z2);
        }

        /// <summary>
        ///  Реализует оператор деления для двух комплексных чисел
        /// </summary>
        /// <param name="z1">Делимое комплексное число</param>
        /// <param name="z2">Делитель комплексное число</param>
        /// <returns>Новое комплексное число, являющееся результатом деления</returns>
        public static ComplexNumber operator /(ComplexNumber z1, ComplexNumber z2)
        {
            return z1.Div(z2);
        }
    }
}

