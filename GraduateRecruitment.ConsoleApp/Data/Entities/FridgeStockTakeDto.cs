using GraduateRecruitment.ConsoleApp.Data.Models;

namespace GraduateRecruitment.ConsoleApp.Data.Entities
{
    internal class FridgeStockTakeDto
    {
        public int Id { get; set; }
        public int OpenBarRecordId { get; set; }
        public int InventoryId { get; set; }
        public Quantity Quantity { get; set; }
    }
}