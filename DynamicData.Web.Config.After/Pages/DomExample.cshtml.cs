using System.Text;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DynamicData.Web.Config.After.Pages
{
    public class DomExampleModel : PageModel
    {
        public void OnGet()
        {
            CreateForm();
        }

        public void OnPost()
        {
            //ViewData["data"] = "";

            //foreach (var item in Request.Form)
            //{
            //    if (item.Key.StartsWith("df_"))
            //    {
            //        ViewData["data"] += $"Form Element: {item.Key} = {item.Value}<br>";
            //    }
            //}

            CreateForm();
        }

        private void CreateForm()
        {
            var template = new StringBuilder();
            template.AppendLine("<div id=\"dynamicContent\">");

            if (Request.HasFormContentType)
            {
                foreach (var item in Request.Form)
                {
                    if (item.Key.StartsWith("df_"))
                    {
                        ViewData["data"] += $"Form Element: {item.Key} = {item.Value}<br>";

                        template.AppendLine("<div class=\"row\">");
                        template.AppendLine("<div class=\"col-md-2\">");
                        template.AppendLine($"<label for=\"{item.Key}\" \">{item.Key.Replace("df_", "")}</label>");
                        template.AppendLine("</div>");
                        template.AppendLine("<div class=\"col-md-10\">");
                        template.AppendLine(
                            $"<input type=\"text\" class=\"form-control\" name=\"{item.Key}\" value=\"{item.Value}\">");
                        template.AppendLine("</div>");
                        template.AppendLine("</div><br>");
                    }
                }
            }

            template.AppendLine("</div>");
            ViewData["form"] = template.ToString();
        }
    }
}