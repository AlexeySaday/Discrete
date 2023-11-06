namespace SetTheory.Conditions;

public class WomanAndParentCondition : ICondition
{
    public bool AnyMother(string women, FeatureVector[] parents, FeatureVector[] wives)
    {
        var res = false;
        foreach (var wife in wives)
            if (wife.Label == women)
                res = true;
        if (!res) return res;
        foreach (var parent in parents)
            if (parent.Label == women)
                return true;
        return false;
    }
}