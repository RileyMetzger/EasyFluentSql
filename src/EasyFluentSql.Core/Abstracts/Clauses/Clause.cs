using EasyFluentSql.Core.Interfaces.Clauses;

namespace EasyFluentSql.Core.Abstracts.Clauses;

public abstract class Clause : IClause
{
    public abstract string Build();
}


public abstract class CollectionClause<TClause> : ICollectionClause<TClause> where TClause : IClause
{
    private readonly List<TClause> _clauses = [];


    public void Add(TClause clause)
    {
        _clauses.Add(clause);
    }

    public IEnumerable<TClause> All()
    {
        return _clauses.AsEnumerable();
    }

    public int Count()
    {
        return _clauses.Count();
    }

    public abstract string Build();
}