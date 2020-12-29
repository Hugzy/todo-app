using System;
using System.Collections;
using System.Collections.Generic;
using TodoService.Models.ItemParts;

namespace TodoService.Models
{
    public class Item
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<ItemPart> Parts { get; set; }
    }
}