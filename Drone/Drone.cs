
using System.Buffers;
using System.IO.Pipelines;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices.Marshalling;

namespace Drone;

public class Drone
{
    public double Start(double x, double y, double z) => 
        Math.Sqrt((x*x) + (y*y) + (z*z));
    

    public double[] NewPosition(double[] arrayA, double[] arrayB)
    {        
        for (int i = 0; i < arrayB.Length; i++)
        {
            if (arrayA[i] > arrayB[i])
            {
                arrayB[i] = -Math.Abs(arrayB[i]);
            }
        }
        return arrayA.Zip(arrayB, (a,b) => a + b).ToArray();
    }

    public double ShortestPath(double x, double y, double z) => 
        Math.Sqrt(x*x + y*y + z*z);
        
}