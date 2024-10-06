// Decompiled with JetBrains decompiler
// Type: StaqData.Story.StoryAbilityList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace StaqData.Story
{
  [Token(Token = "0x200215F")]
  public class StoryAbilityList
  {
    [Token(Token = "0x4008D66")]
    [FieldOffset(Offset = "0x10")]
    private readonly Dictionary<int, StoryAbility> abilities;

    [Token(Token = "0x600CC92")]
    [Address(RVA = "0x1BB01D4", Offset = "0x1BB01D4", VA = "0x1BB01D4")]
    public void Initialize(IEnumerable<int> abilityIDs)
    {
    }

    [Token(Token = "0x600CC93")]
    [Address(RVA = "0x1BB0234", Offset = "0x1BB0234", VA = "0x1BB0234")]
    public void Apply(IEnumerable<int> abilityIDs)
    {
    }

    [Token(Token = "0x600CC94")]
    [Address(RVA = "0x1BB05D0", Offset = "0x1BB05D0", VA = "0x1BB05D0")]
    public bool Contains(int abilityID) => new bool();

    [Token(Token = "0x600CC95")]
    [Address(RVA = "0x1BB0628", Offset = "0x1BB0628", VA = "0x1BB0628")]
    public StoryAbilityList()
    {
    }
  }
}
