namespace GraduateRecruitment.ConsoleApp.Data.Models
{
    internal class FridgeStockTake
    {
        public int Id { get; set; }
        public Inventory Inventory { get; set; }
        public Quantity Quantity { get; set; }
    }
}