using System;

using R5T.T0132;


namespace R5T.L0085
{
    [FunctionalityMarker]
    public partial interface IHasXOperator : IFunctionalityMarker,
        // Allow access to IHasX/IWithX functionality from both operator varieties, but put functionality on IWithX by default.
        IWithXOperator
    {

    }
}
