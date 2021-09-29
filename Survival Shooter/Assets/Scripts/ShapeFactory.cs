using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ShapeFactory
{
    
    //use getShape method to get object of type shape 
    public Shape getShape(string shapeType)
    {
        if (shapeType == null)
        {
            return null;
        }
        if (shapeType.Equals("CIRCLE", StringComparison.InvariantCultureIgnoreCase))
        {
            return new Circle();

        }
        else if (shapeType.Equals("RECTANGLE", StringComparison.InvariantCultureIgnoreCase))
        {
            return new Rectangle();

        }
        else if (shapeType.Equals("SQUARE", StringComparison.InvariantCultureIgnoreCase))
        {
            return new Square();
        }

        return null;
    }
}
