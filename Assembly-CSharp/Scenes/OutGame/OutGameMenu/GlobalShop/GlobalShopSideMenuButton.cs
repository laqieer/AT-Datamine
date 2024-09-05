// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.GlobalShop.GlobalShopSideMenuButton
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using Network.Param;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.OutGameMenu.GlobalShop
{
  [Token(Token = "0x2003BA3")]
  public class GlobalShopSideMenuButton : MonoBehaviour
  {
    [Token(Token = "0x40107AF")]
    public const string TWEEN_IN_KEY = "SideMenu_In";
    [Token(Token = "0x40107B0")]
    public const string TWEEN_OUT_KEY = "SideMenu_Out";
    [Token(Token = "0x40107B1")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private RectTransform rectTransform;
    [Token(Token = "0x40107B2")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x40107B3")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Button button;
    [Token(Token = "0x40107B4")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text text;
    [Token(Token = "0x40107B5")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private RectTransform limitParent;
    [Token(Token = "0x40107B6")]
    [FieldOffset(Offset = "0x40")]
    private Text limitText;
    [Token(Token = "0x40107B8")]
    [FieldOffset(Offset = "0x50")]
    private DateTime? limitTime;

    [Token(Token = "0x17004C3F")]
    public RectTransform RectTransform
    {
      [Token(Token = "0x601772C"), Address(RVA = "0x2650D1C", Offset = "0x2650D1C", VA = "0x2650D1C")] get
      {
        return (RectTransform) null;
      }
    }

    [Token(Token = "0x17004C40")]
    public int Index
    {
      [Token(Token = "0x601772D"), Address(RVA = "0x2650D24", Offset = "0x2650D24", VA = "0x2650D24")] get
      {
        return new int();
      }
      [Token(Token = "0x601772E"), Address(RVA = "0x2650D2C", Offset = "0x2650D2C", VA = "0x2650D2C")] private set
      {
      }
    }

    [Token(Token = "0x601772F")]
    [Address(RVA = "0x2650D34", Offset = "0x2650D34", VA = "0x2650D34")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x6017730")]
    [Address(RVA = "0x2650D54", Offset = "0x2650D54", VA = "0x2650D54")]
    private void BadgeActive(bool isActive)
    {
    }

    [Token(Token = "0x6017731")]
    [Address(RVA = "0x2650DCC", Offset = "0x2650DCC", VA = "0x2650DCC")]
    public void UpdateBadgeIcon(ShopAPIManager shopAPI)
    {
    }

    [Token(Token = "0x6017732")]
    [Address(RVA = "0x2650F70", Offset = "0x2650F70", VA = "0x2650F70")]
    public void SetShopData(int index, GameObject limitObj, ShopAPIManager shopAPI)
    {
    }

    [Token(Token = "0x6017733")]
    [Address(RVA = "0x26510FC", Offset = "0x26510FC", VA = "0x26510FC")]
    private void SetUpdateButtonStatus(PlayerShopType shopType)
    {
    }

    [Token(Token = "0x6017734")]
    [Address(RVA = "0x26511B4", Offset = "0x26511B4", VA = "0x26511B4")]
    public void SetClickCallback(Action<int> onClickAction)
    {
    }

    [Token(Token = "0x6017735")]
    [Address(RVA = "0x26512A4", Offset = "0x26512A4", VA = "0x26512A4")]
    public void PlayToSlideAnim(bool isIn)
    {
    }

    [Token(Token = "0x6017736")]
    [Address(RVA = "0x265131C", Offset = "0x265131C", VA = "0x265131C")]
    private void Update()
    {
    }

    [Token(Token = "0x6017737")]
    [Address(RVA = "0x2651590", Offset = "0x2651590", VA = "0x2651590")]
    public GlobalShopSideMenuButton()
    {
    }
  }
}
