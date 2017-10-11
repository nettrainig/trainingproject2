using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using DAL;
using DAL.dto;

namespace DAL.logic
{
    public class AggregatedCalculator
    {
        private ILog _logger;
        private Test2Context _context;
        public AggregatedCalculator(Test2Context context, ILog logger)
        {
            _logger = logger;
            _context = context;
        }

        public OrderCostInfo GetOrderCostInfo(int orderID)
        {
            return new OrderCostInfo
            {
                OrderID = orderID,
                TotalCost =
                    (from od in _context.OrderDetails
                     join p in _context.Products on od.ProductID equals p.ID
                     where od.OrderID == orderID
                     select new { OrderDetailPrice = od.ProductQuantity * p.Price }).Sum(o => o.OrderDetailPrice)
            };
        }

        public IEnumerable<ClientOrderInfo> GetClientOrdersInfo(int mostRecentCount, int clientID)
        {
            return
                (from od in _context.OrderDetails
                 join p in _context.Products on od.ProductID equals p.ID
                 join o in _context.Orders on od.OrderID equals o.ID
                 join c in _context.Clients on o.ClientID equals c.ID
                 where c.ID == clientID
                 orderby o.DateCreated
                 select new ClientOrderInfo { ClientID = clientID, OrderID = od.OrderID, TotalCost = od.ProductQuantity * p.Price }
                ).Take<ClientOrderInfo>(mostRecentCount);
        }

        public ClientTotalOrderInfo GetClientTotalOrdersInfo(int ClientID)
        {
            SqlParameter clientid = new SqlParameter("@ClientID", ClientID);
            //var a =_context.Database.SqlQuery<ClientTotalOrderInfo>("GetClientOrders @ClientID", clientid).Single();
            var b = _context.Database.SqlQuery<ClientTotalOrderInfo>("GetClientOrders 2").Single();
            return b;
        }
    }
}
