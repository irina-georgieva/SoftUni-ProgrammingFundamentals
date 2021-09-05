using System;

namespace P03_Extract_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullPath = Console.ReadLine();
            int lastIndexOfSlash = fullPath.LastIndexOf('\\');
            string fileNameWithExtention = fullPath
                .Substring(lastIndexOfSlash + 1, fullPath.Length - 1 - lastIndexOfSlash);

            int extentionIndex = fileNameWithExtention.LastIndexOf('.');
            string extention = fileNameWithExtention
                .Substring(extentionIndex + 1, fileNameWithExtention.Length - 1 - extentionIndex);
            
            string name = fileNameWithExtention.Substring(0, extentionIndex);

            Console.WriteLine($"File name: {name}");
            Console.WriteLine($"File extension: {extention}");
        }
    }
}
