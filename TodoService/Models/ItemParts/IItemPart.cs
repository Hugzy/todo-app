using System;

namespace TodoService.Models.ItemParts
{
    public abstract class ItemPart
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Priority { get; set; }
    }
}