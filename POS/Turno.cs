using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS
{
    class Turno
    {
        public static bool isFirsUsageDateSet
        {
            get
            {
                return new Capa_de_Negocio().IsFirstUsageDateSet();
            }
        }

        public static bool shiftActive
        {
            get
            {
                return new Capa_de_Negocio().Shift_isActive();
            }
        }

        public static DateTime startingDate
        {
            get
            {
                return new Capa_de_Negocio().Shift_getStartingDate();
            }
        }

        public static DataTable MoneyAddedToDrawer()
        {
            return new Capa_de_Negocio().shift_getMoneyAddedToDrawer();
        }

        public static void start(DateTime startTime, Decimal initialCash, int employeeID)
        {
            new Capa_de_Negocio().Shift_start(startTime, initialCash, employeeID);
        }

        public static DataTable endShift(int employee_id)
        {
            return new Capa_de_Negocio().Shift_End(employee_id);
        }

        public static void AddCashToDrawer(int employeeID, double cash)
        {
            new Capa_de_Negocio().shift_AddCashToDrawer(employeeID, cash);
        }

        public static void SetFirsUsage(DateTime time)
        {
            new Capa_de_Negocio().FirsUsage(time);
        }
    }
}
