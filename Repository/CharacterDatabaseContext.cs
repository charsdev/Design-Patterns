using System;
using System.Collections.Generic;

namespace Repository
{

    public class CharacterDatabaseContext 
    {
        public List<Character> Characters { get; private set; }
        public List<Character> TableSet { get; set; }

        public CharacterDatabaseContext()
        {
            Characters = new List<Character>();
            TableSet = new List<Character>();
        }

        public void SaveChanges()
        {
            Characters = TableSet;
        }

    }
}
