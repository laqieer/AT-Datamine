// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.EquipmentClassificationData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E8C")]
  [Serializable]
  public sealed class EquipmentClassificationData : IMasterDataEntity
  {
    [Token(Token = "0x4004662")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004663")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x4004664")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public WeaponTypeEnum weaponType;
    [Token(Token = "0x4004665")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public AttackTypeEnum attackType;
    [Token(Token = "0x4004666")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int nearRange;
    [Token(Token = "0x4004667")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public int farRange;
    [Token(Token = "0x4004668")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public int normalAttackSkill;
    [Token(Token = "0x4004669")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public int defaultWeaponID;
    [Token(Token = "0x400466A")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public int brokenWeaponID;
    [Token(Token = "0x400466B")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    public string duelEquipmentClassificationName;
    [Token(Token = "0x400466C")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    public string fieldEquipmentClassificationName;
    [Token(Token = "0x400466D")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    public string backDotName;
    [Token(Token = "0x400466E")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    public string frontDotName;
    [Token(Token = "0x400466F")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    public int weaponSystemIconID;
    [Token(Token = "0x4004670")]
    [FieldOffset(Offset = "0x0")]
    public static readonly EquipmentClassificationData.EquipmentClassificationDataIDS[] DisplayOrder;

    [Token(Token = "0x17000D28")]
    public int Key
    {
      [Token(Token = "0x600588C"), Address(RVA = "0x3C2B7C4", Offset = "0x3C2B7C4", VA = "0x3C2B7C4", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600588D")]
    [Address(RVA = "0x3C2B7CC", Offset = "0x3C2B7CC", VA = "0x3C2B7CC", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x600588E")]
    [Address(RVA = "0x3C2BD58", Offset = "0x3C2BD58", VA = "0x3C2BD58", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000D29")]
    public string Name
    {
      [Token(Token = "0x600588F"), Address(RVA = "0x3C2BEB0", Offset = "0x3C2BEB0", VA = "0x3C2BEB0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6005890")]
    [Address(RVA = "0x3C2C19C", Offset = "0x3C2C19C", VA = "0x3C2C19C")]
    public EquipmentClassificationData()
    {
    }

    [Token(Token = "0x6005891")]
    [Address(RVA = "0x3C2C1A4", Offset = "0x3C2C1A4", VA = "0x3C2C1A4")]
    static EquipmentClassificationData()
    {
    }

    [Token(Token = "0x2000E8D")]
    public enum EquipmentClassificationDataIDS
    {
      [Token(Token = "0x4004672")] SHORT_SWORD = 1,
      [Token(Token = "0x4004673")] ONE_HANDED_SWORD = 2,
      [Token(Token = "0x4004674")] ONE_BIG_SWORD = 3,
      [Token(Token = "0x4004675")] ONE_HANDED_AXE = 4,
      [Token(Token = "0x4004676")] BIG_AXE = 5,
      [Token(Token = "0x4004677")] BIG_HAMMER = 6,
      [Token(Token = "0x4004678")] SPEAR = 7,
      [Token(Token = "0x4004679")] LANCE = 8,
      [Token(Token = "0x400467A")] BOW = 9,
      [Token(Token = "0x400467B")] BOWGUN = 10, // 0x0000000A
      [Token(Token = "0x400467C")] HANDGUN = 11, // 0x0000000B
      [Token(Token = "0x400467D")] RIFLE = 12, // 0x0000000C
      [Token(Token = "0x400467E")] GRIMOIRE = 13, // 0x0000000D
      [Token(Token = "0x400467F")] CANE = 14, // 0x0000000E
      [Token(Token = "0x4004680")] KATANA = 22, // 0x00000016
      [Token(Token = "0x4004681")] MARTIAL_ARTS = 23, // 0x00000017
      [Token(Token = "0x4004682")] TWIN_HANDGUN = 24, // 0x00000018
    }
  }
}
