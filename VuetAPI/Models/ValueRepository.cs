using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VuetAPI.Models
{
    public class ValueRepository : IRepository<Value>
    {
        public static List<Value> values = new List<Value>()
        {
            new Value(1, "First Item", "This is the description of the first item", true, 1.1M, "https://localhost:44359/Icons/1.png"),
            new Value(2, "Second Item", "This is the description of the second item", false, 2.2M, "https://localhost:44359/Icons/2.png"),
            new Value(3, "Third Item", "This is the description of the third item", true, 3.3M, "https://localhost:44359/Icons/3.png"),
            new Value(4, "Fourth Item", "This is the description of the fourth item", false, 4.4M, "https://localhost:44359/Icons/4.png"),
            new Value(5, "Fifth Item", "This is the description of the fifth item", true, 5.5M, "https://localhost:44359/Icons/5.png")
        };
       
        public IEnumerable<Value> All()
        {
            return values;
        }

        public IEnumerable<Value> AllWhere(Func<Value, bool> predicate)
        {
            return values.Where(predicate);
        }

        public void Delete(int id)
        {
            values.Remove(Item(id));
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
