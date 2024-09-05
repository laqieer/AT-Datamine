// Decompiled with JetBrains decompiler
// Type: Battle.UI.CharacterModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Il2CppDummyDll;
using Scenes.OutGame.Info.Character;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x200238E")]
  public class CharacterModel : ICharacterModel
  {
    [Token(Token = "0x17002EAA")]
    public int LP
    {
      [Token(Token = "0x600D912"), Address(RVA = "0x22C5794", Offset = "0x22C5794", VA = "0x22C5794", Slot = "4")] get
      {
        return new int();
      }
      [Token(Token = "0x600D913"), Address(RVA = "0x22C579C", Offset = "0x22C579C", VA = "0x22C579C")] private set
      {
      }
    }

    [Token(Token = "0x17002EAB")]
    public int LPMax
    {
      [Token(Token = "0x600D914"), Address(RVA = "0x22C57A4", Offset = "0x22C57A4", VA = "0x22C57A4", Slot = "5")] get
      {
        return new int();
      }
      [Token(Token = "0x600D915"), Address(RVA = "0x22C57AC", Offset = "0x22C57AC", VA = "0x22C57AC")] private set
      {
      }
    }

    [Token(Token = "0x17002EAC")]
    public string CharacterName
    {
      [Token(Token = "0x600D916"), Address(RVA = "0x22C57B4", Offset = "0x22C57B4", VA = "0x22C57B4", Slot = "6")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600D917"), Address(RVA = "0x22C57BC", Offset = "0x22C57BC", VA = "0x22C57BC")] private set
      {
      }
    }

    [Token(Token = "0x600D918")]
    [Address(RVA = "0x22C57C4", Offset = "0x22C57C4", VA = "0x22C57C4")]
    public void Set(UnitParameterData unit)
    {
    }

    [Token(Token = "0x600D919")]
    [Address(RVA = "0x22C581C", Offset = "0x22C581C", VA = "0x22C581C")]
    public void Set(CharacterModel model)
    {
    }

    [Token(Token = "0x600D91A")]
    [Address(RVA = "0x22C5840", Offset = "0x22C5840", VA = "0x22C5840")]
    public CharacterModel()
    {
    }
  }
}
