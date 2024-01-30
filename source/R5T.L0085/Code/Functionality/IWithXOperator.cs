using System;
using System.Threading.Tasks;

using R5T.T0132;


namespace R5T.L0085
{
    [FunctionalityMarker]
    public partial interface IWithXOperator : IFunctionalityMarker
    {
        /// <summary>
        /// Chooses <see cref="Set_From_Asynchronous{THasX, TWithX, TX}(THasX, TWithX)"/> as the default.
        /// </summary>
        public Task Set_From<THasX, TWithX, TX>(
            THasX hasX,
            TWithX withX)
            where THasX : IHasX<TX>
            where TWithX : IWithX<TX>
            => this.Set_From_Asynchronous<THasX, TWithX, TX>(
                hasX,
                withX);

        public void Set_From_Synchronous<THasX, TWithX, TX>(
            THasX hasX,
            TWithX withX)
            where THasX : IHasX<TX>
            where TWithX : IWithX<TX>
        {
            withX.X = hasX.X;
        }

        public Task Set_From_Asynchronous<THasX, TWithX, TX>(
            THasX hasX,
            TWithX withX)
            where THasX : IHasX<TX>
            where TWithX : IWithX<TX>
        {
            withX.X = hasX.X;

            return Task.CompletedTask;
        }

        /// <summary>
        /// Chooses <see cref="Set_To_Asynchronous{THasX, TWithX, TX}(TWithX, THasX)"/> as the default.
        /// </summary>
        public Task Set_To<THasX, TWithX, TX>(
            TWithX withX,
            THasX hasX)
            where THasX : IHasX<TX>
            where TWithX : IWithX<TX>
            => this.Set_To_Asynchronous<THasX, TWithX, TX>(
                withX,
                hasX);

        public void Set_To_Synchronous<THasX, TWithX, TX>(
            TWithX withX,
            THasX hasX)
            where THasX : IHasX<TX>
            where TWithX : IWithX<TX>
        {
            withX.X = hasX.X;
        }

        public Task Set_To_Asynchronous<THasX, TWithX, TX>(
            TWithX withX,
            THasX hasX)
            where THasX : IHasX<TX>
            where TWithX : IWithX<TX>
        {
            withX.X = hasX.X;

            return Task.CompletedTask;
        }
    }
}
