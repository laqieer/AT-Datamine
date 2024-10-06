// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.IFreeActionObjectData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001437")]
  public interface IFreeActionObjectData
  {
    [Token(Token = "0x17001138")]
    int DataID { [Token(Token = "0x60071B3")] get; }

    [Token(Token = "0x17001139")]
    string ObjectName { [Token(Token = "0x60071B4")] get; }

    [Token(Token = "0x1700113A")]
    int CharacterSwitchPatternID { [Token(Token = "0x60071B5")] get; }

    [Token(Token = "0x1700113B")]
    string ObjectAccessName { [Token(Token = "0x60071B6")] get; }

    [Token(Token = "0x1700113C")]
    int PropID { [Token(Token = "0x60071B7")] get; }

    [Token(Token = "0x1700113D")]
    StoryFreeActionObjectTypeEnum ObjectType { [Token(Token = "0x60071B8")] get; }
  }
}
