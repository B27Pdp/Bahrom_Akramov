using _3_Modul.Lesson_10_February_14_2023;
using _3_Modul.Lesson_9_February_13_2023;

namespace _3_Modul
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MediaPlayer.playMusic("ptr.wav");

            //Console.WriteLine("<==== W E L K O M E ====>");
            //Console.WriteLine();
            //TimeSpan timeSpan = new TimeSpan(0, 0, 1);
            //Thread.Sleep(timeSpan);
            //int threeTime = 1;
            //while (threeTime < 3)
            //{
            //    Console.Clear();
            //    Console.WriteLine("<==== W E L K O M E ====>");
            //    //Thread.Sleep(timeSpan);
            //    Console.Write("\n.");
            //    Thread.Sleep(timeSpan);
            //    Console.Write(".");
            //    Thread.Sleep(timeSpan);
            //    Console.Write(".");
            //    Thread.Sleep(timeSpan);
            //    threeTime++;
            //}



            #region Anime
            //Console.CursorVisible = false;

            //// Initialize array of stars
            //int numStars = 100;
            //int[] x = new int[numStars];
            //int[] y = new int[numStars];
            //int[] z = new int[numStars];
            //Random random = new Random();
            //for (int i = 0; i < numStars; i++)
            //{
            //    x[i] = random.Next(Console.WindowWidth);
            //    y[i] = random.Next(Console.WindowHeight);
            //    z[i] = random.Next(1, 10);
            //}

            //// Loop indefinitely
            //int xxx = 10;
            //while (xxx>0)
            //{
            //    // Clear console and set background color to black
            //    Console.Clear();
            //    Console.BackgroundColor = ConsoleColor.Black;

            //    // Update the position of each star
            //    for (int i = 0; i < numStars; i++)
            //    {
            //        // Move star closer to viewer
            //        z[i] -= 1;

            //        // If star reaches the "camera", reset its position
            //        if (z[i] <= 0)
            //        {
            //            x[i] = random.Next(Console.WindowWidth);
            //            y[i] = random.Next(Console.WindowHeight);
            //            z[i] = 10;
            //        }

            //        // Calculate position on screen based on perspective projection
            //        int px = (int)Math.Round((x[i] * 10.0) / z[i] + Console.WindowWidth / 2.0);
            //        int py = (int)Math.Round((y[i] * 10.0) / z[i] + Console.WindowHeight / 2.0);

            //        // Set cursor position and write the star
            //        if (px >= 0 && px < Console.WindowWidth && py >= 0 && py < Console.WindowHeight)
            //        {
            //            Console.SetCursorPosition(px, py);
            //            Console.ForegroundColor = ConsoleColor.White;
            //            Console.Write("*");
            //        }
            //    }

            //    // Sleep for a short time to slow down the animation
            //    Thread.Sleep(50);
            //    xxx--;
            //}
            #endregion


            Console.CursorVisible = false;

            // Loop indefinitely
            int xx = 200;
            while (xx > 0)
            {
                // Randomly generate colored characters
                Random random = new Random();
                char[] colors = new char[] { ' ', '.', ':', '!', '*', 'o', 'e', '0' };
                ConsoleColor[] consoleColors = new ConsoleColor[] {
                ConsoleColor.Red, ConsoleColor.Yellow, ConsoleColor.Blue,
                ConsoleColor.Magenta, ConsoleColor.Green, ConsoleColor.Cyan,
                ConsoleColor.White, ConsoleColor.DarkGray, ConsoleColor.Gray,
                ConsoleColor.DarkBlue, ConsoleColor.DarkCyan, ConsoleColor.DarkGreen,
                ConsoleColor.DarkMagenta, ConsoleColor.DarkRed, ConsoleColor.DarkYellow
            };
                int colorIndex = random.Next(colors.Length);
                char c = colors[colorIndex];
                ConsoleColor consoleColor = consoleColors[colorIndex];

                // Get random position on the console
                int x = random.Next(Console.WindowWidth);
                int y = random.Next(Console.WindowHeight);

                // Set cursor position and write the colored character
                Console.SetCursorPosition(x, y);
                Console.ForegroundColor = consoleColor;
                Console.Write(c);

                // Sleep for a short time to create the fireworks effect
                Thread.Sleep(10);
                xx--;
            }




            //Lesson_1_Startup.Start();

            //Lesson_2_Startup.Start();

            //Lesson_8_Startup.Run();

            //Lesson_9_Startup.Run();
            Console.Clear();
            Console.CursorVisible = true;
            Lesson_10_Startup.Run();


            




            






            //List<char> list = new List<char>() { 'a', 'd', 'r', 'w' };
            //Console.WriteLine(list);
            //string s = "fdcqkmxwholhytmhafpesaentdvxginrjlyqzyhehybknvdmfrfvtbsovjbdhevlfxpdaovjgunjqlimjkfnqcqnajmebeddqsgl";
            //Console.WriteLine(s.Length);

        }

        public static string doubleSwap(string satr, char a, char b)
        {
            List<char> charList = new List<char>(satr);
            for (int i = 0; i < charList.Count; i++)
            {
                if (charList[i] == a)
                    charList[i] = b;

                else if (charList[i] == b)
                    charList[i] = a;
            }
            return string.Join("", charList);
        }
    }
}