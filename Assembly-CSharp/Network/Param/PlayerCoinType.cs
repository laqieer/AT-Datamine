// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerCoinType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001A9D")]
  [Serializable]
  public class PlayerCoinType
  {
    [Token(Token = "0x4007214")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int common_coin;
    [Token(Token = "0x4007215")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int free_coin;
    [Token(Token = "0x4007216")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private int paid_coin;

    [Token(Token = "0x17001A61")]
    public int CommonCoin
    {
      [Token(Token = "0x60099DF"), Address(RVA = "0x48F0DF0", Offset = "0x48F0DF0", VA = "0x48F0DF0")] get
      {
        return new int();
      }
      [Token(Token = "0x60099E0"), Address(RVA = "0x48F0DF8", Offset = "0x48F0DF8", VA = "0x48F0DF8")] set
      {
      }
    }

    [Token(Token = "0x17001A62")]
    public int FreeCoin
    {
      [Token(Token = "0x60099E1"), Address(RVA = "0x48F0E00", Offset = "0x48F0E00", VA = "0x48F0E00")] get
      {
        return new int();
      }
      [Token(Token = "0x60099E2"), Address(RVA = "0x48F0E08", Offset = "0x48F0E08", VA = "0x48F0E08")] set
      {
      }
    }

    [Token(Token = "0x17001A63")]
    public int PaidCoin
    {
      [Token(Token = "0x60099E3"), Address(RVA = "0x48F0E10", Offset = "0x48F0E10", VA = "0x48F0E10")] get
      {
        return new int();
      }
      [Token(Token = "0x60099E4"), Address(RVA = "0x48F0E18", Offset = "0x48F0E18", VA = "0x48F0E18")] set
      {
      }
    }

    [Token(Token = "0x60099E5")]
    [Address(RVA = "0x48F0E20", Offset = "0x48F0E20", VA = "0x48F0E20")]
    public PlayerCoinType()
    {
    }
  }
}
