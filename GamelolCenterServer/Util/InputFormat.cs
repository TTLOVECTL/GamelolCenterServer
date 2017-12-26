using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamelolCenterServer.Util
{
    public class InputFormat
    {
        public static void ConsoleWriteLineMessage(string targetName,string message)
        {
            Console.Write("[" + targetName + "]");
            Console.Write("[" + message + "]");
            Console.WriteLine();
        }

        public static void ConsoleWriteLineNum(object message) {
            Console.Write("[行数："+GetLineNum().ToString()+"]");
            Console.Write("[" + message + "]");
            Console.WriteLine();
        }

        public static void ConsoleWriteFileName(object message) {
            Console.Write("[文件名："+GetCurSourceFileName()+"]");
            Console.Write("[" + message + "]");
            Console.WriteLine();
        }

        public static void ConsloneWriteAll(object message) {
            Console.Write("[文件名：" + GetCurSourceFileName() + "]");
            Console.Write("[行数：" + GetLineNum().ToString() + "]");
            Console.Write("[" + message + "]");
            Console.WriteLine();
        }

        private static int GetLineNum()
        {
            System.Diagnostics.StackTrace st = new System.Diagnostics.StackTrace(1, true);
            return st.GetFrame(0).GetFileLineNumber();
        }

        /// <summary>
        /// 取当前源码的源文件名
        /// </summary>
        /// <returns></returns>
        private static  string GetCurSourceFileName()
        {
            System.Diagnostics.StackTrace st = new System.Diagnostics.StackTrace(1, true);

            return st.GetFrame(0).GetFileName();

        }
    }
}
