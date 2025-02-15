﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs
{
    internal class BankAccount2
    {
        #region Feild
        /// <summary>
        /// Номер счёта
        /// </summary>
        private int number;
        private  static int numberCounter = 0;
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
        public BankAccount2(Types type, decimal balance)
        {
            number = CustomNumber();
            this.type = type;
            this.balance = balance;
        }
        public BankAccount2()
        {
            number = CustomNumber();
        }
        #endregion

        #region Quality
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
        private static int CustomNumber()
        {
            return ++numberCounter;
        }

        #endregion
    }
}