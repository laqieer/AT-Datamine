// Decompiled with JetBrains decompiler
// Type: Story.ShowLoadingPanel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;

#nullable disable
namespace Story
{
  [Token(Token = "0x20005AB")]
  public class ShowLoadingPanel : IContentTask
  {
    [Token(Token = "0x4001C7B")]
    [FieldOffset(Offset = "0x10")]
    private bool busy;

    [Token(Token = "0x60020AC")]
    [Address(RVA = "0x2D92E74", Offset = "0x2D92E74", VA = "0x2D92E74", Slot = "6")]
    public bool IsBusy() => new bool();

    [Token(Token = "0x60020AD")]
    [Address(RVA = "0x2D92E7C", Offset = "0x2D92E7C", VA = "0x2D92E7C", Slot = "4")]
    public IEnumerator Start() => (IEnumerator) null;

    [Token(Token = "0x60020AE")]
    [Address(RVA = "0x2D92F0C", Offset = "0x2D92F0C", VA = "0x2D92F0C", Slot = "5")]
    public void Update()
    {
    }

    [Token(Token = "0x60020AF")]
    [Address(RVA = "0x2D92F10", Offset = "0x2D92F10", VA = "0x2D92F10")]
    public ShowLoadingPanel()
    {
    }
  }
}
