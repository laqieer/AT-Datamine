// Decompiled with JetBrains decompiler
// Type: Battle.UI.HpGaugeController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Battle.Particle;
using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x2002439")]
  public sealed class HpGaugeController : MonoBehaviour
  {
    [Token(Token = "0x4009B08")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public HpGauge mainHpGauge;
    [Token(Token = "0x4009B09")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private HpGauge damageGauge;
    [Token(Token = "0x4009B0A")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private HpGauge healGauge;
    [Token(Token = "0x4009B0B")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private HpGauge deadlyDamageGauge;
    [Token(Token = "0x4009B0C")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Image mainGaugeImage;
    [Token(Token = "0x4009B0D")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Image hpStockGaugeImage;
    [Token(Token = "0x4009B0E")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Transform stockParticleRoot;
    [Token(Token = "0x4009B11")]
    [FieldOffset(Offset = "0x60")]
    private List<HpGauge> predictionList;
    [Token(Token = "0x4009B12")]
    private const float HpWidth = 58f;
    [Token(Token = "0x4009B13")]
    private const float StockHpWidth = 48f;

    [Token(Token = "0x17002FAE")]
    public HpStockBreakParticle particleScript
    {
      [Token(Token = "0x600DDEF"), Address(RVA = "0x1E2C4B4", Offset = "0x1E2C4B4", VA = "0x1E2C4B4")] get
      {
        return (HpStockBreakParticle) null;
      }
      [Token(Token = "0x600DDF0"), Address(RVA = "0x1E2C4BC", Offset = "0x1E2C4BC", VA = "0x1E2C4BC")] private set
      {
      }
    }

    [Token(Token = "0x17002FAF")]
    public RectTransform rootObject
    {
      [Token(Token = "0x600DDF1"), Address(RVA = "0x1E2C4C4", Offset = "0x1E2C4C4", VA = "0x1E2C4C4")] get
      {
        return (RectTransform) null;
      }
      [Token(Token = "0x600DDF2"), Address(RVA = "0x1E2C4CC", Offset = "0x1E2C4CC", VA = "0x1E2C4CC")] private set
      {
      }
    }

    [Token(Token = "0x600DDF3")]
    [Address(RVA = "0x1E29918", Offset = "0x1E29918", VA = "0x1E29918")]
    public void Initialize(BattleUnitSimplePanelTween panelTween, UnitParameterData unit)
    {
    }

    [Token(Token = "0x600DDF4")]
    [Address(RVA = "0x1E2C81C", Offset = "0x1E2C81C", VA = "0x1E2C81C")]
    public void SetConfirmHp(int maxHp, int currentHp)
    {
    }

    [Token(Token = "0x600DDF5")]
    [Address(RVA = "0x1E29F00", Offset = "0x1E29F00", VA = "0x1E29F00")]
    public void SetPredictionHP(int maxHP, int currentHP, int afterHP)
    {
    }

    [Token(Token = "0x600DDF6")]
    [Address(RVA = "0x1E2C9F8", Offset = "0x1E2C9F8", VA = "0x1E2C9F8")]
    public void ShowPredictionGauge()
    {
    }

    [Token(Token = "0x600DDF7")]
    [Address(RVA = "0x1E2C878", Offset = "0x1E2C878", VA = "0x1E2C878")]
    public void HidePredictionGauge()
    {
    }

    [Token(Token = "0x600DDF8")]
    [Address(RVA = "0x1E29FE4", Offset = "0x1E29FE4", VA = "0x1E29FE4")]
    public void SetHpWidth(bool hasStock)
    {
    }

    [Token(Token = "0x600DDF9")]
    [Address(RVA = "0x1E2A050", Offset = "0x1E2A050", VA = "0x1E2A050")]
    public void SetHpGaugeAnimation(int damage)
    {
    }

    [Token(Token = "0x600DDFA")]
    [Address(RVA = "0x1E2A0B8", Offset = "0x1E2A0B8", VA = "0x1E2A0B8")]
    public float GetHpGaugeValue() => new float();

    [Token(Token = "0x600DDFB")]
    [Address(RVA = "0x1E2C608", Offset = "0x1E2C608", VA = "0x1E2C608")]
    private void LoadHpGaugeAssetBundle(UnitParameterData unit)
    {
    }

    [Token(Token = "0x600DDFC")]
    [Address(RVA = "0x1E2C4D4", Offset = "0x1E2C4D4", VA = "0x1E2C4D4")]
    private void LoadHpStockParticle()
    {
    }

    [Token(Token = "0x600DDFD")]
    [Address(RVA = "0x1E2CB90", Offset = "0x1E2CB90", VA = "0x1E2CB90")]
    public HpGaugeController()
    {
    }
  }
}
