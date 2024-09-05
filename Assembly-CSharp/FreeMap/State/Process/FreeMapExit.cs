// Decompiled with JetBrains decompiler
// Type: FreeMap.State.Process.FreeMapExit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace FreeMap.State.Process
{
  [Token(Token = "0x20017C2")]
  public class FreeMapExit : FreeMapProcess
  {
    [Token(Token = "0x60086B1")]
    [Address(RVA = "0x43CFA20", Offset = "0x43CFA20", VA = "0x43CFA20")]
    public FreeMapExit(FreeMapStateManager entity)
    {
    }

    [Token(Token = "0x60086B2")]
    [Address(RVA = "0x43D13F0", Offset = "0x43D13F0", VA = "0x43D13F0", Slot = "4")]
    public override void Begin()
    {
    }

    [Token(Token = "0x60086B3")]
    [Address(RVA = "0x43D15D8", Offset = "0x43D15D8", VA = "0x43D15D8")]
    public static FreeMapProcess Do(FreeMapStateManager entity, Action callback)
    {
      return (FreeMapProcess) null;
    }

    [Token(Token = "0x20017C3")]
    private class Hide : FreeMapProcess
    {
      [Token(Token = "0x60086B4")]
      [Address(RVA = "0x43D15D0", Offset = "0x43D15D0", VA = "0x43D15D0")]
      public Hide(FreeMapStateManager entity)
      {
      }

      [Token(Token = "0x60086B5")]
      [Address(RVA = "0x43D16FC", Offset = "0x43D16FC", VA = "0x43D16FC", Slot = "4")]
      public override void Begin()
      {
      }

      [Token(Token = "0x60086B6")]
      [Address(RVA = "0x43D1730", Offset = "0x43D1730", VA = "0x43D1730")]
      private IEnumerator Coroutine() => (IEnumerator) null;
    }

    [Token(Token = "0x20017C5")]
    private class EndFreeMap : FreeMapProcess
    {
      [Token(Token = "0x60086BD")]
      [Address(RVA = "0x43D15D4", Offset = "0x43D15D4", VA = "0x43D15D4")]
      public EndFreeMap(FreeMapStateManager entity)
      {
      }

      [Token(Token = "0x60086BE")]
      [Address(RVA = "0x43D1904", Offset = "0x43D1904", VA = "0x43D1904", Slot = "4")]
      public override void Begin()
      {
      }
    }
  }
}
