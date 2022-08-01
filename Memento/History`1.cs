using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Memento
{

    //This is not part of the pattern but is a class who wrap the originator and caretaker classes
    public class History<T>
    {
        private readonly Originator<T> _originator;
        private readonly CareTaker<T> _careTaker;

        public History()
        {
            _originator = new Originator<T>();
            _careTaker = new CareTaker<T>(_originator);
        }

        // Creates a deep copy of an Object (This Help for Generic)
        public T DeepClone(T obj)
        {
            using (var ms = new MemoryStream())
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(ms, obj);
                ms.Position = 0;

                return (T)formatter.Deserialize(ms);
            }
        }

        public void Save(T newState, bool backup = true)
        {
            _originator.State = DeepClone(newState);

            if (backup)
            {
                _careTaker.Backup();
            }
        }

        public T RestoreCheckPoint(int index)
        {
            _originator.Restore(_careTaker[index]);
            return _originator.State;
        }
    }

  
}
