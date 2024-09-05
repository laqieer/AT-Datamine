// Decompiled with JetBrains decompiler
// Type: SerializableCollections.DictionaryValueCollectionDebugView`2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using System.Diagnostics;

#nullable disable
namespace SerializableCollections
{
  [Token(Token = "0x20019B2")]
  internal sealed class DictionaryValueCollectionDebugView<TKey, TValue>
  {
    [Token(Token = "0x4006E55")]
    [FieldOffset(Offset = "0x0")]
    private readonly ICollection<TValue> _collection;

    [Token(Token = "0x60092CE")]
    public DictionaryValueCollectionDebugView(ICollection<TValue> collection)
    {
    }

    [Token(Token = "0x170017B0")]
    [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
    public TValue[] Items
    {
      [Token(Token = "0x60092CF")] get => (TValue[]) null;
    }
  }
}
