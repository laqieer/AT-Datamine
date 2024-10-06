// Decompiled with JetBrains decompiler
// Type: Battle.UI.BattleUnitSimplePanelTween
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x2002432")]
  public sealed class BattleUnitSimplePanelTween : TweenWrapper
  {
    [Token(Token = "0x4009ADB")]
    [FieldOffset(Offset = "0x20")]
    [HideInInspector]
    [SerializeField]
    private string showDealSlayName;
    [Token(Token = "0x4009ADC")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    [HideInInspector]
    private string showTakeSlayName;
    [Token(Token = "0x4009ADD")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    [HideInInspector]
    private string showEachOtherSlayName;
    [Token(Token = "0x4009ADE")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    [HideInInspector]
    private string hideSlayName;

    [Token(Token = "0x600DDC0")]
    [Address(RVA = "0x1E2A268", Offset = "0x1E2A268", VA = "0x1E2A268")]
    public void DealSlay()
    {
    }

    [Token(Token = "0x600DDC1")]
    [Address(RVA = "0x1E2A310", Offset = "0x1E2A310", VA = "0x1E2A310")]
    public void TakeSlay()
    {
    }

    [Token(Token = "0x600DDC2")]
    [Address(RVA = "0x1E2A1C0", Offset = "0x1E2A1C0", VA = "0x1E2A1C0")]
    public void EachOtherSlay()
    {
    }

    [Token(Token = "0x600DDC3")]
    [Address(RVA = "0x1E29870", Offset = "0x1E29870", VA = "0x1E29870")]
    public void HideSlay()
    {
    }

    [Token(Token = "0x600DDC4")]
    [Address(RVA = "0x1E2A5EC", Offset = "0x1E2A5EC", VA = "0x1E2A5EC")]
    public void ShowElementAdvantage()
    {
    }

    [Token(Token = "0x600DDC5")]
    [Address(RVA = "0x1E2A3B8", Offset = "0x1E2A3B8", VA = "0x1E2A3B8")]
    public void HideElementAdvantage()
    {
    }

    [Token(Token = "0x600DDC6")]
    [Address(RVA = "0x1E2A474", Offset = "0x1E2A474", VA = "0x1E2A474")]
    public void ShowElementDisAdvantage()
    {
    }

    [Token(Token = "0x600DDC7")]
    [Address(RVA = "0x1E2A530", Offset = "0x1E2A530", VA = "0x1E2A530")]
    public void HideElementDisAdvantage()
    {
    }

    [Token(Token = "0x600DDC8")]
    [Address(RVA = "0x1E2B38C", Offset = "0x1E2B38C", VA = "0x1E2B38C")]
    public void PredictionDamage()
    {
    }

    [Token(Token = "0x600DDC9")]
    [Address(RVA = "0x1E2B448", Offset = "0x1E2B448", VA = "0x1E2B448")]
    public void PredictionDamageHide()
    {
    }

    [Token(Token = "0x600DDCA")]
    [Address(RVA = "0x1E2B504", Offset = "0x1E2B504", VA = "0x1E2B504")]
    public void PredictionHeal()
    {
    }

    [Token(Token = "0x600DDCB")]
    [Address(RVA = "0x1E2B5C0", Offset = "0x1E2B5C0", VA = "0x1E2B5C0")]
    public void PredictionHealHide()
    {
    }

    [Token(Token = "0x600DDCC")]
    [Address(RVA = "0x1E2B67C", Offset = "0x1E2B67C", VA = "0x1E2B67C")]
    public void DeadlyDamage()
    {
    }

    [Token(Token = "0x600DDCD")]
    [Address(RVA = "0x1E2B738", Offset = "0x1E2B738", VA = "0x1E2B738")]
    public void DeadlyDamageHide()
    {
    }

    [Token(Token = "0x600DDCE")]
    [Address(RVA = "0x1E29064", Offset = "0x1E29064", VA = "0x1E29064")]
    public void HpStock(bool isShow)
    {
    }

    [Token(Token = "0x600DDCF")]
    [Address(RVA = "0x1E2B7F4", Offset = "0x1E2B7F4", VA = "0x1E2B7F4", Slot = "7")]
    protected override void LateUpdate()
    {
    }

    [Token(Token = "0x600DDD0")]
    [Address(RVA = "0x1E2B7F8", Offset = "0x1E2B7F8", VA = "0x1E2B7F8")]
    public BattleUnitSimplePanelTween()
    {
    }

    [Token(Token = "0x2002433")]
    public class TweenName
    {
      [Token(Token = "0x4009ADF")]
      public const string DamageIn = "Damage_In";
      [Token(Token = "0x4009AE0")]
      public const string DamageOut = "Damage_Out";
      [Token(Token = "0x4009AE1")]
      public const string HealIn = "Recovery_In";
      [Token(Token = "0x4009AE2")]
      public const string HealOut = "Recovery_Out";
      [Token(Token = "0x4009AE3")]
      public const string DeadlyIn = "Death_In";
      [Token(Token = "0x4009AE4")]
      public const string DeadlyOut = "Death_Out";
      [Token(Token = "0x4009AE5")]
      public const string HpStockIn = "HpStock_In";
      [Token(Token = "0x4009AE6")]
      public const string HpStockOut = "HpStock_Out";
      [Token(Token = "0x4009AE7")]
      public const string CompatibilityUpIn = "CompatibilityUP_In";
      [Token(Token = "0x4009AE8")]
      public const string CompatibilityUpOut = "CompatibilityUP_Out";
      [Token(Token = "0x4009AE9")]
      public const string CompatibilityDownIn = "CompatibilityDOWN_In";
      [Token(Token = "0x4009AEA")]
      public const string CompatibilityDownOut = "CompatibilityDOWN_Out";

      [Token(Token = "0x600DDD1")]
      [Address(RVA = "0x1E2B854", Offset = "0x1E2B854", VA = "0x1E2B854")]
      public TweenName()
      {
      }
    }
  }
}
