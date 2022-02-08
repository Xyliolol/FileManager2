using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager2
{
    class Metods
    {
        public List<FileSystemInfo> directs;
        public string Path { get; set; }

        public Metods()
        {

            directs = new List<FileSystemInfo>();
            Path = @"";
        }

        const int
            size_pos = 95,
             one = 1,
            name_pos = 25,
            three = 3,
            cd_pos = 105,
            UtoDpos1 = 23,
            UtoDpos2 = 90,
            UtoDpos3 = 103,
            UtoDpos4 = 125;
        int ind,
            board = 41;

        public void DriversInform(int index = -1)
        {
            ClearFiles();
            for (int i = 0; i < 2; i++)
            {
                if (i + ind == index - 1)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                }
            }

            string[] Drives = Environment.GetLogicalDrives();

            foreach (string s in Drives)
            {
                Console.SetCursorPosition(name_pos, 4);
                Console.WriteLine(s);
                foreach (var drive in DriveInfo.GetDrives())
                {
                    Console.SetCursorPosition(size_pos, 4);
                    Console.WriteLine(drive.TotalSize / 1024 / 1024);
                }

            }
            Console.ResetColor();
        }
        public void LeftInfo()
        {
            string info = "Информация\n ";

            string leftinfo =
            "  Файловый менеджер\n" +
            "Создать нажмите:F\n" +
            "Открыть нажмите:Enter\n" +
            "Удалить нажмите:Delete\n" +
            "Скопировать и при желании\n" +
            "переименовать нажмите:R";
            string name = "Имя";
            string size = "размер";
            string crdate = "дата создания";



            Console.SetCursorPosition(name_pos, one);
            Console.WriteLine(name);
            Console.SetCursorPosition(size_pos, one);
            Console.WriteLine(size);
            Console.SetCursorPosition(cd_pos, one);
            Console.WriteLine(crdate);
            Console.SetCursorPosition(one, one);
            Console.WriteLine(info);
            Console.SetCursorPosition(one, three);
            Console.WriteLine(leftinfo);



        }

        public void PathInfo()
        {
            directs.Clear();
            directs.AddRange(new DirectoryInfo(Path).GetDirectories().Where(file =>
                (file.Attributes & FileAttributes.Hidden) == 0));
            directs.AddRange(new DirectoryInfo(Path).GetFiles().Where(file =>
                (file.Attributes & FileAttributes.Hidden) == 0));
        }
        public void DirectoryInform(int index)
        {
            PathInfo();
            ClearFiles();

            for (int i = 0; i < directs.Count; i++)
            {
                if (i + ind == index -1 )
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                }

                if (directs[i].Name.Length > 1000)
                {
                    Console.WriteLine("{ 0,1000 }  ", directs[i].Name);
                   
                }
                else
                {
                    Console.SetCursorPosition(name_pos, i + 4);
                    Console.WriteLine($"{directs[i].Name}");
                    Console.SetCursorPosition(cd_pos, i + 4);
                    Console.WriteLine($"{directs[i].LastWriteTime}");
                }
                if (directs[i] is FileInfo)
                {
                    Console.SetCursorPosition(size_pos, i + 4);
                    Console.WriteLine((directs[i] as FileInfo).Length / 1024);
                }
                Console.ResetColor();
            }
        }

        public void ClearFiles()
        {
            for (int i = 0; i < 23; i++)
            {
                Console.SetCursorPosition(i, name_pos);
                Console.Write(" ");

                for (int j = 10; j < 40; j++)
                {
                    Console.SetCursorPosition(i, j);
                    Console.Write(' ');
                }
            }
            for (int i = 24; i < 90; i++)
            {
                Console.SetCursorPosition(i, name_pos);
                Console.Write(" ");

                for (int j = 4; j < 40; j++)
                {
                    Console.SetCursorPosition(i, j);
                    Console.Write(' ');
                }
            }
            for (int i = 92; i < 101; i++)
            {
                Console.SetCursorPosition(i, name_pos);
                Console.Write(" ");

                for (int j = 4; j < 40; j++)
                {
                    Console.SetCursorPosition(i, j);
                    Console.Write(' ');
                }
            }
            for (int i = 106; i < 125; i++)
            {
                Console.SetCursorPosition(i, name_pos);
                Console.Write(" ");

                for (int j = 4; j < 40; j++)
                {
                    Console.SetCursorPosition(i, j);
                    Console.Write(' ');
                }
            }
        }
        public void ClearInput()
        {
            for (int i = 0; i < Console.WindowHeight - board; i++)
            {
                for (int j = 0; j < Console.WindowWidth - 1; j++)
                {
                    Console.SetCursorPosition(j, board + i);
                    Console.Write(" ");
                }
            }

        }
        public void ClearBuffer()
        {
            while (Console.KeyAvailable)
            {
                Console.ReadKey(false);
            }
        }
        public void Frame()
        {
            Console.SetCursorPosition(name_pos, 3);
            Console.WriteLine("...");
            for (int i = 1; i < 125; i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.WriteLine("-");
            }
            for (int i = 1; i < 125; i++)
            {
                Console.SetCursorPosition(i, 2);
                Console.WriteLine("-");
            }
            for (int i = 1; i < 125; i++)
            {
                Console.SetCursorPosition(i, 40);
                Console.WriteLine("-");
            }
            for (int i = 0; i < 40; i++)
            {
                Console.SetCursorPosition(UtoDpos1, i);
                Console.WriteLine("|");
            }
            for (int i = 0; i < 40; i++)
            {
                Console.SetCursorPosition(UtoDpos2, i);
                Console.WriteLine("|");
            }
            for (int i = 0; i < 40; i++)
            {
                Console.SetCursorPosition(UtoDpos3, i);
                Console.WriteLine("|");
            }
            for (int i = 0; i < 40; i++)
            {
                Console.SetCursorPosition(UtoDpos4, i);
                Console.WriteLine("|");

            }
            Console.SetCursorPosition(41, 0);
            Console.WriteLine(Path);
        }


        public void FileCreate()
        {
            ConsoleKey key = ConsoleKey.F;
            string name = "";

            Console.SetCursorPosition(6, 42);
            Console.Write("Введите имя и расширение (без расширения создастся папка): ");
            name = Console.ReadLine();

            if (name.IndexOf(".") == 1)
            {
                FileStream f = File.Create(Path + name);
                f.Close();
            }
            else
            {
                Directory.CreateDirectory(Path + name);
            }

            ClearFiles();
            ClearInput();
        }
        public void Enter(int index)
        {

            if (index > 0)
            {
                if (directs[index - 1].Extension == "" || directs[index - 1].Attributes == FileAttributes.Directory)
                {
                    ClearFiles();
                    Path += $@"{directs[index - 1].Name}\";
                    PathInfo();
                }
                else if (directs[index - 1].Extension == ".exe")
                {
                    RunExe(directs[index - 1]);
                }
                else if (directs[index - 1].Extension == ".txt")
                {

                }
                else
                {
                    OpenDefault(Path + $@"{directs[index - 1].Name}");

                }

            }
            else if (index == 0)
            {
                ClearFiles();
                OpenBackFolder();
            }

        }
        public void OpenDefault(string path)
        {
            using Process fileopener = new Process();

            fileopener.StartInfo.FileName = "explorer";
            fileopener.StartInfo.Arguments = "\"" + path + "\"";
            fileopener.Start();
        }

        public void RunExe(FileSystemInfo file)
        {
            Process.Start(file.FullName);
        }

        public string OpenBackFolder()
        {
            Path = Path.TrimEnd('\\');
            int position = Path.LastIndexOf(@"\");
            Path = Path.Substring(0, position + 1);
            return Path;
        }
        public void DeleteFile(int index)
        {
            {
                if (directs[index - 1].Extension == "" || directs[index - 1].Attributes == FileAttributes.Directory)
                    Directory.Delete(directs[index - 1].FullName, true);
                else
                    File.Delete(directs[index - 1].FullName);
            }          
        }
       
        public void FileCopy(string from,string to)
        {

                Console.SetCursorPosition(6, 43);
                Console.WriteLine("Укажите путь к файлу, кторый хотите скопировать");
                from = Console.ReadLine();
                Console.WriteLine("Укажите путь, куда скопировать фаил\n" +
                    "при желании можете переименовать фаил");
                to = Console.ReadLine();
            ClearInput();
            if (File.Exists(from))
            {
                File.Copy(from, to, true);
            }
            else
            {
                Console.WriteLine("файл не найден");
            }
            if (File.Exists(from) == File.Exists(to))
            {
                Console.SetCursorPosition(6, 43);
                Console.WriteLine("копирование не будет воспроизведено , так как указана одна и та же директория");
            }
        }

        public void DriversControl()
        {
            DriveInfo[] Drives = DriveInfo.GetDrives();
            int i = 1;
            ConsoleKey key = ConsoleKey.Spacebar;
            while (key != ConsoleKey.Escape)
            {
                ClearBuffer();
                if (key == ConsoleKey.DownArrow)
                    i++;
                if (key == ConsoleKey.UpArrow)
                    i--;
                if (i < 1)
                    i = Drives.Length;
                if (i > Drives.Length)
                    i = 1;

                DriversInform(i);

                key = Console.ReadKey(true).Key;
                if (key == ConsoleKey.Enter)
                {
                    Path += Drives[i - 1].Name;
                    break;
                }
                if (key == ConsoleKey.Escape)
                {
                    Console.SetCursorPosition(0, Console.WindowHeight);
                    Environment.Exit(1);
                }
            }
            ClearFiles();
        }

        public void Start()
        {
            Console.SetWindowSize(126, 50);

            try
            {
                int i = 0;
                Console.CursorVisible = false;
                Console.SetCursorPosition(0, 42);
                Console.WriteLine("Ввод: ");
                ConsoleKey key = ConsoleKey.Spacebar;
                while (key != ConsoleKey.Escape)
                {
                    Frame();
                    ClearBuffer();
                    if (key == ConsoleKey.DownArrow)
                    {
                        i++;
                        if (i > directs.Count)
                            i = directs.Count;
                        else if (i - ind >= 38)
                        {
                            ind++;
                        }
                    }
                    if (key == ConsoleKey.UpArrow)
                    {
                        i--;
                        if (i < 0)
                            i = 0;
                        else if (i < ind + 1)
                        {
                            ind--;
                            if (ind < 0)
                                ind = 0;
                        }
                    }

                    if (Path == @"")
                        DriversControl();
                    DirectoryInform(i);

                    key = Console.ReadKey(true).Key;
                    if (key == ConsoleKey.Enter)
                    {
                        Enter(i);
                        i = 0;
                        ind = 0;
                    }
                    if (key == ConsoleKey.F)
                        FileCreate();
                    if (key == ConsoleKey.Delete)
                        DeleteFile(i);
                    if (key == ConsoleKey.R)
                        FileCopy("","");
                }
            }
            catch (Exception ex)
            {
                Console.SetCursorPosition(0, name_pos + 1);
                Console.SetCursorPosition(0, name_pos + 2);
                Console.WriteLine(ex.Message);
                Console.ReadKey(true);
                OpenBackFolder();
                ClearInput();
                Start();
            }
        }
    }
}
