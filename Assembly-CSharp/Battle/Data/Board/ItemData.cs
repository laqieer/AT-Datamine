// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.ItemData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x20027EE")]
  public class ItemData
  {
    [Token(Token = "0x170035F2")]
    public int Id
    {
      [Token(Token = "0x600F95C"), Address(RVA = "0x44C2008", Offset = "0x44C2008", VA = "0x44C2008")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170035F3")]
    public ExpendablesData MasterData
    {
      [Token(Token = "0x600F95D"), Address(RVA = "0x44C2024", Offset = "0x44C2024", VA = "0x44C2024")] get
      {
        return (ExpendablesData) null;
      }
      [Token(Token = "0x600F95E"), Address(RVA = "0x44C202C", Offset = "0x44C202C", VA = "0x44C202C")] private set
      {
      }
    }

    [Token(Token = "0x170035F4")]
    public ActiveSkillData Skill
    {
      [Token(Token = "0x600F95F"), Address(RVA = "0x44C2034", Offset = "0x44C2034", VA = "0x44C2034")] get
      {
        return (ActiveSkillData) null;
      }
      [Token(Token = "0x600F960"), Address(RVA = "0x44C203C", Offset = "0x44C203C", VA = "0x44C203C")] private set
      {
      }
    }

    [Token(Token = "0x170035F5")]
    public ItemTypeEnum ItemType
    {
      [Token(Token = "0x600F961"), Address(RVA = "0x44C2044", Offset = "0x44C2044", VA = "0x44C2044")] get
      {
        return new ItemTypeEnum();
      }
    }

    [Token(Token = "0x170035F6")]
    public int MaxAmount
    {
      [Token(Token = "0x600F962"), Address(RVA = "0x44C204C", Offset = "0x44C204C", VA = "0x44C204C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170035F7")]
    public string Name
    {
      [Token(Token = "0x600F963"), Address(RVA = "0x44C2068", Offset = "0x44C2068", VA = "0x44C2068")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600F964")]
    [Address(RVA = "0x44C2084", Offset = "0x44C2084", VA = "0x44C2084")]
    public static ItemData Create(int itemId, ActiveSkillData skill) => (ItemData) null;

    [Token(Token = "0x600F965")]
    [Address(RVA = "0x44C2174", Offset = "0x44C2174", VA = "0x44C2174")]
    public ItemData()
    {
    }
  }
}
