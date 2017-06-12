using System;

namespace UnityExample.Persistence {
    public class ConsoleDao: IConsoleDao {
        public void Write(string text) {
            Console.WriteLine(text);
        }
    }
}