// Decompiled with JetBrains decompiler
// Type: FreeMap.State.Process.TrackerAnimiationIfNeed
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;

#nullable disable
namespace FreeMap.State.Process
{
  [Token(Token = "0x20017F5")]
  public class TrackerAnimiationIfNeed : FreeMapProcess
  {
    [Token(Token = "0x6008796")]
    [Address(RVA = "0x43CFA1C", Offset = "0x43CFA1C", VA = "0x43CFA1C")]
    public TrackerAnimiationIfNeed(FreeMapStateManager entity)
    {
    }

    [Token(Token = "0x6008797")]
    [Address(RVA = "0x43D8010", Offset = "0x43D8010", VA = "0x43D8010", Slot = "4")]
    public override void Begin()
    {
    }

    [Token(Token = "0x6008798")]
    [Address(RVA = "0x43D8084", Offset = "0x43D8084", VA = "0x43D8084")]
    private IEnumerator AnimationWaitCoroutine() => (IEnumerator) null;
  }
}
