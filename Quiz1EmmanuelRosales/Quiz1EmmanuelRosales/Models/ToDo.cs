using System;
using System.Collections.Generic;

namespace Quiz1EmmanuelRosales.Models
{
    public partial class ToDo
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public DateTime? Due { get; set; }
        //public string Filter { get; set; } = "";

        //public class ItemsGroupView{
        //    public string ItemName { get; set; } = "";
        //    public List<ToDo> Items { get; set; } = new List<ToDo>();
        //}
    }
}
