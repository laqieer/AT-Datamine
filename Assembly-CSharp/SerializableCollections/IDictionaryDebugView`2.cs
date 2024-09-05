// Decompiled with JetBrains decompiler
// Type: SerializableCollections.IDictionaryDebugView`2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using System.Diagnostics;

#nullable disable
namespace SerializableCollections
{
  [Token(Token = "0x20019B0")]
  internal sealed class IDictionaryDebugView<K, V>
  {
    [Token(Token = "0x4006E53")]
    [FieldOffset(Offset = "0x0")]
    private readonly IDictionary<K, V> _dict;

    [Token(Token = "0x60092CA")]
    public IDictionaryDebugView(IDictionary<K, V> dictionary)
    {
    }

    [Token(Token = "0x170017AE")]
    [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
    public KeyValuePair<K, V>[] Items
    {
      [Token(Token = "0x60092CB")] get => (KeyValuePair<K, V>[]) null;
    }
  }
}
