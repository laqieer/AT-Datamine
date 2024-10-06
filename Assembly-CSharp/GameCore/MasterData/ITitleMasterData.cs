// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ITitleMasterData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001428")]
  public interface ITitleMasterData
  {
    [Token(Token = "0x1700111C")]
    int TitleId { [Token(Token = "0x600717D")] get; }

    [Token(Token = "0x1700111D")]
    TitleTypeEnum TitleType { [Token(Token = "0x600717E")] get; }

    [Token(Token = "0x1700111E")]
    string Text { [Token(Token = "0x600717F")] get; }

    [Token(Token = "0x1700111F")]
    int? SpriteId { [Token(Token = "0x6007180")] get; }

    [Token(Token = "0x17001120")]
    int? Size { [Token(Token = "0x6007181")] get; }

    [Token(Token = "0x17001121")]
    string ColorCode { [Token(Token = "0x6007182")] get; }

    [Token(Token = "0x17001122")]
    string UnlockDescription { [Token(Token = "0x6007183")] get; }
  }
}
