using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace proverka1
{
    internal class inside
    {
        private static int pos;
        public static DriveInfo disks()
        {
            DriveInfo[] disk = DriveInfo.GetDrives();
            foreach (DriveInfo driveInfo in disk)
            {
                Console.WriteLine("  " + driveInfo.Name + "   Доступно: " + driveInfo.TotalFreeSpace/1073741824 + " Гбайт из "  + driveInfo.TotalSize/1073741824);
            }
            pos = strelka.show(3, disk.Length+3);
            return disk[pos-3];
        }
        public static void info(string papka)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Enter - открыть папку/файл Escape - вернуться обратно/выйти");
                string[] papkis = Array.Empty<string>();
                string[] papkafile = Array.Empty<string>();
                string[] result = Array.Empty<string>();
                var tochka = papka.Contains('.');
                if (tochka == false)
                {
                    try
                    {
                        papkis = Directory.GetDirectories(papka);
                        papkafile = Directory.GetFiles(papka);
                        result = papkafile.Concat(papkis).ToArray();
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("  Тут ничего нет");
                    }
                    foreach (var item in papkafile)
                    {
                        var datecreation = Directory.GetCreationTime(item);
                        var extendion1 = Path.GetExtension(item);
                        Console.WriteLine("  " + item + "\tДата создания: " + datecreation + "\tРасширение: " + extendion1);
                    }
                    foreach (var item in papkis)
                    {
                        var datecreation = Directory.GetCreationTime(item);
                        Console.WriteLine("  " + item + "\tДата создания: " + datecreation);
                    }
                }
                if (tochka == true)
                {
                    try
                    {
                        string extension = Path.GetExtension(papka);
                        Process.Start(new ProcessStartInfo { FileName = papka, UseShellExecute = true });
                        
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Нажмите Escape, чтобы выйти");
                    }
                }    
                pos = strelka.show(1, result.Length);
                if (pos == -1)
                    return;
                info(result[pos-1]);
            }
        }
    }
}
