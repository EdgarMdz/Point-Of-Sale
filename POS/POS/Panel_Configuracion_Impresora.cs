using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class Panel_Configuracion_Impresora : Form
    {
        private PrintDialog pd;
        private PrinterTicket printer;
        Font headerFont;
        Font addressFont;
        Font phoneFont;
        Font footerFont;
        bool isPreview;

        public Panel_Configuracion_Impresora()
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
            //this.setTicketSize();
            this.ticketPanel.Enabled = true;

            printDocument1.PrinterSettings.PrinterName = pd.PrinterSettings.PrinterName;
            printPreviewControl1.Document = printDocument1;

            setzoom();

            if (this.ticketPanel.Visible)
                return;
            this.ticketPanel.Show();

        }

        private void setzoom()
        {
            var value = (double)(printPreviewControl1.Width - 20) / pd.PrinterSettings.DefaultPageSettings.PaperSize.Width;

            printPreviewControl1.Zoom = value >= 1 ? 1 : value;
        }

        private void setTicketSize()
        {
            if (pd != null && printerExist(pd.PrinterSettings.PrinterName))
            {
                this.ticketPanelLeft.Width = (this.ticketPanel.Width - this.pd.PrinterSettings.DefaultPageSettings.PaperSize.Width) / 2;
                this.ticketPanelRight.Width = (this.ticketPanel.Width - this.pd.PrinterSettings.DefaultPageSettings.PaperSize.Width) / 2;
                foreach (Control control in this.splitContainer1.Panel2.Controls)
                    this.centerToParent(control);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivo de Imagen(*.jpg;*.jpeg;*.bmp;*.png)|*.jpg;*.jpeg;*.bmp;*.png";
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;
            this.logoPictureBox.Image = (Image)new Bitmap(openFileDialog.FileName);
            this.LogopathLbl.Text = openFileDialog.FileName;
                        
            logoHeight.Value = 100;

            restartTimer();

            openFileDialog.Dispose();
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
            if ( printer.printerName == ""||!printerExist(printer.printerName))
                return;
            this.pd = new PrintDialog();
            this.pd.PrinterSettings.PrinterName = this.printer.printerName;

            setzoom();
            //this.setTicketSize();
            this.ticketPanel.Enabled = true;
            this.ticketPanel.Show();
        }

        private bool printerExist(string name = "")
        {
            if (name != null)
            {
                name = name.ToLower();
                foreach (string item in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
                {
                    if (name == item.ToLower())
                        return true;
                }
                this.printer.saveConfiguration("", printer.logo, printer.logoHeight, printer.logoDisplay,
                    printer.header, printer.headerFont, printer.headderDisplay,
                    printer.address, printer.addressFont, true,
                    printer.phone, printer.phoneFont, printer.phoneDisplay,
                    printer.footer, printer.footerFont, printer.footerDisplay);

                return false;
            }

            else return false;
        }

        void restartTimer()
        {
            timer1.Stop();
            timer1.Start();
        }

        private void headderTxt_TextChanged(object sender, EventArgs e)
        {
            if(headerCheckBox.Checked)
            restartTimer();
        }

        private void headerFontBtn_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.Font = headerFont;
            if (fontDialog.ShowDialog() != DialogResult.OK)
                return;
            this.headderFontTxt.Text = new FontConverter().ConvertToString(fontDialog.Font);
            headerFont = fontDialog.Font;
            
            if (headerCheckBox.Checked)
                restartTimer();

            fontDialog.Dispose();
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
                headerFont = new FontConverter().ConvertFromString(this.headderFontTxt.Text) as Font;
                restartTimer();
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Formato no válido");
                this.headderFontTxt.Text = new FontConverter().ConvertToString(headerFont);
            }
        }

        private void addressTxt_TextChanged(object sender, EventArgs e)
        {
            restartTimer();
        }

        private void addresFontBtn_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.Font = addressFont;
            if (fontDialog.ShowDialog() != DialogResult.OK)
                return;
            this.addressFontTxt.Text = new FontConverter().ConvertToString(fontDialog.Font);
            addressFont = fontDialog.Font;
            restartTimer();
            fontDialog.Dispose();
        }

        private void addressFontTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Return)
                return;
            try
            {
                addressFont = new FontConverter().ConvertFromString(this.addressFontTxt.Text) as Font;
                restartTimer();
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Formato no válido");
                this.addressFontTxt.Text = new FontConverter().ConvertToString((addressFont));
            }
        }

        private void addressFontTxt_Leave(object sender, EventArgs e)
        {
            try
            {
                addressFont = new FontConverter().ConvertFromString(this.addressFontTxt.Text) as Font;
                restartTimer();
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Formato no válido");
                this.addressFontTxt.Text = new FontConverter().ConvertToString(addressFont);
            }
        }

        private void headderFontTxt_Leave(object sender, EventArgs e)
        {
            try
            {
                headerFont = new FontConverter().ConvertFromString(this.headderFontTxt.Text) as Font;
                restartTimer();
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Formato no válido");
                this.headderFontTxt.Text = new FontConverter().ConvertToString(headerFont);
            }
        }

        private void phoneTxt_TextChanged(object sender, EventArgs e)
        {
            if (phoneCheckBox.Checked)
                restartTimer();
        }

        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
        {
                restartTimer();
        }

        private void phoneFontBtn_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.Font = phoneFont;
            if (fontDialog.ShowDialog() != DialogResult.OK)
                return;
            this.phoneFontTxt.Text = new FontConverter().ConvertToString((object)fontDialog.Font);
            phoneFont = fontDialog.Font;

            if (phoneCheckBox.Checked)
                restartTimer();

            fontDialog.Dispose();
        }

        private void phoneFontTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Return)
                return;
            try
            {
                phoneFont = new FontConverter().ConvertFromString(this.phoneFontTxt.Text) as Font;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Formato no válido");
                this.phoneFontTxt.Text = new FontConverter().ConvertToString(phoneFont);
            }
        }

        private void phoneFontTxt_Leave(object sender, EventArgs e)
        {
            try
            {
                phoneFont = new FontConverter().ConvertFromString(this.phoneFontTxt.Text) as Font;
                restartTimer();
            }
            catch (ArgumentException )
            {
                MessageBox.Show("Formato no válido");
                this.phoneFontTxt.Text = new FontConverter().ConvertToString(phoneFont);
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

        private void setChildrenHorizontally(Control control)
        {
            var width = 0;
            int gap = 0;
            int currentGap = 0;
            foreach (Control child in control.Controls)
            {
                child.Size = child.MinimumSize;
                width += child.Width;
            }

            currentGap=gap = (control.Width - width) / control.Controls.Count;
            
            foreach (Control child in control.Controls)
            {
                child.Location = new Point(currentGap, 10);
                currentGap += control.Width + gap;
            }

        }

        private void footerTxt_TextChanged(object sender, EventArgs e)
        {
            if (this.pd == null)
                return;
            if (footerCheckBox.Checked)
                restartTimer();
        }

 

        private async void getFitString(Control control, string text)
        {
            if (pd != null)
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
        }

        private void footerFontTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Return)
                return;
            try
            {
                footerFont = new FontConverter().ConvertFromString(this.footerFontTxt.Text) as Font;
                restartTimer();
            }
            catch (ArgumentException )
            {
                MessageBox.Show("Formato no válido");
                this.footerFontTxt.Text = new FontConverter().ConvertToString(footerFont);
            }
        }

        private void footerFontTxt_Leave(object sender, EventArgs e)
        {
            try
            {
                footerFont = new FontConverter().ConvertFromString(this.footerFontTxt.Text) as Font;
                restartTimer();
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Formato no válido");
                this.footerFontTxt.Text = new FontConverter().ConvertToString(footerFont);
            }
        }

        private void footerFontBtn_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.Font = footerFont;
            if (fontDialog.ShowDialog() != DialogResult.OK)
                return;
            this.footerFontTxt.Text = new FontConverter().ConvertToString(fontDialog.Font);
            footerFont = fontDialog.Font;

            if (footerCheckBox.Checked)
                restartTimer();

            fontDialog.Dispose();
        }

        private void bunifuCheckbox3_OnChange(object sender, EventArgs e)
        {
                restartTimer();
        }

        private void printerPanel_SizeChanged(object sender, EventArgs e)
        {
            this.centerToParent((Control)this.selectPrinterBtn);
        }

        private void headerCheckBox_OnChange(object sender, EventArgs e)
        {
                restartTimer();
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            isPreview = false;
            printDocument1.PrintController = new StandardPrintController();
            this.printDocument1.PrinterSettings.PrinterName = this.pd.PrinterSettings.PrinterName;
            this.pd.Document = this.printDocument1;
            this.printDocument1.Print();
            isPreview = true;
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            int width = (int)this.pd.PrinterSettings.DefaultPageSettings.PrintableArea.Width;
            int num = 0;
            Font font;

            if (this.logoPictureBox.Image != null && this.LogoCheckbox.Checked)
            {
                num += printingClass.printImage(logoPictureBox.Image, width, (int)logoHeight.Value, g, num) + 1;
            }

            if (headerCheckBox.Checked)
            {
                num += printingClass.printLine(headderTxt.Text, headerFont, width, StringAlignment.Center, g, num) + 1;
            }

            num += printingClass.printLine(addressTxt.Text, addressFont, width, StringAlignment.Center, g, num) + 1;

            if(phoneCheckBox.Checked)
            {
                num += printingClass.printLine(phoneTxt.Text, phoneFont, width, StringAlignment.Center, g, num) + 3;
            }
            font =  width > 200 ? new Font("Times new Roman", 9.9f) : new Font("Times new Roman", 7f);
            num += printingClass.drawLine(10, width-10, g, num) + 1;
            printingClass.printLine("Cantidad",font,width, StringAlignment.Near,g,num);
            printingClass.printLine("Precio", font, width, StringAlignment.Center, g, num);
            num += printingClass.printLine("Importe", font, width, StringAlignment.Far, g, num) + 1;
            num += printingClass.drawLine(10, width - 10, g, num) + 3;

            num += printingClass.printLine("Refresco sabor fresa 500 ml", font, width, StringAlignment.Near, g, num)+1;
            printingClass.printLine("12.00", font, width, StringAlignment.Near, g, num);
            printingClass.printLine("$10.00", font, width, StringAlignment.Center, g, num);
            num += printingClass.printLine("$120.00", font, width, StringAlignment.Far, g, num) + 1;
            num += printingClass.drawLine(10, width - 10, g, num) + 3;

            num += printingClass.printLine("Total: $120.00", font, width, StringAlignment.Far, g, num) + 1;
            num += printingClass.printLine("Efectivo: $120.00", font, width, StringAlignment.Far, g, num) + 1;
            num += printingClass.printLine("Cambio: $0.00", font, width, StringAlignment.Far, g, num) + 10;

            if(footerCheckBox.Checked)
            {
                num += printingClass.printLine(footerTxt.Text, footerFont, width, StringAlignment.Center, g, num) + 5;
            }

            if (isPreview)
            {
                using (Pen p = new Pen(Color.Black)
                {
                    DashStyle = System.Drawing.Drawing2D.DashStyle.Dash,
                    Width = 3,
                    Alignment = System.Drawing.Drawing2D.PenAlignment.Outset
                })
                using (Font endFont = new Font("Agency FB", 12f, FontStyle.Regular))
                {
                    g.DrawLine(p, 0, num, width, num);
                    num += 4;

                    printingClass.printLine("Fin del Ticket", endFont, width, StringAlignment.Center, g, num);
                }
            }
            else
            {
                font = new Font("Century gothic", 18, FontStyle.Bold);
                g.TranslateTransform(width / 2, num / 2);
                g.RotateTransform(45);
                SizeF size = g.MeasureString("Ticket de prueba", font);
                PointF drawPoint = new PointF(-size.Width / 2f, -size.Height / 2f);
                using (SolidBrush brush = new SolidBrush(Color.FromArgb(100, 0, 0, 0)))
                {
                    g.DrawString("Ticket de prueba", font, brush, drawPoint);
                }
            }

            e.PageSettings.PaperSize = new PaperSize("custom", width, num);
            printDocument1.PrinterSettings.DefaultPageSettings.PaperSize = new PaperSize("custom", width, num);

            font.Dispose();
        }

        private void LogoCheckbox_OnChange(object sender, EventArgs e)
        {
            if (!this.LogoCheckbox.Checked)
            {
                this.splitContainer1.Panel1.Hide();
                this.splitContainer1.SplitterDistance = 0;

                logoHeight.Enabled = false; 
                logoHeight.Value = 0;
            }
            else
            {
                if (!this.LogoCheckbox.Checked || this.logoPictureBox.Image == null)
                    return;
                //this.splitContainer1.Panel1.Show();
                this.splitContainer1.SplitterDistance = this.splitContainer1.SplitterDistance != 0 ? this.splitContainer1.SplitterDistance : 50;
                // this.logoPictureBox.Show();
                logoHeight.Value = splitContainer1.SplitterDistance;
                logoHeight.Enabled = true;
            }
            restartTimer();
        }

        private void saveSettingsBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea guradar la configuración?", "Guardar Configuración", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;
            
            printer.saveConfiguration(printerNameLbl.Text, logoPictureBox.Image, 
                (int)logoHeight.Value, LogoCheckbox.Checked, headderTxt.Text,
                headerFont, headerCheckBox.Checked, addressTxt.Text, 
                addressFont, true, phoneTxt.Text, phoneFont, 
                phoneCheckBox.Checked, footerTxt.Text,footerFont,
                footerCheckBox.Checked);

            new Toast_Message("Guardado").Show() ;
        }

        private void Panel_Configuracion_SizeChanged(object sender, EventArgs e)
        {
            if (printer != null && !(this.printer.printerName != ""))
                return;
            //this.setTicketSize();
        }

        private void Panel_Configuracion_Shown(object sender, EventArgs e)
        {
            this.printerNameLbl.Text = this.printer.printerName == "" ? "..." : this.printer.printerName;
            this.headderTxt.Text = this.printer.header;
            this.headerCheckBox.Checked = this.printer.headderDisplay;
            this.headderFontTxt.Text = new FontConverter().ConvertToString((object)this.printer.headerFont);
            headerFont = this.printer.headerFont;
            this.addressTxt.Text = this.printer.address;
            this.addressFontTxt.Text = new FontConverter().ConvertToString((object)this.printer.addressFont);
            addressFont = this.printer.addressFont;
            this.phoneTxt.Text = this.printer.phone;
            this.phoneFontTxt.Text = new FontConverter().ConvertToString((object)this.printer.phoneFont);
            this.phoneCheckBox.Checked = this.printer.phoneDisplay;
            phoneFont = this.printer.phoneFont;
            this.footerTxt.Text = this.printer.footer;
            this.footerFontTxt.Text = new FontConverter().ConvertToString((object)this.printer.footerFont);
            this.footerCheckBox.Checked = this.printer.footerDisplay;
            footerFont = this.printer.footerFont;
            this.LogoCheckbox.Checked = this.printer.logoDisplay;
            this.logoPictureBox.Image = this.printer.logo != null ? this.printer.logo : (Image)null;

            if (!this.LogoCheckbox.Checked || this.logoPictureBox.Image == null || this.printer.logoHeight == 0)
            {
                logoHeight.Value = 0;
            }
            else
            {
                if (!this.LogoCheckbox.Checked || this.printer.logo == null)
                    return;

                logoHeight.Value = printer.logoHeight;

                /*this.logoPictureBox.Image = this.printer.logo;
                this.splitContainer1.SplitterDistance = this.printer.logoHeight;
                this.logoPictureBox.Visible = true;*/
            }
            this.splitContainer1.Panel1.Hide();
            if (pd != null)
                setzoom();

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

        private void timer1_Tick(object sender, EventArgs e)
        {
            isPreview = true;
            printPreviewControl1.Document = printDocument1;
            timer1.Stop();
        }

        private void logoHeight_ValueChanged(object sender, EventArgs e)
        {
            if (LogoCheckbox.Checked)
                restartTimer();
        }

        private void logoHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void Panel_Configuracion_Impresora_FormClosing(object sender, FormClosingEventArgs e)
        {
            dispose.DisposeControls(this);
        }
    }
}
