// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.MedalShop.MedalShopBelowScreen
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UI.Direction;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.OutGameMenu.MedalShop
{
  [Token(Token = "0x2003B09")]
  public class MedalShopBelowScreen : OutGameMenuBelowScreenBase
  {
    [Token(Token = "0x401044F")]
    [FieldOffset(Offset = "0x48")]
    private MedalShopLoader shopLoader;
    [Token(Token = "0x4010450")]
    [FieldOffset(Offset = "0x50")]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x4010451")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private TopButtonItem baseItem;
    [Token(Token = "0x4010452")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private RectTransform bannerParent;
    [Token(Token = "0x4010453")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private UITimelineController uiTimelineController;
    [Token(Token = "0x4010454")]
    [FieldOffset(Offset = "0x70")]
    private List<TopButtonItem> createdItem;
    [Token(Token = "0x4010455")]
    [FieldOffset(Offset = "0x78")]
    private Action<bool> onSetSideButtonActive;
    [Token(Token = "0x4010456")]
    [FieldOffset(Offset = "0x80")]
    private Action<int> onMoveMedalShop;
    [Token(Token = "0x4010457")]
    [FieldOffset(Offset = "0x88")]
    private bool isMovedSubScene;
    [Token(Token = "0x4010458")]
    [FieldOffset(Offset = "0x8C")]
    private int selectedGlobalShopIndex;
    [Token(Token = "0x4010459")]
    [FieldOffset(Offset = "0x90")]
    private bool isPassShop;
    [Token(Token = "0x401045A")]
    [FieldOffset(Offset = "0x91")]
    private bool isInitializeEnd;
    [Token(Token = "0x401045B")]
    [FieldOffset(Offset = "0x94")]
    private OutGameMenuSubScene.OutGameMenuID? backMenuId;

    [Token(Token = "0x17004BC7")]
    private bool IsBelowScreenDirection
    {
      [Token(Token = "0x60173A3"), Address(RVA = "0x301E0B4", Offset = "0x301E0B4", VA = "0x301E0B4")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x60173A4")]
    [Address(RVA = "0x301E140", Offset = "0x301E140", VA = "0x301E140")]
    public void SetHeaderText()
    {
    }

    [Token(Token = "0x60173A5")]
    [Address(RVA = "0x301E270", Offset = "0x301E270", VA = "0x301E270", Slot = "4")]
    public override void Initialize(ChangeBelowScreenParameter param = null)
    {
    }

    [Token(Token = "0x60173A6")]
    [Address(RVA = "0x301E3C8", Offset = "0x301E3C8", VA = "0x301E3C8", Slot = "5")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x60173A7")]
    [Address(RVA = "0x301E430", Offset = "0x301E430", VA = "0x301E430")]
    private IEnumerator SetupTimeline() => (IEnumerator) null;

    [Token(Token = "0x60173A8")]
    [Address(RVA = "0x301E498", Offset = "0x301E498", VA = "0x301E498")]
    public void DummyCatalogOperationPossible(bool flg)
    {
    }

    [Token(Token = "0x60173A9")]
    [Address(RVA = "0x301E4A4", Offset = "0x301E4A4", VA = "0x301E4A4", Slot = "7")]
    public override void Open(string preBelowName)
    {
    }

    [Token(Token = "0x60173AA")]
    [Address(RVA = "0x301E6A4", Offset = "0x301E6A4", VA = "0x301E6A4", Slot = "8")]
    public override void Close(string nextBelowName)
    {
    }

    [Token(Token = "0x60173AB")]
    [Address(RVA = "0x301E930", Offset = "0x301E930", VA = "0x301E930", Slot = "9")]
    public override void OnBackSubScene()
    {
    }

    [Token(Token = "0x60173AC")]
    [Address(RVA = "0x301EB98", Offset = "0x301EB98", VA = "0x301EB98")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x60173AD")]
    [Address(RVA = "0x301EDA8", Offset = "0x301EDA8", VA = "0x301EDA8")]
    public MedalShopBelowScreen()
    {
    }

    [Token(Token = "0x2003B0A")]
    public class MedalShopBelowScreenParameter : ChangeBelowScreenParameter
    {
      [Token(Token = "0x401045E")]
      [FieldOffset(Offset = "0x20")]
      private AssetCachedSpawner cachedSpawner;
      [Token(Token = "0x401045F")]
      [FieldOffset(Offset = "0x28")]
      private int nowShopIndex;
      [Token(Token = "0x4010460")]
      [FieldOffset(Offset = "0x2C")]
      private bool isPassShop;
      [Token(Token = "0x4010461")]
      [FieldOffset(Offset = "0x30")]
      private Action<bool> onSetSideButtonActive;
      [Token(Token = "0x4010462")]
      [FieldOffset(Offset = "0x38")]
      private Action<int> onMoveMedalShop;

      [Token(Token = "0x17004BC8")]
      public OutGameMenuSubScene.OutGameMenuID? BackMenuID
      {
        [Token(Token = "0x60173B4"), Address(RVA = "0x2710FE4", Offset = "0x2710FE4", VA = "0x2710FE4")] get
        {
          return new OutGameMenuSubScene.OutGameMenuID?();
        }
        [Token(Token = "0x60173B5"), Address(RVA = "0x2710FEC", Offset = "0x2710FEC", VA = "0x2710FEC")] private set
        {
        }
      }

      [Token(Token = "0x17004BC9")]
      public bool IsGotoMedalShop
      {
        [Token(Token = "0x60173B6"), Address(RVA = "0x2710FF4", Offset = "0x2710FF4", VA = "0x2710FF4")] get
        {
          return new bool();
        }
        [Token(Token = "0x60173B7"), Address(RVA = "0x2710FFC", Offset = "0x2710FFC", VA = "0x2710FFC")] private set
        {
        }
      }

      [Token(Token = "0x17004BCA")]
      public AssetCachedSpawner CachedSpawner
      {
        [Token(Token = "0x60173B8"), Address(RVA = "0x2711008", Offset = "0x2711008", VA = "0x2711008")] get
        {
          return (AssetCachedSpawner) null;
        }
      }

      [Token(Token = "0x17004BCB")]
      public int NowShopIndex
      {
        [Token(Token = "0x60173B9"), Address(RVA = "0x2711010", Offset = "0x2711010", VA = "0x2711010")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x17004BCC")]
      public bool IsPassShop
      {
        [Token(Token = "0x60173BA"), Address(RVA = "0x2711018", Offset = "0x2711018", VA = "0x2711018")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x17004BCD")]
      public Action<bool> OnSetSideButtonActive
      {
        [Token(Token = "0x60173BB"), Address(RVA = "0x2711020", Offset = "0x2711020", VA = "0x2711020")] get
        {
          return (Action<bool>) null;
        }
      }

      [Token(Token = "0x17004BCE")]
      public Action<int> OnMoveMedalShop
      {
        [Token(Token = "0x60173BC"), Address(RVA = "0x2711028", Offset = "0x2711028", VA = "0x2711028")] get
        {
          return (Action<int>) null;
        }
      }

      [Token(Token = "0x60173BD")]
      [Address(RVA = "0x2711030", Offset = "0x2711030", VA = "0x2711030")]
      public MedalShopBelowScreenParameter(
        bool isGotoMedalShop,
        AssetCachedSpawner cachedSpawner,
        Action<bool> onSetSideButtonActive,
        Action<int> onMoveMedalShop,
        OutGameMenuSubScene.OutGameMenuID? backMenuId)
      {
      }

      [Token(Token = "0x60173BE")]
      [Address(RVA = "0x2711088", Offset = "0x2711088", VA = "0x2711088")]
      public MedalShopBelowScreenParameter(
        int shopListIndex,
        bool isPassShop,
        bool isGotoMedalShop,
        AssetCachedSpawner cachedSpawner,
        Action<bool> onSetSideButtonActive,
        Action<int> onMoveMedalShop,
        OutGameMenuSubScene.OutGameMenuID? backMenuId)
      {
      }
    }
  }
}
