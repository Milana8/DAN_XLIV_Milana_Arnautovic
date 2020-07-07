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
    class EmployeeViewModel : ViewModelBase
    {
        EmployeeView view;
        Service service = new Service();

        #region Property

        private tblOrder order;
        public tblOrder Order
        {
            get
            {
                return order;
            }
            set
            {
                order = value;
                OnPropertyChanged("Order");
            }
        }

        private List<tblOrder> orderList;
        public List<tblOrder> OrderList
        {
            get
            {
                return orderList;
            }
            set
            {
                orderList = value;
                OnPropertyChanged("OrderList");
            }
        }

        private Visibility viewOrder = Visibility.Visible;
        public Visibility ViewOrder
        {
            get
            {
                return viewOrder;
            }
            set
            {
                viewOrder = value;
                OnPropertyChanged("ViewOrder");
            }
        }


        #endregion

        #region Constructor
        
        
        public EmployeeViewModel(EmployeeView employeeOpen)
        {
            view = employeeOpen;
            using (DAN_XLIVEntities context = new DAN_XLIVEntities())
            {
                OrderList = context.tblOrders.ToList();
            }
        }
        #endregion

        

       
        

          

    }
}

