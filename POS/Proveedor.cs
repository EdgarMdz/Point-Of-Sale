using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace POS
{
    public class Proveedor
    {
        private Capa_de_Negocio negocio = new Capa_de_Negocio();
        private DataTable _promos;
        private DataTable _POList;
        private DataTable _products;

        public int ID { get; set; }

        public string CuentaBancaria { get; set; }

        public string NombreEmpresa { get; set; }

        public string Direccion { get; set; }

        public string Telefono { get; set; }

        public bool[] diasVisita { get; set; }

        public double Adeudo { get; set; }

        public DataTable promos
        {
            get
            {
                return this._promos;
            }
        }

        public DataTable POList
        {
            get
            {
                return this._POList;
            }
        }

        public DataTable productList
        {
            get { return _products; }
        }
        public Proveedor()
        {
        }

        public Proveedor(int ID)
        {
            this.ID = ID;
            try
            {
                this.GetSupplierData();
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show("No se pudo completar la acción\n Error: \n " + ex.Message, "Error");
            }
        }

        public void Add()
        {
            this.ID = this.negocio.SupplierAdd(this.NombreEmpresa, this.Adeudo);
            this.GetSupplierData();
        }

        public DataTable GetSupplierList()
        {
            return this.negocio.GetSupplierList();
        }

        public void GetSupplierData()
        {
            DataTable supplierData = this.negocio.GetSupplierData(this.ID);
            if (supplierData.Rows.Count > 0)
            {
                this.NombreEmpresa = supplierData.Rows[0][1].ToString()[0].ToString().ToUpper() + supplierData.Rows[0][1].ToString().Substring(1);
                this.Direccion = !(supplierData.Rows[0][2].ToString() != "") ? "" : supplierData.Rows[0][2].ToString()[0].ToString().ToUpper() + supplierData.Rows[0][2].ToString().Substring(1);
                this.Telefono = supplierData.Rows[0][3].ToString();
                int index = 0;
                this.diasVisita = new bool[7];
                foreach (char ch in supplierData.Rows[0][4].ToString())
                {
                    this.diasVisita[index] = ch != '0';
                    ++index;
                }
                this.Adeudo = !(supplierData.Rows[0][5].ToString() != "") ? 0.0 : Convert.ToDouble(supplierData.Rows[0][5].ToString());
                this._promos = this.GetSales();
                this._POList = this.GetPOList();
                _products = this.negocio.GetSupplierProductList(ID);
            }
            else
            {
                int num = (int)MessageBox.Show("No se encontró Proveedor");
            }
        }

        private DataTable GetPOList()
        {
            return this.negocio.GetPOList(this.ID);
        }

        public void UpdateVisitingDays()
        {
            string visitingDays = "";
            foreach (bool flag in this.diasVisita)
                visitingDays = !flag ? visitingDays + "0" : visitingDays + "1";
            this.negocio.UpdateVisitingDays(visitingDays, this.ID);
            Recordatorio recordatorio = new Recordatorio();
            recordatorio.ID_Supplier = this.ID;
            recordatorio.getVisitingReminder();
            recordatorio.RepeatingDays = this.diasVisita;
            recordatorio.UpdateReminder();
        }

        public DataTable GetSales()
        {
            return this.negocio.SupplierGetSales(this.ID);
        }

        public void SupplierUpdateBasicInformation()
        {
            this.negocio.SupplierUpdateBasicInformation(this.NombreEmpresa, this.Telefono, this.Direccion, this.ID);
        }

        public DataTable GetSupplierProductList()
        {
            return negocio.GetSupplierProductList(ID);
        }

        public DataTable SupplierGetQuantitiesAndDates()
        {
            return this.negocio.SupplierGetQuantitiesAndDates(this.ID);
        }

        public void SupplierUpdateQuantities(string ProductID, double Quantity)
        {
            this.negocio.SupplierUpdateQuantities(this.ID, ProductID, Quantity);
        }

       /* private DataTable GiveFormatToTable(DataTable table)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Código de Barras");
            dataTable.Columns.Add("Descripción");
            dataTable.Columns.Add("Marca");
            dataTable.Columns.Add("Último Precio de Compra");
            dataTable.Columns.Add("Piezas Por Caja");
            dataTable.Columns.Add("Stock Actual");
            dataTable.Columns.Add("Stock Mínimo");
            List<int> intList = new List<int>();
            List<string> source = new List<string>();
            List<string> stringList = new List<string>();
            for (int index = 0; index < table.Rows.Count; ++index)
            {
                if (!intList.Contains(int.Parse(table.Rows[index]["id_proveedor"].ToString())))
                {
                    intList.Add(int.Parse(table.Rows[index]["id_proveedor"].ToString()));
                    source.Add(table.Rows[index]["Nombre de la Empresa"].ToString());
                    dataTable.Columns.Add(table.Rows[index]["Nombre de la Empresa"].ToString());
                    if (table.Rows[index]["id_proveedor"].ToString() == this.ID.ToString())
                    {
                        intList.Remove(int.Parse(table.Rows[index]["id_proveedor"].ToString()));
                        intList.Insert(0, int.Parse(table.Rows[index]["id_proveedor"].ToString()));
                        source.Remove(table.Rows[index]["Nombre de la Empresa"].ToString());
                        source.Insert(0, table.Rows[index]["Nombre de la Empresa"].ToString());
                        dataTable.Columns[table.Rows[index]["Nombre de la Empresa"].ToString()].SetOrdinal(7);
                    }
                }
            }
            if (table.Rows.Count == 0)
                return dataTable;
            foreach (DataRow row1 in table.Rows)
            {
                if (!stringList.Contains(row1["Código de Barras"].ToString()))
                {
                    DataRow row2 = dataTable.NewRow();
                    stringList.Add(row1["Código de Barras"].ToString());
                    row2["Código de Barras"] = (object)row1["Código de Barras"].ToString();
                    row2["Descripción"] = (object)row1["Descripción"].ToString();
                    row2["Marca"] = (object)row1["Marca"].ToString();
                    row2["Último Precio de Compra"] = (object)row1["Precio de Compra del Producto"].ToString();
                    foreach (string index in source)
                    {
                        foreach (DataRow row3 in table.Rows)
                        {
                            if (index == row3["Nombre de la Empresa"].ToString() && row1["Código de Barras"].ToString() == row3["Código de Barras"].ToString() && row3.RowState != DataRowState.Modified)
                            {
                                row2[index] = (object)row3["Precio de Compra"].ToString();
                                row3.SetModified();
                                if (row3["Nombre de la Empresa"].ToString().ToLower() == this.NombreEmpresa.ToLower())
                                {
                                    row2["Piezas Por Caja"] = (object)row3["Piezas por Caja"].ToString();
                                    break;
                                }
                                break;
                            }
                        }
                    }
                    row2["Stock Mínimo"] = (object)row1["Stock Mínimo"].ToString();
                    row2["Stock Actual"] = (object)row1["Stock"].ToString();
                    for (int index = 0; index < dataTable.Columns.Count; ++index)
                    {
                        if (row2[index].ToString() == "")
                            row2[index] = (object)"0.00";
                    }
                    dataTable.Rows.Add(row2);
                }
            }
            string str = "";
            int index1 = intList.IndexOf(this.ID);
            if (index1 >= 0)
                str = source.ElementAt<string>(index1);
            if (dataTable.Columns[7].ColumnName == str)
            {
                for (int index2 = 0; index2 < dataTable.Rows.Count; ++index2)
                {
                    if (dataTable.Rows[index2][7].ToString() == "0.00")
                    {
                        dataTable.Rows[index2].Delete();
                        --index2;
                    }
                }
            }
            else
                dataTable.Rows.Clear();
            for (int index2 = 8; index2 < dataTable.Columns.Count; ++index2)
            {
                double num = 0.0;
                for (int index3 = 0; index3 < dataTable.Rows.Count; ++index3)
                    num += Convert.ToDouble(dataTable.Rows[index3][index2].ToString());
                if (num == 0.0)
                {
                    dataTable.Columns.RemoveAt(index2);
                    --index2;
                }
            }
            return dataTable;
            for (int i = 7; i < table.Columns.Count; i++)
            {
                table.Columns[i].ColumnName = new Proveedor(Convert.ToInt32(table.Columns[i].ColumnName)).NombreEmpresa;
            }
            return table;
        }*/
    
        public List<string> filterSuppliers(string search)
        {
            DataTable dataTable1 = new DataTable();
            DataTable dataTable2 = this.negocio.FilterSuppliers(search);
            List<string> stringList = new List<string>();
            foreach (DataRow row in (InternalDataCollectionBase)dataTable2.Rows)
                stringList.Add(row[0].ToString());
            return stringList;
        }

        public void AddProduct(string Barcode, double PurchasePrice, double pieces)
        {
            this.negocio.SupplierAddProduct(this.ID, Barcode, PurchasePrice, pieces);
            _products = GetSupplierProductList();
        }

        public void SupplierEditProduct(
          int SupplierID,
          string Barcode,
          double NewPrice,
          double piecesPerCase)
        {
            this.negocio.SupplierEditProduct(SupplierID, Barcode, NewPrice, piecesPerCase);
        }

        public void DeleteProduct(int SupplierID, string Barcode)
        {
            this.negocio.SupplierDeleteProduct(SupplierID, Barcode);
        }

        public DataTable SupplierFilterProducts(string search)
        {
            return this.negocio.SupplierFilterProducts(search,ID);
        }

        public List<string> SupplierFilterProductsForNextPurchase(string search)
        {
            DataTable dataTable = this.negocio.SupplierFilterProducts(search, ID);
            List<string> stringList = new List<string>();
            foreach (DataRow row in (InternalDataCollectionBase)dataTable.Rows)
            {
                if (!(row["id_proveedor"].ToString() != this.ID.ToString()))
                    stringList.Add(row["Código de barras"].ToString());
            }
            return stringList;
        }

        public int GeneratePO(
          int EmployeeID,
          DateTime arrivalDate,
          DateTime paymentDueDate,
          double total,
          double Payment)
        {
            try
            {
                int po = this.negocio.SupplierGeneratePO(this.ID, EmployeeID, arrivalDate, paymentDueDate, total, Payment);
                if (Payment < total)
                {
                    this.Adeudo += total - Payment;
                    this.UpdateDebt();
                }
                return po;
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show("No se pudo completar la acción.\nError: " + ex.Message, "Error", MessageBoxButtons.OK);
                return -1;
            }
        }

        public void addProductToPO(
          int PO_ID,
          Producto product,
          double quantity,
          double PiecesPerCase,
          double UnitaryCost,
          double Total)
        {
            this.negocio.SupplierAddPODetails(PO_ID, product.Barcode, quantity, PiecesPerCase, UnitaryCost, Total);
        }

        public void UpdateDebt()
        {
            this.negocio.SupplierUpdateDebt(this.ID, this.Adeudo);
        }

        public DataTable SearchValueGetTable(string text)
        {
           return new Capa_de_Negocio().Supplier_SearchValueGetTable(text, this.ID);
        }

        public double getcost(string barcode) => negocio.supplier_getcost(ID, barcode);

        public static DataSet GetProductCostComparison(string barcode)
        {
            return new Capa_de_Negocio().GetProductCostComparison( barcode);
        }
    }
}
