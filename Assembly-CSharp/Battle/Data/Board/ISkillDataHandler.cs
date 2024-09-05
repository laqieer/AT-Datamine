// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.ISkillDataHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x20027F8")]
  public interface ISkillDataHandler
  {
    [Token(Token = "0x600F9ED")]
    int RequestSkillId(int skill, int level, int rarity);

    [Token(Token = "0x600F9EE")]
    bool TryGetSkill(int id, out SkillData skill);

    [Token(Token = "0x600F9EF")]
    bool RegisterSkill(SkillData skill);
  }
}
