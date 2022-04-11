using System;
using System.Collections.Generic;
using System.Text;
using ModernLearns.Core.DTOs.Order;
using ModernLearns.DataLayer.Entities.Order;

namespace ModernLearns.Core.Services.Interfaces
{
    public interface IOrderService
    {
        int AddOrder(string userName, int courseId);
        void UpdatePriceOrder(int orderId);
        void UpdateOrder(Order order);
        Order GetOrderForUserPanel(string userName,int orderId);
        Order GetOrderById(int orderId);
        bool FinalyOrder(string userName, int orderId);
        List<Order> GetUserOrders(string userName);
        bool IsUserInCourse(string userName, int courseId);

        #region Discount
        DiscountUseType UseDiscount(int orderId, string code);
        void AddDiscount(Discount discount);
        List<Discount> GetAllDiscount();
        Discount GetDiscountById(int discountId);
        void UpdateDiscount(Discount discount);
        bool CheckExistCode(string code);
        #endregion
    }
}
