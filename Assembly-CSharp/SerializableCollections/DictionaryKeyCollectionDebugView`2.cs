// Decompiled with JetBrains decompiler
// Type: SerializableCollections.DictionaryKeyCollectionDebugView`2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using System.Diagnostics;

#nullable disable
namespace SerializableCollections
{
  [Token(Token = "0x20019B1")]
  internal sealed class DictionaryKeyCollectionDebugView<TKey, TValue>
  {
    [Token(Token = "0x4006E54")]
    [FieldOffset(Offset = "0x0")]
    private readonly ICollection<TKey> _collection;

    [Token(Token = "0x60092CC")]
    public DictionaryKeyCollectionDebugView(ICollection<TKey> collection)
    {
    }

    [Token(Token = "0x170017AF")]
    [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
    public TKey[] Items
    {
      [Token(Token = "0x60092CD")] get => (TKey[]) null;
    }
  }
}
