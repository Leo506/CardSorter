using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.Shuffle
{
    public class ShuffleFactory
    {
        public static IShuffler GetShuffler() => new SimpleShuffler();
    }
}
