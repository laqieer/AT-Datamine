// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Armoury.WeaponList.WeaponListScreen
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.OutGame.MasterBonus;
using Scenes.OutGame.OutGameMenu.ConsumableMaterialList;
using Scenes.OutGame.Utility;
using StaqData;
using System.Collections;
using System.Collections.Generic;
using UI.SortFilter;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.Armoury.WeaponList
{
  [Token(Token = "0x200382A")]
  internal class WeaponListScreen : ArmouryScreenBase
  {
    [Token(Token = "0x400F510")]
    [FieldOffset(Offset = "0x90")]
    [Header("Nothing時 表示オブジェクト")]
    [SerializeField]
    private GameObject nothingText;
    [Token(Token = "0x400F511")]
    [FieldOffset(Offset = "0x98")]
    [Header("バッジ/フィルタ")]
    [SerializeField]
    private CommonToggle badgeFilter;
    [Token(Token = "0x400F512")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private Text toggleOffText;
    [Token(Token = "0x400F513")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private Text toggleOnText;
    [Token(Token = "0x400F514")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private SortFilterHeaderButton sortFilterHeaderButton;
    [Token(Token = "0x400F515")]
    [FieldOffset(Offset = "0xB8")]
    [Header("画面上部のボタン類")]
    [SerializeField]
    private CommonButton masterBonusButton;
    [Token(Token = "0x400F516")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    private CommonButton materialListButton;
    [Token(Token = "0x400F517")]
    [FieldOffset(Offset = "0xC8")]
    [Header("スクロールビュー")]
    [SerializeField]
    private HorizontalGridInfiniteScrollView infiniteScrollView;
    [Token(Token = "0x400F518")]
    [FieldOffset(Offset = "0xD0")]
    [SerializeField]
    private float scrollSnapDuration;
    [Token(Token = "0x400F519")]
    [FieldOffset(Offset = "0xD8")]
    [SerializeField]
    [Header("サブメニュー")]
    private Transform subMenuParent;
    [Token(Token = "0x400F51A")]
    [FieldOffset(Offset = "0xE0")]
    [Space(10f)]
    [SerializeField]
    private CommonButton fullScreenButton;
    [Token(Token = "0x400F51B")]
    [FieldOffset(Offset = "0xE8")]
    [SerializeField]
    private CanvasGroup rightCanvasGroup;
    [Token(Token = "0x400F51C")]
    [FieldOffset(Offset = "0xF0")]
    [SerializeField]
    private CanvasGroup topCanvasGroup;
    [Token(Token = "0x400F51D")]
    [FieldOffset(Offset = "0xF8")]
    private WeaponListScreen.Param weaponListParam;
    [Token(Token = "0x400F51E")]
    [FieldOffset(Offset = "0x100")]
    private readonly NewBadgeProxy newBadgeProxy;
    [Token(Token = "0x400F51F")]
    [FieldOffset(Offset = "0x108")]
    private readonly MasterBonusProvider masterBonusProvider;
    [Token(Token = "0x400F520")]
    [FieldOffset(Offset = "0x110")]
    private readonly List<IArmouryWeaponThumbResource> weaponResources;
    [Token(Token = "0x400F521")]
    [FieldOffset(Offset = "0x118")]
    private List<Weapon> weaponList;
    [Token(Token = "0x400F522")]
    [FieldOffset(Offset = "0x120")]
    private MaterialListPopupProvider consumableMaterialListPopupProvider;
    [Token(Token = "0x400F523")]
    [FieldOffset(Offset = "0x128")]
    private ArmouryWeaponListAssetLoader weaponListListAssetLoader;
    [Token(Token = "0x400F524")]
    [FieldOffset(Offset = "0x130")]
    private WeaponListSubMenu subMenu;
    [Token(Token = "0x400F525")]
    [FieldOffset(Offset = "0x138")]
    private int thumbSelectIndex;
    [Token(Token = "0x400F526")]
    [FieldOffset(Offset = "0x13C")]
    private bool favoriteConnecting;

    [Token(Token = "0x6016141")]
    [Address(RVA = "0x20F10A8", Offset = "0x20F10A8", VA = "0x20F10A8")]
    public void SetParam(WeaponListScreen.Param param)
    {
    }

    [Token(Token = "0x6016142")]
    [Address(RVA = "0x20F10B0", Offset = "0x20F10B0", VA = "0x20F10B0", Slot = "4")]
    public override void Initialize(ArmouryChangeScreenParam param = null)
    {
    }

    [Token(Token = "0x6016143")]
    [Address(RVA = "0x20F179C", Offset = "0x20F179C", VA = "0x20F179C", Slot = "5")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x6016144")]
    [Address(RVA = "0x20F182C", Offset = "0x20F182C", VA = "0x20F182C", Slot = "7")]
    public override void OnBeforeBackScene(ArmouryChangeScreenParam param = null)
    {
    }

    [Token(Token = "0x6016145")]
    [Address(RVA = "0x20F188C", Offset = "0x20F188C", VA = "0x20F188C", Slot = "8")]
    public override void Active(ArmouryChangeScreenParam param = null)
    {
    }

    [Token(Token = "0x6016146")]
    [Address(RVA = "0x20F1894", Offset = "0x20F1894", VA = "0x20F1894", Slot = "9")]
    public override void InActive()
    {
    }

    [Token(Token = "0x6016147")]
    [Address(RVA = "0x20F19C8", Offset = "0x20F19C8", VA = "0x20F19C8", Slot = "14")]
    public override void Destroy()
    {
    }

    [Token(Token = "0x6016148")]
    [Address(RVA = "0x20F15BC", Offset = "0x20F15BC", VA = "0x20F15BC")]
    private void Refresh()
    {
    }

    [Token(Token = "0x6016149")]
    [Address(RVA = "0x20F2674", Offset = "0x20F2674", VA = "0x20F2674")]
    private void RefreshView(bool immediateSnap, int newThumbSelectIndex)
    {
    }

    [Token(Token = "0x601614A")]
    [Address(RVA = "0x20F1AFC", Offset = "0x20F1AFC", VA = "0x20F1AFC")]
    private void CreateList()
    {
    }

    [Token(Token = "0x601614B")]
    [Address(RVA = "0x20F2074", Offset = "0x20F2074", VA = "0x20F2074")]
    private void CreateThumbResources(int dataCount)
    {
    }

    [Token(Token = "0x601614C")]
    [Address(RVA = "0x20F2348", Offset = "0x20F2348", VA = "0x20F2348")]
    private void SetupScrollView()
    {
    }

    [Token(Token = "0x601614D")]
    [Address(RVA = "0x20F1A10", Offset = "0x20F1A10", VA = "0x20F1A10")]
    private (int, string) GetPrevSelectedInfo() => ();

    [Token(Token = "0x601614E")]
    [Address(RVA = "0x20F27E0", Offset = "0x20F27E0", VA = "0x20F27E0")]
    private void ChangeSelectThumb(int index)
    {
    }

    [Token(Token = "0x601614F")]
    [Address(RVA = "0x20F1F98", Offset = "0x20F1F98", VA = "0x20F1F98")]
    private void ChangeSelectThumbNone()
    {
    }

    [Token(Token = "0x6016150")]
    [Address(RVA = "0x20F18DC", Offset = "0x20F18DC", VA = "0x20F18DC")]
    private void CloseHeaderPopups()
    {
    }

    [Token(Token = "0x6016151")]
    [Address(RVA = "0x20F1848", Offset = "0x20F1848", VA = "0x20F1848")]
    private void SetInteractable(bool flag)
    {
    }

    [Token(Token = "0x6016152")]
    [Address(RVA = "0x20F31F0", Offset = "0x20F31F0", VA = "0x20F31F0")]
    private void OnClickThumb(int index)
    {
    }

    [Token(Token = "0x6016153")]
    [Address(RVA = "0x20F193C", Offset = "0x20F193C", VA = "0x20F193C")]
    private void OnCloseSubMenuAndHeaderPopup()
    {
    }

    [Token(Token = "0x6016154")]
    [Address(RVA = "0x20F351C", Offset = "0x20F351C", VA = "0x20F351C")]
    private void OnChangeEnhancedDetail()
    {
    }

    [Token(Token = "0x6016155")]
    [Address(RVA = "0x20F3644", Offset = "0x20F3644", VA = "0x20F3644")]
    private void OnClickMasterBonus()
    {
    }

    [Token(Token = "0x6016156")]
    [Address(RVA = "0x20F3794", Offset = "0x20F3794", VA = "0x20F3794")]
    private void OnClickMaterialListButton()
    {
    }

    [Token(Token = "0x6016157")]
    [Address(RVA = "0x20F37CC", Offset = "0x20F37CC", VA = "0x20F37CC")]
    private IEnumerator OnClickFilterButton() => (IEnumerator) null;

    [Token(Token = "0x6016158")]
    [Address(RVA = "0x20F385C", Offset = "0x20F385C", VA = "0x20F385C")]
    private void UpdateSortFilterAction(List<Equipment> sortFilterList)
    {
    }

    [Token(Token = "0x6016159")]
    [Address(RVA = "0x20F15A0", Offset = "0x20F15A0", VA = "0x20F15A0")]
    private void UpdateSortFilterButton()
    {
    }

    [Token(Token = "0x601615A")]
    [Address(RVA = "0x20F3C28", Offset = "0x20F3C28", VA = "0x20F3C28")]
    private void OnClickFavorite()
    {
    }

    [Token(Token = "0x601615B")]
    [Address(RVA = "0x20F3CB4", Offset = "0x20F3CB4", VA = "0x20F3CB4")]
    private IEnumerator ConnectAPIFavorite(int index, Weapon weapon) => (IEnumerator) null;

    [Token(Token = "0x601615C")]
    [Address(RVA = "0x20F3D58", Offset = "0x20F3D58", VA = "0x20F3D58")]
    private void OnClickBadgeFilter(bool state)
    {
    }

    [Token(Token = "0x601615D")]
    [Address(RVA = "0x20F3074", Offset = "0x20F3074", VA = "0x20F3074")]
    private List<Weapon> FilteringBadge(List<Weapon> list) => (List<Weapon>) null;

    [Token(Token = "0x601615E")]
    [Address(RVA = "0x20F3D5C", Offset = "0x20F3D5C", VA = "0x20F3D5C")]
    private void Update()
    {
    }

    [Token(Token = "0x601615F")]
    [Address(RVA = "0x20F3D78", Offset = "0x20F3D78", VA = "0x20F3D78")]
    public WeaponListScreen()
    {
    }

    [Token(Token = "0x200382B")]
    public class Param : ArmouryChangeScreenParam
    {
      [Token(Token = "0x170048EF")]
      public int FilterSelect
      {
        [Token(Token = "0x6016165"), Address(RVA = "0x20F3FA8", Offset = "0x20F3FA8", VA = "0x20F3FA8")] get
        {
          return new int();
        }
        [Token(Token = "0x6016166"), Address(RVA = "0x20F3FB0", Offset = "0x20F3FB0", VA = "0x20F3FB0")] set
        {
        }
      }

      [Token(Token = "0x170048F0")]
      public int CurrentThumbIndex
      {
        [Token(Token = "0x6016167"), Address(RVA = "0x20F3FB8", Offset = "0x20F3FB8", VA = "0x20F3FB8")] get
        {
          return new int();
        }
        [Token(Token = "0x6016168"), Address(RVA = "0x20F3FC0", Offset = "0x20F3FC0", VA = "0x20F3FC0")] set
        {
        }
      }

      [Token(Token = "0x6016169")]
      [Address(RVA = "0x20F1590", Offset = "0x20F1590", VA = "0x20F1590")]
      public Param()
      {
      }
    }
  }
}
