using EasyFluentSql.Core.Interfaces;
using EasyFluentSql.Core.Interfaces.Clauses;

namespace EasyFluentSql.Core.Abstracts.Clauses;

public abstract class Clause<TSpecification> : IClause
    where TSpecification : ILanguageSpecification, new()
{
    private static Lazy<TSpecification> SpecificationLazy { get; } = new(() => new TSpecification());
    public static TSpecification Specification => SpecificationLazy.Value;
    public virtual bool IsCollection => false;
    public abstract string GetToken();
}


public abstract class CollectionClause<TClause, TSpecification>(TSpecification specification) 
    : Clause<TSpecification>, ICollectionClause<TClause> 
        where TClause : IClause 
        where TSpecification : ILanguageSpecification, new()
{
    public override bool IsCollection => true;

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
    
}

