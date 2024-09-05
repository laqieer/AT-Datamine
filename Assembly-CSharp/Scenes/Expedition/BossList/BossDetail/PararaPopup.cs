// Decompiled with JetBrains decompiler
// Type: Scenes.Expedition.BossList.BossDetail.PararaPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using Il2CppDummyDll;
using Network.Param;
using StaqData;
using System.Collections;
using System.Collections.Generic;
using UI.Direction;
using UnityEngine;

#nullable disable
namespace Scenes.Expedition.BossList.BossDetail
{
  [Token(Token = "0x2002D3D")]
  public class PararaPopup : MonoBehaviour
  {
    [Token(Token = "0x400C1FF")]
    private const int MAX_UNIT = 5;
    [Token(Token = "0x400C200")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private CommonButton closeButton;
    [Token(Token = "0x400C201")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private UITimelineController timelineController;
    [Token(Token = "0x400C202")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private RectTransform Layout_PararaValueUnits_List;
    [Token(Token = "0x400C203")]
    [FieldOffset(Offset = "0x30")]
    private List<PararaUnit> pararaUnits;

    [Token(Token = "0x6011AFD")]
    [Address(RVA = "0x42B198C", Offset = "0x42B198C", VA = "0x42B198C")]
    private void Awake()
    {
    }

    [Token(Token = "0x6011AFE")]
    [Address(RVA = "0x42B1A00", Offset = "0x42B1A00", VA = "0x42B1A00")]
    public IEnumerator InitializeAsync(
      AssetCachedSpawner assetCachedSpawner,
      int stageId,
      ExpeditionBossDescriptionData bossData,
      Style[] style = null)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6011AFF")]
    [Address(RVA = "0x42B1ABC", Offset = "0x42B1ABC", VA = "0x42B1ABC")]
    public void Close()
    {
    }

    [Token(Token = "0x6011B00")]
    [Address(RVA = "0x42B1B4C", Offset = "0x42B1B4C", VA = "0x42B1B4C")]
    private PlayerExpeditionStageType GetPlayerExpeditionStage(int stageId)
    {
      return (PlayerExpeditionStageType) null;
    }

    [Token(Token = "0x6011B01")]
    [Address(RVA = "0x42B1C38", Offset = "0x42B1C38", VA = "0x42B1C38")]
    public PararaPopup()
    {
    }
  }
}
