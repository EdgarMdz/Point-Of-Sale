using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace POS
{
    class Recordatorio
    {
        private Capa_de_Negocio negocio;

        public int ID_Supplier { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public int Duration { get; set; }

        public bool[] RepeatingDays { get; set; }

        public int ID { get; set; }

        public string Message { get; set; }

        public bool Erasable { get; set; }

        public Recordatorio(int id)
        {
            this.negocio = new Capa_de_Negocio();
            this.initialize(id);
        }

        private void initialize(int id)
        {
            DataTable dataTable = this.negocio.Reminder_initialize(id);
            if (dataTable.Rows.Count != 1)
                return;
            DataRow row = dataTable.Rows[0];
            this.ID = id;
            this.ID_Supplier = Convert.ToInt32(row["id_proveedor"]);
            this.StartTime = this.getTime(Convert.ToDateTime(row["Fecha de Inicio"]), TimeSpan.Parse(row["Hora de Inicio"].ToString()));
            this.EndTime = this.getTime(Convert.ToDateTime(row["Fecha de Fin"]), TimeSpan.Parse(row["Hora de Fin"].ToString()));
            this.Duration = this.EndTime.AddDays(-1.0) == this.StartTime ? 24 : (this.EndTime - this.StartTime).Hours;
            this.RepeatingDays = new bool[7];
            int index = 0;
            foreach (char ch in row["Repetir en Dias"].ToString())
            {
                this.RepeatingDays[index] = ch != '0';
                ++index;
            }
            this.Message = row["Mensaje"].ToString();
            this.Erasable = Convert.ToBoolean(row["Borrable"]);
        }

        private DateTime getTime(DateTime date, TimeSpan time)
        {
            return date.Add(time);
        }

        public Recordatorio()
        {
            this.ID_Supplier = -1;
            this.RepeatingDays = new bool[7];
            this.negocio = new Capa_de_Negocio();
            this.Erasable = true;
        }

        public DataTable getReminder(DateTime date)
        {
            return this.negocio.getReminders(this.ID_Supplier, date);
        }

        public void getVisitingReminder()
        {/*
            DataTable visitingReminder = this.negocio.getVisitingReminder(this.ID_Supplier);
            this.ID = int.Parse(visitingReminder.Rows[0]["ID_Recordatorio"].ToString());
            this.Message = visitingReminder.Rows[0]["Mensaje"].ToString();
            this.Erasable = Convert.ToBoolean(visitingReminder.Rows[0]["Borrable"].ToString());
            this.StartTime = Convert.ToDateTime(visitingReminder.Rows[0]["Fecha de Inicio"].ToString().Substring(0, 10) + " " + visitingReminder.Rows[0]["Hora de Inicio"].ToString());
            this.EndTime = Convert.ToDateTime(visitingReminder.Rows[0]["Fecha de Fin"].ToString().Substring(0, 10) + " " + visitingReminder.Rows[0]["Hora de Fin"].ToString());
            TimeSpan timeSpan = this.EndTime - this.StartTime;
            this.Duration = timeSpan.Hours;
            if (timeSpan.Days > 0)
                this.Duration = 24;
            else if (this.EndTime.Minute > 0 && this.EndTime.Minute < 60)
                ++this.Duration;
            else if (timeSpan.Minutes > 0 && timeSpan.Minutes < 60)
                ++this.Duration;
            for (int index = 0; index < 7; ++index)
                this.RepeatingDays[index] = visitingReminder.Rows[0]["Repetir en Dias"].ToString()[index] == '1';*/
        }

        public void addReminder()
        {
            this.negocio.addReminder(this.ID_Supplier, this.StartTime, this.EndTime, this.RepeatingDays, this.Message, this.Erasable);
        }

        public void UpdateReminder()
        {
            this.negocio.UpdateReminder(this.ID_Supplier, this.ID, this.StartTime, this.EndTime, this.RepeatingDays, this.Message);
        }

        public void delete()
        {
            this.negocio.deleteReminder(this.ID);
        }

        public static int[] getReminderIDsForDate(DateTime date)
        {
            return new Capa_de_Negocio().Reminder_getReminderIDsForDate(date);
        }

        public static void resetReminders()
        {
            new Capa_de_Negocio().Reminder_reset();
        }

        public static DataTable getUnseenReminders()
        {
            return new Capa_de_Negocio().Reminder_getUnseenReminders();
        }

        public void MarkAsSeen()
        {
            this.negocio.reminder_MarkAsSeen(this.ID);
        }
    }
}
