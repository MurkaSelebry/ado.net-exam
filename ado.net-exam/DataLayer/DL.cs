using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ado.net_exam.DataLayer
{
    public static class DL
    {
        public static class tours
        {
            public static IEnumerable<diap_start_date_Result> diap_tours(DateTime d1, DateTime d2)
            {
                using (var db = new Tourist_Entities())
                {
                    List<diap_start_date_Result> tours = new List<diap_start_date_Result>();
                    var res = db.diap_start_date(d1, d2).ToList();
                    foreach (var item in res)
                    {
                        tours.Add(item);
                    }
                    return tours;
                }
            }
            public static IEnumerable<transport_method_Result> transport(string transM)
            {
                using (var db = new Tourist_Entities())
                {
                    List<transport_method_Result> trans = new List<transport_method_Result>();
                    var res = db.transport_method(transM).ToList();
                    foreach (var item in res)
                    {
                        
                        trans.Add(
                        
                            item
                        ) ;
                    }
                    return trans;
                }
            }
            public static IEnumerable<popular_tour_Result> tour()
            {
                using (var db = new Tourist_Entities())
                {
                    List<popular_tour_Result> tours = new List<popular_tour_Result>();
                    var res = db.popular_tour().ToList();
                    foreach (var item in res)
                    {
                        tours.Add(item);
                    }
                    return tours;
                }
            }
            public static IEnumerable<unpopular_tour_Result> untour()
            {
                using (var db = new Tourist_Entities())
                {

                    List<unpopular_tour_Result> tours = new List<unpopular_tour_Result>();
                    var res = db.unpopular_tour().ToList();
                    foreach (var item in res)
                    {
                        tours.Add(item);
                    }
                    return tours;
                }
            }
        }
        public static class customers
        {
            public static bool is_in_tour(string fio)
            {
                using (var db = new Tourist_Entities())
                {
                    var res = db.in_tour(fio).Cast<bool>().First();
                    return res;
                }
            }
            public static IEnumerable<string> listOfTours(string fio)
            {
                using (var db = new Tourist_Entities())
                {
                    List<string> tourists = new List<string>();
                    var res = db.show_list(fio).ToList();
                    foreach (var item in res)
                    {
                        tourists.Add(item);
                    }
                    return tourists;
                }
            }
            public static void insertCustomer(Клиенты_агенства customer)
            {
                using (var db = new Tourist_Entities())
                {
                    var customers = db.Set<Клиенты_агенства>();
                    customers.Add(new Клиенты_агенства { 
                        FIO=customer.FIO,Phone=customer.Phone,Email=customer.Email,DateOfBirth=customer.DateOfBirth,FutureTours=customer.FutureTours,PastTours=customer.PastTours });

                    db.SaveChanges();
                }
            }
            public static void updateCustomer(Клиенты_агенства customer)
            {
                using(var db = new Tourist_Entities())
                {
                    var d = (from t in db.Клиенты_агенства
                             where t.Email == customer.Email
                             select t).FirstOrDefault();
                    if (d != null) d = customer;
                    db.SaveChanges();
                }
            }
            public static void deleteCustomer(string email)
            {
                using (var db = new Tourist_Entities())
                {
                    var d = (from t in db.Клиенты_агенства
                             where t.Email == email
                             select t).FirstOrDefault();
                    if (d != null) db.Клиенты_агенства.Remove(d);
                    db.SaveChanges();
                }
            }
        }
        public static class tourists
        {
            public static IEnumerable<string> tourist()
            {
                using (var db = new Tourist_Entities())
                {
                    List<string> tourists = new List<string>();
                    var res = db.popular_tourist().ToList();
                    foreach (var item in res)
                    {
                        tourists.Add(item);
                    }
                    return tourists;
                }
            }
            public static int count_countries(string country)
            {
                using (var db = new Tourist_Entities())
                {
                    var res = db.visit_country(country);
                    return res;
                }
            }
            public static IEnumerable<string> where_tourist(string fio)
            {
                using (var db = new Tourist_Entities())
                {
                    List<string> tourists = new List<string>();
                    var res = db.where_is_tourist(fio).ToList();
                    foreach (var item in res)
                    {
                        tourists.Add(item);
                    }
                    return tourists;
                }
            }
        }
        public static class arc_tours
        {
            public static IEnumerable<popular_arc_tour_Result> arc()
            {
                using (var db = new Tourist_Entities())
                {
                    List<popular_arc_tour_Result> tours = new List<popular_arc_tour_Result>();
                    var res = db.popular_arc_tour().ToList();
                    foreach (var item in res)
                    {
                        tours.Add(item);
                    }
                    return tours;
                }
            }
        }
        
    }
}
