// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Battle.ResultQuestMissionView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Input;
using GameCore.MasterData;
using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UI.Direction;
using UI.ItemDetail;
using UnityEngine;
using UnityEngine.Playables;

#nullable disable
namespace Scenes.OutGame.Battle
{
  [Token(Token = "0x2003773")]
  public class ResultQuestMissionView : ResultViewBase
  {
    [Token(Token = "0x400F228")]
    [FieldOffset(Offset = "0x28")]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x400F229")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private UITimelineController timeLineController;
    [Token(Token = "0x400F22A")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private PlayableDirector timeLinePlayableDirector;
    [Token(Token = "0x400F22B")]
    [FieldOffset(Offset = "0x40")]
    public float MissonClearItemProductionStartWait;
    [Token(Token = "0x400F22C")]
    [FieldOffset(Offset = "0x44")]
    public float AllClearItemProductionStartWait;
    [Token(Token = "0x400F22D")]
    [FieldOffset(Offset = "0x48")]
    public float ItemClearEffectStartInterval;
    [Token(Token = "0x400F22E")]
    [FieldOffset(Offset = "0x4C")]
    public float ItemClearMarkwaittime;
    [Token(Token = "0x400F22F")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private GameObject[] titleList;
    [Token(Token = "0x400F230")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private CommonButton nextButton;
    [Token(Token = "0x400F231")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private Transform scrollContent;
    [Token(Token = "0x400F232")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private GameObject firstClearGroup;
    [Token(Token = "0x400F233")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private MissionFirstClearCell firstCellItem;
    [Token(Token = "0x400F234")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private GameObject subItemTitle;
    [Token(Token = "0x400F235")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private MissionSubCell subCellItem;
    [Token(Token = "0x400F236")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private GameObject missionTitlePrefab;
    [Token(Token = "0x400F237")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private QuestMissionCell questMissionCellItem;
    [Token(Token = "0x400F238")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private BackKeyHandlerComponent backKeyHandlerComponent;
    [Token(Token = "0x400F239")]
    [FieldOffset(Offset = "0xA0")]
    private List<string> itemThumbList;
    [Token(Token = "0x400F23A")]
    [FieldOffset(Offset = "0xA8")]
    private List<ResultQuestMissionView.stDirectObjeList> directObjeList;
    [Token(Token = "0x400F23B")]
    [FieldOffset(Offset = "0xB0")]
    private (int masterId, bool isClear, bool playAnimation)[] missionData;
    [Token(Token = "0x400F23C")]
    [FieldOffset(Offset = "0xB8")]
    private (int masterId, bool isClear, bool playAnimation)[] subMissionData;
    [Token(Token = "0x400F23D")]
    [FieldOffset(Offset = "0xC0")]
    private ItemDetailPopupProvider itemDetailPopupGenerator;

    [Token(Token = "0x6015D86")]
    [Address(RVA = "0x1B25AF0", Offset = "0x1B25AF0", VA = "0x1B25AF0")]
    public void Initialize(
      BattleResultSubScene subScene,
      AssetCachedSpawner assetCachedSpawner,
      (int masterId, bool isClear, bool playAnimation)[] _missionData,
      (int masterId, bool isClear, bool playAnimation)[] _subMissionData,
      BattleResultSubScene.Parameter parameter)
    {
    }

    [Token(Token = "0x6015D87")]
    [Address(RVA = "0x1B34848", Offset = "0x1B34848", VA = "0x1B34848")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6015D88")]
    [Address(RVA = "0x1B34760", Offset = "0x1B34760", VA = "0x1B34760")]
    private IEnumerator PlayTimeline(UITimelineController.DirectionType type, Action finishAction = null)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6015D89")]
    [Address(RVA = "0x1B34A08", Offset = "0x1B34A08", VA = "0x1B34A08", Slot = "7")]
    public override void Skip()
    {
    }

    [Token(Token = "0x6015D8A")]
    [Address(RVA = "0x1B347E0", Offset = "0x1B347E0", VA = "0x1B347E0")]
    private IEnumerator ExecutePlay() => (IEnumerator) null;

    [Token(Token = "0x6015D8B")]
    [Address(RVA = "0x1B34A38", Offset = "0x1B34A38", VA = "0x1B34A38")]
    private IEnumerator scrollCtrl() => (IEnumerator) null;

    [Token(Token = "0x6015D8C")]
    [Address(RVA = "0x1B34AC8", Offset = "0x1B34AC8", VA = "0x1B34AC8")]
    private void OpenItemDetail(RewardTypeEnum type, int id)
    {
    }

    [Token(Token = "0x6015D8D")]
    [Address(RVA = "0x1B346C8", Offset = "0x1B346C8", VA = "0x1B346C8")]
    private int GetMissionResultTitleIndex(
      (int masterId, bool isClear, bool playAnimation)[] questMission,
      (int masterId, bool isClear, bool playAnimation)[] subMission)
    {
      return new int();
    }

    [Token(Token = "0x6015D8E")]
    [Address(RVA = "0x1B34ADC", Offset = "0x1B34ADC", VA = "0x1B34ADC")]
    public ResultQuestMissionView()
    {
    }

    [Token(Token = "0x2003774")]
    private enum eClearState
    {
      [Token(Token = "0x400F23F")] QuestMission,
      [Token(Token = "0x400F240")] MissionClear,
      [Token(Token = "0x400F241")] AllClear,
      [Token(Token = "0x400F242")] MAX,
    }

    [Token(Token = "0x2003775")]
    private struct stDirectObjeList
    {
      [Token(Token = "0x400F243")]
      [FieldOffset(Offset = "0x0")]
      public GameObject obj;
      [Token(Token = "0x400F244")]
      [FieldOffset(Offset = "0x8")]
      public float time;

      [Token(Token = "0x6015D8F")]
      [Address(RVA = "0x1B346BC", Offset = "0x1B346BC", VA = "0x1B346BC")]
      public stDirectObjeList(GameObject Obj, float directTime)
      {
      }
    }
  }
}
