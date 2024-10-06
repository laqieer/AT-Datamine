// Decompiled with JetBrains decompiler
// Type: Battle.Grid.GridViewTypeExt
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Battle.Grid
{
  [Token(Token = "0x200252A")]
  public static class GridViewTypeExt
  {
    [Token(Token = "0x4009FAA")]
    public const int TexNoPlayer = 1;
    [Token(Token = "0x4009FAB")]
    public const int TexNoEnemy = 2;
    [Token(Token = "0x4009FAC")]
    public const int TexNoMovable = 3;
    [Token(Token = "0x4009FAD")]
    public const int TexNoAttack = 2;
    [Token(Token = "0x4009FAE")]
    public const int TexNoHealing = 4;
    [Token(Token = "0x4009FAF")]
    public const int TexNoOther = 5;

    [Token(Token = "0x600E58D")]
    [Address(RVA = "0x48692FC", Offset = "0x48692FC", VA = "0x48692FC")]
    public static bool Is(this GridViewType self, GridViewType flag) => new bool();

    [Token(Token = "0x600E58E")]
    [Address(RVA = "0x4869318", Offset = "0x4869318", VA = "0x4869318")]
    public static bool IsNot(this GridViewType self, GridViewType flag) => new bool();

    [Token(Token = "0x600E58F")]
    [Address(RVA = "0x4869338", Offset = "0x4869338", VA = "0x4869338")]
    public static int GetPanelTexNo(this GridViewType type) => new int();
  }
}
