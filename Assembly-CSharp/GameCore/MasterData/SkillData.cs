// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.SkillData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20011BD")]
  [Serializable]
  public sealed class SkillData : IMasterDataEntity
  {
    [Token(Token = "0x400555D")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x400555E")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public SkillTypeEnum skillType;
    [Token(Token = "0x400555F")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public SkillCategoryTypeEnum category;
    [Token(Token = "0x4005560")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public SkillKindTypeEnum kind;
    [Token(Token = "0x4005561")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public string iconName;
    [Token(Token = "0x4005562")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public string richDuelName;
    [Token(Token = "0x4005563")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public string simpleDuelName;
    [Token(Token = "0x4005564")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public string duelResourceName;
    [Token(Token = "0x4005565")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    public int skillExp;
    [Token(Token = "0x4005566")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    public bool overwriteElementAttribute;
    [Token(Token = "0x4005567")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    public ElementTypeEnum elementAttribute;
    [Token(Token = "0x4005568")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    public WeaponAttackTypeEnum weaponAttackType;
    [Token(Token = "0x4005569")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    public bool overwriteAttackType;
    [Token(Token = "0x400556A")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    public AttackTypeEnum attackType;
    [Token(Token = "0x400556B")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    public StratagemDirectionTypeEnum stratagemDirectionType;
    [Token(Token = "0x400556C")]
    [FieldOffset(Offset = "0x5C")]
    [SerializeField]
    public int stratagemMnemnographID;
    [Token(Token = "0x400556D")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    public string stratagemMnemnographEffectType;

    [Token(Token = "0x17000F53")]
    public int Key
    {
      [Token(Token = "0x6006591"), Address(RVA = "0x4D1CA74", Offset = "0x4D1CA74", VA = "0x4D1CA74", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006592")]
    [Address(RVA = "0x4D1CA7C", Offset = "0x4D1CA7C", VA = "0x4D1CA7C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006593")]
    [Address(RVA = "0x4D1D130", Offset = "0x4D1D130", VA = "0x4D1D130", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000F54")]
    public string Name
    {
      [Token(Token = "0x6006594"), Address(RVA = "0x4D1D2B8", Offset = "0x4D1D2B8", VA = "0x4D1D2B8")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6006595")]
    [Address(RVA = "0x4D1D394", Offset = "0x4D1D394", VA = "0x4D1D394")]
    public SkillData()
    {
    }
  }
}
