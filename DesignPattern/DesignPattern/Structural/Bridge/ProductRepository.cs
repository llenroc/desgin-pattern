using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Structural.Bridge
{
    public class ProductRepository : Repository
    {
        public ProductRepository(DataObject dataObject) : base(dataObject)
        {
        }

        public override void AddObject()
        {
            // Do repository specific work
            dataObject.Register();
        }

        public override void CopyObject()
        {
            // Do repository specific work
            dataObject.Copy();
        }

        public override void RemoveObject()
        {
            // Do repository specific work
            dataObject.Delete();
        }
    }
}
