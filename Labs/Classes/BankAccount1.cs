using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Labs
{
    enum Types
    {
        current,
        saving
    }
    internal class BankAccount1
    {
        #region Feild
        /// <summary>
        /// Номер счёта
        /// </summary>
        private string number;
        /// <summary>
        /// Тип счёта
        /// </summary>
        private Types type;
        /// <summary>
        /// Баланс счёта
        /// </summary>
        private decimal balance;
        #endregion

        #region Constructors
        public BankAccount1(string number, Types type, decimal balance)
        {
            this.number = number;
            this.type = type;
            this.balance = balance;
        }
        public BankAccount1()
        {
        }
        #endregion

        #region Quality
        public string Number
        {
            get { return number; }
            set { number = value; }
        }
        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public Types Type
        {
            get { return type; }
            set { type = value; }
        }
        #endregion

        #region Method

        public void ConsoleAccountInfo()
        {
            Console.WriteLine($"Номер счёта: {number}");
            Console.WriteLine($"Баланс: {balance}");
            Console.WriteLine($"Тип счёта: {type}");
        }
        #endregion
    }
}