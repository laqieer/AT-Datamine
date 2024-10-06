// Decompiled with JetBrains decompiler
// Type: SoulSpotForcementPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using GameCore.Popup;
using Il2CppDummyDll;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x2000272")]
public class SoulSpotForcementPopup : PopupBase
{
  [Token(Token = "0x4000E78")]
  [FieldOffset(Offset = "0x88")]
  [SerializeField]
  private Text soulSpotBlueCurrLVText;
  [Token(Token = "0x4000E79")]
  [FieldOffset(Offset = "0x90")]
  [SerializeField]
  private Text soulSpotBlueNextLVText;
  [Token(Token = "0x4000E7A")]
  [FieldOffset(Offset = "0x98")]
  [SerializeField]
  private Text soulSpotRedCurrLVText;
  [Token(Token = "0x4000E7B")]
  [FieldOffset(Offset = "0xA0")]
  [SerializeField]
  private Text soulSpotRedNextLVText;
  [Token(Token = "0x4000E7C")]
  [FieldOffset(Offset = "0xA8")]
  [SerializeField]
  private Text soulSpotBlueCurrProductionText;
  [Token(Token = "0x4000E7D")]
  [FieldOffset(Offset = "0xB0")]
  [SerializeField]
  private Text soulSpotBlueNextProductionText;
  [Token(Token = "0x4000E7E")]
  [FieldOffset(Offset = "0xB8")]
  [SerializeField]
  private Text soulSpotRedCurrProductionText;
  [Token(Token = "0x4000E7F")]
  [FieldOffset(Offset = "0xC0")]
  [SerializeField]
  private Text soulSpotRedNextProductionText;
  [Token(Token = "0x4000E80")]
  [FieldOffset(Offset = "0xC8")]
  [SerializeField]
  private Text soulSpotBlueCurrStorageText;
  [Token(Token = "0x4000E81")]
  [FieldOffset(Offset = "0xD0")]
  [SerializeField]
  private Text soulSpotBlueNextStorageText;
  [Token(Token = "0x4000E82")]
  [FieldOffset(Offset = "0xD8")]
  [SerializeField]
  private Text soulSpotRedCurrStorageText;
  [Token(Token = "0x4000E83")]
  [FieldOffset(Offset = "0xE0")]
  [SerializeField]
  private Text soulSpotRedNextStorageText;
  [Token(Token = "0x4000E84")]
  [FieldOffset(Offset = "0xE8")]
  [SerializeField]
  private Text soulSpotBlueForcementMoneyText;
  [Token(Token = "0x4000E85")]
  [FieldOffset(Offset = "0xF0")]
  [SerializeField]
  private Text soulSpotRedForcementMoneyText;
  [Token(Token = "0x4000E86")]
  [FieldOffset(Offset = "0xF8")]
  [SerializeField]
  private Text currMoneyText;
  [Token(Token = "0x4000E87")]
  [FieldOffset(Offset = "0x100")]
  [SerializeField]
  private Text currMoneyText2;
  [Token(Token = "0x4000E88")]
  [FieldOffset(Offset = "0x108")]
  [SerializeField]
  private Text afterBlueMoneyText;
  [Token(Token = "0x4000E89")]
  [FieldOffset(Offset = "0x110")]
  [SerializeField]
  private Text afterRedMoneyText;
  [Token(Token = "0x4000E8A")]
  [FieldOffset(Offset = "0x118")]
  [SerializeField]
  private Button blueForcementButton;
  [Token(Token = "0x4000E8B")]
  [FieldOffset(Offset = "0x120")]
  [SerializeField]
  private Button redForcementButton;
  [Token(Token = "0x4000E8C")]
  [FieldOffset(Offset = "0x128")]
  [SerializeField]
  private GameObject soulSpotForcementEffect;
  [Token(Token = "0x4000E8D")]
  [FieldOffset(Offset = "0x130")]
  [SerializeField]
  private GameObject blueLevelObj;
  [Token(Token = "0x4000E8E")]
  [FieldOffset(Offset = "0x138")]
  [SerializeField]
  private GameObject blueLevelTextObj;
  [Token(Token = "0x4000E8F")]
  [FieldOffset(Offset = "0x140")]
  [SerializeField]
  private GameObject blueLevelMaxObj;
  [Token(Token = "0x4000E90")]
  [FieldOffset(Offset = "0x148")]
  [SerializeField]
  private Text blueLevelMaxLvText;
  [Token(Token = "0x4000E91")]
  [FieldOffset(Offset = "0x150")]
  [SerializeField]
  private GameObject blueLevelMaxTextObj;
  [Token(Token = "0x4000E92")]
  [FieldOffset(Offset = "0x158")]
  [SerializeField]
  private GameObject redLevelObj;
  [Token(Token = "0x4000E93")]
  [FieldOffset(Offset = "0x160")]
  [SerializeField]
  private GameObject redLevelTextObj;
  [Token(Token = "0x4000E94")]
  [FieldOffset(Offset = "0x168")]
  [SerializeField]
  private GameObject redLevelMaxObj;
  [Token(Token = "0x4000E95")]
  [FieldOffset(Offset = "0x170")]
  [SerializeField]
  private Text redLevelMaxLvText;
  [Token(Token = "0x4000E96")]
  [FieldOffset(Offset = "0x178")]
  [SerializeField]
  private GameObject redLevelMaxTextObj;
  [Token(Token = "0x4000E97")]
  [FieldOffset(Offset = "0x180")]
  private SoulSpotForcementEffectPopup soulSpotForcementEffectObj;
  [Token(Token = "0x4000E98")]
  [FieldOffset(Offset = "0x188")]
  private int currBlueSoulLevel;
  [Token(Token = "0x4000E99")]
  [FieldOffset(Offset = "0x18C")]
  private int currRedSoulLevel;
  [Token(Token = "0x4000E9A")]
  [FieldOffset(Offset = "0x190")]
  private bool IsBlueItemEnough;
  [Token(Token = "0x4000E9B")]
  [FieldOffset(Offset = "0x191")]
  private bool IsRedItemEnough;
  [Token(Token = "0x4000E9C")]
  [FieldOffset(Offset = "0x198")]
  private Action<SoulTypeEnum, int, int> onForcementFinish;
  [Token(Token = "0x4000E9D")]
  [FieldOffset(Offset = "0x1A0")]
  private Action closeAction;
  [Token(Token = "0x4000E9E")]
  [FieldOffset(Offset = "0x1A8")]
  private bool isClicked;

  [Token(Token = "0x6000F4A")]
  [Address(RVA = "0x1C96A80", Offset = "0x1C96A80", VA = "0x1C96A80")]
  private void Start()
  {
  }

  [Token(Token = "0x6000F4B")]
  [Address(RVA = "0x1C96BA0", Offset = "0x1C96BA0", VA = "0x1C96BA0")]
  public void Init(
    int currBlueLV,
    int currRedLV,
    Action<SoulTypeEnum, int, int> callback = null,
    Action closeAction = null)
  {
  }

  [Token(Token = "0x6000F4C")]
  [Address(RVA = "0x1C9800C", Offset = "0x1C9800C", VA = "0x1C9800C", Slot = "9")]
  public override void Close()
  {
  }

  [Token(Token = "0x6000F4D")]
  [Address(RVA = "0x1C9803C", Offset = "0x1C9803C", VA = "0x1C9803C")]
  private IEnumerator ForcementSoulSpot(SoulTypeEnum soulType) => (IEnumerator) null;

  [Token(Token = "0x6000F4E")]
  [Address(RVA = "0x1C980DC", Offset = "0x1C980DC", VA = "0x1C980DC")]
  private IEnumerator PlaySoulSpotForcementEffect(SoulTypeEnum soulType, int currLV)
  {
    return (IEnumerator) null;
  }

  [Token(Token = "0x6000F4F")]
  [Address(RVA = "0x1C98180", Offset = "0x1C98180", VA = "0x1C98180")]
  private void OpenNotification(string text)
  {
  }

  [Token(Token = "0x6000F50")]
  [Address(RVA = "0x1C97B00", Offset = "0x1C97B00", VA = "0x1C97B00")]
  private int GetCanUpLevelMax(SoulTypeEnum soulType) => new int();

  [Token(Token = "0x6000F51")]
  [Address(RVA = "0x1C98214", Offset = "0x1C98214", VA = "0x1C98214")]
  public SoulSpotForcementPopup()
  {
  }
}
