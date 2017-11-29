using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Parent Class 
            File myFile = new File();
            Console.WriteLine(myFile.getinfo()); 
            myFile.setName( "New File");
            Console.WriteLine(myFile.getName());
            myFile.setSize(1024);
            Console.WriteLine(myFile.getSize());
            myFile.setExt("txt");
            Console.WriteLine(myFile.getExt());
            // Child Class
            image myImg = new image();
            Console.WriteLine(myImg.getinfo());
            myImg.setExt("jpeg");
            Console.WriteLine(myImg.getExt());
            myImg.setQuality("High");
            Console.WriteLine(myImg.getQuality());
            // Another Child Class
            video myVid = new video();
            Console.WriteLine(myVid.getinfo());
            myVid.setExt("mp4");
            Console.WriteLine(myVid.getExt());
            myVid.setDuration(65);
            Console.WriteLine(myVid.getDuration());

            Console.ReadLine();
        }
    }
}
