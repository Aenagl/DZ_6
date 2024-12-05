using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoShop
{
    public class YouTube_Video : Video
    {
        public string Channel { get; set; }

        public YouTube_Video(string title, string genre, string description, int duration, string channel)
            : base(title, genre, description, duration)//Ключевое слово используется для доступа к членам базового класса из производного класса.
        {
            Channel = channel;
        }
        //public YouTube_Video() { }
       
        public override void Play()
        {
            Console.WriteLine($"Ютуб видео:{Title},канал:{Channel}");
        }

        public override void Info()
        {
            Console.WriteLine($"Название: {Title}, Жанр: {Genre}, Длительность: {Duration} минут, Канал: {Channel}");
        }
    }
}
