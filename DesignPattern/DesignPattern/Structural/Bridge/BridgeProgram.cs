using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Structural.Bridge
{
    class BridgeProgram
    {
        public static void Work()
        {
            var clientDataObject = new ClientDataObject();
            var clientRepository = new ClientRepository(clientDataObject);

            clientRepository.AddObject();
            clientRepository.SaveChanges();

            clientRepository.CopyObject();

            clientRepository.RemoveObject();
            clientRepository.SaveChanges();


            var productDataObject = new ProductDataObject();
            var productRepository = new ProductRepository(productDataObject);
            productRepository.AddObject();
            productRepository.SaveChanges();

            productRepository.CopyObject();

            productRepository.RemoveObject();
            productRepository.SaveChanges();
        }
    }
}
