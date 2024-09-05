// Decompiled with JetBrains decompiler
// Type: FreeMap.State.Process.FreeMapTutorialStart
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Data;
using Il2CppDummyDll;

#nullable disable
namespace FreeMap.State.Process
{
  [Token(Token = "0x20017DC")]
  public class FreeMapTutorialStart : FreeMapProcess
  {
    [Token(Token = "0x40068D9")]
    [FieldOffset(Offset = "0x38")]
    private FreeMapParamList paramlist;
    [Token(Token = "0x40068DA")]
    [FieldOffset(Offset = "0x40")]
    private int playerLabel;

    [Token(Token = "0x600870C")]
    [Address(RVA = "0x43D3F8C", Offset = "0x43D3F8C", VA = "0x43D3F8C")]
    public FreeMapTutorialStart(
      FreeMapStateManager entity,
      FreeMapParamList paramlist,
      int playerLabel)
    {
    }

    [Token(Token = "0x600870D")]
    [Address(RVA = "0x43D3FB8", Offset = "0x43D3FB8", VA = "0x43D3FB8", Slot = "4")]
    public override void Begin()
    {
    }

    [Token(Token = "0x20017DD")]
    private class AreaSetup : FreeMapProcess
    {
      [Token(Token = "0x40068DB")]
      [FieldOffset(Offset = "0x38")]
      private FreeMapParamList paramlist;

      [Token(Token = "0x600870E")]
      [Address(RVA = "0x43D416C", Offset = "0x43D416C", VA = "0x43D416C")]
      public AreaSetup(FreeMapStateManager entity, FreeMapParamList paramlist)
      {
      }

      [Token(Token = "0x600870F")]
      [Address(RVA = "0x43D4194", Offset = "0x43D4194", VA = "0x43D4194", Slot = "4")]
      public override void Begin()
      {
      }
    }

    [Token(Token = "0x20017DE")]
    private class AreaStarted : FreeMapProcess
    {
      [Token(Token = "0x6008710")]
      [Address(RVA = "0x43D4190", Offset = "0x43D4190", VA = "0x43D4190")]
      public AreaStarted(FreeMapStateManager entity)
      {
      }

      [Token(Token = "0x6008711")]
      [Address(RVA = "0x43D422C", Offset = "0x43D422C", VA = "0x43D422C", Slot = "4")]
      public override void Begin()
      {
      }
    }
  }
}
