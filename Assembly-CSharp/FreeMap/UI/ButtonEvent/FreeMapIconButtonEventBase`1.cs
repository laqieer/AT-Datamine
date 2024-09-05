// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.ButtonEvent.FreeMapIconButtonEventBase`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Adv;
using FreeMap.Instance;
using FreeMap.Loader;
using FreeMap.Parameter.UIParam;
using FreeMap.UI.ButtonEvent.Task;
using FreeMap.UI.Element;
using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace FreeMap.UI.ButtonEvent
{
  [Token(Token = "0x20016EC")]
  public abstract class FreeMapIconButtonEventBase<TParam> : IFreeMapIconButtonEvent where TParam : FreeMapUIParamBase
  {
    [Token(Token = "0x4006660")]
    [FieldOffset(Offset = "0x0")]
    protected bool isPauseForAction;
    [Token(Token = "0x4006661")]
    [FieldOffset(Offset = "0x0")]
    protected bool isChageAreaExit;
    [Token(Token = "0x4006662")]
    [FieldOffset(Offset = "0x0")]
    protected bool isTimeElapseAreaExit;
    [Token(Token = "0x4006663")]
    [FieldOffset(Offset = "0x0")]
    protected FreeMapIconEventControlElement controlElement;
    [Token(Token = "0x4006665")]
    [FieldOffset(Offset = "0x0")]
    protected TParam uiParam;
    [Token(Token = "0x4006668")]
    [FieldOffset(Offset = "0x0")]
    protected Action changePlayerOperation;
    [Token(Token = "0x4006669")]
    [FieldOffset(Offset = "0x0")]
    protected Action<int> changeAreaExit;

    [Token(Token = "0x1700142A")]
    public bool IsPauseForAction
    {
      [Token(Token = "0x6008193")] get => new bool();
    }

    [Token(Token = "0x1700142B")]
    public bool IsTimeElapseAreaExit
    {
      [Token(Token = "0x6008194")] get => new bool();
    }

    [Token(Token = "0x1700142C")]
    protected virtual bool IsSavePosition
    {
      [Token(Token = "0x6008195")] get => new bool();
    }

    [Token(Token = "0x14000112")]
    protected event Action<FreeMapUITransformHolder> OnChangeTransformHolder
    {
      [Token(Token = "0x6008196")] add
      {
      }
      [Token(Token = "0x6008197")] remove
      {
      }
    }

    [Token(Token = "0x1700142D")]
    protected FreeMapButtonEventTaskList BeginTasks
    {
      [Token(Token = "0x6008198")] get => (FreeMapButtonEventTaskList) null;
    }

    [Token(Token = "0x1700142E")]
    protected FreeMapButtonEventTaskList EndTasks
    {
      [Token(Token = "0x6008199")] get => (FreeMapButtonEventTaskList) null;
    }

    [Token(Token = "0x600819A")]
    public FreeMapIconButtonEventBase(TParam uiParam, FreeMapCommonElement commonElement)
    {
    }

    [Token(Token = "0x600819B")]
    protected virtual void BuildTask(FreeMapCommonElement element)
    {
    }

    [Token(Token = "0x600819C")]
    protected virtual void SetupBeginTask(
      FreeMapCommonElement element,
      FreeMapButtonEventTaskList withCameraWork,
      FreeMapButtonEventTaskList afterCameraWork)
    {
    }

    [Token(Token = "0x600819D")]
    protected virtual void SetupEndTask(
      FreeMapCommonElement element,
      FreeMapButtonEventTaskList withCameraWork,
      FreeMapButtonEventTaskList afterCameraWork)
    {
    }

    [Token(Token = "0x600819E")]
    public bool IsBaseUIParam(FreeMapUIParamBase param) => new bool();

    [Token(Token = "0x600819F")]
    public UIParameterType GetUIParamType() => new UIParameterType();

    [Token(Token = "0x1700142F")]
    protected IFreeMapAdvControl advControllMethod
    {
      [Token(Token = "0x60081A0")] get => (IFreeMapAdvControl) null;
    }

    [Token(Token = "0x17001430")]
    protected IFreeMapTemporarySceneLoader mapSceneHandler
    {
      [Token(Token = "0x60081A1")] get => (IFreeMapTemporarySceneLoader) null;
    }

    [Token(Token = "0x17001431")]
    protected IFreeMapLocationControll locationControllMethod
    {
      [Token(Token = "0x60081A2")] get => (IFreeMapLocationControll) null;
    }

    [Token(Token = "0x60081A3")]
    public void SetControlElement(FreeMapIconEventControlElement element)
    {
    }

    [Token(Token = "0x60081A4")]
    protected virtual void OnSetControlElement(FreeMapIconEventControlElement element)
    {
    }

    [Token(Token = "0x60081A5")]
    public void BindTransformHolder(FreeMapUITransformHolder holder)
    {
    }

    [Token(Token = "0x60081A6")]
    public void SetAction(Action changePlayerOperation, Action<int> changeAreaExit)
    {
    }

    [Token(Token = "0x60081A7")]
    public IEnumerator PlayActionCoroutine(FreeMapPlayerInstance activePlayer)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60081A8")]
    protected virtual IEnumerator PlayIconEvent(FreeMapPlayerInstance activePlayer)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60081A9")]
    protected virtual IEnumerator PlayIconEvent() => (IEnumerator) null;

    [Token(Token = "0x60081AA")]
    protected virtual void LoadIconEvent(FreeMapPlayerInstance activePlayer)
    {
    }

    [Token(Token = "0x60081AB")]
    protected virtual bool IsLoadedIconEvent() => new bool();

    [Token(Token = "0x60081AC")]
    protected virtual IEnumerator OnCameraRevert() => (IEnumerator) null;

    [Token(Token = "0x60081AD")]
    private void Exit()
    {
    }

    [Token(Token = "0x60081AE")]
    protected virtual void OnExit()
    {
    }

    [Token(Token = "0x60081AF")]
    protected IEnumerator DebugPause() => (IEnumerator) null;

    [Token(Token = "0x60081B0")]
    protected void CommonStartIconEvent()
    {
    }

    [Token(Token = "0x60081B1")]
    protected void CommonExitIconEvent()
    {
    }
  }
}
