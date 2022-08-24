using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacadeLayer;
using EntityLayer;

namespace BusinessLayer
{
    public class BLCustomer
    {
        public static List<TblCustomer> BLCustomerList()
        {
            return DALCustomer.CustomerList();
        }

        public static void BLAddCustomer(TblCustomer p)
        {
            if (p.CustomerName != "" && p.CustomerSurname != "")
            {
                DALCustomer.Add(p);
            }
            else
            {
                //hata mesajları
            }
        }

        public static void BLDeleteCustomer(int id)
        {
            if (id != 0)
            {
                DALCustomer.DeleteCustomer(id);
            }
        }

        public static void BLUpdateCustomer(TblCustomer p,int id)
        {
            if (p.CustomerName != "" && p.CustomerSurname.Length >= 4)
            {
                DALCustomer.UpdateCustomer(p,id);
            }
        }

        public static void BLAddHistory(TblHistory p,string d1,string d2)
        {
            if (p.CustomerId != 0)
            {
                DALCustomer.AddHistory(p,d1,d2);
            }
        }
    }
}
