// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Armoury.StyleMasterList.StyleMasterListScreen
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.OutGame.Utility;
using StaqData;
using System.Collections;
using System.Collections.Generic;
using UI.SortFilter;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.Armoury.StyleMasterList
{
  [Token(Token = "0x2003840")]
  internal class StyleMasterListScreen : ArmouryScreenBase
  {
    [Token(Token = "0x400F57E")]
    [FieldOffset(Offset = "0x90")]
    [Header("Nothing時のオブジェクト")]
    [SerializeField]
    private GameObject nothingText;
    [Token(Token = "0x400F57F")]
    [FieldOffset(Offset = "0x98")]
    [Header("フィルタ")]
    [SerializeField]
    private SortFilterHeaderButton sortFilterHeaderButton;
    [Token(Token = "0x400F580")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    [Header("スクロールビュー")]
    private HorizontalGridInfiniteScrollView infiniteScrollView;
    [Token(Token = "0x400F581")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private float scrollSnapDuration;
    [Token(Token = "0x400F582")]
    [FieldOffset(Offset = "0xB0")]
    [Header("サブメニュー")]
    [SerializeField]
    private Transform subMenuParent;
    [Token(Token = "0x400F583")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    [Space(10f)]
    private CanvasGroup rightCanvasGroup;
    [Token(Token = "0x400F584")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    private CanvasGroup topCanvasGroup;
    [Token(Token = "0x400F585")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    private CommonButton fullScreenButton;
    [Token(Token = "0x400F586")]
    [FieldOffset(Offset = "0xD0")]
    private StyleMasterListScreen.Param trustListParam;
    [Token(Token = "0x400F587")]
    [FieldOffset(Offset = "0xD8")]
    private readonly NewBadgeProxy newBadgeProxy;
    [Token(Token = "0x400F588")]
    [FieldOffset(Offset = "0xE0")]
    private readonly List<UnitTrust> styleMasters;
    [Token(Token = "0x400F589")]
    [FieldOffset(Offset = "0xE8")]
    private readonly List<IArmouryStyleMasterThumbResource> styleMasterResources;
    [Token(Token = "0x400F58A")]
    [FieldOffset(Offset = "0xF0")]
    private ArmouryStyleMasterAssetLoader styleMasterListAssetLoader;
    [Token(Token = "0x400F58B")]
    [FieldOffset(Offset = "0xF8")]
    private StyleMasterListSubMenu subMenu;
    [Token(Token = "0x400F58C")]
    [FieldOffset(Offset = "0x100")]
    private int thumbSelectIndex;
    [Token(Token = "0x400F58D")]
    [FieldOffset(Offset = "0x104")]
    private bool favoriteConnecting;

    [Token(Token = "0x60161C6")]
    [Address(RVA = "0x20F5F1C", Offset = "0x20F5F1C", VA = "0x20F5F1C", Slot = "4")]
    public override void Initialize(ArmouryChangeScreenParam param = null)
    {
    }

    [Token(Token = "0x60161C7")]
    [Address(RVA = "0x20F6C64", Offset = "0x20F6C64", VA = "0x20F6C64", Slot = "5")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x60161C8")]
    [Address(RVA = "0x20F6CF4", Offset = "0x20F6CF4", VA = "0x20F6CF4", Slot = "7")]
    public override void OnBeforeBackScene(ArmouryChangeScreenParam param = null)
    {
    }

    [Token(Token = "0x60161C9")]
    [Address(RVA = "0x20F6FFC", Offset = "0x20F6FFC", VA = "0x20F6FFC", Slot = "8")]
    public override void Active(ArmouryChangeScreenParam param = null)
    {
    }

    [Token(Token = "0x60161CA")]
    [Address(RVA = "0x20F7064", Offset = "0x20F7064", VA = "0x20F7064", Slot = "9")]
    public override void InActive()
    {
    }

    [Token(Token = "0x60161CB")]
    [Address(RVA = "0x20F7120", Offset = "0x20F7120", VA = "0x20F7120", Slot = "14")]
    public override void Destroy()
    {
    }

    [Token(Token = "0x60161CC")]
    [Address(RVA = "0x20F6E90", Offset = "0x20F6E90", VA = "0x20F6E90")]
    private void RefreshView(bool immediateSnap, int newThumbSelectIndex)
    {
    }

    [Token(Token = "0x60161CD")]
    [Address(RVA = "0x20F6288", Offset = "0x20F6288", VA = "0x20F6288")]
    private void CreateStyleMasterList()
    {
    }

    [Token(Token = "0x60161CE")]
    [Address(RVA = "0x20F6698", Offset = "0x20F6698", VA = "0x20F6698")]
    private void CreateResources(int dataCount)
    {
    }

    [Token(Token = "0x60161CF")]
    [Address(RVA = "0x20F696C", Offset = "0x20F696C", VA = "0x20F696C")]
    private void SetupScrollView()
    {
    }

    [Token(Token = "0x60161D0")]
    [Address(RVA = "0x20F74B8", Offset = "0x20F74B8", VA = "0x20F74B8")]
    private (int, string) GetPrevSelectedInfo() => ();

    [Token(Token = "0x60161D1")]
    [Address(RVA = "0x20F6D24", Offset = "0x20F6D24", VA = "0x20F6D24")]
    private void ChangeSelectThumb(int nextIndex)
    {
    }

    [Token(Token = "0x60161D2")]
    [Address(RVA = "0x20F759C", Offset = "0x20F759C", VA = "0x20F759C")]
    private void ChangeSelectThumbNone()
    {
    }

    [Token(Token = "0x60161D3")]
    [Address(RVA = "0x20F6FB8", Offset = "0x20F6FB8", VA = "0x20F6FB8")]
    private void SetInteractable(bool flg)
    {
    }

    [Token(Token = "0x60161D4")]
    [Address(RVA = "0x20F7678", Offset = "0x20F7678", VA = "0x20F7678")]
    private void OnClickThumb(int index)
    {
    }

    [Token(Token = "0x60161D5")]
    [Address(RVA = "0x20F7094", Offset = "0x20F7094", VA = "0x20F7094")]
    private void OnCloseSubMenu()
    {
    }

    [Token(Token = "0x60161D6")]
    [Address(RVA = "0x20F799C", Offset = "0x20F799C", VA = "0x20F799C")]
    private void OnClickStatusButton()
    {
    }

    [Token(Token = "0x60161D7")]
    [Address(RVA = "0x20F7AF4", Offset = "0x20F7AF4", VA = "0x20F7AF4")]
    private void OnClickFavoriteButton()
    {
    }

    [Token(Token = "0x60161D8")]
    [Address(RVA = "0x20F7B80", Offset = "0x20F7B80", VA = "0x20F7B80")]
    private IEnumerator ConnectAPIFavorite(int index, UnitTrust unitTrust) => (IEnumerator) null;

    [Token(Token = "0x60161D9")]
    [Address(RVA = "0x20F7C24", Offset = "0x20F7C24", VA = "0x20F7C24")]
    private void OnClickFilterButton()
    {
    }

    [Token(Token = "0x60161DA")]
    [Address(RVA = "0x20F7CD4", Offset = "0x20F7CD4", VA = "0x20F7CD4")]
    private void UpdateSortFilterAction(List<Equipment> sortFilterList)
    {
    }

    [Token(Token = "0x60161DB")]
    [Address(RVA = "0x20F626C", Offset = "0x20F626C", VA = "0x20F626C")]
    private void UpdateSortFilterButton()
    {
    }

    [Token(Token = "0x60161DC")]
    [Address(RVA = "0x20F8094", Offset = "0x20F8094", VA = "0x20F8094")]
    private void Update()
    {
    }

    [Token(Token = "0x60161DD")]
    [Address(RVA = "0x20F80B0", Offset = "0x20F80B0", VA = "0x20F80B0")]
    public StyleMasterListScreen()
    {
    }

    [Token(Token = "0x2003841")]
    public class Param : ArmouryChangeScreenParam
    {
      [Token(Token = "0x17004904")]
      public int FilterSelect
      {
        [Token(Token = "0x60161E2"), Address(RVA = "0x20F81C0", Offset = "0x20F81C0", VA = "0x20F81C0")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x60161E3")]
      [Address(RVA = "0x20F6264", Offset = "0x20F6264", VA = "0x20F6264")]
      public Param()
      {
      }
    }
  }
}
