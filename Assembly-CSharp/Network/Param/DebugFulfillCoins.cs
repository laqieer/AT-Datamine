// Decompiled with JetBrains decompiler
// Type: Network.Param.DebugFulfillCoins
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001A4E")]
  [Serializable]
  public class DebugFulfillCoins
  {
    [Token(Token = "0x400707B")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private string order_id;
    [Token(Token = "0x400707C")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private string product_id;
    [Token(Token = "0x400707D")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private int paid_coin;
    [Token(Token = "0x400707E")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private int free_coin;
    [Token(Token = "0x400707F")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private int common_coin;

    [Token(Token = "0x170018B1")]
    public string OrderId
    {
      [Token(Token = "0x6009646"), Address(RVA = "0x48EF06C", Offset = "0x48EF06C", VA = "0x48EF06C")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009647"), Address(RVA = "0x48EF074", Offset = "0x48EF074", VA = "0x48EF074")] set
      {
      }
    }

    [Token(Token = "0x170018B2")]
    public string ProductId
    {
      [Token(Token = "0x6009648"), Address(RVA = "0x48EF07C", Offset = "0x48EF07C", VA = "0x48EF07C")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009649"), Address(RVA = "0x48EF084", Offset = "0x48EF084", VA = "0x48EF084")] set
      {
      }
    }

    [Token(Token = "0x170018B3")]
    public int PaidCoin
    {
      [Token(Token = "0x600964A"), Address(RVA = "0x48EF08C", Offset = "0x48EF08C", VA = "0x48EF08C")] get
      {
        return new int();
      }
      [Token(Token = "0x600964B"), Address(RVA = "0x48EF094", Offset = "0x48EF094", VA = "0x48EF094")] set
      {
      }
    }

    [Token(Token = "0x170018B4")]
    public int FreeCoin
    {
      [Token(Token = "0x600964C"), Address(RVA = "0x48EF09C", Offset = "0x48EF09C", VA = "0x48EF09C")] get
      {
        return new int();
      }
      [Token(Token = "0x600964D"), Address(RVA = "0x48EF0A4", Offset = "0x48EF0A4", VA = "0x48EF0A4")] set
      {
      }
    }

    [Token(Token = "0x170018B5")]
    public int CommonCoin
    {
      [Token(Token = "0x600964E"), Address(RVA = "0x48EF0AC", Offset = "0x48EF0AC", VA = "0x48EF0AC")] get
      {
        return new int();
      }
      [Token(Token = "0x600964F"), Address(RVA = "0x48EF0B4", Offset = "0x48EF0B4", VA = "0x48EF0B4")] set
      {
      }
    }

    [Token(Token = "0x6009650")]
    [Address(RVA = "0x48EF0BC", Offset = "0x48EF0BC", VA = "0x48EF0BC")]
    public DebugFulfillCoins()
    {
    }
  }
}
