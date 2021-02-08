using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace ClickShot.Towers
{
    public abstract class UpgradeList
    {
        public static string Get(string name, int lvl)
        {
            TextReader tr = File.OpenText("./ul.json");
            JsonTextReader jr = new JsonTextReader(tr);
            var s = jr.ToString();
            Console.WriteLine(s);
            return s;
        }
    }
}