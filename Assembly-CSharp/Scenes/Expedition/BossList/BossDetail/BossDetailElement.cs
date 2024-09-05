// Decompiled with JetBrains decompiler
// Type: Scenes.Expedition.BossList.BossDetail.BossDetailElement
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UI.ItemDetail;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Expedition.BossList.BossDetail
{
  [Token(Token = "0x2002D30")]
  public class BossDetailElement : InfiniteCellBase
  {
    [Token(Token = "0x400C1CF")]
    private const int MAX_LINE_REWARD = 8;
    [Token(Token = "0x400C1D0")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text Txt_Stage_Value;
    [Token(Token = "0x400C1D1")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private RewardHeader RewardHeader;
    [Token(Token = "0x400C1D2")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private RewardHorizontal HorizontalSet;
    [Token(Token = "0x400C1D3")]
    [FieldOffset(Offset = "0x40")]
    private Vector2 initSizeDelta;
    [Token(Token = "0x400C1D4")]
    [FieldOffset(Offset = "0x48")]
    private List<RewardHeader> rewardHeaderList;
    [Token(Token = "0x400C1D5")]
    [FieldOffset(Offset = "0x50")]
    private List<RewardHorizontal> rewardHorizontalList;

    [Token(Token = "0x6011ACD")]
    [Address(RVA = "0x42AE0C0", Offset = "0x42AE0C0", VA = "0x42AE0C0")]
    private void Awake()
    {
    }

    [Token(Token = "0x6011ACE")]
    [Address(RVA = "0x42AE2C0", Offset = "0x42AE2C0", VA = "0x42AE2C0")]
    public Vector2 CalcSize(int rewardCount) => new Vector2();

    [Token(Token = "0x6011ACF")]
    [Address(RVA = "0x42AE69C", Offset = "0x42AE69C", VA = "0x42AE69C", Slot = "4")]
    public override void OnUpdate()
    {
    }

    [Token(Token = "0x6011AD0")]
    [Address(RVA = "0x42AE754", Offset = "0x42AE754", VA = "0x42AE754")]
    public void Initialize(
      ExpeditionStageData stage,
      int stageCount,
      ExpeditionBossDescriptionData bossDescriptionData,
      bool isLock,
      ItemDetailPopupProvider itemDetailPopupGenerator)
    {
    }

    [Token(Token = "0x6011AD1")]
    [Address(RVA = "0x42AEEBC", Offset = "0x42AEEBC", VA = "0x42AEEBC")]
    public void InitTrans()
    {
    }

    [Token(Token = "0x6011AD2")]
    [Address(RVA = "0x42AEF28", Offset = "0x42AEF28", VA = "0x42AEF28")]
    private void ClearList()
    {
    }

    [Token(Token = "0x6011AD3")]
    [Address(RVA = "0x42AF240", Offset = "0x42AF240", VA = "0x42AF240")]
    private void AddHeader(string title)
    {
    }

    [Token(Token = "0x6011AD4")]
    [Address(RVA = "0x42AF3F8", Offset = "0x42AF3F8", VA = "0x42AF3F8")]
    private void AddHorizontal(
      List<ExpeditionBossRareRewardData> rewardList,
      int index,
      ItemDetailPopupProvider itemDetailPopupGenerator)
    {
    }

    [Token(Token = "0x6011AD5")]
    [Address(RVA = "0x42AF598", Offset = "0x42AF598", VA = "0x42AF598")]
    private void AddHorizontal(Action<RewardHorizontal> initCallback)
    {
    }

    [Token(Token = "0x6011AD6")]
    [Address(RVA = "0x42AF4F0", Offset = "0x42AF4F0", VA = "0x42AF4F0")]
    private void AddSizeDeltaY(float y)
    {
    }

    [Token(Token = "0x6011AD7")]
    [Address(RVA = "0x42AF748", Offset = "0x42AF748", VA = "0x42AF748")]
    public BossDetailElement()
    {
    }

    [Token(Token = "0x2002D31")]
    public class Parameter
    {
      [Token(Token = "0x400C1D6")]
      [FieldOffset(Offset = "0x10")]
      public ExpeditionStageData stage;
      [Token(Token = "0x400C1D7")]
      [FieldOffset(Offset = "0x18")]
      public int stageCount;
      [Token(Token = "0x400C1D8")]
      [FieldOffset(Offset = "0x20")]
      public ExpeditionBossDescriptionData bossDescriptionData;
      [Token(Token = "0x400C1D9")]
      [FieldOffset(Offset = "0x28")]
      public bool isLock;
      [Token(Token = "0x400C1DA")]
      [FieldOffset(Offset = "0x30")]
      public ItemDetailPopupProvider itemDetailPopupGenerator;

      [Token(Token = "0x6011ADA")]
      [Address(RVA = "0x42AF750", Offset = "0x42AF750", VA = "0x42AF750")]
      public Parameter()
      {
      }
    }
  }
}
