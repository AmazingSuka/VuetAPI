using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VuetAPI.Models
{
    public class Value
    {
        public readonly int Id;
        public readonly string Name;
        public readonly string Description;
        public readonly bool Exists;
        public readonly decimal Price;
        public readonly string Icon;

        public Value(int id, string name, string description, bool exists, decimal price, string icon)
        {
            Id = id;
            Name = name;
            Description = description;
            Exists = exists;
            Price = price;
            Icon = icon;
        }
    }
}
