using EasyFluentSql.Core.Interfaces;
using EasyFluentSql.Core.Interfaces.Clauses;

namespace EasyFluentSql.Core.Abstracts.Clauses;

public abstract class SelectorClause<TSpecification> : Clause<TSpecification>, ISelectorClause
    where TSpecification : ILanguageSpecification, new()
{
    public string ColumnName { get; }

    public string? Alias { get; }

    public SelectorClause(string columnName, string? alias)
    {
        ColumnName = columnName;
        Alias = alias;
    }
    
}

public abstract class SelectorSubquery<TSpecification> : Clause<TSpecification>, ISelectorClause
    where TSpecification : ILanguageSpecification, new()
{
    public string? Alias { get; }

    protected SelectorSubquery(string? alias)
    {
        Alias = alias;
    }
}

public abstract class SelectorParent<TSpecification>(TSpecification specification) 
    : CollectionClause<ISelectorClause, TSpecification>(specification), ISelectorClause
        where TSpecification : ILanguageSpecification, new()
{
    public string? Alias { get; }
}

