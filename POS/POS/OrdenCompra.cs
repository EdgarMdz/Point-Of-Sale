
using System;
using System.Data;
using System.Windows.Forms;

namespace POS
{
    public class OrdenCompra
    {
        public int _EmployeeWhoConfirmedThePurchaseID;
        private Capa_de_Negocio negocio;

        public int ID { get; set; }

        public int SupplierID { get; set; }

        public string SupplierName { get; set; }

        public int EmployeeID { get; set; }

        public string EmployeeName { get; set; }

        public DateTime purchaseDate { get; set; }

        public DateTime arrivalDate { get; set; }

        public DateTime paymentDate { get; set; }

        public double total { get; set; }

        public double pay { get; set; }

        public bool paid { get; set; }

        public bool delivered { get; set; }

        public DataTable _products { get; set; }

        public OrdenCompra(int PO_ID)
        {
            this.negocio = new Capa_de_Negocio();
            this.Initialize(PO_ID);
        }

        private void Initialize(int id)
        {
            DataSet dataSet = new DataSet();
            DataSet po = this.negocio.purchasesGetPO(id);
            if (po.Tables[0].Rows.Count > 0)
            {
                DataTable table = po.Tables[0];
                this._products = po.Tables[1];
                this.ID = Convert.ToInt32(table.Rows[0]["ID_PO"]);
                this.SupplierID = Convert.ToInt32(table.Rows[0]["ID_Proveedor"]);
                this.SupplierName = table.Rows[0]["Nombre de la Empresa"].ToString();
                this.EmployeeID = Convert.ToInt32(table.Rows[0]["id_empleado"]);
                this.EmployeeName = table.Rows[0]["Realizó Compra"].ToString();
                this.purchaseDate = Convert.ToDateTime(table.Rows[0]["Fecha de compra"]);
                this.arrivalDate = Convert.ToDateTime(table.Rows[0]["Fecha de Llegada"]);
                this.paymentDate = Convert.ToDateTime(table.Rows[0]["Fecha Límite de Pago"]);
                this.total = Convert.ToDouble(table.Rows[0]["Total"]);
                this.pay = Convert.ToDouble(table.Rows[0]["Abono"]);
                this.paid = Convert.ToBoolean(table.Rows[0]["Estado de Pago"]);
                this.delivered = Convert.ToBoolean(table.Rows[0]["Mercancia Recibida"]);
                int.TryParse(table.Rows[0]["Empleado que recibió"].ToString(), out this._EmployeeWhoConfirmedThePurchaseID);
            }
            else
                this.ID = -1;
        }

        public static DataTable getAllPO(DateTime date)
        {
            return new Capa_de_Negocio().PurchasesGetPOs(date);
        }

        public static DataTable GetPODetails(int po_id)
        {
            return new Capa_de_Negocio().PurchasesGetPODetails(po_id);
        }

        public static DataTable SearchByCoincidence(string search)
        {
            return new Capa_de_Negocio().PurchasesSearchByCoincidence(search);
        }

        public void MakePayment(double payment, int employeeID)
        {
            try
            {
                this.negocio.purchasesPay(this.ID, payment, employeeID);
                this.pay += payment;
                if (this.pay != this.total)
                    return;
                this.paid = true;
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show("No se pudo completar la Accion\n Error: " + ex.Message);
            }
        }

        public void delete()
        {
            try
            {
                this.negocio.purchasesDelete(this.ID);
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show("No se pudo completar la Accion\n Error: " + ex.Message);
            }
        }

        public void UpdateProductQunantity(string barcode, double newQuantity)
        {
            this.negocio.purchasesUpdatePOProductQuantity(this.ID, barcode, newQuantity);
            this.updateTotal();
        }

        private void updateTotal()
        {
            this.negocio.purchasesUpdatePOTotal(this.ID, this.total);
        }

        public void updateDeliveryStatus()
        {
            this.negocio.purchasesUpdateDeliveryStatus(this.ID, this.delivered, this._EmployeeWhoConfirmedThePurchaseID);
        }

        public void updateTotal(double newTotal)
        {
            this.total = newTotal;
            this.updateTotal();
            this.Initialize(this.ID);
        }
    }
}
