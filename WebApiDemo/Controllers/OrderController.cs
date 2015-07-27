using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiDemo.Controllers
{
    using WebApiDemo.Models;

    public class OrderController : ApiController
    {
        private IRepository _repository;

        public OrderController(IRepository repository)
        {
            this._repository = repository;
        }

        public IQueryable<Order> Get()

        {
            return this._repository.GetAllOrders();
        }

        public IQueryable<Order> Get(bool includeDetails)
        {
            return includeDetails
                ? this._repository.GetAllOrdersWithDetails()
                : this._repository.GetAllOrders();
        }

        public Order Get(int id)
        {
            return this._repository.GetOrder(id);
        }
    }
}
