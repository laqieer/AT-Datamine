// Decompiled with JetBrains decompiler
// Type: Story.AdvPlayTask
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Story.Adv;
using System.Collections;

#nullable disable
namespace Story
{
  [Token(Token = "0x200056E")]
  public class AdvPlayTask : IContentTask
  {
    [Token(Token = "0x4001BF2")]
    [FieldOffset(Offset = "0x10")]
    private AdvStage advStage;
    [Token(Token = "0x4001BF3")]
    [FieldOffset(Offset = "0x18")]
    private IAdvDirection direction;
    [Token(Token = "0x4001BF4")]
    [FieldOffset(Offset = "0x20")]
    private bool isEnd;

    [Token(Token = "0x6001F58")]
    [Address(RVA = "0x29FDFE8", Offset = "0x29FDFE8", VA = "0x29FDFE8")]
    public AdvPlayTask(AdvStage advStage, IAdvDirection direction)
    {
    }

    [Token(Token = "0x6001F59")]
    [Address(RVA = "0x2A02F60", Offset = "0x2A02F60", VA = "0x2A02F60", Slot = "6")]
    public bool IsBusy() => new bool();

    [Token(Token = "0x6001F5A")]
    [Address(RVA = "0x29FE014", Offset = "0x29FE014", VA = "0x29FE014", Slot = "4")]
    public IEnumerator Start() => (IEnumerator) null;

    [Token(Token = "0x6001F5B")]
    [Address(RVA = "0x2A02F98", Offset = "0x2A02F98", VA = "0x2A02F98", Slot = "5")]
    private void Story\u002EIContentTask\u002EUpdate()
    {
    }
  }
}
