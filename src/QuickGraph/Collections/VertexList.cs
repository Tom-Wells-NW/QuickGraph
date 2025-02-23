﻿using System;
using System.Collections.Generic;

namespace QuickGraph.Collections
{
    [Serializable]
    public sealed class VertexList<TVertex>
        : List<TVertex>
        , ICloneable
    {
        public VertexList()
        { }

        public VertexList(int capacity)
            : base(capacity)
        { }

        public VertexList(VertexList<TVertex> other)
            : base(other)
        { }

        public VertexList<TVertex> Clone()
        {
            return new VertexList<TVertex>(this);
        }

        object ICloneable.Clone()
        {
            return this.Clone();
        }
    }
}
