using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO2.Models
{
    public class Empleado
    {
        private Guid Id { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Correo { get; set; }
        private double SueldoBase { get; set; }
        public double PorcentajePension { get; set; }
        public double PorcentajeSalud { get; set; }
        private double PorcentajeAhorroCooperativa { get; set; }

        public Empleado(string nombre, string apellido, string correo, double sueldo, double ahorroCooperativa)
        {
            this.Id = Guid.NewGuid();
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Correo = correo;
            this.SueldoBase = sueldo;
            this.PorcentajePension = 4;
            this.PorcentajeSalud = 4;
            this.PorcentajeAhorroCooperativa = ahorroCooperativa;
        }

        public double CalcularSueldoEmpleado()
        {
            return this.SueldoBase - CalcularDeducciones() - CalcularAhorro();
        }

        private double CalcularDeducciones()
        {
            return (this.SueldoBase *  this.PorcentajePension / 100)  + ( this.SueldoBase * this.PorcentajeSalud / 100);
        }

        private double CalcularAhorro()
        {
            return this.SueldoBase * this.PorcentajeAhorroCooperativa /100 ;
        }

        public void MostrarEmpleado()
        {
            Console.WriteLine($"El empleado: {this.Nombre} {this.Apellido}, tiene como sueldo base {this.SueldoBase:C} y su ahorro es de {this.CalcularAhorro():C} mensuales");
        }
    }

}
