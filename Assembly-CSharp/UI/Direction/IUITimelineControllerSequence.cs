// Decompiled with JetBrains decompiler
// Type: UI.Direction.IUITimelineControllerSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine.Events;

#nullable disable
namespace UI.Direction
{
  [Token(Token = "0x2000903")]
  public interface IUITimelineControllerSequence
  {
    [Token(Token = "0x1700075D")]
    bool AnyRequest { [Token(Token = "0x60032F0")] get; }

    [Token(Token = "0x60032F1")]
    void Dispose();

    [Token(Token = "0x60032F2")]
    void Request(
      UITimelineControllerSequence.RequestParameter requestData,
      Action requestFinishCallback = null);

    [Token(Token = "0x60032F3")]
    void Request(
      string keyword,
      UITimelineController.DirectionType type,
      Action callback = null,
      Action requestFinishCallback = null);

    [Token(Token = "0x60032F4")]
    void Request(
      UITimelineController.DirectionType type,
      Action callback = null,
      Action requestFinishCallback = null);

    [Token(Token = "0x60032F5")]
    void Request(
      List<UITimelineControllerSequence.RequestParameter> requestParameterList,
      Action requestFinishCallback = null);

    [Token(Token = "0x60032F6")]
    void Start(UnityAction sequenceFinishCallback = null);

    [Token(Token = "0x60032F7")]
    void Cancel(bool stopDirection = true);
  }
}
