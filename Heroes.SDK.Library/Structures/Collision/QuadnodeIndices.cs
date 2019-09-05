﻿using Heroes.SDK.Utility.Interfaces;
using Reloaded.Memory;

namespace Heroes.SDK.Stage.Collision.Structures
{
    /// <summary>
    /// Note: Big Endian
    /// </summary>
    public struct QuadnodeIndices : IEndianConvertible
    {
        /// <summary>
        /// Unique index of the current node.
        /// </summary>
        public ushort Self;

        /// <summary>
        /// Index of the parent node.
        /// </summary>
        public ushort Parent;

        /// <summary>
        /// The index of the first out of four children of the node, 0 if no child. 
        /// </summary>
        public ushort Child;

        public void SwapEndian()
        {
            Endian.Reverse(ref Self);
            Endian.Reverse(ref Parent);
            Endian.Reverse(ref Child);
        }
    }
}
