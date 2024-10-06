// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StorySubquestRewardSetData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200130F")]
  [Serializable]
  public sealed class StorySubquestRewardSetData : IMasterDataEntity
  {
    [Token(Token = "0x4005A23")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005A24")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int rewardSetLabel;
    [Token(Token = "0x4005A25")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int rewardType;
    [Token(Token = "0x4005A26")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int rewardID;
    [Token(Token = "0x4005A27")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int rewardQuantity;

    [Token(Token = "0x17001044")]
    public int Key
    {
      [Token(Token = "0x6006BA6"), Address(RVA = "0x48E4090", Offset = "0x48E4090", VA = "0x48E4090", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006BA7")]
    [Address(RVA = "0x48E4098", Offset = "0x48E4098", VA = "0x48E4098", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006BA8")]
    [Address(RVA = "0x48E42C4", Offset = "0x48E42C4", VA = "0x48E42C4", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17001045")]
    public RewardTypeEnum RewardTypeEnum
    {
      [Token(Token = "0x6006BA9"), Address(RVA = "0x48E4378", Offset = "0x48E4378", VA = "0x48E4378")] get
      {
        return new RewardTypeEnum();
      }
    }

    [Token(Token = "0x17001046")]
    public string Name
    {
      [Token(Token = "0x6006BAA"), Address(RVA = "0x48E4380", Offset = "0x48E4380", VA = "0x48E4380")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6006BAB")]
    [Address(RVA = "0x48E43B0", Offset = "0x48E43B0", VA = "0x48E43B0")]
    public StorySubquestRewardSetData()
    {
    }
  }
}
