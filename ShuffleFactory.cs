using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.Shuffle
{
    public class ShuffleFactory
    {
        public static IShuffler GetShuffler()
        {
            var reader = new AppSettingsReader();

            var shufflerSetting = reader.GetValue("Shuffler", typeof(string));

            if (shufflerSetting != null && shufflerSetting.ToString() == "Human")
                return new HumanShuffler();

            return new SimpleShuffler();
        }
    }
}
