using System;

using R5T.T0142;


namespace R5T.L0085
{
    /// <summary>
    /// Interface for types with a read-only property of generic type <typeparamref name="T"/>, called "X".
    /// </summary>
    /// <typeparam name="T">The type of the has-ed value.</typeparam>
    [UtilityTypeMarker, DataTypeMarker]
    public interface IHasX<T>
    {
        T X { get; }
    }
}
