using UnityExample.Persistence;

namespace UnityExample.Services {
    public class ConsoleService : IConsoleService{
        private readonly IConsoleDao _consoleDao;
        private readonly string _suffix;

        /// <summary>Initialisiert eine neue Instanz der <see cref="T:System.Object" />-Klasse.</summary>
        public ConsoleService(string suffix, IConsoleDao consoleDao) {
            _consoleDao = consoleDao;
            _suffix = suffix;
        }

        public void Write(string text) {
            _consoleDao.Write(_suffix + text);
        }
    }
}