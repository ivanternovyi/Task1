﻿//Базовий абстрактний клас – Фігура, похідні від нього Коло та Прямокутник. Паралелепіпед
//унаслідується від Прямокутника, Циліндр – від Коло. Визначити:
// Конструктори +
// Колір та ширину контура +
// Колір заливки +
// Площу, периметр +
// Специфічні властивості чи методи для похідних класів (об’єм для циліндра
//наприклад).
//Створити колекцію різних фігур. Порахувати сумарний периметр та площу всіх фігур.

using System;

namespace InheritanceTask
{
    public class Circle:Shape
    {
        protected double radius;

        public Circle(Colour contour, Colour filling, double width = 0, double radius = 0) : base(contour, filling, width)
        {
            if(radius < 0)
                throw new ArgumentException("Value should be > 0");
            this.radius = radius;
        }

        public override void Output()
        {
            Console.Write("Circle -> ");
            base.Output();
            Console.WriteLine($", Perimeter: { Perimeter() }, Square: { Square() } ");
        }

        public override double Square()
        {
            var result = Math.PI * Math.Pow(radius, 2);
            return result;
        }
        
        public override double Perimeter()
        {
            var result = 2 * Math.PI * radius;
            return result;
        }

    }
}