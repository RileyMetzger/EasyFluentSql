namespace EasyFluentSql.Core.ValueTypes;

public enum JoinType
{
    Inner = 0,      // Returns records with matching keys in both tables.
    Left,       // Returns all records from the left table and matched records from the right table.
    Right,      // Returns all records from the right table and matched records from the left table.
    Full        // Returns records when there is a match in one of the tables.
}