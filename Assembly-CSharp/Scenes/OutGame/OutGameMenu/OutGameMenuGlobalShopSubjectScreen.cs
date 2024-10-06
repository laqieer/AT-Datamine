// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.OutGameMenuGlobalShopSubjectScreen
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using Scenes.OutGame.OutGameMenu.GlobalShop;
using Scenes.OutGame.OutGameMenu.MedalShop;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.OutGameMenu
{
  [Token(Token = "0x2003A0A")]
  public class OutGameMenuGlobalShopSubjectScreen : OutGameMenuSubjectScreenBase
  {
    [Token(Token = "0x400FE02")]
    [FieldOffset(Offset = "0x48")]
    private ShopLoader shopLoader;
    [Token(Token = "0x400FE03")]
    [FieldOffset(Offset = "0x50")]
    private MedalShopLoader medalShopLoader;
    [Token(Token = "0x400FE04")]
    [FieldOffset(Offset = "0x58")]
    private ShopAPIManager shopAPI;
    [Token(Token = "0x400FE05")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private OutGameMenuBelowScreenHandler belowScreenHandler;
    [Token(Token = "0x400FE06")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private RectTransform buttonParent;
    [Token(Token = "0x400FE07")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private Image scrollBg;
    [Token(Token = "0x400FE08")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private GameObject[] arrowIcons;
    [Token(Token = "0x400FE09")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x400FE0A")]
    [FieldOffset(Offset = "0x88")]
    private GameObject listSideGroup;
    [Token(Token = "0x400FE0B")]
    [FieldOffset(Offset = "0x90")]
    private PosessionMedalList createdListSideGroup;
    [Token(Token = "0x400FE0C")]
    [FieldOffset(Offset = "0x98")]
    private GlobalShopBelowScreen shopBelowScreen;
    [Token(Token = "0x400FE0D")]
    [FieldOffset(Offset = "0xA0")]
    private OutGameMenuSubScene.OutGameMenuID? backMenuId;
    [Token(Token = "0x400FE0E")]
    [FieldOffset(Offset = "0xA8")]
    private int shopListIndex;
    [Token(Token = "0x400FE0F")]
    [FieldOffset(Offset = "0xB0")]
    private List<GlobalShopSideMenuButton> globalShopSideMenuList;
    [Token(Token = "0x400FE10")]
    [FieldOffset(Offset = "0xB8")]
    private bool isGotoMedalShop;
    [Token(Token = "0x400FE11")]
    [FieldOffset(Offset = "0xBC")]
    private int medalShopId;
    [Token(Token = "0x400FE12")]
    [FieldOffset(Offset = "0xC0")]
    private bool isGotoSaleShop;

    [Token(Token = "0x17004AD7")]
    public ShopLoader ShopLoader
    {
      [Token(Token = "0x6016CCE"), Address(RVA = "0x2C53990", Offset = "0x2C53990", VA = "0x2C53990")] get
      {
        return (ShopLoader) null;
      }
    }

    [Token(Token = "0x17004AD8")]
    public ShopAPIManager ShopAPI
    {
      [Token(Token = "0x6016CCF"), Address(RVA = "0x2C53998", Offset = "0x2C53998", VA = "0x2C53998")] get
      {
        return (ShopAPIManager) null;
      }
    }

    [Token(Token = "0x17004AD9")]
    private bool IsAnyAnimationPlaying
    {
      [Token(Token = "0x6016CD0"), Address(RVA = "0x2C539A0", Offset = "0x2C539A0", VA = "0x2C539A0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004ADA")]
    private bool IsBelowScreenDirection
    {
      [Token(Token = "0x6016CD1"), Address(RVA = "0x2C539B4", Offset = "0x2C539B4", VA = "0x2C539B4")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6016CD2")]
    [Address(RVA = "0x2C53A40", Offset = "0x2C53A40", VA = "0x2C53A40")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6016CD3")]
    [Address(RVA = "0x2C53A54", Offset = "0x2C53A54", VA = "0x2C53A54")]
    private void ChangeActiveArrowIcons(bool isActive)
    {
    }

    [Token(Token = "0x6016CD4")]
    [Address(RVA = "0x2C53B48", Offset = "0x2C53B48", VA = "0x2C53B48")]
    public void UpdateBadgeIcon()
    {
    }

    [Token(Token = "0x6016CD5")]
    [Address(RVA = "0x2C53C98", Offset = "0x2C53C98", VA = "0x2C53C98", Slot = "4")]
    public override void Initialize(ChangeSubjectScreenParameter param = null)
    {
    }

    [Token(Token = "0x6016CD6")]
    [Address(RVA = "0x2C53D50", Offset = "0x2C53D50", VA = "0x2C53D50")]
    private IEnumerator InitToGlobalShop() => (IEnumerator) null;

    [Token(Token = "0x6016CD7")]
    [Address(RVA = "0x2C53DE0", Offset = "0x2C53DE0", VA = "0x2C53DE0")]
    private IEnumerator InitToMedalShop(Action finishAction = null) => (IEnumerator) null;

    [Token(Token = "0x6016CD8")]
    [Address(RVA = "0x2C53E7C", Offset = "0x2C53E7C", VA = "0x2C53E7C", Slot = "5")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x6016CD9")]
    [Address(RVA = "0x2C53F0C", Offset = "0x2C53F0C", VA = "0x2C53F0C")]
    public void OnClickButton(int index)
    {
    }

    [Token(Token = "0x6016CDA")]
    [Address(RVA = "0x2C54630", Offset = "0x2C54630", VA = "0x2C54630", Slot = "7")]
    public override void Open(OutGameMenuSubScene.OutGameMenuID id)
    {
    }

    [Token(Token = "0x6016CDB")]
    [Address(RVA = "0x2C5477C", Offset = "0x2C5477C", VA = "0x2C5477C")]
    private IEnumerator OpenInternal() => (IEnumerator) null;

    [Token(Token = "0x6016CDC")]
    [Address(RVA = "0x2C5480C", Offset = "0x2C5480C", VA = "0x2C5480C", Slot = "8")]
    public override void Close(OutGameMenuSubScene.OutGameMenuID id)
    {
    }

    [Token(Token = "0x6016CDD")]
    [Address(RVA = "0x2C5488C", Offset = "0x2C5488C", VA = "0x2C5488C")]
    private IEnumerator CloseInternal() => (IEnumerator) null;

    [Token(Token = "0x6016CDE")]
    [Address(RVA = "0x2C5491C", Offset = "0x2C5491C", VA = "0x2C5491C")]
    private IEnumerator ChangeBelowScreen(ShopLoader.ShopAssetType shopAssetType, Action onFinish)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6016CDF")]
    [Address(RVA = "0x2C549C4", Offset = "0x2C549C4", VA = "0x2C549C4")]
    private IEnumerator ChangeBelowScreen(
      MedalShopLoader.ShopAssetType shopAssetType,
      Action onFinish)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6016CE0")]
    [Address(RVA = "0x2C54A6C", Offset = "0x2C54A6C", VA = "0x2C54A6C")]
    public void OperationPossible(bool flg)
    {
    }

    [Token(Token = "0x6016CE1")]
    [Address(RVA = "0x2C54B20", Offset = "0x2C54B20", VA = "0x2C54B20")]
    public void SetSideButtonActive(bool isActive)
    {
    }

    [Token(Token = "0x6016CE2")]
    [Address(RVA = "0x2C54B88", Offset = "0x2C54B88", VA = "0x2C54B88")]
    public void SetupMedalList()
    {
    }

    [Token(Token = "0x6016CE3")]
    [Address(RVA = "0x2C54F34", Offset = "0x2C54F34", VA = "0x2C54F34")]
    private void OnMedalShopListBackScene()
    {
    }

    [Token(Token = "0x6016CE4")]
    [Address(RVA = "0x2C55164", Offset = "0x2C55164", VA = "0x2C55164")]
    public void OnClickToMedalShopTopButton(int medalShopId)
    {
    }

    [Token(Token = "0x6016CE5")]
    [Address(RVA = "0x2C55598", Offset = "0x2C55598", VA = "0x2C55598", Slot = "6")]
    public override void Destroy()
    {
    }

    [Token(Token = "0x6016CE6")]
    [Address(RVA = "0x2C55860", Offset = "0x2C55860", VA = "0x2C55860")]
    public OutGameMenuGlobalShopSubjectScreen()
    {
    }

    [Token(Token = "0x2003A0B")]
    public class OutGameMenuGlobalShopSubjectParameter : ChangeSubjectScreenParameter
    {
      [Token(Token = "0x17004ADB")]
      public bool IsGotoMedalShop
      {
        [Token(Token = "0x6016CF4"), Address(RVA = "0x2C55C84", Offset = "0x2C55C84", VA = "0x2C55C84")] get
        {
          return new bool();
        }
        [Token(Token = "0x6016CF5"), Address(RVA = "0x2C55C8C", Offset = "0x2C55C8C", VA = "0x2C55C8C")] private set
        {
        }
      }

      [Token(Token = "0x17004ADC")]
      public int MedalShopID
      {
        [Token(Token = "0x6016CF6"), Address(RVA = "0x2C55C98", Offset = "0x2C55C98", VA = "0x2C55C98")] get
        {
          return new int();
        }
        [Token(Token = "0x6016CF7"), Address(RVA = "0x2C55CA0", Offset = "0x2C55CA0", VA = "0x2C55CA0")] private set
        {
        }
      }

      [Token(Token = "0x17004ADD")]
      public bool IsGotoSaleShop
      {
        [Token(Token = "0x6016CF8"), Address(RVA = "0x2C55CA8", Offset = "0x2C55CA8", VA = "0x2C55CA8")] get
        {
          return new bool();
        }
        [Token(Token = "0x6016CF9"), Address(RVA = "0x2C55CB0", Offset = "0x2C55CB0", VA = "0x2C55CB0")] private set
        {
        }
      }

      [Token(Token = "0x17004ADE")]
      public OutGameMenuSubScene.OutGameMenuID? BackMenuID
      {
        [Token(Token = "0x6016CFA"), Address(RVA = "0x2C55CBC", Offset = "0x2C55CBC", VA = "0x2C55CBC")] get
        {
          return new OutGameMenuSubScene.OutGameMenuID?();
        }
        [Token(Token = "0x6016CFB"), Address(RVA = "0x2C55CC4", Offset = "0x2C55CC4", VA = "0x2C55CC4")] private set
        {
        }
      }

      [Token(Token = "0x6016CFC")]
      [Address(RVA = "0x2C55CCC", Offset = "0x2C55CCC", VA = "0x2C55CCC")]
      public OutGameMenuGlobalShopSubjectParameter(
        bool isGotoMedalShop,
        int medalShopId,
        OutGameMenuSubScene.OutGameMenuID? backMenuId)
      {
      }

      [Token(Token = "0x6016CFD")]
      [Address(RVA = "0x2C55D10", Offset = "0x2C55D10", VA = "0x2C55D10")]
      public OutGameMenuGlobalShopSubjectParameter(
        bool isGotoSaleShop,
        OutGameMenuSubScene.OutGameMenuID? backMenuId)
      {
      }
    }
  }
}
