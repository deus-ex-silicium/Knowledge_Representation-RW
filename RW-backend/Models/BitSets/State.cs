﻿using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("RW-tests")]
namespace RW_backend.Models.BitSets
{
    /// <summary>
    /// Reprezentuje stan świata - wartości fluentów
    /// </summary>
    public class State:BitSet
    {
	    public State(int fluentValues) : base(fluentValues) {}
	    public int FluentValues => this.Set;
		public bool FluentValue (int fluentNumber) => this.ElementValue(fluentNumber);
    }
}