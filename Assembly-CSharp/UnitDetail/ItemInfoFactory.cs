// Decompiled with JetBrains decompiler
// Type: UnitDetail.ItemInfoFactory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace UnitDetail
{
  [Token(Token = "0x2000497")]
  public abstract class ItemInfoFactory
  {
    [Token(Token = "0x60019C1")]
    [Address(RVA = "0x2C232C4", Offset = "0x2C232C4", VA = "0x2C232C4")]
    public List<ItemInfoBase> Create() => (List<ItemInfoBase>) null;

    [Token(Token = "0x60019C2")]
    protected abstract List<ItemInfoBase> CreateItemList();

    [Token(Token = "0x60019C3")]
    [Address(RVA = "0x2C232D0", Offset = "0x2C232D0", VA = "0x2C232D0")]
    protected ItemInfoFactory()
    {
    }
  }
}
