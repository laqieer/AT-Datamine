// Decompiled with JetBrains decompiler
// Type: SoulSpotBoxForcementPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Popup;
using GameCore.Tween;
using Il2CppDummyDll;
using Network.Param;
using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x200026A")]
public class SoulSpotBoxForcementPopup : PopupBase
{
  [Token(Token = "0x4000E43")]
  private const string enoughColor = "NormalValueColor";
  [Token(Token = "0x4000E44")]
  private const string notEnoughColor = "MinusValueColor";
  [Token(Token = "0x4000E45")]
  [FieldOffset(Offset = "0x88")]
  [SerializeField]
  private CommonButton lawBtn;
  [Token(Token = "0x4000E46")]
  [FieldOffset(Offset = "0x90")]
  [SerializeField]
  private TextMeshProUGUI useCoinText;
  [Token(Token = "0x4000E47")]
  [FieldOffset(Offset = "0x98")]
  [SerializeField]
  private Text currCapacityText;
  [Token(Token = "0x4000E48")]
  [FieldOffset(Offset = "0xA0")]
  [SerializeField]
  private Text nextCapacityText;
  [Token(Token = "0x4000E49")]
  [FieldOffset(Offset = "0xA8")]
  [SerializeField]
  private Text currCoinText;
  [Token(Token = "0x4000E4A")]
  [FieldOffset(Offset = "0xB0")]
  [SerializeField]
  private Text currFreeCoinText;
  [Token(Token = "0x4000E4B")]
  [FieldOffset(Offset = "0xB8")]
  [SerializeField]
  private CommonButton forcementBtn;
  [Token(Token = "0x4000E4C")]
  [FieldOffset(Offset = "0xC0")]
  [SerializeField]
  private GameObject forcementEffectPopup;
  [Token(Token = "0x4000E4D")]
  [FieldOffset(Offset = "0xC8")]
  [SerializeField]
  private UITweenGroup crystalStone_Red;
  [Token(Token = "0x4000E4E")]
  [FieldOffset(Offset = "0xD0")]
  [SerializeField]
  private UITweenGroup crystalStone_Blue;
  [Token(Token = "0x4000E4F")]
  [FieldOffset(Offset = "0xD8")]
  private SoulBoxForcementEffectPopup soulBoxForcementEffectObj;
  [Token(Token = "0x4000E50")]
  [FieldOffset(Offset = "0xE0")]
  private int currLv;
  [Token(Token = "0x4000E51")]
  [FieldOffset(Offset = "0xE4")]
  private int maxLv;
  [Token(Token = "0x4000E52")]
  [FieldOffset(Offset = "0xE8")]
  private bool isMoneyEnough;
  [Token(Token = "0x4000E53")]
  [FieldOffset(Offset = "0xE9")]
  private bool isMaxLv;
  [Token(Token = "0x4000E54")]
  [FieldOffset(Offset = "0xF0")]
  private AssetCachedSpawner assetCachedSpawner;
  [Token(Token = "0x4000E55")]
  [FieldOffset(Offset = "0xF8")]
  private Action<PlayerExpeditionType> OnExpeditionBoxLevelup;
  [Token(Token = "0x4000E56")]
  [FieldOffset(Offset = "0x100")]
  private Action closeAction;
  [Token(Token = "0x4000E57")]
  [FieldOffset(Offset = "0x108")]
  private bool isRunningForcement;

  [Token(Token = "0x6000F1B")]
  [Address(RVA = "0x1C94D4C", Offset = "0x1C94D4C", VA = "0x1C94D4C")]
  public void Init(
    AssetCachedSpawner assetCachedSpawner,
    int boxLevel,
    Action<PlayerExpeditionType> onExpeditionBoxLevelup,
    Action closeAction)
  {
  }

  [Token(Token = "0x6000F1C")]
  [Address(RVA = "0x1C9539C", Offset = "0x1C9539C", VA = "0x1C9539C", Slot = "9")]
  public override void Close()
  {
  }

  [Token(Token = "0x6000F1D")]
  [Address(RVA = "0x1C953CC", Offset = "0x1C953CC", VA = "0x1C953CC")]
  public void OnClickForceMent()
  {
  }

  [Token(Token = "0x6000F1E")]
  [Address(RVA = "0x1C95514", Offset = "0x1C95514", VA = "0x1C95514")]
  private IEnumerator ForcementSoulBox() => (IEnumerator) null;

  [Token(Token = "0x6000F1F")]
  [Address(RVA = "0x1C955A4", Offset = "0x1C955A4", VA = "0x1C955A4")]
  private IEnumerator PlaySoulBoxForcementEffect(int boxLevel) => (IEnumerator) null;

  [Token(Token = "0x6000F20")]
  [Address(RVA = "0x1C95644", Offset = "0x1C95644", VA = "0x1C95644")]
  public SoulSpotBoxForcementPopup()
  {
  }
}
