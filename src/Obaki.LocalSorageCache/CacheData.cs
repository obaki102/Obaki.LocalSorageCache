﻿namespace Obaki.LocalSorageCache
{
    public record CacheData<T>
    {
        private DateTime _createDateTime;

        public CacheData()
        {
            _createDateTime = DateTime.Now;
        }
        public T? Cache { get; init; }
        public DateTime Created { get => _createDateTime; set => _createDateTime = value; }
    }
}