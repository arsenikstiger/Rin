﻿using System;
using System.Collections.Generic;

namespace Rin.Core.Record
{
    public sealed class NullTimelineScope : ITimelineScope
    {
        public static NullTimelineScope Instance { get; } = new NullTimelineScope();

        public string Name
        {
            get => String.Empty;
            set { }
        }

        public string Category
        {
            get => String.Empty;
            set { }
        }

        public string Data
        {
            get => null;
            set { }
        }

        public IReadOnlyCollection<TimelineScope> Children => Array.Empty<TimelineScope>();

        public DateTimeOffset Timestamp
        {
            get => default;
            set { }
        }

        public TimeSpan Duration
        {
            get => default;
            set { }
        }

        public void Complete()
        {
        }

        public void Dispose()
        {
        }

        ITimelineScope ITimelineScope.Create(string name, string category, string data) => this;
    }
}
