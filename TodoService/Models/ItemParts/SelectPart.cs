using System;

namespace TodoService.Models.ItemParts
{
    public class SelectPart : ItemPart
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = "SelectPart";
        public int Priority { get; set; }
    }
}