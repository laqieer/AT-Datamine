// Decompiled with JetBrains decompiler
// Type: StaqData.Infomation.OfficialMessageArticle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using System.Collections.Generic;

#nullable disable
namespace StaqData.Infomation
{
  [Token(Token = "0x20021B6")]
  public class OfficialMessageArticle
  {
    [Token(Token = "0x4008EDA")]
    [FieldOffset(Offset = "0x10")]
    private List<OfficialMessageArticleType> officialMessageArticles;
    [Token(Token = "0x4008EDB")]
    [FieldOffset(Offset = "0x18")]
    private bool[] isReadFlags;

    [Token(Token = "0x17002CEB")]
    public List<OfficialMessageArticleType> OfficialMessageArticles
    {
      [Token(Token = "0x600CDEF"), Address(RVA = "0x4B604A0", Offset = "0x4B604A0", VA = "0x4B604A0")] get
      {
        return (List<OfficialMessageArticleType>) null;
      }
    }

    [Token(Token = "0x600CDF0")]
    [Address(RVA = "0x4B604A8", Offset = "0x4B604A8", VA = "0x4B604A8")]
    public void Initialize(
      List<OfficialMessageArticleType> officialMessageArticles)
    {
    }

    [Token(Token = "0x600CDF1")]
    [Address(RVA = "0x4B605A4", Offset = "0x4B605A4", VA = "0x4B605A4")]
    public void SetReadFlag(int index, bool isRead)
    {
    }

    [Token(Token = "0x600CDF2")]
    [Address(RVA = "0x4B605D8", Offset = "0x4B605D8", VA = "0x4B605D8")]
    public void SetReadFlagId(int id, bool isRead)
    {
    }

    [Token(Token = "0x600CDF3")]
    [Address(RVA = "0x4B606A4", Offset = "0x4B606A4", VA = "0x4B606A4")]
    public bool GetReadFlag(int index) => new bool();

    [Token(Token = "0x600CDF4")]
    [Address(RVA = "0x4B606D4", Offset = "0x4B606D4", VA = "0x4B606D4")]
    public bool GetReadFlagId(int id) => new bool();

    [Token(Token = "0x600CDF5")]
    [Address(RVA = "0x4B607A0", Offset = "0x4B607A0", VA = "0x4B607A0")]
    public bool GetReadFlagAll() => new bool();

    [Token(Token = "0x600CDF6")]
    [Address(RVA = "0x4B607F4", Offset = "0x4B607F4", VA = "0x4B607F4")]
    public OfficialMessageArticle()
    {
    }
  }
}
