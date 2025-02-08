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
    public class ClientArr : ArrayList
    {
        public void Fill()
        {
            //להביא מה-DAL טבלה מלאה בכל הלקוחות
            DataTable dataTable = Client_Dal.GetDataTable();

            //להעביר את הערכים מהטבלה לתוך אוסף הלקוחות
            //להעביר כל שורה בטבלה ללקוח

            DataRow dataRow;
            Client client;

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];
                client = new Client(dataRow);
                this.Add(client);
            }
        }

        public ClientArr Filter(int id, string lastName, string mobilePhone, int clientId)
        {
            ClientArr clientArr = new ClientArr();

            for (int i = 0; i < this.Count; i++)
            {
                //הצבת הלקוח הנוכחי במשתנה עזר - לקוח

                Client client = (this[i] as Client);
                if
                (
                //מזהה 0 – כלומר, לא נבחר מזהה בסינון
                (id <= 0 || client.Id == id)
                && client.LastName.StartsWith(lastName)
                && (client.PrefixMobile + client.MobilePhone.ToString()).Contains(mobilePhone)
                && (clientId <= 0 || client.ClientId == clientId)
                )
                    //הלקוח ענה לדרישות הסינון - הוספת הלקוח לאוסף הלקוחות המוחזר
                    clientArr.Add(client);
            }
            return clientArr;
        }
        public int Filter(int minAge, int maxAge)
        {
            ClientArr clientArr = new ClientArr();
            Client client;
            int age;

            for (int i = 0; i < this.Count; i++)
            {
                //הצבת ההזמנה הנוכחית במשתנה עזר - הזמנה
                client = (this[i] as Client);
                age = DateTime.Today.Year - client.BirthDate.Year;

                if (age >= minAge && age <= maxAge)
                {
                    //ההזמנה עונה לדרישות הסינון - הוספת הההזמנה לאוסף ההזמנות המוחזר
                    clientArr.Add(client);
                }
            }

            return clientArr.Count;
        }

        //public double GetAverageClientAge()
        //{
        //    Client client;

        //    double sumAge = 0;

        //    if (this.Count == 0)
        //    {
        //        return 0;
        //    }
        //    else
        //    {
        //        for (int i = 0; i < this.Count; i++)
        //        {
        //            client = (this[i] as Client);

        //            sumAge += DateTime.Today.Year - client.BirthDate.Year;
        //        }
        //        return sumAge / this.Count;
        //    }
        //}

        public bool DoesExist(City curCity)
        {
            //מחזירה האם לפחות לאחד מהלקוחות יש את היישוב
            for (int i = 0; i < this.Count; i++)
            {
                if ((this[i] as Client).City.Id == curCity.Id)
                    return true;
            }
            return false;
        }
    }
}
