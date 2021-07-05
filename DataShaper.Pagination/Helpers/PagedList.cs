using System;
using System.Collections.Generic;
using System.Linq;

namespace DataShaper.Pagination.Helpers
{
    // [Obsolete]
    public class PagedList<T> : List<T>
    {
        public int Offset { get; private set; }
        public int TotalSize { get; private set; }
        public int Limit { get; private set; }

        // public bool HasPrevious => CurrentPage > 1;
        // public bool HasNext => CurrentPage < TotalPages;

        public PagedList(IList<T> items, int totalSize, int offset, int limit)
        {
            this.TotalSize = totalSize;
            this.Offset = offset;
            this.Limit = limit;

            AddRange(items);
        }

        public static PagedList<T> QueryToPagedList(IEnumerable<T> source, int totalSize, int offset, int limit)
        {
            var items = source.Skip(offset).Take(limit);

            return new PagedList<T>(items.ToList(), totalSize, offset, limit);
        }
    }
}