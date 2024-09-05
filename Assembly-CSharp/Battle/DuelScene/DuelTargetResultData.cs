// Decompiled with JetBrains decompiler
// Type: Battle.DuelScene.DuelTargetResultData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Battle.Data.Board;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.DuelScene
{
  [Token(Token = "0x2002549")]
  public sealed class DuelTargetResultData
  {
    [Token(Token = "0x400A070")]
    [FieldOffset(Offset = "0x10")]
    public UnitParameterData Target;
    [Token(Token = "0x400A071")]
    [FieldOffset(Offset = "0x18")]
    public bool IsAnyHit;
    [Token(Token = "0x400A072")]
    [FieldOffset(Offset = "0x20")]
    public List<SupportData> SupportSkillCountList;
    [Token(Token = "0x400A073")]
    [FieldOffset(Offset = "0x28")]
    public UnitParameterChange PrevParam;
    [Token(Token = "0x400A074")]
    [FieldOffset(Offset = "0x30")]
    public UnitParameterChange AfterParam;

    [Token(Token = "0x600E634")]
    [Address(RVA = "0x486D50C", Offset = "0x486D50C", VA = "0x486D50C")]
    public DuelTargetResultData(UnitParameterData unit)
    {
    }
  }
}
