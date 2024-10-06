// Decompiled with JetBrains decompiler
// Type: Network.NetworkErrorEventListener
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace Network
{
  [Token(Token = "0x20019E9")]
  public class NetworkErrorEventListener
  {
    [Token(Token = "0x4006F0D")]
    [FieldOffset(Offset = "0x10")]
    private Dictionary<int, NetworkErrorEventListener.TransitionEvent> Callbacks;
    [Token(Token = "0x4006F0E")]
    [FieldOffset(Offset = "0x18")]
    public NetworkManager.OnError ErrorHandler;

    [Token(Token = "0x60093F2")]
    [Address(RVA = "0x4D13040", Offset = "0x4D13040", VA = "0x4D13040")]
    public NetworkErrorEventListener()
    {
    }

    [Token(Token = "0x60093F3")]
    [Address(RVA = "0x4D136D8", Offset = "0x4D136D8", VA = "0x4D136D8")]
    public void AddTransitionEventCallback(
      ErrorTransitionTypeEnum eventType,
      Func<NetworkErrorResult, IEnumerator> callback)
    {
    }

    [Token(Token = "0x60093F4")]
    [Address(RVA = "0x4D138D8", Offset = "0x4D138D8", VA = "0x4D138D8")]
    public void RemoveTransitionEventCallback(
      ErrorTransitionTypeEnum eventType,
      Func<NetworkErrorResult, IEnumerator> callback)
    {
    }

    [Token(Token = "0x60093F5")]
    [Address(RVA = "0x4D139B4", Offset = "0x4D139B4", VA = "0x4D139B4")]
    private bool TryGetTransitionEventCallback(
      ErrorTransitionTypeEnum eventType,
      out NetworkErrorEventListener.TransitionEvent transitionEvent)
    {
      return new bool();
    }

    [Token(Token = "0x60093F6")]
    [Address(RVA = "0x4D13A1C", Offset = "0x4D13A1C", VA = "0x4D13A1C")]
    private IEnumerator TransitionTitle(NetworkErrorResult networkErrorResult)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60093F7")]
    [Address(RVA = "0x4D13AA4", Offset = "0x4D13AA4", VA = "0x4D13AA4")]
    private IEnumerator TransitionHome(NetworkErrorResult networkErrorResult) => (IEnumerator) null;

    [Token(Token = "0x60093F8")]
    [Address(RVA = "0x4D13B34", Offset = "0x4D13B34", VA = "0x4D13B34")]
    private IEnumerator WaitForSubsceneProcessingToComplete(Action onComplete)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60093F9")]
    [Address(RVA = "0x4D13BC4", Offset = "0x4D13BC4", VA = "0x4D13BC4")]
    private IEnumerator TransitionGuildTop(NetworkErrorResult networkErrorResult)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60093FA")]
    [Address(RVA = "0x4D13C4C", Offset = "0x4D13C4C", VA = "0x4D13C4C")]
    private IEnumerator TransitionGuildRaidTop(NetworkErrorResult networkErrorResult)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60093FB")]
    [Address(RVA = "0x4D13CD4", Offset = "0x4D13CD4", VA = "0x4D13CD4")]
    private IEnumerator TransitionArenaTop(NetworkErrorResult networkErrorResult)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60093FC")]
    [Address(RVA = "0x4D13D5C", Offset = "0x4D13D5C", VA = "0x4D13D5C")]
    private IEnumerator OpenStore(NetworkErrorResult networkErrorResult) => (IEnumerator) null;

    [Token(Token = "0x60093FD")]
    [Address(RVA = "0x4D13DE4", Offset = "0x4D13DE4", VA = "0x4D13DE4")]
    private IEnumerator OpenOfficialSite(NetworkErrorResult networkErrorResult)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60093FE")]
    [Address(RVA = "0x4D13E6C", Offset = "0x4D13E6C", VA = "0x4D13E6C")]
    private IEnumerator Retry(NetworkErrorResult networkErrorResult) => (IEnumerator) null;

    [Token(Token = "0x60093FF")]
    [Address(RVA = "0x4D13EF4", Offset = "0x4D13EF4", VA = "0x4D13EF4")]
    public IEnumerator HandleError(NetworkErrorResult networkErrorResult) => (IEnumerator) null;

    [Token(Token = "0x6009400")]
    [Address(RVA = "0x4D13F90", Offset = "0x4D13F90", VA = "0x4D13F90")]
    private IEnumerator ShowToaster(
      NetworkErrorResult networkErrorResult,
      INetworkErrorData errorMasterData)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6009401")]
    [Address(RVA = "0x4D14034", Offset = "0x4D14034", VA = "0x4D14034")]
    private IEnumerator OpenErrorPopup(
      NetworkErrorResult networkErrorResult,
      INetworkErrorData errorMasterData)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x20019EA")]
    private class TransitionEvent
    {
      [Token(Token = "0x4006F0F")]
      [FieldOffset(Offset = "0x10")]
      private List<Func<NetworkErrorResult, IEnumerator>> callbacks;

      [Token(Token = "0x6009402")]
      [Address(RVA = "0x4D13830", Offset = "0x4D13830", VA = "0x4D13830")]
      public void AddCallback(Func<NetworkErrorResult, IEnumerator> callback)
      {
      }

      [Token(Token = "0x6009403")]
      [Address(RVA = "0x4D1395C", Offset = "0x4D1395C", VA = "0x4D1395C")]
      public void RemoveCallback(Func<NetworkErrorResult, IEnumerator> callback)
      {
      }

      [Token(Token = "0x6009404")]
      [Address(RVA = "0x4D140D8", Offset = "0x4D140D8", VA = "0x4D140D8")]
      public void Clear()
      {
      }

      [Token(Token = "0x6009405")]
      [Address(RVA = "0x4D14148", Offset = "0x4D14148", VA = "0x4D14148")]
      public IEnumerator Invoke(NetworkErrorResult networkErrorResult) => (IEnumerator) null;

      [Token(Token = "0x6009406")]
      [Address(RVA = "0x4D137B4", Offset = "0x4D137B4", VA = "0x4D137B4")]
      public TransitionEvent()
      {
      }
    }
  }
}
