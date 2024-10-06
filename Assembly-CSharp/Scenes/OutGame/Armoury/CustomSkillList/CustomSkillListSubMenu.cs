// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Armoury.CustomSkillList.CustomSkillListSubMenu
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Input;
using GameCore.UIControls;
using Il2CppDummyDll;
using Scenes.OutGame.Favorite;
using Scenes.OutGame.Info.Common.UI;
using Scenes.OutGame.Info.Skill.UI;
using StaqData;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UI.Common;
using UI.Direction;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.Armoury.CustomSkillList
{
  [Token(Token = "0x200387F")]
  public class CustomSkillListSubMenu : MonoBehaviour
  {
    [Token(Token = "0x400F6BC")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITimelineController timelineController;
    [Token(Token = "0x400F6BD")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private CanvasGroup rightCanvasGroup;
    [Token(Token = "0x400F6BE")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private BackKeyHandlerComponent backKeyHandlerComponent;
    [Token(Token = "0x400F6BF")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private TextMeshProUGUI nameText;
    [Token(Token = "0x400F6C0")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private TextMeshProUGUI levelText;
    [Token(Token = "0x400F6C1")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private CommonButton closeButton;
    [Token(Token = "0x400F6C2")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private FavoriteButton favoriteButton;
    [Token(Token = "0x400F6C3")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private RarityIcon rarityIcon;
    [Token(Token = "0x400F6C4")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private CustomSkillIcon mainIcon;
    [Token(Token = "0x400F6C5")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private TextMeshProUGUI categoryName;
    [Token(Token = "0x400F6C6")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private SkillIconList subIconList;
    [Token(Token = "0x400F6C7")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private List<TextMeshProUGUI> tagList;
    [Token(Token = "0x400F6C8")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private TextMeshProUGUI rangeMinValue;
    [Token(Token = "0x400F6C9")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private TextMeshProUGUI rangeMaxValue;
    [Token(Token = "0x400F6CA")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private TextMeshProUGUI useCountValue;
    [Token(Token = "0x400F6CB")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private TextMeshProUGUI coolTimeValue;
    [Token(Token = "0x400F6CC")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private TextMeshProUGUI endDuranceValue;
    [Token(Token = "0x400F6CD")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private SkillInfoUI skillInfoUI;
    [Token(Token = "0x400F6CE")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private TextMeshProUGUI infoText;
    [Token(Token = "0x400F6CF")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private CommonButton enhancedButton;
    [Token(Token = "0x400F6D0")]
    [FieldOffset(Offset = "0xB8")]
    private int selectedListCategory;
    [Token(Token = "0x400F6D1")]
    [FieldOffset(Offset = "0xC0")]
    private CustomSkill selectedCustomSkill;
    [Token(Token = "0x400F6D2")]
    [FieldOffset(Offset = "0xC8")]
    private bool isConnecting;
    [Token(Token = "0x400F6D3")]
    [FieldOffset(Offset = "0xD0")]
    private Action<int> onChange;
    [Token(Token = "0x400F6D4")]
    [FieldOffset(Offset = "0xD8")]
    private Action onMoveEnhanced;
    [Token(Token = "0x400F6D5")]
    [FieldOffset(Offset = "0xE0")]
    private Action onClose;
    [Token(Token = "0x400F6D6")]
    [FieldOffset(Offset = "0xE8")]
    private CustomSkillScreen customSkillScreen;
    [Token(Token = "0x400F6D7")]
    [FieldOffset(Offset = "0xF0")]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x400F6D8")]
    [FieldOffset(Offset = "0xF8")]
    private IAssetProvider assetProvider;

    [Token(Token = "0x601635A")]
    [Address(RVA = "0x1DF6D1C", Offset = "0x1DF6D1C", VA = "0x1DF6D1C")]
    public static IEnumerator SpawnAsync(
      AssetCachedSpawner spawner,
      Transform parent,
      Action<CustomSkillListSubMenu> onCompleted)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x601635B")]
    [Address(RVA = "0x1DF6DC0", Offset = "0x1DF6DC0", VA = "0x1DF6DC0")]
    public IEnumerator InitializeAsync(
      Action<int> onChange,
      Action onMoveEnhanced,
      Action onClose,
      CustomSkillScreen customSkillScreen)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x601635C")]
    [Address(RVA = "0x1DF6E78", Offset = "0x1DF6E78", VA = "0x1DF6E78")]
    public void Refresh(CustomSkill customSkill, int listCategory)
    {
    }

    [Token(Token = "0x601635D")]
    [Address(RVA = "0x1DF775C", Offset = "0x1DF775C", VA = "0x1DF775C")]
    public void UpdateDetail()
    {
    }

    [Token(Token = "0x601635E")]
    [Address(RVA = "0x1DF776C", Offset = "0x1DF776C", VA = "0x1DF776C")]
    public void PlayIn()
    {
    }

    [Token(Token = "0x601635F")]
    [Address(RVA = "0x1DF77E8", Offset = "0x1DF77E8", VA = "0x1DF77E8")]
    public void PlayOut()
    {
    }

    [Token(Token = "0x6016360")]
    [Address(RVA = "0x1DF7864", Offset = "0x1DF7864", VA = "0x1DF7864")]
    public void SetActiveFavoriteButton(bool isSelectedTThumbFavorite)
    {
    }

    [Token(Token = "0x6016361")]
    [Address(RVA = "0x1DF7884", Offset = "0x1DF7884", VA = "0x1DF7884")]
    public void Disable()
    {
    }

    [Token(Token = "0x6016362")]
    [Address(RVA = "0x1DF78BC", Offset = "0x1DF78BC", VA = "0x1DF78BC")]
    private void OnMoveEnhance()
    {
    }

    [Token(Token = "0x6016363")]
    [Address(RVA = "0x1DF78E0", Offset = "0x1DF78E0", VA = "0x1DF78E0")]
    private void OnClickFavorite()
    {
    }

    [Token(Token = "0x6016364")]
    [Address(RVA = "0x1DF6E84", Offset = "0x1DF6E84", VA = "0x1DF6E84")]
    private void SetParameter(CustomSkill customSkill)
    {
    }

    [Token(Token = "0x6016365")]
    [Address(RVA = "0x1DF7910", Offset = "0x1DF7910", VA = "0x1DF7910")]
    private IEnumerator ConnectFavoriteAPI() => (IEnumerator) null;

    [Token(Token = "0x6016366")]
    [Address(RVA = "0x1DF79A8", Offset = "0x1DF79A8", VA = "0x1DF79A8")]
    public CustomSkillListSubMenu()
    {
    }
  }
}
