// Decompiled with JetBrains decompiler
// Type: Battle.Command.UnitCommandLog
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using FlatBuffers;
using Il2CppDummyDll;
using staq.SaveSchema;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Battle.Command
{
  [Token(Token = "0x20024BB")]
  [Serializable]
  public class UnitCommandLog
  {
    [Token(Token = "0x4009D72")]
    [FieldOffset(Offset = "0x10")]
    public CommandType MainCommand;
    [Token(Token = "0x4009D73")]
    [FieldOffset(Offset = "0x14")]
    public int ActionUnitId;
    [Token(Token = "0x4009D74")]
    [FieldOffset(Offset = "0x18")]
    public int TargetId;
    [Token(Token = "0x4009D75")]
    [FieldOffset(Offset = "0x1C")]
    public int UseSkillId;
    [Token(Token = "0x4009D76")]
    [FieldOffset(Offset = "0x20")]
    public int ChargeSkillId;
    [Token(Token = "0x4009D77")]
    [FieldOffset(Offset = "0x24")]
    public int UseItemId;
    [Token(Token = "0x4009D78")]
    [FieldOffset(Offset = "0x28")]
    public Vector2Int MoveTo;
    [Token(Token = "0x4009D79")]
    [FieldOffset(Offset = "0x30")]
    public Vector2Int TargetTo;
    [Token(Token = "0x4009D7A")]
    [FieldOffset(Offset = "0x38")]
    public bool SwitchDouble;
    [Token(Token = "0x4009D7B")]
    [FieldOffset(Offset = "0x3C")]
    public int UseWeaponIdx;
    [Token(Token = "0x4009D7C")]
    [FieldOffset(Offset = "0x40")]
    public int BackWeaponIdx;
    [Token(Token = "0x4009D7D")]
    [FieldOffset(Offset = "0x48")]
    private ActionResult preSkillResult;
    [Token(Token = "0x4009D7E")]
    [FieldOffset(Offset = "0x50")]
    private ActionResult onSkillResult;
    [Token(Token = "0x4009D7F")]
    [FieldOffset(Offset = "0x58")]
    private ActionResult postSkillResult;

    [Token(Token = "0x600E1F5")]
    [Address(RVA = "0x42651E0", Offset = "0x42651E0", VA = "0x42651E0")]
    public UnitCommandLog(Queue<UnitCommandBase> srcQueue)
    {
    }

    [Token(Token = "0x600E1F6")]
    [Address(RVA = "0x4265820", Offset = "0x4265820", VA = "0x4265820")]
    public UnitCommandLog(CommandLog schema)
    {
    }

    [Token(Token = "0x600E1F7")]
    [Address(RVA = "0x4265A38", Offset = "0x4265A38", VA = "0x4265A38")]
    public UnitCommandLog(
      CommandType type,
      int ownerId,
      Vector2Int moveTo,
      Vector2Int targetTo,
      int skillId,
      bool switchDouble)
    {
    }

    [Token(Token = "0x600E1F8")]
    [Address(RVA = "0x4265AA4", Offset = "0x4265AA4", VA = "0x4265AA4")]
    public Offset<CommandLog> Serialize(FlatBufferBuilder fbb) => new Offset<CommandLog>();

    [Token(Token = "0x600E1F9")]
    [Address(RVA = "0x4265BAC", Offset = "0x4265BAC", VA = "0x4265BAC")]
    public string ToJson() => (string) null;
  }
}
