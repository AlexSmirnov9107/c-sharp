using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9
{
    public class House
    {
        public Basement Basement { get; set; }
        public Roof Roof { get; set; }
        public Door Door { get; set; }
        public List<Walls> Walls { get; set; }
        public List<Window> Window { get; set; }

        public House()
        {
            Walls = new List<HomeWork9.Walls>
            {
                new Walls{Height=1,Widht=1,Length=1},
                new Walls{Height=1,Widht=1,Length=1},
                new Walls{Height=1,Widht=1,Length=1},
                new Walls{Height=1,Widht=1,Length=1}
            };
            Window = new List<HomeWork9.Window>
            {
                new Window{Height=1,Widht=1,Length=1},
                new Window{Height=1,Widht=1,Length=1},
                new Window{Height=1,Widht=1,Length=1},
                new Window{Height=1,Widht=1,Length=1}
            };
        }




    }
}
