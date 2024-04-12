using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_17
{
 /*1.Написать класс для работы с директориями: 
 * Класс должен содержать методы принимающие путь к папке и возвращающий: 
 * Количество файлов в каталоге, 
 * FileInfo[] файлов из папки, 
 * Класс должен содержать метод принимающие путь к папке и расширение файлов(txt например): 
 * Количество файлов в каталоге, 
 * FileInfo[] файлов из папки.*/

    internal class NumberFilesAndFileInfo
    {
        public void GetNumberAndInfoFile (string path)
        {
            string[] files = Directory.GetFiles(path);
            Console.WriteLine($"Количество файлов: {files.Length}\n");
            
            foreach ( string file in files )
            {
                var fileInfo = new FileInfo(file);
                Console.WriteLine($"Имя файла: {fileInfo.Name}");
                Console.WriteLine($"Время создания: {fileInfo.CreationTime}");
                Console.WriteLine($"Размер: {fileInfo.Length} \n");
            }
        }

        public void GetNumberAndInfoFileByExtension (string path, string extension)
        {
            var files = Directory.GetFiles(path).ToList();
            Console.WriteLine($"Количество файлов с расширением \"{extension}\" = {files.Count(x => x.EndsWith(extension))}\n"); 

            for (int i = 0; i < files.Count; i++)
            {
                var fileInfo = new FileInfo(files[i]);

                if (fileInfo.Extension == extension)
                {
                    Console.WriteLine($"Имя файла: {fileInfo.Name}");
                    Console.WriteLine($"Время создания: {fileInfo.CreationTime}");
                    Console.WriteLine($"Размер: {fileInfo.Length} \n");
                }
            }
        }
    }
}
