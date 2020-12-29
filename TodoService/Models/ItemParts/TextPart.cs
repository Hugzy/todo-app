using System;

namespace TodoService.Models.ItemParts
{
    public class TextPart : ItemPart
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = "TextPart";
        public int Priority { get; set; }
    }
}