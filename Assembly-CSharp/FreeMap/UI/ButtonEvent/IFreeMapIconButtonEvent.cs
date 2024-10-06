// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.ButtonEvent.IFreeMapIconButtonEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Instance;
using FreeMap.Parameter.UIParam;
using FreeMap.UI.Element;
using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace FreeMap.UI.ButtonEvent
{
  [Token(Token = "0x2001715")]
  public interface IFreeMapIconButtonEvent
  {
    [Token(Token = "0x1700146D")]
    bool IsPauseForAction { [Token(Token = "0x600829A")] get; }

    [Token(Token = "0x1700146E")]
    bool IsTimeElapseAreaExit { [Token(Token = "0x600829B")] get; }

    [Token(Token = "0x600829C")]
    bool IsBaseUIParam(FreeMapUIParamBase param);

    [Token(Token = "0x600829D")]
    UIParameterType GetUIParamType();

    [Token(Token = "0x600829E")]
    void SetControlElement(FreeMapIconEventControlElement element);

    [Token(Token = "0x600829F")]
    void BindTransformHolder(FreeMapUITransformHolder holder);

    [Token(Token = "0x60082A0")]
    void SetAction(Action changePlayerOperation, Action<int> changeAreaExit);

    [Token(Token = "0x60082A1")]
    IEnumerator PlayActionCoroutine(FreeMapPlayerInstance activePlayer);
  }
}
