using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadatak_1.Model;

namespace Zadatak_1
{
    class Service
    {
        public List<tblProduct> GetAllProducts()
        {
            try
            {
                using (DAN_XLIVEntities context = new DAN_XLIVEntities())
                {
                    List<tblProduct> list = new List<tblProduct>();
                    list = (from x in context.tblProducts select x).ToList();
                    return list;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Exception" + ex.Message.ToString());
                return null;
            }
        }

        public List<tblOrder> GetAllOrders()
        {
            try
            {
                using (DAN_XLIVEntities context = new DAN_XLIVEntities())
                {
                    List<tblOrder> orders = new List<tblOrder>();
                    orders = (from x in context.tblOrders select x).ToList();
                    return orders;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Exception" + ex.Message.ToString());
                return null;
            }
        }

       

        public void DeleteOrder(int orderID)
        {
            try
            {
                using (DAN_XLIVEntities context = new DAN_XLIVEntities())
                {
                    tblOrder orderToDelete = (from o in context.tblOrders where o.OrderID == orderID select o).First();
                    context.tblOrders.Remove(orderToDelete);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Exception" + ex.Message.ToString());
            }
        }

        
        public tblOrder CreateOrder(tblOrder order)
        {
            try
            {
                using (DAN_XLIVEntities context = new DAN_XLIVEntities())
                {

                    tblOrder newOrder = new tblOrder();
                    newOrder.Username = order.Username;
                    newOrder.ProductID = order.ProductID;
                    newOrder.Quantity = order.Quantity;
                    newOrder.OrderDate = DateTime.Now;
                    newOrder.OrderStatus = order.OrderStatus;
                    context.tblOrders.Add(newOrder);
                    context.SaveChanges();
                    order.OrderID = newOrder.OrderID;
                    return order;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Exception" + ex.Message.ToString());
                return null;
            }
        }

        public tblOrder ChangeOrderStatus(tblOrder order)
        {
            try
            {
                using (DAN_XLIVEntities context = new DAN_XLIVEntities())
                {
                    tblOrder orderTochange = (from o in context.tblOrders where o.OrderID == order.OrderID select o).First();
                    orderTochange.OrderStatus = order.OrderStatus;

                    context.SaveChanges();
                    return order;

                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Exception" + ex.Message.ToString());
                return null;
            }
        }

        private vwOrder FindOrderByID(int id)
        {
            try
            {
                using (DAN_XLIVEntities context = new DAN_XLIVEntities())
                {
                    vwOrder order = (from x in context.vwOrders where x.OrderId == id select x).FirstOrDefault();
                    return order;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Exception " + ex.Message.ToString());
                return null;
            }

        }
    }
}

