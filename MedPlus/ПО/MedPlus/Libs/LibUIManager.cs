using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MedPlus.Libs
{
    /// <summary>
    /// Класс для обеспечения доступа к общим графическим элементам.
    /// </summary>
    public static class LibUIManager
    {
        /// <summary>
        /// Свойство. Заголовок на главном окне.
        /// </summary>
        public static Label LabHeader { get; set; }

        /// <summary>
        /// Свойство. Контейнер для страниц на главном окне.
        /// </summary>
        public static Frame FrMain { get; set; }
    }
}
