// Decompiled with JetBrains decompiler
// Type: Network.API.APIUnitCharacterComebackResponse
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
  [Token(Token = "0x2001EAC")]
  [Serializable]
  public class APIUnitCharacterComebackResponse
  {
    [Token(Token = "0x40083CC")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private PlayerUnitCharacterType updated_player_unit_character;
    [Token(Token = "0x40083CD")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private PlayerCoinType player_coin;

    [Token(Token = "0x17002589")]
    public PlayerUnitCharacterType UpdatedPlayerUnitCharacter
    {
      [Token(Token = "0x600B622"), Address(RVA = "0x22EB82C", Offset = "0x22EB82C", VA = "0x22EB82C")] get
      {
        return (PlayerUnitCharacterType) null;
      }
    }

    [Token(Token = "0x1700258A")]
    public PlayerCoinType PlayerCoin
    {
      [Token(Token = "0x600B623"), Address(RVA = "0x22EB834", Offset = "0x22EB834", VA = "0x22EB834")] get
      {
        return (PlayerCoinType) null;
      }
    }

    [Token(Token = "0x600B624")]
    [Address(RVA = "0x22EB83C", Offset = "0x22EB83C", VA = "0x22EB83C")]
    public APIUnitCharacterComebackResponse()
    {
    }
  }
}
