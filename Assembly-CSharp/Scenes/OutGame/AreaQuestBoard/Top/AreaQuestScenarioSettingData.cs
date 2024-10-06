// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.AreaQuestBoard.Top.AreaQuestScenarioSettingData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Scenes.OutGame.AreaQuestBoard.Top
{
  [Token(Token = "0x20038F3")]
  public class AreaQuestScenarioSettingData
  {
    [Token(Token = "0x400F90A")]
    [FieldOffset(Offset = "0x10")]
    private bool skipSettingStatus;

    [Token(Token = "0x1700499E")]
    public bool SkipSettingStatus
    {
      [Token(Token = "0x6016633"), Address(RVA = "0x2081F04", Offset = "0x2081F04", VA = "0x2081F04")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6016634")]
    [Address(RVA = "0x2081F0C", Offset = "0x2081F0C", VA = "0x2081F0C")]
    private AreaQuestScenarioSettingData()
    {
    }

    [Token(Token = "0x6016635")]
    [Address(RVA = "0x207CEEC", Offset = "0x207CEEC", VA = "0x207CEEC")]
    public static AreaQuestScenarioSettingData Create() => (AreaQuestScenarioSettingData) null;

    [Token(Token = "0x6016636")]
    [Address(RVA = "0x207D16C", Offset = "0x207D16C", VA = "0x207D16C")]
    public void ApplySkipSettingStatus(bool on)
    {
    }
  }
}
