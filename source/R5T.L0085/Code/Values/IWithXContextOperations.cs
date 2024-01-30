using System;
using System.Threading.Tasks;

using R5T.T0131;
using R5T.T0241;


namespace R5T.L0085
{
    [ContextOperationsMarker, ValuesMarker]
    public partial interface IWithXContextOperations : IValuesMarker
    {
        /// <summary>
        /// Chooses <see cref="Set_To_Asynchronous{TWithX, THasX, TX}(TWithX)"/> as the default.
        /// </summary>
        public Func<THasX, Task> Set_To<TWithX, THasX, TX>(TWithX withX)
            where THasX : IHasX<TX>
            where TWithX : IWithX<TX>
            => this.Set_To_Asynchronous<TWithX, THasX, TX>(withX);

        public Action<THasX> Set_To_Synchronous<TWithX, THasX, TX>(TWithX withX)
            where THasX : IHasX<TX>
            where TWithX : IWithX<TX>
        {
            return hasX =>
            {
                withX.X = hasX.X;
            };
        }

        public Func<THasX, Task> Set_To_Asynchronous<TWithX, THasX, TX>(TWithX withX)
            where THasX : IHasX<TX>
            where TWithX : IWithX<TX>
        {
            return hasX =>
            {
                withX.X = hasX.X;

                return Task.CompletedTask;
            };
        }

        /// <summary>
        /// Chooses <see cref="Set_From_Asynchronous{THasX, TWithX, TX}(THasX)"/> as the default.
        /// </summary>
        public Func<TWithX, Task> Set_From<THasX, TWithX, TX>(THasX hasX)
            where THasX : IHasX<TX>
            where TWithX : IWithX<TX>
            => this.Set_From_Asynchronous<THasX, TWithX, TX>(hasX);

        public Func<TWithX, Task> Set_From_Asynchronous<THasX, TWithX, TX>(THasX hasX)
            where THasX : IHasX<TX>
            where TWithX : IWithX<TX>
        {
            return withX =>
            {
                withX.X = hasX.X;

                return Task.CompletedTask;
            };
        }

        public Action<TWithX> Set_From_Synchronous<THasX, TWithX, TX>(THasX hasX)
            where THasX : IHasX<TX>
            where TWithX : IWithX<TX>
        {
            return withX =>
            {
                withX.X = hasX.X;
            };
        }
    }
}
