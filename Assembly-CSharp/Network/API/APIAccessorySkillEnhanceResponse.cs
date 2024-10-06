// Decompiled with JetBrains decompiler
// Type: Network.API.APIAccessorySkillEnhanceResponse
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
  [Token(Token = "0x2001B4C")]
  [Serializable]
  public class APIAccessorySkillEnhanceResponse
  {
    [Token(Token = "0x4007511")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private bool success;
    [Token(Token = "0x4007512")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private PlayerGearAccessoryType player_accessory;
    [Token(Token = "0x4007513")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private List<PlayerEquipmentSkillEnhanceItemType> updated_equipment_skill_enhance_items;

    [Token(Token = "0x17001D2D")]
    public bool Success
    {
      [Token(Token = "0x600A046"), Address(RVA = "0x46C3CE4", Offset = "0x46C3CE4", VA = "0x46C3CE4")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001D2E")]
    public PlayerGearAccessoryType PlayerAccessory
    {
      [Token(Token = "0x600A047"), Address(RVA = "0x46C3CEC", Offset = "0x46C3CEC", VA = "0x46C3CEC")] get
      {
        return (PlayerGearAccessoryType) null;
      }
    }

    [Token(Token = "0x17001D2F")]
    public List<PlayerEquipmentSkillEnhanceItemType> UpdatedEquipmentSkillEnhanceItems
    {
      [Token(Token = "0x600A048"), Address(RVA = "0x46C3CF4", Offset = "0x46C3CF4", VA = "0x46C3CF4")] get
      {
        return (List<PlayerEquipmentSkillEnhanceItemType>) null;
      }
    }

    [Token(Token = "0x600A049")]
    [Address(RVA = "0x46C3CFC", Offset = "0x46C3CFC", VA = "0x46C3CFC")]
    public APIAccessorySkillEnhanceResponse()
    {
    }
  }
}
