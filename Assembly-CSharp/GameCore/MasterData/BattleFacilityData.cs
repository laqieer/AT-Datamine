// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleFacilityData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E61")]
  [Serializable]
  public sealed class BattleFacilityData : IMasterDataEntity
  {
    [Token(Token = "0x400458E")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x400458F")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x4004590")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public BattleFacilityTypeEnum facilityType;
    [Token(Token = "0x4004591")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int controlType;
    [Token(Token = "0x4004592")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int switchType;
    [Token(Token = "0x4004593")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public bool controllableWalk;
    [Token(Token = "0x4004594")]
    [FieldOffset(Offset = "0x2D")]
    [SerializeField]
    public bool controllableFly;
    [Token(Token = "0x4004595")]
    [FieldOffset(Offset = "0x2E")]
    [SerializeField]
    public bool controllableRide;
    [Token(Token = "0x4004596")]
    [FieldOffset(Offset = "0x2F")]
    [SerializeField]
    public bool controllableFloating;
    [Token(Token = "0x4004597")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public int landformOff;
    [Token(Token = "0x4004598")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public int landformOn;
    [Token(Token = "0x4004599")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public int skillId;
    [Token(Token = "0x400459A")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    public int skillLv;
    [Token(Token = "0x400459B")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    public int resourceId;

    [Token(Token = "0x17000CF1")]
    public int Key
    {
      [Token(Token = "0x60057AA"), Address(RVA = "0x3E422B4", Offset = "0x3E422B4", VA = "0x3E422B4", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60057AB")]
    [Address(RVA = "0x3E422BC", Offset = "0x3E422BC", VA = "0x3E422BC", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60057AC")]
    [Address(RVA = "0x3E42858", Offset = "0x3E42858", VA = "0x3E42858", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x60057AD")]
    [Address(RVA = "0x3E429A0", Offset = "0x3E429A0", VA = "0x3E429A0")]
    public BattleFacilityData()
    {
    }
  }
}
