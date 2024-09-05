// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.IFreeActionLayoutData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001436")]
  public interface IFreeActionLayoutData
  {
    [Token(Token = "0x17001131")]
    int LayoutGroup { [Token(Token = "0x60071AC")] get; }

    [Token(Token = "0x17001132")]
    int AreaID { [Token(Token = "0x60071AD")] get; }

    [Token(Token = "0x17001133")]
    string Anchor { [Token(Token = "0x60071AE")] get; }

    [Token(Token = "0x17001134")]
    IFreeActionObjectData Placement { [Token(Token = "0x60071AF")] get; }

    [Token(Token = "0x17001135")]
    int CharacterPattern { [Token(Token = "0x60071B0")] get; }

    [Token(Token = "0x17001136")]
    int RotationY { [Token(Token = "0x60071B1")] get; }

    [Token(Token = "0x17001137")]
    Vector3 PositionOffset { [Token(Token = "0x60071B2")] get; }
  }
}
