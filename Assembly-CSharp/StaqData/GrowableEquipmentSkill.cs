// Decompiled with JetBrains decompiler
// Type: StaqData.GrowableEquipmentSkill
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x2002023")]
  public abstract class GrowableEquipmentSkill : EquipmentSkill, IGrowable
  {
    [Token(Token = "0x17002812")]
    public int Exp
    {
      [Token(Token = "0x600C016"), Address(RVA = "0x2009F2C", Offset = "0x2009F2C", VA = "0x2009F2C", Slot = "10")] get
      {
        return new int();
      }
      [Token(Token = "0x600C017"), Address(RVA = "0x2009F34", Offset = "0x2009F34", VA = "0x2009F34")] protected set
      {
      }
    }

    [Token(Token = "0x17002813")]
    public abstract int NextLevelExp { [Token(Token = "0x600C018")] get; }

    [Token(Token = "0x17002814")]
    public abstract float NextLevelExpRate { [Token(Token = "0x600C019")] get; }

    [Token(Token = "0x600C01A")]
    public abstract (int, int) GetPredictExperience(int value);

    [Token(Token = "0x600C01B")]
    [Address(RVA = "0x2008A90", Offset = "0x2008A90", VA = "0x2008A90")]
    protected GrowableEquipmentSkill()
    {
    }
  }
}
