using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;

namespace _011_Expressions
{
    internal sealed class ParameterReplacer : ExpressionVisitor
    {
        internal ParameterReplacer(params ParameterExpression[] parameters)
            : this((IEnumerable<ParameterExpression>)parameters)
        { }

        internal ParameterReplacer(IEnumerable<ParameterExpression> parameters)
        {
            _parametersDic = parameters.ToDictionary(p => p.Type.Name, p => p);
        }

        private readonly Dictionary<string, ParameterExpression> _parametersDic;

        protected override Expression VisitParameter(ParameterExpression node)
        {
            if (_parametersDic.TryGetValue(node.Type.Name, out ParameterExpression parameter))
                return base.VisitParameter(parameter);
            return base.VisitParameter(node);
        }
    }
}
