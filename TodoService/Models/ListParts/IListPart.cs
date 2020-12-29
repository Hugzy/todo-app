using System;

namespace TodoService.Models.ListParts
{
    public abstract class ListPart
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Priority { get; set; }
    }
}