namespace personal_financial_management_app_class_libbey
{
    public class Catagory
    {
        private string? name;
        private string? icon;

        public string? Name { get; set; }
        public string? Icon { get; set; }

        public Catagory(string? name, string? icon)
        {
            this.name = name;
            this.icon = icon;
        }

        public Catagory()
        {
        }
    }
}