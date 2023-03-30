﻿namespace LRBee.Utilities
{
    public static class FNVHash
    {
        private const ulong OffsetBasis = 0xCBF29CE484222325;
        private const ulong Prime = 0x100000001B3;

        public static int Get<TItem>(IEnumerable<TItem> items) =>
            (int)items.Aggregate(
                OffsetBasis,
                (hash, item) => (hash ^ (ulong)(item?.GetHashCode() ?? 0)) * Prime);
    }
}