// Decompiled with JetBrains decompiler
// Type: UI.Direction.UITimelineControllerSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace UI.Direction
{
  [Token(Token = "0x2000904")]
  public class UITimelineControllerSequence : IUITimelineControllerSequence, IDisposable
  {
    [Token(Token = "0x4002A28")]
    [FieldOffset(Offset = "0x10")]
    private UITimelineController timelineController;
    [Token(Token = "0x4002A29")]
    [FieldOffset(Offset = "0x18")]
    private Queue<UITimelineControllerSequence.RequestData> requestQueue;
    [Token(Token = "0x4002A2A")]
    [FieldOffset(Offset = "0x20")]
    private UnityAction sequenceFinishCallback;
    [Token(Token = "0x4002A2B")]
    [FieldOffset(Offset = "0x28")]
    private Coroutine startCoroutine;
    [Token(Token = "0x4002A2C")]
    [FieldOffset(Offset = "0x30")]
    private bool disposed;

    [Token(Token = "0x1700075E")]
    public bool AnyRequest
    {
      [Token(Token = "0x60032F8"), Address(RVA = "0x3623718", Offset = "0x3623718", VA = "0x3623718", Slot = "4")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x60032F9")]
    [Address(RVA = "0x3623768", Offset = "0x3623768", VA = "0x3623768")]
    public UITimelineControllerSequence(UITimelineController timelineController)
    {
    }

    [Token(Token = "0x60032FA")]
    [Address(RVA = "0x36237F8", Offset = "0x36237F8", VA = "0x36237F8", Slot = "12")]
    public void Dispose()
    {
    }

    [Token(Token = "0x60032FB")]
    [Address(RVA = "0x36238BC", Offset = "0x36238BC", VA = "0x36238BC", Slot = "6")]
    public void Request(
      UITimelineControllerSequence.RequestParameter requestData,
      Action requestFinishCallback = null)
    {
    }

    [Token(Token = "0x60032FC")]
    [Address(RVA = "0x3623970", Offset = "0x3623970", VA = "0x3623970", Slot = "7")]
    public void Request(
      string keyword,
      UITimelineController.DirectionType type,
      Action callback = null,
      Action requestFinishCallback = null)
    {
    }

    [Token(Token = "0x60032FD")]
    [Address(RVA = "0x3623A44", Offset = "0x3623A44", VA = "0x3623A44", Slot = "8")]
    public void Request(
      UITimelineController.DirectionType type,
      Action callback = null,
      Action requestFinishCallback = null)
    {
    }

    [Token(Token = "0x60032FE")]
    [Address(RVA = "0x3623AB4", Offset = "0x3623AB4", VA = "0x3623AB4", Slot = "9")]
    public void Request(
      List<UITimelineControllerSequence.RequestParameter> requestParameterList,
      Action requestFinishCallback = null)
    {
    }

    [Token(Token = "0x60032FF")]
    [Address(RVA = "0x3623B74", Offset = "0x3623B74", VA = "0x3623B74", Slot = "10")]
    public void Start(UnityAction sequenceFinishCallback = null)
    {
    }

    [Token(Token = "0x6003300")]
    [Address(RVA = "0x3623814", Offset = "0x3623814", VA = "0x3623814", Slot = "11")]
    public void Cancel(bool stopDirection = true)
    {
    }

    [Token(Token = "0x6003301")]
    [Address(RVA = "0x3623C18", Offset = "0x3623C18", VA = "0x3623C18")]
    private IEnumerator Observation() => (IEnumerator) null;

    [Token(Token = "0x2000905")]
    public class RequestParameter
    {
      [Token(Token = "0x4002A2D")]
      [FieldOffset(Offset = "0x10")]
      public string Keyword;
      [Token(Token = "0x4002A2E")]
      [FieldOffset(Offset = "0x18")]
      public UITimelineController.DirectionType Type;
      [Token(Token = "0x4002A2F")]
      [FieldOffset(Offset = "0x20")]
      public Action Callback;

      [Token(Token = "0x6003302")]
      [Address(RVA = "0x3623A04", Offset = "0x3623A04", VA = "0x3623A04")]
      public RequestParameter(
        string keyword,
        UITimelineController.DirectionType type,
        Action callback)
      {
      }
    }

    [Token(Token = "0x2000906")]
    private class RequestData
    {
      [Token(Token = "0x4002A30")]
      [FieldOffset(Offset = "0x10")]
      public UITimelineControllerSequence.RequestParameter SingleDirection;
      [Token(Token = "0x4002A31")]
      [FieldOffset(Offset = "0x18")]
      public List<UITimelineControllerSequence.RequestParameter> DirectionGroup;
      [Token(Token = "0x4002A32")]
      [FieldOffset(Offset = "0x20")]
      public Action RequestFinishCallback;

      [Token(Token = "0x6003303")]
      [Address(RVA = "0x3623968", Offset = "0x3623968", VA = "0x3623968")]
      public RequestData()
      {
      }
    }
  }
}
