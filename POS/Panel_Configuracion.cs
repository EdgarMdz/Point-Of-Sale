using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class Panel_Configuracion : Form
    {
        private PrintDialog pd;
        private PrinterTicket printer;

        public Panel_Configuracion()
        {
            this.InitializeComponent();
            printDocument1.PrintController = new StandardPrintController();
        }

        private void selectPrinterBtn_Click(object sender, EventArgs e)
        {
            this.pd = new PrintDialog();
            this.pd.PrinterSettings.PrinterName = this.printerNameLbl.Text;
            if (this.pd.ShowDialog() != DialogResult.OK)
                return;
            this.printerNameLbl.Text = this.pd.PrinterSettings.PrinterName;
            this.setTicketSize();
            this.ticketPanel.Enabled = true;
            if (this.ticketPanel.Visible)
                return;
            this.ticketPanel.Show();
        }

        private void setTicketSize()
        {
            this.ticketPanelLeft.Width = (this.ticketPanel.Width - this.pd.PrinterSettings.DefaultPageSettings.PaperSize.Width) / 2;
            this.ticketPanelRight.Width = (this.ticketPanel.Width - this.pd.PrinterSettings.DefaultPageSettings.PaperSize.Width) / 2;
            foreach (Control control in this.splitContainer1.Panel2.Controls)
                this.centerToParent(control);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivo de Imagen(*.jpg;*.jpeg;*.bmp;*.png)|*.jpg;*.jpeg;*.bmp;*.png";
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;
            this.logoPictureBox.Image = (Image)new Bitmap(openFileDialog.FileName);
            this.LogopathLbl.Text = openFileDialog.FileName;
            this.logoPictureBox.Show();
            this.splitContainer1.Panel1.Show();
            this.splitContainer1.SplitterDistance = 100;
        }

        private void centerToParent(Control control)
        {
            Control parent = control.Parent;
            control.Location = new Point((parent.Width - control.Width) / 2, control.Location.Y);
        }

        private void centerToTicket(Control control)
        {
            Control parent = control.Parent;
            control.Location = new Point((parent.Width - PrinterTicket.getStringSize(control.Text, control.Font).Width) / 2, control.Location.Y);
        }

        private void Panel_Configuracion_Load(object sender, EventArgs e)
        {
            this.printer = new PrinterTicket();
            if (!(this.printer.printerName != ""))
                return;
            this.pd = new PrintDialog();
            this.pd.PrinterSettings.PrinterName = this.printer.printerName;
            this.setTicketSize();
            this.ticketPanel.Enabled = true;
            this.ticketPanel.Show();
        }

        private void headderTxt_TextChanged(object sender, EventArgs e)
        {
            this.getFitString((Control)this.headderLbl, this.headderTxt.Text);
        }

        private void headerFontBtn_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.Font = this.headderLbl.Font;
            if (fontDialog.ShowDialog() != DialogResult.OK)
                return;
            this.headderFontTxt.Text = new FontConverter().ConvertToString((object)fontDialog.Font);
            this.headderLbl.Font = fontDialog.Font;
        }

        private void headderLbl_TextChanged(object sender, EventArgs e)
        {
            this.centerToTicket((Control)this.headderLbl);
            this.addressLbl.Location = new Point(this.addressLbl.Location.X, this.headderLbl.Location.Y + this.headderLbl.Height + 20);
        }

        private void headderTxt_Leave(object sender, EventArgs e)
        {
            if (!(this.headderTxt.Text == ""))
                return;
            this.headderTxt.Text = "Nombre del Negocio";
        }

        private void headderFontTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Return)
                return;
            try
            {
                this.headderLbl.Font = new FontConverter().ConvertFromString(this.headderFontTxt.Text) as Font;
            }
            catch (ArgumentException)
            {
                int num = (int)MessageBox.Show("Formato no válido");
                this.headderFontTxt.Text = new FontConverter().ConvertToString((object)this.headderLbl.Font);
            }
        }

        private void headderLbl_SizeChanged(object sender, EventArgs e)
        {
            if (this.pd != null)
            {
                string text = (sender as Control).Text;
                Size stringSize = PrinterTicket.getStringSize(text, (sender as Control).Font);
                int width = this.pd.PrinterSettings.DefaultPageSettings.PaperSize.Width;
                string str = "\r\n";
                for (; stringSize.Width > width; stringSize = PrinterTicket.getStringSize(text, (sender as Control).Font))
                {
                    int letterByMeasuring = PrinterTicket.getLastLetterByMeasuring(text, (sender as Control).Font, width);
                    text = text.Insert(letterByMeasuring, text[letterByMeasuring] == ' ' || text[letterByMeasuring] != ' ' && text[letterByMeasuring - 1] == ' ' ? str : "-" + str);
                }
            }
            this.addressLbl.Location = new Point(this.addressLbl.Location.X, this.headderLbl.Location.Y + this.headderLbl.Height + 20);
        }

        private void addressTxt_TextChanged(object sender, EventArgs e)
        {
            this.getFitString((Control)this.addressLbl, this.addressTxt.Text);
        }

        private void addresFontBtn_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.Font = this.addressLbl.Font;
            if (fontDialog.ShowDialog() != DialogResult.OK)
                return;
            this.addressFontTxt.Text = new FontConverter().ConvertToString((object)fontDialog.Font);
            this.addressLbl.Font = fontDialog.Font;
        }

        private void addressFontTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Return)
                return;
            try
            {
                this.addressLbl.Font = new FontConverter().ConvertFromString(this.addressFontTxt.Text) as Font;
            }
            catch (ArgumentException ex)
            {
                int num = (int)MessageBox.Show("Formato no válido");
                this.addressFontTxt.Text = new FontConverter().ConvertToString((object)this.addressLbl.Font);
            }
        }

        private void addressFontTxt_Leave(object sender, EventArgs e)
        {
            try
            {
                this.addressLbl.Font = new FontConverter().ConvertFromString(this.addressFontTxt.Text) as Font;
            }
            catch (ArgumentException ex)
            {
                int num = (int)MessageBox.Show("Formato no válido");
                this.addressFontTxt.Text = new FontConverter().ConvertToString((object)this.addressLbl.Font);
            }
        }

        private void headderFontTxt_Leave(object sender, EventArgs e)
        {
            try
            {
                this.headderLbl.Font = new FontConverter().ConvertFromString(this.headderFontTxt.Text) as Font;
            }
            catch (ArgumentException ex)
            {
                int num = (int)MessageBox.Show("Formato no válido");
                this.headderFontTxt.Text = new FontConverter().ConvertToString((object)this.headderLbl.Font);
            }
        }

        private void addressLbl_SizeChanged(object sender, EventArgs e)
        {
            if (this.pd != null)
            {
                string text = (sender as Control).Text;
                Size stringSize = PrinterTicket.getStringSize(text, (sender as Control).Font);
                int width = this.pd.PrinterSettings.DefaultPageSettings.PaperSize.Width;
                string str = "\r\n";
                for (; stringSize.Width > width; stringSize = PrinterTicket.getStringSize(text, (sender as Control).Font))
                {
                    int letterByMeasuring = PrinterTicket.getLastLetterByMeasuring(text, (sender as Control).Font, width);
                    text = text.Insert(letterByMeasuring, text[letterByMeasuring] == ' ' || text[letterByMeasuring] != ' ' && text[letterByMeasuring - 1] == ' ' ? str : "-" + str);
                }
            }
            this.phoneLbl.Location = new Point(this.phoneLbl.Location.X, this.addressLbl.Location.Y + this.addressLbl.Height + 20);
        }

        private void addressLbl_LocationChanged(object sender, EventArgs e)
        {
            this.phoneLbl.Location = new Point(this.phoneLbl.Location.X, this.addressLbl.Location.Y + this.addressLbl.Height + 20);
        }

        private void phoneTxt_TextChanged(object sender, EventArgs e)
        {
            this.getFitString((Control)this.phoneLbl, this.phoneTxt.Text);
        }

        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
        {
            if (this.phoneCheckBox.Checked)
                this.phoneLbl.Show();
            else
                this.phoneLbl.Hide();
        }

        private void phoneFontBtn_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.Font = this.phoneLbl.Font;
            if (fontDialog.ShowDialog() != DialogResult.OK)
                return;
            this.phoneFontTxt.Text = new FontConverter().ConvertToString((object)fontDialog.Font);
            this.phoneLbl.Font = fontDialog.Font;
        }

        private void phoneFontTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Return)
                return;
            try
            {
                this.phoneLbl.Font = new FontConverter().ConvertFromString(this.phoneFontTxt.Text) as Font;
            }
            catch (ArgumentException ex)
            {
                int num = (int)MessageBox.Show("Formato no válido");
                this.phoneFontTxt.Text = new FontConverter().ConvertToString((object)this.phoneLbl.Font);
            }
        }

        private void phoneFontTxt_Leave(object sender, EventArgs e)
        {
            try
            {
                this.phoneLbl.Font = new FontConverter().ConvertFromString(this.phoneFontTxt.Text) as Font;
            }
            catch (ArgumentException ex)
            {
                int num = (int)MessageBox.Show("Formato no válido");
                this.phoneFontTxt.Text = new FontConverter().ConvertToString((object)this.phoneLbl.Font);
            }
        }

        private void ticketLayout_SizeChanged(object sender, EventArgs e)
        {
            foreach (Control control in this.splitContainer1.Panel2.Controls)
                this.centerToParent(control);
            foreach (Control control in this.ticketPanelLeft.Controls)
                this.centerToParent(control);
            foreach (Control control in this.ticketPanelRight.Controls)
                this.centerToParent(control);
        }

        private void footerTxt_TextChanged(object sender, EventArgs e)
        {
            if (this.pd == null)
                return;
            this.getFitString((Control)this.footerLbl, this.footerTxt.Text);
        }

        private async void getFitString(Control control, string text)
        {
            control.Text = await Task.Run<string>((Func<string>)(() =>
            {
                string str1 = "";
                int width = this.pd.PrinterSettings.DefaultPageSettings.PaperSize.Width;
                string str2 = "\r\n";
                int length = text.IndexOf(str2) > -1 ? text.IndexOf(str2) : text.Length;
                int startIndex = 0;
                do
                {
                    string text1 = text.Substring(startIndex, length).Trim();
                    for (Size stringSize = PrinterTicket.getStringSize(text1, control.Font); stringSize.Width > width; stringSize = PrinterTicket.getStringSize(text1, control.Font))
                    {
                        int letterByMeasuring = PrinterTicket.getLastLetterByMeasuring(text1, control.Font, width);
                        text1 = text1.Insert(letterByMeasuring, text1[letterByMeasuring] == ' ' || text1[letterByMeasuring] != ' ' && text1[letterByMeasuring - 1] == ' ' ? str2 : "-" + str2);
                    }
                    str1 = str1 + text1 + str2;
                    startIndex += length + str2.Length;
                    if (startIndex >= text.Length)
                    {
                        length = -1;
                    }
                    else
                    {
                        while (text.Substring(startIndex).IndexOf(str2) > -1 && text.Substring(startIndex).IndexOf(str2) == 0)
                            startIndex += str2.Length;
                        string str3 = text.Substring(startIndex);
                        string str4 = str3.IndexOf(str2) > -1 ? str3.Substring(0, str3.IndexOf(str2)) : str3.Substring(0, str3.Length);
                        length = str4.Length > 0 ? str4.Length : -1;
                    }
                }
                while (length > -1 && length < text.Length);
                return str1.Trim();
            }));
        }

        private void footerLbl_SizeChanged(object sender, EventArgs e)
        {
            if (this.pd != null)
            {
                string text = (sender as Control).Text;
                Size stringSize = PrinterTicket.getStringSize(text, (sender as Control).Font);
                int width = this.pd.PrinterSettings.DefaultPageSettings.PaperSize.Width;
                string str = "\r\n";
                for (; stringSize.Width > width; stringSize = PrinterTicket.getStringSize(text, (sender as Control).Font))
                {
                    int letterByMeasuring = PrinterTicket.getLastLetterByMeasuring(text, (sender as Control).Font, width);
                    text = text.Insert(letterByMeasuring, text[letterByMeasuring] == ' ' || text[letterByMeasuring] != ' ' && text[letterByMeasuring - 1] == ' ' ? str : "-" + str);
                }
            }
            this.footerLbl.Location = new Point(this.footerLbl.Location.X, this.footerLbl.Parent.Height - this.footerLbl.Height - 20);
        }

        private void footerFontTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Return)
                return;
            try
            {
                this.footerLbl.Font = new FontConverter().ConvertFromString(this.footerFontTxt.Text) as Font;
            }
            catch (ArgumentException ex)
            {
                int num = (int)MessageBox.Show("Formato no válido");
                this.footerFontTxt.Text = new FontConverter().ConvertToString((object)this.footerLbl.Font);
            }
        }

        private void footerFontTxt_Leave(object sender, EventArgs e)
        {
            try
            {
                this.footerLbl.Font = new FontConverter().ConvertFromString(this.footerFontTxt.Text) as Font;
            }
            catch (ArgumentException ex)
            {
                int num = (int)MessageBox.Show("Formato no válido");
                this.footerFontTxt.Text = new FontConverter().ConvertToString((object)this.footerLbl.Font);
            }
        }

        private void footerFontBtn_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.Font = this.footerLbl.Font;
            if (fontDialog.ShowDialog() != DialogResult.OK)
                return;
            this.footerFontTxt.Text = new FontConverter().ConvertToString((object)fontDialog.Font);
            this.footerLbl.Font = fontDialog.Font;
        }

        private void bunifuCheckbox3_OnChange(object sender, EventArgs e)
        {
            if (this.footerCheckBox.Checked)
                this.footerLbl.Visible = true;
            else
                this.footerLbl.Visible = false;
        }

        private void printerPanel_SizeChanged(object sender, EventArgs e)
        {
            this.centerToParent((Control)this.selectPrinterBtn);
        }

        private void headerCheckBox_OnChange(object sender, EventArgs e)
        {
            if (this.headerCheckBox.Checked)
            {
                this.headderLbl.Show();
                this.headderLbl.Location = new Point(this.headderLbl.Location.X, 5);
            }
            else
            {
                this.headderLbl.Hide();
                this.headderLbl.Location = new Point(this.headderLbl.Location.X, 0);
            }
        }

        private void headderLbl_VisibleChanged(object sender, EventArgs e)
        {
            if (this.headderLbl.Visible)
                this.addressLbl.Location = new Point(this.addressLbl.Location.X, this.headderLbl.Location.Y + this.headderLbl.Height + 5);
            else
                this.addressLbl.Location = new Point(this.addressLbl.Location.X, this.headderLbl.Location.Y);
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            printDocument1.PrintController = new StandardPrintController();
            this.printDocument1.PrinterSettings.PrinterName = this.pd.PrinterSettings.PrinterName;
            this.pd.Document = this.printDocument1;
            this.printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            int width = (int)this.pd.PrinterSettings.DefaultPageSettings.PrintableArea.Width;
            int num = 0;
            if (this.logoPictureBox.Image != null && this.LogoCheckbox.Checked)
            {
                graphics.DrawImage(this.logoPictureBox.Image, 0, 10, width, this.logoPictureBox.Height);
                num = this.logoPictureBox.Height;
            }
            if (this.headderLbl.Visible)
                this.printer.printCentered(graphics, this.headderLbl.Location.Y + num, this.headderTxt.Text, this.headderLbl.Font, width);
            this.printer.printCentered(graphics, this.addressLbl.Location.Y + num, this.addressTxt.Text, this.addressLbl.Font, width);
            if (this.phoneLbl.Visible)
                this.printer.printCentered(graphics, this.phoneLbl.Location.Y + num, this.phoneTxt.Text, this.phoneLbl.Font, width);
            if (!this.footerLbl.Visible)
                return;
            this.printer.printCentered(graphics, this.footerLbl.Location.Y + num, this.footerTxt.Text, this.footerLbl.Font, width);
        }

        private void LogoCheckbox_OnChange(object sender, EventArgs e)
        {
            if (!this.LogoCheckbox.Checked)
            {
                this.splitContainer1.Panel1.Hide();
                this.splitContainer1.SplitterDistance = 0;
            }
            else
            {
                if (!this.LogoCheckbox.Checked || this.logoPictureBox.Image == null)
                    return;
                this.splitContainer1.Panel1.Show();
                this.splitContainer1.SplitterDistance = this.splitContainer1.SplitterDistance != 0 ? this.splitContainer1.SplitterDistance : 50;
                this.logoPictureBox.Show();
            }
        }

        private void saveSettingsBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea guradar la configuración?", "Guardar Configuración", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;
            this.printer.saveConfiguration(this.printerNameLbl.Text, this.logoPictureBox.Image, this.splitContainer1.SplitterDistance, this.LogoCheckbox.Checked, this.headderTxt.Text, this.headderLbl.Font, this.headerCheckBox.Checked, this.addressTxt.Text, this.addressLbl.Font, true, this.phoneTxt.Text, this.phoneLbl.Font, this.phoneCheckBox.Checked, this.footerTxt.Text, this.footerLbl.Font, this.footerCheckBox.Checked);
            int num = (int)MessageBox.Show("Operación exitosa.");
        }

        private void Panel_Configuracion_SizeChanged(object sender, EventArgs e)
        {
            if (!(this.printer.printerName != ""))
                return;
            this.setTicketSize();
        }

        private void addressLbl_TextChanged(object sender, EventArgs e)
        {
            this.centerToTicket((Control)this.addressLbl);
        }

        private void phoneLbl_TextChanged(object sender, EventArgs e)
        {
            this.centerToTicket((Control)this.phoneLbl);
        }

        private void footerLbl_TextChanged(object sender, EventArgs e)
        {
            this.centerToTicket((Control)this.footerLbl);
        }

        private void headderLbl_FontChanged_1(object sender, EventArgs e)
        {
            this.centerToTicket((Control)(sender as Label));
        }

        private void Panel_Configuracion_Shown(object sender, EventArgs e)
        {
            this.printerNameLbl.Text = this.printer.printerName == "" ? "..." : this.printer.printerName;
            this.headderTxt.Text = this.printer.header;
            this.headerCheckBox.Checked = this.printer.headderDisplay;
            this.headderFontTxt.Text = new FontConverter().ConvertToString((object)this.printer.headerFont);
            this.headderLbl.Font = this.printer.headerFont;
            this.headderLbl.Visible = this.printer.headderDisplay;
            this.addressTxt.Text = this.printer.address;
            this.addressFontTxt.Text = new FontConverter().ConvertToString((object)this.printer.addressFont);
            this.addressLbl.Font = this.printer.addressFont;
            this.phoneTxt.Text = this.printer.phone;
            this.phoneFontTxt.Text = new FontConverter().ConvertToString((object)this.printer.phoneFont);
            this.phoneCheckBox.Checked = this.printer.phoneDisplay;
            this.phoneLbl.Font = this.printer.phoneFont;
            this.phoneLbl.Visible = this.printer.phoneDisplay;
            this.footerTxt.Text = this.printer.footer;
            this.footerFontTxt.Text = new FontConverter().ConvertToString((object)this.printer.footerFont);
            this.footerCheckBox.Checked = this.printer.footerDisplay;
            this.footerLbl.Font = this.printer.footerFont;
            this.footerLbl.Visible = this.printer.footerDisplay;
            this.LogoCheckbox.Checked = this.printer.logoDisplay;
            this.logoPictureBox.Image = this.printer.logo != null ? this.printer.logo : (Image)null;
            if (!this.LogoCheckbox.Checked || this.logoPictureBox.Image == null || this.printer.logoHeight == 0)
            {
                this.splitContainer1.Panel1.Hide();
                this.splitContainer1.SplitterDistance = 0;
            }
            else
            {
                if (!this.LogoCheckbox.Checked || this.printer.logo == null)
                    return;
                this.logoPictureBox.Image = this.printer.logo;
                this.splitContainer1.SplitterDistance = this.printer.logoHeight;
                this.logoPictureBox.Visible = true;
            }
        }

        private void phoneLbl_SizeChanged(object sender, EventArgs e)
        {
            if (this.pd == null)
                return;
            string text = (sender as Control).Text;
            Size stringSize = PrinterTicket.getStringSize(text, (sender as Control).Font);
            int width = this.pd.PrinterSettings.DefaultPageSettings.PaperSize.Width;
            string str = "\r\n";
            for (; stringSize.Width > width; stringSize = PrinterTicket.getStringSize(text, (sender as Control).Font))
            {
                int letterByMeasuring = PrinterTicket.getLastLetterByMeasuring(text, (sender as Control).Font, width);
                text = text.Insert(letterByMeasuring, text[letterByMeasuring] == ' ' || text[letterByMeasuring] != ' ' && text[letterByMeasuring - 1] == ' ' ? str : "-" + str);
            }
        }
    }
}
