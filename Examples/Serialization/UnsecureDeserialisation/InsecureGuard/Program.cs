using System;
using Common;
using InsecureGuard.Bad;
using Newtonsoft.Json;

namespace InsecureGuard
{
    class Program
    {
        static void Main(string[] args)
        {
            var notAdminUsername = new StartProcessBad("calc.exe");
            Console.WriteLine(notAdminUsername.Cmd);
            
            var json = UnsecureSerializer<StartProcessBad>.Serialize(notAdminUsername);
            
            var tamperedJson = json.Replace("calc.exe", "Virus.exe");
            
            var adminUsername = UnsecureSerializer<StartProcessBad>.Deserialize(tamperedJson);
            Console.WriteLine(adminUsername.Cmd);


            Console.ReadLine();
        }
    }
}