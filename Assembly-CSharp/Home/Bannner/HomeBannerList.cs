// Decompiled with JetBrains decompiler
// Type: Home.Bannner.HomeBannerList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Home.Bannner
{
  [Token(Token = "0x2000B81")]
  internal class HomeBannerList
  {
    [Token(Token = "0x4003468")]
    [FieldOffset(Offset = "0x10")]
    private List<HomeBannerListItemBase> banners;
    [Token(Token = "0x4003469")]
    [FieldOffset(Offset = "0x18")]
    private HomeTransitionContoller transitionContoller;
    [Token(Token = "0x400346A")]
    [FieldOffset(Offset = "0x20")]
    private HomeBannerListView view;

    [Token(Token = "0x6004171")]
    [Address(RVA = "0x2A2F89C", Offset = "0x2A2F89C", VA = "0x2A2F89C")]
    public void Setup(
      HomeBannerListView homeBannerListView,
      List<HomeBannerUIParameter> parameters,
      HomeTransitionContoller transitionContoller)
    {
    }

    [Token(Token = "0x6004172")]
    [Address(RVA = "0x2A2F620", Offset = "0x2A2F620", VA = "0x2A2F620")]
    public void Release()
    {
    }

    [Token(Token = "0x6004173")]
    [Address(RVA = "0x2A30018", Offset = "0x2A30018", VA = "0x2A30018")]
    private void OnUpdateListItemView(int index, HomeBannerListItemView view)
    {
    }

    [Token(Token = "0x6004174")]
    [Address(RVA = "0x2A2FCFC", Offset = "0x2A2FCFC", VA = "0x2A2FCFC")]
    private HomeBannerListItemBase CreateBanner(HomeBannerUIParameter parameter)
    {
      return (HomeBannerListItemBase) null;
    }

    [Token(Token = "0x6004175")]
    [Address(RVA = "0x2A2F820", Offset = "0x2A2F820", VA = "0x2A2F820")]
    public HomeBannerList()
    {
    }
  }
}
