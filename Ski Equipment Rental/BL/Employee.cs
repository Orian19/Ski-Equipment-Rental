using Ski_Equipment_Rental.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ski_Equipment_Rental.BL
{
    public class Employee
    {
        #region Members - תכונות
        private int m_Id;
        private string m_FirstName;
        private string m_LastName;
        private string m_Gender;
        private int m_MobilePhone;
        private string m_PrefixMobile;
        private DateTime m_BirthDate;
        private string m_Email;
        private int m_EmployeeId;
        private string m_Username;
        private string m_Password;
        private bool m_IsAdmin;

        private City m_City;

        public int Id
        {
            get
            {
                return m_Id;
            }

            set
            {
                m_Id = value;
            }
        }
        public string FirstName
        {
            get
            {
                return m_FirstName;
            }

            set
            {
                m_FirstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return m_LastName;
            }

            set
            {
                m_LastName = value;
            }
        }
        public string Gender
        {
            get
            {
                return m_Gender;
            }

            set
            {
                m_Gender = value;
            }
        }
        public int MobilePhone
        {
            get
            {
                return m_MobilePhone;
            }

            set
            {
                m_MobilePhone = value;
            }
        }
        public string PrefixMobile
        {
            get
            {
                return m_PrefixMobile;
            }

            set
            {
                m_PrefixMobile = value;
            }
        }
        public DateTime BirthDate
        {
            get
            {
                return m_BirthDate;
            }

            set
            {
                m_BirthDate = value;
            }
        }
        public string Email
        {
            get
            {
                return m_Email;
            }

            set
            {
                m_Email = value;
            }
        }
        public int EmployeeId
        {
            get
            {
                return m_EmployeeId;
            }

            set
            {
                m_EmployeeId = value;
            }
        }
        public string Username
        {
            get
            {
                return m_Username;
            }

            set
            {
                m_Username = value;
            }
        }
        public string Password
        {
            get
            {
                return m_Password;
            }

            set
            {
                m_Password = value;
            }
        }
        public bool IsAdmin
        {
            get
            {
                return m_IsAdmin;
            }

            set
            {
                m_IsAdmin = value;
            }
        }
        public City City
        {
            get
            {
                return m_City;
            }

            set
            {
                m_City = value;
            }
        }

        public string FullName { get { return LastName + " " + FirstName; } set { FullName = value; } }

        #endregion

        #region Constructors - בנאים
        public Employee()
        {
        }
        public Employee(DataRow dataRow)
        {
            //מייצרת עובד מתוך שורת עובד
            this.m_Id = (int)dataRow["ID"];
            this.m_Username = dataRow["Username"].ToString();
            this.m_Password = dataRow["Password"].ToString();
            this.m_IsAdmin = (bool)dataRow["IsAdmin"];
            this.m_FirstName = dataRow["FirstName"].ToString();
            this.LastName = dataRow["LastName"].ToString();
            this.Gender = dataRow["Gender"].ToString();
            this.MobilePhone = (int)dataRow["MobilePhone"];
            this.PrefixMobile = dataRow["PrefixMobile"].ToString();
            this.m_BirthDate = (DateTime)dataRow["BirthDate"];
            this.m_Email = dataRow["Email"].ToString();
            this.m_EmployeeId = (int)dataRow["EmployeeId"];
            this.m_City = new City(dataRow.GetParentRow("EmployeeCity"));
        }
        #endregion

        public bool Update()
        {
            return Employee_Dal.Update(Id, Username, Password, IsAdmin, FirstName,
            LastName, Gender, MobilePhone, PrefixMobile, BirthDate, Email, EmployeeId, City.Id);
        }

        public override string ToString()
        {
            return LastName + " " + FirstName;
        }

        public bool Insert()
        {
            return Employee_Dal.Insert(Username, Password, IsAdmin, FirstName, 
            LastName, Gender, MobilePhone, PrefixMobile, BirthDate, Email, EmployeeId, City.Id);
        }

        public bool Delete()
        {
            return Employee_Dal.Delete(Id);
        }
    }
}
