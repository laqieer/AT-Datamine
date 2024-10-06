// Decompiled with JetBrains decompiler
// Type: Network.API.APIItemSellRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using System;
using System.Collections.Generic;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001D3F")]
  [Serializable]
  public class APIItemSellRequest
  {
    [Token(Token = "0x4007CE5")]
    [FieldOffset(Offset = "0x10")]
    public List<PlayerSellItemType> sell_items;

    [Token(Token = "0x600AC79")]
    [Address(RVA = "0x1A4690C", Offset = "0x1A4690C", VA = "0x1A4690C")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600AC7A")]
    [Address(RVA = "0x1A46954", Offset = "0x1A46954", VA = "0x1A46954")]
    public APIItemSellRequest()
    {
    }
  }
}
