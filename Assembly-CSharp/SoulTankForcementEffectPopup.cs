// Decompiled with JetBrains decompiler
// Type: SoulTankForcementEffectPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using GameCore.Popup;
using Il2CppDummyDll;
using Scenes.Expedition.ExpeditionTank;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x200027B")]
public class SoulTankForcementEffectPopup : PopupBase
{
  [Token(Token = "0x4000EC0")]
  [FieldOffset(Offset = "0x88")]
  [SerializeField]
  private TextMeshProUGUI soulTankBeforeLevelText;
  [Token(Token = "0x4000EC1")]
  [FieldOffset(Offset = "0x90")]
  [SerializeField]
  private Text soulTankCurrentLevelText;
  [Token(Token = "0x4000EC2")]
  [FieldOffset(Offset = "0x98")]
  [SerializeField]
  private TextMeshProUGUI soulTankBeforeStorageText;
  [Token(Token = "0x4000EC3")]
  [FieldOffset(Offset = "0xA0")]
  [SerializeField]
  private Text soulTankCurrentStorageText;

  [Token(Token = "0x6000F7C")]
  [Address(RVA = "0x1BDFA8C", Offset = "0x1BDFA8C", VA = "0x1BDFA8C")]
  private void Start()
  {
  }

  [Token(Token = "0x6000F7D")]
  [Address(RVA = "0x1BDFA90", Offset = "0x1BDFA90", VA = "0x1BDFA90")]
  public IEnumerator Init(SoulTypeEnum soulType, ExpeditionTankPopup.TankParam para)
  {
    return (IEnumerator) null;
  }

  [Token(Token = "0x6000F7E")]
  [Address(RVA = "0x1BDFB38", Offset = "0x1BDFB38", VA = "0x1BDFB38")]
  public SoulTankForcementEffectPopup()
  {
  }
}
