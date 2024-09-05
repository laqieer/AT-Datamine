// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Info.Character.CharacterModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using StaqData;

#nullable disable
namespace Scenes.OutGame.Info.Character
{
  [Token(Token = "0x2003552")]
  public class CharacterModel : ICharacterModel
  {
    [Token(Token = "0x17004565")]
    public int LP
    {
      [Token(Token = "0x6014EC3"), Address(RVA = "0x1B4B8D0", Offset = "0x1B4B8D0", VA = "0x1B4B8D0", Slot = "4")] get
      {
        return new int();
      }
      [Token(Token = "0x6014EC4"), Address(RVA = "0x1B4B8D8", Offset = "0x1B4B8D8", VA = "0x1B4B8D8")] set
      {
      }
    }

    [Token(Token = "0x17004566")]
    public int LPMax
    {
      [Token(Token = "0x6014EC5"), Address(RVA = "0x1B4B8E0", Offset = "0x1B4B8E0", VA = "0x1B4B8E0", Slot = "5")] get
      {
        return new int();
      }
      [Token(Token = "0x6014EC6"), Address(RVA = "0x1B4B8E8", Offset = "0x1B4B8E8", VA = "0x1B4B8E8")] set
      {
      }
    }

    [Token(Token = "0x17004567")]
    public string CharacterName
    {
      [Token(Token = "0x6014EC7"), Address(RVA = "0x1B4B8F0", Offset = "0x1B4B8F0", VA = "0x1B4B8F0", Slot = "6")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6014EC8"), Address(RVA = "0x1B4B8F8", Offset = "0x1B4B8F8", VA = "0x1B4B8F8")] private set
      {
      }
    }

    [Token(Token = "0x6014EC9")]
    [Address(RVA = "0x1B4B900", Offset = "0x1B4B900", VA = "0x1B4B900")]
    public void Set(UniqueID uniqueID)
    {
    }

    [Token(Token = "0x6014ECA")]
    [Address(RVA = "0x1B4B9CC", Offset = "0x1B4B9CC", VA = "0x1B4B9CC")]
    public void Set(StaqData.Character character)
    {
    }

    [Token(Token = "0x6014ECB")]
    [Address(RVA = "0x1B4B9F8", Offset = "0x1B4B9F8", VA = "0x1B4B9F8")]
    public void Set(CharacterData characterData)
    {
    }

    [Token(Token = "0x6014ECC")]
    [Address(RVA = "0x1B4BA20", Offset = "0x1B4BA20", VA = "0x1B4BA20")]
    public CharacterModel()
    {
    }
  }
}
