// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.MindequipmentThumb
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.OutGameMenu
{
  [Token(Token = "0x200398D")]
  public class MindequipmentThumb : InfiniteCellBase
  {
    [Token(Token = "0x400FB6F")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x400FB70")]
    [FieldOffset(Offset = "0x30")]
    private readonly string[][] iconTweenName;
    [Token(Token = "0x400FB71")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private LongPressButton longPressButton;
    [Token(Token = "0x400FB72")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Image thumbnailImage;
    [Token(Token = "0x400FB73")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Image thumbnailImageLoadingIcon;
    [Token(Token = "0x400FB74")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private Image rarityBaseImage;
    [Token(Token = "0x400FB75")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private Image rarityImage;
    [Token(Token = "0x400FB76")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private GameObject newBadge;
    [Token(Token = "0x400FB77")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private GameObject equipIcon;
    [Token(Token = "0x400FB78")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private Image FavoriteIconImage;
    [Token(Token = "0x400FB79")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private GameObject AcquiredImage;
    [Token(Token = "0x400FB7A")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private GameObject OrdinalNumImage;
    [Token(Token = "0x400FB7B")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private TextMeshProUGUI ItemPossessionNum;
    [Token(Token = "0x400FB7C")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private Image SelectedImage;
    [Token(Token = "0x400FB7D")]
    [FieldOffset(Offset = "0x98")]
    public bool enable;

    [Token(Token = "0x17004A79")]
    public LongPressButton thumbnailButton
    {
      [Token(Token = "0x60169DA"), Address(RVA = "0x42F4FC8", Offset = "0x42F4FC8", VA = "0x42F4FC8")] get
      {
        return (LongPressButton) null;
      }
    }

    [Token(Token = "0x17004A7A")]
    private MindequipmentThumbResource Resource
    {
      [Token(Token = "0x60169DB"), Address(RVA = "0x42F4FD0", Offset = "0x42F4FD0", VA = "0x42F4FD0")] get
      {
        return (MindequipmentThumbResource) null;
      }
    }

    [Token(Token = "0x60169DC")]
    [Address(RVA = "0x42F5058", Offset = "0x42F5058", VA = "0x42F5058")]
    public void InitializeForceUpdate(MindequipmentThumbResource resource)
    {
    }

    [Token(Token = "0x60169DD")]
    [Address(RVA = "0x42F50D0", Offset = "0x42F50D0", VA = "0x42F50D0", Slot = "4")]
    public override void OnUpdate()
    {
    }

    [Token(Token = "0x60169DE")]
    [Address(RVA = "0x42F58DC", Offset = "0x42F58DC", VA = "0x42F58DC")]
    public void SetFavorite(bool isFavorite)
    {
    }

    [Token(Token = "0x60169DF")]
    [Address(RVA = "0x42F5764", Offset = "0x42F5764", VA = "0x42F5764")]
    public void PlaySelectTween(bool select)
    {
    }

    [Token(Token = "0x60169E0")]
    [Address(RVA = "0x42F5658", Offset = "0x42F5658", VA = "0x42F5658")]
    public void PlayNew(bool isNew)
    {
    }

    [Token(Token = "0x60169E1")]
    [Address(RVA = "0x42F56EC", Offset = "0x42F56EC", VA = "0x42F56EC")]
    public void SetEnhancedBadge(bool canEnhanced)
    {
    }

    [Token(Token = "0x60169E2")]
    [Address(RVA = "0x42F59A4", Offset = "0x42F59A4", VA = "0x42F59A4")]
    public void SetConversionDisplay(
      MindequipmentThumbResource resource,
      int amount,
      bool showAmount,
      Action onClick = null)
    {
    }

    [Token(Token = "0x60169E3")]
    [Address(RVA = "0x42F5C98", Offset = "0x42F5C98", VA = "0x42F5C98")]
    public void SetRewardDisplay(
      MindequipmentThumbResource resource,
      int amount,
      bool showAmount,
      Action onClick = null)
    {
    }

    [Token(Token = "0x60169E4")]
    [Address(RVA = "0x42F60C0", Offset = "0x42F60C0", VA = "0x42F60C0")]
    public MindequipmentThumb()
    {
    }

    [Token(Token = "0x200398E")]
    private enum eIconTween
    {
      [Token(Token = "0x400FB7F")] Equip = 0,
      [Token(Token = "0x400FB82")] In = 0,
      [Token(Token = "0x400FB80")] NewBadge = 1,
      [Token(Token = "0x400FB83")] Out = 1,
      [Token(Token = "0x400FB81")] Favorite = 2,
    }
  }
}
