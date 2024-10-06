// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerCoinShopType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001A9C")]
  [Serializable]
  public class PlayerCoinShopType
  {
    [Token(Token = "0x400720F")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int shop_id;
    [Token(Token = "0x4007210")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private string name;
    [Token(Token = "0x4007211")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private string end_at;
    [Token(Token = "0x4007212")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private int show_priority;
    [Token(Token = "0x4007213")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private List<PlayerCoinShopArticleType> articles;

    [Token(Token = "0x17001A5C")]
    public int ShopId
    {
      [Token(Token = "0x60099D4"), Address(RVA = "0x48F0D98", Offset = "0x48F0D98", VA = "0x48F0D98")] get
      {
        return new int();
      }
      [Token(Token = "0x60099D5"), Address(RVA = "0x48F0DA0", Offset = "0x48F0DA0", VA = "0x48F0DA0")] set
      {
      }
    }

    [Token(Token = "0x17001A5D")]
    public string Name
    {
      [Token(Token = "0x60099D6"), Address(RVA = "0x48F0DA8", Offset = "0x48F0DA8", VA = "0x48F0DA8")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60099D7"), Address(RVA = "0x48F0DB0", Offset = "0x48F0DB0", VA = "0x48F0DB0")] set
      {
      }
    }

    [Token(Token = "0x17001A5E")]
    public string EndAt
    {
      [Token(Token = "0x60099D8"), Address(RVA = "0x48F0DB8", Offset = "0x48F0DB8", VA = "0x48F0DB8")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60099D9"), Address(RVA = "0x48F0DC0", Offset = "0x48F0DC0", VA = "0x48F0DC0")] set
      {
      }
    }

    [Token(Token = "0x17001A5F")]
    public int ShowPriority
    {
      [Token(Token = "0x60099DA"), Address(RVA = "0x48F0DC8", Offset = "0x48F0DC8", VA = "0x48F0DC8")] get
      {
        return new int();
      }
      [Token(Token = "0x60099DB"), Address(RVA = "0x48F0DD0", Offset = "0x48F0DD0", VA = "0x48F0DD0")] set
      {
      }
    }

    [Token(Token = "0x17001A60")]
    public List<PlayerCoinShopArticleType> Articles
    {
      [Token(Token = "0x60099DC"), Address(RVA = "0x48F0DD8", Offset = "0x48F0DD8", VA = "0x48F0DD8")] get
      {
        return (List<PlayerCoinShopArticleType>) null;
      }
      [Token(Token = "0x60099DD"), Address(RVA = "0x48F0DE0", Offset = "0x48F0DE0", VA = "0x48F0DE0")] set
      {
      }
    }

    [Token(Token = "0x60099DE")]
    [Address(RVA = "0x48F0DE8", Offset = "0x48F0DE8", VA = "0x48F0DE8")]
    public PlayerCoinShopType()
    {
    }
  }
}
