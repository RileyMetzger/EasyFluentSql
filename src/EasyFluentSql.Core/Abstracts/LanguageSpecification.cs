using System.ComponentModel;
using EasyFluentSql.Core.Interfaces;

namespace EasyFluentSql.Core.Abstracts;

public abstract class LanguageSpecification<T> : ILanguageSpecification
    where T : LanguageSpecification<T>, new() // Enforce a parameterless constructor
{
    public static T Instance { get; } = new T(); // Safe instantiation
}