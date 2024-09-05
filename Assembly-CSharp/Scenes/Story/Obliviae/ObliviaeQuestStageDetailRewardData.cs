// Decompiled with JetBrains decompiler
// Type: Scenes.Story.Obliviae.ObliviaeQuestStageDetailRewardData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using StaqData;

#nullable disable
namespace Scenes.Story.Obliviae
{
  [Token(Token = "0x2002E6B")]
  public class ObliviaeQuestStageDetailRewardData
  {
    [Token(Token = "0x17003DA2")]
    public ItemUtility.Parameter RewardData
    {
      [Token(Token = "0x6012237"), Address(RVA = "0x458D4DC", Offset = "0x458D4DC", VA = "0x458D4DC")] get
      {
        return new ItemUtility.Parameter();
      }
      [Token(Token = "0x6012238"), Address(RVA = "0x458D4EC", Offset = "0x458D4EC", VA = "0x458D4EC")] private set
      {
      }
    }

    [Token(Token = "0x17003DA3")]
    public int Count
    {
      [Token(Token = "0x6012239"), Address(RVA = "0x458D504", Offset = "0x458D504", VA = "0x458D504")] get
      {
        return new int();
      }
      [Token(Token = "0x601223A"), Address(RVA = "0x458D50C", Offset = "0x458D50C", VA = "0x458D50C")] private set
      {
      }
    }

    [Token(Token = "0x17003DA4")]
    public RewardTypeEnum RewardType
    {
      [Token(Token = "0x601223B"), Address(RVA = "0x458D514", Offset = "0x458D514", VA = "0x458D514")] get
      {
        return new RewardTypeEnum();
      }
      [Token(Token = "0x601223C"), Address(RVA = "0x458D51C", Offset = "0x458D51C", VA = "0x458D51C")] private set
      {
      }
    }

    [Token(Token = "0x17003DA5")]
    public int RewardId
    {
      [Token(Token = "0x601223D"), Address(RVA = "0x458D524", Offset = "0x458D524", VA = "0x458D524")] get
      {
        return new int();
      }
      [Token(Token = "0x601223E"), Address(RVA = "0x458D52C", Offset = "0x458D52C", VA = "0x458D52C")] private set
      {
      }
    }

    [Token(Token = "0x601223F")]
    [Address(RVA = "0x458D534", Offset = "0x458D534", VA = "0x458D534")]
    public bool ExistReward() => new bool();

    [Token(Token = "0x6012240")]
    [Address(RVA = "0x458CB1C", Offset = "0x458CB1C", VA = "0x458CB1C")]
    public ObliviaeQuestStageDetailRewardData(
      RewardTypeEnum rewardType,
      int rewardId,
      ItemUtility.Parameter rewardData,
      int count)
    {
    }
  }
}
