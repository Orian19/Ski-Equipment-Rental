using Ski_Equipment_Rental.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ski_Equipment_Rental.BL
{
    public class Client
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
        private int m_ClientId;

        private City m_City;

        //for automatic get and set click: "ctrl r + ctrl e"
              
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
        public int ClientId
        {
            get
            {
                return m_ClientId;
            }

            set
            {
                m_ClientId = value;
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
        public Client()
        {
        }
        public Client(DataRow dataRow)
        {
            //מייצרת לקוח מתוך שורת לקוח
            this.m_Id = (int)dataRow["ID"];
            this.m_FirstName = dataRow["FirstName"].ToString();
            this.LastName = dataRow["LastName"].ToString();
            this.Gender = dataRow["Gender"].ToString();
            this.MobilePhone = (int)dataRow["MobilePhone"];
            this.PrefixMobile = dataRow["PrefixMobile"].ToString();
            this.m_BirthDate = (DateTime)dataRow["BirthDate"];
            this.m_Email = dataRow["Email"].ToString();
            this.m_ClientId = (int)dataRow["ClientId"];
            this.m_City = new City(dataRow.GetParentRow("ClientCity"));
        }
        #endregion

        public override string ToString()
        {
            return LastName + " " + FirstName;
        }

        public bool Insert()
        {
            return Client_Dal.Insert(FirstName, LastName, Gender, MobilePhone,
            PrefixMobile, BirthDate, Email, ClientId, City.Id);
        }

        public bool Update()
        {
            return Client_Dal.Update(Id, FirstName, LastName, Gender, MobilePhone,
            PrefixMobile, BirthDate, Email, ClientId, City.Id);
        }

        public bool Delete()
        {
            return Client_Dal.Delete(Id);
        }
    }
}
