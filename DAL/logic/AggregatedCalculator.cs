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

        public OrderCostInfo GetOrderCostInfo(int OrderID)
        {
            return null;
        }
    }
}
