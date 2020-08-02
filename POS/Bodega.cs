using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Windows.Media.TextFormatting;

namespace POS
{
    class Bodega
    {
        private bool showInProductSearchingResults;
        private Capa_de_Negocio negocio;

        public string name { get; set; }

        public int ID { get; set; }

        private DataTable products { get; set; }

        public DataTable ProductTable
        {
            get
            {
                return this.products;
            }
        }

        public bool showInProductSearches
        {
            set
            {
                this.negocio.depot_UpdateShowInProductSearches(value, this.ID);
                this.showInProductSearchingResults = value;
            }
            get
            {
                return this.showInProductSearchingResults;
            }
        }

        public Bodega(int id)
        {
            this.negocio = new Capa_de_Negocio();
            this.InitializeDepot(id);
        }

        private void InitializeDepot(int id)
        {
            DataSet dataSet = this.negocio.DepotSetDepot(id);
            if (dataSet.Tables[0].Rows.Count > 0)
            {
                this.ID = Convert.ToInt32(dataSet.Tables[0].Rows[0]["ID_Bodega"]);
                this.name = dataSet.Tables[0].Rows[0]["Nombre"].ToString();
                this.showInProductSearchingResults = Convert.ToBoolean(dataSet.Tables[0].Rows[0]["Mostrar en Busquedas"]);
                this.products = dataSet.Tables[1].Copy();
            }
            else
                this.negocio = (Capa_de_Negocio)null;
        }

        public static Queue<int> getEveryDepotID()
        {
            return new Capa_de_Negocio().depot_getEveryDepotID();
        }

        public double getProductQuantity(string barcode)
        {
            foreach (DataRow row in (InternalDataCollectionBase)this.products.Rows)
            {
                if (row["Código de Barras"].ToString() == barcode)
                    return Convert.ToDouble(row["Cantidad"]);
            }
            return 0.0;
        }

        public double getMinStockForProduct(string barcode)
        {
            foreach (DataRow row in (InternalDataCollectionBase)this.products.Rows)
            {
                if (row["Código de Barras"].ToString() == barcode)
                    return Convert.ToDouble(row["Stock Mínimo"]);
            }
            return 0.0;
        }

        public static DataTable GetDepots()
        {
            return new Capa_de_Negocio().ProductGetDepots();
        }

        public static DataTable getInventory()
        {
            DataSet inventory = new Capa_de_Negocio().DepotGetInventory();
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Código de Barras");
            dataTable.Columns.Add("Descripción");
            dataTable.Columns.Add("Marca");
            List<string> stringList = new List<string>();
            foreach (DataRow row in (InternalDataCollectionBase)inventory.Tables[0].Rows)
            {
                stringList.Add(row["Nombre"].ToString());
                dataTable.Columns.Add(row["Nombre"].ToString());
                dataTable.Columns[row["Nombre"].ToString()].Caption = row["ID_Bodega"].ToString();
            }

            int count = 0;
            foreach (DataRow row1 in (InternalDataCollectionBase)inventory.Tables[1].Rows)
            {
                int index1 = -1;
                for (int index2 = 0; index2 < dataTable.Rows.Count; ++index2)
                {
                    if (row1["Código de Barras"].ToString() == dataTable.Rows[index2]["Código de Barras"].ToString())
                    {
                        index1 = index2;
                        break;
                    }
                }
                if (index1 == -1)
                {
                    DataRow row2 = dataTable.NewRow();
                    row2["Código de Barras"] = row1["Código de Barras"];
                    row2["Marca"] = row1["Marca"];
                    row2["Descripción"] = row1["Descripción"];
                    string index2 = row1["Nombre"].ToString();
                    row2[index2] = Convert.ToDouble(row1["Cantidad"]) == 0.0 ? (object)"0 piezas" : (object)(Math.Truncate(Convert.ToDouble(row1["Cantidad"]) / Convert.ToDouble(row1["Piezas por Caja"])).ToString() + " cajas,\r\n" + (Convert.ToDouble(row1["Cantidad"]) % Convert.ToDouble(row1["Piezas por Caja"])).ToString() + " piezas");
                    dataTable.Rows.Add(row2);
                    for (int index3 = 3; index3 < dataTable.Columns.Count; ++index3)
                    {
                        if (row2[index3].ToString() == "")
                            row2[index3] = (object)"0 piezas";
                    }
                }
                else
                {
                    string index2 = row1["Nombre"].ToString();
                    dataTable.Rows[index1][index2] = Convert.ToDouble(row1["Cantidad"]) == 0.0 ? (object)"0 piezas" : (object)(Math.Truncate(Convert.ToDouble(row1["Cantidad"]) / Convert.ToDouble(row1["Piezas por Caja"])).ToString() + " cajas,\r\n" + (Convert.ToDouble(row1["Cantidad"]) % Convert.ToDouble(row1["Piezas por Caja"])).ToString() + " piezas");
                }

                if (++count > 200)
                    break;
            }
            return dataTable;

        }

        public static DataTable getInventory(string text)
        {
            DataSet inventory = new Capa_de_Negocio().DepotGetInventory(text);
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Código de Barras");
            dataTable.Columns.Add("Descripción");
            dataTable.Columns.Add("Marca");
            List<string> stringList = new List<string>();
            foreach (DataRow row in inventory.Tables[0].Rows)
            {
                stringList.Add(row["Nombre"].ToString());
                dataTable.Columns.Add(row["Nombre"].ToString());
                dataTable.Columns[row["Nombre"].ToString()].Caption = row["ID_Bodega"].ToString();
            }
            foreach (DataRow row1 in inventory.Tables[1].Rows)
            {
                int index1 = -1;
                for (int index2 = 0; index2 < dataTable.Rows.Count; ++index2)
                {
                    if (row1["Código de Barras"].ToString() == dataTable.Rows[index2]["Código de Barras"].ToString())
                    {
                        index1 = index2;
                        break;
                    }
                }
                if (index1 == -1)
                {
                    DataRow row2 = dataTable.NewRow();
                    row2["Código de Barras"] = row1["Código de Barras"];
                    row2["Marca"] = row1["Marca"];
                    row2["Descripción"] = row1["Descripción"];
                    string index2 = row1["Nombre"].ToString();
                    row2[index2] = Convert.ToDouble(row1["Cantidad"]).ToString() + " piezas"; //Convert.ToDouble(row1["Cantidad"]) == 0.0 ?  "0 piezas" : (Math.Truncate(Convert.ToDouble(row1["Cantidad"]) / Convert.ToDouble(row1["Piezas por Caja"])).ToString() + " cajas,\r\n" + (Convert.ToDouble(row1["Cantidad"]) % Convert.ToDouble(row1["Piezas por Caja"])).ToString() + " piezas");
                    dataTable.Rows.Add(row2);
                    for (int index3 = 3; index3 < dataTable.Columns.Count; ++index3)
                    {
                        if (row2[index3].ToString() == "")
                            row2[index3] = "0 piezas";
                    }
                }
                else
                {
                    string index2 = row1["Nombre"].ToString();
                    dataTable.Rows[index1][index2] = Convert.ToDouble(row1["Cantidad"]).ToString() + " piezas";//Convert.ToDouble(row1["Cantidad"]) == 0.0 ?  "0 piezas" :  (Math.Truncate(Convert.ToDouble(row1["Cantidad"]) / Convert.ToDouble(row1["Piezas por Caja"])).ToString() + " cajas,\r\n" + (Convert.ToDouble(row1["Cantidad"]) % Convert.ToDouble(row1["Piezas por Caja"])).ToString() + " piezas");
                }
            }
            return dataTable;
        }

        public static int newDepot(string name)
        {
            if (!(name != ""))
                return -1;
            foreach (DataRow row in (InternalDataCollectionBase)Bodega.GetDepots().Rows)
            {
                if (row["Nombre"].ToString().ToLower() == name.ToLower())
                {
                    int num = (int)MessageBox.Show("No se creó la bodega.");
                    return -1;
                }
            }
            return new Capa_de_Negocio().DepotNewDepot(name);
        }

        public void Delete()
        {
            if (this.ID == 1)
                return;
            this.negocio.DepotDelete(this.ID);
        }

        public void UpdateMinStockQuantity(string barcode, double minStock, double maxStock)
        {
            this.negocio.DepotUpdateMinStockQuantity(this.ID, barcode, minStock, maxStock);
        }

        public void UpdateProductQuantity(double newQuantity, string barcode)
        {
            this.negocio.DepotUpdateProductQuantity(this.ID, barcode, newQuantity);
            this.InitializeDepot(this.ID);
        }

        public void Rename()
        {
            this.negocio.Depot_Rename(this.ID, this.name);
        }

        public void RegisterScrap(string barcode, double quantity, int employee)
        {
            this.negocio.depotScrap(this.ID, employee, barcode, quantity);
        }

        /// <summary>
        /// Updates the check status of each product in the depot to be displayed as indicated in the info table the next time 
        /// the user want to check the missing products list
        /// </summary>
        /// <param name="depotID">Depot ID</param>
        /// <param name="info">Table containing the barcode and its check status</param>
        public static void updateProductCheckStatus(int depotID, string barcode)
        {
            new Capa_de_Negocio().depot_updateProductCheckStatus(depotID, barcode);
        }

        public DataTable MissingProducts()
        {
            /*DataTable dataTable = new DataTable();
            string columnName1 = "Código de Barras";
            string columnName2 = "Descripción";
            string columnName3 = "Marca";
            string columnName4 = "Cantidad Faltante";
            string ischecked = "Checked";
            dataTable.Columns.Add(columnName1);
            dataTable.Columns.Add(columnName2);
            dataTable.Columns.Add(columnName3);
            dataTable.Columns.Add(columnName4);
            dataTable.Columns.Add(ischecked);

            foreach (DataRow row1 in (InternalDataCollectionBase)this.products.Rows)
            {
                double num1 = Convert.ToDouble(row1["Cantidad"]);
                double num2 = Convert.ToDouble(row1["Stock Mínimo"]);
                if (num2 - num1 > 0.0)
                {
                    DataRow row2 = dataTable.NewRow();
                    row2[0] = row1[columnName1];
                    row2[1] = row1[columnName2];
                    row2[2] = row1[columnName3];
                    Producto producto = new Producto(row1[columnName1].ToString());
                    double num3 = num2 - num1;
                    int num4 = (int)Math.Truncate(num3 / producto.PiecesPerCase);
                    double num5 = num3 - (double)num4 * producto.PiecesPerCase;
                    row2[3] = num4 <= 0 ? (object)string.Format("{0} piezas", (object)num5) : (object)string.Format("{0} cajas,\n{1} piezas", (object)num4, (object)num5);
                    dataTable.Rows.Add(row2);
                    dataTable.AcceptChanges();
                    row2[ischecked] = row1[ischecked];
                }
            }*/
            return  negocio.Depot_getMissingProducts(ID);
        }
    }
}
