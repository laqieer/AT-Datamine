// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.AreaEventQuest.AreaQuestEventMissionView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Input;
using Il2CppDummyDll;
using Scenes.ScenarioQuest;
using Scenes.ScenarioQuest.EventMission;
using Scenes.ScenarioQuest.UI.Top;
using System;
using System.Collections.Generic;
using UI.Direction;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.AreaEventQuest
{
  [Token(Token = "0x2003944")]
  public class AreaQuestEventMissionView : MissionView
  {
    [Token(Token = "0x400FA4A")]
    [FieldOffset(Offset = "0x38")]
    [Space(5f)]
    [Header("GroupCanvas")]
    [SerializeField]
    private CanvasGroup canvasGroup;
    [Token(Token = "0x400FA4B")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    [Space(5f)]
    [Header("右上側 イベントミッション進捗")]
    private MissionProgressView eventMissionProgressView;
    [Token(Token = "0x400FA4C")]
    [FieldOffset(Offset = "0x48")]
    [Header("階級")]
    [Space(5f)]
    [SerializeField]
    private AreaQuestEventMissionRank missionProgressRank;
    [Token(Token = "0x400FA4D")]
    [FieldOffset(Offset = "0x50")]
    [Header("ボタン")]
    [Space(5f)]
    [SerializeField]
    private CommonButton backButton;
    [Token(Token = "0x400FA4E")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private BackKeyHandlerComponent backKeyHandler;
    [Token(Token = "0x400FA4F")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private GotoExchangeStoreUI exchangeStore;
    [Token(Token = "0x400FA50")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    [Header("Timeline")]
    [Space(5f)]
    private UITimelineController timeline;

    [Token(Token = "0x17004A05")]
    public CommonButton BackButton
    {
      [Token(Token = "0x6016827"), Address(RVA = "0x42EAD30", Offset = "0x42EAD30", VA = "0x42EAD30")] get
      {
        return (CommonButton) null;
      }
    }

    [Token(Token = "0x17004A06")]
    public BackKeyHandlerComponent BackKey
    {
      [Token(Token = "0x6016828"), Address(RVA = "0x42EAD38", Offset = "0x42EAD38", VA = "0x42EAD38")] get
      {
        return (BackKeyHandlerComponent) null;
      }
    }

    [Token(Token = "0x17004A07")]
    public GotoExchangeStoreUI ExchangeStoreButton
    {
      [Token(Token = "0x6016829"), Address(RVA = "0x42EAD40", Offset = "0x42EAD40", VA = "0x42EAD40")] get
      {
        return (GotoExchangeStoreUI) null;
      }
    }

    [Token(Token = "0x17004A08")]
    public UITImelineControllerFacade TimelineFacade
    {
      [Token(Token = "0x601682A"), Address(RVA = "0x42EAD48", Offset = "0x42EAD48", VA = "0x42EAD48")] get
      {
        return (UITImelineControllerFacade) null;
      }
      [Token(Token = "0x601682B"), Address(RVA = "0x42EAD50", Offset = "0x42EAD50", VA = "0x42EAD50")] private set
      {
      }
    }

    [Token(Token = "0x17004A09")]
    private int EventId
    {
      [Token(Token = "0x601682C"), Address(RVA = "0x42EAD58", Offset = "0x42EAD58", VA = "0x42EAD58")] get
      {
        return new int();
      }
      [Token(Token = "0x601682D"), Address(RVA = "0x42EAD60", Offset = "0x42EAD60", VA = "0x42EAD60")] set
      {
      }
    }

    [Token(Token = "0x601682E")]
    [Address(RVA = "0x42E8AE4", Offset = "0x42E8AE4", VA = "0x42E8AE4")]
    public void Initialize(int eventId, AssetCachedSpawner spawner)
    {
    }

    [Token(Token = "0x601682F")]
    [Address(RVA = "0x42E90C4", Offset = "0x42E90C4", VA = "0x42E90C4")]
    public void SetOperationPossible(bool state)
    {
    }

    [Token(Token = "0x6016830")]
    [Address(RVA = "0x42E7844", Offset = "0x42E7844", VA = "0x42E7844")]
    public void SetRewardConditions(
      List<RewardConditionData> rewardConditions,
      int progressPoint,
      int maxPoint,
      Action<bool, int> onClickTreasure)
    {
    }

    [Token(Token = "0x6016831")]
    [Address(RVA = "0x42E793C", Offset = "0x42E793C", VA = "0x42E793C")]
    public void SetProgressRank(int rank)
    {
    }

    [Token(Token = "0x6016832")]
    [Address(RVA = "0x42E797C", Offset = "0x42E797C", VA = "0x42E797C")]
    public void UpdateProgressRank(int rank, Action callback)
    {
    }

    [Token(Token = "0x6016833")]
    [Address(RVA = "0x42E79B0", Offset = "0x42E79B0", VA = "0x42E79B0")]
    public void SetExChangeStoreText()
    {
    }

    [Token(Token = "0x6016834")]
    [Address(RVA = "0x42EAD68", Offset = "0x42EAD68", VA = "0x42EAD68")]
    public AreaQuestEventMissionView()
    {
    }
  }
}
