// Decompiled with JetBrains decompiler
// Type: EventTransmitter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[Token(Token = "0x20000CE")]
public class EventTransmitter : MonoBehaviour
{
  [Token(Token = "0x4000374")]
  [FieldOffset(Offset = "0x18")]
  protected Dictionary<string, EventTransmitter.CallbackRequestEvent> callbackList;

  [Token(Token = "0x6000604")]
  [Address(RVA = "0x417E480", Offset = "0x417E480", VA = "0x417E480")]
  public static void Create(
    Animator animator,
    string callbackTag,
    EventTransmitter.CallbackRequestEvent callback)
  {
  }

  [Token(Token = "0x6000605")]
  [Address(RVA = "0x417E564", Offset = "0x417E564", VA = "0x417E564")]
  public void SetCallback(string callbackTag, EventTransmitter.CallbackRequestEvent callback)
  {
  }

  [Token(Token = "0x6000606")]
  [Address(RVA = "0x417E5CC", Offset = "0x417E5CC", VA = "0x417E5CC")]
  public void RemoveCallback(string callbackTag)
  {
  }

  [Token(Token = "0x6000607")]
  [Address(RVA = "0x417E624", Offset = "0x417E624", VA = "0x417E624")]
  public void RequestEvent(string argument)
  {
  }

  [Token(Token = "0x6000608")]
  [Address(RVA = "0x417E828", Offset = "0x417E828", VA = "0x417E828")]
  public EventTransmitter()
  {
  }

  [Token(Token = "0x20000CF")]
  public delegate void CallbackRequestEvent(List<string> argument);
}
