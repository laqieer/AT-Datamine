// Decompiled with JetBrains decompiler
// Type: GameCore.Scene.SceneAssetName
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace GameCore.Scene
{
  [Token(Token = "0x2000C5A")]
  public static class SceneAssetName
  {
    [Token(Token = "0x600470C")]
    [Address(RVA = "0x351D74C", Offset = "0x351D74C", VA = "0x351D74C")]
    public static SubSceneAssetNames GetAssetName(SceneAssetName.SubSceneAssetNameType type)
    {
      return (SubSceneAssetNames) null;
    }

    [Token(Token = "0x2000C5B")]
    public enum SubSceneAssetNameType
    {
      [Token(Token = "0x40037C9")] Home,
      [Token(Token = "0x40037CA")] Armoury,
      [Token(Token = "0x40037CB")] ScenarioQuestSelect,
      [Token(Token = "0x40037CC")] ScenarioQuestTop,
      [Token(Token = "0x40037CD")] SpecialBattle,
      [Token(Token = "0x40037CE")] EventQuest,
      [Token(Token = "0x40037CF")] ScoreAttack,
      [Token(Token = "0x40037D0")] ScoreAttackResult,
    }
  }
}
