// Decompiled with JetBrains decompiler
// Type: Battle.Logic.BarrierDamageLogic
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Battle.Data.Board;
using Il2CppDummyDll;

#nullable disable
namespace Battle.Logic
{
  [Token(Token = "0x20024D3")]
  public class BarrierDamageLogic
  {
    [Token(Token = "0x4009DF8")]
    private const int AreaBonus = 1;
    [Token(Token = "0x4009DF9")]
    private const int StratagemMainTargetBonus = 2;
    [Token(Token = "0x4009DFA")]
    [FieldOffset(Offset = "0x10")]
    private int mainTargetBonus;

    [Token(Token = "0x17003094")]
    public int WeakElementBonus
    {
      [Token(Token = "0x600E2C4"), Address(RVA = "0x401DA98", Offset = "0x401DA98", VA = "0x401DA98")] get
      {
        return new int();
      }
      [Token(Token = "0x600E2C5"), Address(RVA = "0x401DAA0", Offset = "0x401DAA0", VA = "0x401DAA0")] private set
      {
      }
    }

    [Token(Token = "0x17003095")]
    public int AlignmentStratagemBonus
    {
      [Token(Token = "0x600E2C6"), Address(RVA = "0x401DAA8", Offset = "0x401DAA8", VA = "0x401DAA8")] get
      {
        return new int();
      }
      [Token(Token = "0x600E2C7"), Address(RVA = "0x401DAB0", Offset = "0x401DAB0", VA = "0x401DAB0")] private set
      {
      }
    }

    [Token(Token = "0x600E2C8")]
    [Address(RVA = "0x401C864", Offset = "0x401C864", VA = "0x401C864")]
    public BarrierDamageLogic(
      SkillParameterData skill,
      TargetPair mainTarget,
      TargetPair target,
      int weakElementBonus,
      int alignmentStratagemBonus)
    {
    }

    [Token(Token = "0x600E2C9")]
    [Address(RVA = "0x4018A68", Offset = "0x4018A68", VA = "0x4018A68")]
    public void Collect(int weakElementBonus, int alignmentStratagemBonus)
    {
    }

    [Token(Token = "0x17003096")]
    public int Damage
    {
      [Token(Token = "0x600E2CA"), Address(RVA = "0x401DAB8", Offset = "0x401DAB8", VA = "0x401DAB8")] get
      {
        return new int();
      }
    }
  }
}
