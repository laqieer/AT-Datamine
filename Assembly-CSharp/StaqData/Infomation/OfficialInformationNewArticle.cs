// Decompiled with JetBrains decompiler
// Type: StaqData.Infomation.OfficialInformationNewArticle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using System.Collections.Generic;

#nullable disable
namespace StaqData.Infomation
{
  [Token(Token = "0x20021B4")]
  public class OfficialInformationNewArticle
  {
    [Token(Token = "0x17002CE9")]
    public List<OfficialInformationArticleType> OfficialInfoArticles
    {
      [Token(Token = "0x600CDE5"), Address(RVA = "0x4B60218", Offset = "0x4B60218", VA = "0x4B60218")] get
      {
        return (List<OfficialInformationArticleType>) null;
      }
      [Token(Token = "0x600CDE6"), Address(RVA = "0x4B60220", Offset = "0x4B60220", VA = "0x4B60220")] private set
      {
      }
    }

    [Token(Token = "0x17002CEA")]
    public bool DisplayedNewArticle
    {
      [Token(Token = "0x600CDE7"), Address(RVA = "0x4B60228", Offset = "0x4B60228", VA = "0x4B60228")] get
      {
        return new bool();
      }
      [Token(Token = "0x600CDE8"), Address(RVA = "0x4B60230", Offset = "0x4B60230", VA = "0x4B60230")] private set
      {
      }
    }

    [Token(Token = "0x600CDE9")]
    [Address(RVA = "0x4B6023C", Offset = "0x4B6023C", VA = "0x4B6023C")]
    public void UpdateOfficialInfoArticles(
      List<OfficialInformationArticleType> officialInfoArticles)
    {
    }

    [Token(Token = "0x600CDEA")]
    [Address(RVA = "0x4B60394", Offset = "0x4B60394", VA = "0x4B60394")]
    public void SetDisplayed()
    {
    }

    [Token(Token = "0x600CDEB")]
    [Address(RVA = "0x4B603A0", Offset = "0x4B603A0", VA = "0x4B603A0")]
    public OfficialInformationNewArticle()
    {
    }
  }
}
