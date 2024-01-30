using System;


namespace R5T.L0085
{
    public class WithXContextOperations : IWithXContextOperations
    {
        #region Infrastructure

        public static IWithXContextOperations Instance { get; } = new WithXContextOperations();


        private WithXContextOperations()
        {
        }

        #endregion
    }
}
