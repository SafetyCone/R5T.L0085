using System;

using R5T.T0142;


namespace R5T.L0085.N001
{
    /// <summary>
    /// Interface for types with a read-write property of generic type <typeparamref name="T"/>, called "X".
    /// </summary>
    /// <remarks>
    /// Does not inherit from <see cref="IHasX{T}"/>.
    /// For the IWithX interface that does inherit from IHasX, <see cref="L0085.IWithX{T}"/>.
    /// </remarks>
    /// <typeparam name="T">The type of the has-ed value.</typeparam>
    [UtilityTypeMarker, DataTypeMarker]
    public interface IWithX<T>
    {
        T X { get; set; }
    }
}
