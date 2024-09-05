// Decompiled with JetBrains decompiler
// Type: Staq.Tools.DuelDebugTool.DuelDebugTurn
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace Staq.Tools.DuelDebugTool
{
  [Token(Token = "0x2000982")]
  [Serializable]
  public class DuelDebugTurn
  {
    [Token(Token = "0x4002C3A")]
    [FieldOffset(Offset = "0x10")]
    public DuelDebugAction AttackerAction;
    [Token(Token = "0x4002C3B")]
    [FieldOffset(Offset = "0x18")]
    public DuelDebugAction AttackerSupporterAction;
    [Token(Token = "0x4002C3C")]
    [FieldOffset(Offset = "0x20")]
    public DuelDebugAction DefenderAction;
    [Token(Token = "0x4002C3D")]
    [FieldOffset(Offset = "0x28")]
    public DuelDebugAction DefenderSupporterAction;

    [Token(Token = "0x600360E")]
    [Address(RVA = "0x3531468", Offset = "0x3531468", VA = "0x3531468")]
    public static DuelDebugTurn CreateDefaultTurn() => (DuelDebugTurn) null;

    [Token(Token = "0x600360F")]
    [Address(RVA = "0x3531734", Offset = "0x3531734", VA = "0x3531734")]
    public Dictionary<DuelCharacterController.DuelCharacterRole, IDuelDebugToolActionSettings> ToDict()
    {
      return (Dictionary<DuelCharacterController.DuelCharacterRole, IDuelDebugToolActionSettings>) null;
    }

    [Token(Token = "0x6003610")]
    [Address(RVA = "0x3531838", Offset = "0x3531838", VA = "0x3531838")]
    public DuelDebugTurn()
    {
    }
  }
}
