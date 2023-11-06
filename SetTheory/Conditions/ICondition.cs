namespace SetTheory.Conditions;

public interface ICondition
{
    bool AnyMother(string women, FeatureVector[] parents, FeatureVector[] wives);
}