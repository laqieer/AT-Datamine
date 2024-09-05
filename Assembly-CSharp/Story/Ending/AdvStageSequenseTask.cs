// Decompiled with JetBrains decompiler
// Type: Story.Ending.AdvStageSequenseTask
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Story.Adv;
using System.Collections;

#nullable disable
namespace Story.Ending
{
  [Token(Token = "0x2000610")]
  public class AdvStageSequenseTask : SequenseTaskBase
  {
    [Token(Token = "0x4001DC4")]
    [FieldOffset(Offset = "0x14")]
    private bool isEnded;
    [Token(Token = "0x4001DC5")]
    [FieldOffset(Offset = "0x18")]
    private AdvStage advStage;

    [Token(Token = "0x170004FE")]
    private int AdvID
    {
      [Token(Token = "0x6002313"), Address(RVA = "0x2DA35E4", Offset = "0x2DA35E4", VA = "0x2DA35E4")] get
      {
        return new int();
      }
      [Token(Token = "0x6002314"), Address(RVA = "0x2DA35EC", Offset = "0x2DA35EC", VA = "0x2DA35EC")] set
      {
      }
    }

    [Token(Token = "0x6002315")]
    [Address(RVA = "0x2DA35F4", Offset = "0x2DA35F4", VA = "0x2DA35F4")]
    public AdvStageSequenseTask(int advID)
    {
    }

    [Token(Token = "0x6002316")]
    [Address(RVA = "0x2DA361C", Offset = "0x2DA361C", VA = "0x2DA361C", Slot = "4")]
    public override void Start()
    {
    }

    [Token(Token = "0x6002317")]
    [Address(RVA = "0x2DA3718", Offset = "0x2DA3718", VA = "0x2DA3718", Slot = "6")]
    public override bool IsEnded() => new bool();

    [Token(Token = "0x6002318")]
    [Address(RVA = "0x2DA36B0", Offset = "0x2DA36B0", VA = "0x2DA36B0")]
    private IEnumerator Process() => (IEnumerator) null;

    [Token(Token = "0x6002319")]
    [Address(RVA = "0x2DA3748", Offset = "0x2DA3748", VA = "0x2DA3748")]
    private IEnumerator AdvStageSequence() => (IEnumerator) null;
  }
}
