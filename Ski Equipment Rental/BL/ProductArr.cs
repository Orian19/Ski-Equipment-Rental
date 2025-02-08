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
    public class ProductArr : ArrayList
    {
        public void Fill()
        {
            //להביא מה-DAL טבלה מלאה בכל המוצרים
            DataTable dataTable = Product_Dal.GetDataTable();

            //להעביר את הערכים מהטבלה לתוך אוסף המוצרים
            //להעביר כל שורה בטבלה למוצר

            DataRow dataRow;
            Product product;

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];
                product = new Product(dataRow);
                this.Add(product);
            }
        }

        public ProductArr Filter(int id, string Product, Company company, Category category, 
            int count, SkillLevel skillLevel)
        {
            ProductArr productArr = new ProductArr();

            for (int i = 0; i < this.Count; i++)
            {
                //הצבת המוצר הנוכחי במשתנה עזר - מוצר

                Product product = (this[i] as Product);
                if (

                //סינון לפי מזהה המוצר

                (id <= 0 || product.Id == id)

                //סינון לפי שם המוצר

                && product.ProductName.StartsWith(Product)

                //סינון לפי החברה
                && (company == null || company.Id == -1 || product.Company.Id == company.Id)
                //סינון לפי קטגוריה
                && (category == null || category.Id == -1 || product.Category.Id == category.Id)
                //סינון לפי כמות מוצרים
                && (count == 0 || product.Count == count)
                //סינון לפי רמת מיומנות שדורש המוצר בשביל השימוש    
                && (skillLevel == null || skillLevel.Id == -1 || product.SkillLevel.Id == skillLevel.Id)
                )
                {
                    //המוצר ענה לדרישות החיפוש – הוספה שלו לאוסף המוחזר
                    productArr.Add(product);
                    if (id > 0)
                        break;
                }
            }
            return productArr;
        }

        public ProductArr Filter(int count)
        {
            ProductArr prductArr = new ProductArr();
            Product product;

            for (int i = 0; i < this.Count; i++)
            {
                //הצבת המוצר הנוכחי במשתנה עזר - מוצר
                product = (this[i] as Product);
                if
                (
                //סינון מוצרים שנגמרו במלאי
                (product.Count == count)
                )
                {
                    //המוצר עונה לדרישות הסינון - הוספת המוצר לאוסף המוצרים המוחזר
                    prductArr.Add(product);
                }
            }

            return prductArr;
        }

        #region DoesExist
        public bool DoesExistCompany(Company curCompany)
        {
            //מחזירה האם לפחות לאחד מהמוצרים יש את החברה
            for (int i = 0; i < this.Count; i++)
            {
                if ((this[i] as Product).Company.Id == curCompany.Id)
                    return true;
            }
            return false;
        }
        public bool DoesExistCategory(Category curCategory)
        {
            //מחזירה האם לפחות לאחד מהמצורים יש את הקטגוריה
            for (int i = 0; i < this.Count; i++)
            {
                if ((this[i] as Product).Category.Id == curCategory.Id)
                    return true;
            }
            return false;
        }
        public bool DoesExistSkillLevel(SkillLevel curSkillLevel)
        {
            //מחזירה האם לפחות לאחד מהמצורים יש את הקטגוריה
            for (int i = 0; i < this.Count; i++)
            {
                if ((this[i] as Product).SkillLevel.Id == curSkillLevel.Id)
                    return true;
            }
            return false;
        } 
        #endregion

        public bool IsContains(Product product)
        {
            //מחזירה האם האוסף מכיל כבר את המוצר

            for (int i = 0; i < this.Count; i++)
            {
                if ((this[i] as Product).Id == product.Id)
                    return true;
            }
            return false;
        }

        public void Update()
        {
            //מעדכנת את אוסף המוצרים

            for (int i = 0; i < this.Count; i++)
            {
                (this[i] as Product).Update();
            }
        }

        public void Remove(ProductArr productArr)
        {
            //מסירה מהאוסף הנוכחי את האוסף המתקבל

            for (int i = 0; i < productArr.Count; i++)
            {
                this.Remove(productArr[i] as Product);
            }
        }
        public void Remove(Product product)
        {
            //מסירה מהאוסף הנוכחי את הפריט המתקבל

            for (int i = 0; i < this.Count; i++)
            {
                if ((this[i] as Product).Id == product.Id)
                    this.RemoveAt(i);
            }
        }

        public void UpdateProduct(Product product)
        {
            //מעדכנת את הכמות של הפריט באוסף הנוכחי

            for (int i = 0; i < this.Count; i++)
            {
                if ((this[i] as Product).Id == product.Id)
                {
                    this[i] = product;
                    break;
                }
            }
        }
    }
}
