// Decompiled with JetBrains decompiler
// Type: Routine.FierceArg
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Routine
{
  [Token(Token = "0x2002222")]
  public class FierceArg : ActionArg
  {
    [Token(Token = "0x17002D3C")]
    public int SpecifiedTargetId
    {
      [Token(Token = "0x600CFDB"), Address(RVA = "0x4CCEA74", Offset = "0x4CCEA74", VA = "0x4CCEA74")] get
      {
        return new int();
      }
      [Token(Token = "0x600CFDC"), Address(RVA = "0x4CCEA7C", Offset = "0x4CCEA7C", VA = "0x4CCEA7C")] private set
      {
      }
    }

    [Token(Token = "0x17002D3D")]
    public int SpecifiedSkillId
    {
      [Token(Token = "0x600CFDD"), Address(RVA = "0x4CCEA84", Offset = "0x4CCEA84", VA = "0x4CCEA84")] get
      {
        return new int();
      }
      [Token(Token = "0x600CFDE"), Address(RVA = "0x4CCEA8C", Offset = "0x4CCEA8C", VA = "0x4CCEA8C")] private set
      {
      }
    }

    [Token(Token = "0x600CFDF")]
    [Address(RVA = "0x4CCEA94", Offset = "0x4CCEA94", VA = "0x4CCEA94")]
    public FierceArg(int[] arg)
    {
    }

    [Token(Token = "0x600CFE0")]
    [Address(RVA = "0x4CCEA9C", Offset = "0x4CCEA9C", VA = "0x4CCEA9C", Slot = "4")]
    protected override void SetArg(int[] arg)
    {
    }

    [Token(Token = "0x2002223")]
    private enum ContextIndex
    {
      [Token(Token = "0x4009038")] SpecifiedTarget,
      [Token(Token = "0x4009039")] Skill,
    }
  }
}
