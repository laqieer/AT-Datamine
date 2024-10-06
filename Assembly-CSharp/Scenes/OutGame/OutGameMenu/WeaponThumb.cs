// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.WeaponThumb
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
  [Token(Token = "0x200399A")]
  public class WeaponThumb : InfiniteCellBase
  {
    [Token(Token = "0x400FBB3")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x400FBB4")]
    [FieldOffset(Offset = "0x30")]
    private readonly string[][] iconTweenName;
    [Token(Token = "0x400FBB5")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private LongPressButton longPressButton;
    [Token(Token = "0x400FBB6")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Image thumbnailImage;
    [Token(Token = "0x400FBB7")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Image thumbnailImageLoadingIcon;
    [Token(Token = "0x400FBB8")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private Image rarityBaseImage;
    [Token(Token = "0x400FBB9")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private Image rarityImage;
    [Token(Token = "0x400FBBA")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private GameObject newBadge;
    [Token(Token = "0x400FBBB")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private Image FavoriteIconImage;
    [Token(Token = "0x400FBBC")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private Image SelectedImage;
    [Token(Token = "0x400FBBD")]
    [FieldOffset(Offset = "0x78")]
    public bool enable;

    [Token(Token = "0x17004A7E")]
    public Image ThumbnailImage
    {
      [Token(Token = "0x6016A17"), Address(RVA = "0x3F5E348", Offset = "0x3F5E348", VA = "0x3F5E348")] get
      {
        return (Image) null;
      }
    }

    [Token(Token = "0x17004A7F")]
    public LongPressButton thumbnailButton
    {
      [Token(Token = "0x6016A18"), Address(RVA = "0x3F5E350", Offset = "0x3F5E350", VA = "0x3F5E350")] get
      {
        return (LongPressButton) null;
      }
    }

    [Token(Token = "0x17004A80")]
    private WeaponThumbResource Resource
    {
      [Token(Token = "0x6016A19"), Address(RVA = "0x3F5E358", Offset = "0x3F5E358", VA = "0x3F5E358")] get
      {
        return (WeaponThumbResource) null;
      }
    }

    [Token(Token = "0x6016A1A")]
    [Address(RVA = "0x3F5E3E0", Offset = "0x3F5E3E0", VA = "0x3F5E3E0", Slot = "4")]
    public override void OnUpdate()
    {
    }

    [Token(Token = "0x6016A1B")]
    [Address(RVA = "0x3F5EBC0", Offset = "0x3F5EBC0", VA = "0x3F5EBC0")]
    public void SetFavorite(bool isFavorite)
    {
    }

    [Token(Token = "0x6016A1C")]
    [Address(RVA = "0x3F5EA48", Offset = "0x3F5EA48", VA = "0x3F5EA48")]
    public void PlaySelectTween(bool select)
    {
    }

    [Token(Token = "0x6016A1D")]
    [Address(RVA = "0x3F5E93C", Offset = "0x3F5E93C", VA = "0x3F5E93C")]
    public void PlayNew(bool isNew)
    {
    }

    [Token(Token = "0x6016A1E")]
    [Address(RVA = "0x3F5E9D0", Offset = "0x3F5E9D0", VA = "0x3F5E9D0")]
    public void SetEnhancedBadge(bool canEnhanced)
    {
    }

    [Token(Token = "0x6016A1F")]
    [Address(RVA = "0x3F5EC88", Offset = "0x3F5EC88", VA = "0x3F5EC88")]
    public WeaponThumb()
    {
    }

    [Token(Token = "0x200399B")]
    private enum eIconTween
    {
      [Token(Token = "0x400FBC2")] In = 0,
      [Token(Token = "0x400FBBF")] NewBadge = 0,
      [Token(Token = "0x400FBC0")] Equipped = 1,
      [Token(Token = "0x400FBC3")] Out = 1,
      [Token(Token = "0x400FBC1")] Favorite = 2,
      [Token(Token = "0x400FBC4")] Flick = 2,
    }
  }
}
