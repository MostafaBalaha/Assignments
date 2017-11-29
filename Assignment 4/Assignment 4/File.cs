using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    interface IFile
    {
        void setName();
        string getName();
      
        string getInfo();
        void setExt();
        string getExt();
        void setSize();
        double getSize();

    }
    class File
    {
        string name,info,ext;
        double size;
        public File()
        {
            name = "";
            info = "";
            ext = "";
            size = 0.0;

        }
        public void setName(string x)
        {
            name = x;
        }
        public string getName()
        {
            return name;
        }
       
        public virtual string getinfo()
        {
            return "This is a file :D";
        }
        public void setExt(string x)
        {
            ext = x;
        }
        public string getExt()
        {
            return ext;
        }
        public void setSize(double x)
        {
            size = x;
        }
        public double getSize()
        {
            return size;
        }



    }
    class image :File
    {
        string imageQuality;
        public image()
        {
            imageQuality = "Normal";
        }
        public override string getinfo()
        {
            return "This is an image, :D";
        }

        public void setQuality(string x)
        {
            imageQuality = x;
        }

        public string getQuality()
        {
           return imageQuality ;
        }

    }
    class video :File
    {
        double duration;
        public video()
        {
            duration = 0.0;
        }

        public override string getinfo()
        {
            return "This is a video, :)";
        }
        public void setDuration(double x)
        {
            duration = x;
        }
        public double getDuration()
        {
            return duration;
        }
    }
}
