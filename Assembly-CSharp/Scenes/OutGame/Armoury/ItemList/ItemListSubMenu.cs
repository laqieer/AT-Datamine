// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Armoury.ItemList.ItemListSubMenu
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Input;
using Il2CppDummyDll;
using StaqData;
using System;
using System.Collections;
using TMPro;
using UI.Direction;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.Armoury.ItemList
{
  [Token(Token = "0x200387A")]
  public class ItemListSubMenu : MonoBehaviour
  {
    [Token(Token = "0x400F69C")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITimelineController timelineController;
    [Token(Token = "0x400F69D")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private CanvasGroup rightCanvasGroup;
    [Token(Token = "0x400F69E")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private CommonButton closeButton;
    [Token(Token = "0x400F69F")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Image thumbImage;
    [Token(Token = "0x400F6A0")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Image rarityImage;
    [Token(Token = "0x400F6A1")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private TextMeshProUGUI itemNameText;
    [Token(Token = "0x400F6A2")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private TextMeshProUGUI possessionText;
    [Token(Token = "0x400F6A3")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private TextMeshProUGUI itemInfoText;
    [Token(Token = "0x400F6A4")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private CommonButton saleButton;
    [Token(Token = "0x400F6A5")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private GameObject notSaleObject;
    [Token(Token = "0x400F6A6")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private GameObject useButtonRoot;
    [Token(Token = "0x400F6A7")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private CommonButton useButton;
    [Token(Token = "0x400F6A8")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private BackKeyHandlerComponent backKeyHandlerComponent;
    [Token(Token = "0x400F6A9")]
    [FieldOffset(Offset = "0x80")]
    private AssetCachedSpawner assetCachedSpawner;

    [Token(Token = "0x601633E")]
    [Address(RVA = "0x1DF5AA0", Offset = "0x1DF5AA0", VA = "0x1DF5AA0")]
    public static IEnumerator SpawnAsync(
      AssetCachedSpawner spawner,
      Transform parent,
      Action<ItemListSubMenu> onCompleted)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x601633F")]
    [Address(RVA = "0x1DF5B1C", Offset = "0x1DF5B1C", VA = "0x1DF5B1C")]
    public IEnumerator InitializeAsync(Action onSaleDialog, Action onUseDialog, Action onClose)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6016340")]
    [Address(RVA = "0x1DF393C", Offset = "0x1DF393C", VA = "0x1DF393C")]
    public void Refresh(Item itemData)
    {
    }

    [Token(Token = "0x6016341")]
    [Address(RVA = "0x1DF4DE8", Offset = "0x1DF4DE8", VA = "0x1DF4DE8")]
    public void RefreshItemAmount(Item itemData)
    {
    }

    [Token(Token = "0x6016342")]
    [Address(RVA = "0x1DF6654", Offset = "0x1DF6654", VA = "0x1DF6654")]
    private bool IsActiveUseButton(Item itemData) => new bool();

    [Token(Token = "0x6016343")]
    [Address(RVA = "0x1DF4024", Offset = "0x1DF4024", VA = "0x1DF4024")]
    public void PlayIn()
    {
    }

    [Token(Token = "0x6016344")]
    [Address(RVA = "0x1DF3C34", Offset = "0x1DF3C34", VA = "0x1DF3C34")]
    public void PlayOut()
    {
    }

    [Token(Token = "0x6016345")]
    [Address(RVA = "0x1DF3660", Offset = "0x1DF3660", VA = "0x1DF3660")]
    public void Disable()
    {
    }

    [Token(Token = "0x6016346")]
    [Address(RVA = "0x1DF6680", Offset = "0x1DF6680", VA = "0x1DF6680")]
    public ItemListSubMenu()
    {
    }
  }
}
