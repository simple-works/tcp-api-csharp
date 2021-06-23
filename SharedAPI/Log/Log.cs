using System;

namespace SharedAPI
{
    public class Log : BaseLog
    {
        public static string Prompt(object value, params object[] arg)
        {
            string format = (value == null) ? "@ ► " : string.Format("{0} ► ", value);
            Write(format, false, arg);
            return ReadLine();
        }

        public static string Prompt(object value = null)
        {
            return Prompt(value, null);
        }

        public static void Note(object value, params object[] arg)
        {
            WriteLine(value, arg);
        }
        public static void Note(object value)
        {
            WriteLine(value);
        }

        public static void Info(object value, params object[] arg)
        {
            WriteLineWithColor(value, ConsoleColor.Cyan, arg);
        }

        public static void Info(object value)
        {
            WriteLineWithColor(value, ConsoleColor.Cyan, null);
        }

        public static void Warning(object value, params object[] arg)
        {
            WriteLineWithColor(value, ConsoleColor.Yellow, arg);
        }

        public static void Warning(object value)
        {
            WriteLineWithColor(value, ConsoleColor.Yellow, null);
        }

        public static void Error(object value, params object[] arg)
        {
            WriteLineWithColor(value, ConsoleColor.Red, arg);
        }

        public static void Error(object value)
        {
            WriteLineWithColor(value, ConsoleColor.Red, null);
        }

        public static void Exception(Exception exception, bool full = false)
        {
            WriteLineWithColor("Exception: {0}", ConsoleColor.Red, exception.Message);
            if (full) WriteLineWithColor(exception, ConsoleColor.Red);
            ReadKey(true);
            Clear();
        }

        public static void Success(object value, params object[] arg)
        {
            WriteLineWithColor(value, ConsoleColor.Green, arg);
        }
        public static void Success(object value)
        {
            WriteLineWithColor(value, ConsoleColor.Green, null);
        }
    }
}
