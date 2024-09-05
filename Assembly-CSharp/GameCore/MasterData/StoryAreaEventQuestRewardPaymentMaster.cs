// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryAreaEventQuestRewardPaymentMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20011D7")]
  [Serializable]
  public sealed class StoryAreaEventQuestRewardPaymentMaster : 
    BaseMaster<StoryAreaEventQuestRewardPaymentData>
  {
    [Token(Token = "0x600660C")]
    [Address(RVA = "0x4D21A58", Offset = "0x4D21A58", VA = "0x4D21A58")]
    public IReadOnlyDictionary<int, StoryAreaEventQuestRewardPaymentData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryAreaEventQuestRewardPaymentData>) null;
    }

    [Token(Token = "0x600660D")]
    [Address(RVA = "0x4D21A60", Offset = "0x4D21A60", VA = "0x4D21A60", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x600660E")]
    [Address(RVA = "0x4D21AC0", Offset = "0x4D21AC0", VA = "0x4D21AC0", Slot = "5")]
    protected override StoryAreaEventQuestRewardPaymentData LoadEntity(IMasterDataReader reader)
    {
      return (StoryAreaEventQuestRewardPaymentData) null;
    }

    [Token(Token = "0x600660F")]
    [Address(RVA = "0x4D21B18", Offset = "0x4D21B18", VA = "0x4D21B18")]
    public IEnumerable<StoryAreaEventQuestRewardPaymentData> GetList(int label)
    {
      return (IEnumerable<StoryAreaEventQuestRewardPaymentData>) null;
    }

    [Token(Token = "0x6006610")]
    [Address(RVA = "0x4D21C20", Offset = "0x4D21C20", VA = "0x4D21C20")]
    public IEnumerable<StoryAreaEventQuestRewardPaymentMaster.RewardData> Rewards(int label)
    {
      return (IEnumerable<StoryAreaEventQuestRewardPaymentMaster.RewardData>) null;
    }

    [Token(Token = "0x6006611")]
    [Address(RVA = "0x4D2208C", Offset = "0x4D2208C", VA = "0x4D2208C")]
    public IEnumerable<StoryAreaEventQuestRewardPaymentMaster.PaymentData> Payments(int label)
    {
      return (IEnumerable<StoryAreaEventQuestRewardPaymentMaster.PaymentData>) null;
    }

    [Token(Token = "0x6006612")]
    [Address(RVA = "0x4D224F8", Offset = "0x4D224F8", VA = "0x4D224F8")]
    public StoryAreaEventQuestRewardPaymentMaster()
    {
    }

    [Token(Token = "0x20011D8")]
    public struct RewardData
    {
      [Token(Token = "0x40055B7")]
      [FieldOffset(Offset = "0x0")]
      private StoryAreaEventQuestRewardPaymentData entity;

      [Token(Token = "0x17000F64")]
      public ItemUtility.Parameter Parameter
      {
        [Token(Token = "0x6006613"), Address(RVA = "0x4D22540", Offset = "0x4D22540", VA = "0x4D22540")] get
        {
          return new ItemUtility.Parameter();
        }
      }

      [Token(Token = "0x17000F65")]
      public int Quantity
      {
        [Token(Token = "0x6006614"), Address(RVA = "0x4D22588", Offset = "0x4D22588", VA = "0x4D22588")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x6006615")]
      [Address(RVA = "0x4D225A4", Offset = "0x4D225A4", VA = "0x4D225A4")]
      public RewardData(StoryAreaEventQuestRewardPaymentData entity)
      {
      }

      [Token(Token = "0x6006616")]
      [Address(RVA = "0x4D225AC", Offset = "0x4D225AC", VA = "0x4D225AC")]
      public StaqData.RewardData GetRewardData() => (StaqData.RewardData) null;
    }

    [Token(Token = "0x20011D9")]
    public struct PaymentData
    {
      [Token(Token = "0x40055B8")]
      [FieldOffset(Offset = "0x0")]
      private StoryAreaEventQuestRewardPaymentData entity;

      [Token(Token = "0x17000F66")]
      public ItemUtility.Parameter Parameter
      {
        [Token(Token = "0x6006617"), Address(RVA = "0x4D22630", Offset = "0x4D22630", VA = "0x4D22630")] get
        {
          return new ItemUtility.Parameter();
        }
      }

      [Token(Token = "0x17000F67")]
      public int Quantity
      {
        [Token(Token = "0x6006618"), Address(RVA = "0x4D22674", Offset = "0x4D22674", VA = "0x4D22674")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x6006619")]
      [Address(RVA = "0x4D22690", Offset = "0x4D22690", VA = "0x4D22690")]
      public PaymentData(StoryAreaEventQuestRewardPaymentData entity)
      {
      }
    }
  }
}
