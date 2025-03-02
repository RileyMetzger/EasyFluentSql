using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyFluentSql.Core.Interfaces.Clauses;

public interface IClause
{
    bool IsCollection { get; }
    string GetToken();
}

/// <summary>
/// for selecting column data, can be subqueries as well.
/// </summary>
public interface ISelectorClause : IClause
{
    string? Alias { get; }
}

/// <summary>
/// Handles Tables, views, arrays and subqueries.  Anything you can query from.
/// </summary>
public interface ITargetTableClause : IClause
{

    string? Alias { get; }

}

public interface IGroupByClause : IClause
{
}

/// <summary>
/// generates where portion of a statement. Where clauses can be logic attached to
/// columns, parameters and even subqueries.
/// </summary>
public interface IWhereClause : IClause
{
}

/// <summary>
/// special case where clause that applies to aggregate functions.
/// </summary>
public interface IHavingClause : IWhereClause
{

}




public interface ICollectionClause<TClause> : IClause
    where TClause : IClause
{
    void Add(TClause clause);

    IEnumerable<TClause> All();

    int Count();
}
