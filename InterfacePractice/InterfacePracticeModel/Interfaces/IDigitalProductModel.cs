using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePracticeModel.Interfaces
{
    public interface IDigitalProductModel : IProductModel
    {
        byte DownloadsLeft { get; }
    }
}
