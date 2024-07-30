using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using POO_Interface_Crud.Models;

namespace POO_Interface_Crud.Interfaces
{
    public interface ICRUD
    {
        void Create(List<Coder> coders, Coder coder);
        void Read(List<Coder> coders);
        void Update(List<Coder> coders, Guid id, Coder coder);
        void Delete(List<Coder> coders, Guid id);
    }
}