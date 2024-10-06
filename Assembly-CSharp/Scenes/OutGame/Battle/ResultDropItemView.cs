// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Battle.ResultDropItemView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Input;
using GameCore.MasterData;
using Il2CppDummyDll;
using Scenes.OutGame.Battle.ResultCommon;
using Scenes.OutGame.Battle.ResultItem;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UI.Direction;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace Scenes.OutGame.Battle
{
  [Token(Token = "0x200376D")]
  public class ResultDropItemView : ResultViewBase
  {
    [Token(Token = "0x400F207")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private UITimelineController timeLineController;
    [Token(Token = "0x400F208")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private MissionClearMarks missionClearMarks;
    [Token(Token = "0x400F209")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private BattleResultQuestTitle questTitle;
    [Token(Token = "0x400F20A")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private GameObject zenyTop;
    [Token(Token = "0x400F20B")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private TextMeshProUGUI zenyText;
    [Token(Token = "0x400F20C")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private BattleResultItemList _dropItemList;
    [Token(Token = "0x400F20D")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private CommonButton[] buttonsNext;
    [Token(Token = "0x400F20E")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private BackKeyHandlerComponent backKeyHandlerComponent;
    [Token(Token = "0x400F210")]
    [FieldOffset(Offset = "0x70")]
    private bool isInitialized;
    [Token(Token = "0x400F211")]
    [FieldOffset(Offset = "0x71")]
    private bool inDirect;
    [Token(Token = "0x400F212")]
    [FieldOffset(Offset = "0x78")]
    private List<ResultData.ItemData> unreceivedItemList;

    [Token(Token = "0x1400021E")]
    public event UnityAction OnNext
    {
      [Token(Token = "0x6015D61"), Address(RVA = "0x1B33548", Offset = "0x1B33548", VA = "0x1B33548")] add
      {
      }
      [Token(Token = "0x6015D62"), Address(RVA = "0x1B335E4", Offset = "0x1B335E4", VA = "0x1B335E4")] remove
      {
      }
    }

    [Token(Token = "0x6015D63")]
    [Address(RVA = "0x1B2730C", Offset = "0x1B2730C", VA = "0x1B2730C")]
    public void Initialize(
      BattleResultSubScene subScene,
      ResultData.ItemData[] dropItemList,
      ResultData.ItemData[] unreceivedItemList,
      bool[] missionClear,
      int rewardZeny,
      BattleResultSubScene.Parameter parameter)
    {
    }

    [Token(Token = "0x6015D64")]
    [Address(RVA = "0x1B33680", Offset = "0x1B33680", VA = "0x1B33680")]
    private bool InitializeResultRetry(QuestTypeEnum questType, int questId) => new bool();

    [Token(Token = "0x6015D65")]
    [Address(RVA = "0x1B337B4", Offset = "0x1B337B4", VA = "0x1B337B4")]
    private IEnumerator ExecutePlay() => (IEnumerator) null;

    [Token(Token = "0x6015D66")]
    [Address(RVA = "0x1B33844", Offset = "0x1B33844", VA = "0x1B33844", Slot = "6")]
    public override void Play()
    {
    }

    [Token(Token = "0x6015D67")]
    [Address(RVA = "0x1B33884", Offset = "0x1B33884", VA = "0x1B33884")]
    private void PlayTimeLine(UITimelineController.DirectionType type, Action finish)
    {
    }

    [Token(Token = "0x6015D68")]
    [Address(RVA = "0x1B33970", Offset = "0x1B33970", VA = "0x1B33970")]
    private void DoNextAction()
    {
    }

    [Token(Token = "0x6015D69")]
    [Address(RVA = "0x1B339A8", Offset = "0x1B339A8", VA = "0x1B339A8")]
    public ResultDropItemView()
    {
    }
  }
}
