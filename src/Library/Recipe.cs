//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    public class Recipe
    {
        public ArrayList steps = new ArrayList();

        public Product FinalProduct { get; set; }

        public void AddStep(Step step)
        {
            this.steps.Add(step);
        }

        public void RemoveStep(Step step)
        {
            this.steps.Remove(step);
        }

        public double GetProductionCost(Recipe recipe)
        {
            double materialCost = 0;
            double equipmentCost = 0;

            foreach (Step step in recipe.steps)
            {
                materialCost += step.MaterialCost;
                equipmentCost += step.EquipmentCost;
            }
            return materialCost + equipmentCost;
        }   
        
           
    
  
    }

   
       
}

/*la clase recipe no cumple con los principios de srp ya que tenia dos responsabilidades la de conocer la receta 
        y la de imprimirla
        public void PrintRecipe()
        {
            Console.WriteLine($"Receta de {this.FinalProduct.Description}:");
            foreach (Step step in this.steps)
            {
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
            }
        } */