// Decompiled with JetBrains decompiler
// Type: Scenes.Expedition.BossList.BossDetail.BossDetailElementList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;
using UI.ItemDetail;
using UnityEngine;

#nullable disable
namespace Scenes.Expedition.BossList.BossDetail
{
  [Token(Token = "0x2002D34")]
  public class BossDetailElementList : MonoBehaviour
  {
    [Token(Token = "0x400C1DF")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private BossDetailElement Container_Detail_Element;
    [Token(Token = "0x400C1E0")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private InfiniteScrollView infiniteScrollView;
    [Token(Token = "0x400C1E1")]
    [FieldOffset(Offset = "0x28")]
    private List<InfiniteCellData> parameters;

    [Token(Token = "0x6011ADD")]
    [Address(RVA = "0x42AF97C", Offset = "0x42AF97C", VA = "0x42AF97C")]
    private void Awake()
    {
    }

    [Token(Token = "0x6011ADE")]
    [Address(RVA = "0x42AF9A8", Offset = "0x42AF9A8", VA = "0x42AF9A8")]
    public void Initialize(
      int stageId,
      int challengeBossLevel,
      ItemDetailPopupProvider itemDetailPopupGenerator)
    {
    }

    [Token(Token = "0x6011ADF")]
    [Address(RVA = "0x42AFD24", Offset = "0x42AFD24", VA = "0x42AFD24")]
    private void ClearList()
    {
    }

    [Token(Token = "0x6011AE0")]
    [Address(RVA = "0x42B0044", Offset = "0x42B0044", VA = "0x42B0044")]
    private void AddElement(
      ExpeditionStageData stage,
      int stageCount,
      ExpeditionBossDescriptionData bossDescriptionData,
      bool isLock,
      ItemDetailPopupProvider itemDetailPopupGenerator)
    {
    }

    [Token(Token = "0x6011AE1")]
    [Address(RVA = "0x42AFD94", Offset = "0x42AFD94", VA = "0x42AFD94")]
    public static ExpeditionStageData GetExpeditionStageData(int stageId)
    {
      return (ExpeditionStageData) null;
    }

    [Token(Token = "0x6011AE2")]
    [Address(RVA = "0x42B0230", Offset = "0x42B0230", VA = "0x42B0230")]
    public static List<ExpeditionBossDescriptionData> GetExpeditionBossDescriptionDatas(int stageId)
    {
      return (List<ExpeditionBossDescriptionData>) null;
    }

    [Token(Token = "0x6011AE3")]
    [Address(RVA = "0x42AFE30", Offset = "0x42AFE30", VA = "0x42AFE30")]
    public static List<ExpeditionBossDescriptionData> GetExpeditionBossDescriptionDatas(
      ExpeditionStageData stageData)
    {
      return (List<ExpeditionBossDescriptionData>) null;
    }

    [Token(Token = "0x6011AE4")]
    [Address(RVA = "0x42B0248", Offset = "0x42B0248", VA = "0x42B0248")]
    public BossDetailElementList()
    {
    }
  }
}
