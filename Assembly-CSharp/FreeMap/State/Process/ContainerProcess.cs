// Decompiled with JetBrains decompiler
// Type: FreeMap.State.Process.ContainerProcess
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace FreeMap.State.Process
{
  [Token(Token = "0x20017D1")]
  internal class ContainerProcess : FreeMapProcess
  {
    [Token(Token = "0x40068C5")]
    [FieldOffset(Offset = "0x38")]
    private List<FreeMapProcess> reqProcess;

    [Token(Token = "0x60086E7")]
    [Address(RVA = "0x43D0EF0", Offset = "0x43D0EF0", VA = "0x43D0EF0")]
    public ContainerProcess(FreeMapStateManager entity, params FreeMapProcess[] process)
    {
    }

    [Token(Token = "0x60086E8")]
    [Address(RVA = "0x43D2E5C", Offset = "0x43D2E5C", VA = "0x43D2E5C", Slot = "4")]
    public override void Begin()
    {
    }
  }
}
