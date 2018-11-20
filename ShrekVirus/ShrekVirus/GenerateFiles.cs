using System;
using System.Collections.Generic;
using System.IO;

namespace ShrekVirus
{
    class GenerateFiles
    {
        public static void GenerateFile()
        {
            var user = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            var ganger = 1;
            List<string> epList = new List<string>();
            for (int i = 1; i <= ganger; i++)
            {
                epList.Add("Well");
            }

            File.WriteAllLines($@"{user}\Desktop\well.txt", epList);
        }
    }
}
