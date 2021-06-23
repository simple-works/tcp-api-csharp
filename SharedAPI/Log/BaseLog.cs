using System;
using System.IO;
using System.Text;

namespace SharedAPI
{
    public class BaseLog
    {
        public static void New(string title = "Untitled", int standardInputBufferSize = 8192)
        {
            Console.Title = title;
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.SetIn(new StreamReader(Console.OpenStandardInput(standardInputBufferSize)));
            Console.Clear();
        }

        public static void Header(object value, string unit = "=", int length = 50)
        {
            string line = "";
            for (int i = 0; i < length; i++) line += unit;
            Console.WriteLine(line);
            Console.WriteLine(value);
            Console.WriteLine(line);
        }

        public static void LineBreak()
        {
            Console.WriteLine();
        }

        public static void Line(string unit = "-", int length = 50)
        {
            string line = "";
            for (int i = 0; i < length; i++) line += unit;
            Console.WriteLine(line);
        }

        public static void Clear()
        {
            Console.Clear();
        }

        public static void ClearLine()
        {
            int cursorPosition = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, cursorPosition);
        }

        public static void SetCursorToNextLine(int column = 0)
        {
            if (Console.CursorTop < Console.BufferHeight
                && column >= 0 && column <= Console.BufferWidth)
                Console.SetCursorPosition(column, Console.CursorTop + 1);
        }

        public static void SetCursorToPreviousLine(int column = 0)
        {
            if (Console.CursorTop >= 1 && column >= 0 && column <= Console.BufferWidth)
                Console.SetCursorPosition(column, Console.CursorTop - 1);
        }

        public static string ReadLine()
        {
            return Console.ReadLine();
        }

        public static ConsoleKeyInfo ReadKey(bool intercept = false)
        {
            return Console.ReadKey(intercept);
        }

        public static void Write(object value, bool line, params object[] arg)
        {
            if (line)
            {
                if (arg == null) Console.WriteLine(value.ToString());
                else Console.WriteLine(value.ToString(), arg);
            }
            else
            {
                if (arg == null) Console.Write(value.ToString());
                else Console.Write(value.ToString(), arg);
            }
        }

        public static void WriteWithColor(object value, bool line, ConsoleColor color, params object[] arg)
        {
            Console.ForegroundColor = color;
            Write(value, line, arg);
            Console.ResetColor();
        }

        public static void WriteLine(object value, params object[] arg)
        {
            Write(value, true, arg);
        }

        public static void WriteLineWithColor(object value, ConsoleColor color, params object[] arg)
        {
            WriteWithColor(value, true, color, arg);
        }
    }
}
