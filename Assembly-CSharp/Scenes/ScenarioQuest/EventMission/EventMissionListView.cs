// Decompiled with JetBrains decompiler
// Type: Scenes.ScenarioQuest.EventMission.EventMissionListView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UI.Direction;
using UI.ItemDetail;
using UnityEngine;

#nullable disable
namespace Scenes.ScenarioQuest.EventMission
{
  [Token(Token = "0x2002982")]
  public sealed class EventMissionListView : MonoBehaviour
  {
    [Token(Token = "0x400B0C5")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITimelineController timeLineController;
    [Token(Token = "0x400B0C6")]
    [FieldOffset(Offset = "0x20")]
    [Space(5f)]
    [Header("Cell Prefab")]
    [SerializeField]
    private GameObject missionCellData;
    [Token(Token = "0x400B0C7")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject lockCellData;
    [Token(Token = "0x400B0C8")]
    [FieldOffset(Offset = "0x30")]
    [Space(5f)]
    [Header("InfinityScroll")]
    [SerializeField]
    private EventMissionInfinityScroll infinityScrollView;
    [Token(Token = "0x400B0C9")]
    [FieldOffset(Offset = "0x38")]
    private AssetCachedSpawner _assetCachedSpawner;
    [Token(Token = "0x400B0CA")]
    [FieldOffset(Offset = "0x40")]
    private ItemDetailPopupProvider _popupGenerator;

    [Token(Token = "0x6010500")]
    [Address(RVA = "0x475CDD8", Offset = "0x475CDD8", VA = "0x475CDD8")]
    public void Initialize(List<MissionDataList> missionDataList)
    {
    }

    [Token(Token = "0x6010501")]
    [Address(RVA = "0x475CEFC", Offset = "0x475CEFC", VA = "0x475CEFC")]
    private IEnumerator LoadItemDetailPopupGenerator(ItemDetailPopupProvider generator)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6010502")]
    [Address(RVA = "0x475CF70", Offset = "0x475CF70", VA = "0x475CF70")]
    public void SetMissionListData(List<MissionDataList> missionDataList)
    {
    }

    [Token(Token = "0x6010503")]
    [Address(RVA = "0x475D38C", Offset = "0x475D38C", VA = "0x475D38C")]
    public EventMissionListView()
    {
    }
  }
}
