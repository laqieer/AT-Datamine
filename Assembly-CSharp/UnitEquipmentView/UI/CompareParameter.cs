// Decompiled with JetBrains decompiler
// Type: UnitEquipmentView.UI.CompareParameter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnitEquipmentView.Equipment;
using Utility;

#nullable disable
namespace UnitEquipmentView.UI
{
  [Token(Token = "0x2000432")]
  public class CompareParameter
  {
    [Token(Token = "0x400179A")]
    [FieldOffset(Offset = "0x10")]
    private readonly ParameterColorCode parameterColor;

    [Token(Token = "0x60017CB")]
    [Address(RVA = "0x248EC80", Offset = "0x248EC80", VA = "0x248EC80")]
    public string ColorCode(Parameter param1, Parameter param2, bool smallerOneIsPositive = false)
    {
      return (string) null;
    }

    [Token(Token = "0x60017CC")]
    [Address(RVA = "0x248ED10", Offset = "0x248ED10", VA = "0x248ED10")]
    private ParameterColorCode.Color GetColor(bool isPositive) => (ParameterColorCode.Color) null;

    [Token(Token = "0x60017CD")]
    [Address(RVA = "0x248ED3C", Offset = "0x248ED3C", VA = "0x248ED3C")]
    public CompareParameter()
    {
    }
  }
}
