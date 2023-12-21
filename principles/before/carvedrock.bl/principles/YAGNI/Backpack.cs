﻿using System.Text.Json;

namespace carvedrock.bl.principles.YAGNI
{
    public class Backpack
    {
        public string Name { get; } = null!;
        public double Price { get; }
        public int Capacity { get; }
        public double Weight { get; }
        public bool IsWaterproof { get; }

        public Backpack(string name, double price, int capacity, double weight, bool isWaterproof)
        {
            Name = name;
            Price = price;
            Capacity = capacity;
            Weight = weight;
            IsWaterproof = isWaterproof;
        }

        public string ToJson()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
