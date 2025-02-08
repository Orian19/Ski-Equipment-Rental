using Ski_Equipment_Rental.DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ski_Equipment_Rental.BL
{
    public class SkillLevelArr : ArrayList
    {
        public void Fill()
        {
            //-DAL טבלה מלאה בכל הקטגוריות
            DataTable dataTable = SkillLevel_Dal.GetDataTable();

            //להעביר את הערכים מהטבלה לתוך אוסף הקטגוריות
            //להעביר כל שורה בטבלה לקטגוריה

            DataRow dataRow;
            SkillLevel skillLevel;

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];
                skillLevel = new SkillLevel(dataRow);
                this.Add(skillLevel);
            }
        }

        public bool IsContain(string levelName)
        {
            //בדיקה האם יש רמת מיומנות עם אותו שם

            string curLevelName;

            for (int i = 0; i < this.Count; i++)
            {
                curLevelName = (this[i] as SkillLevel).LevelName;

                if (curLevelName == levelName)
                    return true;
            }
            return false;
        }

        public SkillLevel GetSkillLevelWithMaxId()
        {
            //מחזירה את הרמת מיומנות עם המזהה הגבוה ביותר

            SkillLevel maxSkillLevel = new SkillLevel();
            for (int i = 0; i < this.Count; i++)
            {
                if ((this[i] as SkillLevel).Id > maxSkillLevel.Id)
                    maxSkillLevel = (this[i] as SkillLevel);
            }
            return maxSkillLevel;
        }
    }
}
