using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class PanelProveedoresNuevoRecordatorio : Form
    {
        public bool[] repetingDays;
        private bool userIsAdmin;

        public Color color { get; set; }

        public DateTime date { get; set; }

        public int time { get; set; }

        public bool HalfHour { get; set; }

        public DateTime endDate { get; set; }

        public int endtime { get; set; }

        public bool EndTimeHalfHour { get; set; }

        public int SupplierID { get; set; }

        public int reminderID { get; set; }

        public string headerTitle { get; set; }

        public string eventName { get; set; }

        private bool CanErase { get; set; }

        public PanelProveedoresNuevoRecordatorio(
          Color c,
          bool canErase,
          bool UserisAdmin,
          bool showClosingButton = true)
        {
            this.InitializeComponent();
            this.color = c;
            this.ShowInTaskbar = false;
            this.endtime = -1;
            this.reminderID = -1;
            this.repetingDays = new bool[7];
            this.CanErase = canErase;
            this.closeBtn.Visible = showClosingButton;
            this.userIsAdmin = UserisAdmin;
            if (UserisAdmin)
                return;
            this.DeleteButton.Enabled = false;
            this.EventNameTxt.Enabled = false;
            this.dateTimePicker.Visible = false;
            this.StartTimeCombo.Enabled = false;
            this.EndTimeCombo.Enabled = false;
            this.OKBtn.Visible = false;
        }

        public PanelProveedoresNuevoRecordatorio(
          Color color,
          int time,
          int SupplierID,
          bool canDelete,
          DateTime selectedDayinCalendar,
          string HeaderTittle,
          bool showClosingButton = true)
        {
            this.InitializeComponent();
            this.color = color;
            this.time = time;
            this.SupplierID = SupplierID;
            this.date = selectedDayinCalendar;
            this.headerTitle = HeaderTittle;
            this.CanErase = canDelete;
            this.ShowInTaskbar = false;
            this.closeBtn.Visible = showClosingButton;
            this.endtime = -1;
            this.reminderID = -1;
            this.repetingDays = new bool[7];
        }

        private void PanelProveedoresNuevoRecordatorio_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Gray);
            pen.Width = 3f;
            e.Graphics.DrawRectangle(pen, 0.0f, 0.0f, (float)this.Width - pen.Width / 2f, (float)this.Height - pen.Width / 2f);
        }

        private void HeaderTitlePanel_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Gray);
            pen.Width = 3f;
            e.Graphics.DrawLine(pen, 0.0f, 0.0f, (float)this.Width - pen.Width / 2f, 0.0f);
            e.Graphics.DrawLine(pen, 0.0f, 0.0f, 0.0f, (float)this.Height - pen.Width / 2f);
            e.Graphics.DrawLine(pen, (float)this.Width - pen.Width / 2f, 0.0f, (float)this.Width - pen.Width / 2f, (float)this.Height - pen.Width / 2f);
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PanelProveedoresNuevoRecordatorio_Load(object sender, EventArgs e)
        {
            this.label1.Text = this.headerTitle;
            this.HeaderTitlePanel.GradientTopLeft = this.color;
            this.HeaderTitlePanel.GradientTopRight = this.color;
            Bitmap bitmap = new Bitmap(this.HeaderTitlePanel.Width, this.HeaderTitlePanel.Height);
            this.HeaderTitlePanel.DrawToBitmap(bitmap, new Rectangle(0, 0, this.HeaderTitlePanel.Width, this.HeaderTitlePanel.Height));
            int red = 0;
            int green = 0;
            int blue = 0;
            for (int y = 0; y < bitmap.Height; ++y)
            {
                Color pixel = bitmap.GetPixel(10, y);
                red += (int)pixel.R / bitmap.Height;
                green += (int)pixel.G / bitmap.Height;
                blue += (int)pixel.B / bitmap.Height;
            }
            this.color = Color.FromArgb(red, green, blue);
            this.OKBtn.ForeColor = this.color;
            this.OKBtn.IdleForecolor = this.color;
            this.OKBtn.IdleLineColor = this.color;
            this.OKBtn.ActiveFillColor = this.color;
            this.OKBtn.ActiveLineColor = this.color;
            this.dateTimePicker.Value = this.date;
            if (!this.repetingDays[0])
                this.SundayLabel.ForeColor = Color.DimGray;
            else
                this.SundayLabel.ForeColor = Color.Tomato;
            if (!this.repetingDays[1])
                this.MondayLabel.ForeColor = Color.DimGray;
            else
                this.MondayLabel.ForeColor = Color.Tomato;
            if (!this.repetingDays[2])
                this.TuesdayLabel.ForeColor = Color.DimGray;
            else
                this.TuesdayLabel.ForeColor = Color.Tomato;
            if (!this.repetingDays[3])
                this.WednesdayLabel.ForeColor = Color.DimGray;
            else
                this.WednesdayLabel.ForeColor = Color.Tomato;
            if (!this.repetingDays[4])
                this.ThursdayLabel.ForeColor = Color.DimGray;
            else
                this.ThursdayLabel.ForeColor = Color.Tomato;
            if (!this.repetingDays[5])
                this.FridayLabel.ForeColor = Color.DimGray;
            else
                this.FridayLabel.ForeColor = Color.Tomato;
            if (!this.repetingDays[6])
                this.SaturdayLabel.ForeColor = Color.DimGray;
            else
                this.SaturdayLabel.ForeColor = Color.Tomato;
            this.fillcombo(this.StartTimeCombo, 0);
            if (!this.HalfHour)
                this.StartTimeCombo.SelectedIndex = this.time * 2;
            else
                this.StartTimeCombo.SelectedIndex = this.time * 2 + 1;
            if (this.endtime > -1)
            {
                for (int index = 0; index < this.EndTimeCombo.Items.Count; ++index)
                {
                    this.EndTimeCombo.SelectedIndex = index;
                    string itemText = this.EndTimeCombo.GetItemText(this.EndTimeCombo.SelectedItem);
                    int num1;
                    if (itemText.IndexOf("P.M.") > 0)
                    {
                        num1 = int.Parse(itemText.Substring(0, itemText.IndexOf(":")));
                        if (num1 != 12)
                            num1 += 12;
                    }
                    else
                    {
                        num1 = int.Parse(itemText.Substring(0, itemText.IndexOf(":")));
                        if (num1 == 12)
                            num1 = 0;
                    }
                    int num2 = int.Parse(itemText.Substring(itemText.IndexOf(":") + 1, 2));
                    if (this.endDate.Hour == num1 && num2 == this.endDate.Minute)
                        break;
                }
                if (this.CanErase)
                    this.DeleteButton.Show();
            }
            this.EventNameTxt.Text = this.eventName;
        }

        private ComboBox fillcombo(ComboBox combo, int StartingTime)
        {
            int num = StartingTime * 2;
            combo.Items.Clear();
            while (num < 48)
            {
                if (StartingTime > 12)
                    StartingTime -= 12;
                if (StartingTime == 0)
                    StartingTime = 12;
                if (num < 24)
                {
                    if (num % 2 == 0)
                    {
                        combo.Items.Add((object)(StartingTime.ToString() + ":00 A.M."));
                    }
                    else
                    {
                        combo.Items.Add((object)(StartingTime.ToString() + ":30 A.M."));
                        ++StartingTime;
                    }
                }
                else if (num % 2 == 0)
                {
                    combo.Items.Add((object)(StartingTime.ToString() + ":00 P.M."));
                }
                else
                {
                    combo.Items.Add((object)(StartingTime.ToString() + ":30 P.M."));
                    ++StartingTime;
                }
                ++num;
                if (StartingTime == 13 && num > 2)
                    StartingTime = 1;
            }
            return combo;
        }

        private void SundayLabel_Click(object sender, EventArgs e)
        {
            if (!this.userIsAdmin)
                return;
            if (!this.repetingDays[0])
            {
                this.repetingDays[0] = true;
                this.SundayLabel.ForeColor = Color.Tomato;
            }
            else
            {
                this.repetingDays[0] = false;
                this.SundayLabel.ForeColor = Color.DimGray;
            }
        }

        private void MondayLabel_Click(object sender, EventArgs e)
        {
            if (!this.userIsAdmin)
                return;
            if (!this.repetingDays[1])
            {
                this.repetingDays[1] = true;
                this.MondayLabel.ForeColor = Color.Tomato;
            }
            else
            {
                this.repetingDays[1] = false;
                this.MondayLabel.ForeColor = Color.DimGray;
            }
        }

        private void TuesdayLabel_Click(object sender, EventArgs e)
        {
            if (!this.userIsAdmin)
                return;
            if (!this.repetingDays[2])
            {
                this.repetingDays[2] = true;
                this.TuesdayLabel.ForeColor = Color.Tomato;
            }
            else
            {
                this.repetingDays[2] = false;
                this.TuesdayLabel.ForeColor = Color.DimGray;
            }
        }

        private void WednesdayLabel_Click(object sender, EventArgs e)
        {
            if (!this.userIsAdmin)
                return;
            if (!this.repetingDays[3])
            {
                this.repetingDays[3] = true;
                this.WednesdayLabel.ForeColor = Color.Tomato;
            }
            else
            {
                this.repetingDays[3] = false;
                this.WednesdayLabel.ForeColor = Color.DimGray;
            }
        }

        private void ThursdayLabel_Click(object sender, EventArgs e)
        {
            if (!this.userIsAdmin)
                return;
            if (!this.repetingDays[4])
            {
                this.repetingDays[4] = true;
                this.ThursdayLabel.ForeColor = Color.Tomato;
            }
            else
            {
                this.repetingDays[4] = false;
                this.ThursdayLabel.ForeColor = Color.DimGray;
            }
        }

        private void FridayLabel_Click(object sender, EventArgs e)
        {
            if (!this.userIsAdmin)
                return;
            if (!this.repetingDays[5])
            {
                this.repetingDays[5] = true;
                this.FridayLabel.ForeColor = Color.Tomato;
            }
            else
            {
                this.repetingDays[5] = false;
                this.FridayLabel.ForeColor = Color.DimGray;
            }
        }

        private void SaturdayLabel_Click(object sender, EventArgs e)
        {
            if (!this.userIsAdmin)
                return;
            if (!this.repetingDays[6])
            {
                this.repetingDays[6] = true;
                this.SaturdayLabel.ForeColor = Color.Tomato;
            }
            else
            {
                this.repetingDays[6] = false;
                this.SaturdayLabel.ForeColor = Color.DimGray;
            }
        }

        private void StartTimeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.time = (sender as ComboBox).SelectedIndex / 2;
            this.fillcombo(this.EndTimeCombo, this.time);
            this.EndTimeCombo.Items.RemoveAt(0);
            if (this.StartTimeCombo.SelectedIndex % 2 != 0)
                this.EndTimeCombo.Items.RemoveAt(0);
            this.EndTimeCombo.Items.Add((object)"12:00 A.M.");
            this.EndTimeCombo.SelectedIndex = 0;
        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            this.AddReminderToDataBase();
        }

        private void AddReminderToDataBase()
        {
            if (this.reminderID == -1)
            {
                Recordatorio reminder = new Recordatorio();
                reminder.ID_Supplier = this.SupplierID;
                this.fillReminder(reminder);
                try
                {
                    reminder.addReminder();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    int num = (int)MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                Recordatorio reminder = new Recordatorio();
                reminder.ID_Supplier = this.SupplierID;
                reminder.ID = this.reminderID;
                this.fillReminder(reminder);
                try
                {
                    reminder.UpdateReminder();
                    this.DialogResult = DialogResult.OK;
                    if (!this.CanErase)
                    {
                        Proveedor proveedor = new Proveedor();
                        proveedor.ID = this.SupplierID;
                        proveedor.GetSupplierData();
                        proveedor.diasVisita = this.repetingDays;
                        proveedor.UpdateVisitingDays();
                    }
                    this.Close();
                }
                catch (Exception ex)
                {
                    int num = (int)MessageBox.Show(ex.ToString());
                }
            }
        }

        private void fillReminder(Recordatorio reminder)
        {
            int minute1 = this.StartTimeCombo.SelectedIndex % 2 != 0 ? 30 : 0;
            this.date = this.dateTimePicker.Value;
            reminder.StartTime = new DateTime(this.date.Year, this.date.Month, this.date.Day, this.StartTimeCombo.SelectedIndex / 2, minute1, 0);
            int minute2 = int.Parse(this.EndTimeCombo.Text.Substring(this.EndTimeCombo.Text.IndexOf(':') + 1, 2));
            int hour = int.Parse(this.EndTimeCombo.Text.Substring(0, this.EndTimeCombo.Text.IndexOf(':')));
            if (this.EndTimeCombo.Text.IndexOf("P.M.") > 0)
            {
                if (hour != 12)
                    hour += 12;
                else if (hour == 24)
                    hour = 0;
            }
            else if (hour == 12)
                hour = 0;
            reminder.EndTime = new DateTime(this.date.Year, this.date.Month, this.date.Day, hour, minute2, 0);
            if (reminder.EndTime.Hour == 0 && reminder.EndTime.Minute == 0)
                reminder.EndTime = reminder.EndTime.AddDays(1.0);
            reminder.RepeatingDays = this.repetingDays;
            reminder.Message = this.EventNameTxt.Text;
            reminder.RepeatingDays = this.repetingDays;
            reminder.Message = this.EventNameTxt.Text;
            reminder.Erasable = this.CanErase;
        }

        private void OKBtn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape && this.CanErase)
                this.Close();
            if (e.KeyCode != Keys.Return)
                return;
            this.AddReminderToDataBase();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea borrar este recordatorio?", "", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;
            Recordatorio recordatorio = new Recordatorio();
            recordatorio.ID_Supplier = this.SupplierID;
            recordatorio.ID = this.reminderID;
            try
            {
                recordatorio.delete();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show("No se pudo eliminar el recordatorio.\n Eroor: " + ex.ToString(), "Error");
            }
        }

    }
}
