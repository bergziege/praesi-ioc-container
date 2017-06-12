using UnityExample.Persistence;

namespace UnityExample.Services {
    public class ConsoleService : IConsoleService{
        private readonly IConsoleDao _consoleDao;

        /// <summary>Initialisiert eine neue Instanz der <see cref="T:System.Object" />-Klasse.</summary>
        public ConsoleService(IConsoleDao consoleDao) {
            _consoleDao = consoleDao;
        }

        public void Write(string text) {
            _consoleDao.Write(text);
        }
    }
}