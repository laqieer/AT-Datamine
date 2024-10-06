// Decompiled with JetBrains decompiler
// Type: Battle.UI.BattleUnitTargetIcon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x2002435")]
  public class BattleUnitTargetIcon : MonoBehaviour
  {
    [Token(Token = "0x4009AEE")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject attackableIconObject;
    [Token(Token = "0x4009AEF")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject selectAttackableIconObject;
    [Token(Token = "0x4009AF0")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject healableIconObject;
    [Token(Token = "0x4009AF1")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject selectHealableIconObject;
    [Token(Token = "0x4009AF2")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject supportableIconObject;
    [Token(Token = "0x4009AF3")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private GameObject selectSupportableIconObject;

    [Token(Token = "0x17002FA9")]
    public bool Visible
    {
      [Token(Token = "0x600DDD8"), Address(RVA = "0x1E2BC6C", Offset = "0x1E2BC6C", VA = "0x1E2BC6C")] get
      {
        return new bool();
      }
      [Token(Token = "0x600DDD9"), Address(RVA = "0x1E2BC8C", Offset = "0x1E2BC8C", VA = "0x1E2BC8C")] set
      {
      }
    }

    [Token(Token = "0x600DDDA")]
    [Address(RVA = "0x1E2BCB4", Offset = "0x1E2BCB4", VA = "0x1E2BCB4")]
    public static BattleUnitTargetIcon Create(
      string assetBundleLabel,
      string assetName,
      Transform parent,
      BattleConfigAsset config)
    {
      return (BattleUnitTargetIcon) null;
    }

    [Token(Token = "0x600DDDB")]
    [Address(RVA = "0x1E2BDCC", Offset = "0x1E2BDCC", VA = "0x1E2BDCC")]
    public void Initialize(BattleConfigAsset battleConfig)
    {
    }

    [Token(Token = "0x600DDDC")]
    [Address(RVA = "0x1E2BE40", Offset = "0x1E2BE40", VA = "0x1E2BE40")]
    public void Release()
    {
    }

    [Token(Token = "0x600DDDD")]
    [Address(RVA = "0x1E2BEAC", Offset = "0x1E2BEAC", VA = "0x1E2BEAC")]
    public void SetVisibleTargetableIcon(BattleUnitTargetIcon.TargetType state, bool isSelectGrid = false)
    {
    }

    [Token(Token = "0x600DDDE")]
    [Address(RVA = "0x1E2BFC0", Offset = "0x1E2BFC0", VA = "0x1E2BFC0")]
    public BattleUnitTargetIcon()
    {
    }

    [Token(Token = "0x2002436")]
    public enum TargetType
    {
      [Token(Token = "0x4009AF5")] Non,
      [Token(Token = "0x4009AF6")] Attack,
      [Token(Token = "0x4009AF7")] Heal,
      [Token(Token = "0x4009AF8")] Double,
    }
  }
}
