﻿using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace NLinq
{
    public class PagedEnumerable<T> : IPageable<T>, IEnumerable<T>
    {
        public IEnumerable<T> Items { get; protected set; }
        public int PageNumber { get; protected set; }
        public int PageSize { get; protected set; }
        public int PageCount { get; protected set; }
        public int SourceCount { get; protected set; }
        public bool IsFristPage => PageNumber == 1;
        public bool IsLastPage => PageNumber == PageCount;

        protected PagedEnumerable() { }

        public PagedEnumerable(IEnumerable<T> source, int page, int pageSize)
        {
            PageSize = pageSize;
            PageCount = source.PageCount(pageSize, out var sourceCount);
            SourceCount = sourceCount;

            if (PageCount > 0)
            {
                switch (page)
                {
                    case int p when p < 1: PageNumber = 1; break;
                    case int p when p > PageCount: PageNumber = PageCount; break;
                    default: PageNumber = page; break;
                }
                Items = source.Skip((PageNumber - 1) * PageSize).Take(PageSize);
            }
            else Items = source;
        }

        public PagedEnumerable(PagedQueryable<T> pagedQueryable)
        {
            PageSize = pagedQueryable.PageSize;
            PageCount = pagedQueryable.PageCount;
            PageNumber = pagedQueryable.PageNumber;
            SourceCount = pagedQueryable.SourceCount;
            Items = pagedQueryable.ToArray();
        }

        public IEnumerator<T> GetEnumerator() => Items.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => Items.GetEnumerator();
    }

}
