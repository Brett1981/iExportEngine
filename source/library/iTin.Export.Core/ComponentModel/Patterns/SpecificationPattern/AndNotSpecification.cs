﻿
namespace iTin.Export.ComponentModel.Patterns
{
    using System.Diagnostics;

    public class AndNotSpecification<T> : CompositeSpecification<T>
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly ISpecification<T> _left;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly ISpecification<T> _right;

        public AndNotSpecification(ISpecification<T> left, ISpecification<T> right)
        {
            _left = left;
            _right = right;
        }

        public override bool IsSatisfiedBy(T candidate) => _left.IsSatisfiedBy(candidate) && _right.IsSatisfiedBy(candidate) != true;
    }
}
