using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Managerment.DTO
{
    public class Menu
    {
        public Menu(string drinkName, int count, float price, float totalPrice = 0)
        {
            this.DrinkName = drinkName;
            this.Count = count;
            this.Price = price;
            this.TotalPrice = totalPrice;
        }
        public Menu(DataRow row)
        {
            this.DrinkName = row["NAME"].ToString();
            this.Count =  (int)row["COUNT"];
            this.Price = (float)Convert.ToDouble(row["PRICE"].ToString());
            this.TotalPrice = (float)Convert.ToDouble(row["TotalPrice"].ToString());
        }
        private float totalPrice;

        public float TotalPrice
        {
            get { return totalPrice; }
            set { totalPrice = value; }
        }
        private float price;

        public float Price
        {
            get { return price; }
            set { price = value; }
        }
        private int count;

        public int Count
        {
            get { return count; }
            set { count = value; }
        }
        private string drinkName;

        public string DrinkName
        {
            get { return drinkName; }
            set { drinkName = value; }
        }
    }
}
