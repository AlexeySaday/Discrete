using SetTheory.Conditions;

namespace SetTheory;

/// <summary>
///  Сформулируйте правило вывода для извлечения ин-
/// формации о матерях из экспертной системы «КОРОЛЕВСКАЯ ДИНА-
/// стия». Определите правило мать(x) так, чтобы положительный от-
/// вет на соответствующий запрос выдавался в том случае, если х —
/// жена чьего-то родителя или х — женщина и чей-то родитель. При-
/// мените новое правило совместно с правилом (1) к исходной базе
/// данных для определения максимально возможного числа матерей.
/// Удовлетворительным ли получилось новое правило вывода?
/// </summary>
public class RoyalDynastyMotherChecker : ICondition // @TODO  RoyalDynastyMotherChecker : ICondition - логика не очень
{
    private readonly ICondition[] _conditions;

    public RoyalDynastyMotherChecker(params ICondition[] conditions)
    {
        _conditions = conditions;
    }
     
    public bool AnyMother(string women, FeatureVector[] parents, FeatureVector[] wives) 
        => _conditions.Any(x => x.AnyMother(women, parents, wives)); 
}