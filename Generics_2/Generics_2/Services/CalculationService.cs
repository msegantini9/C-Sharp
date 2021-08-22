﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_2.Services
{
    class CalculationService
    {
        public T max<T>(List<T> list) where T : IComparable
        {
            if(list.Count == 0)
            {
                throw new ArgumentException("The list can't be empty!");
            }

            T max = list[0];

            for(int i = 0; i < list.Count; i++)
            {
                if(list[i].CompareTo(max) > 0)
                {
                    max = list[i];
                }
            }

            return max;
        }
    }
}
