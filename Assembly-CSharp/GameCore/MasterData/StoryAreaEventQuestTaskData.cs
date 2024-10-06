// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryAreaEventQuestTaskData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20011E4")]
  [Serializable]
  public sealed class StoryAreaEventQuestTaskData : IMasterDataEntity
  {
    [Token(Token = "0x40055CF")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40055D0")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x40055D1")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int areaeventquestID;
    [Token(Token = "0x40055D2")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int taskFlagID;
    [Token(Token = "0x40055D3")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int taskFlagCheck;
    [Token(Token = "0x40055D4")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public int taskType;
    [Token(Token = "0x40055D5")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public int advID;
    [Token(Token = "0x40055D6")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public bool isResearchStaging;
    [Token(Token = "0x40055D7")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public int taskRewardPaymentLabel;
    [Token(Token = "0x40055D8")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    public int objectID;
    [Token(Token = "0x40055D9")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    public int progressText;
    [Token(Token = "0x40055DA")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    public int cameraMovePosition;
    [Token(Token = "0x40055DB")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    public int playerMovePosition;
    [Token(Token = "0x40055DC")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    public EventNpcActEnum beginNpcAct;
    [Token(Token = "0x40055DD")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    public int iconType;
    [Token(Token = "0x40055DE")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    public float iconPositionX;
    [Token(Token = "0x40055DF")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    public float iconPositionY;
    [Token(Token = "0x40055E0")]
    [FieldOffset(Offset = "0x5C")]
    [SerializeField]
    public float iconPositionZ;
    [Token(Token = "0x40055E1")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    public bool isFreeMapEnd;

    [Token(Token = "0x17000F6D")]
    public int Key
    {
      [Token(Token = "0x6006642"), Address(RVA = "0x4D23808", Offset = "0x4D23808", VA = "0x4D23808", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006643")]
    [Address(RVA = "0x4D23810", Offset = "0x4D23810", VA = "0x4D23810", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006644")]
    [Address(RVA = "0x4D23F84", Offset = "0x4D23F84", VA = "0x4D23F84", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006645")]
    [Address(RVA = "0x4D2411C", Offset = "0x4D2411C", VA = "0x4D2411C")]
    public StoryAreaEventQuestRewardPaymentMaster.RewardData[] GetRewards()
    {
      return (StoryAreaEventQuestRewardPaymentMaster.RewardData[]) null;
    }

    [Token(Token = "0x6006646")]
    [Address(RVA = "0x4D241BC", Offset = "0x4D241BC", VA = "0x4D241BC")]
    public StoryAreaEventQuestRewardPaymentMaster.PaymentData[] GetPayments()
    {
      return (StoryAreaEventQuestRewardPaymentMaster.PaymentData[]) null;
    }

    [Token(Token = "0x6006647")]
    [Address(RVA = "0x4D2425C", Offset = "0x4D2425C", VA = "0x4D2425C")]
    public StoryAreaEventQuestTaskData()
    {
    }
  }
}
