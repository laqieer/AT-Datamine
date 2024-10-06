// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerShopContentType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001ADE")]
  [Serializable]
  public class PlayerShopContentType
  {
    [Token(Token = "0x400733C")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int content_id;
    [Token(Token = "0x400733D")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int sort_number;
    [Token(Token = "0x400733E")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Reward reward_item;

    [Token(Token = "0x17001B9E")]
    public int ContentId
    {
      [Token(Token = "0x6009C85"), Address(RVA = "0x48F24C0", Offset = "0x48F24C0", VA = "0x48F24C0")] get
      {
        return new int();
      }
      [Token(Token = "0x6009C86"), Address(RVA = "0x48F24C8", Offset = "0x48F24C8", VA = "0x48F24C8")] set
      {
      }
    }

    [Token(Token = "0x17001B9F")]
    public int SortNumber
    {
      [Token(Token = "0x6009C87"), Address(RVA = "0x48F24D0", Offset = "0x48F24D0", VA = "0x48F24D0")] get
      {
        return new int();
      }
      [Token(Token = "0x6009C88"), Address(RVA = "0x48F24D8", Offset = "0x48F24D8", VA = "0x48F24D8")] set
      {
      }
    }

    [Token(Token = "0x17001BA0")]
    public Reward RewardItem
    {
      [Token(Token = "0x6009C89"), Address(RVA = "0x48F24E0", Offset = "0x48F24E0", VA = "0x48F24E0")] get
      {
        return (Reward) null;
      }
      [Token(Token = "0x6009C8A"), Address(RVA = "0x48F24E8", Offset = "0x48F24E8", VA = "0x48F24E8")] set
      {
      }
    }

    [Token(Token = "0x6009C8B")]
    [Address(RVA = "0x48F24F0", Offset = "0x48F24F0", VA = "0x48F24F0")]
    public PlayerShopContentType()
    {
    }
  }
}
