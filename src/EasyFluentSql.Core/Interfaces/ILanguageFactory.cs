using EasyFluentSql.Core.Interfaces.Clauses;

namespace EasyFluentSql.Core.Interfaces;

public interface ILanguageFactory
{
    ISelectorClause GetSelectorRoot();
    ITargetTableClause GetTargetRoot();
    IWhereClause GetWhereRoot();
    IGroupByClause GetGroupByRoot();
}