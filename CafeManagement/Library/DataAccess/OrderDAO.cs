﻿using Library.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAccess
{
    public class OrderDAO
    {
        private static OrderDAO instance = null;
        private static readonly object instancelock = new object();
        private OrderDAO() { }
        public static OrderDAO Instance
        {
            get
            {
                lock (instancelock)
                {
                    if (instance == null)
                    {
                        instance = new OrderDAO();
                    }
                    return instance;
                }
            }
        }

        public bool CreateOrder(List<Product> listOrder, Customer customer, staff staff, double amount)
        {
            using (var db = new CoffeeShopManagementContext())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        Order order = new Order()
                        {
                            DateOrder = DateTime.Now,
                            PaymentMethodId = 1,
                            StatusOrderId = 1,
                            StaffId = staff.StaffId,
                            PhoneNumber = customer.PhoneNumber,
                            Amount = amount,
                        };
                        db.Orders.Add(order);
                        db.SaveChanges();

                        foreach (var product in listOrder)
                        {
                            OrderDetail orderDetail = new OrderDetail()
                            {
                                ProductId = product.ProductId,
                                OrderId = order.OrderId,
                                Quantity = (int)product.CategoryId,
                                TotalPrice = (double)(product.CategoryId * product.Price)
                            };
                            db.OrderDetails.Add(orderDetail);
                            db.SaveChanges();
                        }
                        transaction.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception(ex.Message);

                    }                 
                }                  
            }
        }

        public List<Order> ListALL()
        {
            using(var db = new CoffeeShopManagementContext())
            {
                return db.Orders.Include(i => i.OrderDetails)
                                    .Include(i => i.Staff)
                                    .Include(i => i.PaymentMethod)
                                    .Include(i => i.StatusOrder)
                                    .OrderByDescending(i => i.DateOrder)
                    .ToList();
            }
        }

        public List<Order> ListALLByOrderID(int orderid)
        {
            using (var db = new CoffeeShopManagementContext())
            {
                return db.Orders.Where(o => o.OrderId == orderid).Include(i => i.OrderDetails)
                                    .Include(i => i.Staff)
                                    .Include(i => i.PaymentMethod)
                                    .Include(i => i.StatusOrder)
                                    .OrderByDescending(i => i.DateOrder)
                    .ToList();
            }
        }

        public List<OrderDetail> GetOrderDetailsByOrderID(int orderID)
        {
            using(var db = new CoffeeShopManagementContext())
            {
                return db.OrderDetails.Where(o => o.OrderId == orderID)
                        .Include(i => i.Product)
                    .ToList();
            }
        }
    }
}
