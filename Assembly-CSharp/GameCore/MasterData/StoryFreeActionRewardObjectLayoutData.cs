// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFreeActionRewardObjectLayoutData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001278")]
  [Serializable]
  public sealed class StoryFreeActionRewardObjectLayoutData : IMasterDataEntity
  {
    [Token(Token = "0x400583D")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x400583E")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int groupLabel;
    [Token(Token = "0x400583F")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int area;
    [Token(Token = "0x4005840")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public string anchorName;
    [Token(Token = "0x4005841")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public float rotationOfffset;
    [Token(Token = "0x4005842")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public float positionOffsetX;
    [Token(Token = "0x4005843")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public float positionOffsetY;
    [Token(Token = "0x4005844")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public float positionOffsetZ;
    [Token(Token = "0x4005845")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public int objectType;
    [Token(Token = "0x4005846")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    public int chest;
    [Token(Token = "0x4005847")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    public int breakableObject;

    [Token(Token = "0x17000FE5")]
    public int Key
    {
      [Token(Token = "0x6006901"), Address(RVA = "0x48CB7A8", Offset = "0x48CB7A8", VA = "0x48CB7A8", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006902")]
    [Address(RVA = "0x48CB7B0", Offset = "0x48CB7B0", VA = "0x48CB7B0", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006903")]
    [Address(RVA = "0x48CBC1C", Offset = "0x48CBC1C", VA = "0x48CBC1C", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000FE6")]
    public Vector3 PositionOffset
    {
      [Token(Token = "0x6006904"), Address(RVA = "0x48CBD34", Offset = "0x48CBD34", VA = "0x48CBD34")] get
      {
        return new Vector3();
      }
      [Token(Token = "0x6006905"), Address(RVA = "0x48CBD40", Offset = "0x48CBD40", VA = "0x48CBD40")] private set
      {
      }
    }

    [Token(Token = "0x17000FE7")]
    public RewardObjectTypeEnum RewardObjectType
    {
      [Token(Token = "0x6006906"), Address(RVA = "0x48CBD4C", Offset = "0x48CBD4C", VA = "0x48CBD4C")] get
      {
        return new RewardObjectTypeEnum();
      }
    }

    [Token(Token = "0x6006907")]
    [Address(RVA = "0x48CB3CC", Offset = "0x48CB3CC", VA = "0x48CB3CC")]
    public void OnLoad()
    {
    }

    [Token(Token = "0x6006908")]
    [Address(RVA = "0x48CBD54", Offset = "0x48CBD54", VA = "0x48CBD54")]
    public StoryFreeActionRewardObjectLayoutData()
    {
    }
  }
}
