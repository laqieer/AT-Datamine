// Decompiled with JetBrains decompiler
// Type: FreeMap.State.AreaEvent.AreaEventQuestReceipt
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Adv;
using FreeMap.Loader;
using Il2CppDummyDll;
using Network.API;
using StaqData.AreaEvent;
using Story.Adv;
using System.Collections;

#nullable disable
namespace FreeMap.State.AreaEvent
{
  [Token(Token = "0x200183D")]
  public class AreaEventQuestReceipt
  {
    [Token(Token = "0x40069C1")]
    [FieldOffset(Offset = "0x10")]
    private APIStoryAreaEventQuestReceipt api;
    [Token(Token = "0x40069C2")]
    [FieldOffset(Offset = "0x18")]
    public AreaEventQuestReceipt.CalledAPI OnCalledAPI;
    [Token(Token = "0x40069C3")]
    [FieldOffset(Offset = "0x20")]
    private Story.APIResult.AreaEventQuestReceipt resultCommon;
    [Token(Token = "0x40069C4")]
    [FieldOffset(Offset = "0x28")]
    private IFreeMapAdvControl freemapAdvControl;
    [Token(Token = "0x40069C5")]
    [FieldOffset(Offset = "0x30")]
    private IFreeMapTemporarySceneLoader sceneHandler;
    [Token(Token = "0x40069C6")]
    [FieldOffset(Offset = "0x38")]
    private bool isChangeArea;

    [Token(Token = "0x600891A")]
    [Address(RVA = "0x43E1ECC", Offset = "0x43E1ECC", VA = "0x43E1ECC")]
    private AdvStageAreaEventQuest CreateAdvStage(int taskID) => (AdvStageAreaEventQuest) null;

    [Token(Token = "0x600891B")]
    [Address(RVA = "0x43E21C4", Offset = "0x43E21C4", VA = "0x43E21C4")]
    private IEnumerator Play(int taskID) => (IEnumerator) null;

    [Token(Token = "0x600891C")]
    [Address(RVA = "0x43E2264", Offset = "0x43E2264", VA = "0x43E2264")]
    private void OnAreaChange()
    {
    }

    [Token(Token = "0x600891D")]
    [Address(RVA = "0x43E2400", Offset = "0x43E2400", VA = "0x43E2400")]
    private IEnumerator OnStageEnd() => (IEnumerator) null;

    [Token(Token = "0x600891E")]
    [Address(RVA = "0x43E2490", Offset = "0x43E2490", VA = "0x43E2490")]
    public AreaEventQuestReceipt(
      IFreeMapAdvControl freemapAdvControl,
      IFreeMapTemporarySceneLoader sceneHandler)
    {
    }

    [Token(Token = "0x600891F")]
    [Address(RVA = "0x43E2558", Offset = "0x43E2558", VA = "0x43E2558")]
    public void Execute()
    {
    }

    [Token(Token = "0x6008920")]
    [Address(RVA = "0x43E2654", Offset = "0x43E2654", VA = "0x43E2654")]
    private IEnumerator ExecuteAsync(AreaEventQuestData quest) => (IEnumerator) null;

    [Token(Token = "0x6008921")]
    [Address(RVA = "0x43E26F0", Offset = "0x43E26F0", VA = "0x43E26F0")]
    private IEnumerator CallAPI(AdvStageBase advStageBase) => (IEnumerator) null;

    [Token(Token = "0x200183E")]
    public delegate IEnumerator CalledAPI(APIStoryAreaEventQuestReceiptResponse response);
  }
}
