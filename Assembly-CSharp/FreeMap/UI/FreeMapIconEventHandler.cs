// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.FreeMapIconEventHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Instance;
using FreeMap.Parameter.UIParam;
using FreeMap.UI.ButtonEvent;
using FreeMap.UI.Manager;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace FreeMap.UI
{
  [Token(Token = "0x20015F5")]
  public class FreeMapIconEventHandler
  {
    [Token(Token = "0x4006420")]
    [FieldOffset(Offset = "0x10")]
    private IFreeMapIconButtonEvent currentIconEvent;
    [Token(Token = "0x4006421")]
    [FieldOffset(Offset = "0x18")]
    public Action<FreeMapUIParamBase> OnExecuteClosedEvent;
    [Token(Token = "0x4006422")]
    [FieldOffset(Offset = "0x20")]
    public Action<FreeMapUIParamBase> OnExecuteEvent;
    [Token(Token = "0x4006423")]
    [FieldOffset(Offset = "0x28")]
    private List<IFreeMapUIVisible> uiControllerList;
    [Token(Token = "0x4006424")]
    [FieldOffset(Offset = "0x30")]
    private MonoBehaviour coroutineHandler;
    [Token(Token = "0x4006426")]
    [FieldOffset(Offset = "0x40")]
    private Coroutine coroutineEvent;

    [Token(Token = "0x17001321")]
    public IFreeMapIconButtonEvent CurrentIconEvent
    {
      [Token(Token = "0x6007C3A"), Address(RVA = "0x219FC1C", Offset = "0x219FC1C", VA = "0x219FC1C")] get
      {
        return (IFreeMapIconButtonEvent) null;
      }
    }

    [Token(Token = "0x17001322")]
    public GameObject MovePointObject
    {
      [Token(Token = "0x6007C3B"), Address(RVA = "0x219FC24", Offset = "0x219FC24", VA = "0x219FC24")] private set
      {
      }
      [Token(Token = "0x6007C3C"), Address(RVA = "0x219FC2C", Offset = "0x219FC2C", VA = "0x219FC2C")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x6007C3D")]
    [Address(RVA = "0x219FC34", Offset = "0x219FC34", VA = "0x219FC34")]
    public void Release()
    {
    }

    [Token(Token = "0x6007C3E")]
    [Address(RVA = "0x219FCC0", Offset = "0x219FCC0", VA = "0x219FCC0")]
    public void Initialize(FreeMapUIManageHandler holder, MonoBehaviour coroutineHandler)
    {
    }

    [Token(Token = "0x6007C3F")]
    [Address(RVA = "0x219FDD4", Offset = "0x219FDD4", VA = "0x219FDD4")]
    public void SetIconEvent(IFreeMapIconButtonEvent iconEvent)
    {
    }

    [Token(Token = "0x6007C40")]
    [Address(RVA = "0x219FDDC", Offset = "0x219FDDC", VA = "0x219FDDC")]
    public void SetMovePointObject(GameObject movePointObject)
    {
    }

    [Token(Token = "0x6007C41")]
    [Address(RVA = "0x219FDE4", Offset = "0x219FDE4", VA = "0x219FDE4")]
    public void PlayIconEvent(
      FreeMapPlayerInstance player,
      Action changePlayerOperation,
      Action<int> changeAreaExit)
    {
    }

    [Token(Token = "0x6007C42")]
    [Address(RVA = "0x219FF34", Offset = "0x219FF34", VA = "0x219FF34")]
    public void ClearIconEventCallback()
    {
    }

    [Token(Token = "0x6007C43")]
    [Address(RVA = "0x219FFE0", Offset = "0x219FFE0", VA = "0x219FFE0")]
    public void SetUIVisible(bool visible)
    {
    }

    [Token(Token = "0x6007C44")]
    [Address(RVA = "0x21A0194", Offset = "0x21A0194", VA = "0x21A0194")]
    public FreeMapIconEventHandler()
    {
    }
  }
}
