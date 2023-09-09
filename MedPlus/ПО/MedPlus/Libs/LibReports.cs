using MedPlus.Data.DataBaseModel;
using MedPlus.Libs.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedPlus.Libs.Entities
{
    /// <summary>
    /// Статический класс. Возвращает отчёты.
    /// </summary>
    public static class LibReports
    {
        /// <summary>
        /// Статический метод. Возвращает сигнальную ведомость за укзанный день
        /// </summary>
        /// <param name="date">День отчёта</param>
        /// <returns>Список записей</returns>
        public static List<Sp_SignalStatement_Result> GetSignalStatement(DateTime date)
        {
            System.Data.SqlClient.SqlParameter param = new System.Data.SqlClient.SqlParameter("@day", date.ToString());
            return LibDB.GetContext().Database.SqlQuery<Sp_SignalStatement_Result>("EXEC Sp_SignalStatement @date = @day;", param).ToList();
        }

        /// <summary>
        /// Статический метод. Возвращает отчёт поступивших за указанный период.
        /// </summary>
        /// <param name="dateBegin">Начало периода</param>
        /// <param name="dateEnd">Конец периода</param>
        /// <returns>Список записей</returns>
        public static List<Sp_ListOfAddmited_Result> GetListOfAddmited(DateTime dateBegin, DateTime dateEnd)
        {
            System.Data.SqlClient.SqlParameter parameter1 = new System.Data.SqlClient.SqlParameter("@dBegin", dateBegin.ToString());
            System.Data.SqlClient.SqlParameter parameter2 = new System.Data.SqlClient.SqlParameter("@dEnd", dateEnd.ToString());

            return LibDB.GetContext().Database.SqlQuery<Sp_ListOfAddmited_Result>("EXEC Sp_ListOfAddmited @dateBegin = @dBegin, @dateEnd = @dEnd;", parameter1, parameter2).ToList();
        }
    }
}
