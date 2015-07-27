namespace WebApiDemo.Models
{
    using System.Linq;

    public interface IRepository
    {
        IQueryable<Order> GetAllOrders();
        IQueryable<Order> GetAllOrdersWithDetails();
        Order GetOrder(int id);
    }
}