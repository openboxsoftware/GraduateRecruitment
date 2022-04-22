using System;
using System.Collections.Generic;

namespace GraduateRecruitment.ConsoleApp.Data.Models
{
    internal class OpenBarRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public DayOfWeek DayOfWeek { get; set; }
        public int NumberOfPeopleInBar { get; set; }
        public IList<FridgeStockTake> FridgeStockTakeList { get; set; } = new List<FridgeStockTake>();
    }
}