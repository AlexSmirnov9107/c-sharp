using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft
{
    public class Workbench
    {
        public Material[] reciept = new Material[9];
        Material[] materials = new Material[5] {
            new Material(0, "Дерево"),
            new Material(1, "Камень"),
            new Material(2, "Мифрил"),
            new Material(3, "Золото"),
            new Material(4, "Метал")
    };
        List<Tool> tools = new List<Tool>();
        private static int size = 0;
        public Workbench()
        {
            tools.Add(new Tool(new Material[9] { materials[1], materials[1], materials[1], null, materials[0], null, null, materials[0], null },"Кирка"));
            tools.Add(new Tool(new Material[9] { materials[0], materials[0], materials[0], null, materials[0], null, null, materials[1], null }, "Топор"));
            tools.Add(new Tool(new Material[9] { null, materials[1], null, null, materials[0], null, null, materials[0], null }, "Лопата"));
            tools.Add(new Tool(new Material[9] { materials[1], materials[1], null, null, materials[0], null, null, materials[0], null }, "Мотыга"));
            Reset();
        }
        public void Reset()
        {
            for (int i = 0; i < 9; i++)
            {
                reciept[i] = null;
            }
        }
        public static Workbench operator +(Workbench o, Material m)
        {
            o.reciept[size++] = m;
            return o;
        }
        public void AddMaterial(Material m, int pos)
        {
            pos = (((pos / 10) - 1) * 3 + pos % 10) - 1;
            if (pos < 9)
                reciept[pos] = m;
        }
        public string GetElementName(int pos)
        {
            if (pos < 9)
                return this.reciept[pos].GetName();
            else
                return "Нет такого элемента";
        }
        public bool TryCraft(out Tool t)
        {
            Tool newTool = new Tool(reciept,"New");
            t = newTool;
            if (newTool == tools) { 
                return true;
            };
            return false;
        }
        public void DrawWorkBench()
        {
            Console.WriteLine("- Верстак -");
            Console.WriteLine("   1 2 3");
            Console.WriteLine("  -------");
            Console.WriteLine("1 |{0}|{1}|{2}|", (reciept[0] != null? reciept[0].ToString(): " "), (reciept[1] != null ? reciept[1].ToString() : " "), (reciept[2] != null ? reciept[2].ToString() : " "));
            Console.WriteLine("  -------");
            Console.WriteLine("2 |{0}|{1}|{2}|", (reciept[3] != null ? reciept[3].ToString() : " "), (reciept[4] != null ? reciept[4].ToString() : " "), (reciept[5] != null ? reciept[5].ToString() : " "));
            Console.WriteLine("  -------");
            Console.WriteLine("3 |{0}|{1}|{2}|", (reciept[6] != null ? reciept[6].ToString() : " "), (reciept[7] != null ? reciept[7].ToString() : " "), (reciept[8] != null ? reciept[8].ToString() : " "));
            Console.WriteLine("  -------");
        }
        public Material[] GetMaterials()
        {
            return materials;
        }

    }

}
