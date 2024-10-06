// Decompiled with JetBrains decompiler
// Type: IronSourceEventsDispatcher
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000041")]
public class IronSourceEventsDispatcher : MonoBehaviour
{
  [Token(Token = "0x400013B")]
  [FieldOffset(Offset = "0x0")]
  private static IronSourceEventsDispatcher instance;
  [Token(Token = "0x400013C")]
  [FieldOffset(Offset = "0x8")]
  private static readonly Queue<Action> ironSourceExecuteOnMainThreadQueue;

  [Token(Token = "0x600022B")]
  [Address(RVA = "0x2047D48", Offset = "0x2047D48", VA = "0x2047D48")]
  public static void executeAction(Action action)
  {
  }

  [Token(Token = "0x600022C")]
  [Address(RVA = "0x2058C28", Offset = "0x2058C28", VA = "0x2058C28")]
  private void Update()
  {
  }

  [Token(Token = "0x600022D")]
  [Address(RVA = "0x2058EA4", Offset = "0x2058EA4", VA = "0x2058EA4")]
  public void removeFromParent()
  {
  }

  [Token(Token = "0x600022E")]
  [Address(RVA = "0x203E350", Offset = "0x203E350", VA = "0x203E350")]
  public static void initialize()
  {
  }

  [Token(Token = "0x600022F")]
  [Address(RVA = "0x2058F28", Offset = "0x2058F28", VA = "0x2058F28")]
  public static bool isCreated() => new bool();

  [Token(Token = "0x6000230")]
  [Address(RVA = "0x2058FB4", Offset = "0x2058FB4", VA = "0x2058FB4")]
  public void Awake()
  {
  }

  [Token(Token = "0x6000231")]
  [Address(RVA = "0x2059020", Offset = "0x2059020", VA = "0x2059020")]
  public void OnDisable()
  {
  }

  [Token(Token = "0x6000232")]
  [Address(RVA = "0x2059078", Offset = "0x2059078", VA = "0x2059078")]
  public IronSourceEventsDispatcher()
  {
  }

  [Token(Token = "0x6000233")]
  [Address(RVA = "0x2059080", Offset = "0x2059080", VA = "0x2059080")]
  static IronSourceEventsDispatcher()
  {
  }
}
