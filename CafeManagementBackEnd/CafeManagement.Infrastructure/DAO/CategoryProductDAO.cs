using CafeManagement.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagement.Infrastructure.DAO
{
    public class CategoryProductDAO
    {
        CoffeeShopManagementContext _context = new();
        private static CategoryProductDAO instance = null;
        private static readonly object instanceLock = new object();
        private CategoryProductDAO() { }
        public static CategoryProductDAO getInstance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new CategoryProductDAO();
                    }
                    return instance;
                }
            }
        }
        public IEnumerable<CategoryProduct> GetAllCategory() => _context.CategoryProducts.AsEnumerable();
        public CategoryProduct GetCategoryProductById(int id) => _context.CategoryProducts.SingleOrDefault(cat => cat.CategoryId == id);
        public IEnumerable<CategoryProduct> GetCategoryProductByName(string name) => _context.CategoryProducts.Where(cat => cat.Name.Contains(name)).AsEnumerable();
        public CategoryProduct CreateCategoryProduct(CategoryProduct CategoryProduct)
        {
            try
            {
                _context.CategoryProducts.Add(CategoryProduct);
                _context.SaveChanges();
                CategoryProduct = GetCategoryProductById(CategoryProduct.CategoryId);
                return CategoryProduct;
            }
            catch
            {
                throw;
            }
        }
        public bool DeleteCategoryProduct(CategoryProduct CategoryProduct)
        {
            try
            {
                var rol = GetCategoryProductById(CategoryProduct.CategoryId);
                if (rol != null)
                {
                    _context.CategoryProducts.Remove(CategoryProduct);
                    _context.SaveChanges();
                    return true;
                }
                return false;
            }
            catch
            {
                throw;
            }
        }
        public CategoryProduct UpdateCategoryProduct(CategoryProduct CategoryProduct)
        {
            try
            {
                var rol = GetCategoryProductById(CategoryProduct.CategoryId);
                if (rol != null)
                {
                    var tracker = _context.Attach(rol);
                    tracker.State = EntityState.Modified;
                    _context.SaveChanges();
                    CategoryProduct = GetCategoryProductById(CategoryProduct.CategoryId);
                    return CategoryProduct;
                }
                return null;
            }
            catch { throw; }
        }
    }
}
