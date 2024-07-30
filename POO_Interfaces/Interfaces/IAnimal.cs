using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_Interfaces.Interfaces
{
    // Por convención, I mayus siempre.
    public interface IAnimal
    {
        // por defecto siempre es public
        // es normal que la gente no lo ponga
        void Comer();
        void Dormir();
        void Respirar();
        void Desplazar();

    }
}