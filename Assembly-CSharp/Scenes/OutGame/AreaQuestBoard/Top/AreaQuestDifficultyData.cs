// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.AreaQuestBoard.Top.AreaQuestDifficultyData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Scenes.OutGame.AreaQuestBoard.Top
{
  [Token(Token = "0x20038F1")]
  internal struct AreaQuestDifficultyData
  {
    [Token(Token = "0x400F907")]
    [FieldOffset(Offset = "0x4")]
    public readonly int UnlockHighestDifficultyId;
    [Token(Token = "0x400F908")]
    [FieldOffset(Offset = "0x8")]
    public readonly bool FixedDifficultyLevel;

    [Token(Token = "0x1700499D")]
    public int SelectedDifficultyId
    {
      [Token(Token = "0x601662B"), Address(RVA = "0x2081D9C", Offset = "0x2081D9C", VA = "0x2081D9C")] readonly get
      {
        return new int();
      }
      [Token(Token = "0x601662C"), Address(RVA = "0x2081DA4", Offset = "0x2081DA4", VA = "0x2081DA4")] private set
      {
      }
    }

    [Token(Token = "0x601662D")]
    [Address(RVA = "0x2081DAC", Offset = "0x2081DAC", VA = "0x2081DAC")]
    private AreaQuestDifficultyData(
      int selectedDifficultyId,
      int unlockDifficultyId,
      bool fixedDifficultyLevel)
    {
    }

    [Token(Token = "0x601662E")]
    [Address(RVA = "0x207D164", Offset = "0x207D164", VA = "0x207D164")]
    public void SetSelectedDifficultyId(int selectedDifficultyId)
    {
    }

    [Token(Token = "0x601662F")]
    [Address(RVA = "0x207CDEC", Offset = "0x207CDEC", VA = "0x207CDEC")]
    public static AreaQuestDifficultyData CreateData(int areaGroupId)
    {
      return new AreaQuestDifficultyData();
    }

    [Token(Token = "0x6016630")]
    [Address(RVA = "0x2081DBC", Offset = "0x2081DBC", VA = "0x2081DBC")]
    private static AreaQuestDifficultyData CreateDifficultyData() => new AreaQuestDifficultyData();
  }
}
