// Decompiled with JetBrains decompiler
// Type: Network.API.APIUnitTrustSkillEnhanceResponse
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
  [Token(Token = "0x2001EDC")]
  [Serializable]
  public class APIUnitTrustSkillEnhanceResponse
  {
    [Token(Token = "0x4008487")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private bool success;
    [Token(Token = "0x4008488")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private PlayerGearUnitTrustType player_unit_trust;
    [Token(Token = "0x4008489")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private List<PlayerEquipmentSkillEnhanceItemType> updated_equipment_skill_enhance_items;

    [Token(Token = "0x170025EF")]
    public bool Success
    {
      [Token(Token = "0x600B748"), Address(RVA = "0x21303F0", Offset = "0x21303F0", VA = "0x21303F0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170025F0")]
    public PlayerGearUnitTrustType PlayerUnitTrust
    {
      [Token(Token = "0x600B749"), Address(RVA = "0x21303F8", Offset = "0x21303F8", VA = "0x21303F8")] get
      {
        return (PlayerGearUnitTrustType) null;
      }
    }

    [Token(Token = "0x170025F1")]
    public List<PlayerEquipmentSkillEnhanceItemType> UpdatedEquipmentSkillEnhanceItems
    {
      [Token(Token = "0x600B74A"), Address(RVA = "0x2130400", Offset = "0x2130400", VA = "0x2130400")] get
      {
        return (List<PlayerEquipmentSkillEnhanceItemType>) null;
      }
    }

    [Token(Token = "0x600B74B")]
    [Address(RVA = "0x2130408", Offset = "0x2130408", VA = "0x2130408")]
    public APIUnitTrustSkillEnhanceResponse()
    {
    }
  }
}
