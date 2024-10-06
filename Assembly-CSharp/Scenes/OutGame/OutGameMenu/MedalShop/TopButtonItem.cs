// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.MedalShop.TopButtonItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using Il2CppDummyDll;
using System;
using UI;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.OutGameMenu.MedalShop
{
  [Token(Token = "0x2003B32")]
  public class TopButtonItem : MonoBehaviour
  {
    [Token(Token = "0x4010554")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private RectTransform rectTransform;
    [Token(Token = "0x4010555")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private CommonButton button;
    [Token(Token = "0x4010556")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject medalParent;
    [Token(Token = "0x4010557")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Image payIcon;
    [Token(Token = "0x4010558")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private TextAccessor medalNum;
    [Token(Token = "0x4010559")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private TextAccessor title;
    [Token(Token = "0x401055A")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Image banner;
    [Token(Token = "0x401055B")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private TextAccessor limitTimeObj;
    [Token(Token = "0x401055D")]
    [FieldOffset(Offset = "0x60")]
    private int shopId;
    [Token(Token = "0x401055E")]
    [FieldOffset(Offset = "0x68")]
    private Coroutine bannerCoroutine;
    [Token(Token = "0x401055F")]
    [FieldOffset(Offset = "0x70")]
    private MedalShopLoader loader;
    [Token(Token = "0x4010560")]
    [FieldOffset(Offset = "0x78")]
    private bool isInitializeEnd;
    [Token(Token = "0x4010561")]
    [FieldOffset(Offset = "0x80")]
    private DateTime? limitTime;
    [Token(Token = "0x4010562")]
    [FieldOffset(Offset = "0x90")]
    private bool isTimeLimit;
    [Token(Token = "0x4010563")]
    [FieldOffset(Offset = "0x94")]
    private int bannerId;
    [Token(Token = "0x4010564")]
    [FieldOffset(Offset = "0x98")]
    private string remainTitle;
    [Token(Token = "0x4010565")]
    [FieldOffset(Offset = "0xA0")]
    private MedalTradePrizeResetData resetData;

    [Token(Token = "0x17004BFA")]
    public RectTransform RectTransform
    {
      [Token(Token = "0x60174B4"), Address(RVA = "0x271DC38", Offset = "0x271DC38", VA = "0x271DC38")] get
      {
        return (RectTransform) null;
      }
    }

    [Token(Token = "0x17004BFB")]
    public Action<int> OnClick
    {
      [Token(Token = "0x60174B5"), Address(RVA = "0x271DC40", Offset = "0x271DC40", VA = "0x271DC40")] get
      {
        return (Action<int>) null;
      }
      [Token(Token = "0x60174B6"), Address(RVA = "0x271DC48", Offset = "0x271DC48", VA = "0x271DC48")] set
      {
      }
    }

    [Token(Token = "0x60174B7")]
    [Address(RVA = "0x2711AD4", Offset = "0x2711AD4", VA = "0x2711AD4")]
    public void Initialize(
      AssetCachedSpawner spawner,
      MedalTradeShopData shopData,
      MedalShopLoader loader)
    {
    }

    [Token(Token = "0x60174B8")]
    [Address(RVA = "0x271DDEC", Offset = "0x271DDEC", VA = "0x271DDEC")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x60174B9")]
    [Address(RVA = "0x271DDFC", Offset = "0x271DDFC", VA = "0x271DDFC")]
    private void OnDisable()
    {
    }

    [Token(Token = "0x60174BA")]
    [Address(RVA = "0x271DE20", Offset = "0x271DE20", VA = "0x271DE20")]
    public void OnClickToBanner()
    {
    }

    [Token(Token = "0x60174BB")]
    [Address(RVA = "0x271DE48", Offset = "0x271DE48", VA = "0x271DE48")]
    private void Update()
    {
    }

    [Token(Token = "0x60174BC")]
    [Address(RVA = "0x271DC50", Offset = "0x271DC50", VA = "0x271DC50")]
    private DateTime GetRenewalDateTime() => new DateTime();

    [Token(Token = "0x60174BD")]
    [Address(RVA = "0x271DD38", Offset = "0x271DD38", VA = "0x271DD38")]
    private void SetupRawDataTexture()
    {
    }

    [Token(Token = "0x60174BE")]
    [Address(RVA = "0x271E0E8", Offset = "0x271E0E8", VA = "0x271E0E8")]
    public TopButtonItem()
    {
    }
  }
}
