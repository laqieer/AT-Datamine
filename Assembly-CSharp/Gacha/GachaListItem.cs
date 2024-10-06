// Decompiled with JetBrains decompiler
// Type: Gacha.GachaListItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData;
using System;
using UnityEngine;

#nullable disable
namespace Gacha
{
  [Token(Token = "0x2001502")]
  internal class GachaListItem
  {
    [Token(Token = "0x400607B")]
    [FieldOffset(Offset = "0x10")]
    private readonly DateTime endAt;
    [Token(Token = "0x400607C")]
    [FieldOffset(Offset = "0x18")]
    private readonly int number;
    [Token(Token = "0x400607D")]
    [FieldOffset(Offset = "0x20")]
    public readonly string GachaName;
    [Token(Token = "0x400607E")]
    [FieldOffset(Offset = "0x28")]
    private GameObject gachaScheduleView;
    [Token(Token = "0x400607F")]
    [FieldOffset(Offset = "0x30")]
    private GachaResourceProvider resourceProvider;
    [Token(Token = "0x4006080")]
    [FieldOffset(Offset = "0x38")]
    private bool seeForTheFirstTime;
    [Token(Token = "0x4006081")]
    [FieldOffset(Offset = "0x39")]
    private bool hasAnyServerBadge;

    [Token(Token = "0x1700125C")]
    private bool isBadgeEnable
    {
      [Token(Token = "0x60076D8"), Address(RVA = "0x44ECDD8", Offset = "0x44ECDD8", VA = "0x44ECDD8")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x60076D9")]
    [Address(RVA = "0x44EC640", Offset = "0x44EC640", VA = "0x44EC640")]
    public GachaListItem(
      GachaListItemInfo gachaListItemInfo,
      GameObject gachaScheduleView,
      GachaResourceProvider resourceProvider,
      bool seeForTheFirstTime)
    {
    }

    [Token(Token = "0x60076DA")]
    [Address(RVA = "0x44EC868", Offset = "0x44EC868", VA = "0x44EC868")]
    public void SetupBannerView(GachaListItemView view, bool isSelected)
    {
    }

    [Token(Token = "0x60076DB")]
    [Address(RVA = "0x44ED1E4", Offset = "0x44ED1E4", VA = "0x44ED1E4")]
    public void SetSeeForTheFirstTime(bool value)
    {
    }
  }
}
