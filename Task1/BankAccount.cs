using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class BankAccount<T>
    {
        public T Num { get; set; }
        public int Balance { get; set; }
        public string Fullname { get; set; }
        public string GetInfo()
        {
            return ($"{Num} {Balance} {Fullname}");
        }
        public void Imput()
        {
            Console.WriteLine("Введите номер счёта");
            string stringNum = Console.ReadLine();
            Num = (T)Convert.ChangeType(stringNum, typeof(T));
            Console.WriteLine("Введите баланс");
            Balance = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите ФИО владельца");
            Fullname = Console.ReadLine();
        }
    }
}
