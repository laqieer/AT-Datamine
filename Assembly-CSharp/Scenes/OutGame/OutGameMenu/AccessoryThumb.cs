// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.AccessoryThumb
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.OutGameMenu
{
  [Token(Token = "0x2003985")]
  public class AccessoryThumb : InfiniteCellBase
  {
    [Token(Token = "0x400FB50")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x400FB51")]
    [FieldOffset(Offset = "0x30")]
    private readonly string[][] iconTweenName;
    [Token(Token = "0x400FB52")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private LongPressButton longPressButton;
    [Token(Token = "0x400FB53")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Image thumbnailImage;
    [Token(Token = "0x400FB54")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Image thumbnailImageLoadingIcon;
    [Token(Token = "0x400FB55")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private Image rarityBaseImage;
    [Token(Token = "0x400FB56")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private Image rarityImage;
    [Token(Token = "0x400FB57")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private GameObject newBadge;
    [Token(Token = "0x400FB58")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private Image FavoriteIconImage;
    [Token(Token = "0x400FB59")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private Image SelectedImage;
    [Token(Token = "0x400FB5A")]
    [FieldOffset(Offset = "0x78")]
    public bool enable;

    [Token(Token = "0x17004A77")]
    public LongPressButton thumbnailButton
    {
      [Token(Token = "0x60169B6"), Address(RVA = "0x42F3C2C", Offset = "0x42F3C2C", VA = "0x42F3C2C")] get
      {
        return (LongPressButton) null;
      }
    }

    [Token(Token = "0x17004A78")]
    private AccessoryThumbResource Resource
    {
      [Token(Token = "0x60169B7"), Address(RVA = "0x42F3C34", Offset = "0x42F3C34", VA = "0x42F3C34")] get
      {
        return (AccessoryThumbResource) null;
      }
    }

    [Token(Token = "0x60169B8")]
    [Address(RVA = "0x42F3CBC", Offset = "0x42F3CBC", VA = "0x42F3CBC", Slot = "4")]
    public override void OnUpdate()
    {
    }

    [Token(Token = "0x60169B9")]
    [Address(RVA = "0x42F4484", Offset = "0x42F4484", VA = "0x42F4484")]
    public void SetFavorite(bool isFavorite)
    {
    }

    [Token(Token = "0x60169BA")]
    [Address(RVA = "0x42F430C", Offset = "0x42F430C", VA = "0x42F430C")]
    public void PlaySelectTween(bool select)
    {
    }

    [Token(Token = "0x60169BB")]
    [Address(RVA = "0x42F4200", Offset = "0x42F4200", VA = "0x42F4200")]
    public void PlayNew(bool isNew)
    {
    }

    [Token(Token = "0x60169BC")]
    [Address(RVA = "0x42F4294", Offset = "0x42F4294", VA = "0x42F4294")]
    public void SetEnhancedBadge(bool canEnhanced)
    {
    }

    [Token(Token = "0x60169BD")]
    [Address(RVA = "0x42F454C", Offset = "0x42F454C", VA = "0x42F454C")]
    public AccessoryThumb()
    {
    }

    [Token(Token = "0x2003986")]
    private enum eIconTween
    {
      [Token(Token = "0x400FB5F")] In = 0,
      [Token(Token = "0x400FB5C")] NewBadge = 0,
      [Token(Token = "0x400FB5D")] Equipped = 1,
      [Token(Token = "0x400FB60")] Out = 1,
      [Token(Token = "0x400FB5E")] Favorite = 2,
      [Token(Token = "0x400FB61")] Flick = 2,
    }
  }
}
