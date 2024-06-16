using System;
using System.IO;
using FileParser;

namespace VehicleExample
{
    public abstract class BaseFileParser
    {
        string first_line_str;
        public BaseFileParser(string dataPath)
        {
            FileParser.IParsedFile file = new FileParser.ParsedFile(dataPath);
            FileParser.IParsedLine first_line = file.NextLine();
            first_line_str = first_line.NextElement<string>();
        }
    }


    public class WindowsFileParser : BaseFileParser
    {
        public WindowsFileParser(string dataPath) : base(dataPath)
        {

        }
    }


    public class LinuxFileParser : BaseFileParser
    {
        public LinuxFileParser(string dataPath) : base(dataPath)
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an array of Vehicle objects
            //Vehicle[] vehicles = new Vehicle[]
            //{
            //    new Car("path/to/car1/data"),
            //    new Bus("path/to/bus1/data"),
            //    new Car("path/to/car2/data"),
            //    new Bus("path/to/bus2/data")
            //};

            string filename = "SimpleInput1.txt";
            string currentFolder = Directory.GetCurrentDirectory();
            DirectoryInfo parent_folder = Directory.GetParent(currentFolder);
            DirectoryInfo grand_parent_folder = Directory.GetParent(parent_folder.FullName);
            DirectoryInfo grand_grand_parent_folder = Directory.GetParent(grand_parent_folder.FullName);
            DirectoryInfo grand_grand_grand_parent_folder = Directory.GetParent(grand_grand_parent_folder.FullName);
            string file_full_path = Path.Combine(grand_grand_grand_parent_folder.FullName, "net6.0", filename);

            BaseFileParser david = new WindowsFileParser(file_full_path);

            System.Console.ReadLine();
        }
    }
}
