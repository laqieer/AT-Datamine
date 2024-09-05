// Decompiled with JetBrains decompiler
// Type: Home.Bannner.HomeBannerListItemBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Home.Bannner
{
  [Token(Token = "0x2000B82")]
  internal class HomeBannerListItemBase
  {
    [Token(Token = "0x400346B")]
    [FieldOffset(Offset = "0x10")]
    private Action<HomeBannerUIParameter> onBannerClicked;

    [Token(Token = "0x17000983")]
    private HomeBannerUIParameter parameter
    {
      [Token(Token = "0x600417E"), Address(RVA = "0x2A302B8", Offset = "0x2A302B8", VA = "0x2A302B8")] get
      {
        return (HomeBannerUIParameter) null;
      }
      [Token(Token = "0x600417F"), Address(RVA = "0x2A302C0", Offset = "0x2A302C0", VA = "0x2A302C0")] set
      {
      }
    }

    [Token(Token = "0x6004180")]
    [Address(RVA = "0x2A30188", Offset = "0x2A30188", VA = "0x2A30188")]
    public HomeBannerListItemBase(
      HomeBannerUIParameter parameter,
      Action<HomeBannerUIParameter> onBannerClicked)
    {
    }

    [Token(Token = "0x6004181")]
    [Address(RVA = "0x2A300BC", Offset = "0x2A300BC", VA = "0x2A300BC")]
    public void SetupBannerView(HomeBannerListItemView homeBannerView)
    {
    }

    [Token(Token = "0x6004182")]
    [Address(RVA = "0x2A30314", Offset = "0x2A30314", VA = "0x2A30314")]
    private void OnClickBanner()
    {
    }

    [Token(Token = "0x6004183")]
    [Address(RVA = "0x2A2FFE0", Offset = "0x2A2FFE0", VA = "0x2A2FFE0")]
    public void Release()
    {
    }
  }
}
