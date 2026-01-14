using DynamicData.Web.Config.After.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DynamicData.Web.Config.After.Pages
{
    public class ReflectionExampleModel : PageModel
    {
        public List<FieldDetails>? MetaData { get; set; }
        public dynamic? Output { get; set; }
        public string Entity { get; set; } = string.Empty;

        public void OnGet(string entity = "people")
        {
            LoadObject(entity);
        }

        public void OnPost([FromQuery] string entity = "people")
        {
            ViewData["data"] = "";

            foreach (var item in Request.Form)
            {
                if (item.Key.StartsWith("df_"))
                {
                    ViewData["data"] += $"Form Element: {item.Key} = {item.Value}<br>";
                }
            }

            LoadObject(entity);
        }

        private void LoadObject(string entity)
        {
            Entity = entity;

            PopulateData(entity);

            MetaData = new List<FieldDetails>();

            var propertyInfo = Output.GetType().GetProperties();

            foreach (var property in propertyInfo)
            {
                MetaData.Add(new FieldDetails
                {
                    Name = property.Name,
                    Value = property.GetValue(Output).ToString(),
                    DataType = property.PropertyType.Name
                });
            }
        }

        private void PopulateData(string entity)
        {
            if (entity.Equals("people", StringComparison.CurrentCultureIgnoreCase))
            {
                var output = new Person
                {
                    FirstName = "Alex",
                    LastName = "Tushinsky",
                    City = "Las Vegas"
                };

                Output = output;
            }
            else
            {
                var output = new Product
                {
                    ProductId = 1,
                    ListPrice = 100,
                    Name = "Widget 1000",
                    ProductNumber = "W1000",
                    StandardCost = 90
                };

                Output = output;
            }
        }
    }

    public class FieldDetails
    {
        public string Name { get; set; } = string.Empty;
        public string Value { get; set; } = string.Empty;
        public string DataType { get; set; } = string.Empty;
    }
}