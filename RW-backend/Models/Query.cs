﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using RW_backend.Models.GraphModels;

[assembly: InternalsVisibleTo("RW-tests")]
namespace RW_backend.Models
{
    /// <summary>
    /// Reprezentacja kwerendy
    /// </summary>
    public abstract class Query
    {
        public enum QueryType
        {
            Executable,
            After,
            Engaged
        }
        public abstract QueryType Type { get; }
        
        public abstract QueryResult Evaluate(World world);

        //opcjonalnie tworzenie kwerend na podstawie zdania
        public static Query Create(string queryString)
        {
            throw new NotImplementedException();
        }
    }

	public class QueryResult
    {
        public bool IsTrue;
        public List<State> Function;
    }

    //TODO zaimplementować typy odpowiadające kwerendom executable, after i engaged
}
