// Decompiled with JetBrains decompiler
// Type: Story.BranchDownloadTask
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;

#nullable disable
namespace Story
{
  [Token(Token = "0x20005AD")]
  public class BranchDownloadTask : IContentTask
  {
    [Token(Token = "0x4001C7F")]
    [FieldOffset(Offset = "0x10")]
    private bool downloaded;

    [Token(Token = "0x60020B6")]
    [Address(RVA = "0x2D9304C", Offset = "0x2D9304C", VA = "0x2D9304C", Slot = "6")]
    public bool IsBusy() => new bool();

    [Token(Token = "0x60020B7")]
    [Address(RVA = "0x2D9305C", Offset = "0x2D9305C", VA = "0x2D9305C", Slot = "4")]
    public IEnumerator Start() => (IEnumerator) null;

    [Token(Token = "0x60020B8")]
    [Address(RVA = "0x2D930EC", Offset = "0x2D930EC", VA = "0x2D930EC")]
    private IEnumerator OpenDownloadedDialog() => (IEnumerator) null;

    [Token(Token = "0x60020B9")]
    [Address(RVA = "0x2D93174", Offset = "0x2D93174", VA = "0x2D93174", Slot = "5")]
    public void Update()
    {
    }

    [Token(Token = "0x60020BA")]
    [Address(RVA = "0x2D93178", Offset = "0x2D93178", VA = "0x2D93178")]
    private void ReturnTitleScene()
    {
    }

    [Token(Token = "0x60020BB")]
    [Address(RVA = "0x2D93380", Offset = "0x2D93380", VA = "0x2D93380")]
    public BranchDownloadTask()
    {
    }
  }
}
