using System.Diagnostics.Contracts;

namespace QuickGraph.Contracts
{
    [ContractClassFor(typeof(IEdge<>))]
    abstract class IEdgeContract<TVertex>
        : IEdge<TVertex>
    {
        [ContractInvariantMethod]
        void IEdgeInvariant()
        {
            IEdge<TVertex> ithis = this;
            Contract.Invariant(ithis.Source is not null);
            Contract.Invariant(ithis.Target is not null);
        }

        TVertex IEdge<TVertex>.Source
        {
            get
            {
                Contract.Ensures(Contract.Result<TVertex>() is not null);
                return default(TVertex);
            }
        }

        TVertex IEdge<TVertex>.Target
        {
            get
            {
                Contract.Ensures(Contract.Result<TVertex>() is not null);
                return default(TVertex);
            }
        }
    }
}
