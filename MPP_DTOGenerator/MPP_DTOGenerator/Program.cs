using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MPP_DTOGenerator {
    class Program {

        static void Main(string[] args) {
            DTOGenerator generator = new DTOGenerator();
            DTO dtoObject;
            dtoObject = generator.parseJSON("C:\\Users\\Public\\Desktop\\test1.json");
            List<DTOContainer> items;
            items = dtoObject.Items;

            Console.WriteLine(items.ElementAt(2).ClassName);
            generator.startGenerating(dtoObject);
            Console.ReadKey();
        }
    }
}
