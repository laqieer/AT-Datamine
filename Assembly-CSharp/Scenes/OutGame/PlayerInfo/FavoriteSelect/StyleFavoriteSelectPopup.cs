// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.PlayerInfo.FavoriteSelect.StyleFavoriteSelectPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Popup;
using Il2CppDummyDll;
using Scenes.OutGame.OutGameMenu;
using Scenes.OutGame.Utility;
using StaqData;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.PlayerInfo.FavoriteSelect
{
  [Token(Token = "0x20034C2")]
  [AddComponentMenu("Scenes/OutGame/PlayerInfo/FavoriteSelect/Popup")]
  public class StyleFavoriteSelectPopup : PopupBase, IStyleInventory
  {
    [Token(Token = "0x400E59D")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private ScrollRect scrollRect;
    [Token(Token = "0x400E59E")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private GameObject srcBase;
    [Token(Token = "0x400E59F")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private HorizontalLayoutGroup horizontalLayoutGroup;
    [Token(Token = "0x400E5A0")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private HorizontalInfiniteScrollView infiniteScrollView;
    [Token(Token = "0x400E5A1")]
    private const int baseEntryMax = 3;
    [Token(Token = "0x400E5A2")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private int leftMargin;
    [Token(Token = "0x400E5A3")]
    [FieldOffset(Offset = "0xAC")]
    [SerializeField]
    private int rightMargin;
    [Token(Token = "0x400E5A6")]
    [FieldOffset(Offset = "0xB8")]
    private Coroutine loadAssetBundleCoroutine;
    [Token(Token = "0x400E5A7")]
    [FieldOffset(Offset = "0xC0")]
    private float constPosX;
    [Token(Token = "0x400E5A8")]
    private const float scrollAdjustmentTime = 0.25f;
    [Token(Token = "0x400E5A9")]
    [FieldOffset(Offset = "0xC8")]
    private Style[] styles;
    [Token(Token = "0x400E5AA")]
    [FieldOffset(Offset = "0xD0")]
    private List<StyleThumb> styleThumbList;
    [Token(Token = "0x400E5AB")]
    [FieldOffset(Offset = "0xD8")]
    private List<string>[] loadWaitStyleId;
    [Token(Token = "0x400E5AC")]
    [FieldOffset(Offset = "0xE0")]
    private int loadWaitStyleIdOfs;
    [Token(Token = "0x400E5B0")]
    [FieldOffset(Offset = "0xF8")]
    private int selectedStyleId;
    [Token(Token = "0x400E5B1")]
    [FieldOffset(Offset = "0x100")]
    private Action<int> onChangeStyleId;
    [Token(Token = "0x400E5B2")]
    [FieldOffset(Offset = "0x108")]
    private bool disabledClick;
    [Token(Token = "0x400E5B3")]
    [FieldOffset(Offset = "0x0")]
    public static readonly string AssetBundleName;
    [Token(Token = "0x400E5B4")]
    [FieldOffset(Offset = "0x8")]
    public static readonly string AssetName;

    [Token(Token = "0x170044A2")]
    public int BaseEntryMax
    {
      [Token(Token = "0x6014B2C"), Address(RVA = "0x1D6CA90", Offset = "0x1D6CA90", VA = "0x1D6CA90", Slot = "12")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170044A3")]
    public float ListItemWidth
    {
      [Token(Token = "0x6014B2D"), Address(RVA = "0x1D6CA98", Offset = "0x1D6CA98", VA = "0x1D6CA98", Slot = "10")] get
      {
        return new float();
      }
      [Token(Token = "0x6014B2E"), Address(RVA = "0x1D6CAA0", Offset = "0x1D6CAA0", VA = "0x1D6CAA0")] private set
      {
      }
    }

    [Token(Token = "0x170044A4")]
    public float ListItemHeight
    {
      [Token(Token = "0x6014B2F"), Address(RVA = "0x1D6CAA8", Offset = "0x1D6CAA8", VA = "0x1D6CAA8")] get
      {
        return new float();
      }
      [Token(Token = "0x6014B30"), Address(RVA = "0x1D6CAB0", Offset = "0x1D6CAB0", VA = "0x1D6CAB0")] private set
      {
      }
    }

    [Token(Token = "0x170044A5")]
    public int ThumbSelectedIndex
    {
      [Token(Token = "0x6014B31"), Address(RVA = "0x1D6CAB8", Offset = "0x1D6CAB8", VA = "0x1D6CAB8", Slot = "11")] get
      {
        return new int();
      }
      [Token(Token = "0x6014B32"), Address(RVA = "0x1D6CAC0", Offset = "0x1D6CAC0", VA = "0x1D6CAC0")] private set
      {
      }
    }

    [Token(Token = "0x170044A6")]
    public NewBadgeProxy NewBadgeProxy
    {
      [Token(Token = "0x6014B33"), Address(RVA = "0x1D6CAC8", Offset = "0x1D6CAC8", VA = "0x1D6CAC8", Slot = "13")] get
      {
        return (NewBadgeProxy) null;
      }
      [Token(Token = "0x6014B34"), Address(RVA = "0x1D6CAD0", Offset = "0x1D6CAD0", VA = "0x1D6CAD0")] private set
      {
      }
    }

    [Token(Token = "0x170044A7")]
    public AssetCachedSpawner AssetSpawner
    {
      [Token(Token = "0x6014B35"), Address(RVA = "0x1D6CAD8", Offset = "0x1D6CAD8", VA = "0x1D6CAD8", Slot = "19")] get
      {
        return (AssetCachedSpawner) null;
      }
      [Token(Token = "0x6014B36"), Address(RVA = "0x1D6CAE0", Offset = "0x1D6CAE0", VA = "0x1D6CAE0")] private set
      {
      }
    }

    [Token(Token = "0x6014B37")]
    [Address(RVA = "0x1D69910", Offset = "0x1D69910", VA = "0x1D69910")]
    public static void Show(
      AssetCachedSpawner spawner,
      int selectedStyleId,
      Action<int> callbackChangeStyleId)
    {
    }

    [Token(Token = "0x6014B38")]
    [Address(RVA = "0x1D6CAF0", Offset = "0x1D6CAF0", VA = "0x1D6CAF0")]
    private void Initialize()
    {
    }

    [Token(Token = "0x6014B39")]
    [Address(RVA = "0x1D6CB20", Offset = "0x1D6CB20", VA = "0x1D6CB20")]
    private IEnumerator Start() => (IEnumerator) null;

    [Token(Token = "0x6014B3A")]
    [Address(RVA = "0x1D6CBB0", Offset = "0x1D6CBB0", VA = "0x1D6CBB0")]
    private void ResetFocus(bool waitFrame, Action onFinished = null)
    {
    }

    [Token(Token = "0x6014B3B")]
    [Address(RVA = "0x1D6CD64", Offset = "0x1D6CD64", VA = "0x1D6CD64")]
    private IEnumerator DelayExecute(Action execute, int waitFrame = 1) => (IEnumerator) null;

    [Token(Token = "0x6014B3C")]
    [Address(RVA = "0x1D6CE68", Offset = "0x1D6CE68", VA = "0x1D6CE68", Slot = "4")]
    public override void Destroy()
    {
    }

    [Token(Token = "0x6014B3D")]
    [Address(RVA = "0x1D6CFC8", Offset = "0x1D6CFC8", VA = "0x1D6CFC8")]
    private void WithRefreshedThumbIndex(Action listUpdater, bool immidiateSnap = false)
    {
    }

    [Token(Token = "0x6014B3E")]
    [Address(RVA = "0x1D6D304", Offset = "0x1D6D304", VA = "0x1D6D304")]
    public void UpdateStyleList()
    {
    }

    [Token(Token = "0x6014B3F")]
    [Address(RVA = "0x1D6D40C", Offset = "0x1D6D40C", VA = "0x1D6D40C")]
    private void OnDisable()
    {
    }

    [Token(Token = "0x6014B40")]
    [Address(RVA = "0x1D6D440", Offset = "0x1D6D440", VA = "0x1D6D440")]
    private void CreateStyleList()
    {
    }

    [Token(Token = "0x6014B41")]
    [Address(RVA = "0x1D6D6BC", Offset = "0x1D6D6BC", VA = "0x1D6D6BC")]
    private void SetStyleList()
    {
    }

    [Token(Token = "0x6014B42")]
    [Address(RVA = "0x1D6D824", Offset = "0x1D6D824", VA = "0x1D6D824", Slot = "14")]
    public void AddStyleThumb(StyleThumb styleThumb)
    {
    }

    [Token(Token = "0x6014B43")]
    [Address(RVA = "0x1D6D93C", Offset = "0x1D6D93C", VA = "0x1D6D93C", Slot = "15")]
    public void RemoveStyleThumb(StyleThumb styleThumb)
    {
    }

    [Token(Token = "0x6014B44")]
    [Address(RVA = "0x1D6D9E4", Offset = "0x1D6D9E4", VA = "0x1D6D9E4", Slot = "16")]
    public Style[] GetThumbStyleList(int index) => (Style[]) null;

    [Token(Token = "0x6014B45")]
    [Address(RVA = "0x1D6DAD0", Offset = "0x1D6DAD0", VA = "0x1D6DAD0", Slot = "17")]
    public void AddLoadAssetBundle(string name)
    {
    }

    [Token(Token = "0x6014B46")]
    [Address(RVA = "0x1D6D3A4", Offset = "0x1D6D3A4", VA = "0x1D6D3A4")]
    public IEnumerator SetLoadingAssetBundle() => (IEnumerator) null;

    [Token(Token = "0x6014B47")]
    [Address(RVA = "0x1D6DBC0", Offset = "0x1D6DBC0", VA = "0x1D6DBC0", Slot = "18")]
    public void ThumbOnClick(int index)
    {
    }

    [Token(Token = "0x6014B48")]
    [Address(RVA = "0x1D6D158", Offset = "0x1D6D158", VA = "0x1D6D158")]
    public void SetThumbSelectIndex(int index)
    {
    }

    [Token(Token = "0x6014B49")]
    [Address(RVA = "0x1D6DBD0", Offset = "0x1D6DBD0", VA = "0x1D6DBD0")]
    public void OnClickDecide()
    {
    }

    [Token(Token = "0x6014B4A")]
    [Address(RVA = "0x1D6DD14", Offset = "0x1D6DD14", VA = "0x1D6DD14")]
    private IEnumerator ChangeSymbolEditUnit(int styleId) => (IEnumerator) null;

    [Token(Token = "0x6014B4B")]
    [Address(RVA = "0x1D6DDB4", Offset = "0x1D6DDB4", VA = "0x1D6DDB4", Slot = "5")]
    public override void OnClickClose()
    {
    }

    [Token(Token = "0x6014B4C")]
    [Address(RVA = "0x1D6DDD4", Offset = "0x1D6DDD4", VA = "0x1D6DDD4")]
    public StyleFavoriteSelectPopup()
    {
    }

    [Token(Token = "0x6014B4D")]
    [Address(RVA = "0x1D6DE4C", Offset = "0x1D6DE4C", VA = "0x1D6DE4C")]
    static StyleFavoriteSelectPopup()
    {
    }
  }
}
