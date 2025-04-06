using System;

namespace HelloLibrary
{
    public class HelloHelper
    {
        public static string GetHello (string userName) {
            string output = $"Hello, {userName}";
            return output;          

        }      
    }
}
