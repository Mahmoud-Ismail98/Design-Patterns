namespace DesignPatterns.Builder
{
    public class MotorCycle : IBuilder
    {
        private string brandName;
        private Product product;
        public MotorCycle(string brand)
        {
            product = new Product();
            this.brandName = brand;
        }
        public void StartUpOperations()
        {
            product.Add($"MotorCycle Model name :{this.brandName}");
        }
        public void BuildBody()
        {
            product.Add("Body of MotorCycle was added");
        }
        public void InsertWheels()
        {
            product.Add("two wheels are added");
        }
        public void AddHeadlights()
        {
            product.Add("one Headlights and one backlight are added");
        }
        public void EndOperations()
        {
            /*End Operation*/
        }
        public Product GetVehicle()
        {
            return product;
        }
    }
}