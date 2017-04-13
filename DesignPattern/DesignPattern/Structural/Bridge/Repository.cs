using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Structural.Bridge
{
    public abstract class Repository
    {
        protected DataObject dataObject;

        public Repository(DataObject dataObject)
        {
            this.dataObject = dataObject;
        }

        public abstract void AddObject();
        public abstract void CopyObject();
        public abstract void RemoveObject();

        public void SaveChanges()
        {
            Console.WriteLine("Changes were saved");
        }
    }
}
