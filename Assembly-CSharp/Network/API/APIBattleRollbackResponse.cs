// Decompiled with JetBrains decompiler
// Type: Network.API.APIBattleRollbackResponse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using System;
using UnityEngine;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001BB0")]
  [Serializable]
  public class APIBattleRollbackResponse
  {
    [Token(Token = "0x40076B6")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private PlayerCoinType player_coin;

    [Token(Token = "0x17001E11")]
    public PlayerCoinType PlayerCoin
    {
      [Token(Token = "0x600A2BA"), Address(RVA = "0x46CC3C0", Offset = "0x46CC3C0", VA = "0x46CC3C0")] get
      {
        return (PlayerCoinType) null;
      }
    }

    [Token(Token = "0x600A2BB")]
    [Address(RVA = "0x46CC3C8", Offset = "0x46CC3C8", VA = "0x46CC3C8")]
    public APIBattleRollbackResponse()
    {
    }
  }
}
