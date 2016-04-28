using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

using System.Web.Script.Serialization;
using WcfServicePhoto;

namespace WcfServicePhoto
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        //public tblPackages[]
        //{
        //    using (ist420row3Entities entities = new ist420row3Entities())
        //    {
        //        var Package = from Pack in entities.tblPackages select Package;
        //        return Package.ToArray();
        //    }
        //}

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

     
          public string CreateCustomer(string custName, string custSSN, string custEmail, string custPhone)
        {

            using (ist420row3Entities1 entities = new ist420row3Entities1())
            {

                tblCustomer cust = new tblCustomer();
                cust.CustomerName = custName;
                cust.CustomerSSN = custSSN;
                cust.CustomerEmail = custEmail;
                cust.CustomerPhone = custPhone;
                entities.tblCustomers.Add(cust);
                entities.SaveChanges();
                if (cust.CustomerID > 0)
                    return cust.CustomerID.ToString();
                else
                    return "false";

            }
        }
        public bool UpdateCustomer(int custID, string custName, string custSSN, string custEmail, string custPhone)
        {
            using (ist420row3Entities1 entities = new ist420row3Entities1())
            {
                tblCustomer cust = new tblCustomer();
                try
                {
                    cust = entities.tblCustomers.Find(custID);
                    cust.CustomerName = (custName == null) ? cust.CustomerName : custName;
                    cust.CustomerSSN = (custSSN == null) ? cust.CustomerSSN : custSSN;
                    cust.CustomerEmail = (custEmail == null) ? cust.CustomerEmail : custEmail;
                    cust.CustomerPhone = (custPhone == null) ? cust.CustomerPhone : custPhone;
                    entities.SaveChanges();
                }
                catch (Exception)
                {
                    return false;
                }

                if (cust.CustomerID > 0)
                    return true;
                else
                    return false;
            }
        }

        public tblCustomer ReadCustomer(int CustID)
        {
            using (ist420row3Entities1 entities = new ist420row3Entities1())
            {
                tblCustomer cust = new tblCustomer();
                try
                {
                    cust = entities.tblCustomers.Find(CustID);
                }
                catch (Exception)
                {
                    //TODO add to log
                }
                return cust;
            }
        }

        public tblCustomer[] ReadCustomerList()
        {
            using (ist420row3Entities1 entities = new ist420row3Entities1())
            {
                var customers = from s in entities.tblCustomers select s;
                return customers.ToArray();
            }
        }

        public bool DeleteCustomer(int custID)
        {
            using (ist420row3Entities1 entities = new ist420row3Entities1())
            {
                tblCustomer cust = new tblCustomer();
                try
                {
                    cust = entities.tblCustomers.Find(custID);
                    entities.tblCustomers.Remove(cust);
                    entities.SaveChanges();
                    return true;
                }
                catch
                {

                    return false;


   
        }
            }
        }

        public Boolean SavePackageType(String packageType, decimal cost)
        {
            Items packageType1 = new Items();
            packageType1.packageType = packageType;
            packageType1.cost = cost;
            //write the database
            return true;

            using (ist420row3Entities1 row3Entity = new ist420row3Entities1())
            {
                tblPackage mi = new tblPackage();
                mi.fldPackageType = packageType;
                mi.fldPackageCost = cost;
                row3Entity.tblPackages.Add(mi);
                row3Entity.SaveChanges();
                if (mi.fldPackageID > 0)
                    return true;
                else
                    return false;
            }
        }
    }
}
    


     
        



       
        
    


