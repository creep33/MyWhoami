using System;
using System.Runtime.InteropServices;

namespace mywhoami
{
    internal class Program
    {
        [DllImport("secur32.dll", CharSet = CharSet.Auto)]
        public static extern int GetUserNameEx(int nameFormat, char[] userName, ref int userNameSize);

        static void Main(string[] args)
        {
            char[] userName = new char[1024];
            int userNameSize = userName.Length;
            GetUserNameEx(2, userName, ref userNameSize);
            Console.WriteLine(userName);
        }
    }
}