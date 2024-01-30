using System;


namespace R5T.L0085
{
    public class WithXOperator : IWithXOperator
    {
        #region Infrastructure

        public static IWithXOperator Instance { get; } = new WithXOperator();


        private WithXOperator()
        {
        }

        #endregion
    }
}
