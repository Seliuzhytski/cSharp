using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*4.Файлы:
Создать три файла. В двух должен быть какой-то текст, последний пустой.
Прочитать содержимое первых двух файлов в различных потоках и записать результаты чтения в третий файл так, 
чтобы операции записи не мешали друг другу.*/

namespace HW_18
{
    public class FileHelper
    {
        private static readonly object locker = new();
        public void WriteData(string data, string filePath)
        {
            lock (locker)
            {
                using (var fs = new FileStream(filePath, FileMode.Append, FileAccess.Write))
                {
                    byte[] dataAsByteArray = new UTF8Encoding(true).GetBytes(data);
                    fs.Write(dataAsByteArray, 0, data.Length);
                }
            }
        }

        public string ReadData(string filePath)
        {
            lock (locker)
            {
                using (FileStream fstream = File.OpenRead(filePath))
                {
                    byte[] buffer = new byte[fstream.Length];
                    fstream.Read(buffer, 0, buffer.Length);
                    string textFromFile = Encoding.Default.GetString(buffer);
                    Console.WriteLine($"Текст из файла: {textFromFile}");
                    return textFromFile;
                }
            }
        }
    }
}
