// Decompiled with JetBrains decompiler
// Type: Gacha.GachaListItemView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Gacha
{
  [Token(Token = "0x2001504")]
  internal class GachaListItemView : InfiniteCellBase
  {
    [Token(Token = "0x4006083")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x4006084")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Button buttonBanner;
    [Token(Token = "0x4006085")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private RawImage imageBanner;
    [Token(Token = "0x4006086")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Text textButtonName;
    [Token(Token = "0x4006087")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private RectTransform parentLimitTime;
    [Token(Token = "0x4006088")]
    [FieldOffset(Offset = "0x50")]
    private GachaScheduleView gachaScheduleView;
    [Token(Token = "0x4006089")]
    [FieldOffset(Offset = "0x58")]
    private int index;
    [Token(Token = "0x400608A")]
    [FieldOffset(Offset = "0x60")]
    public Action<int, GachaListItemView> OnUpdateListItem;
    [Token(Token = "0x400608B")]
    [FieldOffset(Offset = "0x68")]
    public Action<int, GachaListItemView> OnClickListItem;

    [Token(Token = "0x60076DE")]
    [Address(RVA = "0x44ED278", Offset = "0x44ED278", VA = "0x44ED278")]
    public static InfiniteCellData CreateCellData(
      Vector2 size,
      Action<int, GachaListItemView> onUpdateListItem,
      Action<int, GachaListItemView> onClickListItem)
    {
      return (InfiniteCellData) null;
    }

    [Token(Token = "0x60076DF")]
    [Address(RVA = "0x44ED338", Offset = "0x44ED338", VA = "0x44ED338")]
    private void Awake()
    {
    }

    [Token(Token = "0x60076E0")]
    [Address(RVA = "0x44ED3CC", Offset = "0x44ED3CC", VA = "0x44ED3CC")]
    public void SetIndex(int index)
    {
    }

    [Token(Token = "0x60076E1")]
    [Address(RVA = "0x44ED3D4", Offset = "0x44ED3D4", VA = "0x44ED3D4")]
    private void OnDisable()
    {
    }

    [Token(Token = "0x60076E2")]
    [Address(RVA = "0x44ED210", Offset = "0x44ED210", VA = "0x44ED210")]
    public void SetBannerTexture(Texture texture)
    {
    }

    [Token(Token = "0x60076E3")]
    [Address(RVA = "0x44ECE00", Offset = "0x44ECE00", VA = "0x44ECE00")]
    public void SetBadgeEnable(bool enable)
    {
    }

    [Token(Token = "0x60076E4")]
    [Address(RVA = "0x44ED3EC", Offset = "0x44ED3EC", VA = "0x44ED3EC", Slot = "4")]
    public override void OnUpdate()
    {
    }

    [Token(Token = "0x60076E5")]
    [Address(RVA = "0x44ED02C", Offset = "0x44ED02C", VA = "0x44ED02C")]
    public void AssignScheduleView(GameObject view)
    {
    }

    [Token(Token = "0x60076E6")]
    [Address(RVA = "0x44ED4A4", Offset = "0x44ED4A4", VA = "0x44ED4A4")]
    public void SetRemainingCountDown(DateTime endAt)
    {
    }

    [Token(Token = "0x60076E7")]
    [Address(RVA = "0x44ED14C", Offset = "0x44ED14C", VA = "0x44ED14C")]
    public void SetRemainingTime(TimeSpan remainingTime)
    {
    }

    [Token(Token = "0x60076E8")]
    [Address(RVA = "0x44ECF80", Offset = "0x44ECF80", VA = "0x44ECF80")]
    public void SetRemainingTimeActive(bool isActive)
    {
    }

    [Token(Token = "0x60076E9")]
    [Address(RVA = "0x44ED53C", Offset = "0x44ED53C", VA = "0x44ED53C")]
    public GachaListItemView()
    {
    }

    [Token(Token = "0x2001505")]
    public class Parameter
    {
      [Token(Token = "0x400608C")]
      [FieldOffset(Offset = "0x10")]
      public Action<int, GachaListItemView> OnUpdate;
      [Token(Token = "0x400608D")]
      [FieldOffset(Offset = "0x18")]
      public Action<int, GachaListItemView> OnClick;

      [Token(Token = "0x60076EB")]
      [Address(RVA = "0x44ED330", Offset = "0x44ED330", VA = "0x44ED330")]
      public Parameter()
      {
      }
    }
  }
}
