using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WWWally
{
    public class Building
    {
        public static uint countBuilding = 0;
        private uint id = 228558;
        private float height;
        private byte numberStoreys;
        private ushort numberFlats;
        private byte numberEntrance;

        public uint GetID()
        {
            return id;
        }
        public float GetHeight()
        {
            return height;
        }
        public byte GetNummberStoreys()
        {
            return numberStoreys;
        }
        public ushort GetNumberFlats()
        {
            return numberFlats;
        }
        public byte GetNumberEntrance()
        {
            return numberEntrance;
        }
        public void SetNumberEntrance(byte numberEntrance)
        {
            this.numberEntrance = numberEntrance;
        }
        internal Building(float height, byte numberEntrance, byte numberStoreys, ushort numberFlats) 
        {
            this.height = height;
            this.numberEntrance = numberEntrance;
            this.numberStoreys = numberStoreys;
            this.numberFlats = numberFlats;

            id += countBuilding;
            countBuilding++;
        }
        public void Info()
        {
            Console.WriteLine($"ID: {GetID()}");
            Console.WriteLine($"Высота: { GetHeight()}");
            Console.WriteLine($"Кол-во Подьездов: {GetNumberEntrance()}");
            Console.WriteLine($"Кол-во Этажей: {GetNummberStoreys()}");
            Console.WriteLine($"Кол-во Квартир: {GetNumberFlats()}");
            
        }
    }
}
