using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileClass
{
    interface Ifile {
        void CreateFile();
        void OpenFile();
        void ClopseFile();
        
    }
    
    class file : Ifile { 
    
    }

    class image : file { }
    class audio : file { }
    class video : file { }
    class text : file { }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
