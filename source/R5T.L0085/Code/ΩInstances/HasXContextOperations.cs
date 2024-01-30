using System;


namespace R5T.L0085
{
    public class HasXContextOperations : IHasXContextOperations
    {
        #region Infrastructure

        public static IHasXContextOperations Instance { get; } = new HasXContextOperations();


        private HasXContextOperations()
        {
        }

        #endregion
    }
}
