using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComputerStore.DAL;
using ComputerStore.Models;

namespace ComputerStore.BLL
{
    public class StatisticsService
    {
        private readonly StatisticsRepository _repository;

        public StatisticsService(string connectionString)
        {
            _repository = new StatisticsRepository(connectionString);
        }

        /// <summary>
        /// Lấy doanh thu theo loại sản phẩm và khoảng thời gian
        /// </summary>
        public List<ThongKe> GetRevenueByCategory(int maLoai, DateTime fromDate, DateTime toDate)
        {
            return _repository.GetRevenueByCategory(maLoai, fromDate, toDate);
        }

        /// <summary>
        /// Lấy doanh thu theo khoảng thời gian
        /// </summary>
        public List<ThongKe> GetRevenueByDate(DateTime fromDate, DateTime toDate)
        {
            return _repository.GetRevenueByDate(fromDate, toDate);
        }
    }
}
