// Decompiled with JetBrains decompiler
// Type: Network.API.APICustomSkillEnhanceResponse
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
  [Token(Token = "0x2001BE8")]
  [Serializable]
  public class APICustomSkillEnhanceResponse : IPostApiResult, ICommonApiResult
  {
    [Token(Token = "0x400777E")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x400777F")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UpdatedPlayerDataSet updated_player_data_set;
    [Token(Token = "0x4007780")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayerCoinType player_coin;
    [Token(Token = "0x4007781")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private bool success;
    [Token(Token = "0x4007782")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private PlayerUnitCustomSkillType player_custom_skill;
    [Token(Token = "0x4007783")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private List<PlayerEquipmentSkillEnhanceItemType> updated_equipment_skill_enhance_items;

    [Token(Token = "0x17001E7C")]
    public NoticeData Notice
    {
      [Token(Token = "0x600A405"), Address(RVA = "0x46D0EA0", Offset = "0x46D0EA0", VA = "0x46D0EA0", Slot = "6")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x17001E7D")]
    public UpdatedPlayerDataSet UpdatedPlayerDataSet
    {
      [Token(Token = "0x600A406"), Address(RVA = "0x46D0EA8", Offset = "0x46D0EA8", VA = "0x46D0EA8", Slot = "4")] get
      {
        return (UpdatedPlayerDataSet) null;
      }
    }

    [Token(Token = "0x17001E7E")]
    public PlayerCoinType PlayerCoin
    {
      [Token(Token = "0x600A407"), Address(RVA = "0x46D0EB0", Offset = "0x46D0EB0", VA = "0x46D0EB0", Slot = "5")] get
      {
        return (PlayerCoinType) null;
      }
    }

    [Token(Token = "0x17001E7F")]
    public bool Success
    {
      [Token(Token = "0x600A408"), Address(RVA = "0x46D0EB8", Offset = "0x46D0EB8", VA = "0x46D0EB8")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001E80")]
    public PlayerUnitCustomSkillType PlayerCustomSkill
    {
      [Token(Token = "0x600A409"), Address(RVA = "0x46D0EC0", Offset = "0x46D0EC0", VA = "0x46D0EC0")] get
      {
        return (PlayerUnitCustomSkillType) null;
      }
    }

    [Token(Token = "0x17001E81")]
    public List<PlayerEquipmentSkillEnhanceItemType> UpdatedEquipmentSkillEnhanceItems
    {
      [Token(Token = "0x600A40A"), Address(RVA = "0x46D0EC8", Offset = "0x46D0EC8", VA = "0x46D0EC8")] get
      {
        return (List<PlayerEquipmentSkillEnhanceItemType>) null;
      }
    }

    [Token(Token = "0x600A40B")]
    [Address(RVA = "0x46D0ED0", Offset = "0x46D0ED0", VA = "0x46D0ED0")]
    public APICustomSkillEnhanceResponse()
    {
    }
  }
}
