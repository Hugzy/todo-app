
using System;

namespace TodoService.Models.ListParts
{
    public class BoundListPart : ListPart
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = "BoundListPart";
        public int Priority { get; set; } = 1;
    }
}