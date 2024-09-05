// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StorySubquestRewardPaymentData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200130D")]
  [Serializable]
  public sealed class StorySubquestRewardPaymentData : IMasterDataEntity
  {
    [Token(Token = "0x4005A17")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005A18")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int taskRewardPaymentLabel;
    [Token(Token = "0x4005A19")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int rewardType;
    [Token(Token = "0x4005A1A")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int rewardID;
    [Token(Token = "0x4005A1B")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int rewardQuantity;
    [Token(Token = "0x4005A1C")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int paymentType;
    [Token(Token = "0x4005A1D")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int paymentID;
    [Token(Token = "0x4005A1E")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public int paymentQuantity;

    [Token(Token = "0x1700103D")]
    public int Key
    {
      [Token(Token = "0x6006B91"), Address(RVA = "0x48E3790", Offset = "0x48E3790", VA = "0x48E3790", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006B92")]
    [Address(RVA = "0x48E3798", Offset = "0x48E3798", VA = "0x48E3798", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006B93")]
    [Address(RVA = "0x48E3AE4", Offset = "0x48E3AE4", VA = "0x48E3AE4", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x1700103E")]
    public RewardTypeEnum RewardTypeEnum
    {
      [Token(Token = "0x6006B94"), Address(RVA = "0x48E3BC8", Offset = "0x48E3BC8", VA = "0x48E3BC8")] get
      {
        return new RewardTypeEnum();
      }
    }

    [Token(Token = "0x1700103F")]
    public RewardTypeEnum PaymentTypeEnum
    {
      [Token(Token = "0x6006B95"), Address(RVA = "0x48E3BD0", Offset = "0x48E3BD0", VA = "0x48E3BD0")] get
      {
        return new RewardTypeEnum();
      }
    }

    [Token(Token = "0x17001040")]
    public StaqData.RewardData Reward
    {
      [Token(Token = "0x6006B96"), Address(RVA = "0x48E3BD8", Offset = "0x48E3BD8", VA = "0x48E3BD8")] get
      {
        return (StaqData.RewardData) null;
      }
      [Token(Token = "0x6006B97"), Address(RVA = "0x48E3BE0", Offset = "0x48E3BE0", VA = "0x48E3BE0")] private set
      {
      }
    }

    [Token(Token = "0x17001041")]
    public StaqData.RewardData Payment
    {
      [Token(Token = "0x6006B98"), Address(RVA = "0x48E3BE8", Offset = "0x48E3BE8", VA = "0x48E3BE8")] get
      {
        return (StaqData.RewardData) null;
      }
      [Token(Token = "0x6006B99"), Address(RVA = "0x48E3BF0", Offset = "0x48E3BF0", VA = "0x48E3BF0")] private set
      {
      }
    }

    [Token(Token = "0x6006B9A")]
    [Address(RVA = "0x48E30F8", Offset = "0x48E30F8", VA = "0x48E30F8")]
    public void OnLoad()
    {
    }

    [Token(Token = "0x17001042")]
    public ItemUtility.Parameter RewardItem
    {
      [Token(Token = "0x6006B9B"), Address(RVA = "0x48E3BF8", Offset = "0x48E3BF8", VA = "0x48E3BF8")] get
      {
        return new ItemUtility.Parameter();
      }
    }

    [Token(Token = "0x17001043")]
    public ItemUtility.Parameter PaymentItem
    {
      [Token(Token = "0x6006B9C"), Address(RVA = "0x48E3C38", Offset = "0x48E3C38", VA = "0x48E3C38")] get
      {
        return new ItemUtility.Parameter();
      }
    }

    [Token(Token = "0x6006B9D")]
    [Address(RVA = "0x48E3C78", Offset = "0x48E3C78", VA = "0x48E3C78")]
    public StorySubquestRewardPaymentData()
    {
    }
  }
}
