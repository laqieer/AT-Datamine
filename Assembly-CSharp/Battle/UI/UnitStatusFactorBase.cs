// Decompiled with JetBrains decompiler
// Type: Battle.UI.UnitStatusFactorBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Battle.UI.Option;
using Il2CppDummyDll;
using StaqData.StatusIcon;
using UnitDetail.Data.ScriptableObjects;
using UnityEngine;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x2002356")]
  public abstract class UnitStatusFactorBase : MonoBehaviour
  {
    [Token(Token = "0x400961C")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private CanvasGroup canvasGroup;
    [Token(Token = "0x400961D")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private RectTransform rootRect;
    [Token(Token = "0x400961E")]
    [FieldOffset(Offset = "0x28")]
    public bool isNeedLp;
    [Token(Token = "0x4009621")]
    [FieldOffset(Offset = "0x40")]
    protected UnitListConfig unitListConfig;

    [Token(Token = "0x17002E6A")]
    public float ScrollPositionY
    {
      [Token(Token = "0x600D7D0"), Address(RVA = "0x1B8C708", Offset = "0x1B8C708", VA = "0x1B8C708")] set
      {
      }
      [Token(Token = "0x600D7D1"), Address(RVA = "0x1B8C72C", Offset = "0x1B8C72C", VA = "0x1B8C72C")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17002E6B")]
    public float ScrollHeight
    {
      [Token(Token = "0x600D7D2"), Address(RVA = "0x1B8C750", Offset = "0x1B8C750", VA = "0x1B8C750")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17002E6C")]
    protected UnitFeatureTable features
    {
      [Token(Token = "0x600D7D3"), Address(RVA = "0x1B8C774", Offset = "0x1B8C774", VA = "0x1B8C774")] get
      {
        return (UnitFeatureTable) null;
      }
      [Token(Token = "0x600D7D4"), Address(RVA = "0x1B8C77C", Offset = "0x1B8C77C", VA = "0x1B8C77C")] private set
      {
      }
    }

    [Token(Token = "0x17002E6D")]
    protected IconFactory iconFactory
    {
      [Token(Token = "0x600D7D5"), Address(RVA = "0x1B8C784", Offset = "0x1B8C784", VA = "0x1B8C784")] get
      {
        return (IconFactory) null;
      }
      [Token(Token = "0x600D7D6"), Address(RVA = "0x1B8C78C", Offset = "0x1B8C78C", VA = "0x1B8C78C")] private set
      {
      }
    }

    [Token(Token = "0x600D7D7")]
    [Address(RVA = "0x1B88C34", Offset = "0x1B88C34", VA = "0x1B88C34", Slot = "4")]
    public virtual void Initialize(UnitStatusFactorBase.Context context)
    {
    }

    [Token(Token = "0x600D7D8")]
    public abstract void Set(UnitParameterData unit, BattlePlayerData owner);

    [Token(Token = "0x600D7D9")]
    [Address(RVA = "0x1B8C794", Offset = "0x1B8C794", VA = "0x1B8C794", Slot = "6")]
    public virtual void SetFactor(UnitStatusFactorBase.UnitListShowFactor factor)
    {
    }

    [Token(Token = "0x600D7DA")]
    [Address(RVA = "0x1B8ABB0", Offset = "0x1B8ABB0", VA = "0x1B8ABB0", Slot = "7")]
    public virtual void SetActiveFactor(bool active)
    {
    }

    [Token(Token = "0x600D7DB")]
    [Address(RVA = "0x1B89334", Offset = "0x1B89334", VA = "0x1B89334")]
    protected UnitStatusFactorBase()
    {
    }

    [Token(Token = "0x2002357")]
    public enum UnitListShowFactor
    {
      [Token(Token = "0x4009623")] Basic,
      [Token(Token = "0x4009624")] Element,
      [Token(Token = "0x4009625")] WeaponAttackType,
      [Token(Token = "0x4009626")] BadStatus,
      [Token(Token = "0x4009627")] SpecialEffect,
      [Token(Token = "0x4009628")] Equipment,
      [Token(Token = "0x4009629")] BattleParam,
    }

    [Token(Token = "0x2002358")]
    public struct Context
    {
      [Token(Token = "0x400962A")]
      [FieldOffset(Offset = "0x0")]
      public UnitFeatureTable features;
      [Token(Token = "0x400962B")]
      [FieldOffset(Offset = "0x8")]
      public IconFactory iconFactory;
      [Token(Token = "0x400962C")]
      [FieldOffset(Offset = "0x10")]
      public UnitListConfig UnitListConfig;
    }
  }
}
