using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Security.AccessControl;

namespace POS
{
    class Capa_de_Datos
    {
        private SqlConnection con;

        public void AddProduct(string Marca, string Descripcion, double PrecioMinoreo, double PrecioPorCaja, double PiezasPorCaja, double PreciodeCompra, double Stock, double minStock, byte[] Foto, string CodigoBarras, int depotID, string mainProductBarcode, bool isReturnable, bool displayAsKg, bool HideInTicket)
        {
            SqlCommand command = new SqlCommand("AddProduct", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@Code", CodigoBarras);
            command.Parameters.AddWithValue("@Name", Descripcion);
            command.Parameters.AddWithValue("@Brand", Marca);
            command.Parameters.AddWithValue("@RetailPrice", PrecioMinoreo);
            command.Parameters.AddWithValue("@BoxPrice", PrecioPorCaja);
            command.Parameters.AddWithValue("@PiecesBox", PiezasPorCaja);
            command.Parameters.AddWithValue("@PurchaseCost", PreciodeCompra);
            command.Parameters.AddWithValue("@Stock", Stock);
            command.Parameters.AddWithValue("@minStock", minStock);
            command.Parameters.AddWithValue("@Photo", Foto);
            command.Parameters.AddWithValue("@depotID", depotID);
            command.Parameters.AddWithValue("@MainProductBarcode", mainProductBarcode);
            command.Parameters.AddWithValue("@isReturnable", isReturnable);
            command.Parameters.AddWithValue("@displayAsKilogram", displayAsKg);
            command.Parameters.AddWithValue("@HideInTicket", HideInTicket);
            command.ExecuteNonQuery();
            this.CloseSqlConnection();
        }

        public DataTable Product_getWholeSaleCosts(string barcode)
        {
            SqlCommand command = new SqlCommand("Product_GetWholeSaleCosts", OpenSqlConnection()) { CommandType = CommandType.StoredProcedure };

            DataTable dt = new DataTable();


            command.Parameters.AddWithValue("@barcode", barcode);

            dt.Load(command.ExecuteReader());

            CloseSqlConnection();

            return dt;
            
        }

        public DataTable GetSupplierList(string text)
        {
            SqlCommand com = new SqlCommand("Supplier_FindSupplierByCoincidence", OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure
            };

            DataTable dt = new DataTable();

            com.Parameters.AddWithValue("@text", text);

            dt.Load(com.ExecuteReader());

            CloseSqlConnection();

            return dt;
        }

        public void addReminder(int SupplierID, DateTime startTime, DateTime endTime, bool[] repetitionDays, string message, bool canDelete)
        {
            SqlCommand command = new SqlCommand("Reminder_AddReminder", this.OpenSqlConnection());
            string str = "";
            for (int i = 0; i < repetitionDays.Length; i++)
            {
                str = repetitionDays[i] ? (str + "1") : (str + "0");
            }
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@supplierID", SupplierID);
            command.Parameters.AddWithValue("@StartingDate", startTime.Date);
            command.Parameters.AddWithValue("@startingTime", startTime.TimeOfDay);
            command.Parameters.AddWithValue("@endingDate", endTime.Date);
            command.Parameters.AddWithValue("@endingTime", endTime.TimeOfDay);
            command.Parameters.AddWithValue("@repetitionDays", str);
            command.Parameters.AddWithValue("@message", message);
            command.Parameters.AddWithValue("@canDelete", canDelete);
            command.ExecuteNonQuery();
            this.CloseSqlConnection();
        }

        public void product_deleteWholeSaleCost(int wholeSaleCostId, string barcode)
        {
            SqlCommand command = new SqlCommand("product_deleteWholesaleCost", OpenSqlConnection()) { CommandType = CommandType.StoredProcedure };
            command.Parameters.AddWithValue("@wholecostID", wholeSaleCostId);
            command.Parameters.AddWithValue("@barcode", barcode);
            command.ExecuteNonQuery();
            CloseSqlConnection();

        }

        public DataTable Products_getWrongProducts()
        {
            SqlCommand command = new SqlCommand("products_CheckProductsToFix", OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure,
                CommandTimeout = 120
            };

            DataTable dt = new DataTable();

            dt.Load(command.ExecuteReader());

            CloseSqlConnection();
            return dt;
        }

        public DataTable Sale_getUnfinishedSalesIDs()
        {
            SqlCommand com = new SqlCommand("Sale_GetUnfinishedSellIDs", OpenSqlConnection());
            com.CommandType = CommandType.StoredProcedure;

            DataTable dt = new DataTable();
            dt.Load(com.ExecuteReader());
            CloseSqlConnection();
            return dt;
        }

        public DataTable Supplier_searchForNewProduct(string text, int iD)
        {
            SqlCommand com = new SqlCommand("suplier_searchForNewProduct", OpenSqlConnection())
            {
                CommandType= CommandType.StoredProcedure,
                CommandTimeout=120
            };

            DataTable dt = new DataTable();

            com.Parameters.AddWithValue("@value", text);
            com.Parameters.AddWithValue("@SupplierId", iD);

            dt.Load(com.ExecuteReader());

            CloseSqlConnection();

            return dt;

        }

        public void Product_UpdateWholesaleCost(string barcode, int costID, double discount, bool isByPercentage)
        {
            SqlCommand command = new SqlCommand("product_updateWholesaleCost", OpenSqlConnection()) { CommandType = CommandType.StoredProcedure };

            command.Parameters.AddWithValue("@costID", costID);
            command.Parameters.AddWithValue("@barcode", barcode);
            command.Parameters.AddWithValue("@newCost", discount);
            command.Parameters.AddWithValue("@isByPercentage", isByPercentage);

            command.ExecuteNonQuery();
            CloseSqlConnection();
        }

        public void Product_addNewWholeSaleCost(double amount, double discount, bool isPercentage, string barcode)
        {
            SqlCommand command = new SqlCommand("Product_AddNewWholesaleCost", OpenSqlConnection()) { CommandType = CommandType.StoredProcedure };
            command.Parameters.AddWithValue("@barcode", barcode);
            command.Parameters.AddWithValue("@amount", amount);
            command.Parameters.AddWithValue("@discount", discount);
            command.Parameters.AddWithValue("@isdicount", isPercentage);

            command.ExecuteNonQuery();
            CloseSqlConnection();
        }

        private void CloseSqlConnection()
        {
            this.con.Close();
        }

        public List<object> convertReader(SqlDataReader reader)
        {
            List<object> list = new List<object>();
            while (!reader.Read())
            {
                for (int i = 0; i < 9; i++)
                {
                    list.Add(reader[i].ToString());
                }
            }
            return list;
        }

        public void employee_Delete(int iD)
        {
            SqlCommand com = new SqlCommand("employee_Delete", OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure
            };

            com.Parameters.AddWithValue("@employeeID", iD);

            com.ExecuteNonQuery();
            CloseSqlConnection();

        }

        public DataTable Customer_GetAcountsReceivable(int customerID)
        {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("Customer_GetAcountsReceivable", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@customerID", customerID);
            table.Load(command.ExecuteReader());
            this.CloseSqlConnection();
            return table;
        }

        public void deleteCustomerPrice(int disountID)
        {
            SqlCommand command = new SqlCommand("deleteCustomerPrice", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@discountID", disountID);
            command.ExecuteNonQuery();
            this.CloseSqlConnection();
        }

        public void DeleteProduct(string BarCode)
        {
            SqlCommand command = new SqlCommand("DeleteProduct", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@code", BarCode);
            command.ExecuteNonQuery();
            this.CloseSqlConnection();
        }

        public DataTable Sale_getReurnableProducts(int saleID)
        {
            DataTable dt = new DataTable();
            SqlCommand com = new SqlCommand("Sale_getPendingReturnablePackagesfromSale", OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure
            };

            com.Parameters.AddWithValue("@saleID", saleID);

            dt.Load(com.ExecuteReader());

                CloseSqlConnection();

            return dt;            
        }

        public DataTable getInfoUnfinishedSell(int savedWindowID, int newWindowID)
        {
            SqlCommand com = new SqlCommand("Sale_GetUnfinishedSellInfo", OpenSqlConnection());
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@windowID", savedWindowID);
            com.Parameters.AddWithValue("@newWindowID", newWindowID);

            DataTable dt = new DataTable();

            dt.Load(com.ExecuteReader());

            CloseSqlConnection();
            return dt;
        }

        public void customer_Delete(int iD)
        {
            SqlCommand com = new SqlCommand("customer_delete", OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure,
                CommandTimeout = 120
            };

            com.Parameters.AddWithValue("@customerID", iD);

            com.ExecuteNonQuery();
            CloseSqlConnection();
        }

        public int customer_matchwithEmployee(int iD)
        {
            SqlCommand com = new SqlCommand("customer_matchWithEmployee", OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure,
                CommandTimeout = 120
            };

            com.Parameters.AddWithValue("@customerID", iD);

            object result = com.ExecuteScalar();
            CloseSqlConnection();

            return result == null ? -1 : (int)result;
        }

        public void deleteReminder(int reminderID)
        {
            SqlCommand command = new SqlCommand("ReminderDelete", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@reminderID", reminderID);
            command.ExecuteNonQuery();
            this.CloseSqlConnection();
        }

        public DataTable depot_everyDepotID()
        {
            DataTable table = new DataTable();
            table.Load(new SqlCommand("depot_GetAllDepotsID", this.OpenSqlConnection()) { CommandType = CommandType.StoredProcedure }.ExecuteReader());
            this.CloseSqlConnection();
            return table;
        }

        public void Depot_Rename(int depotID, string name)
        {
            SqlCommand command = new SqlCommand("depot_Rename", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@depotID", depotID);
            command.Parameters.AddWithValue("@newName", name);
            command.ExecuteNonQuery();
            this.CloseSqlConnection();
        }

        public void depot_UpdateShowInProductSearches(bool show, int depotid)
        {
            SqlCommand command = new SqlCommand("depot_UpdateShowInProductSearches", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@show", show);
            command.Parameters.AddWithValue("@depotID", depotid);
            command.ExecuteNonQuery();
            this.CloseSqlConnection();
        }

        public void Sale_RefoundProductsToCustomer(int iD, DataTable barcodesToBeRefounded)
        {
            SqlCommand command = new SqlCommand("sale_RefoundSomeProducts", OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure,
                CommandTimeout=120
            };
            command.Parameters.AddWithValue("@saleID", iD);
            command.Parameters.AddWithValue("@products", barcodesToBeRefounded);

            command.ExecuteNonQuery();
            CloseSqlConnection();
        
        }

        internal DataSet getNextSaleID(int ID)
        {
            SqlCommand com = new SqlCommand("sale_getNextAndPreviousTicket", OpenSqlConnection()) { CommandType = CommandType.StoredProcedure };
            com.Parameters.AddWithValue("@saleID", ID);
            
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            DataSet ds = new DataSet();

            adapter.Fill(ds);

            CloseSqlConnection();
            return ds;
        }

        /// <summary>
        /// Updates the check status of each product in the depot to be displayed as indicated in the info table the next time 
        /// the user want to check the missing products list
        /// </summary>
        /// <param name="depotID">Depot ID</param>
        /// <param name="info">Table containing the barcode and its check status</param>
        public void depot_updateProductCheckStatus(int  depotID, string barcode)
        {
            SqlCommand com = new SqlCommand("depot_updateProductCheckStatus", OpenSqlConnection())
            { CommandType = CommandType.StoredProcedure };

            com.Parameters.AddWithValue("@depotID", depotID);
            com.Parameters.AddWithValue("@barcode", barcode);

            com.ExecuteNonQuery();

            CloseSqlConnection();
        }


        public void DepotDelete(int DepotID)
        {
            SqlCommand command = new SqlCommand("[depot_delete]", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure,
                CommandTimeout = 180
            };
            command.Parameters.AddWithValue("@depotID", DepotID);
            command.ExecuteNonQuery();
            this.CloseSqlConnection();
        }

        public DataTable DepotGetInventory()
        {
            DataTable data = new DataTable();
            SqlCommand selectCommand = new SqlCommand("Depot_GetInventory", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure,
                CommandTimeout= 180
            };
            data.Load(selectCommand.ExecuteReader());
            CloseSqlConnection();
            return data;
        }

        public DataTable DepotGetInventory(string text)
        {
            DataTable data = new DataTable();
            SqlCommand selectCommand = new SqlCommand("[Depot_FilterInventory]", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure,
                CommandTimeout = 180
            };

            selectCommand.Parameters.AddWithValue("@text", text);
            data.Load(selectCommand.ExecuteReader());
            this.CloseSqlConnection();
            return data;
        }

        public int DepotNewDepot(string name)
        {
            SqlCommand command = new SqlCommand("Product_NewDepot", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure,
                CommandTimeout =   180
            };
            command.Parameters.AddWithValue("@name", name);
            object obj2 = command.ExecuteScalar();
            int num = Convert.ToInt32((obj2 == DBNull.Value) ? null : obj2);
            this.CloseSqlConnection();
            return num;
        }

        public void Supplier_delete(int supplierID)
        {
            SqlCommand com = new SqlCommand("Supplier_delete", OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure
            };

            com.Parameters.AddWithValue("@supplierID", supplierID);
            com.ExecuteNonQuery();
            CloseSqlConnection();
        }

        public DataTable Supplier_getPurchaseStatistics(int iD, DateTime date, Proveedor.PeriodOfTime mode)
        {
            SqlCommand com = new SqlCommand("Supplier_PurchaseStatistics", OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure,
                CommandTimeout=120
            };

            com.Parameters.AddWithValue("@supplierID", iD);
            com.Parameters.AddWithValue("@periodOfTime", mode);
            com.Parameters.AddWithValue("@date", date);

            DataTable data = new DataTable();
            data.Load(com.ExecuteReader());

            CloseSqlConnection();
            return data;
        }

        public void depotScrap(int depotID, int employeeID, string barcode, double quantity)
        {
            SqlCommand command = new SqlCommand("depot_Scrap", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@barcode", barcode);
            command.Parameters.AddWithValue("@quantity", quantity);
            command.Parameters.AddWithValue("@employeeID", employeeID);
            command.Parameters.AddWithValue("@depotID", depotID);
            command.ExecuteNonQuery();
            this.CloseSqlConnection();
        }

        public DataTable Supplier_getProductInfo(int iD, string barcode)
        {
            SqlCommand command = new SqlCommand("supplier_GetProductInfo", OpenSqlConnection()) { CommandType = CommandType.StoredProcedure };

            command.Parameters.AddWithValue("@barcode", barcode);
            command.Parameters.AddWithValue("@supplierID", iD);

            DataTable dt = new DataTable();
            dt.Load(command.ExecuteReader());

            CloseSqlConnection();
            return dt;
        }

        public DataTable DepotSetDepot(int depotID)
        {
            DataTable data = new DataTable();
            SqlCommand selectCommand = new SqlCommand("Depot_Initialize", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure
            };
            selectCommand.Parameters.AddWithValue("@depotID", depotID);
            data.Load(selectCommand.ExecuteReader());
            this.CloseSqlConnection();
            return data;
        }

        public DataTable Depot_GetWholeInventory(int depotID)
        {
            DataTable dt = new DataTable();
            SqlCommand com = new SqlCommand("Depot_GetWholeInventory", OpenSqlConnection()) { CommandType = CommandType.StoredProcedure, CommandTimeout = 90 };

            com.Parameters.AddWithValue("@depotID", depotID);

            dt.Load(com.ExecuteReader());

            CloseSqlConnection();

            return dt;
        }

        public DataTable Depot_GetInventoryForProduct(int depotID, string barcode)
        {
            DataTable dt = new DataTable();
            SqlCommand com = new SqlCommand("Depot_getInvoentoryForProduct", OpenSqlConnection()) { CommandType = CommandType.StoredProcedure };

            com.Parameters.AddWithValue("@depotID", depotID);
            com.Parameters.AddWithValue("@barcode", barcode);

            dt.Load(com.ExecuteReader());

            CloseSqlConnection();

            return dt;
        }

        public void DepotUpdateMinStockQuantity(int depotID, string barcode, double minStock, double maxStock)
        {
            SqlCommand command = new SqlCommand("[depot_UpdateMinStockQuantity]", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@depotID", depotID);
            command.Parameters.AddWithValue("@barcode", barcode);
            command.Parameters.AddWithValue("@minStock", minStock);
            command.Parameters.AddWithValue("@maxStock", maxStock);
            command.ExecuteNonQuery();
            this.CloseSqlConnection();
        }

        public void DepotUpdateProductQuantity(int depotID, string barcode, double newQuant)
        {
            SqlCommand command = new SqlCommand("Depot_UpdateProductQuantity", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@id_Depot", depotID);
            command.Parameters.AddWithValue("@barcode", barcode);
            command.Parameters.AddWithValue("@quantity", newQuant);
            command.ExecuteNonQuery();
            this.CloseSqlConnection();
        }

        public void EditProduct(string Marca, string Descripcion, double PrecioMinoreo, double PrecioPorCaja, double PiezasPorCaja, double preciodeCompra, double Stock, double minStock, byte[] Foto, string NuevoCodigoBarras, string CodigoBarras, int depotID, string mainProductBarcode, bool isReturnable, bool displayAsKg, bool hideInTicket)
        {
            SqlCommand command = new SqlCommand("EditProduct", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@CurrentCode", CodigoBarras);
            command.Parameters.AddWithValue("@NewCode", NuevoCodigoBarras);
            command.Parameters.AddWithValue("@Name", Descripcion);
            command.Parameters.AddWithValue("@Brand", Marca);
            command.Parameters.AddWithValue("@RetailPrice", PrecioMinoreo);
            command.Parameters.AddWithValue("@BoxPrice", PrecioPorCaja);
            command.Parameters.AddWithValue("@PiecesBox", PiezasPorCaja);
            command.Parameters.AddWithValue("@purchaseCost", preciodeCompra);
            command.Parameters.AddWithValue("@Stock", Stock);
            command.Parameters.AddWithValue("@MinStock", minStock);
            command.Parameters.AddWithValue("@Photo", Foto);
            command.Parameters.AddWithValue("@defaltDepotID", depotID);
            command.Parameters.AddWithValue("@mainProductBarcode", mainProductBarcode);
            command.Parameters.AddWithValue("@isReturnable", isReturnable);
            command.Parameters.AddWithValue("@displayAsKg", displayAsKg);
            command.Parameters.AddWithValue("@hideInTicket", hideInTicket);
            command.ExecuteNonQuery();
            this.CloseSqlConnection();
        }

        internal DataTable Depot_getMissingProducts(int iD)
        {
            SqlCommand com = new SqlCommand("Depot_MissingProducts", OpenSqlConnection())
            {
                CommandType= CommandType.StoredProcedure
            };

            com.Parameters.AddWithValue("@depotID", iD);

            DataTable dt = new DataTable();
            dt.Load(com.ExecuteReader());
            CloseSqlConnection();
            return dt;
        }

        public DataSet GetProductCostComparison(string barcode)
        {
            DataSet ds = new DataSet();
            SqlCommand com = new SqlCommand("suppliert_CompareCosts", OpenSqlConnection()) { CommandType= CommandType.StoredProcedure};
            com.Parameters.AddWithValue("@barcode", barcode);

            new SqlDataAdapter() { SelectCommand = com }.Fill(ds);

            CloseSqlConnection();
            return ds;
        }

        internal double supplier_getCost(int iD, string barcode)
        {
            SqlCommand com = new SqlCommand("supplier_GetCost", OpenSqlConnection()) { CommandType = CommandType.StoredProcedure };
            com.Parameters.AddWithValue("@barcode", barcode);
            com.Parameters.AddWithValue("@supplierID", iD);

            var result = com.ExecuteScalar();

            CloseSqlConnection();


            return Convert.ToDouble(result);
        }

        public void Employee_changePassword(int employeeID, string newPassword)
        {
            SqlCommand command = new SqlCommand("employee_changePassword", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@employeeID", employeeID);
            command.Parameters.AddWithValue("@newPassword", newPassword);
            command.ExecuteNonQuery();
            this.CloseSqlConnection();
        }

        public DataTable Employee_getListOfEmployees()
        {
            DataTable table = new DataTable();
            table.Load(new SqlCommand("Employee_getListofEmployees", this.OpenSqlConnection()) { CommandType = CommandType.StoredProcedure }.ExecuteReader());
            this.CloseSqlConnection();
            return table;
        }

        public DataTable Employee_Initialize(int employeeID)
        {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("Employee_Initialize", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@employeeID", employeeID);
            table.Load(command.ExecuteReader());
            this.CloseSqlConnection();
            return table;
        }

        public int employee_Login(string user, string password)
        {
            SqlCommand command = new SqlCommand("dbo.Employee_Login", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@user", user);
            command.Parameters.AddWithValue("@pass", password);
            object obj2 = command.ExecuteScalar();
            int num = (obj2 == null) ? -1 : Convert.ToInt32(obj2);
            this.CloseSqlConnection();
            return num;
        }

        public bool Employee_nameExist(string name)
        {
            DataSet dataSet = new DataSet();
            SqlCommand selectCommand = new SqlCommand("employee_nameExist", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure
            };
            selectCommand.Parameters.AddWithValue("@name", name);
            new SqlDataAdapter(selectCommand).Fill(dataSet);
            bool flag = false;
            foreach (DataTable table in dataSet.Tables)
            {
                if (table.Rows.Count > 0)
                {
                    flag = true;
                    break;
                }
            }
            this.CloseSqlConnection();
            return flag;
        }

        public int Employee_new(string name, string userName, bool isAdmin)
        {
            SqlCommand command = new SqlCommand("employee_newEmployee", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@username", userName);
            command.Parameters.AddWithValue("@isAdmin", isAdmin);
            object obj2 = command.ExecuteScalar();
            int num = (obj2 == null) ? -1 : Convert.ToInt32(obj2);
            this.CloseSqlConnection();
            return num;
        }

        public void Employee_paySalary(int employeeID)
        {
            SqlCommand command = new SqlCommand("employee_PaySalary", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@employeeID", employeeID);
            command.ExecuteNonQuery();
            this.CloseSqlConnection();
        }

        public DataTable Employee_search(string name)
        {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("Employee_findCoincidence", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@text", name);
            table.Load(command.ExecuteReader());
            this.CloseSqlConnection();
            return table;
        }

        public void Employee_UpdateAddress(string newAddress, int employeeId)
        {
            SqlCommand command = new SqlCommand("employee_UpdateAddress", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@employeeID", employeeId);
            command.Parameters.AddWithValue("@newAddress", newAddress);
            command.ExecuteNonQuery();
            this.CloseSqlConnection();
        }

        public void Employee_UpdateDateOfBirth(DateTime newDate, int employeeID)
        {
            SqlCommand command = new SqlCommand("employee_UpdateDateOfBith", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@employeeID", employeeID);
            command.Parameters.AddWithValue("@newDate", newDate);
            command.ExecuteNonQuery();
            this.CloseSqlConnection();
        }

        public void Employee_UpdateDiscount(int employeeID, double discount, bool isPercentage)
        {
            SqlCommand command = new SqlCommand("Employee_updateDiscount", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@employeeID", employeeID);
            command.Parameters.AddWithValue("@discount", discount);
            command.Parameters.AddWithValue("@isPercentage", isPercentage);
            command.ExecuteNonQuery();
            this.CloseSqlConnection();
        }

        public void Employee_UpdateHirementDate(DateTime newDate, int employeeID)
        {
            SqlCommand command = new SqlCommand("employee_UpdateHirementDate", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@employeeID", employeeID);
            command.Parameters.AddWithValue("@newDate", newDate);
            command.ExecuteNonQuery();
            this.CloseSqlConnection();
        }

        public void Employee_UpdateName(string newName, int employeeID)
        {
            SqlCommand command = new SqlCommand("employee_UpdateName", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@employeeID", employeeID);
            command.Parameters.AddWithValue("@newName", newName);
            command.ExecuteNonQuery();
            this.CloseSqlConnection();
        }

        public void Employee_updatePaymentDay(string paymentDays, int employeeID)
        {
            SqlCommand command = new SqlCommand("employee_UpdatePaymentDay", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@employeeID", employeeID);
            command.Parameters.AddWithValue("@newValue", paymentDays);
            command.ExecuteNonQuery();
            this.CloseSqlConnection();
        }

        public void Employee_UpdatePhone(string newPhone, int employeeID)
        {
            SqlCommand command = new SqlCommand("employee_UpdatePhone", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@employeeID", employeeID);
            command.Parameters.AddWithValue("@newPhone", newPhone);
            command.ExecuteNonQuery();
            this.CloseSqlConnection();
        }

        public void Employee_UpdatePosition(bool isAdmin, int employeeID)
        {
            SqlCommand command = new SqlCommand("Employee_updatePosition", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@employeeId", employeeID);
            command.Parameters.AddWithValue("@isAdmin", isAdmin);
            command.ExecuteNonQuery();
            this.CloseSqlConnection();
        }

        public void Employee_UpdateSalary(double newSalary, int employeeID)
        {
            SqlCommand command = new SqlCommand("employee_UpdateSalary", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@employeeID", employeeID);
            command.Parameters.AddWithValue("@newSalary", newSalary);
            command.ExecuteNonQuery();
            this.CloseSqlConnection();
        }

        public bool Employee_userNameExist(string user)
        {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("employee_userNameExist", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@username", user);
            table.Load(command.ExecuteReader());
            bool flag = false;
            if (table.Rows.Count > 0)
            {
                flag = true;
            }
            this.CloseSqlConnection();
            return flag;
        }

        public DataTable fillTable(int offset, int fetchRows)
        {
            DataTable table = new DataTable();

            SqlCommand com = new SqlCommand("FillTable", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure,
            };


            com.Parameters.AddWithValue("@offset", offset);
            com.Parameters.AddWithValue("@fetch", fetchRows);

            table.Load(com.ExecuteReader());

            this.CloseSqlConnection();
            return table;
        }

        public DataTable filterSuppliers(string Search)
        {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SearchSupplierByCoincidence", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@search", Search);
            table.Load(command.ExecuteReader());
            this.CloseSqlConnection();
            return table;
        }

        internal DataTable Supplier_SearchValueGetTable(string text, int iD)
        {
            DataTable dt = new DataTable();
            SqlCommand com = new SqlCommand("findProductInSupplier", OpenSqlConnection()) { CommandType = CommandType.StoredProcedure };
            com.Parameters.AddWithValue("@value", text);
            com.Parameters.AddWithValue("@supplierID", iD);

            dt.Load(com.ExecuteReader());

            CloseSqlConnection();
            return dt;
        }

        public DataTable FindCustomer(string Name)
        {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("FindCustomer", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@Name", Name);
            table.Load(command.ExecuteReader());
            this.CloseSqlConnection();
            return table;
        }

        public DataSet FindCustomerbyID(int id)
        {
            SqlCommand selectCommand = new SqlCommand("findCustomerbyID", this.OpenSqlConnection());
            DataSet dataSet = new DataSet();
            selectCommand.CommandType = CommandType.StoredProcedure;
            selectCommand.Parameters.AddWithValue("@id", id);
            new SqlDataAdapter(selectCommand).Fill(dataSet);
            this.CloseSqlConnection();
            return dataSet;
        }

        public void FirsUsage(DateTime time)
        {
            SqlCommand command = new SqlCommand("FirstUsage", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@date", time);
            command.ExecuteNonQuery();
            this.CloseSqlConnection();
        }

        public DataTable getCustomerList()
        {
            DataTable table = new DataTable();
            table.Load(new SqlCommand("getCustomerList", this.OpenSqlConnection()) { CommandType = CommandType.StoredProcedure }.ExecuteReader());
            this.CloseSqlConnection();
            return table;
        }

        public List<string[]> GetCustomerPurchases(int ID)
        {
            DataTable table = new DataTable();
            List<string[]> list = new List<string[]>();
            SqlCommand command = new SqlCommand("GetSales", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@Customer_ID", ID);
            table.Load(command.ExecuteReader());
            foreach (DataRow row in table.Rows)
            {
                string[] item = new string[] { row["Hora"].ToString(), row["Numero de Ticket"].ToString(), row["Total"].ToString(), row["Abono"].ToString(), row["Estado de Pago"].ToString(), row["Fecha"].ToString().Substring(0, 10) };
                list.Add(item);
            }
            this.CloseSqlConnection();
            return list;
        }

        private void getINfo(object sender, SqlInfoMessageEventArgs e)
        {
            Console.WriteLine(e.Message);
        }

        public DataTable GetPOList(int SupplierID)
        {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SupplierGetPOs", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@SupplierID", SupplierID);
            table.Load(command.ExecuteReader());
            this.CloseSqlConnection();
            return table;
        }

        public DataTable GetPriceList(int Customer_ID)
        {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("GetPriceList", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@CustomerID", Customer_ID);
            table.Load(command.ExecuteReader());
            this.CloseSqlConnection();
            return table;
        }

        public DataTable getPurchase(int TicketNumber)
        {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("GetPurchase", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@TicketNumber", TicketNumber);
            table.Load(command.ExecuteReader());
            this.CloseSqlConnection();
            return table;
        }

        public DataTable getPurchaseChart(string CodigoBarras)
        {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("GetSellingProductData", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@Barcode", CodigoBarras);
            table.Load(command.ExecuteReader());
            this.CloseSqlConnection();
            return table;
        }

        public DataTable getPurchaseRecord(int Customer_ID)
        {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("GetCustomerPaymentRecord", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@customerID", Customer_ID);
            table.Load(command.ExecuteReader());
            this.CloseSqlConnection();
            return table;
        }

        public DataTable getReminders(int supplierId, DateTime date)
        {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("[ReminderGetRemindersIDsforADay]", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@supplierID", supplierId);
            command.Parameters.AddWithValue("@fecha", date.Date);
            table.Load(command.ExecuteReader());
            this.CloseSqlConnection();
            return table;
        }

        public DataTable GetSupplierData(int id)
        {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("getSupplierData", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@id", id);
            table.Load(command.ExecuteReader());
            this.CloseSqlConnection();
            return table;
        }

        public DataTable GetSupplierList()
        {
            DataTable table = new DataTable();
            table.Load(new SqlCommand("GetSuppliersList", this.OpenSqlConnection()) { CommandType = CommandType.StoredProcedure }.ExecuteReader());
            this.CloseSqlConnection();
            return table;
        }

        public DataTable getSupplierProductList(int supplierID)
        {
            DataTable table = new DataTable();
            SqlCommand com = new SqlCommand("GetSupplierProductList", OpenSqlConnection());
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@id", supplierID);

            table.Load(com.ExecuteReader());
            this.CloseSqlConnection();
            return table;
        }

        public DataTable getVisitingReminder(int SupplierId)
        {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("ReminderGetVisitingReminder", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@SupplierID", SupplierId);
            table.Load(command.ExecuteReader());
            this.CloseSqlConnection();
            return table;
        }

        public bool IsFirstUsageDateSet()
        {
            SqlCommand command = new SqlCommand("getFirstUsageDate", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure
            };
            DataTable table = new DataTable();
            table.Load(command.ExecuteReader());
            this.CloseSqlConnection();
            return (table.Rows.Count > 0);
        }

        public void NewCustomer(string Name, string TelephoneNumber, string Address, double debt, int id_employee)
        {
            SqlCommand command = new SqlCommand("AddNewCustomer", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@name", Name);
            command.Parameters.AddWithValue("@phone", TelephoneNumber);
            command.Parameters.AddWithValue("@address", Address);
            command.Parameters.AddWithValue("@debt", debt);
            object obj2 = command.ExecuteScalar();
            int customerID = Convert.ToInt32((obj2 == DBNull.Value) ? null : obj2);
            this.CloseSqlConnection();
            if (debt > 0.0)
            {
                DataTable listOfProducts = new DataTable();
                listOfProducts.Columns.Add("barcode");
                listOfProducts.Columns.Add("amount");
                listOfProducts.Columns.Add("cost");
                listOfProducts.Columns.Add("discount");
                listOfProducts.Columns.Add("No.");
                listOfProducts.Columns.Add("DepotID");
                this.Sale_newSale(DateTime.Now, id_employee, customerID, debt, 0.0, listOfProducts, 0.0);
            }
        }

        public void newPrice(int Customer_ID, string barcode, double discount, bool isPercentage, double MinAmount, bool sellByCase)
        {
            SqlCommand command = new SqlCommand("newPrice", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@CustomerID", Customer_ID);
            command.Parameters.AddWithValue("@barcode", barcode);
            command.Parameters.AddWithValue("@Discount", discount);
            command.Parameters.AddWithValue("@isPercentage", isPercentage);
            command.Parameters.AddWithValue("@minAmount", MinAmount);
            command.Parameters.AddWithValue("@sellByCase", sellByCase);
            command.ExecuteNonQuery();
            this.CloseSqlConnection();
        }

        private SqlConnection OpenSqlConnection()
        {
            this.con = new SqlConnection()
            {
                // ConnectionString = @"Data Source = localhost\SQLEXPRESS; Initial Catalog = C:\USERS\TIENDA\SOURCE\REPOS\POS\POS\DATA\FINALDB.MDF; Integrated Security = True"
                ConnectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=C:\USERS\TIENDA\SOURCE\REPOS\POS\POS\DATA\FINALDB.MDF;Integrated Security=True"
            };
           
            
            this.con.Open();
            this.con.InfoMessage += new SqlInfoMessageEventHandler(this.getINfo);
            return this.con;
        }

        public void Pay(double cash, int Customer_ID, int TicketNumber)
        {
            SqlCommand command = new SqlCommand("[Payment]", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@cash", cash);
            command.Parameters.AddWithValue("@customerID", Customer_ID);
            command.Parameters.AddWithValue("@ticketNumber", TicketNumber);
            command.ExecuteNonQuery();
            this.CloseSqlConnection();
        }

        public void Printer_saveConfiguration(string printerName, byte[] logo, int logoHeight, bool displayImage, string header, string headerFont, bool displayHeader, string address, string addressFont, bool displayaddress, string phone, string phoneFont, bool displayphone, string footer, string footerFont, bool displayfooter)
        {
            SqlCommand command = new SqlCommand("printer_saveConfiguration", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@printerName", printerName);
            command.Parameters.AddWithValue("@logo", logo);
            command.Parameters.AddWithValue("@logoHeight", logoHeight);
            command.Parameters.AddWithValue("@imageDisplay", displayImage);
            command.Parameters.AddWithValue("@header", header);
            command.Parameters.AddWithValue("@headerFont", headerFont);
            command.Parameters.AddWithValue("@headerDisplay", displayHeader);
            command.Parameters.AddWithValue("@address", address);
            command.Parameters.AddWithValue("@addressFont", addressFont);
            command.Parameters.AddWithValue("@addressDisplay", displayaddress);
            command.Parameters.AddWithValue("@phone", phone);
            command.Parameters.AddWithValue("@phoneFont", phoneFont);
            command.Parameters.AddWithValue("@phoneDisplay", displayphone);
            command.Parameters.AddWithValue("@footer", footer);
            command.Parameters.AddWithValue("@footerFont", footerFont);
            command.Parameters.AddWithValue("@footerDisplay", displayfooter);
            command.ExecuteNonQuery();
            this.CloseSqlConnection();
        }

        /// <summary>
        /// creates a new group of mixable selling products and add products the given product to the group
        /// </summary>
        /// <param name="productBarcodelist">List of barcodes to be added to the group</param>
        public void product_createNewGroup(DataTable productBarcodelist)
        {
            SqlCommand com = new SqlCommand("product_NewMixedCaseGroup", OpenSqlConnection()) { CommandType = CommandType.StoredProcedure };
            com.Parameters.AddWithValue("@listOfBarcodes", productBarcodelist);

            com.ExecuteNonQuery();
            this.CloseSqlConnection();
        }

        /// <summary>
        /// Gets the list of the different promos for products in the database
        /// </summary>
        /// <returns></returns>
        public DataTable product_getListOfPromos()
        {
            DataTable dt = new DataTable();
            SqlCommand com = new SqlCommand("product_getListOfPromos", OpenSqlConnection())
            { CommandType= CommandType.StoredProcedure };

            dt.Load(com.ExecuteReader());
            CloseSqlConnection();
            return dt;
        }


        /// <summary>
        /// gets the info from a promo for the given ID
        /// </summary>
        /// <param name="promoID">Promo ID</param>
        /// <returns></returns>
        public DataTable product_getPromo(int promoID)
        {
            DataTable dt = new DataTable();
            SqlCommand com = new SqlCommand("product_getPromo", OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure
            };

            com.Parameters.AddWithValue("@promoID", promoID);

            dt.Load(com.ExecuteReader());

            CloseSqlConnection();

            return dt;

        }

        /// <summary>
        /// Finds the ID of a promo which product info matches with the given text
        /// </summary>
        /// <param name="text">key words to find a promo</param>
        /// <returns></returns>
        public DataTable product_findPromo(string text)
        {
            SqlCommand com = new SqlCommand("product_findPromos", OpenSqlConnection());
            com.CommandType = CommandType.StoredProcedure;

            com.Parameters.AddWithValue("@text", text);

            DataTable dt = new DataTable();
            dt.Load(com.ExecuteReader());

            return dt;           
        }

        /// <summary>
        /// updates the promo with the given details
        /// </summary>
        /// <param name="promoID">ID of the promo to be updated</param>
        /// <param name="promoDetails">new promo data details</param>
        /// <param name="cost">new cost for the promo</param>
        public void product_updatePromo(int promoID, DataTable promoDetails, double cost)
        {
            SqlCommand com = new SqlCommand("product_updatePromo", OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure
            };

            com.Parameters.AddWithValue("@promoID", promoID);
            com.Parameters.AddWithValue("@data", promoDetails);
            com.Parameters.AddWithValue("@cost", cost);

            com.ExecuteNonQuery();

            CloseSqlConnection();
        }


        /// <summary>
        /// deletes the promo which corresponds to the given ID
        /// </summary>
        /// <param name="promoID">Promo id number</param>
        public void product_deletePromo(int promoID)
        {
            SqlCommand com = new SqlCommand("product_deletePromo", OpenSqlConnection())
            { CommandType = CommandType.StoredProcedure };

            com.Parameters.AddWithValue("@promoID", promoID);

            com.ExecuteNonQuery();
            CloseSqlConnection();
        }

        /// <summary>
        /// Registers a new promo in the database
        /// </summary>
        /// <param name="data">table storing the barcodes and amount for each product in the promo</param>
        /// <param name="promoCost">cost of the promo</param>
        public void product_newPromo(DataTable data, double promoCost)
        {
            SqlCommand com = new SqlCommand("product_NewPromo", OpenSqlConnection())
            { CommandType = CommandType.StoredProcedure };

            com.Parameters.AddWithValue("@listOfProducts", data);
            com.Parameters.AddWithValue("@cost", promoCost);

            com.ExecuteNonQuery();
            CloseSqlConnection();
        }

        /// <summary>
        /// Updates the group of mixable selling products as stablished in the given table
        /// </summary>
        /// <param name="groupID">ID number of the group to be updated</param>
        /// <param name="productBarcodelist">List of barcodes to be added to the group</param>
        public void product_updateGroup(int groupID,DataTable productBarcodelist)
        {
            SqlCommand com = new SqlCommand("product_UpdateMixedCaseSellingGroup", OpenSqlConnection())
            { CommandType = CommandType.StoredProcedure };

            com.Parameters.AddWithValue("@groupID", groupID);
            com.Parameters.AddWithValue("@data", productBarcodelist);

            com.ExecuteNonQuery();
            this.CloseSqlConnection();
        }

        /// <summary>
        /// deletes the group of mixable selling products
        /// </summary>
        /// <param name="groupID">ID number of the group to be deleted</param>
        public void product_deleteGroup(int groupID)
        {
            SqlCommand com = new SqlCommand("product_deleteMixedCaseSellingGroup", OpenSqlConnection())
            { CommandType = CommandType.StoredProcedure };

            com.Parameters.AddWithValue("@groupID", groupID);

            com.ExecuteNonQuery();
            this.CloseSqlConnection();
        }

        /// <summary>
        /// get the product list that make up the given group ID
        /// </summary>
        /// <param name="groupID">ID number of the desired group</param>
        /// <returns></returns>
        public DataTable product_getMixedSaleGroupInfo(int groupID)
        {
            DataTable dt = new DataTable();
            SqlCommand com = new SqlCommand("product_getMixedSellGroupInformation", OpenSqlConnection())
            { CommandType = CommandType.StoredProcedure };

            com.Parameters.AddWithValue("@groupID", groupID);

            dt.Load(com.ExecuteReader());

            CloseSqlConnection();

            return dt;
        }
        public DataTable Product_BestSellProductsTable(DateTime date, int periodOfTime)
        {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("Product_BestSellProducts", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure,
                CommandTimeout = 180
            };
            command.Parameters.AddWithValue("@date", date);
            command.Parameters.AddWithValue("@timePeriodValue", periodOfTime);
            table.Load(command.ExecuteReader());
            this.CloseSqlConnection();
            return table;
        }

        public DataTable Product_GetScrapTable(DateTime date, int periodOfTime)
        {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("[Product_GetScrapStatistics]", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@date", date);
            command.Parameters.AddWithValue("@TimeLapse", periodOfTime);
            table.Load(command.ExecuteReader());
            this.CloseSqlConnection();
            return table;
        }

        /// <summary>
        /// Looks for a group of products' ID which are permitted to be sell together to form a case searching 
        /// by the barcode of one of the member products of that group
        /// </summary>
        /// <param name="Barcode">barcode of one of the members that make up the group of products</param>
        /// <returns></returns>
        public int product_findSellCaseByMixedProductsGroup(string Barcode)
        {
            SqlCommand com = new SqlCommand("product_FindSellingMixedCaseGroup", OpenSqlConnection()) { CommandType = CommandType.StoredProcedure };
            com.Parameters.AddWithValue("@partnerBarcode", Barcode);
            var result = com.Parameters.Add("@GroupID", SqlDbType.Int);
            result.Direction = ParameterDirection.ReturnValue;
            com.ExecuteNonQuery();

            CloseSqlConnection();


            return Convert.ToInt32(result.Value);
        }

        public DataTable product_ProductStatistics(string barcode, int periodOfTimeValue, DateTime date)
        {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("Produt_getStatisticsForProduct", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure,
                CommandTimeout = 190
            };
            command.Parameters.AddWithValue("@periodOfTimeValue", periodOfTimeValue);
            command.Parameters.AddWithValue("@barcode", barcode);
            command.Parameters.AddWithValue("@date", date);
            table.Load(command.ExecuteReader());
            this.CloseSqlConnection();
            return table;
        }


        public DataTable ProductGetDepots()
        {
            DataTable table = new DataTable();
            table.Load(new SqlCommand("Depots_GetDepots", this.OpenSqlConnection()) { CommandType = CommandType.StoredProcedure }.ExecuteReader());
            this.CloseSqlConnection();
            return table;
        }

        public void purchasesDelete(int PO_ID)
        {
            SqlCommand command = new SqlCommand("Purchases_Delete", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@poID", PO_ID);
            command.ExecuteNonQuery();
            this.CloseSqlConnection();
        }

        public DataSet purchasesGetPO(int PO_ID)
        {
            DataSet dataSet = new DataSet();
            SqlCommand selectCommand = new SqlCommand("Purchases_GetPO", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure
            };
            selectCommand.Parameters.AddWithValue("@poID", PO_ID);
            new SqlDataAdapter(selectCommand).Fill(dataSet);
            this.CloseSqlConnection();
            return dataSet;
        }

        public DataTable PurchasesGetPODetails(int po_id)
        {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("[Purchases_GetPODetails]", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@PO_ID", po_id);
            table.Load(command.ExecuteReader());
            this.CloseSqlConnection();
            return table;
        }

        public DataSet PurchasesGetPOs(DateTime date)
        {
            SqlCommand selectCommand = new SqlCommand("[PurchasesGetPOs]", this.OpenSqlConnection());
            DataSet dataSet = new DataSet();
            selectCommand.CommandType = CommandType.StoredProcedure;
            selectCommand.Parameters.AddWithValue("@date", date);
            new SqlDataAdapter(selectCommand).Fill(dataSet);
            this.CloseSqlConnection();
            return dataSet;
        }

        public void purchasesPay(int PO_ID, double payment, int employeeID)
        {
            SqlCommand command = new SqlCommand("[Purchase_Pay]", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@poID", PO_ID);
            command.Parameters.AddWithValue("@payment", payment);
            command.Parameters.AddWithValue("@paymentDate", DateTime.Now);
            command.Parameters.AddWithValue("@employeeId", employeeID);
            command.ExecuteNonQuery();
            this.CloseSqlConnection();
        }

        public DataTable PurchasesSearchByCoincidence(string search)
        {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("[Purchases_getPObyCoincidence]", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@text", search);
            table.Load(command.ExecuteReader());
            this.CloseSqlConnection();
            return table;
        }

        public void purchasesUpdateDeliveryStatus(int POID, bool delivered, int employeeID)
        {
            SqlCommand command = new SqlCommand("Purchases_UpdateDeliveryStatus", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@poID", POID);
            command.Parameters.AddWithValue("@delivered", delivered);
            command.Parameters.AddWithValue("@employeeWhoConfirmdID", employeeID);
            command.ExecuteNonQuery();
            this.CloseSqlConnection();
        }

        public void purchasesUpdatePOProductQuantity(int poID, string barcode, double quantity)
        {
            SqlCommand command = new SqlCommand("Purchases_UpdatePO", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@poID", poID);
            command.Parameters.AddWithValue("@barcode", barcode);
            command.Parameters.AddWithValue("@quant", quantity);
            command.ExecuteNonQuery();
            this.CloseSqlConnection();
        }

        public void purchasesUpdatePOTotal(int poID, double total)
        {
            SqlCommand command = new SqlCommand("purchases_UpdateTotal", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@poID", poID);
            command.Parameters.AddWithValue("@total", total);
            command.ExecuteNonQuery();
            this.CloseSqlConnection();
        }

        public bool RegisteredPrice(int CustomerID, string Barcode, double minAmount, bool sellByCase)
        {
            int count = 0;
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("getPrice", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@customerID", CustomerID);
            command.Parameters.AddWithValue("@barcode", Barcode);
            command.Parameters.AddWithValue("@minQuant", minAmount);
            command.Parameters.AddWithValue("@sellByCases", sellByCase);
            table.Load(command.ExecuteReader());
            count = table.Rows.Count;
            this.CloseSqlConnection();
            return (count != 0);
        }

        public void RegisterPayment(int Customer_ID, DateTime DateAndTime, int PurchaseID, double cash, int employeeID)
        {
            SqlCommand command = new SqlCommand("CustomerPaymentRecordAdd", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@customerID", Customer_ID);
            command.Parameters.AddWithValue("@PurchaseID", PurchaseID);
            command.Parameters.AddWithValue("@date", DateAndTime.Date);
            command.Parameters.AddWithValue("@time", DateAndTime.TimeOfDay);
            command.Parameters.AddWithValue("@cash", cash);
            command.Parameters.AddWithValue("@EmployeeID", employeeID);
            command.ExecuteNonQuery();
            this.CloseSqlConnection();
        }

        public DataTable Reminder_getReminderIDsForDate(DateTime date, int dayofWeek)
        {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("reminder_GetRemindersforDate", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@dayoftheweek", dayofWeek);
            command.Parameters.AddWithValue("@date", date);
            table.Load(command.ExecuteReader());
            this.CloseSqlConnection();
            return table;
        }

        public DataTable Reminder_getUnseenReminders(int dayOfTheWeek)
        {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("Reminders_CheckForUnseenReminders", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@date", DateTime.Now);
            command.Parameters.AddWithValue("@dayOfTheWeek", dayOfTheWeek);
            table.Load(command.ExecuteReader());
            this.CloseSqlConnection();
            return table;
        }

        public DataTable Reminder_initialize(int reminderID)
        {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("reminder_Initialize", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@reminderID", reminderID);
            table.Load(command.ExecuteReader());
            this.CloseSqlConnection();
            return table;
        }

        public void reminder_MarkAsSeen(int reminderID)
        {
            SqlCommand command = new SqlCommand("reminder_MarkAsSeen", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@reminderID", reminderID);
            command.ExecuteNonQuery();
            this.CloseSqlConnection();
        }

        public void Reminder_reset()
        {
            new SqlCommand("Reminders_Reset", this.OpenSqlConnection()) { CommandType = CommandType.StoredProcedure }.ExecuteNonQuery();
            this.CloseSqlConnection();
        }

        public void Sale_Cancel(int saleID, int EmployeeID)
        {
            SqlCommand command = new SqlCommand("Sale_Cancel", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@saleID", saleID);
            command.Parameters.AddWithValue("@employeeID", EmployeeID);
            command.Parameters.AddWithValue("@dateOfCancellation", DateTime.Now);
            command.ExecuteNonQuery();
            this.CloseSqlConnection();
        }

        public DataTable Sale_find(int SaleID)
        {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("Sale_find", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@saleID", SaleID);
            table.Load(command.ExecuteReader());
            this.CloseSqlConnection();
            return table;
        }

        public int Sale_getLastSaleID()
        {
            int num = -1;
            object obj2 = new SqlCommand("Sale_getLastSale", this.OpenSqlConnection()) { CommandType = CommandType.StoredProcedure }.ExecuteScalar();
            num = Convert.ToInt32((obj2 == DBNull.Value) ? null : obj2);
            this.CloseSqlConnection();
            return num;
        }

        public DataSet Sale_Initialize(int saleID)
        {
            DataSet dataSet = new DataSet();
            SqlCommand selectCommand = new SqlCommand("Sale_Initialize", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure,
                CommandTimeout=120
            };
            selectCommand.Parameters.AddWithValue("@saleID", saleID);
            new SqlDataAdapter(selectCommand).Fill(dataSet);
            return dataSet;
        }

        public DataTable Sale_InvestmentSellsProfit(int periodOfTimeValue, DateTime date)
        {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("[InvestmentSellsProfit]", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure,
                CommandTimeout = 120
            };
            command.Parameters.AddWithValue("@periodOfTimeValue", periodOfTimeValue);
            command.Parameters.AddWithValue("@date", date);
            table.Load(command.ExecuteReader());
            this.CloseSqlConnection();
            return table;
        }

        public int Sale_newSale(DateTime time, int Id_Employee, int CustomerID, double total, double payment, DataTable listOfProducts, double cash)
        {
            SqlCommand command = new SqlCommand("Sale_New", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure,
                CommandTimeout=120
            };
            command.Parameters.AddWithValue("@date", time.Date);
            command.Parameters.AddWithValue("@time", time.TimeOfDay);
            command.Parameters.AddWithValue("@IDemployee", Id_Employee);
            command.Parameters.AddWithValue("@idCustomer", CustomerID);
            command.Parameters.AddWithValue("@total", total);
            command.Parameters.AddWithValue("@payment", payment);
            command.Parameters.AddWithValue("@saleDetail", listOfProducts);
            command.Parameters.AddWithValue("@cash", cash);
            object obj2 = command.ExecuteScalar();
            int num = Convert.ToInt32((obj2 == DBNull.Value) ? null : obj2);
            this.CloseSqlConnection();
            return num;
        }

        public void Sale_ReturnPackage(int saleID, string barcode, decimal Amount, int employeeID)
        {
            SqlCommand command = new SqlCommand("sale_PackageRetuern", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@barcode", barcode);
            command.Parameters.AddWithValue("@amount", Amount);
            command.Parameters.AddWithValue("@saleID", saleID);
            command.Parameters.AddWithValue("@employeeID", employeeID);
            command.ExecuteNonQuery();
            this.CloseSqlConnection();
        }

        public DataTable SearchCustomer(string search)
        {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SearchCustomer", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@string", search);
            table.Load(command.ExecuteReader());
            this.CloseSqlConnection();
            return table;
        }

        public DataTable SearchProduct(string CodigoBarras)
        {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SearchProduct", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@code", CodigoBarras);
            table.Load(command.ExecuteReader());
            this.CloseSqlConnection();
            return table;
        }

        public DataTable SearchProductByCoincidence(string text)
        {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SearchProductByCoincidence", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure,
                CommandTimeout=120
            };
            command.Parameters.AddWithValue("@text", text);
            table.Load(command.ExecuteReader());
            this.CloseSqlConnection();
            return table;
        }

        public DataTable SearchValue(string Search)
        {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SearchValue", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@value", Search);
            table.Load(command.ExecuteReader());
            return table;
        }

        public void shift_AddCashToDrawer(int employeeID, double cash)
        {
            SqlCommand command = new SqlCommand("shift_AddMoneyToDrawer", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@cash", cash);
            command.Parameters.AddWithValue("@employeeID", employeeID);
            command.ExecuteNonQuery();
            this.CloseSqlConnection();
        }

        public DataTable Shift_End(int employeeID)
        {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("[Shift_end]", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@employeeID", employeeID);
            command.Parameters.AddWithValue("@time", DateTime.Now);
            table.Load(command.ExecuteReader());
            this.CloseSqlConnection();
            return table;
        }

        public DataTable shift_getMoneyAddedToDrawer()
        {
            DataTable table = new DataTable();
            table.Load(new SqlCommand("shift_getMoneyAddedToDrawer", this.OpenSqlConnection()) { CommandType = CommandType.StoredProcedure }.ExecuteReader());
            this.CloseSqlConnection();
            return table;
        }

        public DataRow Shift_getStartingDate()
        {
            DataTable table = new DataTable();
            table.Load(new SqlCommand("Shift_getStartingTime", this.OpenSqlConnection()) { CommandType = CommandType.StoredProcedure }.ExecuteReader());
            this.CloseSqlConnection();
            return table.Rows[0];
        }

        public DataTable Shift_isActive()
        {
            DataTable table = new DataTable();
            table.Load(new SqlCommand("Shift_isActive", this.OpenSqlConnection()) { CommandType = CommandType.StoredProcedure }.ExecuteReader());
            this.CloseSqlConnection();
            return table;
        }

        public void Shift_start(DateTime startTime, decimal initialCash, int employeeID)
        {
            SqlCommand command = new SqlCommand("Shift_start", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@cash", initialCash);
            command.Parameters.AddWithValue("@time", startTime);
            command.Parameters.AddWithValue("@employeeID", employeeID);
            command.ExecuteNonQuery();
            this.CloseSqlConnection();
        }

        public int SupplierAdd(string Name, double debt)
        {
            SqlCommand command = new SqlCommand("SupplierAdd", this.OpenSqlConnection());
            command.Parameters.AddWithValue("@name", Name);
            command.Parameters.AddWithValue("@debt", debt);
            command.CommandType = CommandType.StoredProcedure;
            object obj2 = command.ExecuteScalar();
            int num = Convert.ToInt32((obj2 == DBNull.Value) ? null : obj2);
            this.CloseSqlConnection();
            return num;
        }

        public void SupplierAddPODetails(int PO_ID, string barcode, double quantity, double PiecesperCase, double UnitaryCost, double Total,int destinyDepotID)
        {
            SqlCommand command = new SqlCommand("SupplierGeneratePODetails", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@POid", PO_ID);
            command.Parameters.AddWithValue("@barcode", barcode);
            command.Parameters.AddWithValue("@quantity", quantity);
            command.Parameters.AddWithValue("@Pieces", PiecesperCase);
            command.Parameters.AddWithValue("@cost", UnitaryCost);
            command.Parameters.AddWithValue("@total", Total);
            command.Parameters.AddWithValue("@depotID", destinyDepotID);
            command.ExecuteNonQuery();
            this.CloseSqlConnection();
        }

        public void SupplierAddProduct(int SupplierID, string Barcode, double PurchasePrice, double pieces)
        {
            SqlCommand command = new SqlCommand("AddSuplierProductList", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@idSupplier", SupplierID);
            command.Parameters.AddWithValue("@idProduct", Barcode);
            command.Parameters.AddWithValue("@PurchasePrice", PurchasePrice);
            command.Parameters.AddWithValue("@Quantity", 0.0);
            command.Parameters.AddWithValue("@pieces", pieces);
            command.ExecuteNonQuery();
            this.CloseSqlConnection();
        }

        public void SupplierDeleteProduct(int SupplierID, string Barcode)
        {
            SqlCommand command = new SqlCommand("DeleteSupplierProduct", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@SupplierID", SupplierID);
            command.Parameters.AddWithValue("@barcode", Barcode);
            command.ExecuteNonQuery();
            this.CloseSqlConnection();
        }

        public void SupplierDeletePromo(int PromoID)
        {
            SqlCommand command = new SqlCommand("SupplierDeletePromo", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@PromoID", PromoID);
            command.ExecuteNonQuery();
            this.CloseSqlConnection();
        }

        public void SupplierEditProduct(int SupplierID, string Barcode, double NewPrice, double piecesPerCase)
        {
            SqlCommand command = new SqlCommand("UpdateSupplierProduct", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@SupplierID", SupplierID);
            command.Parameters.AddWithValue("@pieces", piecesPerCase);
            command.Parameters.AddWithValue("@barcode", Barcode);
            command.Parameters.AddWithValue("@newPrice", NewPrice);
            command.ExecuteNonQuery();
            this.CloseSqlConnection();
        }

        public DataTable SupplierFilterProducts(string search, int supplierId)
        {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("[SearchSupplierProductByCoincidence]", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@search", search);
            command.Parameters.AddWithValue("@id", supplierId);
            table.Load(command.ExecuteReader());
            this.CloseSqlConnection();
            return table;
        }

        public int SupplierGeneratePO(int SupplierID, int EmployeeID, DateTime arrivalDate, DateTime paymentDueDate, double total, double Payment)
        {
            SqlCommand command = new SqlCommand("[SupplierGeneratePO]", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@supplierID", SupplierID);
            command.Parameters.AddWithValue("@EmployeeID", EmployeeID);
            command.Parameters.AddWithValue("@ArrivalDate", arrivalDate);
            command.Parameters.AddWithValue("@PaymentDueDate", paymentDueDate);
            command.Parameters.AddWithValue("@payment", Payment);
            command.Parameters.AddWithValue("@total", total);
            object obj2 = command.ExecuteScalar();
            int num = Convert.ToInt32((obj2 == DBNull.Value) ? null : obj2);
            this.CloseSqlConnection();
            return num;
        }

        public DataTable SupplierGetPromos(int SupplierID)
        {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SupplierGetSales", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@SupplierID", SupplierID);
            table.Load(command.ExecuteReader());
            this.CloseSqlConnection();
            return table;
        }

        public DataTable SupplierGetQuantitiesAndDates(int SupplierID)
        {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SupplierGetQuantitiesAndDates", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@SupplierID", SupplierID);
            table.Load(command.ExecuteReader());
            this.CloseSqlConnection();
            return table;
        }

        public void SupplierPromoAdd(int supplierID, string Barcode, double cost, double quantity, DateTime startDate, DateTime endDate, string notes)
        {
            SqlCommand command = new SqlCommand("SupplierPromoAdd", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@supplierID", supplierID);
            command.Parameters.AddWithValue("@productID", Barcode);
            command.Parameters.AddWithValue("@cost", cost);
            command.Parameters.AddWithValue("@minQuant", quantity);
            command.Parameters.AddWithValue("@startDate", startDate);
            command.Parameters.AddWithValue("@endDate", endDate);
            command.Parameters.AddWithValue("@notes", notes);
            command.ExecuteNonQuery();
            this.CloseSqlConnection();
        }

        public DataTable SupplierPromoCorroborateExistenceOfSimilarPromo(int supplierId, int promoID, string barcode, double quant)
        {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("[SupplierPromoCorroborateDoesNotExist]", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@SupplierID", supplierId);
            command.Parameters.AddWithValue("@PromoID", promoID);
            command.Parameters.AddWithValue("@Barcode", barcode);
            command.Parameters.AddWithValue("@Quantity", quant);
            table.Load(command.ExecuteReader());
            return table;
        }

        public DataTable SupplierPromoGetByID(int PromoID)
        {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SupplierPromoGetPromoByID", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@id", PromoID);
            table.Load(command.ExecuteReader());
            this.CloseSqlConnection();
            return table;
        }

        public void SupplierPromoUpdate(int promoID, double cost, double quantity, DateTime startDate, DateTime endDate, string notes)
        {
            SqlCommand command = new SqlCommand("SupplierPromoUpdate", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@PromoID", promoID);
            command.Parameters.AddWithValue("@cost", cost);
            command.Parameters.AddWithValue("@minQuant", quantity);
            command.Parameters.AddWithValue("@startDate", startDate);
            command.Parameters.AddWithValue("@endDate", endDate);
            command.Parameters.AddWithValue("@notes", notes);
            command.ExecuteNonQuery();
            this.CloseSqlConnection();
        }

        public void SupplierUpdateBasicInformation(string name, string telephone, string Address, int SupplierID)
        {
            SqlCommand command = new SqlCommand("[SuppliersUpdateBasicInformation]", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@telephone", telephone);
            command.Parameters.AddWithValue("@address", Address);
            command.Parameters.AddWithValue("@SupplierID", SupplierID);
            command.ExecuteNonQuery();
            this.CloseSqlConnection();
        }

        public void SupplierUpdateDebt(int supplierID, double newDebt)
        {
            SqlCommand command = new SqlCommand("[SupplierUpdateDebt]", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@SupplierID", supplierID);
            command.Parameters.AddWithValue("@NewDebt", newDebt);
            command.ExecuteNonQuery();
            this.CloseSqlConnection();
        }

        public void SupplierUpdateQuantities(int SupplierID, string ProductID, double Quantity)
        {
            SqlCommand command = new SqlCommand("SupplierProductListUpdateQuantities", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@SupplierID", SupplierID);
            command.Parameters.AddWithValue("@ProductID", ProductID);
            command.Parameters.AddWithValue("@Quantity", Quantity);
            command.ExecuteNonQuery();
            this.CloseSqlConnection();
        }

        public DataTable TicketPrinter_Initialize()
        {
            DataTable table = new DataTable();
            table.Load(new SqlCommand("printer_Initialize", this.OpenSqlConnection()) { CommandType = CommandType.StoredProcedure }.ExecuteReader());
            this.CloseSqlConnection();
            return table;
        }

        public void UpdateCustomerInfo(string Name, string TelephoneNumber, string Address, int CustomerID, decimal discount, bool isPercentage, bool dontApplyAnyDiscount)
        {
            SqlCommand command = new SqlCommand("UpdateCustomerInforation", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@name", Name);
            command.Parameters.AddWithValue("@ID", CustomerID);
            command.Parameters.AddWithValue("@telephone ", TelephoneNumber);
            command.Parameters.AddWithValue("@address", Address);
            command.Parameters.AddWithValue("@discount", discount);
            command.Parameters.AddWithValue("@isPercentage", isPercentage);
            command.Parameters.AddWithValue("@dontApplyAnyKindOfDiscount", dontApplyAnyDiscount);
            command.ExecuteNonQuery();
            this.CloseSqlConnection();
        }

        public void UpdatePrice(int discount_ID, double Discount, bool isPercentage, double minAmount, bool SellByCases)
        {
            SqlCommand command = new SqlCommand("UpdateCustomerCost", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@discountID", discount_ID);
            command.Parameters.AddWithValue("@Discount", Discount);
            command.Parameters.AddWithValue("@isPercentage", isPercentage);
            command.Parameters.AddWithValue("@minAmount", minAmount);
            command.Parameters.AddWithValue("@sellByCase", SellByCases);
            command.ExecuteNonQuery();
            this.CloseSqlConnection();
        }

        public void UpdateReminder(int SupplierID, int ReminderID, DateTime startTime, DateTime endTime, bool[] repetitionDays, string message)
        {
            SqlCommand command = new SqlCommand("Reminder_UpdateReminder", this.OpenSqlConnection());
            string str = "";
            for (int i = 0; i < repetitionDays.Length; i++)
            {
                str = repetitionDays[i] ? (str + "1") : (str + "0");
            }
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@supplierID", SupplierID);
            command.Parameters.AddWithValue("@ReminderID", ReminderID);
            command.Parameters.AddWithValue("@StartingDate", startTime.Date);
            command.Parameters.AddWithValue("@startingTime", startTime.TimeOfDay);
            command.Parameters.AddWithValue("@endingDate", endTime.Date);
            command.Parameters.AddWithValue("@endingTime", endTime.TimeOfDay);
            command.Parameters.AddWithValue("@repetitionDays", str);
            command.Parameters.AddWithValue("@message", message);
            command.ExecuteNonQuery();
            this.CloseSqlConnection();
        }

        public void UpdateStatus(string Status, int CustomerId)
        {
            SqlCommand command = new SqlCommand("UpdateCustomerStatus", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@id", CustomerId);
            command.Parameters.AddWithValue("@status", Status);
            command.ExecuteNonQuery();
        }

        public void UpdateVisitingDays(string visitingDays, int SupplierID)
        {
            SqlCommand command = new SqlCommand("UpdateVisitingDays", this.OpenSqlConnection())
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@visitingDays", visitingDays);
            command.Parameters.AddWithValue("@SupplierID", SupplierID);
            command.ExecuteNonQuery();
            this.CloseSqlConnection();
        }

    }
}
