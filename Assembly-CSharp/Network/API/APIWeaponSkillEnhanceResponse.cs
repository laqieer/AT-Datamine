// Decompiled with JetBrains decompiler
// Type: Network.API.APIWeaponSkillEnhanceResponse
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
  [Token(Token = "0x2001F08")]
  [Serializable]
  public class APIWeaponSkillEnhanceResponse
  {
    [Token(Token = "0x4008533")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private bool success;
    [Token(Token = "0x4008534")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private PlayerGearWeaponType player_weapon;
    [Token(Token = "0x4008535")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private List<PlayerEquipmentSkillEnhanceItemType> updated_equipment_skill_enhance_items;

    [Token(Token = "0x17002652")]
    public bool Success
    {
      [Token(Token = "0x600B85B"), Address(RVA = "0x2133F3C", Offset = "0x2133F3C", VA = "0x2133F3C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002653")]
    public PlayerGearWeaponType PlayerWeapon
    {
      [Token(Token = "0x600B85C"), Address(RVA = "0x2133F44", Offset = "0x2133F44", VA = "0x2133F44")] get
      {
        return (PlayerGearWeaponType) null;
      }
    }

    [Token(Token = "0x17002654")]
    public List<PlayerEquipmentSkillEnhanceItemType> UpdatedEquipmentSkillEnhanceItems
    {
      [Token(Token = "0x600B85D"), Address(RVA = "0x2133F4C", Offset = "0x2133F4C", VA = "0x2133F4C")] get
      {
        return (List<PlayerEquipmentSkillEnhanceItemType>) null;
      }
    }

    [Token(Token = "0x600B85E")]
    [Address(RVA = "0x2133F54", Offset = "0x2133F54", VA = "0x2133F54")]
    public APIWeaponSkillEnhanceResponse()
    {
    }
  }
}
