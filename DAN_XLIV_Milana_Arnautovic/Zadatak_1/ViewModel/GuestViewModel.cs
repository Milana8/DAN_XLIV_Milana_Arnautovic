using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Zadatak_1.Command;
using Zadatak_1.Model;
using Zadatak_1.View;

namespace Zadatak_1.ViewModel
{
    class GuestViewModel: ViewModelBase
    {
        GuestView guestView;
        Service service;
        
        
        private int totalPrice = 0;
        static string JMBG = " ";

        #region Constructor
        public GuestViewModel(GuestView guestViewOpen)
        {
            guestView = guestViewOpen;
            service = new Service();
            order = new tblOrder();
            ProductList = service.GetAllProducts();
            OrderProduct = new List<tblOrder>();

        }
        #endregion

        #region Properites
        private Visibility viewProduct = Visibility.Collapsed;
        public Visibility ViewProduct
        {
            get { return viewProduct; }
            set
            {
                viewProduct = value;
                OnPropertyChanged("ViewProducts");
            }
        }

       
        private List<tblProduct> productList;
        public List<tblProduct> ProductList
        {
            get { return productList; }
            set
            {
                productList = value;
                OnPropertyChanged("ProductList");
            }
        }

        
        private tblProduct product;
        public tblProduct Product
        {
            get
            { return product; }
            set
            {
                product = value;
                OnPropertyChanged("Product");
            }
        }

       
        private string totalP = "0";
        public string TotalP
        {
            get
            {
                return totalP;
            }
            set
            {
                totalP = value;
                OnPropertyChanged("TotalP");
            }
        }

       

        private tblOrder order;
        public tblOrder Order
        {
            get { return order; }
            set
            {
                order = value;
                OnPropertyChanged("Order");
            }
        }

       
        private List<tblOrder> orderProduct;
        public List<tblOrder> OrderProduct
        {
            get
            {
                return orderProduct;
            }
            set
            {
                orderProduct = value;
                OnPropertyChanged("OrederProduct");
            }
        }
        #endregion

        #region Commands
       
        private ICommand showProduct;
        public ICommand ShowProduct
        {
            get
            {
                if (showProduct == null)
                {
                    showProduct = new RelayCommand(param => ShowProductExecute(), param => CanShowMenuExecute());
                }
                return showProduct;
            }
        }

        
        private void ShowProductExecute()
        {
            try
            {
                ViewProduct = Visibility.Visible;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

       
        private bool CanShowMenuExecute()
        {
            return true;
        }
        

       

       
        private ICommand close;
        public ICommand Close
        {
            get
            {
                if (close == null)
                {
                    close = new RelayCommand(param => CloseExecute(), param => CanCloseExecute());
                }
                return close;
            }
        }

        
        private void CloseExecute()
        {
            try
            {
                guestView.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

       
        private bool CanCloseExecute()
        {
            return true;
        }

        
        private ICommand addToOrder;
        public ICommand AddToOrder
        {
            get
            {
                if (addToOrder == null)
                {
                    addToOrder = new RelayCommand(param => AddToOrderExecute(), param => CanAddToOrderExecute());
                }
                return addToOrder;
            }
        }

       
        private void AddToOrderExecute()
        {
            try
            {
                Order.ProductID = Product.ProductID;
                Order.Username = JMBG;
                if (Order.Quantity <= 0)
                {
                    MessageBox.Show("Choose what you want to order");

                    return;
                }

                Order.OrderStatus = "On hold";
                service.CreateOrder(Order);

                if (Order != null)
                {
                    MessageBox.Show(Order.Quantity.ToString());
                    totalPrice -= (Order.Quantity * Product.Price);

                }
                totalPrice += (Order.Quantity * Product.Price);

                TotalP= totalPrice.ToString();
                string outputMessage = string.Format("Your order contain {0} {1}", Order.Quantity, Product.ProductName);
                MessageBox.Show(outputMessage);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        
        private bool CanAddToOrderExecute()
        {
            return true;
        }


       
        #endregion
    }
}
