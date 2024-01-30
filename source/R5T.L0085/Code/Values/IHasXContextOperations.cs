using System;

using R5T.T0131;
using R5T.T0241;


namespace R5T.L0085
{
    [ContextOperationsMarker, ValuesMarker]
    public partial interface IHasXContextOperations : IValuesMarker,
        // Allow access to IHasX/IWithX functionality from both operator varieties, but put functionality on IWithX by default.
        IWithXContextOperations
    {

    }
}
