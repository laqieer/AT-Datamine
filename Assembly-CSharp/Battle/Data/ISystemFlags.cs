// Decompiled with JetBrains decompiler
// Type: Battle.Data.ISystemFlags
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Battle.Data
{
  [Token(Token = "0x20026F8")]
  public interface ISystemFlags
  {
    [Token(Token = "0x1700330C")]
    bool EnableStaging { [Token(Token = "0x600F13D")] get; }

    [Token(Token = "0x1700330D")]
    bool AutoMode { [Token(Token = "0x600F13E")] get; [Token(Token = "0x600F13F")] set; }

    [Token(Token = "0x1700330E")]
    bool FastMode { [Token(Token = "0x600F140")] get; [Token(Token = "0x600F141")] set; }

    [Token(Token = "0x1700330F")]
    bool DangerArea { [Token(Token = "0x600F142")] get; [Token(Token = "0x600F143")] set; }

    [Token(Token = "0x17003310")]
    bool IsSkip { [Token(Token = "0x600F144")] get; [Token(Token = "0x600F145")] set; }

    [Token(Token = "0x17003311")]
    bool ShowGridLines { [Token(Token = "0x600F146")] get; [Token(Token = "0x600F147")] set; }

    [Token(Token = "0x17003312")]
    bool ShowDuelAnim { [Token(Token = "0x600F148")] get; [Token(Token = "0x600F149")] set; }

    [Token(Token = "0x17003313")]
    bool ShowStatusIcon { [Token(Token = "0x600F14A")] get; [Token(Token = "0x600F14B")] set; }

    [Token(Token = "0x17003314")]
    bool AutoBattlePlayScenarioFast { [Token(Token = "0x600F14C")] get; [Token(Token = "0x600F14D")] set; }

    [Token(Token = "0x17003315")]
    bool AutoBattlePauseUnitLost { [Token(Token = "0x600F14E")] get; [Token(Token = "0x600F14F")] set; }

    [Token(Token = "0x17003316")]
    bool AutoBattleDisableDownLP { [Token(Token = "0x600F150")] get; [Token(Token = "0x600F151")] set; }

    [Token(Token = "0x17003317")]
    int CameraIndex { [Token(Token = "0x600F152")] get; [Token(Token = "0x600F153")] set; }

    [Token(Token = "0x17003318")]
    bool AutoPlacement { [Token(Token = "0x600F154")] get; [Token(Token = "0x600F155")] set; }

    [Token(Token = "0x17003319")]
    bool CanItemUse { [Token(Token = "0x600F156")] get; [Token(Token = "0x600F157")] set; }

    [Token(Token = "0x1700331A")]
    bool IsTutorial { [Token(Token = "0x600F158")] get; [Token(Token = "0x600F159")] set; }

    [Token(Token = "0x1700331B")]
    bool CanRollBack { [Token(Token = "0x600F15A")] get; [Token(Token = "0x600F15B")] set; }

    [Token(Token = "0x1700331C")]
    bool ShowLevelUpEffect { [Token(Token = "0x600F15C")] get; [Token(Token = "0x600F15D")] set; }

    [Token(Token = "0x600F15E")]
    void SaveSettings();
  }
}
