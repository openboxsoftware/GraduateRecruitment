using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using GraduateRecruitment.ConsoleApp.Data.Entities;
using GraduateRecruitment.ConsoleApp.Data.Models;
using LumenWorks.Framework.IO.Csv;

namespace GraduateRecruitment.ConsoleApp.Data
{
    internal class OpenBarRepository
    {
        private readonly IList<OpenBarRecordDto> _openBarRecordsDto;
        private readonly IList<FridgeStockTakeDto> _fridgeStockDto;
        private readonly IList<InventoryDto> _inventoryDto;

        public IList<OpenBarRecord> AllOpenBarRecords { get; private set; } = new List<OpenBarRecord>();
        public IList<FridgeStockTake> AllFridgeStocks { get; private set; } = new List<FridgeStockTake>();
        public IList<Inventory> AllInventory { get; private set; } = new List<Inventory>();

        public OpenBarRepository()
        {
            _openBarRecordsDto = GetOpenBarRecordData();
            _fridgeStockDto = GetFridgeStockData();
            _inventoryDto = GetInventoryData();
            AllOpenBarRecords = GetOpenBarRecords();
            AllFridgeStocks = GetFridgeStockTakes();
            AllInventory = GetInventoryList();
        }

        private IList<OpenBarRecord> GetOpenBarRecords()
        {
            var openBarRecords = new List<OpenBarRecord>();
            foreach (var openBarRecord in _openBarRecordsDto)
            {
                openBarRecords.Add(new OpenBarRecord
                {
                    Id = openBarRecord.Id,
                    Date = openBarRecord.Date,
                    DayOfWeek = openBarRecord.Date.DayOfWeek,
                    NumberOfPeopleInBar = openBarRecord.NumberOfPeopleInBar,
                    FridgeStockTakeList = GetFridgeStockTakes(openBarRecord.Id)
                });
            }

            return openBarRecords;
        }

        private Inventory GetInventory(int id)
        {
            var inventoryDto = _inventoryDto.FirstOrDefault(i => i.Id == id);
            return new Inventory
            {
                Id = inventoryDto.Id,
                Name = inventoryDto.Name,
                Price = inventoryDto.Price,
            };
        }

        private IList<FridgeStockTake> GetFridgeStockTakes(int openBarRecordId)
        {
            var fridgeStockTakes = new List<FridgeStockTake>();
            foreach (var frideStockTake in _fridgeStockDto.Where(f => f.OpenBarRecordId == openBarRecordId))
            {
                fridgeStockTakes.Add(new FridgeStockTake
                {
                    Id = frideStockTake.Id,
                    Quantity = frideStockTake.Quantity,
                    Inventory = GetInventory(frideStockTake.InventoryId),
                });
            }

            return fridgeStockTakes;
        }

        private IList<FridgeStockTake> GetFridgeStockTakes()
        {
            var fridgeStockTakes = new List<FridgeStockTake>();
            foreach (var frideStockTake in _fridgeStockDto)
            {
                fridgeStockTakes.Add(new FridgeStockTake
                {
                    Id = frideStockTake.Id,
                    Quantity = frideStockTake.Quantity,
                    Inventory = GetInventory(frideStockTake.InventoryId),
                });
            }

            return fridgeStockTakes;
        }

        private IList<Inventory> GetInventoryList()
        {
            var inventoryList = new List<Inventory>();
            foreach (var inventoryDto in _inventoryDto)
            {
                inventoryList.Add(new Inventory
                {
                    Id = inventoryDto.Id,
                    Name = inventoryDto.Name,
                    Price = inventoryDto.Price,
                });
            }

            return inventoryList;
        }

        private IList<OpenBarRecordDto> GetOpenBarRecordData()
        {
            var csvTable = new DataTable();
            using (var csvReader = new CsvReader(new StreamReader(File.OpenRead(@"./Data/Files/OpenBarRecord.csv")), true))
            {
                csvTable.Load(csvReader);
            }

            var openBarRecords = new List<OpenBarRecordDto>();

            for (int i = 0; i < csvTable.Rows.Count; i++)
            {
                var date = DateTime.Parse(csvTable.Rows[i][1].ToString());
                openBarRecords.Add(new OpenBarRecordDto
                {
                    Id = int.Parse(csvTable.Rows[i][0].ToString()),
                    Date = date,
                    NumberOfPeopleInBar = int.Parse(csvTable.Rows[i][2].ToString()),
                });
            }

            return openBarRecords;
        }

        private IList<FridgeStockTakeDto> GetFridgeStockData()
        {
            var csvTable = new DataTable();
            using (var csvReader = new CsvReader(new StreamReader(File.OpenRead(@"./Data/Files/FridgeStockTake.csv")), true))
            {
                csvTable.Load(csvReader);
            }

            var fridgeStockList = new List<FridgeStockTakeDto>();

            for (int i = 0; i < csvTable.Rows.Count; i++)
            {
                fridgeStockList.Add(new FridgeStockTakeDto
                {
                    Id = int.Parse(csvTable.Rows[i][0].ToString()),
                    OpenBarRecordId = int.Parse(csvTable.Rows[i][1].ToString()),
                    InventoryId = int.Parse(csvTable.Rows[i][2].ToString()),
                    Quantity = new Quantity
                    {
                        Taken = int.Parse(csvTable.Rows[i][3].ToString()),
                        Added = int.Parse(csvTable.Rows[i][4].ToString()),
                    }
                });
            }

            return fridgeStockList;
        }

        private IList<InventoryDto> GetInventoryData()
        {
            var csvTable = new DataTable();
            using (var csvReader = new CsvReader(new StreamReader(File.OpenRead(@"./Data/Files/Inventory.csv")), true))
            {
                csvTable.Load(csvReader);
            }

            var inventoryList = new List<InventoryDto>();

            for (int i = 0; i < csvTable.Rows.Count; i++)
            {
                var style = NumberStyles.Number | NumberStyles.AllowCurrencySymbol;
                var provider = new CultureInfo("en-GB");

                inventoryList.Add(new InventoryDto
                {
                    Id = int.Parse(csvTable.Rows[i][0].ToString()),
                    Name = csvTable.Rows[i][1].ToString(),
                    Price = decimal.Parse(csvTable.Rows[i][2].ToString(), style, provider),
                });
            }

            return inventoryList;
        }
    }
}