﻿namespace ShapeFactory.Domain;

public class Shape
{
    public Shape(int id = default, int angles = default, string color = default)
    {
        Id = id;
        Angles = angles;
        Color = color;
    }

    public int Id { get; set; }
    public int Angles { get; set; }
    public string Color { get; set; }

    public override string ToString() => $"Shape: ID = {Id}, Angles = {Angles}, Color = {Color}";
}