// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryMainQuestSequenceRewardsPaymentsData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20012A6")]
  [Serializable]
  public sealed class StoryMainQuestSequenceRewardsPaymentsData : IMasterDataEntity
  {
    [Token(Token = "0x40058DE")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40058DF")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int sequenceId;
    [Token(Token = "0x40058E0")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int rewardType;
    [Token(Token = "0x40058E1")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int rewardId;
    [Token(Token = "0x40058E2")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int rewardNum;

    [Token(Token = "0x17000FFC")]
    public int Key
    {
      [Token(Token = "0x60069DF"), Address(RVA = "0x48D3DA8", Offset = "0x48D3DA8", VA = "0x48D3DA8", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60069E0")]
    [Address(RVA = "0x48D3DB0", Offset = "0x48D3DB0", VA = "0x48D3DB0", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60069E1")]
    [Address(RVA = "0x48D3FDC", Offset = "0x48D3FDC", VA = "0x48D3FDC", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x60069E2")]
    [Address(RVA = "0x48D4090", Offset = "0x48D4090", VA = "0x48D4090")]
    public StoryMainQuestSequenceRewardsPaymentsData()
    {
    }
  }
}
