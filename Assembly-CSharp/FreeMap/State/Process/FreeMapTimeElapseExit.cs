// Decompiled with JetBrains decompiler
// Type: FreeMap.State.Process.FreeMapTimeElapseExit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;

#nullable disable
namespace FreeMap.State.Process
{
  [Token(Token = "0x20017C7")]
  public class FreeMapTimeElapseExit : FreeMapProcess
  {
    [Token(Token = "0x60086C2")]
    [Address(RVA = "0x43CFA18", Offset = "0x43CFA18", VA = "0x43CFA18")]
    public FreeMapTimeElapseExit(FreeMapStateManager entity)
    {
    }

    [Token(Token = "0x60086C3")]
    [Address(RVA = "0x43D19D0", Offset = "0x43D19D0", VA = "0x43D19D0", Slot = "4")]
    public override void Begin()
    {
    }

    [Token(Token = "0x20017C8")]
    private class Fade : FreeMapProcess
    {
      [Token(Token = "0x60086C4")]
      [Address(RVA = "0x43D1BB0", Offset = "0x43D1BB0", VA = "0x43D1BB0")]
      public Fade(FreeMapStateManager entity)
      {
      }

      [Token(Token = "0x60086C5")]
      [Address(RVA = "0x43D1BB8", Offset = "0x43D1BB8", VA = "0x43D1BB8", Slot = "4")]
      public override void Begin()
      {
      }

      [Token(Token = "0x60086C6")]
      [Address(RVA = "0x43D1BEC", Offset = "0x43D1BEC", VA = "0x43D1BEC")]
      private IEnumerator Coroutine() => (IEnumerator) null;
    }

    [Token(Token = "0x20017CA")]
    private class EndFreeMap : FreeMapProcess
    {
      [Token(Token = "0x60086CD")]
      [Address(RVA = "0x43D1BB4", Offset = "0x43D1BB4", VA = "0x43D1BB4")]
      public EndFreeMap(FreeMapStateManager entity)
      {
      }

      [Token(Token = "0x60086CE")]
      [Address(RVA = "0x43D1DAC", Offset = "0x43D1DAC", VA = "0x43D1DAC", Slot = "4")]
      public override void Begin()
      {
      }
    }
  }
}
