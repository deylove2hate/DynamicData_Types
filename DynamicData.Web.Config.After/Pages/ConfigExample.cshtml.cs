using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DynamicData.Web.Config.After.Pages
{
    public class ConfigExampleModel : PageModel
    {
        public List<FormField> Questions { get; set; } = new List<FormField>();

        public void OnGet()
        {
            Questions.Add(new FormField
            {
                FormId = 1,
                FieldName = "LastName",
                FieldValue = "Tushinsky",
                FieldLabel = "Last Name",
                Row = 1,
                Column = 1,
                Span = 4,
                IsRequired = true,
                FieldType = FieldTypes.Text
            });
            Questions.Add(new FormField
            {
                FormId = 1,
                FieldName = "FirstName",
                FieldValue = "Alex",
                FieldLabel = "First Name",
                Row = 1,
                Column = 5,
                Span = 4,
                IsRequired = true,
                FieldType = FieldTypes.Text
            });
            Questions.Add(new FormField
            {
                FormId = 1,
                FieldName = "City",
                FieldValue = "Las Vegas",
                FieldLabel = "City",
                Row = 2,
                Column = 1,
                Span = 4,
                IsRequired = false,
                FieldType = FieldTypes.Text
            });
            Questions.Add(new FormField
            {
                FormId = 1,
                FieldName = "State",
                FieldValue = "NV;NY,CT,NJ,NV,UT,CA",
                FieldLabel = "US State",
                Row = 2,
                Column = 5,
                Span = 4,
                IsRequired = false,
                FieldType = FieldTypes.DropDown
            });
        }
    }


    public class FormField
    {
        public int FormId { get; set; }
        public string FieldName { get; set; }
        public string FieldValue { get; set; }
        public string FieldLabel { get; set; }
        public short Row { get; set; }
        public short Column { get; set; }
        public short Span { get; set; } = 4;
        public bool IsRequired { get; set; }
        public FieldTypes FieldType { get; set; }
    }

    public enum FieldTypes
    {
        Text,
        Email,
        Number,
        DropDown
    }
}