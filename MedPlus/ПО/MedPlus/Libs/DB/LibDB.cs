using MedPlus.Data.DataBaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedPlus.Libs.DB
{
    /// <summary>
    /// Статический класс для работы с базой данных MedPlusDB
    /// </summary>
    public static class LibDB
    {
        /// <summary>
        /// Статическое свойство. Хранит переменную текушего контекста БД
        /// </summary>
        private static MedPlusDB_Entities _context;

        // <summary>
        /// Статическое свойство. Возвращает переменную контекста БД
        /// </summary>
        public static MedPlusDB_Entities GetContext()
        {
            if (_context == null)
                _context = new MedPlusDB_Entities();
            return _context;
        }
    }
}
