// Decompiled with JetBrains decompiler
// Type: Routine.AttackArg
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace Routine
{
  [Token(Token = "0x2002211")]
  public class AttackArg : ActionArg
  {
    [Token(Token = "0x17002D31")]
    public ActionArg.TargetSettingType TargetSetting
    {
      [Token(Token = "0x600CF8B"), Address(RVA = "0x4B70B6C", Offset = "0x4B70B6C", VA = "0x4B70B6C")] get
      {
        return new ActionArg.TargetSettingType();
      }
      [Token(Token = "0x600CF8C"), Address(RVA = "0x4B70B74", Offset = "0x4B70B74", VA = "0x4B70B74")] private set
      {
      }
    }

    [Token(Token = "0x17002D32")]
    public int SpecifiedTargetId
    {
      [Token(Token = "0x600CF8D"), Address(RVA = "0x4B70B7C", Offset = "0x4B70B7C", VA = "0x4B70B7C")] get
      {
        return new int();
      }
      [Token(Token = "0x600CF8E"), Address(RVA = "0x4B70B84", Offset = "0x4B70B84", VA = "0x4B70B84")] private set
      {
      }
    }

    [Token(Token = "0x17002D33")]
    public AttackArg.MeansSettingType MeansSetting
    {
      [Token(Token = "0x600CF8F"), Address(RVA = "0x4B70B8C", Offset = "0x4B70B8C", VA = "0x4B70B8C")] get
      {
        return new AttackArg.MeansSettingType();
      }
      [Token(Token = "0x600CF90"), Address(RVA = "0x4B70B94", Offset = "0x4B70B94", VA = "0x4B70B94")] private set
      {
      }
    }

    [Token(Token = "0x17002D34")]
    public ElementTypeEnum? ElementSetting
    {
      [Token(Token = "0x600CF91"), Address(RVA = "0x4B70B9C", Offset = "0x4B70B9C", VA = "0x4B70B9C")] get
      {
        return new ElementTypeEnum?();
      }
      [Token(Token = "0x600CF92"), Address(RVA = "0x4B70BA4", Offset = "0x4B70BA4", VA = "0x4B70BA4")] private set
      {
      }
    }

    [Token(Token = "0x17002D35")]
    public WeaponTypeEnum? WeaponTypeSetting
    {
      [Token(Token = "0x600CF93"), Address(RVA = "0x4B70BAC", Offset = "0x4B70BAC", VA = "0x4B70BAC")] get
      {
        return new WeaponTypeEnum?();
      }
      [Token(Token = "0x600CF94"), Address(RVA = "0x4B70BB4", Offset = "0x4B70BB4", VA = "0x4B70BB4")] private set
      {
      }
    }

    [Token(Token = "0x17002D36")]
    public EquipmentClassificationData ClassificationSetting
    {
      [Token(Token = "0x600CF95"), Address(RVA = "0x4B70BBC", Offset = "0x4B70BBC", VA = "0x4B70BBC")] get
      {
        return (EquipmentClassificationData) null;
      }
      [Token(Token = "0x600CF96"), Address(RVA = "0x4B70BC4", Offset = "0x4B70BC4", VA = "0x4B70BC4")] private set
      {
      }
    }

    [Token(Token = "0x17002D37")]
    public AttackTypeEnum? AttackTypeSetting
    {
      [Token(Token = "0x600CF97"), Address(RVA = "0x4B70BCC", Offset = "0x4B70BCC", VA = "0x4B70BCC")] get
      {
        return new AttackTypeEnum?();
      }
      [Token(Token = "0x600CF98"), Address(RVA = "0x4B70BD4", Offset = "0x4B70BD4", VA = "0x4B70BD4")] private set
      {
      }
    }

    [Token(Token = "0x17002D38")]
    public int SpecifiedSkillId
    {
      [Token(Token = "0x600CF99"), Address(RVA = "0x4B70BDC", Offset = "0x4B70BDC", VA = "0x4B70BDC")] get
      {
        return new int();
      }
      [Token(Token = "0x600CF9A"), Address(RVA = "0x4B70BE4", Offset = "0x4B70BE4", VA = "0x4B70BE4")] private set
      {
      }
    }

    [Token(Token = "0x600CF9B")]
    [Address(RVA = "0x4B70BEC", Offset = "0x4B70BEC", VA = "0x4B70BEC")]
    public AttackArg(int[] arg)
    {
    }

    [Token(Token = "0x600CF9C")]
    [Address(RVA = "0x4B70C20", Offset = "0x4B70C20", VA = "0x4B70C20", Slot = "4")]
    protected override void SetArg(int[] arg)
    {
    }

    [Token(Token = "0x2002212")]
    private enum ContextIndex
    {
      [Token(Token = "0x4008FFD")] Move,
      [Token(Token = "0x4008FFE")] Target,
      [Token(Token = "0x4008FFF")] SpecifiedTarget,
      [Token(Token = "0x4009000")] Means,
      [Token(Token = "0x4009001")] Element,
      [Token(Token = "0x4009002")] WeaponType,
      [Token(Token = "0x4009003")] EquipmentClassification,
      [Token(Token = "0x4009004")] AttackType,
      [Token(Token = "0x4009005")] Skill,
      [Token(Token = "0x4009006")] Border,
    }

    [Token(Token = "0x2002213")]
    public enum MeansSettingType
    {
      [Token(Token = "0x4009008")] None,
      [Token(Token = "0x4009009")] WeaponIndexOne,
      [Token(Token = "0x400900A")] WeaponIndexTwo,
      [Token(Token = "0x400900B")] WeaponIndexThree,
      [Token(Token = "0x400900C")] RangeOne,
      [Token(Token = "0x400900D")] RangeTwo,
    }

    [Token(Token = "0x2002214")]
    private enum ElementSettingType
    {
      [Token(Token = "0x400900F")] None,
      [Token(Token = "0x4009010")] Fire,
      [Token(Token = "0x4009011")] Ice,
      [Token(Token = "0x4009012")] Thunder,
      [Token(Token = "0x4009013")] Wind,
      [Token(Token = "0x4009014")] Light,
      [Token(Token = "0x4009015")] Dark,
    }

    [Token(Token = "0x2002215")]
    private enum AttackSettingType
    {
      [Token(Token = "0x4009017")] None,
      [Token(Token = "0x4009018")] Slash,
      [Token(Token = "0x4009019")] Thrus,
      [Token(Token = "0x400901A")] Blow,
      [Token(Token = "0x400901B")] Shoot,
      [Token(Token = "0x400901C")] Magic,
    }
  }
}
