// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.IWeaponDataHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x2002816")]
  public interface IWeaponDataHandler
  {
    [Token(Token = "0x600FC1F")]
    bool TryGetWeapon(string id, out WeaponData weapon);

    [Token(Token = "0x600FC20")]
    bool RegisterWeapon(WeaponData weapon);
  }
}
