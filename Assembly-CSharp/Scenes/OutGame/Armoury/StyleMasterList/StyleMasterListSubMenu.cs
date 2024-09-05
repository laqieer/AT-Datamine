// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Armoury.StyleMasterList.StyleMasterListSubMenu
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Input;
using Il2CppDummyDll;
using Scenes.OutGame.Favorite;
using Scenes.OutGame.Info.Common.UI;
using Scenes.OutGame.OutGameMenu;
using StaqData;
using System;
using System.Collections;
using TMPro;
using UI.Common;
using UI.Direction;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.Armoury.StyleMasterList
{
  [Token(Token = "0x2003847")]
  internal class StyleMasterListSubMenu : MonoBehaviour
  {
    [Token(Token = "0x400F59D")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITimelineController timelineController;
    [Token(Token = "0x400F59E")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private CanvasGroup rightCanvasGroup;
    [Token(Token = "0x400F59F")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private BackKeyHandlerComponent backKeyHandlerComponent;
    [Token(Token = "0x400F5A0")]
    [FieldOffset(Offset = "0x30")]
    [Header("上部")]
    [SerializeField]
    private TextMeshProUGUI nameText;
    [Token(Token = "0x400F5A1")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private CommonButton closeButton;
    [Token(Token = "0x400F5A2")]
    [FieldOffset(Offset = "0x40")]
    [Header("情報：ヘッダ部")]
    [SerializeField]
    private RarityIcon rarityIcon;
    [Token(Token = "0x400F5A3")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private FavoriteButton favoriteButton;
    [Token(Token = "0x400F5A4")]
    [FieldOffset(Offset = "0x50")]
    [Header("情報：ステータス部")]
    [SerializeField]
    private CommonButton detailButton;
    [Token(Token = "0x400F5A5")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private TextMeshProUGUI combatPower;
    [Token(Token = "0x400F5A6")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private TextMeshProUGUI hpText;
    [Token(Token = "0x400F5A7")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private TextMeshProUGUI hitText;
    [Token(Token = "0x400F5A8")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private TextMeshProUGUI physicalAttackText;
    [Token(Token = "0x400F5A9")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private TextMeshProUGUI avoidText;
    [Token(Token = "0x400F5AA")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private TextMeshProUGUI magicalAttackText;
    [Token(Token = "0x400F5AB")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private TextMeshProUGUI criticalText;
    [Token(Token = "0x400F5AC")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private TextMeshProUGUI physicalDefText;
    [Token(Token = "0x400F5AD")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private TextMeshProUGUI criticalAvoidText;
    [Token(Token = "0x400F5AE")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private TextMeshProUGUI magicalDefText;
    [Token(Token = "0x400F5AF")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private TextMeshProUGUI weightText;
    [Token(Token = "0x400F5B0")]
    [FieldOffset(Offset = "0xB0")]
    [Header("情報：スキル")]
    [SerializeField]
    private DetailSkillListThumb detailSkillList;
    [Token(Token = "0x400F5B1")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    [Header("下部")]
    private CommonButton statusButton;
    [Token(Token = "0x400F5B2")]
    [FieldOffset(Offset = "0xC0")]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x400F5B3")]
    [FieldOffset(Offset = "0xC8")]
    private IAssetProvider assetProvider;

    [Token(Token = "0x60161F7")]
    [Address(RVA = "0x20F8948", Offset = "0x20F8948", VA = "0x20F8948")]
    public static IEnumerator SpawnAsync(
      AssetCachedSpawner spawner,
      Transform parent,
      Action<StyleMasterListSubMenu> onCompleted)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60161F8")]
    [Address(RVA = "0x20F89C4", Offset = "0x20F89C4", VA = "0x20F89C4")]
    public IEnumerator InitializeAsync(
      Action onClickStatusButton,
      Action onClickFavoriteButton,
      Action onClickCloseButton)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60161F9")]
    [Address(RVA = "0x20F713C", Offset = "0x20F713C", VA = "0x20F713C")]
    public void Refresh(UnitTrust unitTrust)
    {
    }

    [Token(Token = "0x60161FA")]
    [Address(RVA = "0x20F7920", Offset = "0x20F7920", VA = "0x20F7920")]
    public void PlayIn()
    {
    }

    [Token(Token = "0x60161FB")]
    [Address(RVA = "0x20F7434", Offset = "0x20F7434", VA = "0x20F7434")]
    public void PlayOut()
    {
    }

    [Token(Token = "0x60161FC")]
    [Address(RVA = "0x20F86EC", Offset = "0x20F86EC", VA = "0x20F86EC")]
    public void SetActiveFavoriteButton(bool isSelectedTThumbFavorite)
    {
    }

    [Token(Token = "0x60161FD")]
    [Address(RVA = "0x20F70E8", Offset = "0x20F70E8", VA = "0x20F70E8")]
    public void Disable()
    {
    }

    [Token(Token = "0x60161FE")]
    [Address(RVA = "0x20F8AF4", Offset = "0x20F8AF4", VA = "0x20F8AF4")]
    public StyleMasterListSubMenu()
    {
    }
  }
}
