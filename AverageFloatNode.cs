using UnityEngine;
using Warudo.Core.Attributes;
using Warudo.Core.Graphs;

[NodeType(
    Id = "1dddd3c4-a31d-4143-9ed4-01e3071e8d12", // Must be unique. Generate one at https://guidgenerator.com/
    Title = "Average Float",
    Category ="CATEGORY_ARITHMETIC")]
public class AverageFloatNode : Node
{
    //Stores an A value
    [DataInput]
    [Label("A")]
    public float floatA;
        
    //Stores a B value
    [DataInput]
    [Label("B")]
    public float floatB;
        
    //   
    //Returns the average value
    [DataOutput]
    [Label("Average")]
    public float AverageFloat()
    {
        return (floatA + floatB) / 2;
    }
}