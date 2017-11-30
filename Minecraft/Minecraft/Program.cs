using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft
{
    class Program
    {

        static void Main(string[] args)
        {
            Workbench crafter = new Workbench();
            Material[] materials = crafter.GetMaterials();
        //    crafter.reciept = new Material[9] { materials[0], materials[0], materials[0], null, materials[0], null, null, materials[0], null };
            int materialID = 0;
            int materialPos = 0;
            int menu = 0;
            bool parseResult = false;
            while (true)
            {
                Console.Clear();
                crafter.DrawWorkBench();
                switch (menu)
                {
                    case 0:
                        {
                            Console.WriteLine("Выберите действие:");
                            Console.WriteLine("1. Добавить в верстак материал.");
                            Console.WriteLine("2. Скрафтить.:");
                            Console.WriteLine("3. Очистить вестак:");
                            Console.Write("(root):>");
                            parseResult = int.TryParse(Console.ReadLine(),out menu);
                            break;
                        }
                    case 1:
                        {
                            Console.WriteLine("Выберите материал:");
                            Console.WriteLine("0. Дерево");
                            Console.WriteLine("1. Камень");
                            Console.WriteLine("2. Мифрил");
                            Console.WriteLine("3. Золото");
                            Console.WriteLine("4. Метал");
                            Console.Write("(root):>");
                            parseResult= int.TryParse(Console.ReadLine(),out materialID);
                            if (!parseResult)
                                break;
                            if (materialID > 5)
                                break;

                            Console.WriteLine("Выберите позицию для материала: ");
                            Console.Write("(root):>");
                            parseResult= int.TryParse(Console.ReadLine(),out materialPos);
                            if (!parseResult)
                                break;
                            crafter.AddMaterial(materials[materialID],materialPos);
                            menu = 0;
                            break;
                        }
                    case 2:
                        {
                            Tool newTool;
                            if (crafter.TryCraft(out newTool))
                            {
                                Console.WriteLine("Успешно: \n Получился: ");
                                Console.WriteLine(newTool.name);
                                
                            }
                            else
                            {
                                Console.WriteLine("Неверный рецепт");
                            }
                            Console.ReadKey();
                            menu = 0;
                            break;
                        }
                    case 3:
                        {
                            crafter.Reset();
                            menu = 0;
                            break;
                        }
                    default:
                        break;
                }


               


            }
        }
    }
}
