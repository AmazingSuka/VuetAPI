using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VuetAPI.Models
{
    public class ValueRepository : IRepository<Value>
    {
        private List<Value> values = new List<Value>();

        public ValueRepository()
        {
            values.Add(new Value { Id = 1, Name = "First Item", Description = "This is the description of the first item", Exists = true, Price = 1.1M });
            values.Add(new Value { Id = 2, Name = "Second Item", Description = "This is the description of the second item", Exists = false, Price = 2.2M });
            values.Add(new Value { Id = 3, Name = "Third Item", Description = "This is the description of the third item", Exists = true, Price = 3.3M });
            values.Add(new Value { Id = 4, Name = "Fourth Item", Description = "This is the description of the fourth item", Exists = false, Price = 4.4M });
            values.Add(new Value { Id = 5, Name = "Fifth Item", Description = "This is the description of the fifth item", Exists = true, Price = 5.5M });
        }

        public IEnumerable<Value> All()
        {
            return values;
        }

        public IEnumerable<Value> AllWhere(Func<Value, bool> predicate)
        {
            return values.Where(predicate);
        }

        public void Delete(Value entity)
        {
            values.Remove(entity);
        }

        public void Insert(Value entity)
        {
            values.Add(entity);
        }

        public Value Item(int id)
        {
            return values.FirstOrDefault(x => x.Id == id);
        }

        public void Update(Value entity)
        {

        }
    }
}
