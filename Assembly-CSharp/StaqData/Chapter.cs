// Decompiled with JetBrains decompiler
// Type: StaqData.Chapter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x20020DD")]
  public class Chapter
  {
    [Token(Token = "0x17002AD0")]
    public int ChapterID
    {
      [Token(Token = "0x600C718"), Address(RVA = "0x1CDC618", Offset = "0x1CDC618", VA = "0x1CDC618")] get
      {
        return new int();
      }
      [Token(Token = "0x600C719"), Address(RVA = "0x1CDC620", Offset = "0x1CDC620", VA = "0x1CDC620")] private set
      {
      }
    }

    [Token(Token = "0x17002AD1")]
    public int LoopCount
    {
      [Token(Token = "0x600C71A"), Address(RVA = "0x1CDC628", Offset = "0x1CDC628", VA = "0x1CDC628")] get
      {
        return new int();
      }
      [Token(Token = "0x600C71B"), Address(RVA = "0x1CDC630", Offset = "0x1CDC630", VA = "0x1CDC630")] private set
      {
      }
    }

    [Token(Token = "0x600C71C")]
    [Address(RVA = "0x1CDC0B0", Offset = "0x1CDC0B0", VA = "0x1CDC0B0")]
    public Chapter()
    {
    }

    [Token(Token = "0x600C71D")]
    [Address(RVA = "0x1CDA3C8", Offset = "0x1CDA3C8", VA = "0x1CDA3C8")]
    public Chapter(int chapterID)
    {
    }

    [Token(Token = "0x600C71E")]
    [Address(RVA = "0x1CDC0B8", Offset = "0x1CDC0B8", VA = "0x1CDC0B8")]
    public void Apply(PlayerStoryChapterType entity)
    {
    }
  }
}
