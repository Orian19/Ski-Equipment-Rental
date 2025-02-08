using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ski_Equipment_Rental.BL
{
    public class Main
    {
        #region Members - תכונות
        private int m_Id;
        private string m_UserName;
        private string m_Password;
        private bool m_IsAdmin;

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
        public string UserName
        {
            get
            {
                return m_UserName;
            }

            set
            {
                m_UserName = value;
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

        #endregion

        #region Constructors - בנאים
        public Main()
        {
        }
        public Main(DataRow dataRow)
        {
            this.Id = (int)dataRow["ID"];
            this.m_UserName = dataRow["UserName"].ToString();
            this.m_Password = dataRow["Password"].ToString();
            this.m_IsAdmin = (bool)dataRow["IsAdmin"];
        }
        #endregion

    }
}
