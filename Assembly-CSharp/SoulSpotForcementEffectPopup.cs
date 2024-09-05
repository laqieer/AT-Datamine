// Decompiled with JetBrains decompiler
// Type: SoulSpotForcementEffectPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using GameCore.Popup;
using Il2CppDummyDll;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x200026E")]
public class SoulSpotForcementEffectPopup : PopupBase
{
  [Token(Token = "0x4000E63")]
  [FieldOffset(Offset = "0x88")]
  [SerializeField]
  private TextMeshProUGUI soulSpotBeforeLVText;
  [Token(Token = "0x4000E64")]
  [FieldOffset(Offset = "0x90")]
  [SerializeField]
  private Text soulSpotCurrLVText;
  [Token(Token = "0x4000E65")]
  [FieldOffset(Offset = "0x98")]
  [SerializeField]
  private TextMeshProUGUI soulSpotBeforeProductionText;
  [Token(Token = "0x4000E66")]
  [FieldOffset(Offset = "0xA0")]
  [SerializeField]
  private Text soulSpotCurrProductionText;
  [Token(Token = "0x4000E67")]
  [FieldOffset(Offset = "0xA8")]
  [SerializeField]
  private TextMeshProUGUI soulSpotBeforeStorageText;
  [Token(Token = "0x4000E68")]
  [FieldOffset(Offset = "0xB0")]
  [SerializeField]
  private Text soulSpotCurrentStorageText;
  [Token(Token = "0x4000E69")]
  [FieldOffset(Offset = "0xB8")]
  [SerializeField]
  private CommonButton closeBtn;

  [Token(Token = "0x6000F34")]
  [Address(RVA = "0x1C95D18", Offset = "0x1C95D18", VA = "0x1C95D18")]
  private void Start()
  {
  }

  [Token(Token = "0x6000F35")]
  [Address(RVA = "0x1C95D1C", Offset = "0x1C95D1C", VA = "0x1C95D1C")]
  public IEnumerator Init(SoulTypeEnum soulType, int currLV) => (IEnumerator) null;

  [Token(Token = "0x6000F36")]
  [Address(RVA = "0x1C95DC0", Offset = "0x1C95DC0", VA = "0x1C95DC0")]
  public SoulSpotForcementEffectPopup()
  {
  }
}
