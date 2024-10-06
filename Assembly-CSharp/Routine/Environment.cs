// Decompiled with JetBrains decompiler
// Type: Routine.Environment
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Battle.RouteSearch;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace Routine
{
  [Token(Token = "0x2002205")]
  public sealed class Environment
  {
    [Token(Token = "0x4008FB4")]
    [FieldOffset(Offset = "0x10")]
    private BoardData board;
    [Token(Token = "0x4008FB5")]
    [FieldOffset(Offset = "0x18")]
    private MovableAreaSearcher movable;
    [Token(Token = "0x4008FB6")]
    [FieldOffset(Offset = "0x20")]
    private AttackableAreaSearcher attackable;

    [Token(Token = "0x600CF20")]
    [Address(RVA = "0x4B6ABB0", Offset = "0x4B6ABB0", VA = "0x4B6ABB0")]
    public Environment(BoardData board)
    {
    }

    [Token(Token = "0x600CF21")]
    [Address(RVA = "0x4B6AC78", Offset = "0x4B6AC78", VA = "0x4B6AC78")]
    public void Update(BoardData board)
    {
    }

    [Token(Token = "0x600CF22")]
    [Address(RVA = "0x4B6AC80", Offset = "0x4B6AC80", VA = "0x4B6AC80")]
    public bool HasNonDuplicateBuff(Environment.Unit unit) => new bool();

    [Token(Token = "0x600CF23")]
    [Address(RVA = "0x4B6B26C", Offset = "0x4B6B26C", VA = "0x4B6B26C")]
    public bool HasNonDuplicateBuff(Environment.Unit unit, Environment.Unit target) => new bool();

    [Token(Token = "0x600CF24")]
    [Address(RVA = "0x4B6B300", Offset = "0x4B6B300", VA = "0x4B6B300")]
    public bool HasNonDuplicateBuff(Environment.Unit unit, List<Environment.Unit> targets)
    {
      return new bool();
    }

    [Token(Token = "0x600CF25")]
    [Address(RVA = "0x4B6B500", Offset = "0x4B6B500", VA = "0x4B6B500")]
    public bool HasNonDuplicateDebuff(Environment.Unit unit) => new bool();

    [Token(Token = "0x600CF26")]
    [Address(RVA = "0x4B6B590", Offset = "0x4B6B590", VA = "0x4B6B590")]
    public bool HasNonDuplicateDebuff(Environment.Unit unit, Environment.Unit target) => new bool();

    [Token(Token = "0x600CF27")]
    [Address(RVA = "0x4B6B624", Offset = "0x4B6B624", VA = "0x4B6B624")]
    public bool HasNonDuplicateDebuff(Environment.Unit unit, List<Environment.Unit> targets)
    {
      return new bool();
    }

    [Token(Token = "0x600CF28")]
    [Address(RVA = "0x4B6B6B8", Offset = "0x4B6B6B8", VA = "0x4B6B6B8")]
    public List<Environment.Unit> GetAliveOwnForces(int unitParamId)
    {
      return (List<Environment.Unit>) null;
    }

    [Token(Token = "0x600CF29")]
    [Address(RVA = "0x4B6BA9C", Offset = "0x4B6BA9C", VA = "0x4B6BA9C")]
    public List<Environment.Unit> GetOwnForces(int unitParamId) => (List<Environment.Unit>) null;

    [Token(Token = "0x600CF2A")]
    [Address(RVA = "0x4B6BF40", Offset = "0x4B6BF40", VA = "0x4B6BF40")]
    private bool OwnForceCondition(UnitParameterData own, UnitParameterData target) => new bool();

    [Token(Token = "0x600CF2B")]
    [Address(RVA = "0x4B6BF68", Offset = "0x4B6BF68", VA = "0x4B6BF68")]
    public List<Environment.Unit> GetAliveFriendlies(int unitParamId)
    {
      return (List<Environment.Unit>) null;
    }

    [Token(Token = "0x600CF2C")]
    [Address(RVA = "0x4B6BFF4", Offset = "0x4B6BFF4", VA = "0x4B6BFF4")]
    public List<Environment.Unit> GetFriendlies(int unitParamId) => (List<Environment.Unit>) null;

    [Token(Token = "0x600CF2D")]
    [Address(RVA = "0x4B6C080", Offset = "0x4B6C080", VA = "0x4B6C080")]
    private bool FriendlyCondition(UnitParameterData own, UnitParameterData target) => new bool();

    [Token(Token = "0x600CF2E")]
    [Address(RVA = "0x4B6C114", Offset = "0x4B6C114", VA = "0x4B6C114")]
    public List<Environment.Unit> GetEnableBarrierHostiles(int unitParamId)
    {
      return (List<Environment.Unit>) null;
    }

    [Token(Token = "0x600CF2F")]
    [Address(RVA = "0x4B6C3C8", Offset = "0x4B6C3C8", VA = "0x4B6C3C8")]
    public List<Environment.Unit> GetAliveHostiles(int unitParamId)
    {
      return (List<Environment.Unit>) null;
    }

    [Token(Token = "0x600CF30")]
    [Address(RVA = "0x4B6C454", Offset = "0x4B6C454", VA = "0x4B6C454")]
    public bool HasAttackableHostiles(int unitParamId) => new bool();

    [Token(Token = "0x600CF31")]
    [Address(RVA = "0x4B6C4CC", Offset = "0x4B6C4CC", VA = "0x4B6C4CC")]
    public List<Environment.Unit> GetHostiles(int unitParamId) => (List<Environment.Unit>) null;

    [Token(Token = "0x600CF32")]
    [Address(RVA = "0x4B6CB30", Offset = "0x4B6CB30", VA = "0x4B6CB30")]
    private bool HostileCondition(UnitParameterData own, UnitParameterData target) => new bool();

    [Token(Token = "0x600CF33")]
    [Address(RVA = "0x4B6CB94", Offset = "0x4B6CB94", VA = "0x4B6CB94")]
    public List<Environment.Unit> GetAliveUserPlayerUnits(int unitParamId)
    {
      return (List<Environment.Unit>) null;
    }

    [Token(Token = "0x600CF34")]
    [Address(RVA = "0x4B6CC20", Offset = "0x4B6CC20", VA = "0x4B6CC20")]
    public List<Environment.Unit> GetUserPlayerUnits(int unitParamId)
    {
      return (List<Environment.Unit>) null;
    }

    [Token(Token = "0x600CF35")]
    [Address(RVA = "0x4B6CCAC", Offset = "0x4B6CCAC", VA = "0x4B6CCAC")]
    private bool UserPlayerCondition(UnitParameterData own, UnitParameterData target) => new bool();

    [Token(Token = "0x600CF36")]
    [Address(RVA = "0x4B6CCCC", Offset = "0x4B6CCCC", VA = "0x4B6CCCC")]
    public List<Environment.Unit> GetAliveGuests(int unitParamId) => (List<Environment.Unit>) null;

    [Token(Token = "0x600CF37")]
    [Address(RVA = "0x4B6CD58", Offset = "0x4B6CD58", VA = "0x4B6CD58")]
    public List<Environment.Unit> GetGuests(int unitParamId) => (List<Environment.Unit>) null;

    [Token(Token = "0x600CF38")]
    [Address(RVA = "0x4B6CDE4", Offset = "0x4B6CDE4", VA = "0x4B6CDE4")]
    private bool GuestCondition(UnitParameterData own, UnitParameterData target) => new bool();

    [Token(Token = "0x600CF39")]
    [Address(RVA = "0x4B6CE04", Offset = "0x4B6CE04", VA = "0x4B6CE04")]
    public List<Environment.Unit> GetAliveEnemies(int unitParamId) => (List<Environment.Unit>) null;

    [Token(Token = "0x600CF3A")]
    [Address(RVA = "0x4B6CE90", Offset = "0x4B6CE90", VA = "0x4B6CE90")]
    public List<Environment.Unit> GetEnemies(int unitParamId) => (List<Environment.Unit>) null;

    [Token(Token = "0x600CF3B")]
    [Address(RVA = "0x4B6CF1C", Offset = "0x4B6CF1C", VA = "0x4B6CF1C")]
    private bool EnemyCondition(UnitParameterData own, UnitParameterData target) => new bool();

    [Token(Token = "0x600CF3C")]
    [Address(RVA = "0x4B6CF3C", Offset = "0x4B6CF3C", VA = "0x4B6CF3C")]
    public List<Environment.Unit> GetAliveThirdArmies(int unitParamId)
    {
      return (List<Environment.Unit>) null;
    }

    [Token(Token = "0x600CF3D")]
    [Address(RVA = "0x4B6CFC8", Offset = "0x4B6CFC8", VA = "0x4B6CFC8")]
    public List<Environment.Unit> GetThirdArmies(int unitParamId) => (List<Environment.Unit>) null;

    [Token(Token = "0x600CF3E")]
    [Address(RVA = "0x4B6D054", Offset = "0x4B6D054", VA = "0x4B6D054")]
    private bool ThirdArmyCondition(UnitParameterData own, UnitParameterData target) => new bool();

    [Token(Token = "0x600CF3F")]
    [Address(RVA = "0x4B6C49C", Offset = "0x4B6C49C", VA = "0x4B6C49C")]
    public Environment.Unit GetUnit(int unitParamId) => (Environment.Unit) null;

    [Token(Token = "0x600CF40")]
    [Address(RVA = "0x4B6D11C", Offset = "0x4B6D11C", VA = "0x4B6D11C")]
    private List<Environment.Unit> GetUnits(
      int unitParamId,
      Environment.GetUnitsConditionDelegate del)
    {
      return (List<Environment.Unit>) null;
    }

    [Token(Token = "0x600CF41")]
    [Address(RVA = "0x4B6BB28", Offset = "0x4B6BB28", VA = "0x4B6BB28")]
    private List<Environment.Unit> GetOnBoardUnits(
      int unitParamId,
      Environment.GetUnitsConditionDelegate del)
    {
      return (List<Environment.Unit>) null;
    }

    [Token(Token = "0x600CF42")]
    [Address(RVA = "0x4B6D52C", Offset = "0x4B6D52C", VA = "0x4B6D52C")]
    private bool IsBuffCondition(EffectData e) => new bool();

    [Token(Token = "0x600CF43")]
    [Address(RVA = "0x4B6D54C", Offset = "0x4B6D54C", VA = "0x4B6D54C")]
    private bool IsDebuffCondition(EffectData e) => new bool();

    [Token(Token = "0x600CF44")]
    [Address(RVA = "0x4B6D56C", Offset = "0x4B6D56C", VA = "0x4B6D56C")]
    public int GetTurn() => new int();

    [Token(Token = "0x600CF45")]
    [Address(RVA = "0x4B6B874", Offset = "0x4B6B874", VA = "0x4B6B874")]
    private List<Environment.Unit> GetAliveUnits(
      int unitParamId,
      Environment.GetUnitsConditionDelegate del)
    {
      return (List<Environment.Unit>) null;
    }

    [Token(Token = "0x600CF46")]
    [Address(RVA = "0x4B6C1A0", Offset = "0x4B6C1A0", VA = "0x4B6C1A0")]
    private List<Environment.Unit> GetEnableBarrierUnits(
      int unitParamId,
      Environment.GetUnitsConditionDelegate del)
    {
      return (List<Environment.Unit>) null;
    }

    [Token(Token = "0x2002206")]
    private delegate bool GetUnitsConditionDelegate(UnitParameterData a, UnitParameterData b);

    [Token(Token = "0x2002207")]
    public class Unit
    {
      [Token(Token = "0x4008FB7")]
      [FieldOffset(Offset = "0x10")]
      private WeakReference<UnitParameterData> origin;

      [Token(Token = "0x17002D21")]
      private UnitParameterData Origin
      {
        [Token(Token = "0x600CF4B"), Address(RVA = "0x4B6D608", Offset = "0x4B6D608", VA = "0x4B6D608")] get
        {
          return (UnitParameterData) null;
        }
      }

      [Token(Token = "0x600CF4C")]
      [Address(RVA = "0x4B6D074", Offset = "0x4B6D074", VA = "0x4B6D074")]
      public static Environment.Unit Create(UnitParameterData unit) => (Environment.Unit) null;

      [Token(Token = "0x600CF4D")]
      [Address(RVA = "0x4B6D670", Offset = "0x4B6D670", VA = "0x4B6D670")]
      private Unit()
      {
      }

      [Token(Token = "0x17002D22")]
      public int Id
      {
        [Token(Token = "0x600CF4E"), Address(RVA = "0x4B6D678", Offset = "0x4B6D678", VA = "0x4B6D678")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x17002D23")]
      public bool IsAlive
      {
        [Token(Token = "0x600CF4F"), Address(RVA = "0x4B6D588", Offset = "0x4B6D588", VA = "0x4B6D588")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x17002D24")]
      public bool HasBuff
      {
        [Token(Token = "0x600CF50"), Address(RVA = "0x4B6D694", Offset = "0x4B6D694", VA = "0x4B6D694")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x17002D25")]
      public int CurrentHPPercentage
      {
        [Token(Token = "0x600CF51"), Address(RVA = "0x4B6D6B0", Offset = "0x4B6D6B0", VA = "0x4B6D6B0")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x17002D26")]
      public int RemainingStock
      {
        [Token(Token = "0x600CF52"), Address(RVA = "0x4B6D6CC", Offset = "0x4B6D6CC", VA = "0x4B6D6CC")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x17002D27")]
      public bool IsCharging
      {
        [Token(Token = "0x600CF53"), Address(RVA = "0x4B6D6E8", Offset = "0x4B6D6E8", VA = "0x4B6D6E8")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x17002D28")]
      public bool HadCharged
      {
        [Token(Token = "0x600CF54"), Address(RVA = "0x4B6D704", Offset = "0x4B6D704", VA = "0x4B6D704")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x600CF55")]
      [Address(RVA = "0x4B6B394", Offset = "0x4B6B394", VA = "0x4B6B394")]
      public bool HasNonDuplicate(
        List<Environment.Unit> targets,
        Environment.Unit.ValidEffectDelegate del)
      {
        return new bool();
      }

      [Token(Token = "0x600CF56")]
      [Address(RVA = "0x4B6AE3C", Offset = "0x4B6AE3C", VA = "0x4B6AE3C")]
      public bool HasNonDuplicate(Environment.Unit target, Environment.Unit.ValidEffectDelegate del)
      {
        return new bool();
      }

      [Token(Token = "0x600CF57")]
      [Address(RVA = "0x4B6C558", Offset = "0x4B6C558", VA = "0x4B6C558")]
      public bool HasAttackable(
        List<Environment.Unit> targets,
        BoardData board,
        MovableAreaSearcher movable,
        AttackableAreaSearcher attackable)
      {
        return new bool();
      }

      [Token(Token = "0x600CF58")]
      [Address(RVA = "0x4B6D720", Offset = "0x4B6D720", VA = "0x4B6D720")]
      public bool HasAttackable(
        Environment.Unit target,
        BoardData board,
        MovableAreaSearcher movable,
        AttackableAreaSearcher attackable)
      {
        return new bool();
      }

      [Token(Token = "0x2002208")]
      public delegate bool ValidEffectDelegate(EffectData e);
    }
  }
}
