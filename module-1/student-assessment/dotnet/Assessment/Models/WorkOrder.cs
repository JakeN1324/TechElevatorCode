using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment.Models
{
    public class WorkOrder
    {
        public string Name { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }
        public decimal EstimatedTotal
        {
            get
            {
                return ((Length * Width) / 100) * 4.99M;
            }
            set
            {

            }
            
        }

        public WorkOrder(string name, int length, int width)
        {
            Name = name;
            Length = length;
            Width = width;
        }

        

        public decimal ActualTotal(bool rush, bool icy)
        {
            if (rush == true && icy == true)
            {
                return EstimatedTotal += 33.96M + 24.75M;
                

            }
            else if (rush == true)
            {
                return EstimatedTotal += 16.98M;
                

            }
            else if (icy == true)
            {
                return EstimatedTotal += 24.75M;
                 

            }
            else
            {
                return EstimatedTotal;

            }


        }

        public override string ToString()
        {
            return $"WORK ORDER - " + Name + " - " + EstimatedTotal;
        }
    }
}
