namespace SetTheory.Conditions;

public class ParentsWifeCondition : ICondition
{
    public bool AnyMother(string women, FeatureVector[] parents, FeatureVector[] wives)
    {
        string[]? husbands = null;
        foreach (var wife in wives)
            if (wife.Label == women)
            {
                husbands = wife.Values;
            }

        if (husbands == null) return false;

        foreach (var parent in parents)
            if (husbands.Contains(parent.Label))
                return true;
        return false;
    }
}