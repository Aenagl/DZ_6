using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Film film = new Film("Один дома", "комедия", "Американское семейство отправляется в путешествие, но в спешке забывают дома… одного из своих детей", 103, "Крис Коламбус");
            film.Info();
            film.Play();
            YouTube_Video ytvideo = new YouTube_Video("Три часа режу воду","развлекательный","увлекательно режу воду 3 часа",180,"энжитв")
            ytvideo.Info();
            ytvideo.Play();
        }
    }
}
