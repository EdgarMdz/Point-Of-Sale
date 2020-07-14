using System;
using System.Collections.Generic;
using System.Data;

namespace POS
{
    class Cliente
    {
        private Capa_de_Negocio negocio = new Capa_de_Negocio();
        private bool _status;
        private double _debt;
        private bool _dontApplyAnyDiscount;
        private DataTable ProductsWithDiscount;

        public string Name { get; set; }

        public string Address { get; set; }

        public string TelephoneNumber { get; set; }

        public string Status { get; set; }

        public bool hasCredit
        {
            get
            {
                return this._status;
            }
        }

        public Decimal generalDiscount { get; set; }

        public bool isDiscountbyPercentage { get; set; }

        public double Debt
        {
            get
            {
                return this._debt;
            }
        }

        public bool DontApplyAnyDiscount
        {
            set
            {
                this._dontApplyAnyDiscount = value;
            }
            get
            {
                return this._dontApplyAnyDiscount;
            }
        }

        public int ID { get; set; }

        public Cliente(int id)
        {
            this.FindCustomerbyID(id);
        }

        public Cliente()
        {
        }

        public DataTable SearchCustomer(string search)
        {
            return this.negocio.SearchCustomer(search);
        }

        public void FindCustomer()
        {
            foreach (DataRow row in (InternalDataCollectionBase)this.negocio.FindCustomer(this.Name).Rows)
            {
                this.ID = int.Parse(row["Id_Cliente"].ToString());
                this.Name = row["Nombre"].ToString();
                this.Address = row["Dirección"].ToString();
                this.TelephoneNumber = row["Teléfono"].ToString();
                this.Status = row["Estado"].ToString();
                this._status = row["Estado"].ToString().ToLower() == "activo";
                this._debt = Convert.ToDouble(row["Adeudo"]);
                this._dontApplyAnyDiscount = Convert.ToBoolean(row["No aplicar ningun descuento"]);
                this.generalDiscount = Convert.ToDecimal(row["Descuento general"]);
                this.isDiscountbyPercentage = Convert.ToBoolean(row["isPercentage"]);
            }
        }

        public List<string[]> GetCustomerPurchases()
        {
            return this.negocio.GetCustomerPurchases(this.ID);
        }

        public DataTable getPurchase(string TicketNumber)
        {
            return this.negocio.getPurchase(TicketNumber);
        }

        public DataTable getPriceList(int Customer_ID)
        {
            return this.negocio.GetPriceList(Customer_ID);
        }

        public void Pay(double cash, int ticketNumber)
        {
            this.negocio.Pay(cash, this.ID, ticketNumber);
            this.FindCustomerbyID(this.ID);
        }

        public void newPrice(
          string barcode,
          double discount,
          bool isPercentage,
          double MinAmount,
          bool sellByCase)
        {
            this.negocio.newPrice(this.ID, barcode, discount, isPercentage, MinAmount, sellByCase);
        }

        public void UpdatePrice(
          int discount_ID,
          double Discount,
          bool isPercentage,
          double minAmount,
          bool SellByCases)
        {
            this.negocio.UpdatePrice(discount_ID, Discount, isPercentage, minAmount, SellByCases);
        }

        public bool isPriceRegistered(
          int CustomerID,
          string barcode,
          double minAmount,
          bool sellByCase)
        {
            return this.negocio.RegisteredPrice(CustomerID, barcode, minAmount, sellByCase);
        }

        public void deletePrice(int discountID)
        {
            this.negocio.deletePrice(discountID);
        }

        public void updateCustomerInfo()
        {
            this.negocio.UpdateCustomerInfo(this.Name, this.TelephoneNumber, this.Address, this.ID, this.generalDiscount, this.isDiscountbyPercentage, this._dontApplyAnyDiscount);
        }

        public void UpdateStatus()
        {
            this.negocio.UpdateStatus(this.Status, this.ID);
        }

        public void NewCustomer(double debt, int EmployeeID)
        {
            this.negocio.NewCustomer(this.Name, this.TelephoneNumber, this.Address, debt, EmployeeID);
        }

        public DataTable GetCustomerList()
        {
            return this.negocio.getCustomerList();
        }

        public void FindCustomerbyID(int id)
        {
            DataSet customerbyId = this.negocio.FindCustomerbyID(id);
            foreach (DataRow row in (InternalDataCollectionBase)customerbyId.Tables[0].Rows)
            {
                this.ID = int.Parse(row["Id_Cliente"].ToString());
                this.Name = row["Nombre"].ToString();
                this.Address = row["Dirección"].ToString();
                if (row["Teléfono"].ToString() != "")
                {
                    this.TelephoneNumber = row["Teléfono"].ToString();
                    if (this.TelephoneNumber.Length == 10)
                    {
                        this.TelephoneNumber = this.TelephoneNumber.Insert(3, "-");
                        this.TelephoneNumber = this.TelephoneNumber.Insert(7, "-");
                    }
                }
                this.generalDiscount = Convert.ToDecimal(row["Descuento general"]);
                this.isDiscountbyPercentage = Convert.ToBoolean(row["isPercentage"]);
                this._debt = Convert.ToDouble(row["Adeudo"]);
                this.Status = row["Estado"].ToString();
                this._status = row["Estado"].ToString().ToLower() == "activo";
                this._dontApplyAnyDiscount = Convert.ToBoolean(row["No aplicar ningun descuento"]);
            }
            this.ProductsWithDiscount = customerbyId.Tables[1];
        }

        public void RegisterPayment(int PurchaseID, DateTime DateAndTime, double cash, int employeeID)
        {
            this.negocio.RegisterPayment(this.ID, PurchaseID, DateAndTime, cash, employeeID);
        }

        public DataTable getPurchaseRecord()
        {
            return this.negocio.getPurchaseRecord(this.ID);
        }

        public DataRow findDiscount(string barcode, double minAmount)
        {
            foreach (DataRow row in (InternalDataCollectionBase)this.ProductsWithDiscount.Rows)
            {
                if (row["id_Producto"].ToString() == barcode && Convert.ToDouble(row["Cantidad minima"]) == minAmount)
                    return row;
            }
            return (DataRow)null;
        }

        public DataTable findAllDiscount(string barcode, double minAmount)
        {
            DataTable dataTable = new DataTable();
            foreach (DataColumn column in (InternalDataCollectionBase)this.ProductsWithDiscount.Columns)
                dataTable.Columns.Add(column.ColumnName);
            foreach (DataRow row in (InternalDataCollectionBase)this.ProductsWithDiscount.Rows)
            {
                if (row["id_Producto"].ToString() == barcode && Convert.ToDouble(row["Cantidad minima"]) == minAmount)
                    dataTable.Rows.Add(row.ItemArray.Clone() as object[]);
            }
            return dataTable;
        }

        public DataRow findDiscount(int discountID)
        {
            foreach (DataRow row in (InternalDataCollectionBase)this.ProductsWithDiscount.Rows)
            {
                if (Convert.ToInt32(row["id_descuento"]) == discountID)
                    return row;
            }
            return (DataRow)null;
        }

        public double getCost(string barcode, double amount)
        {
            if (!this._status)
                return new Producto(barcode).RetailCost;
            double num1 = -1.0;
            foreach (DataRow row in (InternalDataCollectionBase)this.ProductsWithDiscount.Rows)
            {
                if (row["Id_Producto"].ToString() == barcode)
                {
                    Producto producto = new Producto(barcode);
                    double num2 = Convert.ToBoolean(row["Venta por Caja"]) ? Convert.ToDouble(row["Cantidad minima"]) * producto.PiecesPerCase : Convert.ToDouble(row["Cantidad minima"]);
                    if (amount >= num2)
                        num1 = Convert.ToBoolean(row["Porcentage"]) ? producto.RetailCost - producto.RetailCost * Convert.ToDouble(row["Descuento"]) / 100.0 : producto.RetailCost - Convert.ToDouble(row["Descuento"]);
                }
            }
            if (num1 == -1.0 && this.generalDiscount > new Decimal(0))
            {
                Producto producto = new Producto(barcode);
                num1 = this.isDiscountbyPercentage ? producto.RetailCost - producto.RetailCost * (double)this.generalDiscount / 100.0 : producto.RetailCost - (double)this.generalDiscount;
            }
            else if (num1 == -1.0)
                num1 = new Producto(barcode).RetailCost;
            return num1;
        }

        public DataTable GetAcountsReceivable()
        {
            return this.negocio.Customer_GetAcountsReceivable(this.ID);
        }

        public void RefreshInfo()
        {
            this.FindCustomerbyID(this.ID);
        }
    }
}
