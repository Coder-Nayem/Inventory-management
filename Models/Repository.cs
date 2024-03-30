using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationMVC.Models
{
    public class Repository
    {
        static List<InvoiceInfo> Data = new List<InvoiceInfo>();
        public Repository()
        {
           
            if (Data.Count ==0)
            {
                

                for (int i = 1; i <= 3; i++) 
                {

                    InvoiceInfo a = new InvoiceInfo();
                    a.Name = i.ToString();
                    

                    a.Details.Add(new Productdetails()
                    {
                        ProductName = "Laptop",
                        Price = 45000,
                        Quantity = 5,
                        
                    });
                    a.Details.Add(new Productdetails()
                    {
                        ProductName = "TV",
                        Price = 20000,
                        Quantity = 2,
                        
                    });
                    a.Details.Add(new Productdetails()
                    {
                        ProductName = "AC",
                        Price =30000 ,
                        Quantity = 2008,
                        
                    });
                    Data.Add(a);

                }

            }
        }

        public List<InvoiceInfo> GetList()
        {

            return Data;
        }

        internal void Delete(Guid id)
        {
            Data.Remove(Get(id));
        }

        internal InvoiceInfo Get(Guid id)
        {
            return Data.Find(m => m.Id == id);
        }

        internal void Invoice(InvoiceInfo p)
        {
            throw new NotImplementedException();
        }

        internal void Save(InvoiceInfo applicant)
        {
            Data.Add(applicant);
        }

        internal void UpdateInvoice(InvoiceInfo p)
        {
            var index = Data.FindIndex(m => m.Id == p.Id);

            if(index != -1)
            {
                Data[index] = p;
            }
        }
    }
}