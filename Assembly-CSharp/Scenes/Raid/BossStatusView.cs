// Decompiled with JetBrains decompiler
// Type: Scenes.Raid.BossStatusView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Raid
{
  [Token(Token = "0x20029B3")]
  internal class BossStatusView : MonoBehaviour
  {
    [Token(Token = "0x400B19C")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private TextMeshProUGUI lapText;
    [Token(Token = "0x400B19D")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private TextMeshProUGUI stageText;
    [Token(Token = "0x400B19E")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private TextMeshProUGUI nameText;
    [Token(Token = "0x400B19F")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private TextMeshProUGUI currentHpText;
    [Token(Token = "0x400B1A0")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private TextMeshProUGUI maxHpText;
    [Token(Token = "0x400B1A1")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Slider currentHpSlider;
    [Token(Token = "0x400B1A2")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Slider damageSlider;
    [Token(Token = "0x400B1A3")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private float damageSliderSpeed;
    [Token(Token = "0x400B1A4")]
    [FieldOffset(Offset = "0x54")]
    public bool gaugeFlg;
    [Token(Token = "0x400B1A5")]
    [FieldOffset(Offset = "0x58")]
    private float current;
    [Token(Token = "0x400B1A6")]
    [FieldOffset(Offset = "0x5C")]
    private float damage;

    [Token(Token = "0x6010602")]
    [Address(RVA = "0x488485C", Offset = "0x488485C", VA = "0x488485C")]
    public void SetStatus(
      GuildRaidPositionDetailType positionDetailType,
      int lap,
      int score,
      bool showdamage)
    {
    }

    [Token(Token = "0x6010603")]
    [Address(RVA = "0x4884C80", Offset = "0x4884C80", VA = "0x4884C80")]
    private IEnumerator SetGaugeFlg() => (IEnumerator) null;

    [Token(Token = "0x6010604")]
    [Address(RVA = "0x4884D10", Offset = "0x4884D10", VA = "0x4884D10")]
    private void Update()
    {
    }

    [Token(Token = "0x6010605")]
    [Address(RVA = "0x4884D60", Offset = "0x4884D60", VA = "0x4884D60")]
    public BossStatusView()
    {
    }
  }
}
