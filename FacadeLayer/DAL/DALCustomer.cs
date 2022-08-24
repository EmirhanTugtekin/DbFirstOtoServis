using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeLayer
{
    public class DALCustomer
    {
        public static List<TblCustomer> CustomerList()
        {
            DbOtoServisEntities entities = new DbOtoServisEntities();

            var values = from x in entities.TblCustomer
                             select new
                             {
                                 x.CustomerId,
                                 x.CustomerName,
                                 x.CustomerSurname,
                                 x.CustomerPhone,
                                 x.CustomerBringDate,
                                 x.CustomerDeliveryDate,
                                 x.CustomerRequest,
                                 x.TblBrand.BrandName,
                                 x.TblMechanic.MechanicName,
                                 x.TblAdmin.AdminName,
                                 x.CustomerCarPlateNumber
                             };
                return (List<TblCustomer>)values;
        }

        public static void Add(TblCustomer p)
        {
            DbOtoServisEntities entities = new DbOtoServisEntities();

            TblCustomer tblCustomer = new TblCustomer();

            tblCustomer.CustomerName = p.CustomerName;
            tblCustomer.CustomerSurname=p.CustomerSurname;
            tblCustomer.CustomerPhone = p.CustomerPhone;
            tblCustomer.CustomerBringDate = p.CustomerBringDate;
            tblCustomer.CustomerDeliveryDate= p.CustomerDeliveryDate;
            tblCustomer.CustomerRequest = p.CustomerRequest;
            tblCustomer.CustomerCarBrandId = p.CustomerCarBrandId;
            tblCustomer.CustomerMechanicId = p.CustomerMechanicId;
            tblCustomer.CustomerAdminId = p.CustomerAdminId;
            tblCustomer.CustomerCarPlateNumber = p.CustomerCarPlateNumber;

            entities.TblCustomer.Add(tblCustomer);
            entities.SaveChanges();

        }

        public static void AddHistory(TblHistory p, string d1, string d2)
        {
            DbOtoServisEntities entities = new DbOtoServisEntities();

            p.CustomerId = Convert.ToInt32(d1);
            p.Info = d2;

            entities.TblHistory.Add(p);
            entities.SaveChanges();
        }

        public static void DeleteCustomer(int id)
        {
            DbOtoServisEntities entities = new DbOtoServisEntities();

            var values=entities.TblCustomer.Where(x=>x.CustomerId==id).FirstOrDefault();
            entities.TblCustomer.Remove(values);
            entities.SaveChanges();
        }

        public static void UpdateCustomer(TblCustomer p,int id)
        {
            DbOtoServisEntities entities = new DbOtoServisEntities();

            var values = entities.TblCustomer.Where(x => x.CustomerId == p.CustomerId).FirstOrDefault();
            values.CustomerName = p.CustomerName;
            values.CustomerSurname = p.CustomerSurname;
            values.CustomerPhone = p.CustomerPhone;
            values.CustomerBringDate = p.CustomerBringDate;
            values.CustomerDeliveryDate = p.CustomerDeliveryDate;
            values.CustomerRequest = p.CustomerRequest;
            values.CustomerCarBrandId = p.CustomerCarBrandId;
            values.CustomerMechanicId = p.CustomerMechanicId;
            values.CustomerAdminId = p.CustomerAdminId;
            values.CustomerCarPlateNumber = p.CustomerCarPlateNumber;

            entities.SaveChanges();
        }
    }
}
