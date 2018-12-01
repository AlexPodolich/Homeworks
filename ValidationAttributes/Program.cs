using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationAttributes
{
    class MyCustomAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            return !string.IsNullOrWhiteSpace(value as string);
        }
    }
    class AccountModel
    {
        /*
            StringLength - длина строку
            Compare - соответствие(сравнение) с каким то свойством
            RegularExpression - проверка условия через регулярное выражение
            Range - вхождение числа в диапазон
        */
        [StringLength(10, MinimumLength = 4, ErrorMessage = "Длина логина должна быть 4 - 10 символов")]
        public string Login { get; set; }

        [StringLength(8, MinimumLength = 4, ErrorMessage = "Длина пароля должна быть 4 - 8 символов")]
        public string Password { get; set; }

        [RegularExpression(@"\w+@\w+\.\w+", ErrorMessage = "Проверьте правильность ввода email")]
        public string Email { get; set; }

        [Range(0, 100, ErrorMessage = "Возраст должен быть в диапазоне 0 - 100")]
        public int Age { get; set; }

        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        public string ConfirmPassword { get; set; }

        [MyCustom(ErrorMessage = "Null or empty")]
        public string Text { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            AccountModel am = new AccountModel
            {
                Age = -10,
                ConfirmPassword = "11",
                Email = "asfas",
                Login = "",
                Password = "1234",
                Text = "d"
            };

            //Список ошибок
            var errors = new List<ValidationResult>();
            var ctx = new ValidationContext(am);

            //Валидация данных

            if (!Validator.TryValidateObject(am, ctx, errors, true))
            {
                foreach (var e in errors)
                {
                    Console.WriteLine(e.ErrorMessage);
                }
            }
            else
            {
                Console.WriteLine("Valid");
            }

            Console.Read();
        }
    }
}
