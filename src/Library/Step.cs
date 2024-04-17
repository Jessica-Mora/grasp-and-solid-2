//-------------------------------------------------------------------------------
// <copyright file="Step.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------------

namespace Full_GRASP_And_SOLID.Library
{
    public class Step
    {
        public Step(Product input, double quantity, Equipment equipment, int time)
        {
            this.Quantity = quantity;
            this.Input = input;
            this.Time = time;
            this.Equipment = equipment;

            
        MaterialCost = Quantity * input.UnitCost; // Calcula el costo del material basado en la cantidad y el costo de la unidad 

        
        EquipmentCost = Time * equipment.HourlyCost;  // Calcula el costo de equipo basado en el costo por hora
        }

        public Product Input { get; set; }

        public double Quantity { get; set; }

        public int Time { get; set; }

        public Equipment Equipment { get; set; }
        public double EquipmentCost { get; set;}

        public double MaterialCost { get; set;}
        
       
    }
}