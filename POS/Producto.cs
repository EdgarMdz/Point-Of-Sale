
using System;
using System.Data;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace POS
{
    public class Producto
    {
        private Capa_de_Negocio negocio = new Capa_de_Negocio();

        public string Brand { get; set; }

        public string Description { get; set; }

        public double RetailCost { get; set; }

        public double CostPerCase { get; set; }

        public double PiecesPerCase { get; set; }

        public double PurchaseCost { get; set; }

        public bool isReturnable { get; set; }

        


        /// <summary>
        /// Looks for a group of products' ID which are permitted to be sell together to form a case searching 
        /// by the barcode of one of the member products of that group
        /// </summary>
        /// <param name="barcode">barcode of one of the members that make up the group of products</param>
        /// <returns></returns>
        public static int findSellingMixedGroup(string barcode)
        {
            return new Capa_de_Negocio().product_findSellCaseByMixedProductsGroup(barcode);
        }

            

        public bool displayAsKilogram { get; set; }

  

        public bool HideInTicket { get; set; }

        public double CurrentStock { get; set; }

        public double minStock { get; set; }


        public string Photo { get; set; }

        public string Barcode { get; set; }

        public string mainProductBarcode { get; set; }
        public double PiecesToMakeOneMainProduct { get; set; }

        /// <summary>
        /// returns true if there is a match for the given amount.
        /// returns false if there is no match
        /// 
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public bool checkForWholeSaleExistingAmount(double amount)
        {
            DataTable wholeSaleCosts = negocio.Product_getWholeSaleCosts(Barcode);

            foreach (DataRow row in wholeSaleCosts.Rows)
            {
                var num = Convert.ToDouble(row["cantidad"]);
                if (num == amount)
                    return true;
                else if (num > amount)
                    break;
            }
            return false;
        }

        public void deleteWholeSaleCost(int wholeSaleCostId)
        {
            negocio.product_deleteWholeSaleCost(wholeSaleCostId, Barcode);
        }

        public byte[] Image { get; set; }

        public System.Drawing.Image image { get; set; }

        public int defaultDepotID { get; set; }

        int _mixedCaseGroup;
        public int mixedCaseGroup { get { return _mixedCaseGroup; } }

        public Producto()
        {
        }

        public Producto(string barcode)
        {
            if (Producto.SearchProduct(barcode))
            {
                this.Barcode = barcode;
                this.SearchProduct();
            }
            else
                this.Barcode = "";
        }

        public void addNewWholeSaleCost(double amount, double discount, bool isPercentage)
        {
            negocio.Product_addNewWholeSaleCost(amount, discount, isPercentage, Barcode);
        }

        /// <summary>
        /// Get list of products
        /// </summary>
        /// <param name="offset">amount of rows to offset</param>
        /// <param name="fetchRows">rows to be fetched after offset</param>
        /// <returns></returns>
        public static DataTable fillTable(int offset=0, int fetchRows=0)
        {
            return new Capa_de_Negocio().fillTable(offset,fetchRows);
        }

        public void addProduct()
        {
            this.negocio.AddProduct(this.Brand, this.Description, this.RetailCost, this.CostPerCase,
                this.PiecesPerCase, this.PurchaseCost, this.CurrentStock, this.minStock, this.Image,
                this.Barcode, this.defaultDepotID, this.mainProductBarcode, this.isReturnable,
                this.displayAsKilogram, this.HideInTicket, PiecesToMakeOneMainProduct);
        }

        public void DeletePurchaseCostRecordValue(DateTime date, double remainingPieces, double purchaseCost)
        {
            negocio.product_DeletePurchaseCostRecordValue(Barcode, date, remainingPieces, purchaseCost);
        }

        public void UpdateWholeSaleCost(int costID, double discount, bool isByPercentage)
        {
            negocio.Product_UpdateWholesaleCost(Barcode, costID, discount, isByPercentage);
        }

        public static DataTable getWrongProducts() => new Capa_de_Negocio().Products_getWrongProducts();

        public bool SearchProduct()
        {
            DataTable dataTable2 = this.negocio.SearchProduct(this.Barcode);
            if (dataTable2.Rows.Count <= 0)
                return false;
            foreach (DataRow row in dataTable2.Rows)
            {
                this.Barcode = row["Código de Barras"].ToString();
                this.Description = row["Descripción"].ToString();
                this.Brand = row["Marca"].ToString();
                this.RetailCost = Convert.ToDouble(row["Precio Menudeo"]);
                this.CostPerCase = Convert.ToDouble(row["Precio por Caja"]);
                this.PiecesPerCase = Convert.ToDouble(row["Piezas por Caja"]);
                this.PurchaseCost = row["Precio de Compra"].ToString()==""?0: Convert.ToDouble(row["Precio de Compra"]);
                this.CurrentStock = Convert.ToDouble(row["Stock"]);
                this.minStock = Convert.ToDouble(row["Stock Mínimo"].ToString() == "" ? 0 : row["Stock Mínimo"]);
                this.mainProductBarcode = row["Código de Barras del Producto Principal"].ToString();
                this.isReturnable = Convert.ToBoolean(row["Es Retornable?"]);
                this.displayAsKilogram = Convert.ToBoolean(row["Venta a granel"]);
                this.HideInTicket = Convert.ToBoolean(row["Ocultar en Ticket"]);
                if (row["Foto"].ToString() != "")
                {
                    this.Image = (byte[])row["Foto"];
                    this.image = System.Drawing.Image.FromStream((Stream)new MemoryStream(this.Image, 0, this.Image.Length));
                }
                this.defaultDepotID = Convert.ToInt32(row["Bodega por Defecto"]);
                _mixedCaseGroup = row["id_grupo"].ToString() != "" ? Convert.ToInt32(row["id_grupo"]) : 0;
                this.PiecesToMakeOneMainProduct = row["piezas para un producto"].ToString() == "" ? 0 : Convert.ToDouble(row["piezas para un producto"]);
            }
            return true;
        }

        public static bool SearchProduct(string Barcode)
        {
            return new Capa_de_Negocio().SearchProduct(Barcode).Rows.Count > 0;
        }

        /// <summary>
        /// creates a new group of mixable selling products and add products the given product to the group
        /// </summary>
        /// <param name="productBarcodelist">List of barcodes to be added to the group</param>
        public static void createNewGroup(DataTable productBarcodelist)
        {
            new Capa_de_Negocio().product_createNewGroup(productBarcodelist);
        }

        public void DeleteProduct()
        {
            this.negocio.DeleteProduct(this.Barcode);
        }

        public void UpdateProduct(string NewBarcode)
        {
            this.negocio.EditProduct(this.Brand, this.Description, this.RetailCost, this.CostPerCase, this.PiecesPerCase, this.PurchaseCost, this.CurrentStock, this.minStock, this.Image, this.Barcode, NewBarcode, this.defaultDepotID, this.mainProductBarcode, this.isReturnable, this.displayAsKilogram, this.HideInTicket,PiecesToMakeOneMainProduct);
        }

        public static DataTable SearchValueGetTable(string Search)
        {
            return new Capa_de_Negocio().SearchValue(Search);
        }

        public DataTable SearchProductByCoincidence(string text)
        {
            return this.negocio.SearchProductByCoincidence(text);
        }

        public DataTable getPurchaseChart()
        {
            return this.negocio.getPurchaseChart(this.Barcode);
        }

        public static DataTable getScrap(DateTime date, int periodOfTimeValue)
        {
            return periodOfTimeValue <= 3 ? new Capa_de_Negocio().Product_GetScrapTable(date, periodOfTimeValue) : (DataTable)null;
        }

        /// <summary>
        /// get the product list that make up the given group ID
        /// </summary>
        /// <param name="groupID">ID number of the desired group</param>
        /// <returns></returns>
        public static DataTable getMixedSaleGroupInfo(int groupID)
        {
            return new Capa_de_Datos().product_getMixedSaleGroupInfo(groupID);
        }

        public DataTable checkForStoredPurchaseCosts()
        {
            return negocio.Product_checkForStoredPurchaseCosts(Barcode);
        }
        public static DataTable getBestSellProducts(DateTime date, int periodOfTimeValue)
        {
            if (periodOfTimeValue > 3)
                return (DataTable)null;
            DataTable dataTable = new Capa_de_Negocio().Product_BestSellProductsTable(date, periodOfTimeValue);
            dataTable.Columns.Add("No.", typeof(int));
            dataTable.Columns["No."].SetOrdinal(0);
            for (int index = 0; index < dataTable.Rows.Count; ++index)
                dataTable.Rows[index][0] = (object)(index + 1);
            return dataTable;
        }

        public static DataTable ProductStatistics(
          string barcode,
          int periodOfTimeValue,
          DateTime date)
        {
            return new Capa_de_Negocio().product_ProductStatistics(barcode, periodOfTimeValue, date);
        }


        /// <summary>
        /// Updates the group of mixable selling products as stablished in the given table
        /// </summary>
        /// <param name="groupID">ID number of the group to be updated</param>
        /// <param name="productBarcodelist">List of barcodes to be added to the group</param>
        public static void updateGroup(int groupID, DataTable productBarcodelist)
        {
            new Capa_de_Negocio().product_updateGroup(groupID, productBarcodelist);
        }

        /// <summary>
        /// deletes the group of mixable selling products
        /// </summary>
        /// <param name="groupID">ID number of the group to be deleted</param>
        public static void deleteGroup(int groupID)
        {
            new Capa_de_Negocio().product_deleteGroup(groupID);
        }


        /// <summary>
        /// Registers a new promo in the database
        /// </summary>
        /// <param name="data">table storing the barcodes and amount for each product in the promo</param>
        /// <param name="promoCost">cost of the promo</param>
        public static void newPromo(DataTable data, double promoCost)
        {
            new Capa_de_Negocio().product_newPromo(data, promoCost);
        }

        /// <summary>
        /// Gets the list of the different promos for products in the database
        /// </summary>
        /// <returns></returns>
        public static DataTable getListOfPromos()
        {
            return new Capa_de_Negocio().product_getListOfPromos();
        }


        /// <summary>
        /// gets the info from a promo for the given ID
        /// </summary>
        /// <param name="promoID">Promo ID</param>
        /// <returns></returns>
        public static DataSet getPromo(int promoID)
        {
            Capa_de_Negocio neg = new Capa_de_Negocio();
            DataTable details = neg.product_getPromo(promoID);


            DataTable general = new DataTable();
            general.Columns.Add("cost");
            general.Columns.Add("discount");
            general.Columns.Add("totalAmountOfProducts");

            foreach (DataRow row in getListOfPromos().Rows)
            {
                if (Convert.ToInt32(row["promoID"]) == promoID)
                {
                    DataRow newRow = general.NewRow();
                    newRow["cost"] = row["Costo"];


                    double total = 0;

                    foreach (DataRow item in details.Rows)
                    {
                        Producto p = new Producto(item["id_producto"].ToString());
                        total += Convert.ToDouble(item["amount"]) * p.RetailCost;
                    }

                    newRow["discount"] = total - Convert.ToDouble(row["Costo"]);
                    newRow["totalAmountOfProducts"] = row["Cant. de Productos"];

                    general.Rows.Add(newRow);

                    break;
                }

            }



            DataSet set = new DataSet();

            set.Tables.Add(general);
            set.Tables.Add(details);

            return set;
        }

        /// <summary>
        /// updates the promo with the given details
        /// </summary>
        /// <param name="promoID">ID of the promo to be updated</param>
        /// <param name="promoDetails">new promo data details</param>
        /// <param name="cost">new cost for the promo</param>
        public static void updatePromo(int promoID, DataTable promoDetails, double cost)
        {
            new Capa_de_Negocio().product_updatePromo(promoID, promoDetails, cost);
        }

        /// <summary>
        /// deletes the promo which corresponds to the given ID
        /// </summary>
        /// <param name="promoID">Promo id number</param>
        public static void deletePromo(int promoID)
        {
            new Capa_de_Negocio().product_deletePromo(promoID);
        }

        /// <summary>
        /// Finds the IDs the promo which product info matches with the given text
        /// </summary>
        /// <param name="text">key words to find a promo</param>
        /// <returns></returns>
        public static int[] findPromo(string text)
        {
            return new Capa_de_Negocio().product_findPromo(text);
        }

        public static bool promoExist(int promoID)
        {
            return new Capa_de_Negocio().product_getPromo(promoID).Rows.Count > 0;
        }
        public DataTable GetWholesaleCosts()
        {
            return negocio.Product_getWholeSaleCosts(Barcode);
        }

        public double GetWholesaleDiscount(double amount)
        {
            DataTable dt = GetWholesaleCosts();

            if (dt.Rows.Count == 0)
                return 0;
            else
            {

                int discountRowIndex = -1;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    double minAmount = Convert.ToDouble(dt.Rows[i]["cantidad"]);

                    if (amount >= minAmount)
                        discountRowIndex = i;
                    else
                        break;
                }
                if (discountRowIndex == -1)
                    return 0;
                else
                {
                    //in case the given amount fits for case discount return that value
                    if (amount >= PiecesPerCase && PiecesPerCase >= Convert.ToDouble(dt.Rows[discountRowIndex]["cantidad"])) 
                        return (RetailCost - CostPerCase / PiecesPerCase) * amount;

                    //if not return the corresponding discount
                    else
                    {
                        var discountvalue = dt.Rows[discountRowIndex]["descuento"].ToString();

                        double discount = discountvalue.IndexOf("%") > -1 ? Convert.ToDouble(discountvalue.Substring(0, discountvalue.Length - 1)) :
                            Convert.ToDouble(discountvalue);
                        bool isPercentage = discountvalue.IndexOf("%") > -1;

                        if (!isPercentage)
                            return discount * amount;
                        else
                            return (RetailCost / 100 * discount) * amount;
                    }
                }
            }
        }
        public DataTable getDerivedProductsList()
        {
            return negocio.getDerivedProductsList(Barcode);
        }

        public static Tuple<int, double> getCasesAndSingleProducts(Producto producto, double amount)
        {
            int cases = producto.PiecesPerCase > 1.0 ? (int)Math.Truncate(amount / producto.PiecesPerCase) : 0;
            double singlePieces = producto.PiecesPerCase > 1.0 ? amount % producto.PiecesPerCase : amount;

            return new Tuple<int, double>(cases, singlePieces);
        }
    }
}
