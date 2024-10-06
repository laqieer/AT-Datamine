// Decompiled with JetBrains decompiler
// Type: Battle.Process.ManualActionLuaCommandData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Battle.Process
{
  [Token(Token = "0x200262A")]
  public class ManualActionLuaCommandData
  {
    [Token(Token = "0x400A3EA")]
    [FieldOffset(Offset = "0x10")]
    public UnitParameterData actionUnit;
    [Token(Token = "0x400A3EB")]
    [FieldOffset(Offset = "0x18")]
    public LuaActionCommandEnum command;
    [Token(Token = "0x400A3EC")]
    [FieldOffset(Offset = "0x1C")]
    public Vector2Int moveGridPos;
    [Token(Token = "0x400A3ED")]
    [FieldOffset(Offset = "0x24")]
    public Vector2Int targetPos;
    [Token(Token = "0x400A3EE")]
    [FieldOffset(Offset = "0x2C")]
    public int skillIdx;
    [Token(Token = "0x400A3EF")]
    [FieldOffset(Offset = "0x30")]
    public int weaponIndex;

    [Token(Token = "0x600EC27")]
    [Address(RVA = "0x4482990", Offset = "0x4482990", VA = "0x4482990")]
    public ManualActionLuaCommandData(
      UnitParameterData unit,
      LuaActionCommandEnum command,
      Vector2Int pos,
      Vector2Int target,
      int skillidx)
    {
    }

    [Token(Token = "0x600EC28")]
    [Address(RVA = "0x44829F4", Offset = "0x44829F4", VA = "0x44829F4")]
    public ManualActionLuaCommandData(
      UnitParameterData unit,
      LuaActionCommandEnum command,
      int weapon)
    {
    }
  }
}
