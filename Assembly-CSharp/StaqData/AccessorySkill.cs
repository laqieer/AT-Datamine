// Decompiled with JetBrains decompiler
// Type: StaqData.AccessorySkill
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x200201B")]
  public sealed class AccessorySkill : GrowableEquipmentSkill
  {
    [Token(Token = "0x40088B3")]
    private const float ExpRateMax = 1f;

    [Token(Token = "0x170027E1")]
    public override int NextLevelExp
    {
      [Token(Token = "0x600BF8B"), Address(RVA = "0x20086D4", Offset = "0x20086D4", VA = "0x20086D4", Slot = "15")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170027E2")]
    public override float NextLevelExpRate
    {
      [Token(Token = "0x600BF8C"), Address(RVA = "0x20087E0", Offset = "0x20087E0", VA = "0x20087E0", Slot = "16")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x600BF8D")]
    [Address(RVA = "0x200890C", Offset = "0x200890C", VA = "0x200890C")]
    public AccessorySkill(UniqueID uID, int id, int skillID, int exp, int level)
    {
    }

    [Token(Token = "0x600BF8E")]
    [Address(RVA = "0x2008AF4", Offset = "0x2008AF4", VA = "0x2008AF4")]
    public AccessorySkill(AccessorySkill other)
    {
    }

    [Token(Token = "0x600BF8F")]
    [Address(RVA = "0x2007F54", Offset = "0x2007F54", VA = "0x2007F54")]
    public AccessorySkill(PlayerGearAccessorySkillType entity)
    {
    }

    [Token(Token = "0x600BF90")]
    [Address(RVA = "0x2008B50", Offset = "0x2008B50", VA = "0x2008B50", Slot = "17")]
    public override (int, int) GetPredictExperience(int value) => ();
  }
}
