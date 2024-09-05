// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.RarityStyleData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20013A3")]
  [Serializable]
  public sealed class RarityStyleData : IMasterDataEntity
  {
    [Token(Token = "0x4005B8A")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005B8B")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int rarityStar;
    [Token(Token = "0x4005B8C")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string rarityStarKey;
    [Token(Token = "0x4005B8D")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int rarityStarType;
    [Token(Token = "0x4005B8E")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int styleLevelMax;
    [Token(Token = "0x4005B8F")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public bool flgAccessory;
    [Token(Token = "0x4005B90")]
    [FieldOffset(Offset = "0x29")]
    [SerializeField]
    public bool flgEquipmentTrust;
    [Token(Token = "0x4005B91")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public int paramRate;
    [Token(Token = "0x4005B92")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public int customskillSlotNum;
    [Token(Token = "0x4005B93")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public int subWeaponSlotNum;
    [Token(Token = "0x4005B94")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public int styleSkillTypeID;

    [Token(Token = "0x17001093")]
    public int Key
    {
      [Token(Token = "0x6006E51"), Address(RVA = "0x470425C", Offset = "0x470425C", VA = "0x470425C", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006E52")]
    [Address(RVA = "0x4704264", Offset = "0x4704264", VA = "0x4704264", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006E53")]
    [Address(RVA = "0x47046D8", Offset = "0x47046D8", VA = "0x47046D8", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006E54")]
    [Address(RVA = "0x47047F0", Offset = "0x47047F0", VA = "0x47047F0")]
    public RarityStyleData()
    {
    }
  }
}
