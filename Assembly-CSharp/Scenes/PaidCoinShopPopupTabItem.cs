// Decompiled with JetBrains decompiler
// Type: Scenes.PaidCoinShopPopupTabItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Tween;
using Il2CppDummyDll;
using Network.Param;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
namespace Scenes
{
  [Token(Token = "0x20028AA")]
  public class PaidCoinShopPopupTabItem : MonoBehaviour
  {
    [Token(Token = "0x400ADA0")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x400ADA1")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text tabName;
    [Token(Token = "0x400ADA2")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Transform limitParent;
    [Token(Token = "0x400ADA3")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private CommonButton button;
    [Token(Token = "0x400ADA4")]
    [FieldOffset(Offset = "0x38")]
    [HideInInspector]
    public PlayerCoinShopType CoinShopType;
    [Token(Token = "0x400ADA5")]
    [FieldOffset(Offset = "0x40")]
    [HideInInspector]
    public PaidCoinShopPopupTabItem.TabTypeEnum TabType;

    [Token(Token = "0x1700383A")]
    public UITweenGroup TweenGroup
    {
      [Token(Token = "0x6010015"), Address(RVA = "0x4165900", Offset = "0x4165900", VA = "0x4165900")] get
      {
        return (UITweenGroup) null;
      }
    }

    [Token(Token = "0x6010016")]
    [Address(RVA = "0x4165908", Offset = "0x4165908", VA = "0x4165908")]
    public void Init(
      int tabIndex,
      PlayerCoinShopType coinShopType,
      UnityAction<int> action,
      AssetCachedSpawner spawner)
    {
    }

    [Token(Token = "0x6010017")]
    [Address(RVA = "0x4165C7C", Offset = "0x4165C7C", VA = "0x4165C7C")]
    public void SelectCursor()
    {
    }

    [Token(Token = "0x6010018")]
    [Address(RVA = "0x4165CD4", Offset = "0x4165CD4", VA = "0x4165CD4")]
    public void UnSelectCursor()
    {
    }

    [Token(Token = "0x6010019")]
    [Address(RVA = "0x4165D2C", Offset = "0x4165D2C", VA = "0x4165D2C")]
    public PaidCoinShopPopupTabItem()
    {
    }

    [Token(Token = "0x20028AB")]
    public enum TabTypeEnum
    {
      [Token(Token = "0x400ADA7")] Single,
      [Token(Token = "0x400ADA8")] Set,
    }
  }
}
