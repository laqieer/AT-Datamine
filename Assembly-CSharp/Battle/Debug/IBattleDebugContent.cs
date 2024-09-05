// Decompiled with JetBrains decompiler
// Type: Battle.Debug.IBattleDebugContent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Il2CppDummyDll;

#nullable disable
namespace Battle.Debug
{
  [Token(Token = "0x20025CA")]
  public interface IBattleDebugContent
  {
    [Token(Token = "0x170031D2")]
    bool IsValid { [Token(Token = "0x600E956")] get; }

    [Token(Token = "0x600E957")]
    void OnGUI();

    [Token(Token = "0x600E958")]
    bool OnGUI(UnitParameterData unit);

    [Token(Token = "0x600E959")]
    bool OnGUI(GridData grid);
  }
}
