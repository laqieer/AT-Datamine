// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryBattleMissionRewardDescriptionData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E69")]
  [Serializable]
  public sealed class StoryBattleMissionRewardDescriptionData : IMasterDataEntity
  {
    [Token(Token = "0x40045AF")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40045B0")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int rewardGroupId;
    [Token(Token = "0x40045B1")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public RewardTypeEnum rewardType;
    [Token(Token = "0x40045B2")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int rewardID;
    [Token(Token = "0x40045B3")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int amount;

    [Token(Token = "0x17000CF4")]
    public int Key
    {
      [Token(Token = "0x60057D2"), Address(RVA = "0x3E43E68", Offset = "0x3E43E68", VA = "0x3E43E68", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60057D3")]
    [Address(RVA = "0x3E43E70", Offset = "0x3E43E70", VA = "0x3E43E70", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60057D4")]
    [Address(RVA = "0x3E4409C", Offset = "0x3E4409C", VA = "0x3E4409C", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x60057D5")]
    [Address(RVA = "0x3E44150", Offset = "0x3E44150", VA = "0x3E44150")]
    public StoryBattleMissionRewardDescriptionData()
    {
    }
  }
}
