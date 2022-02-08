using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager2
{
    class Keys:Metods
    {
//        const int name_pos = 25;
//        int ind;
       
//        public void FileCreate()
//        {
//            ConsoleKey key = ConsoleKey.F;
//            string name = "";

//        Console.SetCursorPosition(0, name_pos + 2);
//            Console.Write("Введите имя и расширение (без расширения создастся папка): ");
//            name = Console.ReadLine();

//            if (name.IndexOf(".") == 1)
//            {
//                FileStream f = File.Create(Path + name);
//                f.Close();
//            }
//            else
//            {
//                Directory.CreateDirectory(Path + name);
//            }

//    ClearFiles();
//    ClearInput();
//}
//        public void Enter(int index)
//        {
           
//                if (index > 0)
//                {
//                    if (directs[index - 1].Extension == "" || directs[index - 1].Attributes == FileAttributes.Directory)
//                    {
//                        ClearFiles();
//                        Path += $@"{directs[index - 1].Name}\";
//                        PathInfo();
//                    }
//                    else if (directs[index - 1].Extension == ".exe")
//                    {
//                        RunExe(directs[index - 1]);
//                    }
//                    else if (directs[index - 1].Extension == ".txt")
//                    {

//                    }
//                    else
//                    {
//                        OpenDefault(Path + $@"{directs[index - 1].Name}");

//                    }

//                }
//                else if (index == 0)
//                {
//                    ClearFiles();
//                    OpenBackFolder();
//                }
            
//        }
//        public void OpenDefault(string path)
//        {
//            using Process fileopener = new Process();

//            fileopener.StartInfo.FileName = "explorer";
//            fileopener.StartInfo.Arguments = "\"" + path + "\"";
//            fileopener.Start();
//        }

//        public void RunExe(FileSystemInfo file)
//        {
//            Process.Start(file.FullName);
//        }

//        public string OpenBackFolder()
//        {
//            Path = Path.TrimEnd('\\');
//            int position = Path.LastIndexOf(@"\");
//            Path = Path.Substring(0, position + 1);
//            return Path;
//        }
//        public void DeleteFile(int index)
//        {
//            {
//                if (directs[index - 1].Extension == "" || directs[index - 1].Attributes == FileAttributes.Directory)
//                    Directory.Delete(directs[index - 1].FullName, true);
//                else
//                    File.Delete(directs[index - 1].FullName);
//            }
//            static void ClearBuffer()
//            {
//                while (Console.KeyAvailable)
//                {
//                    Console.ReadKey(false);
//                }
//            }
//        }
//        public void FileRename()
//        {
//            ConsoleKey key = ConsoleKey.R;

//                try
//                {
//                    Console.WriteLine("Введите имя файла который хотите переименовать>");
//                    var a = Console.ReadLine();

//                    Console.WriteLine("Введите желаемое имя файла>");
//                    var b = Console.ReadLine();

//                    Microsoft.VisualBasic.FileIO.FileSystem.RenameFile(a, b);
//                    ClearInput();
//                    Console.WriteLine($"файл {a} переименован в {b}");
//                }
//                catch (Exception)
//                {
//                    Console.WriteLine("Файл  невозможно переименовать");
//                }
            
//        }
//        public void FileCopy()
//        {

//        }
//        public void DriversControl()
//        {
//            DriveInfo[] Drives = DriveInfo.GetDrives();
//            int i = 1;
//            ConsoleKey key = ConsoleKey.Spacebar;
//            while (key != ConsoleKey.Escape)
//            {
//                ClearBuffer();
//                if (key == ConsoleKey.DownArrow)
//                    i++;
//                if (key == ConsoleKey.UpArrow)
//                    i--;
//                if (i < 1)
//                    i = Drives.Length;
//                if (i > Drives.Length)
//                    i = 1;

//                DriversInform(i);

//                key = Console.ReadKey(true).Key;
//                if (key == ConsoleKey.Enter)
//                {
//                    Path += Drives[i - 1].Name;
//                    break;
//                }
//                if (key == ConsoleKey.Escape)
//                {
//                    Console.SetCursorPosition(0, Console.WindowHeight);
//                    Environment.Exit(1);
//                }
//            }
//            ClearFiles();
//        }
//        public void Movement()
//        {

//        }
//        public void Start()
//        {
//            Console.SetWindowSize(126, 50);
//            try
//            {
//                int i = 0;
//                Console.CursorVisible = false;
//                Console.SetCursorPosition(0, name_pos + 1);
//                Console.WriteLine("Ввод: ");
//                ConsoleKey key = ConsoleKey.Spacebar;
//                while (key != ConsoleKey.Escape)
//                {
//                    Frame();
//                    ClearBuffer();
//                    if (key == ConsoleKey.DownArrow)
//                    {
//                        i++;
//                        if (i > directs.Count)
//                            i = directs.Count;
//                        else if (i - ind >= name_pos - 4)
//                        {
//                            ind++;
//                        }
//                    }
//                    if (key == ConsoleKey.UpArrow)
//                    {
//                        i--;
//                        if (i < 0)
//                            i = 0;
//                        else if (i < ind + 1)
//                        {
//                            ind--;
//                            if (ind < 0)
//                                ind = 0;
//                        }
//                    }

//                    if (Path == @"")
//                        DriversControl();
//                    DirectoryInform(i);

//                    key = Console.ReadKey(true).Key;
//                    if (key == ConsoleKey.Enter)
//                    {
//                        Enter(i);
//                        i = 0;
//                        ind = 0;
//                    }
//                    if (key == ConsoleKey.N)
//                        FileCreate();
//                    if (key == ConsoleKey.Delete)
//                        DeleteFile(i);

//                }
//            }
//            catch (Exception ex)
//            {
//                Console.SetCursorPosition(0, name_pos + 1);
//                Console.SetCursorPosition(0, name_pos + 2);
//                Console.WriteLine(ex.Message);
//                Console.ReadKey(true);
//                OpenBackFolder();
//                ClearInput();
//                Start();
//            }
//        }
    }
}
    