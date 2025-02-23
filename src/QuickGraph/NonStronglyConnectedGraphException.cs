﻿namespace QuickGraph
{
    /// <summary>
    /// Exception raised when an algorithm detects a non-strongly connected graph.
    /// </summary>
    public class NonStronglyConnectedGraphException 
        : QuickGraphException
    {
        public NonStronglyConnectedGraphException() { }
        public NonStronglyConnectedGraphException(string message) : base( message ) { }
        public NonStronglyConnectedGraphException(string message, System.Exception inner) : base( message, inner ) { }
    }
}
