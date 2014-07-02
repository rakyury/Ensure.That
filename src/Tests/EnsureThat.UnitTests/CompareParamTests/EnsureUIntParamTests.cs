namespace EnsureThat.UnitTests.CompareParamTests
{
    public class EnsureUIntParamTests : EnsureCompareParamTests<uint>
    {
        protected override Param<uint> IsLt(CompareParamTestSpec<uint> spec)
        {
            return Ensure.That(spec.Value, ParamName).IsLt(spec.Limit);
        }

        protected override CompareParamTestSpec<uint> When_value_is_gt_than_limit()
        {
            return new CompareParamTestSpec<uint> { Limit = 42, Value = 43 };
        }

        protected override CompareParamTestSpec<uint> When_value_is_equal_to_limit()
        {
            return new CompareParamTestSpec<uint> { Limit = 42, Value = 42 };
        }

        protected override CompareParamTestSpec<uint> When_value_is_lt_than_limit()
        {
            return new CompareParamTestSpec<uint> { Limit = 42, Value = 41 };
        }

        protected override Param<uint> IsGt(CompareParamTestSpec<uint> spec)
        {
            return Ensure.That(spec.Value, ParamName).IsGt(spec.Limit);
        }

        protected override Param<uint> IsLte(CompareParamTestSpec<uint> spec)
        {
            return Ensure.That(spec.Value, ParamName).IsLte(spec.Limit);
        }

        protected override Param<uint> IsGte(CompareParamTestSpec<uint> spec)
        {
            return Ensure.That(spec.Value, ParamName).IsGte(spec.Limit);
        }

        protected override Param<uint> IsInRange(CompareParamTestSpec<uint> spec)
        {
            return Ensure.That(spec.Value, ParamName).IsInRange(spec.LowerLimit, spec.UpperLimit);
        }

        protected override CompareParamTestSpec<uint> When_value_is_lower_limit()
        {
            return new CompareParamTestSpec<uint> { LowerLimit = 42, UpperLimit = 50, Value = 42 };
        }

        protected override CompareParamTestSpec<uint> When_value_is_upper_limit()
        {
            return new CompareParamTestSpec<uint> { LowerLimit = 42, UpperLimit = 50, Value = 50 };
        }

        protected override CompareParamTestSpec<uint> When_value_is_between_limits()
        {
            return new CompareParamTestSpec<uint> { LowerLimit = 40, UpperLimit = 50, Value = 45 };
        }

        protected override CompareParamTestSpec<uint> When_value_is_lower_than_lower_limit()
        {
            return new CompareParamTestSpec<uint> { LowerLimit = 40, UpperLimit = 50, Value = 39 };
        }

        protected override CompareParamTestSpec<uint> When_value_is_greater_than_upper_limit()
        {
            return new CompareParamTestSpec<uint> { LowerLimit = 40, UpperLimit = 50, Value = 51 };
        }
    }
}