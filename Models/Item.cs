using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyHomies.Models
{
    public class Item //we might want to make this abstract if different items have diff methods
    {
        [Key]
        public int ItemID { get; set; } //the ID of this class
        public String name { get; set; }

        public int checkOutTime { get; set; } //0 if not checked out
        //maybe I can make this an optional field. Like it only pops up if it is checked out

        public Boolean checkedOut { get; set; }
        public DateTime reservedTime { get; set; } //how do I make any of these optional

        public int maxTimeOut { get; set; } //max length of time until overdue

        public String condition { get; set; } //condition of item before check out

        public int lateFee { get; set; }

    }
}
