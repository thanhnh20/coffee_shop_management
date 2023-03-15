using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Utils
{
    public class MyHelper
    {
        
        public static string GetConnectionString()
        {
            
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            return config["ConnectionStrings:CoffeeShopManagement"];
        }

        public static string CheckValid(object entity)
        {
            var valid = new ValidationContext(entity);
            List<ValidationResult> results = new();
            var isValid = Validator.TryValidateObject(entity, valid, results, true);
            if (!isValid)
            {
                var msgError = "";
                foreach (var error in results)
                {
                    msgError += error.ErrorMessage + "\n";
                }
                return msgError;
            }
            return null;
        }
    }
}
