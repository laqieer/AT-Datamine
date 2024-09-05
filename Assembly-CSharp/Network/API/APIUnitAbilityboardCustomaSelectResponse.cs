// Decompiled with JetBrains decompiler
// Type: Network.API.APIUnitAbilityboardCustomaSelectResponse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001E94")]
  [Serializable]
  public class APIUnitAbilityboardCustomaSelectResponse
  {
    [Token(Token = "0x4008364")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private PlayerUnitType player_unit;
    [Token(Token = "0x4008365")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private PlayerUnitCharacterType player_unit_character;
    [Token(Token = "0x4008366")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private List<PlayerUnitAbilityBoardType> release_nodes;
    [Token(Token = "0x4008367")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private PlayerUnitAbilityBoardCustomANodeType current_custom_node;
    [Token(Token = "0x4008368")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private List<PlayerStyleMasterBonusType> player_style_master_bonuses;

    [Token(Token = "0x17002549")]
    public PlayerUnitType PlayerUnit
    {
      [Token(Token = "0x600B582"), Address(RVA = "0x22E9784", Offset = "0x22E9784", VA = "0x22E9784")] get
      {
        return (PlayerUnitType) null;
      }
    }

    [Token(Token = "0x1700254A")]
    public PlayerUnitCharacterType PlayerUnitCharacter
    {
      [Token(Token = "0x600B583"), Address(RVA = "0x22E978C", Offset = "0x22E978C", VA = "0x22E978C")] get
      {
        return (PlayerUnitCharacterType) null;
      }
    }

    [Token(Token = "0x1700254B")]
    public List<PlayerUnitAbilityBoardType> ReleaseNodes
    {
      [Token(Token = "0x600B584"), Address(RVA = "0x22E9794", Offset = "0x22E9794", VA = "0x22E9794")] get
      {
        return (List<PlayerUnitAbilityBoardType>) null;
      }
    }

    [Token(Token = "0x1700254C")]
    public PlayerUnitAbilityBoardCustomANodeType CurrentCustomNode
    {
      [Token(Token = "0x600B585"), Address(RVA = "0x22E979C", Offset = "0x22E979C", VA = "0x22E979C")] get
      {
        return (PlayerUnitAbilityBoardCustomANodeType) null;
      }
    }

    [Token(Token = "0x1700254D")]
    public List<PlayerStyleMasterBonusType> PlayerStyleMasterBonuses
    {
      [Token(Token = "0x600B586"), Address(RVA = "0x22E97A4", Offset = "0x22E97A4", VA = "0x22E97A4")] get
      {
        return (List<PlayerStyleMasterBonusType>) null;
      }
    }

    [Token(Token = "0x600B587")]
    [Address(RVA = "0x22E97AC", Offset = "0x22E97AC", VA = "0x22E97AC")]
    public APIUnitAbilityboardCustomaSelectResponse()
    {
    }
  }
}
