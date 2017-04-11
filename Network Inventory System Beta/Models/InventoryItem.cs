using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Network_Inventory_System_Beta.Models
{
    public class InventoryItem
    {
        public int Id { get; set; }
        [DisplayName("ITD ID")]
        public string ItdId { get; set; }
        [DisplayName("Serial Number")]
        public string SerialNumber { get; set; }
        [DisplayName("Location")]
        public string Location { get; set; }
        [DisplayName("Manufacturer")]
        public string Manufacturer { get; set; }
        [DisplayName("Part Number")]
        public string PartNumber { get; set; }
        [DisplayName("Model Number")]
        public string ModelNumber { get; set; }
        [DisplayName("Confirmed")]
        public string Confirmed { get; set; }
        [DisplayName("Comments")]
        public string Comments { get; set; }
        [DisplayName("Asset Number")]
        public string AssetNumber { get; set; }
    }
}