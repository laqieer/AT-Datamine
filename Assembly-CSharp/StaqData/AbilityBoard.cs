// Decompiled with JetBrains decompiler
// Type: StaqData.AbilityBoard
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x20020FA")]
  public class AbilityBoard
  {
    [Token(Token = "0x17002B3F")]
    public int ParameterId
    {
      [Token(Token = "0x600C827"), Address(RVA = "0x1CE1A28", Offset = "0x1CE1A28", VA = "0x1CE1A28")] get
      {
        return new int();
      }
      [Token(Token = "0x600C828"), Address(RVA = "0x1CE1A30", Offset = "0x1CE1A30", VA = "0x1CE1A30")] private set
      {
      }
    }

    [Token(Token = "0x17002B40")]
    public int Value
    {
      [Token(Token = "0x600C829"), Address(RVA = "0x1CE1A38", Offset = "0x1CE1A38", VA = "0x1CE1A38")] get
      {
        return new int();
      }
      [Token(Token = "0x600C82A"), Address(RVA = "0x1CE1A40", Offset = "0x1CE1A40", VA = "0x1CE1A40")] private set
      {
      }
    }

    [Token(Token = "0x600C82B")]
    [Address(RVA = "0x1CE1A48", Offset = "0x1CE1A48", VA = "0x1CE1A48")]
    public AbilityBoard()
    {
    }

    [Token(Token = "0x600C82C")]
    [Address(RVA = "0x1CE1A50", Offset = "0x1CE1A50", VA = "0x1CE1A50")]
    public void Apply(PlayerUnitAbilityBoardParameterType entity)
    {
    }

    [Token(Token = "0x600C82D")]
    [Address(RVA = "0x1CE1A70", Offset = "0x1CE1A70", VA = "0x1CE1A70")]
    private void Reset()
    {
    }
  }
}
