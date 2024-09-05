// Decompiled with JetBrains decompiler
// Type: Story.AdvPreLoadTask
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Story.Adv;
using System.Collections;

#nullable disable
namespace Story
{
  [Token(Token = "0x2000570")]
  public class AdvPreLoadTask : IContentTask
  {
    [Token(Token = "0x4001BF8")]
    [FieldOffset(Offset = "0x10")]
    private AdvPreLoadTask.IOwner owner;

    [Token(Token = "0x6001F62")]
    [Address(RVA = "0x2A02860", Offset = "0x2A02860", VA = "0x2A02860")]
    public AdvPreLoadTask(AdvPreLoadTask.IOwner owner)
    {
    }

    [Token(Token = "0x6001F63")]
    [Address(RVA = "0x2A03258", Offset = "0x2A03258", VA = "0x2A03258", Slot = "6")]
    private bool Story\u002EIContentTask\u002EIsBusy() => new bool();

    [Token(Token = "0x6001F64")]
    [Address(RVA = "0x2A03318", Offset = "0x2A03318", VA = "0x2A03318", Slot = "4")]
    private IEnumerator Story\u002EIContentTask\u002EStart() => (IEnumerator) null;

    [Token(Token = "0x6001F65")]
    [Address(RVA = "0x2A033A8", Offset = "0x2A033A8", VA = "0x2A033A8", Slot = "5")]
    private void Story\u002EIContentTask\u002EUpdate()
    {
    }

    [Token(Token = "0x2000571")]
    public interface IOwner
    {
      [Token(Token = "0x17000450")]
      IAdvDirection Direction { [Token(Token = "0x6001F66")] get; }

      [Token(Token = "0x17000451")]
      AdvStage AdvStage { [Token(Token = "0x6001F67")] get; [Token(Token = "0x6001F68")] set; }
    }
  }
}
