using System;
using System.Collections.Generic;

namespace Generics
{
    public class GnericRepository : IRepository<Entity>
    {
        List<Entity> entities = new List<Entity>();
        public void Add(Entity item)
        {
            entities.Add(item);
        }

        public IEnumerable<Entity> GetAll()
        {
            return entities;
        }

        public Entity GetById(int id)
        {
            for(int i = 0; i < entities.Count; i++)
            {
                if(entities[i].Id == id)
                {
                    return entities[i];
                }
            }
            return null;
        }

        public void Remove(Entity item)
        {
            entities.Remove(item);
        }

        public void Save()
        {
            Console.WriteLine("Saved");
        }
    }
}
