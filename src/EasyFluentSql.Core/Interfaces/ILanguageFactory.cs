using EasyFluentSql.Core.Interfaces.Clauses;

namespace EasyFluentSql.Core.Interfaces;

public interface ILanguageFactory 
{
    ISelectorFactory SelectorFactory { get; }
    ITargetFactory TargetFactory { get; }
    IWhereFactory WhereFactory { get; }
    IGroupByFactory GroupByFactory { get; }
    IHavingFactory HavingClause { get; }
}

public interface ISelectorFactory
{
    ISelectorClause GetSelectorRoot();
}

public interface ITargetFactory
{
    ITargetTableClause GetTargetRoot();
}

public interface IWhereFactory
{
    IWhereClause GetWhereRoot();
}

public interface IGroupByFactory
{
    IGroupByClause GetGroupByRoot();
}

public interface IHavingFactory
{
    IHavingClause GetHavingClauseRoot();
}

