using System;

namespace HelloLibrary
{
    public class HelloHelper
    {
        public static string GetHello(string userName)
        {
            string currentTime = DateTime.Now.ToString("HH:mm:ss");
            string output = $"{currentTime} Hello, {userName}!";
            return output;
        }
    }
}
