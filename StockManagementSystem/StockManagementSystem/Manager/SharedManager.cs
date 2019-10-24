using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystem.Model;
using StockManagementSystem.Repository;

namespace StockManagementSystem.Manager
{
    public class SharedManager
    {
        SharedRepository _sharedRepository=new SharedRepository();
        public List<PurchaseReportViewModel> GetPurchaseReport()
        {
            return _sharedRepository.GetPurchaseReport();
        }

        public List<PurchaseReportViewModel> SearchPurchaseReportByDate(string startDate,string endDate)
        {
            return _sharedRepository.SearchPurchaseReportByDate(startDate,endDate);
        }
    }
}
