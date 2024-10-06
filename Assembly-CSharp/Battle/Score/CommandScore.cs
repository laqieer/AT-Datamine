// Decompiled with JetBrains decompiler
// Type: Battle.Score.CommandScore
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Score
{
  [Token(Token = "0x200247E")]
  public class CommandScore
  {
    [Token(Token = "0x4009C8A")]
    [FieldOffset(Offset = "0x78")]
    private Dictionary<int, Battle.Score.Score> scoreDictionary;

    [Token(Token = "0x17003003")]
    public int ActionUnitId
    {
      [Token(Token = "0x600DFC9"), Address(RVA = "0x2021174", Offset = "0x2021174", VA = "0x2021174")] get
      {
        return new int();
      }
      [Token(Token = "0x600DFCA"), Address(RVA = "0x202117C", Offset = "0x202117C", VA = "0x202117C")] set
      {
      }
    }

    [Token(Token = "0x17003004")]
    public string WeaponParamId
    {
      [Token(Token = "0x600DFCB"), Address(RVA = "0x2021184", Offset = "0x2021184", VA = "0x2021184")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600DFCC"), Address(RVA = "0x202118C", Offset = "0x202118C", VA = "0x202118C")] set
      {
      }
    }

    [Token(Token = "0x17003005")]
    public int TargetId
    {
      [Token(Token = "0x600DFCD"), Address(RVA = "0x2021194", Offset = "0x2021194", VA = "0x2021194")] get
      {
        return new int();
      }
      [Token(Token = "0x600DFCE"), Address(RVA = "0x202119C", Offset = "0x202119C", VA = "0x202119C")] set
      {
      }
    }

    [Token(Token = "0x17003006")]
    public IReadOnlyList<(int unitId, int x, int y)> Targets
    {
      [Token(Token = "0x600DFCF"), Address(RVA = "0x20211A4", Offset = "0x20211A4", VA = "0x20211A4")] get
      {
        return (IReadOnlyList<(int, int, int)>) null;
      }
      [Token(Token = "0x600DFD0"), Address(RVA = "0x20211AC", Offset = "0x20211AC", VA = "0x20211AC")] set
      {
      }
    }

    [Token(Token = "0x17003007")]
    public (int x, int y)? CastTo
    {
      [Token(Token = "0x600DFD1"), Address(RVA = "0x20211B4", Offset = "0x20211B4", VA = "0x20211B4")] get
      {
        return new (int, int)?();
      }
      [Token(Token = "0x600DFD2"), Address(RVA = "0x20211C4", Offset = "0x20211C4", VA = "0x20211C4")] set
      {
      }
    }

    [Token(Token = "0x17003008")]
    public int SkillParamId
    {
      [Token(Token = "0x600DFD3"), Address(RVA = "0x20211D0", Offset = "0x20211D0", VA = "0x20211D0")] get
      {
        return new int();
      }
      [Token(Token = "0x600DFD4"), Address(RVA = "0x20211D8", Offset = "0x20211D8", VA = "0x20211D8")] set
      {
      }
    }

    [Token(Token = "0x17003009")]
    public (int x, int y)? MoveToGrid
    {
      [Token(Token = "0x600DFD5"), Address(RVA = "0x20211E0", Offset = "0x20211E0", VA = "0x20211E0")] get
      {
        return new (int, int)?();
      }
      [Token(Token = "0x600DFD6"), Address(RVA = "0x20211F0", Offset = "0x20211F0", VA = "0x20211F0")] set
      {
      }
    }

    [Token(Token = "0x1700300A")]
    public int X
    {
      [Token(Token = "0x600DFD7"), Address(RVA = "0x20211FC", Offset = "0x20211FC", VA = "0x20211FC")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700300B")]
    public int Y
    {
      [Token(Token = "0x600DFD8"), Address(RVA = "0x2021284", Offset = "0x2021284", VA = "0x2021284")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700300C")]
    public (int x, int y)? InteractToGrid
    {
      [Token(Token = "0x600DFD9"), Address(RVA = "0x2021310", Offset = "0x2021310", VA = "0x2021310")] get
      {
        return new (int, int)?();
      }
      [Token(Token = "0x600DFDA"), Address(RVA = "0x2021320", Offset = "0x2021320", VA = "0x2021320")] set
      {
      }
    }

    [Token(Token = "0x1700300D")]
    public CommandScore.CommandScoreState State
    {
      [Token(Token = "0x600DFDB"), Address(RVA = "0x202132C", Offset = "0x202132C", VA = "0x202132C")] get
      {
        return new CommandScore.CommandScoreState();
      }
      [Token(Token = "0x600DFDC"), Address(RVA = "0x2021334", Offset = "0x2021334", VA = "0x2021334")] set
      {
      }
    }

    [Token(Token = "0x1700300E")]
    public SimulatorBase Simulator
    {
      [Token(Token = "0x600DFDD"), Address(RVA = "0x202133C", Offset = "0x202133C", VA = "0x202133C")] get
      {
        return (SimulatorBase) null;
      }
      [Token(Token = "0x600DFDE"), Address(RVA = "0x2021344", Offset = "0x2021344", VA = "0x2021344")] set
      {
      }
    }

    [Token(Token = "0x1700300F")]
    public SimulatorBase.ResultInfo SimulateResult
    {
      [Token(Token = "0x600DFDF"), Address(RVA = "0x202134C", Offset = "0x202134C", VA = "0x202134C")] get
      {
        return (SimulatorBase.ResultInfo) null;
      }
      [Token(Token = "0x600DFE0"), Address(RVA = "0x2021354", Offset = "0x2021354", VA = "0x2021354")] set
      {
      }
    }

    [Token(Token = "0x17003010")]
    public int Score
    {
      [Token(Token = "0x600DFE1"), Address(RVA = "0x202135C", Offset = "0x202135C", VA = "0x202135C")] get
      {
        return new int();
      }
      [Token(Token = "0x600DFE2"), Address(RVA = "0x2021364", Offset = "0x2021364", VA = "0x2021364")] set
      {
      }
    }

    [Token(Token = "0x17003011")]
    public Dictionary<int, Battle.Score.Score> Dic
    {
      [Token(Token = "0x600DFE3"), Address(RVA = "0x202136C", Offset = "0x202136C", VA = "0x202136C")] get
      {
        return (Dictionary<int, Battle.Score.Score>) null;
      }
    }

    [Token(Token = "0x600DFE4")]
    [Address(RVA = "0x2021374", Offset = "0x2021374", VA = "0x2021374")]
    public int GetScore(int index) => new int();

    [Token(Token = "0x600DFE5")]
    [Address(RVA = "0x20213F8", Offset = "0x20213F8", VA = "0x20213F8")]
    public void Log()
    {
    }

    [Token(Token = "0x600DFE6")]
    [Address(RVA = "0x20213FC", Offset = "0x20213FC", VA = "0x20213FC")]
    public void AddScore(Battle.Score.Score score)
    {
    }

    [Token(Token = "0x600DFE7")]
    [Address(RVA = "0x202149C", Offset = "0x202149C", VA = "0x202149C")]
    public CommandScore()
    {
    }

    [Token(Token = "0x200247F")]
    public enum CommandScoreState
    {
      [Token(Token = "0x4009C8C")] None,
      [Token(Token = "0x4009C8D")] Stay,
      [Token(Token = "0x4009C8E")] Control,
      [Token(Token = "0x4009C8F")] ReserveFierce,
      [Token(Token = "0x4009C90")] DidnotMove,
    }
  }
}
