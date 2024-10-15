using System;

public class Laptop : ICloneable
{
    public string Processor { get; set; }
    public string RAM { get; set; }
    public string GraphicsCard { get; set; }
    public string Storage { get; set; }

    public object Clone()
    {
        return this.MemberwiseClone();
    }

    public override string ToString()
    {
        return $"Processor: {Processor}, RAM: {RAM}, Graphics Card: {GraphicsCard}, Storage: {Storage}";
    }
}
