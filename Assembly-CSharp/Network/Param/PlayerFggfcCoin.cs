// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerFggfcCoin
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001AB2")]
  [Serializable]
  public class PlayerFggfcCoin
  {
    [Token(Token = "0x4007269")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int coin_quantity;
    [Token(Token = "0x400726A")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private string expiration_datetime;
    [Token(Token = "0x400726B")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private string added_date;

    [Token(Token = "0x17001AB6")]
    public int CoinQuantity
    {
      [Token(Token = "0x6009A9E"), Address(RVA = "0x48F13F0", Offset = "0x48F13F0", VA = "0x48F13F0")] get
      {
        return new int();
      }
      [Token(Token = "0x6009A9F"), Address(RVA = "0x48F13F8", Offset = "0x48F13F8", VA = "0x48F13F8")] set
      {
      }
    }

    [Token(Token = "0x17001AB7")]
    public string ExpirationDatetime
    {
      [Token(Token = "0x6009AA0"), Address(RVA = "0x48F1400", Offset = "0x48F1400", VA = "0x48F1400")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009AA1"), Address(RVA = "0x48F1408", Offset = "0x48F1408", VA = "0x48F1408")] set
      {
      }
    }

    [Token(Token = "0x17001AB8")]
    public string AddedDate
    {
      [Token(Token = "0x6009AA2"), Address(RVA = "0x48F1410", Offset = "0x48F1410", VA = "0x48F1410")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009AA3"), Address(RVA = "0x48F1418", Offset = "0x48F1418", VA = "0x48F1418")] set
      {
      }
    }

    [Token(Token = "0x6009AA4")]
    [Address(RVA = "0x48F1420", Offset = "0x48F1420", VA = "0x48F1420")]
    public PlayerFggfcCoin()
    {
    }
  }
}
