using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoShop;

namespace VideoShop
{
    public class Film : Video
    {
        public string Director { get; set; }

        public Film(string title, string genre, string description, int duration, string director) 
            : base(title, genre,description,duration)//Ключевое слово используется для доступа к членам базового класса из производного класса.
        {
            Director = director;
        }

        public override void Play()
        {
            Console.WriteLine($"Фильм:{Title},режиссер:{Director}");
        }

        public override void Info()
        {
            Console.WriteLine($"Фильм: {Title}, Жанр: {Genre}, Длительность: {Duration} минут, Режиссёр: {Director}");
        }
    }
}
