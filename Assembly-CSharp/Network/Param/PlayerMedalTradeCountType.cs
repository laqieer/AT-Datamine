// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerMedalTradeCountType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001AC9")]
  [Serializable]
  public class PlayerMedalTradeCountType
  {
    [Token(Token = "0x40072C6")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int prize_id;
    [Token(Token = "0x40072C7")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int count;
    [Token(Token = "0x40072C8")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private string next_reset_at;

    [Token(Token = "0x17001B1C")]
    public int PrizeId
    {
      [Token(Token = "0x6009B78"), Address(RVA = "0x48F1BD4", Offset = "0x48F1BD4", VA = "0x48F1BD4")] get
      {
        return new int();
      }
      [Token(Token = "0x6009B79"), Address(RVA = "0x48F1BDC", Offset = "0x48F1BDC", VA = "0x48F1BDC")] set
      {
      }
    }

    [Token(Token = "0x17001B1D")]
    public int Count
    {
      [Token(Token = "0x6009B7A"), Address(RVA = "0x48F1BE4", Offset = "0x48F1BE4", VA = "0x48F1BE4")] get
      {
        return new int();
      }
      [Token(Token = "0x6009B7B"), Address(RVA = "0x48F1BEC", Offset = "0x48F1BEC", VA = "0x48F1BEC")] set
      {
      }
    }

    [Token(Token = "0x17001B1E")]
    public string NextResetAt
    {
      [Token(Token = "0x6009B7C"), Address(RVA = "0x48F1BF4", Offset = "0x48F1BF4", VA = "0x48F1BF4")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009B7D"), Address(RVA = "0x48F1BFC", Offset = "0x48F1BFC", VA = "0x48F1BFC")] set
      {
      }
    }

    [Token(Token = "0x6009B7E")]
    [Address(RVA = "0x48F1C04", Offset = "0x48F1C04", VA = "0x48F1C04")]
    public PlayerMedalTradeCountType()
    {
    }
  }
}
