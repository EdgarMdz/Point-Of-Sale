using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS
{
    class Empleado
    {
        private Capa_de_Negocio negocio = new Capa_de_Negocio();
        private bool _isAdmin;
        private bool _isDiscountAppliedAsPercentage;
        private bool[] _paymentday;
        private int _ID;
        private int _customerID;
        private double _salary;
        private double _discount;
        private string _address;
        private string _name;
        private string _telephonNumber;
        private string _userName;
        private DateTime _dateOfBirth;
        private DateTime _hirementDate;

        public bool isAdmin
        {
            get
            {
                return this._isAdmin;
            }
        }

        public bool isDiscountAppliedAsPercentage
        {
            get
            {
                return this._isDiscountAppliedAsPercentage;
            }
        }

        public bool[] daysOfPayment
        {
            get
            {
                return this._paymentday;
            }
        }

        public int ID
        {
            get
            {
                return this._ID;
            }
        }

        public int CustomerID
        {
            get
            {
                return this._customerID;
            }
        }

        public double salary
        {
            get
            {
                return this._salary;
            }
        }

        public double discount
        {
            get
            {
                return this._discount;
            }
        }

        public string address
        {
            get
            {
                return this._address;
            }
        }

        public string name
        {
            get
            {
                return this._name;
            }
        }

        public string phoneNumber
        {
            get
            {
                return this._telephonNumber;
            }
        }

        public string userName
        {
            get
            {
                return this._userName;
            }
        }

        public DateTime dateOfBirth
        {
            get
            {
                return this._dateOfBirth;
            }
        }

        public DateTime hirementDate
        {
            get
            {
                return this._hirementDate;
            }
        }

        public Empleado(int ID)
        {
            this.initialize(ID);
        }

        public Empleado(string user, string password)
        {
            this.initialize(this.negocio.employee_Login(user, password));
        }

        public static DataTable searchEmployee(string text)
        {
            return new Capa_de_Negocio().Employee_search(text);
        }

        private void initialize(int id)
        {
            DataTable dataTable = this.negocio.Employee_Initialize(id);
            if (dataTable.Rows.Count == 1)
            {
                DataRow row = dataTable.Rows[0];
                this._ID = Convert.ToInt32(row["id_Empleado"]);
                this._name = row["Nombre"].ToString();
                this._isAdmin = Convert.ToBoolean(row["Administrador"]);
                this._telephonNumber = row["Teléfono"].ToString();
                this._dateOfBirth = row["Fecha de Nacimiento"].ToString() != "" ? Convert.ToDateTime(row["Fecha de Nacimiento"]) : new DateTime();
                this._hirementDate = row["Fecha de Contratación"].ToString() != "" ? Convert.ToDateTime(row["Fecha de Contratación"]) : new DateTime();
                this._salary = Convert.ToDouble(row["Pago"]);
                this._paymentday = new bool[7];
                for (int index = 0; index < 7; ++index)
                    this._paymentday[index] = Convert.ToBoolean(char.GetNumericValue(row["Dia de Pago"].ToString()[index]));
                this._discount = Convert.ToDouble(row["Descuento"]);
                this._isDiscountAppliedAsPercentage = Convert.ToBoolean(row["Es descuento por porcentaje"]);
                this._address = row["Dirección"].ToString();
                this._customerID = Convert.ToInt32(row["id_cliente"]);
                this._userName = row["Usuario"].ToString();
            }
            else
                this._ID = -1;
        }

        public static DataTable getListOfEmployees()
        {
            return new Capa_de_Negocio().Employee_getListOfEmployees();
        }

        public static int newEmployee(string name, string userName, bool isAdmin)
        {
            return new Capa_de_Negocio().Employee_new(name, userName, isAdmin);
        }

        public void changePassword(string newPass)
        {
            this.negocio.Employee_changePassword(this.ID, newPass);
        }

        public void UpdateAddress(string newAddress)
        {
            this.negocio.Employee_UpdateAddress(newAddress, this.ID);
            this._address = newAddress;
        }

        public void UpdateDateOfBirth(DateTime newDate)
        {
            this.negocio.Employee_UpdateDateOfBirth(newDate, this.ID);
            this._dateOfBirth = newDate;
        }

        public void UpdateDiscount(double discount, bool isPercentage)
        {
            this.negocio.Employee_UpdateDiscount(this.ID, discount, isPercentage);
            this._discount = discount;
            this._isDiscountAppliedAsPercentage = isPercentage;
        }

        public void UpdateHirementDate(DateTime newDate)
        {
            this.negocio.Employee_UpdateHirementDate(newDate, this.ID);
            this._hirementDate = newDate;
        }

        public void UpdateName(string newName)
        {
            this.negocio.Employee_UpdateName(newName, this.ID);
            this._name = newName;
        }

        public void updatePaymentDay(bool[] paymentDays)
        {
            this.negocio.Employee_updatePaymentDay(paymentDays, this.ID);
            this.initialize(this.ID);
        }

        public void UpdatePhone(string newPhone)
        {
            this.negocio.Employee_UpdatePhone(newPhone, this.ID);
            this._telephonNumber = newPhone;
        }

        public void UpdatePosition(bool isAdmin)
        {
            this.negocio.Employee_UpdatePosition(isAdmin, this.ID);
            this._isAdmin = isAdmin;
        }

        public void updateSalary(double newSalary)
        {
            this.negocio.Employee_UpdateSalary(newSalary, this.ID);
            this._salary = newSalary;
        }

        public void paySalary()
        {
            this.negocio.employee_paySalary(this.ID);
        }

        public static bool nameExist(string name)
        {
            return new Capa_de_Negocio().Employee_nameExist(name);
        }

        public static bool userNameExist(string user)
        {
            return new Capa_de_Negocio().Employee_userNameExist(user);
        }
    }
}
