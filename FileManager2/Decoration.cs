using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager2
{
    class Decoration
    {
        const int name_pos = 25,
            one = 1,
            three = 3,
            size_pos = 95,
            cd_pos = 105;
          
      
        public void LeftInfo()
        {
            string info = "Информация\n ";

            string leftinfo =
            "  Файловый менеджер\n" +
            "Создать нажмите:F\n" +
            "Открыть нажмите:Enter\n" +
            "Удалить нажмите:Delete\n" +
            "Переименовать нажмите:R";
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
       
       
    }
}
