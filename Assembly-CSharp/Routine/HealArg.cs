// Decompiled with JetBrains decompiler
// Type: Routine.HealArg
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Routine
{
  [Token(Token = "0x2002226")]
  public class HealArg : ActionArg
  {
    [Token(Token = "0x17002D42")]
    public ActionArg.TargetSettingType TargetSetting
    {
      [Token(Token = "0x600CFF3"), Address(RVA = "0x4CD023C", Offset = "0x4CD023C", VA = "0x4CD023C")] get
      {
        return new ActionArg.TargetSettingType();
      }
      [Token(Token = "0x600CFF4"), Address(RVA = "0x4CD0244", Offset = "0x4CD0244", VA = "0x4CD0244")] private set
      {
      }
    }

    [Token(Token = "0x17002D43")]
    public int SpecifiedTargetId
    {
      [Token(Token = "0x600CFF5"), Address(RVA = "0x4CD024C", Offset = "0x4CD024C", VA = "0x4CD024C")] get
      {
        return new int();
      }
      [Token(Token = "0x600CFF6"), Address(RVA = "0x4CD0254", Offset = "0x4CD0254", VA = "0x4CD0254")] private set
      {
      }
    }

    [Token(Token = "0x17002D44")]
    public int[] PreferenceTargetIds
    {
      [Token(Token = "0x600CFF7"), Address(RVA = "0x4CD025C", Offset = "0x4CD025C", VA = "0x4CD025C")] get
      {
        return (int[]) null;
      }
      [Token(Token = "0x600CFF8"), Address(RVA = "0x4CD0264", Offset = "0x4CD0264", VA = "0x4CD0264")] private set
      {
      }
    }

    [Token(Token = "0x17002D45")]
    public HealArg.MeansSettingType MeansSetting
    {
      [Token(Token = "0x600CFF9"), Address(RVA = "0x4CD026C", Offset = "0x4CD026C", VA = "0x4CD026C")] get
      {
        return new HealArg.MeansSettingType();
      }
      [Token(Token = "0x600CFFA"), Address(RVA = "0x4CD0274", Offset = "0x4CD0274", VA = "0x4CD0274")] private set
      {
      }
    }

    [Token(Token = "0x17002D46")]
    public int SpecifiedSkillId
    {
      [Token(Token = "0x600CFFB"), Address(RVA = "0x4CD027C", Offset = "0x4CD027C", VA = "0x4CD027C")] get
      {
        return new int();
      }
      [Token(Token = "0x600CFFC"), Address(RVA = "0x4CD0284", Offset = "0x4CD0284", VA = "0x4CD0284")] private set
      {
      }
    }

    [Token(Token = "0x600CFFD")]
    [Address(RVA = "0x4CD028C", Offset = "0x4CD028C", VA = "0x4CD028C")]
    public HealArg(int[] arg, int[] preference)
    {
    }

    [Token(Token = "0x600CFFE")]
    [Address(RVA = "0x4CD02B4", Offset = "0x4CD02B4", VA = "0x4CD02B4", Slot = "4")]
    protected override void SetArg(int[] arg)
    {
    }

    [Token(Token = "0x2002227")]
    private enum ContextIndex
    {
      [Token(Token = "0x4009044")] Move,
      [Token(Token = "0x4009045")] Target,
      [Token(Token = "0x4009046")] SpecifiedTarget,
      [Token(Token = "0x4009047")] Means,
      [Token(Token = "0x4009048")] Skill,
    }

    [Token(Token = "0x2002228")]
    public enum MeansSettingType
    {
      [Token(Token = "0x400904A")] None,
      [Token(Token = "0x400904B")] WeaponIndexOne,
      [Token(Token = "0x400904C")] WeaponIndexTwo,
      [Token(Token = "0x400904D")] WeaponIndexThree,
    }
  }
}
