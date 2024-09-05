// Decompiled with JetBrains decompiler
// Type: Battle.Data.ActionResult
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Battle.DuelScene;
using Battle.Logic;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Data
{
  [Token(Token = "0x2002746")]
  public sealed class ActionResult
  {
    [Token(Token = "0x400A7CB")]
    [FieldOffset(Offset = "0x20")]
    private List<UnitParameterData> killedUnits;
    [Token(Token = "0x400A7CD")]
    [FieldOffset(Offset = "0x30")]
    public HashSet<int> DealDamagedUnits;
    [Token(Token = "0x400A7CE")]
    [FieldOffset(Offset = "0x38")]
    private Dictionary<(UnitParameterData unit, int index), BarrierDamageLogic> reserveBarrierDamageDic;

    [Token(Token = "0x1700344C")]
    public bool IsHealedYourself
    {
      [Token(Token = "0x600F4BA"), Address(RVA = "0x1FAFDFC", Offset = "0x1FAFDFC", VA = "0x1FAFDFC")] get
      {
        return new bool();
      }
      [Token(Token = "0x600F4BB"), Address(RVA = "0x1FAFE04", Offset = "0x1FAFE04", VA = "0x1FAFE04")] private set
      {
      }
    }

    [Token(Token = "0x1700344D")]
    public bool IsHealedOthers
    {
      [Token(Token = "0x600F4BC"), Address(RVA = "0x1FAFE10", Offset = "0x1FAFE10", VA = "0x1FAFE10")] get
      {
        return new bool();
      }
      [Token(Token = "0x600F4BD"), Address(RVA = "0x1FAFE18", Offset = "0x1FAFE18", VA = "0x1FAFE18")] private set
      {
      }
    }

    [Token(Token = "0x1700344E")]
    public bool IsKilledUnit
    {
      [Token(Token = "0x600F4BE"), Address(RVA = "0x1FAFE24", Offset = "0x1FAFE24", VA = "0x1FAFE24")] get
      {
        return new bool();
      }
      [Token(Token = "0x600F4BF"), Address(RVA = "0x1FAFE2C", Offset = "0x1FAFE2C", VA = "0x1FAFE2C")] private set
      {
      }
    }

    [Token(Token = "0x1700344F")]
    public bool IsDefeated
    {
      [Token(Token = "0x600F4C0"), Address(RVA = "0x1FAFE38", Offset = "0x1FAFE38", VA = "0x1FAFE38")] get
      {
        return new bool();
      }
      [Token(Token = "0x600F4C1"), Address(RVA = "0x1FAFE40", Offset = "0x1FAFE40", VA = "0x1FAFE40")] private set
      {
      }
    }

    [Token(Token = "0x17003450")]
    public bool IsAttackWeaponBroken
    {
      [Token(Token = "0x600F4C2"), Address(RVA = "0x1FAFE4C", Offset = "0x1FAFE4C", VA = "0x1FAFE4C")] get
      {
        return new bool();
      }
      [Token(Token = "0x600F4C3"), Address(RVA = "0x1FAFE54", Offset = "0x1FAFE54", VA = "0x1FAFE54")] private set
      {
      }
    }

    [Token(Token = "0x17003451")]
    public bool IsDefenderWeaponBroken
    {
      [Token(Token = "0x600F4C4"), Address(RVA = "0x1FAFE60", Offset = "0x1FAFE60", VA = "0x1FAFE60")] get
      {
        return new bool();
      }
      [Token(Token = "0x600F4C5"), Address(RVA = "0x1FAFE68", Offset = "0x1FAFE68", VA = "0x1FAFE68")] private set
      {
      }
    }

    [Token(Token = "0x17003452")]
    public DuelData DuelData
    {
      [Token(Token = "0x600F4C6"), Address(RVA = "0x1FAFE74", Offset = "0x1FAFE74", VA = "0x1FAFE74")] get
      {
        return (DuelData) null;
      }
      [Token(Token = "0x600F4C7"), Address(RVA = "0x1FAFE7C", Offset = "0x1FAFE7C", VA = "0x1FAFE7C")] private set
      {
      }
    }

    [Token(Token = "0x17003453")]
    public IReadOnlyList<UnitParameterData> KilledUnits
    {
      [Token(Token = "0x600F4C8"), Address(RVA = "0x1FAFE84", Offset = "0x1FAFE84", VA = "0x1FAFE84")] get
      {
        return (IReadOnlyList<UnitParameterData>) null;
      }
    }

    [Token(Token = "0x17003454")]
    public bool IsTakeDamage
    {
      [Token(Token = "0x600F4C9"), Address(RVA = "0x1FAFE8C", Offset = "0x1FAFE8C", VA = "0x1FAFE8C")] get
      {
        return new bool();
      }
      [Token(Token = "0x600F4CA"), Address(RVA = "0x1FAFE94", Offset = "0x1FAFE94", VA = "0x1FAFE94")] private set
      {
      }
    }

    [Token(Token = "0x17003455")]
    public IReadOnlyDictionary<(UnitParameterData unit, int index), BarrierDamageLogic> ReserveBarrierDamageDic
    {
      [Token(Token = "0x600F4CB"), Address(RVA = "0x1FAFEA0", Offset = "0x1FAFEA0", VA = "0x1FAFEA0")] get
      {
        return (IReadOnlyDictionary<(UnitParameterData, int), BarrierDamageLogic>) null;
      }
    }

    [Token(Token = "0x600F4CC")]
    [Address(RVA = "0x1FAFEA8", Offset = "0x1FAFEA8", VA = "0x1FAFEA8")]
    public void CollectResult(ActionLogicBase logic, DuelData duelData)
    {
    }

    [Token(Token = "0x600F4CD")]
    [Address(RVA = "0x1FB01EC", Offset = "0x1FB01EC", VA = "0x1FB01EC")]
    public void CollectResult(DuelData duelData)
    {
    }

    [Token(Token = "0x600F4CE")]
    [Address(RVA = "0x1FB0818", Offset = "0x1FB0818", VA = "0x1FB0818")]
    public string ToJson() => (string) null;

    [Token(Token = "0x600F4CF")]
    [Address(RVA = "0x1FB0874", Offset = "0x1FB0874", VA = "0x1FB0874")]
    public ActionResult()
    {
    }
  }
}
