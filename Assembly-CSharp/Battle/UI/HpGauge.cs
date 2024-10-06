// Decompiled with JetBrains decompiler
// Type: Battle.UI.HpGauge
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x2002437")]
  public sealed class HpGauge : MonoBehaviour
  {
    [Token(Token = "0x4009AF9")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Slider gauge;
    [Token(Token = "0x4009AFA")]
    [FieldOffset(Offset = "0x20")]
    public GaugeViewType Type;
    [Token(Token = "0x4009AFB")]
    [FieldOffset(Offset = "0x24")]
    private float end;
    [Token(Token = "0x4009AFC")]
    [FieldOffset(Offset = "0x28")]
    private Coroutine _coroutine;
    [Token(Token = "0x4009AFD")]
    [FieldOffset(Offset = "0x30")]
    public UnityAction Show;
    [Token(Token = "0x4009AFE")]
    [FieldOffset(Offset = "0x38")]
    public UnityAction Hide;
    [Token(Token = "0x4009AFF")]
    private const float MaxAnimationTime = 0.65f;
    [Token(Token = "0x4009B00")]
    private const float EndTimeDuration = 0.2f;

    [Token(Token = "0x17002FAA")]
    public float Max
    {
      [Token(Token = "0x600DDDF"), Address(RVA = "0x1E2BFC8", Offset = "0x1E2BFC8", VA = "0x1E2BFC8")] get
      {
        return new float();
      }
      [Token(Token = "0x600DDE0"), Address(RVA = "0x1E2BFE4", Offset = "0x1E2BFE4", VA = "0x1E2BFE4")] set
      {
      }
    }

    [Token(Token = "0x17002FAB")]
    public float Current
    {
      [Token(Token = "0x600DDE1"), Address(RVA = "0x1E2C000", Offset = "0x1E2C000", VA = "0x1E2C000")] get
      {
        return new float();
      }
      [Token(Token = "0x600DDE2"), Address(RVA = "0x1E2C024", Offset = "0x1E2C024", VA = "0x1E2C024")] set
      {
      }
    }

    [Token(Token = "0x600DDE3")]
    [Address(RVA = "0x1E2C048", Offset = "0x1E2C048", VA = "0x1E2C048")]
    public void Initialize(UnityAction show, UnityAction hide)
    {
    }

    [Token(Token = "0x600DDE4")]
    [Address(RVA = "0x1E2C050", Offset = "0x1E2C050", VA = "0x1E2C050")]
    public void Set(int maxHp, int currentHp)
    {
    }

    [Token(Token = "0x600DDE5")]
    [Address(RVA = "0x1E2C09C", Offset = "0x1E2C09C", VA = "0x1E2C09C")]
    public void SetAnimation(int damage)
    {
    }

    [Token(Token = "0x600DDE6")]
    [Address(RVA = "0x1E2C1AC", Offset = "0x1E2C1AC", VA = "0x1E2C1AC")]
    private IEnumerator StartAnimation(float from, float to) => (IEnumerator) null;

    [Token(Token = "0x600DDE7")]
    [Address(RVA = "0x1E2C180", Offset = "0x1E2C180", VA = "0x1E2C180")]
    private void DestroyCoroutine()
    {
    }

    [Token(Token = "0x600DDE8")]
    [Address(RVA = "0x1E2C250", Offset = "0x1E2C250", VA = "0x1E2C250")]
    public HpGauge()
    {
    }
  }
}
