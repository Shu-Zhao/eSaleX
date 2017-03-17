using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eSaleX.Models
{
    public class OrderService
    {
        /// <summary>
        /// 新增訂單
        /// </summary>
        /// <param name="order"></param>
        public void InsertOrder(Models.Order order)
        {
            //todo
        }
        /// <summary>
        /// 依照Id 取得訂單資料
        /// </summary>
        /// <returns></returns>
        public Models.Order GetOrderById(string orderId)
        {
            Models.Order result = new Order();
            result.CustId = "GSS";
            result.CustName = "叡揚資訊";
            //todo
            return result;
        }
        /// <summary>
        /// 依照條件取得訂單資料
        /// </summary>
        /// <returns></returns>
        public List<Models.Order> GetOrderByCondtioin()
        {
            //todo
            return new List<Order>();
        }
        /// <summary>
        /// 刪除訂單
        /// </summary>
        public void DeleteOrderById(string orderId)
        {
            //todo
        }
        /// <summary>
        /// 更新訂單
        /// </summary>
        public void UpdateOrder(Models.Order order)
        {
            //todo
        }

    }
}