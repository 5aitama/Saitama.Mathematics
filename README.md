# Saitama.Mathematics

A C# math extension library provide set of helpfull function.

The main goal is to deliver functions that I use a lot and that are very useful in my procedural generation projects.

## Usage

You can use this library in your Unity game by using the `Package Manager` and select `Add package from git url` and copy git url of this repo into it.

```C#
using Unity.Mathematics;
using Saitama.Mathematics;

namespace MyNamespace
{
    ...

    // Convert 2D index to 1D index
    var index2to1 = new int2(2).To1D(4);

    // Convert 3D index to 1D index
    var index3to1 = new int3(4, 4).To1D(4);

    // Convert 1D index to 2D index
    var index1to2 = 45.To2D(10, 10);

    // Convert 1D index to 3D index
    var index1to3 = 45.To3D(10, 10, 10);

    ...
}
```