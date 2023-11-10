using System.ComponentModel;

namespace proverka1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo key;
            while (true)
            {
                Console.WriteLine("Добро пожаловать в проводник");
                Console.WriteLine("Enter - открыть папку/файл\nEscape - вернуться обратно/выйти");
                DriveInfo deive = inside.disks();
                string diskpath = Convert.ToString(deive);
                inside.info(diskpath);
            }
        }
    }
}