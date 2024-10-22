// Copyright (c) 2021 The Bitcask Authors. All rights reserved.

using Bitcask.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitcask
{
    public class Index : IIndex
    {
        public Index(string key) : this(key, 0, 0, 0, 0)
        {
        }

        public Index(string key, uint fileIndex, ulong fileOffset, uint keySize, uint valueSize)
        {
            if (string.IsNullOrWhiteSpace(key)) throw new ArgumentNullException(nameof(key));

            Key = key;
            FileIndex = fileIndex;
            FileOffset = fileOffset;
            KeySize = keySize;
            ValueSize = valueSize;
        }

        public string Key { get; private set; }

        public uint FileIndex { get; private set; }

        public ulong FileOffset { get; private set; }

        public uint KeySize { get; private set; }

        public uint ValueSize { get; private set; }

        public uint DataSize  => KeySize + ValueSize;

        public uint IndexSize => KeySize + sizeof(uint) * 3 + sizeof(ulong);
    }
}
