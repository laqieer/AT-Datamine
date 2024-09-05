// Decompiled with JetBrains decompiler
// Type: Story.ContentFreeMap
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.State;
using Il2CppDummyDll;
using System.Collections;

#nullable disable
namespace Story
{
  [Token(Token = "0x2000554")]
  public sealed class ContentFreeMap : Content
  {
    [Token(Token = "0x4001BC6")]
    [FieldOffset(Offset = "0x20")]
    private FreeMapStateManager freemapStateManager;
    [Token(Token = "0x4001BC7")]
    [FieldOffset(Offset = "0x28")]
    private IFreeMapDirection direction;

    [Token(Token = "0x6001ED6")]
    [Address(RVA = "0x2A004EC", Offset = "0x2A004EC", VA = "0x2A004EC")]
    public ContentFreeMap(IFreeMapDirection direction)
    {
    }

    [Token(Token = "0x6001ED7")]
    [Address(RVA = "0x2A00514", Offset = "0x2A00514", VA = "0x2A00514", Slot = "4")]
    protected override void OnStart()
    {
    }

    [Token(Token = "0x6001ED8")]
    [Address(RVA = "0x2A00770", Offset = "0x2A00770", VA = "0x2A00770")]
    private void End()
    {
    }

    [Token(Token = "0x6001ED9")]
    [Address(RVA = "0x2A00858", Offset = "0x2A00858", VA = "0x2A00858")]
    private void OnChangedSequence(int _)
    {
    }

    [Token(Token = "0x6001EDA")]
    [Address(RVA = "0x2A0085C", Offset = "0x2A0085C", VA = "0x2A0085C", Slot = "5")]
    protected override void OnUpdate()
    {
    }

    [Token(Token = "0x6001EDB")]
    [Address(RVA = "0x2A008A0", Offset = "0x2A008A0", VA = "0x2A008A0", Slot = "6")]
    protected override void OnAbort()
    {
    }

    [Token(Token = "0x2000555")]
    public class PreLoad : IContentTask
    {
      [Token(Token = "0x4001BC8")]
      [FieldOffset(Offset = "0x10")]
      private ContentFreeMap entity;
      [Token(Token = "0x4001BC9")]
      [FieldOffset(Offset = "0x18")]
      private bool finished;

      [Token(Token = "0x6001EDC")]
      [Address(RVA = "0x2A008C4", Offset = "0x2A008C4", VA = "0x2A008C4")]
      public PreLoad(ContentFreeMap entity)
      {
      }

      [Token(Token = "0x6001EDD")]
      [Address(RVA = "0x2A008EC", Offset = "0x2A008EC", VA = "0x2A008EC", Slot = "6")]
      private bool Story\u002EIContentTask\u002EIsBusy() => new bool();

      [Token(Token = "0x6001EDE")]
      [Address(RVA = "0x2A008FC", Offset = "0x2A008FC", VA = "0x2A008FC", Slot = "4")]
      private IEnumerator Story\u002EIContentTask\u002EStart() => (IEnumerator) null;

      [Token(Token = "0x6001EDF")]
      [Address(RVA = "0x2A0098C", Offset = "0x2A0098C", VA = "0x2A0098C", Slot = "5")]
      private void Story\u002EIContentTask\u002EUpdate()
      {
      }
    }
  }
}
