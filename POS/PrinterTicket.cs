using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace POS
{
    class PrinterTicket
    {
        private Capa_de_Negocio negocio;
        private string _printerName;
        private Image _logo;
        private int _logoHeight;
        private bool _logoDisplay;
        private string _header;
        private Font _headerFont;
        private bool _headerDisplay;
        private string _address;
        private Font _addressFont;
        private bool _addressDisplay;
        private string _phone;
        private Font _phoneFont;
        private bool _phoneDisplay;
        private string _footer;
        private Font _footerFont;
        private bool _footerDisplay;
        private bool _useMPOS;
        private int _charactersPerLine;

        public string printerName
        {
            get
            {
                return this._printerName;
            }
        }

        public Image logo
        {
            get
            {
                return this._logo;
            }
        }

        public int logoHeight
        {
            get
            {
                return this._logoHeight;
            }
        }

        public bool logoDisplay
        {
            get
            {
                return this._logoDisplay;
            }
        }

        public string header
        {
            get
            {
                return this._header;
            }
        }

        public Font headerFont
        {
            get
            {
                return this._headerFont;
            }
        }

        public bool headderDisplay
        {
            get
            {
                return this._headerDisplay;
            }
        }

        public string address
        {
            get
            {
                return this._address;
            }
        }

        public Font addressFont
        {
            get
            {
                return this._addressFont;
            }
        }

        public bool addressDisplay
        {
            get
            {
                return this._addressDisplay;
            }
        }

        public string phone
        {
            get
            {
                return this._phone;
            }
        }

        public Font phoneFont
        {
            get
            {
                return this._phoneFont;
            }
        }

        public bool phoneDisplay
        {
            get
            {
                return this._phoneDisplay;
            }
        }

        public string footer
        {
            get
            {
                return this._footer;
            }
        }

        public Font footerFont
        {
            get
            {
                return this._footerFont;
            }
        }

        public bool footerDisplay
        {
            get
            {
                return this._footerDisplay;
            }
        }

        public bool useMPOS { get { return _useMPOS; } }

        public int charactersPerLine { get { return _charactersPerLine; } }

        public PrinterTicket()
        {
            this.negocio = new Capa_de_Negocio();
            this.initialize();
        }

        private void initialize()
        {
            DataTable dataTable = this.negocio.TicketPrinter_Initialize();
            if (dataTable.Rows.Count <= 0)
                return;
            DataRow row = dataTable.Rows[0];
            if (row["Imagen de Encabezado"].ToString() != "")
            {
                byte[] buffer = (byte[])row["Imagen de Encabezado"];
                this._logo = Image.FromStream((Stream)new MemoryStream(buffer, 0, buffer.Length));
            }
            this._logoHeight = Convert.ToInt32(row["Altura de imagen"]);
            this._logoDisplay = Convert.ToBoolean(row["Mostrar Imagen"]);
            this._printerName = row["Impresora"].ToString();
            this._header = row["Encabezado"].ToString();
            this._headerFont = new FontConverter().ConvertFromString(row["Fuente del Encabezado"].ToString()) as Font;
            this._headerDisplay = Convert.ToBoolean(row["Mostrar Encabezado"]);
            this._address = row["Dirección"].ToString();
            this._addressFont = new FontConverter().ConvertFromString(row["Fuente de la Dirección"].ToString()) as Font;
            this._addressDisplay = Convert.ToBoolean(row["Mostrar Dirección"]);
            this._phone = row["Teléfono"].ToString();
            this._phoneFont = new FontConverter().ConvertFromString(row["Fuente del teléfono"].ToString()) as Font;
            this._phoneDisplay = Convert.ToBoolean(row["Mostrar Teléfono"]);
            this._footer = row["Pie de Página"].ToString();
            this._footerDisplay = Convert.ToBoolean(row["Mostrar Pie de Página"]);
            this._footerFont = new FontConverter().ConvertFromString(row["Fuente para pie de página"].ToString()) as Font;

            var usePOS = row["usar Microsoft POS"].ToString();
          
            if (usePOS == "" || usePOS == "0")
                _useMPOS = false;
            else
                _useMPOS = true;

            _charactersPerLine = Convert.ToInt32(row["caracteres por linea"]);
        }

        public void saveConfiguration(
          string printerName,
          Image logo,
          int logoHeight,
          bool displayImage,
          string header,
          Font headerFont,
          bool displayHeader,
          string address,
          Font addressFont,
          bool displayaddress,
          string phone,
          Font phoneFont,
          bool displayphone,
          string footer,
          Font footerFont,
          bool displayfooter)
        {
            byte[] logo1 = (byte[])null;
            if (logo != null)
            {
                MemoryStream memoryStream = new MemoryStream();
                logo.Save((Stream)memoryStream, logo.RawFormat);
                logo1 = memoryStream.GetBuffer();
            }
            this.negocio.Printer_saveConfiguration(printerName, logo1, logoHeight, displayImage, header, new FontConverter().ConvertToString((object)headerFont), displayHeader, address, new FontConverter().ConvertToString((object)addressFont), displayaddress, phone, new FontConverter().ConvertToString((object)phoneFont), displayphone, footer, new FontConverter().ConvertToString((object)footerFont), displayfooter);
            this.initialize();
        }

        public Size printLogo(Graphics g, int y)
        {
            if (!this._logoDisplay)
                return new Size(0, 0);
            int width = (int)new PrintDialog()
            {
                PrinterSettings = {
          PrinterName = this.printerName
        }
            }.PrinterSettings.DefaultPageSettings.PrintableArea.Width;
            g.DrawImage(this._logo, 0, y, width, this._logoHeight);
            return new Size(width, this._logoHeight);
        }

        public Size printHeader(Graphics g, int y)
        {
            if (!this._headerDisplay)
                return new Size(0, 0);
            return this.printCentered(g, y, this._header, this._headerFont, (int)new PrintDialog()
            {
                PrinterSettings = {
          PrinterName = this.printerName
        }
            }.PrinterSettings.DefaultPageSettings.PrintableArea.Width);
        }

        public Size printAddress(Graphics g, int y)
        {
            if (!this._addressDisplay)
                return new Size(0, 0);
            return this.printCentered(g, y, this._address, this._addressFont, (int)new PrintDialog()
            {
                PrinterSettings = {
          PrinterName = this.printerName
        }
            }.PrinterSettings.DefaultPageSettings.PrintableArea.Width);
        }

        public Size printPhone(Graphics g, int y)
        {
            if (!this._phoneDisplay)
                return new Size(0, 0);
            return this.printCentered(g, y, this._phone, this._phoneFont, (int)new PrintDialog()
            {
                PrinterSettings = {
          PrinterName = this.printerName
        }
            }.PrinterSettings.DefaultPageSettings.PrintableArea.Width);
        }

        public Size printFooter(Graphics g, int y)
        {
            if (!this._footerDisplay)
                return new Size(0, 0);
            return this.printCentered(g, y, this._footer, this._footerFont, (int)new PrintDialog()
            {
                PrinterSettings = {
          PrinterName = this.printerName
        }
            }.PrinterSettings.DefaultPageSettings.PrintableArea.Width);
        }

        public Size printCentered(Graphics g, int y, string text, Font font, int paperWidth)
        {
            string str1 = "";
            string str2 = "\r\n";
            int length = text.IndexOf(str2) > -1 ? text.IndexOf(str2) : text.Length;
            int startIndex = 0;
            do
            {
                string str3 = text.Substring(startIndex, length).Trim();
                Size size;
                for (size = PrinterTicket.getStringSize(str3, font); size.Width > paperWidth; size = PrinterTicket.getStringSize(str3, font))
                {
                    int letterByMeasuring = PrinterTicket.getLastLetterByMeasuring(str3, font, paperWidth);
                    str3 = str3.Insert(letterByMeasuring, str3[letterByMeasuring] == ' ' || str3[letterByMeasuring] != ' ' && str3[letterByMeasuring - 1] == ' ' ? str2 : "-" + str2);
                }
                if (str3.IndexOf(str2) > -1)
                    size = this.printCentered(g, y, str3, font, paperWidth);
                else
                    g.DrawString(str3, font, Brushes.Black, (float)((paperWidth - size.Width) / 2), (float)y);
                y += size.Height;
                str1 = str1 + str3 + str2;
                startIndex += length + str2.Length;
                if (startIndex >= text.Length)
                {
                    length = -1;
                }
                else
                {
                    while (text.Substring(startIndex).IndexOf(str2) > -1 && text.Substring(startIndex).IndexOf(str2) == 0)
                        startIndex += str2.Length;
                    string str4 = text.Substring(startIndex);
                    string str5 = str4.IndexOf(str2) > -1 ? str4.Substring(0, str4.IndexOf(str2)) : str4.Substring(0, str4.Length);
                    length = str5.Length > 0 ? str5.Length : -1;
                }
            }
            while (length > -1 && length < text.Length);
            return PrinterTicket.getStringSize(str1.Trim(), font);
        }

        public static int getLastLetterByMeasuring(string text, Font font, int paperWidth)
        {
            int num = -1;
            for (int index = 0; index < text.Length; ++index)
            {
                if (PrinterTicket.getStringSize(text.Substring(0, index + 1), font).Width >= paperWidth)
                {
                    num = index - 1 < 0 ? 0 : index - 1;
                    break;
                }
            }
            return num;
        }

        public static Size getStringSize(string text, Font font)
        {
            return TextRenderer.MeasureText(text, font);
        }

        public static Font getFont(string text, int width, FontStyle style = FontStyle.Bold, string font= "Times new roman")
        {
            int num1 = 25;
            Font font1 = new Font(font, (float)num1, style);
            Size stringSize = PrinterTicket.getStringSize(text, font1);
            if (stringSize.Width > width)
            {
                int num2 = 0;
                Font font2;
                for (; stringSize.Width > width; stringSize = PrinterTicket.getStringSize(text, font2))
                {
                    num2 += 2;
                    font2 = new Font(font, (float)(num1 - num2), style);
                }
                font1 = new Font(font, (float)(num1 - num2), style);
            }
            else if (stringSize.Width < width)
            {
                int num2 = 0;
                Font font2;
                for (; stringSize.Width < width; stringSize = PrinterTicket.getStringSize(text, font2))
                {
                    num2 += 2;
                    font2 = new Font(font, (float)(num1 + num2), style);
                }
                font1 = new Font(font, (float)(num1 + num2), style);
            }
            return font1;
        }
    }
}
