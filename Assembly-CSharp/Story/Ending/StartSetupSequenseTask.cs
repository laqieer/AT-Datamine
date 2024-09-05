// Decompiled with JetBrains decompiler
// Type: Story.Ending.StartSetupSequenseTask
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;

#nullable disable
namespace Story.Ending
{
  [Token(Token = "0x200060E")]
  public class StartSetupSequenseTask : SequenseTaskBase
  {
    [Token(Token = "0x4001DBF")]
    [FieldOffset(Offset = "0x10")]
    private bool isEnded;

    [Token(Token = "0x6002309")]
    [Address(RVA = "0x2DA3390", Offset = "0x2DA3390", VA = "0x2DA3390", Slot = "4")]
    public override void Start()
    {
    }

    [Token(Token = "0x600230A")]
    [Address(RVA = "0x2DA3424", Offset = "0x2DA3424", VA = "0x2DA3424")]
    private IEnumerator SetupSequence() => (IEnumerator) null;

    [Token(Token = "0x600230B")]
    [Address(RVA = "0x2DA34B4", Offset = "0x2DA34B4", VA = "0x2DA34B4", Slot = "6")]
    public override bool IsEnded() => new bool();

    [Token(Token = "0x600230C")]
    [Address(RVA = "0x2DA34BC", Offset = "0x2DA34BC", VA = "0x2DA34BC")]
    public StartSetupSequenseTask()
    {
    }
  }
}
