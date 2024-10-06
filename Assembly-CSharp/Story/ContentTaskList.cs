// Decompiled with JetBrains decompiler
// Type: Story.ContentTaskList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace Story
{
  [Token(Token = "0x2000573")]
  public class ContentTaskList : IContentTaskHandler, IContentTask
  {
    [Token(Token = "0x4001BFC")]
    [FieldOffset(Offset = "0x10")]
    private List<IContentTask> tasks;
    [Token(Token = "0x4001BFD")]
    [FieldOffset(Offset = "0x18")]
    private ContentTaskList updator;

    [Token(Token = "0x6001F6F")]
    [Address(RVA = "0x2A01B70", Offset = "0x2A01B70", VA = "0x2A01B70", Slot = "4")]
    public void Add(IContentTask task)
    {
    }

    [Token(Token = "0x6001F70")]
    [Address(RVA = "0x2A0359C", Offset = "0x2A0359C", VA = "0x2A0359C", Slot = "5")]
    public void Clear()
    {
    }

    [Token(Token = "0x6001F71")]
    [Address(RVA = "0x2A0360C", Offset = "0x2A0360C", VA = "0x2A0360C", Slot = "11")]
    public bool IsBusy() => new bool();

    [Token(Token = "0x6001F72")]
    [Address(RVA = "0x2A03708", Offset = "0x2A03708", VA = "0x2A03708", Slot = "9")]
    private IEnumerator Story\u002EIContentTask\u002EStart() => (IEnumerator) null;

    [Token(Token = "0x6001F73")]
    [Address(RVA = "0x2A03798", Offset = "0x2A03798", VA = "0x2A03798", Slot = "6")]
    public void Start()
    {
    }

    [Token(Token = "0x6001F74")]
    [Address(RVA = "0x2A03A28", Offset = "0x2A03A28", VA = "0x2A03A28", Slot = "10")]
    public void Update()
    {
    }

    [Token(Token = "0x6001F75")]
    [Address(RVA = "0x2A03A38", Offset = "0x2A03A38", VA = "0x2A03A38")]
    private void UpdateInternal()
    {
    }

    [Token(Token = "0x6001F76")]
    [Address(RVA = "0x2A03C70", Offset = "0x2A03C70", VA = "0x2A03C70", Slot = "3")]
    public override string ToString() => (string) null;

    [Token(Token = "0x6001F77")]
    [Address(RVA = "0x2A01A70", Offset = "0x2A01A70", VA = "0x2A01A70")]
    public ContentTaskList()
    {
    }
  }
}
