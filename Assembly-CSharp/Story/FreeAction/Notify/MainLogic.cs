// Decompiled with JetBrains decompiler
// Type: Story.FreeAction.Notify.MainLogic
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace Story.FreeAction.Notify
{
  [Token(Token = "0x2000699")]
  public class MainLogic
  {
    [Token(Token = "0x4001FB2")]
    [FieldOffset(Offset = "0x10")]
    private Sort alignment;
    [Token(Token = "0x4001FB3")]
    [FieldOffset(Offset = "0x18")]
    private List<Element> notifyElements;

    [Token(Token = "0x17000583")]
    public bool IsEnded
    {
      [Token(Token = "0x6002587"), Address(RVA = "0x2F3B614", Offset = "0x2F3B614", VA = "0x2F3B614")] get
      {
        return new bool();
      }
      [Token(Token = "0x6002588"), Address(RVA = "0x2F3B61C", Offset = "0x2F3B61C", VA = "0x2F3B61C")] private set
      {
      }
    }

    [Token(Token = "0x6002589")]
    [Address(RVA = "0x2F3B628", Offset = "0x2F3B628", VA = "0x2F3B628")]
    public void RegisterAndPlay(IEnumerable<Element> elements)
    {
    }

    [Token(Token = "0x600258A")]
    [Address(RVA = "0x2F3B894", Offset = "0x2F3B894", VA = "0x2F3B894")]
    private IEnumerator UpdateNotify() => (IEnumerator) null;

    [Token(Token = "0x600258B")]
    [Address(RVA = "0x2F3B924", Offset = "0x2F3B924", VA = "0x2F3B924")]
    public MainLogic()
    {
    }
  }
}
