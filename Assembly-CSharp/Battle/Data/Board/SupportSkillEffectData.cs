// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.SupportSkillEffectData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x20027DB")]
  public class SupportSkillEffectData : EffectData
  {
    [Token(Token = "0x170035C3")]
    public SkillData Skill
    {
      [Token(Token = "0x600F8DC"), Address(RVA = "0x44BD150", Offset = "0x44BD150", VA = "0x44BD150")] get
      {
        return (SkillData) null;
      }
      [Token(Token = "0x600F8DD"), Address(RVA = "0x44BD158", Offset = "0x44BD158", VA = "0x44BD158")] private set
      {
      }
    }

    [Token(Token = "0x600F8DE")]
    [Address(RVA = "0x44BD160", Offset = "0x44BD160", VA = "0x44BD160")]
    public static SupportSkillEffectData Create(SupportSkillEffectSource source)
    {
      return (SupportSkillEffectData) null;
    }

    [Token(Token = "0x600F8DF")]
    [Address(RVA = "0x44BD224", Offset = "0x44BD224", VA = "0x44BD224")]
    protected SupportSkillEffectData(EffectSource source)
    {
    }

    [Token(Token = "0x600F8E0")]
    [Address(RVA = "0x44BD258", Offset = "0x44BD258", VA = "0x44BD258", Slot = "7")]
    protected override void CreateKey()
    {
    }

    [Token(Token = "0x20027DC")]
    public enum ContextType
    {
      [Token(Token = "0x400A9A9")] SkillID,
      [Token(Token = "0x400A9AA")] SkillLevel,
    }
  }
}
