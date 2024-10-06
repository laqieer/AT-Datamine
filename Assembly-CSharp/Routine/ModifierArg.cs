// Decompiled with JetBrains decompiler
// Type: Routine.ModifierArg
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Routine
{
  [Token(Token = "0x2002239")]
  public class ModifierArg : ActionArg
  {
    [Token(Token = "0x17002D4F")]
    public ActionArg.TargetSettingType TargetSetting
    {
      [Token(Token = "0x600D03D"), Address(RVA = "0x4CD49DC", Offset = "0x4CD49DC", VA = "0x4CD49DC")] get
      {
        return new ActionArg.TargetSettingType();
      }
      [Token(Token = "0x600D03E"), Address(RVA = "0x4CD49E4", Offset = "0x4CD49E4", VA = "0x4CD49E4")] private set
      {
      }
    }

    [Token(Token = "0x17002D50")]
    public int SpecifiedTargetId
    {
      [Token(Token = "0x600D03F"), Address(RVA = "0x4CD49EC", Offset = "0x4CD49EC", VA = "0x4CD49EC")] get
      {
        return new int();
      }
      [Token(Token = "0x600D040"), Address(RVA = "0x4CD49F4", Offset = "0x4CD49F4", VA = "0x4CD49F4")] private set
      {
      }
    }

    [Token(Token = "0x17002D51")]
    public ActionArg.DuplicateSettingType DuplicateSetting
    {
      [Token(Token = "0x600D041"), Address(RVA = "0x4CD49FC", Offset = "0x4CD49FC", VA = "0x4CD49FC")] get
      {
        return new ActionArg.DuplicateSettingType();
      }
      [Token(Token = "0x600D042"), Address(RVA = "0x4CD4A04", Offset = "0x4CD4A04", VA = "0x4CD4A04")] private set
      {
      }
    }

    [Token(Token = "0x17002D52")]
    public int SpecifiedSkillId
    {
      [Token(Token = "0x600D043"), Address(RVA = "0x4CD4A0C", Offset = "0x4CD4A0C", VA = "0x4CD4A0C")] get
      {
        return new int();
      }
      [Token(Token = "0x600D044"), Address(RVA = "0x4CD4A14", Offset = "0x4CD4A14", VA = "0x4CD4A14")] private set
      {
      }
    }

    [Token(Token = "0x600D045")]
    [Address(RVA = "0x4CD4A1C", Offset = "0x4CD4A1C", VA = "0x4CD4A1C")]
    public ModifierArg(int[] arg)
    {
    }

    [Token(Token = "0x600D046")]
    [Address(RVA = "0x4CD4A24", Offset = "0x4CD4A24", VA = "0x4CD4A24", Slot = "4")]
    protected override void SetArg(int[] arg)
    {
    }

    [Token(Token = "0x200223A")]
    private enum ContextIndex
    {
      [Token(Token = "0x4009073")] Move,
      [Token(Token = "0x4009074")] Target,
      [Token(Token = "0x4009075")] SpecifiedTarget,
      [Token(Token = "0x4009076")] Duplicate,
      [Token(Token = "0x4009077")] Skill,
    }
  }
}
