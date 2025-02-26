using EasyFluentSql.Core.Interfaces.Clauses;

namespace EasyFluentSql.Core.Abstracts.Clauses;

public abstract class SelectorClause(string columnName, string? alias = null) : ISelectorClause
{
    public string ColumnName { get; } = columnName;

    public string? Alias { get; } = alias;

    public abstract string Build();
}

public abstract class SubQuerySelectorClass(SelectStatement selectStatement, string? alias = null) : ISelectorClause
{
    public SelectStatement SelectStatement { get; } = selectStatement;
    public string? Alias { get; } = alias;

    public abstract string Build();
}

public abstract class SelectorCollectionClause : CollectionClause<ISelectorClause>, ISelectorClause
{

}