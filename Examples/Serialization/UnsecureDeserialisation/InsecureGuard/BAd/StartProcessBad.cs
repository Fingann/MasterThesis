using System;

namespace InsecureGuard.Bad
{
    public class StartProcessBad
    {
        public string Cmd { get; set; }
        
        public StartProcessBad(string cmd)
        {
            if (cmd != "calc.exe") 
                throw new ArgumentException("Cmd is not calc.exe");
            
            Cmd = cmd;
        }
        
        public StartProcessBad()
        {
            Console.WriteLine("Default - Ctor");
        }

       
      
    }
}