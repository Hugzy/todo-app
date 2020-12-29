using System;
using System.Collections.Generic;
using TodoService.Models.ListParts;

namespace TodoService.Models
{
    public class TodoList
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<Item> Items { get; set; }
        public List<ListPart> Bounds { get; set; }
    }
}