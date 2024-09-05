// Decompiled with JetBrains decompiler
// Type: Scenes.ScenarioQuest.EventMission.ScenarioQuestEventMissionSubScene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Scene;
using Il2CppDummyDll;
using Network.API;
using System;
using System.Collections;
using System.Collections.Generic;
using UI.Direction;
using UnityEngine;

#nullable disable
namespace Scenes.ScenarioQuest.EventMission
{
  [Token(Token = "0x20029A7")]
  public class ScenarioQuestEventMissionSubScene : SubScene
  {
    [Token(Token = "0x400B16F")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private UITimelineController timeline;
    [Token(Token = "0x400B170")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private EventMissionView view;
    [Token(Token = "0x400B171")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private CommonButton globalButton;
    [Token(Token = "0x400B172")]
    [FieldOffset(Offset = "0x70")]
    private UITImelineControllerFacade _timelineFacade;
    [Token(Token = "0x400B173")]
    [FieldOffset(Offset = "0x78")]
    private AssetCachedSpawner _spawner;
    [Token(Token = "0x400B174")]
    [FieldOffset(Offset = "0x80")]
    private EventMissionModel _model;
    [Token(Token = "0x400B175")]
    [FieldOffset(Offset = "0x88")]
    private EventMissionPresenter _presenter;
    [Token(Token = "0x400B176")]
    [FieldOffset(Offset = "0x90")]
    private APIMissionListResponse _response;
    [Token(Token = "0x400B177")]
    [FieldOffset(Offset = "0x98")]
    private int _missionGroupId;
    [Token(Token = "0x400B178")]
    [FieldOffset(Offset = "0x9C")]
    private bool isInit;
    [Token(Token = "0x400B179")]
    [FieldOffset(Offset = "0x9D")]
    private bool onRequestReceiveMissionReward;

    [Token(Token = "0x60105BD")]
    [Address(RVA = "0x488207C", Offset = "0x488207C", VA = "0x488207C")]
    public static void ChangeSubScene()
    {
    }

    [Token(Token = "0x14000156")]
    private event Action<List<int>> receiptAction
    {
      [Token(Token = "0x60105BE"), Address(RVA = "0x4882128", Offset = "0x4882128", VA = "0x4882128")] add
      {
      }
      [Token(Token = "0x60105BF"), Address(RVA = "0x48821D8", Offset = "0x48821D8", VA = "0x48821D8")] remove
      {
      }
    }

    [Token(Token = "0x14000157")]
    private event Action<bool, int> receiptProgress
    {
      [Token(Token = "0x60105C0"), Address(RVA = "0x4882288", Offset = "0x4882288", VA = "0x4882288")] add
      {
      }
      [Token(Token = "0x60105C1"), Address(RVA = "0x4882338", Offset = "0x4882338", VA = "0x4882338")] remove
      {
      }
    }

    [Token(Token = "0x60105C2")]
    [Address(RVA = "0x48823E8", Offset = "0x48823E8", VA = "0x48823E8", Slot = "6")]
    public override void Initialize(ChangeSceneParameter param = null)
    {
    }

    [Token(Token = "0x60105C3")]
    [Address(RVA = "0x48828DC", Offset = "0x48828DC", VA = "0x48828DC", Slot = "7")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x60105C4")]
    [Address(RVA = "0x4882584", Offset = "0x4882584", VA = "0x4882584")]
    private int GetMissionGroupId() => new int();

    [Token(Token = "0x60105C5")]
    [Address(RVA = "0x488264C", Offset = "0x488264C", VA = "0x488264C")]
    private void SetCharacterData()
    {
    }

    [Token(Token = "0x60105C6")]
    [Address(RVA = "0x4882974", Offset = "0x4882974", VA = "0x4882974")]
    private IEnumerator GetMissionProgressRewards() => (IEnumerator) null;

    [Token(Token = "0x60105C7")]
    [Address(RVA = "0x4882A04", Offset = "0x4882A04", VA = "0x4882A04")]
    public void RequestOnClickReceiptButton(List<int> ids)
    {
    }

    [Token(Token = "0x60105C8")]
    [Address(RVA = "0x4882AB0", Offset = "0x4882AB0", VA = "0x4882AB0")]
    public void RequestGetProgressReward(bool isOpen, int progressId)
    {
    }

    [Token(Token = "0x60105C9")]
    [Address(RVA = "0x4882A3C", Offset = "0x4882A3C", VA = "0x4882A3C")]
    public IEnumerator RequestReceiveMissionReward(List<int> ids) => (IEnumerator) null;

    [Token(Token = "0x60105CA")]
    [Address(RVA = "0x4882AEC", Offset = "0x4882AEC", VA = "0x4882AEC")]
    public IEnumerator RequestReceiveProgressReward(bool isOpen, int progressId)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60105CB")]
    [Address(RVA = "0x4882BC0", Offset = "0x4882BC0", VA = "0x4882BC0", Slot = "21")]
    public override IEnumerator EnableEffect() => (IEnumerator) null;

    [Token(Token = "0x60105CC")]
    [Address(RVA = "0x4882C50", Offset = "0x4882C50", VA = "0x4882C50", Slot = "22")]
    public override IEnumerator DisableEffect() => (IEnumerator) null;

    [Token(Token = "0x60105CD")]
    [Address(RVA = "0x4882CE0", Offset = "0x4882CE0", VA = "0x4882CE0")]
    public void OnBack()
    {
    }

    [Token(Token = "0x60105CE")]
    [Address(RVA = "0x4882D78", Offset = "0x4882D78", VA = "0x4882D78")]
    public void Update()
    {
    }

    [Token(Token = "0x60105CF")]
    [Address(RVA = "0x4882D94", Offset = "0x4882D94", VA = "0x4882D94")]
    private void OpenHasNotAcceptedPopup(Action callback = null)
    {
    }

    [Token(Token = "0x60105D0")]
    [Address(RVA = "0x4882F70", Offset = "0x4882F70", VA = "0x4882F70")]
    public ScenarioQuestEventMissionSubScene()
    {
    }
  }
}
