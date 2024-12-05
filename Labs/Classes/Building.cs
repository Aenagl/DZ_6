using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs
{
    internal class Building
    {
        #region Field
        private static int lastNum;
        /// <summary>
        /// Номер здания
        /// </summary>
        private int num;
        /// <summary>
        /// Высота здания
        /// </summary>
        private double height;
        /// <summary>
        /// Этажность здания
        /// </summary>
        private int floors;
        /// <summary>
        /// Количество квартир
        /// </summary>
        private int apartments;
        /// <summary>
        /// Количество подъездов
        /// </summary>
        private int hallways;
        #endregion

        #region Constructor
        public Building(double height, int floors, int apartments, int hallways)
        {
            this.num = CustomeNumber();
            this.height = height;
            this.floors = floors;
            this.apartments = apartments;
            this.hallways = hallways;
        }
        #endregion

        #region Methods
        public void ConsoleInfo()
        {
            Console.WriteLine($"Номер здания: {num}");
            Console.WriteLine($"Высота здания:{height}");
            Console.WriteLine($"Этажность здания:{floors}");
            Console.WriteLine($"Количество квартир:{apartments}");
            Console.WriteLine($"Количество подъездов:{hallways}");
        }
        public int CustomeNumber()
        {
            lastNum++;
            return lastNum;
        }
        public double HeightFloor()
        {
            return height / floors;
        }
        public int ApartmentHallway()
        {
            return apartments / hallways;
        }
        public int ApartmentFloor()
        {
            return apartments / floors;
        }
        #endregion
    }
}