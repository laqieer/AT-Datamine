// Decompiled with JetBrains decompiler
// Type: Story.ContentAreaEventFreeMap
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.State;
using Il2CppDummyDll;
using System.Collections;

#nullable disable
namespace Story
{
  [Token(Token = "0x2000548")]
  public sealed class ContentAreaEventFreeMap : Content
  {
    [Token(Token = "0x4001BA6")]
    [FieldOffset(Offset = "0x20")]
    private IFreeMapDirection direction;
    [Token(Token = "0x4001BA7")]
    [FieldOffset(Offset = "0x28")]
    private FreeMapStateManager freemapStateManager;

    [Token(Token = "0x6001E99")]
    [Address(RVA = "0x29FE300", Offset = "0x29FE300", VA = "0x29FE300")]
    public ContentAreaEventFreeMap(IFreeMapDirection direction)
    {
    }

    [Token(Token = "0x6001E9A")]
    [Address(RVA = "0x29FE328", Offset = "0x29FE328", VA = "0x29FE328", Slot = "4")]
    protected override void OnStart()
    {
    }

    [Token(Token = "0x6001E9B")]
    [Address(RVA = "0x29FE750", Offset = "0x29FE750", VA = "0x29FE750")]
    private void End()
    {
    }

    [Token(Token = "0x6001E9C")]
    [Address(RVA = "0x29FE7F8", Offset = "0x29FE7F8", VA = "0x29FE7F8")]
    private void OnChangedSequence(int sequenceID)
    {
    }

    [Token(Token = "0x6001E9D")]
    [Address(RVA = "0x29FE7FC", Offset = "0x29FE7FC", VA = "0x29FE7FC", Slot = "5")]
    protected override void OnUpdate()
    {
    }

    [Token(Token = "0x6001E9E")]
    [Address(RVA = "0x29FE840", Offset = "0x29FE840", VA = "0x29FE840", Slot = "6")]
    protected override void OnAbort()
    {
    }

    [Token(Token = "0x2000549")]
    public class PreLoad : IContentTask
    {
      [Token(Token = "0x4001BA8")]
      [FieldOffset(Offset = "0x10")]
      private ContentAreaEventFreeMap entity;
      [Token(Token = "0x4001BA9")]
      [FieldOffset(Offset = "0x18")]
      private bool finished;

      [Token(Token = "0x6001E9F")]
      [Address(RVA = "0x29FE864", Offset = "0x29FE864", VA = "0x29FE864")]
      public PreLoad(ContentAreaEventFreeMap entity)
      {
      }

      [Token(Token = "0x6001EA0")]
      [Address(RVA = "0x29FE88C", Offset = "0x29FE88C", VA = "0x29FE88C", Slot = "6")]
      private bool Story\u002EIContentTask\u002EIsBusy() => new bool();

      [Token(Token = "0x6001EA1")]
      [Address(RVA = "0x29FE89C", Offset = "0x29FE89C", VA = "0x29FE89C", Slot = "4")]
      private IEnumerator Story\u002EIContentTask\u002EStart() => (IEnumerator) null;

      [Token(Token = "0x6001EA2")]
      [Address(RVA = "0x29FE92C", Offset = "0x29FE92C", VA = "0x29FE92C", Slot = "5")]
      private void Story\u002EIContentTask\u002EUpdate()
      {
      }
    }
  }
}
