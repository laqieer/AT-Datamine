// Decompiled with JetBrains decompiler
// Type: DuelUIHPController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using TMPro;
using Tween.Tweeners;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x2000186")]
public class DuelUIHPController : MonoBehaviour
{
  [Token(Token = "0x4000A04")]
  [FieldOffset(Offset = "0x18")]
  [SerializeField]
  private GameObject parentUnitStatus;
  [Token(Token = "0x4000A05")]
  [FieldOffset(Offset = "0x20")]
  [SerializeField]
  private TextMeshProUGUI hpText;
  [Token(Token = "0x4000A06")]
  [FieldOffset(Offset = "0x28")]
  [SerializeField]
  private Slider HPGaugeSlider;
  [Token(Token = "0x4000A07")]
  [FieldOffset(Offset = "0x30")]
  [SerializeField]
  private Slider damageGaugeSlider;
  [Token(Token = "0x4000A08")]
  [FieldOffset(Offset = "0x38")]
  [SerializeField]
  private Slider healGaugeSlider;
  [Token(Token = "0x4000A09")]
  [FieldOffset(Offset = "0x40")]
  [SerializeField]
  private GameObject healParticle;
  [Token(Token = "0x4000A0A")]
  [FieldOffset(Offset = "0x48")]
  [SerializeField]
  private GameObject damageParticleAlly;
  [Token(Token = "0x4000A0B")]
  [FieldOffset(Offset = "0x50")]
  [SerializeField]
  private GameObject damageParticleGuest;
  [Token(Token = "0x4000A0C")]
  [FieldOffset(Offset = "0x58")]
  [SerializeField]
  private GameObject damageParticleEnemy;
  [Token(Token = "0x4000A0D")]
  [FieldOffset(Offset = "0x60")]
  [SerializeField]
  private GameObject damageParticleAnotherForce;
  [Token(Token = "0x4000A0E")]
  [FieldOffset(Offset = "0x68")]
  private GameObject currentParticle;
  [Token(Token = "0x4000A0F")]
  [FieldOffset(Offset = "0x70")]
  [SerializeField]
  private TweenSlider[] hpTweenSliders;
  [Token(Token = "0x4000A10")]
  [FieldOffset(Offset = "0x78")]
  [SerializeField]
  private TweenSlider damageTweenSlider;
  [Token(Token = "0x4000A11")]
  [FieldOffset(Offset = "0x80")]
  [SerializeField]
  private TweenSlider healTweenSlider;
  [Token(Token = "0x4000A12")]
  [FieldOffset(Offset = "0x88")]
  [SerializeField]
  private GameObject fillMaskAlly;
  [Token(Token = "0x4000A13")]
  [FieldOffset(Offset = "0x90")]
  [SerializeField]
  private GameObject fillMaskGuest;
  [Token(Token = "0x4000A14")]
  [FieldOffset(Offset = "0x98")]
  [SerializeField]
  private GameObject fillMaskEnemy;
  [Token(Token = "0x4000A15")]
  [FieldOffset(Offset = "0xA0")]
  [SerializeField]
  private GameObject fillMaskAnotherForce;
  [Token(Token = "0x4000A16")]
  [FieldOffset(Offset = "0xA8")]
  private Coroutine updateHPCoroutine;
  [Token(Token = "0x4000A17")]
  private const int HP_VALUE_MIN = 0;
  [Token(Token = "0x4000A18")]
  private const int HP_VALUE_MAX = 9999;

  [Token(Token = "0x6000AA2")]
  [Address(RVA = "0x4BB457C", Offset = "0x4BB457C", VA = "0x4BB457C")]
  public void InitializeHP(int maxValue, int value)
  {
  }

  [Token(Token = "0x6000AA3")]
  [Address(RVA = "0x4BB4344", Offset = "0x4BB4344", VA = "0x4BB4344")]
  public void TurnColorByForceType(ForceTypeEnum forceTypeEnum)
  {
  }

  [Token(Token = "0x6000AA4")]
  [Address(RVA = "0x4BB47FC", Offset = "0x4BB47FC", VA = "0x4BB47FC")]
  public void SetHP(int value)
  {
  }

  [Token(Token = "0x6000AA5")]
  [Address(RVA = "0x4BB4A08", Offset = "0x4BB4A08", VA = "0x4BB4A08")]
  public void UpdateHP(int value)
  {
  }

  [Token(Token = "0x6000AA6")]
  [Address(RVA = "0x4BB49BC", Offset = "0x4BB49BC", VA = "0x4BB49BC")]
  public bool IsDamage(int value) => new bool();

  [Token(Token = "0x6000AA7")]
  [Address(RVA = "0x4BB4CA0", Offset = "0x4BB4CA0", VA = "0x4BB4CA0")]
  public bool IsHeal(int value) => new bool();

  [Token(Token = "0x6000AA8")]
  [Address(RVA = "0x4BB9FD8", Offset = "0x4BB9FD8", VA = "0x4BB9FD8")]
  public DuelUIHPController()
  {
  }
}
