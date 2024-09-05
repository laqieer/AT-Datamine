// Decompiled with JetBrains decompiler
// Type: Network.Param.UpdatedPlayerEquipments
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001B16")]
  [Serializable]
  public class UpdatedPlayerEquipments
  {
    [Token(Token = "0x4007465")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private List<PlayerGearWeaponType> new_weapons;
    [Token(Token = "0x4007466")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private List<PlayerGearMindEquipmentType> new_mind_equipments;
    [Token(Token = "0x4007467")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private List<PlayerGearAccessoryType> new_accessories;
    [Token(Token = "0x4007468")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private List<PlayerUnitCustomSkillType> new_custom_skills;
    [Token(Token = "0x4007469")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private List<MindEquipmentDuplicateInfoType> mind_equipment_duplicate_info;

    [Token(Token = "0x17001CC7")]
    public List<PlayerGearWeaponType> NewWeapons
    {
      [Token(Token = "0x6009F0F"), Address(RVA = "0x48F395C", Offset = "0x48F395C", VA = "0x48F395C")] get
      {
        return (List<PlayerGearWeaponType>) null;
      }
      [Token(Token = "0x6009F10"), Address(RVA = "0x48F3964", Offset = "0x48F3964", VA = "0x48F3964")] set
      {
      }
    }

    [Token(Token = "0x17001CC8")]
    public List<PlayerGearMindEquipmentType> NewMindEquipments
    {
      [Token(Token = "0x6009F11"), Address(RVA = "0x48F396C", Offset = "0x48F396C", VA = "0x48F396C")] get
      {
        return (List<PlayerGearMindEquipmentType>) null;
      }
      [Token(Token = "0x6009F12"), Address(RVA = "0x48F3974", Offset = "0x48F3974", VA = "0x48F3974")] set
      {
      }
    }

    [Token(Token = "0x17001CC9")]
    public List<PlayerGearAccessoryType> NewAccessories
    {
      [Token(Token = "0x6009F13"), Address(RVA = "0x48F397C", Offset = "0x48F397C", VA = "0x48F397C")] get
      {
        return (List<PlayerGearAccessoryType>) null;
      }
      [Token(Token = "0x6009F14"), Address(RVA = "0x48F3984", Offset = "0x48F3984", VA = "0x48F3984")] set
      {
      }
    }

    [Token(Token = "0x17001CCA")]
    public List<PlayerUnitCustomSkillType> NewCustomSkills
    {
      [Token(Token = "0x6009F15"), Address(RVA = "0x48F398C", Offset = "0x48F398C", VA = "0x48F398C")] get
      {
        return (List<PlayerUnitCustomSkillType>) null;
      }
      [Token(Token = "0x6009F16"), Address(RVA = "0x48F3994", Offset = "0x48F3994", VA = "0x48F3994")] set
      {
      }
    }

    [Token(Token = "0x17001CCB")]
    public List<MindEquipmentDuplicateInfoType> MindEquipmentDuplicateInfo
    {
      [Token(Token = "0x6009F17"), Address(RVA = "0x48F399C", Offset = "0x48F399C", VA = "0x48F399C")] get
      {
        return (List<MindEquipmentDuplicateInfoType>) null;
      }
      [Token(Token = "0x6009F18"), Address(RVA = "0x48F39A4", Offset = "0x48F39A4", VA = "0x48F39A4")] set
      {
      }
    }

    [Token(Token = "0x6009F19")]
    [Address(RVA = "0x48F39AC", Offset = "0x48F39AC", VA = "0x48F39AC")]
    public UpdatedPlayerEquipments()
    {
    }
  }
}
