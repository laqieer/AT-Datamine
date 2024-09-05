// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.AreaEventQuest.AreaQuestEventMissionSubScene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Scene;
using Il2CppDummyDll;
using Network.API;
using Scenes.ScenarioQuest.EventMission;
using System;
using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace Scenes.OutGame.AreaEventQuest
{
  [Token(Token = "0x2003933")]
  public class AreaQuestEventMissionSubScene : SubScene
  {
    [Token(Token = "0x400FA11")]
    [FieldOffset(Offset = "0x58")]
    private AssetCachedSpawner _spawner;
    [Token(Token = "0x400FA12")]
    [FieldOffset(Offset = "0x60")]
    private AreaQuestEventMissionPresenter _presenter;
    [Token(Token = "0x400FA13")]
    [FieldOffset(Offset = "0x68")]
    private EventMissionModel _model;
    [Token(Token = "0x400FA14")]
    [FieldOffset(Offset = "0x70")]
    private AreaQuestEventMissionView _view;
    [Token(Token = "0x400FA15")]
    [FieldOffset(Offset = "0x78")]
    private APIMissionListResponse _response;
    [Token(Token = "0x400FA16")]
    [FieldOffset(Offset = "0x80")]
    private int _missionGroupId;
    [Token(Token = "0x400FA17")]
    [FieldOffset(Offset = "0x84")]
    private bool isInit;
    [Token(Token = "0x400FA18")]
    [FieldOffset(Offset = "0x85")]
    private bool onRequestReceiveMissionReward;
    [Token(Token = "0x400FA1B")]
    [FieldOffset(Offset = "0x98")]
    private AreaQuestEventMissionSubScene.EventMissionParameter _parameter;

    [Token(Token = "0x60167C7")]
    [Address(RVA = "0x42E3B80", Offset = "0x42E3B80", VA = "0x42E3B80")]
    public static void ChangeSubScene(int id)
    {
    }

    [Token(Token = "0x1400021F")]
    private event Action<List<int>> receiptAction
    {
      [Token(Token = "0x60167C8"), Address(RVA = "0x42E7AA0", Offset = "0x42E7AA0", VA = "0x42E7AA0")] add
      {
      }
      [Token(Token = "0x60167C9"), Address(RVA = "0x42E7B50", Offset = "0x42E7B50", VA = "0x42E7B50")] remove
      {
      }
    }

    [Token(Token = "0x14000220")]
    private event Action<bool, int> receiptProgress
    {
      [Token(Token = "0x60167CA"), Address(RVA = "0x42E7C00", Offset = "0x42E7C00", VA = "0x42E7C00")] add
      {
      }
      [Token(Token = "0x60167CB"), Address(RVA = "0x42E7CB0", Offset = "0x42E7CB0", VA = "0x42E7CB0")] remove
      {
      }
    }

    [Token(Token = "0x60167CC")]
    [Address(RVA = "0x42E7D60", Offset = "0x42E7D60", VA = "0x42E7D60", Slot = "6")]
    public override void Initialize(ChangeSceneParameter param = null)
    {
    }

    [Token(Token = "0x60167CD")]
    [Address(RVA = "0x42E7E28", Offset = "0x42E7E28", VA = "0x42E7E28", Slot = "7")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x60167CE")]
    [Address(RVA = "0x42E7EB8", Offset = "0x42E7EB8", VA = "0x42E7EB8", Slot = "21")]
    public override IEnumerator EnableEffect() => (IEnumerator) null;

    [Token(Token = "0x60167CF")]
    [Address(RVA = "0x42E7F48", Offset = "0x42E7F48", VA = "0x42E7F48", Slot = "22")]
    public override IEnumerator DisableEffect() => (IEnumerator) null;

    [Token(Token = "0x60167D0")]
    [Address(RVA = "0x42E7FD8", Offset = "0x42E7FD8", VA = "0x42E7FD8")]
    public void Update()
    {
    }

    [Token(Token = "0x60167D1")]
    [Address(RVA = "0x42E7E00", Offset = "0x42E7E00", VA = "0x42E7E00")]
    private int GetMissionGroupId() => new int();

    [Token(Token = "0x60167D2")]
    [Address(RVA = "0x42E8194", Offset = "0x42E8194", VA = "0x42E8194")]
    private IEnumerator GetMissionProgressRewards() => (IEnumerator) null;

    [Token(Token = "0x60167D3")]
    [Address(RVA = "0x42E8224", Offset = "0x42E8224", VA = "0x42E8224")]
    public void RequestOnClickReceiptButton(List<int> ids)
    {
    }

    [Token(Token = "0x60167D4")]
    [Address(RVA = "0x42E82D0", Offset = "0x42E82D0", VA = "0x42E82D0")]
    public void RequestOnClickBunchReciptButton()
    {
    }

    [Token(Token = "0x60167D5")]
    [Address(RVA = "0x42E82FC", Offset = "0x42E82FC", VA = "0x42E82FC")]
    public void RequestGetProgressReward(bool isOpen, int progressId)
    {
    }

    [Token(Token = "0x60167D6")]
    [Address(RVA = "0x42E825C", Offset = "0x42E825C", VA = "0x42E825C")]
    public IEnumerator RequestReceiveMissionReward(List<int> ids) => (IEnumerator) null;

    [Token(Token = "0x60167D7")]
    [Address(RVA = "0x42E8320", Offset = "0x42E8320", VA = "0x42E8320")]
    public IEnumerator RequestReceiveProgressReward(bool isOpen, int progressId)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60167D8")]
    [Address(RVA = "0x42E83F4", Offset = "0x42E83F4", VA = "0x42E83F4")]
    public void OnBack()
    {
    }

    [Token(Token = "0x60167D9")]
    [Address(RVA = "0x42E8474", Offset = "0x42E8474", VA = "0x42E8474", Slot = "25")]
    public override void OnBackScene()
    {
    }

    [Token(Token = "0x60167DA")]
    [Address(RVA = "0x42E8494", Offset = "0x42E8494", VA = "0x42E8494")]
    private IEnumerator InitializeBackScene() => (IEnumerator) null;

    [Token(Token = "0x60167DB")]
    [Address(RVA = "0x42E8524", Offset = "0x42E8524", VA = "0x42E8524")]
    private void OnExchangeStore()
    {
    }

    [Token(Token = "0x60167DC")]
    [Address(RVA = "0x42E87E0", Offset = "0x42E87E0", VA = "0x42E87E0")]
    private void OpenHasNotAcceptedPopup(Action callback = null)
    {
    }

    [Token(Token = "0x60167DD")]
    [Address(RVA = "0x42E8648", Offset = "0x42E8648", VA = "0x42E8648")]
    private void ViewOutPeriod()
    {
    }

    [Token(Token = "0x60167DE")]
    [Address(RVA = "0x42E89BC", Offset = "0x42E89BC", VA = "0x42E89BC")]
    public AreaQuestEventMissionSubScene()
    {
    }

    [Token(Token = "0x2003934")]
    public sealed class EventMissionParameter : ChangeSceneParameter
    {
      [Token(Token = "0x400FA1C")]
      [FieldOffset(Offset = "0x14")]
      public int EventPageId;

      [Token(Token = "0x60167E4")]
      [Address(RVA = "0x42E79E4", Offset = "0x42E79E4", VA = "0x42E79E4")]
      public EventMissionParameter(int id)
      {
      }
    }
  }
}
