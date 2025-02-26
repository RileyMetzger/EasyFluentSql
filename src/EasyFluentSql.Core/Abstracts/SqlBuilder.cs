using System.ComponentModel;
using EasyFluentSql.Core.Interfaces;
using EasyFluentSql.Core.Interfaces.Clauses;

namespace EasyFluentSql.Core.Abstracts;

public interface ISqlBuilder
{
    string Build();
}

public abstract class SqlBuilder<TLanguageFactory>(TLanguageFactory factory) : ISqlBuilder
    where TLanguageFactory : ILanguageFactory
{
    public TLanguageFactory Factory { get; } = factory;

    public abstract string Build();
    
}

public abstract class SqlStatement<TBuilder> 
    where TBuilder : ISqlBuilder
{
    protected virtual TBuilder Builder { get; } = Activator.CreateInstance<TBuilder>();
}

public abstract class SelectBuilder<TLanguageFactory> : SqlBuilder<TLanguageFactory>
    where TLanguageFactory : ILanguageFactory
{
    protected ISelectorClause SelectClause { get; }
    protected ITargetTableClause SelectionSourceClause { get; }
    protected IWhereClause WhereClause { get; }
    protected IGroupByClause GroupByClause { get; }

    protected SelectBuilder(TLanguageFactory factory) : base(factory)
    {
        SelectClause = Factory.GetSelectorRoot();
        SelectionSourceClause = Factory.GetTargetRoot();
        WhereClause = Factory.GetWhereRoot();
        GroupByClause = Factory.GetGroupByRoot();
    }

}



public abstract class SelectStatement<TLanguageFactory> : SqlStatement<SelectBuilder<TLanguageFactory>>
    where TLanguageFactory : ILanguageFactory
{
    
}








