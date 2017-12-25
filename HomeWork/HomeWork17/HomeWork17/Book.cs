using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork17
{
    
    [Serializable]
    public class Book
    {
        [InputLocalization("Название книги")]
        public string Name { get; set; }
        [InputLocalization("Стоимость")]
        public double Price { get; set; }
        [InputLocalization("Автор")]
        public string Author { get; set; }
        [InputLocalization("Год издания")]
        public int Year { get; set; }

    }
}
