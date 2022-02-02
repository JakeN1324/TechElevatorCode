using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    class Tractor : ISingable, ISellable
    {
        public string Name { get; } = "Tractor";
        public string Sound { get; } = "Vrooom";
        public decimal Price { get; } = 1500M;
    }
}
