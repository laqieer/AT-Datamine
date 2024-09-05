// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.TrustThumb
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
  [Token(Token = "0x2003995")]
  public class TrustThumb : InfiniteCellBase
  {
    [Token(Token = "0x400FB96")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x400FB97")]
    [FieldOffset(Offset = "0x30")]
    private readonly string[][] iconTweenName;
    [Token(Token = "0x400FB98")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private LongPressButton longPressButton;
    [Token(Token = "0x400FB99")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Image thumbnailImage;
    [Token(Token = "0x400FB9A")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Image thumbnailImageLoadingIcon;
    [Token(Token = "0x400FB9B")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private Image rarityBaseImage;
    [Token(Token = "0x400FB9C")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private Image rarityImage;
    [Token(Token = "0x400FB9D")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private GameObject newBadge;
    [Token(Token = "0x400FB9E")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private Image FavoriteIconImage;
    [Token(Token = "0x400FB9F")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private Image SelectedImage;
    [Token(Token = "0x400FBA0")]
    [FieldOffset(Offset = "0x78")]
    public bool enable;

    [Token(Token = "0x17004A7C")]
    public LongPressButton thumbnailButton
    {
      [Token(Token = "0x6016A02"), Address(RVA = "0x42F6B60", Offset = "0x42F6B60", VA = "0x42F6B60")] get
      {
        return (LongPressButton) null;
      }
    }

    [Token(Token = "0x17004A7D")]
    private TrustThumbResource Resource
    {
      [Token(Token = "0x6016A03"), Address(RVA = "0x42F6B68", Offset = "0x42F6B68", VA = "0x42F6B68")] get
      {
        return (TrustThumbResource) null;
      }
    }

    [Token(Token = "0x6016A04")]
    [Address(RVA = "0x42F6BF0", Offset = "0x42F6BF0", VA = "0x42F6BF0", Slot = "4")]
    public override void OnUpdate()
    {
    }

    [Token(Token = "0x6016A05")]
    [Address(RVA = "0x42F7318", Offset = "0x42F7318", VA = "0x42F7318")]
    public void SetFavorite(bool isFavorite)
    {
    }

    [Token(Token = "0x6016A06")]
    [Address(RVA = "0x42F71A0", Offset = "0x42F71A0", VA = "0x42F71A0")]
    public void PlaySelectTween(bool select)
    {
    }

    [Token(Token = "0x6016A07")]
    [Address(RVA = "0x42F710C", Offset = "0x42F710C", VA = "0x42F710C")]
    public void PlayNew(bool isNew)
    {
    }

    [Token(Token = "0x6016A08")]
    [Address(RVA = "0x42F73E0", Offset = "0x42F73E0", VA = "0x42F73E0")]
    public TrustThumb()
    {
    }

    [Token(Token = "0x2003996")]
    private enum eIconTween
    {
      [Token(Token = "0x400FBA5")] In = 0,
      [Token(Token = "0x400FBA2")] NewBadge = 0,
      [Token(Token = "0x400FBA3")] Equipped = 1,
      [Token(Token = "0x400FBA6")] Out = 1,
      [Token(Token = "0x400FBA4")] Favorite = 2,
      [Token(Token = "0x400FBA7")] Flick = 2,
    }
  }
}
