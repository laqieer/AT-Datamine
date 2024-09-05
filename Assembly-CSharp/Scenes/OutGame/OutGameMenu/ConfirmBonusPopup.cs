// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.ConfirmBonusPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Popup;
using Il2CppDummyDll;
using Scenes.OutGame.Info.Common.UI;
using StaqData;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.OutGameMenu
{
  [Token(Token = "0x2003A59")]
  public class ConfirmBonusPopup : PopupBase
  {
    [Token(Token = "0x400FFC1")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private Image[] rarityBlueStar;
    [Token(Token = "0x400FFC2")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private ConfirmBonusContent[] bonusContent;
    [Token(Token = "0x400FFC3")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private CanvasGroup[] contentCanvasGroup;
    [Token(Token = "0x400FFC4")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private float unOpenedAlpha;
    [Token(Token = "0x400FFC5")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private CommonButton closeButton;
    [Token(Token = "0x400FFC6")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private CommonButton prevButton;
    [Token(Token = "0x400FFC7")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private CommonButton nextButton;
    [Token(Token = "0x400FFC8")]
    [FieldOffset(Offset = "0xC0")]
    private IAssetProvider assetProvider;
    [Token(Token = "0x400FFC9")]
    [FieldOffset(Offset = "0xC8")]
    private Style dispStyle;
    [Token(Token = "0x400FFCA")]
    [FieldOffset(Offset = "0xD0")]
    private int showRarity;
    [Token(Token = "0x400FFCB")]
    [FieldOffset(Offset = "0xD8")]
    private Sprite blueStar;
    [Token(Token = "0x400FFCC")]
    [FieldOffset(Offset = "0xE0")]
    private Sprite blackStar;

    [Token(Token = "0x6016EEE")]
    [Address(RVA = "0x29C00CC", Offset = "0x29C00CC", VA = "0x29C00CC")]
    public IEnumerator InitializeAsync(AssetCachedSpawner assetCachedSpawner) => (IEnumerator) null;

    [Token(Token = "0x6016EEF")]
    [Address(RVA = "0x29C0168", Offset = "0x29C0168", VA = "0x29C0168")]
    public void SetData(Style dispStyle, int nowRarity)
    {
    }

    [Token(Token = "0x6016EF0")]
    [Address(RVA = "0x29C08F4", Offset = "0x29C08F4", VA = "0x29C08F4")]
    public void SetForceActiveBonus()
    {
    }

    [Token(Token = "0x6016EF1")]
    [Address(RVA = "0x29C0718", Offset = "0x29C0718", VA = "0x29C0718")]
    private void SetButtonInteractable(Style dispStyle)
    {
    }

    [Token(Token = "0x6016EF2")]
    [Address(RVA = "0x29C0964", Offset = "0x29C0964", VA = "0x29C0964")]
    private void OnCloseButton()
    {
    }

    [Token(Token = "0x6016EF3")]
    [Address(RVA = "0x29C09F4", Offset = "0x29C09F4", VA = "0x29C09F4")]
    private void OnPrevButton()
    {
    }

    [Token(Token = "0x6016EF4")]
    [Address(RVA = "0x29C0A04", Offset = "0x29C0A04", VA = "0x29C0A04")]
    private void OnNextButton()
    {
    }

    [Token(Token = "0x6016EF5")]
    [Address(RVA = "0x29C0A14", Offset = "0x29C0A14", VA = "0x29C0A14")]
    public ConfirmBonusPopup()
    {
    }
  }
}
