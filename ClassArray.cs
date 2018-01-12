using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    class ClassArray<T> where T : ITechno
    {
        private T defaultValue;
        private Dictionary<int, T> places;
        private int maxCount;
        
        public ClassArray(int size, T defVal)
        {
            defaultValue = defVal;
            places = new Dictionary<int, T>();
            maxCount = size;            
        }
      
        public static int operator +(ClassArray<T> p, T ship)
        {
            if (p.places.Count == p.maxCount)
            {
                return -1;
            }
            for (int i = 0; i < p.places.Count; i++)
            {
                if (p.CheckFreePlace(i))
                {
                    p.places.Add(i, ship);
                    return i;
                }
            }

            p.places.Add(p.places.Count, ship);
            return p.places.Count - 1;
          
        }
        public static T operator -(ClassArray<T> p, int index)
        {
            if (p.places.ContainsKey(index))
            {
                T ship = p.places[index];
                p.places.Remove(index);
                return ship;
            }
            return p.defaultValue;
        }
        private bool CheckFreePlace(int index)
        {
            return !places.ContainsKey(index);
        }

        public T this[int ind]
        {
            get
            {
                if (places.ContainsKey(ind))
                {
                    return places[ind];

                }
                return defaultValue;
            }
        }


    }
}

