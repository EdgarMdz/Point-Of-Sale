using System;
using System.Collections.Generic;
using System.Data;

namespace POS
{
    class Venta
    {
        private Capa_de_Negocio negocio = new Capa_de_Negocio();
        private int _ID;
        private int _EmployeeID;
        private int _EmployeeWhoCanceledTheSale;
        private int _CustomerID;
        private DateTime _cancellationdate;
        private DateTime _date;
        private Decimal _Total;
        private Decimal _payment;
        private Decimal _Cash;
        private bool _paymentStatus;
        private bool _isCanceled;
        private DataTable _saleDetail;

        public int ID
        {
            get
            {
                return this._ID;
            }
        }

        public DateTime Date
        {
            get
            {
                return this._date;
            }
        }

        public DateTime cancellationDate
        {
            get
            {
                return this._cancellationdate;
            }
        }

        public int EmployeeID
        {
            get
            {
                return this._EmployeeID;
            }
        }

        public int EmployeeWhoCanceledTheSale
        {
            get
            {
                return this._EmployeeWhoCanceledTheSale;
            }
        }

        public int CustomerID
        {
            get
            {
                return this._CustomerID;
            }
        }

        public Decimal Total
        {
            get
            {
                return this._Total;
            }
        }

        public Decimal Payment
        {
            get
            {
                return this._payment;
            }
        }

        public Decimal Cash
        {
            get
            {
                return this._Cash;
            }
        }

        public bool isPaid
        {
            get
            {
                return this._paymentStatus;
            }
        }

        public bool isSaleCanceled
        {
            get
            {
                return this._isCanceled;
            }
        }

        public DataTable getSoldProducts
        {
            get
            {
                return this._saleDetail;
            }
        }

        public Venta()
        {
        }

        public Venta(int id)
        {
            this._ID = id;
            this.initialize();
        }

        public static DataTable getSalesInvestProfitData(int periodOfTimeValue, DateTime date)
        {
            return new Capa_de_Negocio().Sale_InvestmentSellsProfit(periodOfTimeValue, date);
        }

        private void initialize()
        {
            DataSet dataSet = this.negocio.Sale_Initialize(this._ID);
            DataRow row = dataSet.Tables[0].Rows[0];
            this._saleDetail = dataSet.Tables[1];
            this._date = Convert.ToDateTime(row["Fecha"]).Add(TimeSpan.Parse(row["hora"].ToString()));
            this._EmployeeID = Convert.ToInt32(row["id_Empleado"]);
            this._CustomerID = Convert.ToInt32(row["id_cliente"]);
            this._Total = Convert.ToDecimal(row["Total"]);
            this._payment = Convert.ToDecimal(row["Abono"]);
            this._paymentStatus = row["Estado de Pago"].ToString().ToLower() == "pagado";
            this._isCanceled = Convert.ToBoolean(row["Cancelada"]);
            this._Cash = Convert.ToDecimal(row["Efectivo"]);
            int.TryParse(row["Empleado que canceló"].ToString(), out this._EmployeeWhoCanceledTheSale);
            DateTime.TryParse(row["Fecha de Cancelación"].ToString(), out this._cancellationdate);
        }

        public static DataTable getUnfinishedSalesIDs()
        {
            return new Capa_de_Negocio().Sale_getUnfinishedSalesIDs();
        }

        public int newSale(
          int EmployeeID,
          int customerID,
          double Total,
          double Payment,
          Tuple<string, double, double, double,int>[] ListofProducts,
          double cash)
        {
            this._ID = this.negocio.Sale_newSale(EmployeeID, customerID, Total, Payment, ListofProducts, cash);
            this.initialize();
            return this._ID;
        }

        public static Venta getLastSale()
        {
            int lastSaleId = new Capa_de_Negocio().Sale_getLastSaleID();
            return lastSaleId > 0 ? new Venta(lastSaleId) : (Venta)null;
        }

        public void Cancel(int employeeID)
        {
            this.negocio.Sale_Cancel(this._ID, employeeID);
            this.initialize();
        }

        public int getAmountOfPendingPackagesToReturn(string barcode)
        {
            foreach (DataRow row in (InternalDataCollectionBase)this._saleDetail.Rows)
            {
                if (barcode == row["id_producto"].ToString() && !this._isCanceled)
                    return Convert.ToInt32(row["Cantidad"]) - Convert.ToInt32(row["Envases Retornados"]);
            }
            return 0;
        }

        public int getAmountOfPackagesReturned(string barcode)
        {
            foreach (DataRow row in (InternalDataCollectionBase)this._saleDetail.Rows)
            {
                if (barcode == row["id_producto"].ToString() && new Producto(barcode).isReturnable)
                    return Convert.ToInt32(row["Envases Retornados"]);
            }
            return 0;
        }

        public static bool doesSaleExist(int ID)
        {
            return new Capa_de_Negocio().Sale_doesPurchaseExist(ID);
        }

        public Decimal getSingleCost(string barcode)
        {
            foreach (DataRow row in (InternalDataCollectionBase)this._saleDetail.Rows)
            {
                if (row["id_producto"].ToString() == barcode)
                    return Convert.ToDecimal(row["Precio"]) - Convert.ToDecimal(row["Descuento"]) / Convert.ToDecimal(row["Cantidad"]);
            }
            return new Decimal(0);
        }

        public Decimal getAmountofProduct(string barcode)
        {
            foreach (DataRow row in (InternalDataCollectionBase)this._saleDetail.Rows)
            {
                if (row["id_producto"].ToString() == barcode)
                    return Convert.ToDecimal(row["Cantidad"]);
            }
            return new Decimal(0);
        }

        public void returnPackages(string barcode, int amount, int employeeID)
        {
            this.negocio.Sale_ReturnPackage(this.ID, barcode, (Decimal)amount, employeeID);
            this.initialize();
        }

        public void RefoundProductsToCustomer(DataTable barcodesToBeRefounded)
        {
            negocio.Sale_RefoundProductsToCustomer(ID, barcodesToBeRefounded);
        }

        public DataSet getNextSaleID()
        {
            return negocio.getNextSaleID(ID);
        }

        public static DataTable getInfoUnfinishedSell(int savedWindowID, int newWindowID)
        {
            Capa_de_Negocio n = new Capa_de_Negocio();
            return n.getInfoUnfinishedSell(savedWindowID, newWindowID);
        }
    }
}
