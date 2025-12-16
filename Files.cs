using System;
using System.Collections.Generic;
using System.IO;//Files 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPrograms
{
    internal class Files
    {
        static void Main(string[] args)
        {
            //Write();
            //Read();
            //Append();
            //Thread.Sleep(5000);
            //Read();
            //FileExists();
            FilesDirectoriesDemo();
            Console.ReadLine();

        }
        // Write to a file
        // Create, Open, Write, Close
        public static void Write()
        {
            //@ - verbatim string literal
            FileInfo fileInfo = new FileInfo(@"C:\Pallavi_Koenig\Dot NET with C#, SQL and ASP.NET\CSharpPrograms\FileDemo1.txt");
            //FileMode - Open the file/Create the file
            FileStream fileStream = fileInfo.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
            //fileStream - FileDemo1.txt
            //StreamWriter - to write the data into the file - fileStream - FileDemo1.txt
            StreamWriter writer = new StreamWriter(fileStream);
            try
            {
                writer.WriteLine("Welcome to files again"); // FileDemo1.txt
                writer.WriteLine("This is second line in the file");
                writer.WriteLine("Welcome to Toyota");
                writer.Flush(); // to clear the buffer and write the data into the file
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            //Even if there is an exception or not the below code should execute
            finally
            {
                writer.Close();
                fileStream.Close();
            }
        }
        // Read from a file
        public static void Read()
        {
            FileInfo fileInfo = new FileInfo(@"C:\Pallavi_Koenig\Dot NET with C#, SQL and ASP.NET\CSharpPrograms\FileDemo1.txt");
            FileStream fileStream = fileInfo.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
            StreamReader reader = new StreamReader(fileStream);//read the data from the file - fileStream - FileDemo1.txt
            try
            {
                string line;
                line = reader.ReadToEnd();
                Console.WriteLine(line);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                reader.Close();
                fileStream.Close();
            }
        }
        //Append to a file
        public static void Append()
        {
            FileInfo fileInfo = new FileInfo(@"C:\Pallavi_Koenig\Dot NET with C#, SQL and ASP.NET\CSharpPrograms\FileDemo1.txt");
            FileStream fileStream = fileInfo.Open(FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
            StreamWriter writer = new StreamWriter(fileStream);
            try
            {
                writer.WriteLine("Appended content into the file");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                writer.Close();
                fileStream.Close();
            }
        }

        public static void FileExists()
        {
            string path = @"C:\Pallavi_Koenig\Dot NET with C#, SQL and ASP.NET\CSharpPrograms\FileDemo.txt";
            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }

        public static void FilesDirectoriesDemo()
        {
            //File.WriteAllText(@"E:\Dlithe1.txt","I am a one line File Write Method");

            FileInfo fileInfo = new FileInfo(@"C:\Pallavi_Koenig\Dot NET with C#, SQL and ASP.NET\CSharpPrograms\FileDemo1.txt");
            Console.WriteLine(fileInfo.FullName);
            Console.WriteLine(fileInfo.Name);
            Console.WriteLine(fileInfo.Length);
            Console.WriteLine(fileInfo.CreationTime);
            Console.WriteLine(fileInfo.LastAccessTime);
            Console.WriteLine(fileInfo.LastWriteTime);
            Console.WriteLine(fileInfo.Extension);
            Console.WriteLine("******************************");
            foreach (string files in Directory.GetFiles(@"C:\Pallavi_Koenig\Dot NET with C#, SQL and ASP.NET"))
            {
                Console.WriteLine(files);

            }
            Console.WriteLine("******************************");
            foreach (string files in Directory.GetDirectories(@"C:\Pallavi_Koenig\Dot NET with C#, SQL and ASP.NET"))
            {
                Console.WriteLine($"{files}");
            }
        }

    }
}
