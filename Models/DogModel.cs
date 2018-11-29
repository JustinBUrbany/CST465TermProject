using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPTermProject.Models
{
    public class DogModel
    {
        public string DogType { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }

        public static readonly List<string> DogTypes = new List<string> { "German Sheppard", "Bull Dog", "Labrador Retriever" };
    }
}
