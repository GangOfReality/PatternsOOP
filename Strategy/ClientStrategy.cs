using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public static class ClientStrategy
    {
        public static void ExecuteScript()
        {
            // Set compositor
            Composition composition = new Composition(new SimpleCompositor());

            // Create components List
            CreateComponentsList(composition);

            composition.Repair();
            composition.Draw();

            Console.WriteLine("\n\n");

            composition.SetCompositor(new ArrayCompositor());
            composition.Repair();
            composition.Draw();

            Console.WriteLine("\n\n");
        }

        public static void CreateComponentsList(Composition composition)
        {
            composition.AddComponent(new Component { Character = 'A', Width = 2 });
            composition.AddComponent(new Component { Character = 'B', Width = 3 });
            composition.AddComponent(new Component { Character = 'C', Width = 1 });
            composition.AddComponent(new Component { Character = 'D', Width = 2, Stretchability = true });
            composition.AddComponent(new Component { Character = 'E', Width = 3 });
            composition.AddComponent(new Component { Character = 'F', Width = 3 });
            composition.AddComponent(new Component { Character = 'G', Width = 1 });
            composition.AddComponent(new Component { Character = 'H', Width = 2, Stretchability = true });
            composition.AddComponent(new Component { Character = 'I', Width = 2 });
            composition.AddComponent(new Component { Character = 'J', Width = 1 });
            composition.AddComponent(new Component { Character = 'K', Width = 4, Stretchability = true }); ;
            composition.AddComponent(new Component { Character = 'L', Width = 1 });
            composition.AddComponent(new Component { Character = 'A', Width = 2 });
            composition.AddComponent(new Component { Character = 'B', Width = 3 });
            composition.AddComponent(new Component { Character = 'C', Width = 1 });
            composition.AddComponent(new Component { Character = 'D', Width = 2, Stretchability = true });
            composition.AddComponent(new Component { Character = 'E', Width = 3 });
            composition.AddComponent(new Component { Character = 'F', Width = 3 });
            composition.AddComponent(new Component { Character = 'G', Width = 1 });
            composition.AddComponent(new Component { Character = 'H', Width = 2, Stretchability = true });
            composition.AddComponent(new Component { Character = 'I', Width = 2 });
            composition.AddComponent(new Component { Character = 'J', Width = 1 });
            composition.AddComponent(new Component { Character = 'K', Width = 4, Stretchability = true }); ;
            composition.AddComponent(new Component { Character = 'L', Width = 1 });
            composition.AddComponent(new Component { Character = 'A', Width = 2 });
            composition.AddComponent(new Component { Character = 'B', Width = 3 });
            composition.AddComponent(new Component { Character = 'C', Width = 1 });
            composition.AddComponent(new Component { Character = 'D', Width = 2, Stretchability = true });
            composition.AddComponent(new Component { Character = 'E', Width = 3 });
            composition.AddComponent(new Component { Character = 'F', Width = 3 });
            composition.AddComponent(new Component { Character = 'G', Width = 1 });
            composition.AddComponent(new Component { Character = 'H', Width = 2, Stretchability = true });
            composition.AddComponent(new Component { Character = 'I', Width = 2 });
            composition.AddComponent(new Component { Character = 'J', Width = 1 });
            composition.AddComponent(new Component { Character = 'K', Width = 4, Stretchability = true }); ;
            composition.AddComponent(new Component { Character = 'L', Width = 1 });
        }
    }
}
