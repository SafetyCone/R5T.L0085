using System;


namespace R5T.L0085
{
    public class HasXOperator : IHasXOperator
    {
        #region Infrastructure

        public static IHasXOperator Instance { get; } = new HasXOperator();


        private HasXOperator()
        {
        }

        #endregion
    }
}
