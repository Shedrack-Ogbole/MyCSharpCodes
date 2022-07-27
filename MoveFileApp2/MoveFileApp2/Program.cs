using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MoveFileApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string rootpath = @"C:\Users\Student\Downloads\";
            string[] downloadImagesDir = Directory.GetFiles(rootpath, "*.jpg*", SearchOption.AllDirectories);
            string destinationFolder = @"C:\Users\Student\Downloads\Images\";

            //Creating image folder if it does not exit

            bool directoryExist = Directory.Exists(destinationFolder);


            if (directoryExist)
            {
                Console.WriteLine("The directory exit ");

                try
                {


                    foreach (var image in downloadImagesDir)
                    {
                        File.Move(image, $"{destinationFolder}{Path.GetFileNameWithoutExtension(image)}");
                    }

                }
                catch (Exception err)
                {
                    Console.WriteLine("File already exist");
                }

            }
            else
            {
                Console.WriteLine("The directory does not exist");
                Directory.CreateDirectory(destinationFolder);

                foreach (var image in downloadImagesDir)
                {
                    File.Move(image, $"{destinationFolder}{Path.GetFileNameWithoutExtension(image)}");
                }
            }


            //Promptint user with associated messages if no image exist in download


            if (downloadImagesDir.Length == 0)
            {
                Console.WriteLine("No image exist");
            }
            else
            {
                Console.WriteLine("Images exist:");
            }


            Console.ReadLine();
        }
    }
}
