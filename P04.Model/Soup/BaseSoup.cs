using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04.Model.Soup
{
    public class BaseSoup
    {
        public int SoupId { get; set; }

        public string SoupName { get; set; }

        public string SoupDescription { get; set; }

        public ConsoleColor MessageColor { get; set; }
    }
}
