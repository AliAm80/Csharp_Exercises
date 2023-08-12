using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise_5
{
    // Specific class for clothing products
    class ClothingDetails
    {
        public string Size { get; set; }
        public string Material { get; set; }

        public ClothingDetails(string size, string material)
        {
            Size = size;
            Material = material;
        }

        public override string ToString()
        {
            return $"Size : [{Size}],  Material : [{Material}]";
        }


    }
}