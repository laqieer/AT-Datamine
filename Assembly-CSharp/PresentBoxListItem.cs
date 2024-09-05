// Decompiled with JetBrains decompiler
// Type: PresentBoxListItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using Scenes.PresentBox;
using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x20002B0")]
public class PresentBoxListItem : MonoBehaviour
{
  [Token(Token = "0x4000FDF")]
  [FieldOffset(Offset = "0x18")]
  [SerializeField]
  private TextMeshProUGUI presentName;
  [Token(Token = "0x4000FE0")]
  [FieldOffset(Offset = "0x20")]
  [SerializeField]
  private TextMeshProUGUI presentInfo;
  [Token(Token = "0x4000FE1")]
  [FieldOffset(Offset = "0x28")]
  [SerializeField]
  private Text presentQuantity;
  [Token(Token = "0x4000FE2")]
  [FieldOffset(Offset = "0x30")]
  [SerializeField]
  private TextMeshProUGUI textReceiveTimeLimit;
  [Token(Token = "0x4000FE3")]
  [FieldOffset(Offset = "0x38")]
  [SerializeField]
  private TextMeshProUGUI textReceiveTimeLabel;
  [Token(Token = "0x4000FE4")]
  [FieldOffset(Offset = "0x40")]
  [SerializeField]
  private GameObject timeIcon;
  [Token(Token = "0x4000FE5")]
  [FieldOffset(Offset = "0x48")]
  [SerializeField]
  private Button receiveBtn;
  [Token(Token = "0x4000FE6")]
  [FieldOffset(Offset = "0x50")]
  [SerializeField]
  private RectTransform parent;
  [Token(Token = "0x4000FE7")]
  [FieldOffset(Offset = "0x58")]
  private PresentBoxSubScene subScene;
  [Token(Token = "0x4000FE8")]
  [FieldOffset(Offset = "0x60")]
  private string presentID;

  [Token(Token = "0x60010D6")]
  [Address(RVA = "0x1BEAA74", Offset = "0x1BEAA74", VA = "0x1BEAA74")]
  public void SetData(PresentBoxSubScene subScene, PlayerPresentType presentData, Action onClick)
  {
  }

  [Token(Token = "0x60010D7")]
  [Address(RVA = "0x1BEAE00", Offset = "0x1BEAE00", VA = "0x1BEAE00")]
  private void SetUIState(PresentBoxSubScene.TabType tabType)
  {
  }

  [Token(Token = "0x60010D8")]
  [Address(RVA = "0x1BEAD3C", Offset = "0x1BEAD3C", VA = "0x1BEAD3C")]
  private string GetLimitTime(string postTime) => (string) null;

  [Token(Token = "0x60010D9")]
  [Address(RVA = "0x1BEAED4", Offset = "0x1BEAED4", VA = "0x1BEAED4")]
  private IEnumerator RequestReceivePresentBox() => (IEnumerator) null;

  [Token(Token = "0x60010DA")]
  [Address(RVA = "0x1BEAF64", Offset = "0x1BEAF64", VA = "0x1BEAF64")]
  public PresentBoxListItem()
  {
  }
}
