using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_02_Demo.Interface
{
    internal interface ISeries
    {
        int Current { get; }
        void GetNext();
        void Reset();
    }
    struct SeriesByTwo : ISeries
    {
        int current;
        public int Current
        {
            get { return current; }
        }

        public void GetNext()
        {
            current += 2;
        }

        public void Reset()
        {
            current = 0;
        }
    }
    struct SeriesByThree : ISeries
    {
        int current;
        public int Current
        {
            get { return current; }
        }

        public void GetNext()
        {
            current += 3;
        }

        public void Reset()
        {
            current = 0;
        }
    }
}
