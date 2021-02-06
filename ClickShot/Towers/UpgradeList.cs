using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace ClickShot.Towers
{
    public abstract class UpgradeList
    {

        public static Newtonsoft.Json.JsonTextReader Get(string name)
        {
            TextReader tr = File.OpenText("./ul.json");
            JsonTextReader jr = new JsonTextReader(tr);
            return jr;
        }
    }
}