using System;
using System.Data;
using System.Windows.Forms;

namespace POS
{
    public class Oferta
    {
        private int _ID;
        private string _barcode;
        private string _description;

        public double cost { get; set; }

        public double MinimumQuantityToBuy { get; set; }

        public DateTime StartingPomoDate { get; set; }

        public DateTime EndingPromoDate { get; set; }

        public string notes { get; set; }

        public int ID
        {
            get
            {
                return this._ID;
            }
        }

        public string Barcode
        {
            get
            {
                return this._barcode;
            }
        }

        public string ProductDescription
        {
            get
            {
                return this._description;
            }
        }

        public Oferta(string barcode)
        {
            Producto producto = new Producto(barcode);
            if (producto.Barcode != null)
            {
                this._barcode = barcode;
                this._description = producto.Description;
            }
            else
            {
                int num = (int)MessageBox.Show("No se encontró el producto solicitado");
                this._ID = -1;
            }
        }

        public Oferta(int id)
        {
            this._ID = id;
            this.GetPromoByID();
        }

        public bool CorroborateExistenceOfSimilarPromo(int supplierID)
        {
            return new Capa_de_Negocio().SupplierPromoCorroborateExistenceOfSimilarPromo(supplierID, this._ID, this._barcode, this.MinimumQuantityToBuy);
        }

        private void GetPromoByID()
        {
            try
            {
                DataTable byId = new Capa_de_Negocio().SupplierPromoGetByID(this._ID);
                if (byId.Rows.Count > 0)
                {
                    this._barcode = byId.Rows[0]["Código de Barras"].ToString();
                    this._description = byId.Rows[0]["Descripción"].ToString();
                    this.cost = Convert.ToDouble(byId.Rows[0]["Precio de Oferta"].ToString());
                    this.MinimumQuantityToBuy = Convert.ToDouble(byId.Rows[0]["Cantidad Mínima de Compra"].ToString());
                    this.StartingPomoDate = Convert.ToDateTime(byId.Rows[0]["Fecha de Inicio"]);
                    this.EndingPromoDate = Convert.ToDateTime(byId.Rows[0]["Fecha de Fin"]);
                    this.notes = byId.Rows[0]["Notas"].ToString();
                }
                else
                {
                    int num = (int)MessageBox.Show("No se encontró la oferta indicada con el ID = " + (object)this._ID);
                    this._ID = -1;
                }
            }
            catch (Exception ex)
            {
                this._ID = -1;
                int num = (int)MessageBox.Show("No se pudo Completar La acción.\nError: " + ex.Message, "Ocurrio un error", MessageBoxButtons.OK);
            }
        }

        public void Add(int SupplierID)
        {
            if (this._barcode == null)
                return;
            double cost = this.cost;
            double minimumQuantityToBuy = this.MinimumQuantityToBuy;
            DateTime startingPomoDate = this.StartingPomoDate;
            DateTime endingPromoDate = this.EndingPromoDate;
            try
            {
                new Capa_de_Negocio().SupplierPromoAdd(SupplierID, this._barcode, this.cost, this.MinimumQuantityToBuy, this.StartingPomoDate, this.EndingPromoDate, this.notes);
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show("No se pudo Completar La acción.\nError: " + ex.Message, "Ocurrio un error", MessageBoxButtons.OK);
            }
        }

        public void Update()
        {
            try
            {
                new Capa_de_Negocio().SupplierPromoUpdate(this._ID, this.cost, this.MinimumQuantityToBuy, this.StartingPomoDate, this.EndingPromoDate, this.notes);
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show("No se pudo Completar La acción.\nError: " + ex.Message, "Ocurrio un error", MessageBoxButtons.OK);
            }
        }

        public void Delete()
        {
            try
            {
                new Capa_de_Negocio().SupplierDeletePromo(this.ID);
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show("No se pudo Completar La acción.\nError: " + ex.Message, "Ocurrio un error", MessageBoxButtons.OK);
            }
        }
    }
}
