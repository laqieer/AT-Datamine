// Decompiled with JetBrains decompiler
// Type: StaqData.ChapterItemInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using System.Collections.Generic;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x200209C")]
  public class ChapterItemInfo
  {
    [Token(Token = "0x4008AA2")]
    [FieldOffset(Offset = "0x10")]
    private Dictionary<int, ChapterItem> playerChapterItemInfo;
    [Token(Token = "0x4008AA3")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, ChapterItem> prevPlayerChapterItemInfo;

    [Token(Token = "0x17002A25")]
    public IEnumerable<ChapterItem> Items
    {
      [Token(Token = "0x600C536"), Address(RVA = "0x1A008C0", Offset = "0x1A008C0", VA = "0x1A008C0")] get
      {
        return (IEnumerable<ChapterItem>) null;
      }
    }

    [Token(Token = "0x600C537")]
    [Address(RVA = "0x19F8FD4", Offset = "0x19F8FD4", VA = "0x19F8FD4")]
    public void Apply(
      IReadOnlyList<PlayerStoryChapterItemType> entityList)
    {
    }

    [Token(Token = "0x600C538")]
    [Address(RVA = "0x1A009E8", Offset = "0x1A009E8", VA = "0x1A009E8")]
    public void ApplyToPrevData(
      IReadOnlyList<PlayerStoryChapterItemType> entityList)
    {
    }

    [Token(Token = "0x600C539")]
    [Address(RVA = "0x1A00DE4", Offset = "0x1A00DE4", VA = "0x1A00DE4")]
    public void Apply(
      IReadOnlyList<RewardGiveResultEntityType> entityList)
    {
    }

    [Token(Token = "0x600C53A")]
    [Address(RVA = "0x19FF5B0", Offset = "0x19FF5B0", VA = "0x19FF5B0")]
    public ChapterItem Get(int id) => (ChapterItem) null;

    [Token(Token = "0x600C53B")]
    [Address(RVA = "0x19FC4C8", Offset = "0x19FC4C8", VA = "0x19FC4C8")]
    public bool TryGetChapterItemCount(int itemID, out int itemCount, bool isPrevData = false)
    {
      return new bool();
    }

    [Token(Token = "0x600C53C")]
    [Address(RVA = "0x1A01498", Offset = "0x1A01498", VA = "0x1A01498")]
    private bool TryGetChapterItemCount(int itemID, out int itemCount) => new bool();

    [Token(Token = "0x600C53D")]
    [Address(RVA = "0x1A013EC", Offset = "0x1A013EC", VA = "0x1A013EC")]
    private bool TryGetPrevChapterItemCount(int itemID, out int itemCount) => new bool();

    [Token(Token = "0x600C53E")]
    [Address(RVA = "0x1A01544", Offset = "0x1A01544", VA = "0x1A01544")]
    public ChapterItemInfo()
    {
    }
  }
}
