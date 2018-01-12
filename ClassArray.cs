using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;




namespace WindowsFormsApplication3
{
    class ClassArray<T> : IEnumerator<T>, IEnumerable<T>, IComparable <ClassArray<T>>
    {
        private int currentIndex;
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
            var isKreiser = ship is Kreiser;
       
            if (p.places.Count == p.maxCount)
            {
               throw new ParkingOverflowException();
            }
            int index = p.places.Count;
            for (int i = 0; i < p.places.Count; i++)
            {
                if (p.CheckFreePlace(i))
                {
                    return i;
                }

                if (ship.GetType() == p.places[i].GetType())
                {
                    if (isKreiser)
                    {
                        if ((ship as Kreiser).Equals(p.places[i]))
                        {
                            throw new ParkingAlreadyHaveException();
                        }
                    }
                    else if ((ship as Ship).Equals(p.places[i]))
                    {
                        throw new ParkingAlreadyHaveException();
                    }
                }

            }
            if (index != p.places.Count)
            {
                p.places.Add(index, ship);
                return index;
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
            throw new ParkingIndexOutOfRangeException();
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
        public T Current
        {
            get
            {
                return places[places.Keys.ToList()[currentIndex]];
            }
        }
        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public void Dispose()
        {

        }


        public bool MoveNext()
        {
            if (currentIndex + 1 >= places.Count)
            {
                Reset();
                return false;
            }
            currentIndex++;
            return true;
        }
        public void Reset()
        {
            currentIndex = -1;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public int CompareTo(ClassArray<T> other)
        {
            if (this.Count() > other.Count())
            {
                return -1;
            }

            else if (this.Count() < other.Count())
            {
                return 1;
            }
            else
            {
                var thiskeys = this.places.Keys.ToList();
                var otherKeys = other.places.Keys.ToList();
                for (int i = 0; i < this.places.Count; ++i)
                {
                    if (this.places[thiskeys[i]] is Ship && other.places[thiskeys[i]] is Kreiser)
                    {
                        return 1;
                    }

                    if (this.places[thiskeys[i]] is Kreiser && other.places[thiskeys[i]] is Ship)
                    {
                        return -1;
                    }
                    if (this.places[thiskeys[i]] is Ship && other.places[thiskeys[i]] is Ship)
                    {
                        return (this.places[thiskeys[i]] is Ship)
                            .CompareTo(other.places[thiskeys[i]] is Ship);
                    }

                   
                }
            }

            return 0;
        }



    }
}

