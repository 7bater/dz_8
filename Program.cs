//using dz_8;
//using System;
//using System.Text;
//using static System.Console;

//namespace dz_8
//{
//    internal class Program
//    {
//        private static void Main(string[] args)
//        {
//            OutputEncoding = Encoding.UTF8;

//            int[] numbers = { 5, 12, 3, 8, 20, 15 };
//            ArrayContainer container = new ArrayContainer(numbers);

//            WriteLine($"Менших за 10: {container.Less(10)}");
//            WriteLine($"Більших за 10: {container.Greater(10)}");

//            ReadKey();
//        }
//    }
//}

//exx2
//using System;
//using System.Text;
//using static System.Console;

//namespace dz_8
//{
//    internal class Program
//    {
//        private static void Main(string[] args)
//        {
//            OutputEncoding = Encoding.UTF8;

//            int[] numbers = { 1, 2, 3, 4, 5, 6 };
//            ArrayOutput output = new ArrayOutput(numbers);

//            output.ShowEven();
//            output.ShowOdd();

//            ReadKey();
//        }
//    }
//}

//exx3
//using System;
//using System.Text;
//using static System.Console;

//namespace dz_8
//{
//    internal class Program
//    {
//        private static void Main(string[] args)
//        {
//            OutputEncoding = Encoding.UTF8;

//            int[] numbers = { 4, 2, 4, 5, 2, 9, 1 };
//            ArrayCalc calc = new ArrayCalc(numbers);

//            WriteLine($"Кількість унікальних: {calc.CountDistinct()}");
//            WriteLine($"Кількість рівних 4: {calc.EqualToValue(4)}");

//            ReadKey();
//        }
//    }
//}


//exx4
//using System;
//using System.Text;
//using static System.Console;

//namespace dz_8
//{
//    internal class Program
//    {
//        private static void Main(string[] args)
//        {
//            OutputEncoding = Encoding.UTF8;

//            IRemoteControl tv = new TV();
//            tv.TurnOn();
//            tv.SetChannel(5);
//            tv.TurnOff();

//            WriteLine();

//            IRemoteControl radio = new Radio();
//            radio.TurnOn();
//            radio.SetChannel(102);
//            radio.TurnOff();

//            ReadKey();
//        }
//    }
//}



//exx5
using System;
using System.Text;
using static System.Console;

namespace dz_8
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            OutputEncoding = Encoding.UTF8;

            IValidator passValidator = new PasswordValidator();
            IValidator emailValidator = new EmailValidator();

            WriteLine($"Пароль '123' валідний: {passValidator.Validate("123")}");
            WriteLine($"Пароль 'secret123' валідний: {passValidator.Validate("secret123")}");

            WriteLine($"Email 'test@gmail.com' валідний: {emailValidator.Validate("test@gmail.com")}");
            WriteLine($"Email 'invalid-email' валідний: {emailValidator.Validate("invalid-email")}");

            ReadKey();
        }
    }
}