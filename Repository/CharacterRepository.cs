using System;
using System.Collections.Generic;

namespace Repository
{
    public class CharacterRepository : IRepository<Character>
    {
        private readonly CharacterDatabaseContext _context;

        public CharacterRepository()
        {
            _context = new CharacterDatabaseContext();
        }

        public void Delete(int id)
        {
            int index = _context.Characters.FindIndex((c) => c.CharacterId == id);
            _context.Characters.RemoveAt(index);
        }

        public IEnumerable<Character> GetAll()
        {
            return _context.Characters;
        }

        public Character GetById(int id)
        {
            return _context.Characters.Find((c) => c.CharacterId == id);
        }

        public void Insert(Character value)
        {
            _context.TableSet.Add(value);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Character value)
        {
            int index = _context.Characters.FindIndex((c) => c.CharacterId == value.CharacterId);
            _context.TableSet[index] = value;
        }
    }
}
