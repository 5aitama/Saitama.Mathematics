using Unity.Mathematics;

/// <summary>
/// Contains some usefull mathematics methods.
/// </summary>
namespace Saitama.Mathematics 
{
    /// <summary>
    /// All class/structs extensions.
    /// </summary>
    public static class Extension 
    {
        /// <summary>
        /// Convert 2D index array to 1D index array.
        /// </summary>
        /// <param name="p">2D index array</param>
        /// <param name="width">Width of the 2D index array</param>
        /// <returns>1D index array</returns>
        public static int To1D(this int2 p, int width) => p.y * width + p.x;

        /// <summary>
        /// Convert 3D index array to 1D index array.
        /// </summary>
        /// <param name="p">3D index array</param>
        /// <param name="size">Size of the 3D index array</param>
        /// <returns>1D index array</returns>
        public static int To1D(this int3 p, int3 size) => p.x + p.y * size.x + p.z * size.x * size.y;

        /// <summary>
        /// Convert 1D index array to 2D index array.
        /// </summary>
        /// <param name="p">1D index array</param>
        /// <param name="size">Size of the 2D index array</param>
        /// <returns>2D index array</returns>
        public static int2 To2D(this int p, int2 size) => new int2(p % size.x, p / size.x);

        /// <summary>
        /// Convert 1D index array to 3D index array.
        /// </summary>
        /// <param name="p">1D index array</param>
        /// <param name="size">Size of 3D index array</param>
        /// <returns>3D index array</returns>
        public static int3 To3D(this int p, int3 size) => new int3(p % size.x, (p / size.x) % size.y, p / (size.x * size.y));
    }
}