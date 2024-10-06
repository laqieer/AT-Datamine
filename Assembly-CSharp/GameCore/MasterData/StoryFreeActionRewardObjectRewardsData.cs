// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFreeActionRewardObjectRewardsData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200127A")]
  [Serializable]
  public sealed class StoryFreeActionRewardObjectRewardsData : IMasterDataEntity
  {
    [Token(Token = "0x4005849")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x400584A")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int lootLabel;
    [Token(Token = "0x400584B")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int rewardType;
    [Token(Token = "0x400584C")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int rewardID;
    [Token(Token = "0x400584D")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int rewardQuantity;

    [Token(Token = "0x17000FE8")]
    public int Key
    {
      [Token(Token = "0x600690D"), Address(RVA = "0x48CBE64", Offset = "0x48CBE64", VA = "0x48CBE64", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600690E")]
    [Address(RVA = "0x48CBE6C", Offset = "0x48CBE6C", VA = "0x48CBE6C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x600690F")]
    [Address(RVA = "0x48CC098", Offset = "0x48CC098", VA = "0x48CC098", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006910")]
    [Address(RVA = "0x48CC14C", Offset = "0x48CC14C", VA = "0x48CC14C")]
    public StoryFreeActionRewardObjectRewardsData()
    {
    }
  }
}
