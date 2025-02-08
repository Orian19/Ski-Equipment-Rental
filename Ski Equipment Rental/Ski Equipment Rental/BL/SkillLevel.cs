using Ski_Equipment_Rental.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ski_Equipment_Rental.BL
{
    public class SkillLevel
    {
        #region Members - תכונות
        private int m_Id;
        private string m_LevelName;

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
        public string LevelName
        {
            get
            {
                return m_LevelName;
            }

            set
            {
                m_LevelName = value;
            }
        }
        #endregion

        #region Constructors - בנאים
        public SkillLevel()
        {
        }
        public SkillLevel(DataRow dataRow)
        {
            //מייצרת רמת מיומנות מתוך שורת הקטגוריות

            this.Id = (int)dataRow["ID"];
            this.m_LevelName = dataRow["LevelName"].ToString();
        }
        #endregion

        public override string ToString()
        {
            return m_LevelName;
        }

        public bool Insert()
        {
            return SkillLevel_Dal.Insert(m_LevelName);
        }

        public bool Update()
        {
            return SkillLevel_Dal.Update(m_Id, m_LevelName);
        }

        public bool Delete()
        {
            return SkillLevel_Dal.Delete(m_Id);
        }
    }
}
