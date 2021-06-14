using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3LayerApp.BLL.DTO;

namespace _3LayerApp.BLL.Interfaces
{
    public interface IOrderService
    {
        void MakeOrder(OrderDTO orderDto);
        SaddleDTO GetSaddle(int? id);
        IEnumerable<SaddleDTO> GetSaddles();
        void Dispose();
    }
}
