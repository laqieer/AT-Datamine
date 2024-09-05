// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.OfferSkillEffectData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x20027D0")]
  public class OfferSkillEffectData : EffectData
  {
    [Token(Token = "0x170035B2")]
    public SkillData Skill
    {
      [Token(Token = "0x600F8B4"), Address(RVA = "0x44BC5F4", Offset = "0x44BC5F4", VA = "0x44BC5F4")] get
      {
        return (SkillData) null;
      }
      [Token(Token = "0x600F8B5"), Address(RVA = "0x44BC5FC", Offset = "0x44BC5FC", VA = "0x44BC5FC")] private set
      {
      }
    }

    [Token(Token = "0x600F8B6")]
    [Address(RVA = "0x44BC604", Offset = "0x44BC604", VA = "0x44BC604")]
    public static OfferSkillEffectData Create(OfferSkillEffectSource source)
    {
      return (OfferSkillEffectData) null;
    }

    [Token(Token = "0x600F8B7")]
    [Address(RVA = "0x44BC6C8", Offset = "0x44BC6C8", VA = "0x44BC6C8")]
    protected OfferSkillEffectData(EffectSource source)
    {
    }

    [Token(Token = "0x20027D1")]
    public enum ContextType
    {
      [Token(Token = "0x400A986")] SkillID = 1,
      [Token(Token = "0x400A987")] SkillLevel = 2,
    }
  }
}
