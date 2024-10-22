// Copyright (c) 2021 The Bitcask Authors. All rights reserved.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitcask.Interface
{
    public interface IIndex
    {
        string Key { get; }
        
        uint FileIndex {  get; }
        ulong FileOffset { get; }

        uint KeySize { get; }
        uint ValueSize { get; }
        uint DataSize { get; }
        uint IndexSize { get; }
    }
}
