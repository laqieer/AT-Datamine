// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.IPossessionLimitData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001410")]
  public interface IPossessionLimitData
  {
    [Token(Token = "0x170010E9")]
    ItemTypeEnum ItemType { [Token(Token = "0x600710B")] get; }

    [Token(Token = "0x170010EA")]
    int ShowLimitNumber { [Token(Token = "0x600710C")] get; }

    [Token(Token = "0x170010EB")]
    int PossessionLimitNumber { [Token(Token = "0x600710D")] get; }

    [Token(Token = "0x170010EC")]
    bool SendPresent { [Token(Token = "0x600710E")] get; }
  }
}
