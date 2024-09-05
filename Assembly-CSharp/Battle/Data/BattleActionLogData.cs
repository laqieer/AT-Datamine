// Decompiled with JetBrains decompiler
// Type: Battle.Data.BattleActionLogData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Command;
using Battle.Data.Board;
using Battle.Grid;
using Il2CppDummyDll;

#nullable disable
namespace Battle.Data
{
  [Token(Token = "0x20026FF")]
  public class BattleActionLogData
  {
    [Token(Token = "0x17003341")]
    public int ActionTurn
    {
      [Token(Token = "0x600F1A0"), Address(RVA = "0x41AF464", Offset = "0x41AF464", VA = "0x41AF464")] get
      {
        return new int();
      }
      [Token(Token = "0x600F1A1"), Address(RVA = "0x41AF46C", Offset = "0x41AF46C", VA = "0x41AF46C")] private set
      {
      }
    }

    [Token(Token = "0x17003342")]
    public bool IsRollBackIndexable
    {
      [Token(Token = "0x600F1A2"), Address(RVA = "0x41AF474", Offset = "0x41AF474", VA = "0x41AF474")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17003343")]
    public UnitParameterData ActionUnit
    {
      [Token(Token = "0x600F1A3"), Address(RVA = "0x41AF484", Offset = "0x41AF484", VA = "0x41AF484")] get
      {
        return (UnitParameterData) null;
      }
      [Token(Token = "0x600F1A4"), Address(RVA = "0x41AF48C", Offset = "0x41AF48C", VA = "0x41AF48C")] private set
      {
      }
    }

    [Token(Token = "0x17003344")]
    public WeaponData ActionUnitWeapon
    {
      [Token(Token = "0x600F1A5"), Address(RVA = "0x41AF494", Offset = "0x41AF494", VA = "0x41AF494")] get
      {
        return (WeaponData) null;
      }
      [Token(Token = "0x600F1A6"), Address(RVA = "0x41AF49C", Offset = "0x41AF49C", VA = "0x41AF49C")] private set
      {
      }
    }

    [Token(Token = "0x17003345")]
    public UnitParameterData TargetUnit
    {
      [Token(Token = "0x600F1A7"), Address(RVA = "0x41AF4A4", Offset = "0x41AF4A4", VA = "0x41AF4A4")] get
      {
        return (UnitParameterData) null;
      }
      [Token(Token = "0x600F1A8"), Address(RVA = "0x41AF4AC", Offset = "0x41AF4AC", VA = "0x41AF4AC")] private set
      {
      }
    }

    [Token(Token = "0x17003346")]
    public WeaponData TargetUnitWeapon
    {
      [Token(Token = "0x600F1A9"), Address(RVA = "0x41AF4B4", Offset = "0x41AF4B4", VA = "0x41AF4B4")] get
      {
        return (WeaponData) null;
      }
      [Token(Token = "0x600F1AA"), Address(RVA = "0x41AF4BC", Offset = "0x41AF4BC", VA = "0x41AF4BC")] private set
      {
      }
    }

    [Token(Token = "0x17003347")]
    public SkillData Skill
    {
      [Token(Token = "0x600F1AB"), Address(RVA = "0x41AF4C4", Offset = "0x41AF4C4", VA = "0x41AF4C4")] get
      {
        return (SkillData) null;
      }
      [Token(Token = "0x600F1AC"), Address(RVA = "0x41AF4CC", Offset = "0x41AF4CC", VA = "0x41AF4CC")] private set
      {
      }
    }

    [Token(Token = "0x17003348")]
    public GridObject MoveToGrid
    {
      [Token(Token = "0x600F1AD"), Address(RVA = "0x41AF4D4", Offset = "0x41AF4D4", VA = "0x41AF4D4")] get
      {
        return (GridObject) null;
      }
      [Token(Token = "0x600F1AE"), Address(RVA = "0x41AF4DC", Offset = "0x41AF4DC", VA = "0x41AF4DC")] private set
      {
      }
    }

    [Token(Token = "0x17003349")]
    public CommandType Command
    {
      [Token(Token = "0x600F1AF"), Address(RVA = "0x41AF4E4", Offset = "0x41AF4E4", VA = "0x41AF4E4")] get
      {
        return new CommandType();
      }
      [Token(Token = "0x600F1B0"), Address(RVA = "0x41AF4EC", Offset = "0x41AF4EC", VA = "0x41AF4EC")] private set
      {
      }
    }

    [Token(Token = "0x600F1B1")]
    [Address(RVA = "0x41AF4F4", Offset = "0x41AF4F4", VA = "0x41AF4F4")]
    public BattleActionLogData()
    {
    }
  }
}
