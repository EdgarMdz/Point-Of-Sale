using System;
using System.Collections.Generic;
using System.Data;

namespace POS
{
    class Capa_de_Negocio
    {
        private Capa_de_Datos datos = new Capa_de_Datos();

        public void AddProduct(string Marca, string Descripcion, double PrecioMinoreo, double PrecioPorCaja, double PiezasPorCaja, double PreciodeCompra, double Stock, double minStock, byte[] Foto, string CodigoBarras, int depotID, string mainProductBarcode, bool isReturnable, bool displayAsKilogram, bool HideInTicket)
        {
            this.datos.AddProduct(Marca, Descripcion, PrecioMinoreo, PrecioPorCaja, PiezasPorCaja, PreciodeCompra, Stock, minStock, Foto, CodigoBarras, depotID, mainProductBarcode, isReturnable, displayAsKilogram, HideInTicket);
        }

        public void addReminder(int SupplierID, DateTime startTime, DateTime endTime, bool[] repetitionDays, string message, bool canDelete)
        {
            this.datos.addReminder(SupplierID, startTime, endTime, repetitionDays, message, canDelete);
        }

        public DataTable Customer_GetAcountsReceivable(int customerID) =>
            this.datos.Customer_GetAcountsReceivable(customerID);

        public void deletePrice(int discountID)
        {
            this.datos.deleteCustomerPrice(discountID);
        }

        public void DeleteProduct(string BarCode)
        {
            this.datos.DeleteProduct(BarCode);
        }

        public void deleteReminder(int reminderID)
        {
            this.datos.deleteReminder(reminderID);
        }

        public DataTable Product_getWholeSaleCosts(string barcode)
        {
            return datos.Product_getWholeSaleCosts(barcode);
        }

        public Queue<int> depot_getEveryDepotID()
        {
            Queue<int> queue = new Queue<int>();
            foreach (DataRow row in this.datos.depot_everyDepotID().Rows)
            {
                queue.Enqueue(Convert.ToInt32(row["ID_Bodega"]));
            }
            return queue;
        }

        public void Depot_Rename(int depotID, string name)
        {
            this.datos.Depot_Rename(depotID, name);
        }

        public void depot_UpdateShowInProductSearches(bool show, int depotid)
        {
            this.datos.depot_UpdateShowInProductSearches(show, depotid);
        }

        public void product_deleteWholeSaleCost(int wholeSaleCostId, string barcode)
        {
            datos.product_deleteWholeSaleCost(wholeSaleCostId, barcode);
        }

        /// <summary>
        /// Updates the check status of each product in the depot to be displayed as indicated in the info table the next time 
        /// the user want to check the missing products list
        /// </summary>
        /// <param name="depotID">Depot ID</param>
        /// <param name="info">Table containing the barcode and its check status</param>
        public void depot_updateProductCheckStatus(int depotID, string barcode)
        => datos.depot_updateProductCheckStatus(depotID, barcode);

            public void DepotDelete(int DepotID)
        {
            this.datos.DepotDelete(DepotID);
        }

        public void Product_addNewWholeSaleCost(double amount, double discount, bool isPercentage, string barcode)
        {
            datos.Product_addNewWholeSaleCost(amount, discount, isPercentage, barcode);
        }

        public DataSet DepotGetInventory() =>
            this.datos.DepotGetInventory();

        public DataSet DepotGetInventory(string text) =>
          this.datos.DepotGetInventory(text);
        public int DepotNewDepot(string name) =>
            this.datos.DepotNewDepot(name);

        public void depotScrap(int depotID, int employeeID, string barcode, double quantity)
        {
            this.datos.depotScrap(depotID, employeeID, barcode, quantity);
        }

        public void Product_UpdateWholesaleCost(string barcode, int costID, double discount, bool isByPercentage)
        {
            datos.Product_UpdateWholesaleCost(barcode, costID, discount, isByPercentage);
        }

        public DataSet DepotSetDepot(int depotID) =>
            this.datos.DepotSetDepot(depotID);

        public void DepotUpdateMinStockQuantity(int depotID, string barcode, double minStock, double maxStock)
        {
            this.datos.DepotUpdateMinStockQuantity(depotID, barcode, minStock, maxStock);
        }

        public void DepotUpdateProductQuantity(int depotID, string barcode, double newQuant)
        {
            this.datos.DepotUpdateProductQuantity(depotID, barcode, newQuant);
        }

        public void EditProduct(string Marca, string Descripcion, double PrecioMinoreo, double PrecioPorCaja, double PiezasPorCaja, double preciodeCompra, double Stock, double minStock, byte[] Foto, string CodigoBarras, string NuevoCodigoBarras, int depotID, string mainProductBarcode, bool isReturnable, bool displayAsKg, bool hideInTicket)
        {
            this.datos.EditProduct(Marca, Descripcion, PrecioMinoreo, PrecioPorCaja, PiezasPorCaja, preciodeCompra, Stock, minStock, Foto, CodigoBarras, NuevoCodigoBarras, depotID, mainProductBarcode, isReturnable, displayAsKg, hideInTicket);
        }

        public void Employee_changePassword(int employeeID, string newPassword)
        {
            this.datos.Employee_changePassword(employeeID, newPassword);
        }

        public DataTable Employee_getListOfEmployees() =>
            this.datos.Employee_getListOfEmployees();

        public DataTable Employee_Initialize(int employeeID) =>
            this.datos.Employee_Initialize(employeeID);

        public int employee_Login(string user, string password) =>
            this.datos.employee_Login(user, password);

        public bool Employee_nameExist(string name) =>
            this.datos.Employee_nameExist(name);

        public int Employee_new(string name, string userName, bool isAdmin) =>
            this.datos.Employee_new(name, userName, isAdmin);

        public void employee_paySalary(int employeeID)
        {
            this.datos.Employee_paySalary(employeeID);
        }

        public DataTable Employee_search(string name) =>
            this.datos.Employee_search(name);

        public void Employee_UpdateAddress(string newAddress, int employeeId)
        {
            this.datos.Employee_UpdateAddress(newAddress, employeeId);
        }

        public void Employee_UpdateDateOfBirth(DateTime newDate, int employeeID)
        {
            this.datos.Employee_UpdateDateOfBirth(newDate, employeeID);
        }

        public void Employee_UpdateDiscount(int employeeID, double discount, bool isPercentage)
        {
            this.datos.Employee_UpdateDiscount(employeeID, discount, isPercentage);
        }

        public void Employee_UpdateHirementDate(DateTime newDate, int employeeID)
        {
            this.datos.Employee_UpdateHirementDate(newDate, employeeID);
        }

        public void Employee_UpdateName(string newName, int employeeID)
        {
            this.datos.Employee_UpdateName(newName, employeeID);
        }

        public void Employee_updatePaymentDay(bool[] paymentDays, int employeeID)
        {
            string str = "";
            foreach (bool flag in paymentDays)
            {
                str = !flag ? (str + "0") : (str + "1");
            }
            this.datos.Employee_updatePaymentDay(str, employeeID);
        }

        public void Sale_RefoundProductsToCustomer(int iD, DataTable barcodesToBeRefounded)
        {
            datos.Sale_RefoundProductsToCustomer(iD, barcodesToBeRefounded);
        }

        internal DataSet getNextSaleID(int ID)
        {
            return datos.getNextSaleID(ID);
        }

        public void Employee_UpdatePhone(string newPhone, int employeeID)
        {
            this.datos.Employee_UpdatePhone(newPhone, employeeID);
        }

        public void Employee_UpdatePosition(bool isAdmin, int employeeID)
        {
            this.datos.Employee_UpdatePosition(isAdmin, employeeID);
        }

        public void Employee_UpdateSalary(double newSalary, int employeeID)
        {
            this.datos.Employee_UpdateSalary(newSalary, employeeID);
        }

        public bool Employee_userNameExist(string user) =>
            this.datos.Employee_userNameExist(user);

        public DataTable fillTable() =>
            this.datos.fillTable();

        public DataTable FilterSuppliers(string search) =>
            this.datos.filterSuppliers(search);

        public DataTable FindCustomer(string Name) =>
            this.datos.FindCustomer(Name);

        public DataSet FindCustomerbyID(int id) =>
            this.datos.FindCustomerbyID(id);

        public void FirsUsage(DateTime time)
        {
            this.datos.FirsUsage(time);
        }

        public DataTable getCustomerList() =>
            this.datos.getCustomerList();

        public List<string[]> GetCustomerPurchases(int ID) =>
            this.datos.GetCustomerPurchases(ID);

        public DataTable GetPOList(int SupplierID) =>
            this.datos.GetPOList(SupplierID);

        public DataTable GetPriceList(int Customer_ID) =>
            this.datos.GetPriceList(Customer_ID);

        public DataTable getPurchase(string TicketNumber) =>
            this.datos.getPurchase(Convert.ToInt32(TicketNumber, 0x10));

        public DataTable getPurchaseChart(string CodigoBarras) =>
            this.datos.getPurchaseChart(CodigoBarras);

        public DataTable getPurchaseRecord(int Customer_ID) =>
            this.datos.getPurchaseRecord(Customer_ID);

        public DataTable getReminders(int supplierId, DateTime date) =>
            this.datos.getReminders(supplierId, date);

        public DataTable GetSupplierData(int id) =>
            this.datos.GetSupplierData(id);

        public DataTable GetSupplierList() =>
            this.datos.GetSupplierList();

        public DataTable GetSupplierProductList(int supplierid) =>
            this.datos.getSupplierProductList(supplierid);

        public DataTable getVisitingReminder(int SupplierId) =>
            this.datos.getVisitingReminder(SupplierId);

        public bool IsFirstUsageDateSet() =>
            this.datos.IsFirstUsageDateSet();

        public void NewCustomer(string Name, string TelephoneNumber, string Address, double debt, int employeeID)
        {
            this.datos.NewCustomer(Name, TelephoneNumber, Address, debt, employeeID);
        }

        public void newPrice(int Customer_ID, string barcode, double discount, bool isPercentage, double MinAmount, bool sellByCase)
        {
            this.datos.newPrice(Customer_ID, barcode, discount, isPercentage, MinAmount, sellByCase);
        }

        public void Pay(double cash, int Customer_ID, int TicketNumber)
        {
            this.datos.Pay(cash, Customer_ID, TicketNumber);
        }

        public void Printer_saveConfiguration(string printerName, byte[] logo, int logoHeight, bool displayImage, string header, string headerFont, bool displayHeader, string address, string addressFont, bool displayaddress, string phone, string phoneFont, bool displayphone, string footer, string footerFont, bool displayfooter)
        {
            this.datos.Printer_saveConfiguration(printerName, logo, logoHeight, displayImage, header, headerFont, displayHeader, address, addressFont, displayaddress, phone, phoneFont, displayphone, footer, footerFont, displayfooter);
        }

        /// <summary>
        /// creates a new group of mixable selling products and add products the given product to the group
        /// </summary>
        /// <param name="productBarcodelist">List of barcodes to be added to the group</param>
        public void product_createNewGroup(DataTable productBarcodelist) =>
            datos.product_createNewGroup(productBarcodelist);

        /// <summary>
        /// Gets the list of the different promos for products in the database
        /// </summary>
        /// <returns></returns>
        public DataTable product_getListOfPromos()
        => datos.product_getListOfPromos();


        /// <summary>
        /// gets the info from a promo for the given ID
        /// </summary>
        /// <param name="promoID">Promo ID</param>
        /// <returns></returns>
        public DataTable product_getPromo(int promoID)
        => datos.product_getPromo(promoID);


        /// <summary>
        /// Finds the IDs the promo which product info matches with the given text
        /// </summary>
        /// <param name="text">key words to find a promo</param>
        /// <returns></returns>
        public int[] product_findPromo(string text)
        {
            List<int> IDs = new List<int>();

            foreach (DataRow row in datos.product_findPromo(text).Rows)
            {
                IDs.Add(Convert.ToInt32(row["id_oferta"]));
            }

            return IDs.ToArray();
        }

        public DataTable Depot_getMissingProducts(int ID)
        {
            return datos.Depot_getMissingProducts(ID);
        }

        /// <summary>
        /// updates the promo with the given details
        /// </summary>
        /// <param name="promoID">ID of the promo to be updated</param>
        /// <param name="promoDetails">new promo data details</param>
        /// <param name="cost">new cost for the promo</param>
        public void product_updatePromo(int promoID, DataTable promoDetails, double cost) =>
            datos.product_updatePromo(promoID, promoDetails,cost);


        /// <summary>
        /// deletes the promo which corresponds to the given ID
        /// </summary>
        /// <param name="promoID">Promo id number</param>
        public void product_deletePromo(int promoID)
        => datos.product_deletePromo(promoID);

        public double supplier_getcost(int ID, string barcode)
        {
            return datos.supplier_getCost(ID, barcode);
        }

        /// <summary>
        /// Registers a new promo in the database
        /// </summary>
        /// <param name="data">table storing the barcodes and amount for each product in the promo</param>
        /// <param name="promoCost">cost of the promo</param>
        public void product_newPromo(DataTable data, double promoCost)
        => datos.product_newPromo(data, promoCost);

        public DataSet GetProductCostComparison(string barcode)
        {
            return datos.GetProductCostComparison(barcode);
        }

        /// <summary>
        /// Updates the group of mixable selling products as stablished in the given table
        /// </summary>
        /// <param name="groupID">ID number of the group to be updated</param>
        /// <param name="productBarcodelist">List of barcodes to be added to the group</param>
        public void product_updateGroup(int groupID, DataTable productBarcodelist)
        => datos.product_updateGroup(groupID, productBarcodelist);

        /// <summary>
        /// deletes the group of mixable selling products
        /// </summary>
        /// <param name="groupID">ID number of the group to be deleted</param>
        public void product_deleteGroup(int groupID)
        => datos.product_deleteGroup(groupID);


            /// <summary>
            /// get the product list that make up the given group ID
            /// </summary>
            /// <param name="groupID">ID number of the desired group</param>
            /// <returns></returns>
            public DataTable product_getMixedSaleGroupInfo(int groupID) =>
        datos.product_getMixedSaleGroupInfo(groupID);

        public DataTable Product_BestSellProductsTable(DateTime date, int periodOfTime) =>
        this.datos.Product_BestSellProductsTable(date, periodOfTime);

        public DataTable Product_GetScrapTable(DateTime date, int periodOfTime) =>
            this.datos.Product_GetScrapTable(date, periodOfTime);

        public DataTable product_ProductStatistics(string barcode, int periodOfTimeValue, DateTime date) =>
            this.datos.product_ProductStatistics(barcode, periodOfTimeValue, date);

        /// <summary>
        /// Looks for a group of products' ID which are permitted to be sell together to form a case searching 
        /// by the barcode of one of the member products of that group
        /// </summary>
        /// <param name="Barcode">barcode of one of the members that make up the group of products</param>
        /// <returns></returns>
        public int product_findSellCaseByMixedProductsGroup(string Barcode) =>
            datos.product_findSellCaseByMixedProductsGroup(Barcode);


        public DataTable ProductGetDepots() =>
        this.datos.ProductGetDepots();

        public void purchasesDelete(int PO_ID)
        {
            this.datos.purchasesDelete(PO_ID);
        }

        public DataSet purchasesGetPO(int PO_ID) =>
            this.datos.purchasesGetPO(PO_ID);

        public DataTable PurchasesGetPODetails(int po_id) =>
            this.datos.PurchasesGetPODetails(po_id);

        public DataTable PurchasesGetPOs(DateTime date)
        {
            DataSet set = this.datos.PurchasesGetPOs(date);
            DataTable table = new DataTable();
            table = set.Tables[0];
            table.Merge(set.Tables[1]);
            return table;
        }

        public void purchasesPay(int PO_ID, double payment, int employeeID)
        {
            this.datos.purchasesPay(PO_ID, payment, employeeID);
        }

        public DataTable PurchasesSearchByCoincidence(string search) =>
            this.datos.PurchasesSearchByCoincidence(search);

        public void purchasesUpdateDeliveryStatus(int POID, bool delivered, int employeeID)
        {
            this.datos.purchasesUpdateDeliveryStatus(POID, delivered, employeeID);
        }

        public void purchasesUpdatePOProductQuantity(int poID, string barcode, double quantity)
        {
            this.datos.purchasesUpdatePOProductQuantity(poID, barcode, quantity);
        }

        public void purchasesUpdatePOTotal(int poID, double total)
        {
            this.datos.purchasesUpdatePOTotal(poID, total);
        }

        public bool RegisteredPrice(int CustomerID, string Barcode, double minAmount, bool sellByCase) =>
            this.datos.RegisteredPrice(CustomerID, Barcode, minAmount, sellByCase);

        public void RegisterPayment(int Customer_ID, int PurchaseID, DateTime DateAndTime, double cash, int employeeID)
        {
            this.datos.RegisterPayment(Customer_ID, DateAndTime, PurchaseID, cash, employeeID);
        }

        public int[] Reminder_getReminderIDsForDate(DateTime date)
        {
            List<int> list = new List<int>();
            int dayofWeek = 0;
            switch (date.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                    dayofWeek = 1;
                    break;

                case DayOfWeek.Monday:
                    dayofWeek = 2;
                    break;

                case DayOfWeek.Tuesday:
                    dayofWeek = 3;
                    break;

                case DayOfWeek.Wednesday:
                    dayofWeek = 4;
                    break;

                case DayOfWeek.Thursday:
                    dayofWeek = 5;
                    break;

                case DayOfWeek.Friday:
                    dayofWeek = 6;
                    break;

                case DayOfWeek.Saturday:
                    dayofWeek = 7;
                    break;

                default:
                    break;
            }
            foreach (DataRow row in this.datos.Reminder_getReminderIDsForDate(date, dayofWeek).Rows)
            {
                list.Add(Convert.ToInt32(row["ID_Recordatorio"]));
            }
            return list.ToArray();
        }

        public DataTable Reminder_getUnseenReminders()
        {
            int dayOfTheWeek = ((int)DateTime.Now.DayOfWeek) + 1;
            return this.datos.Reminder_getUnseenReminders(dayOfTheWeek);
        }

        public DataTable Reminder_initialize(int reminderID) =>
            this.datos.Reminder_initialize(reminderID);

        public void reminder_MarkAsSeen(int reminderID)
        {
            this.datos.reminder_MarkAsSeen(reminderID);
        }

        public void Reminder_reset()
        {
            this.datos.Reminder_reset();
        }

        public void Sale_Cancel(int saleID, int employeeID)
        {
            this.datos.Sale_Cancel(saleID, employeeID);
        }

        public bool Sale_doesPurchaseExist(int saleID) =>
            (this.datos.Sale_find(saleID).Rows.Count == 1);

        public DataTable Sale_find(int SaleID) =>
            this.datos.Sale_find(SaleID);

        public int Sale_getLastSaleID() =>
            this.datos.Sale_getLastSaleID();

        public DataSet Sale_Initialize(int saleID) =>
            this.datos.Sale_Initialize(saleID);

        public DataTable Sale_InvestmentSellsProfit(int periodOfTimeValue, DateTime date) =>
            this.datos.Sale_InvestmentSellsProfit(periodOfTimeValue, date);

        public int Sale_newSale(int EmployeeID, int CustomerID, double total, double payment, Tuple<string,double, double, double,int>[] ListofProducts, double cash)
        {
            DataTable listOfProducts = new DataTable();
            DataColumn[] columns = new DataColumn[] { new DataColumn("barcode"), new DataColumn("cost"), new DataColumn("amount"), new DataColumn("discount"),new DataColumn ( "No.") ,new DataColumn("depotID")};
            listOfProducts.Columns.AddRange(columns);
            if (ListofProducts != null)
            {
                int i = 1;
                foreach (var product in ListofProducts)
                {
                    DataRow row = listOfProducts.NewRow();
                    row[0] = product.Item1;
                    row[1] = product.Item2;
                    row[2] = product.Item3;
                    row[3] = product.Item4;
                    listOfProducts.Rows.Add(row);
                    row[4] = i++;
                    row[5] = product.Item5;
                }
            }
            return this.datos.Sale_newSale(DateTime.Now, EmployeeID, CustomerID, total, payment, listOfProducts, cash);
        }

        public void Sale_ReturnPackage(int saleID, string barcode, decimal Amount, int employeeID)
        {
            this.datos.Sale_ReturnPackage(saleID, barcode, Amount, employeeID);
        }

        public DataTable SearchCustomer(string search) =>
            this.datos.SearchCustomer(search);

        public DataTable SearchProduct(string CodigoBarra) =>
            this.datos.SearchProduct(CodigoBarra);

        public DataTable SearchProductByCoincidence(string text) =>
            this.datos.SearchProductByCoincidence(text);

        public DataTable SearchValue(string Search) =>
            this.datos.SearchValue(Search);

        public void shift_AddCashToDrawer(int employeeID, double cash)
        {
            this.datos.shift_AddCashToDrawer(employeeID, cash);
        }

        public DataTable Shift_End(int employeeID) =>
            this.datos.Shift_End(employeeID);

        public DataTable shift_getMoneyAddedToDrawer() =>
            this.datos.shift_getMoneyAddedToDrawer();

        public DateTime Shift_getStartingDate() =>
            Convert.ToDateTime(this.datos.Shift_getStartingDate()["Inicio de Turno"]);

        public bool Shift_isActive()
        {
            DataTable table = this.datos.Shift_isActive();
            return ((table.Rows.Count == 1) && Convert.ToBoolean(table.Rows[0]["Turno Activo"]));
        }

        public void Shift_start(DateTime startTime, decimal initialCash, int employeeID)
        {
            this.datos.Shift_start(startTime, initialCash, employeeID);
        }

        public int SupplierAdd(string Name, double debt) =>
            this.datos.SupplierAdd(Name, debt);

        public void SupplierAddPODetails(int PO_ID, string barcode, double quantity, double PiecesperCase, double UnitaryCost, double Total)
        {
            this.datos.SupplierAddPODetails(PO_ID, barcode, quantity, PiecesperCase, UnitaryCost, Total);
        }

        public void SupplierAddProduct(int SupplierID, string Barcode, double PurchasePrice, double pieces)
        {
            this.datos.SupplierAddProduct(SupplierID, Barcode, PurchasePrice, pieces);
        }

        public void SupplierDeleteProduct(int SupplierID, string Barcode)
        {
            this.datos.SupplierDeleteProduct(SupplierID, Barcode);
        }

        public void SupplierDeletePromo(int PromoID)
        {
            this.datos.SupplierDeletePromo(PromoID);
        }

        public void SupplierEditProduct(int SupplierID, string Barcode, double NewPrice, double piecesPerCase)
        {
            this.datos.SupplierEditProduct(SupplierID, Barcode, NewPrice, piecesPerCase);
        }

        internal DataTable Supplier_SearchValueGetTable(string text, int ID)
        => datos.Supplier_SearchValueGetTable(text, ID);
        public DataTable SupplierFilterProducts(string search, int supplierID) =>
            this.datos.SupplierFilterProducts(search, supplierID);

        public int SupplierGeneratePO(int SupplierID, int EmployeeID, DateTime arrivalDate, DateTime paymentDueDate, double total, double Payment) =>
            this.datos.SupplierGeneratePO(SupplierID, EmployeeID, arrivalDate, paymentDueDate, total, Payment);

        public DataTable SupplierGetQuantitiesAndDates(int SupplierID) =>
            this.datos.SupplierGetQuantitiesAndDates(SupplierID);

        public DataTable SupplierGetSales(int SupplierID) =>
            this.datos.SupplierGetPromos(SupplierID);

        public void SupplierPromoAdd(int supplierID, string Barcode, double cost, double quantity, DateTime startDate, DateTime endDate, string notes)
        {
            this.datos.SupplierPromoAdd(supplierID, Barcode, cost, quantity, startDate, endDate, notes);
        }

        public bool SupplierPromoCorroborateExistenceOfSimilarPromo(int supplierId, int Promoid, string barcode, double quant)
        {
            DataTable table = new DataTable();
            return (this.datos.SupplierPromoCorroborateExistenceOfSimilarPromo(supplierId, Promoid, barcode, quant).Rows.Count > 0);
        }

        public DataTable SupplierPromoGetByID(int PromoID) =>
            this.datos.SupplierPromoGetByID(PromoID);

        public void SupplierPromoUpdate(int promoID, double cost, double quantity, DateTime startDate, DateTime endDate, string notes)
        {
            this.datos.SupplierPromoUpdate(promoID, cost, quantity, startDate, endDate, notes);
        }

        public void SupplierUpdateBasicInformation(string name, string telephone, string Address, int SupplierID)
        {
            this.datos.SupplierUpdateBasicInformation(name, telephone, Address, SupplierID);
        }

        public void SupplierUpdateDebt(int supplierID, double newDebt)
        {
            this.datos.SupplierUpdateDebt(supplierID, newDebt);
        }

        public void SupplierUpdateQuantities(int SupplierID, string ProductID, double Quantity)
        {
            this.datos.SupplierUpdateQuantities(SupplierID, ProductID, Quantity);
        }

        public DataTable TicketPrinter_Initialize() =>
            this.datos.TicketPrinter_Initialize();

        public void UpdateCustomerInfo(string Name, string TelephoneNumber, string Address, int CustomerID, decimal discount, bool isPercentage, bool dontApplyAnyDiscount)
        {
            this.datos.UpdateCustomerInfo(Name, TelephoneNumber, Address, CustomerID, discount, isPercentage, dontApplyAnyDiscount);
        }

        public void UpdatePrice(int discount_ID, double Discount, bool isPercentage, double minAmount, bool SellByCases)
        {
            this.datos.UpdatePrice(discount_ID, Discount, isPercentage, minAmount, SellByCases);
        }

        public void UpdateReminder(int SupplierID, int ReminderID, DateTime startTime, DateTime endTime, bool[] repetitionDays, string message)
        {
            this.datos.UpdateReminder(SupplierID, ReminderID, startTime, endTime, repetitionDays, message);
        }

        public void UpdateStatus(string Status, int CustomerID)
        {
            this.datos.UpdateStatus(Status, CustomerID);
        }

        public void UpdateVisitingDays(string visitingDays, int SupplierID)
        {
            this.datos.UpdateVisitingDays(visitingDays, SupplierID);
        }

    }
}