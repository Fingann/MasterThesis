using System;

namespace InsecureGuard.Bad
{
    public class StartProcess
    {
        public string Cmd { get; set; }
        
        public StartProcess(string cmd)
        {
            if (cmd != "calc.exe") 
                throw new ArgumentException("Cmd is not calc.exe");
            
            Cmd = cmd;
        }
        
        public StartProcess()
        {
            Console.WriteLine("Default - Ctor");
        }

        public void Start()
        {
            Console.WriteLine("Starting process: "+ Cmd);
        }

       
      
    }
}