// Decompiled with JetBrains decompiler
// Type: Battle.UI.SkillButtonInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Il2CppDummyDll;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x20023B5")]
  public class SkillButtonInfo
  {
    [Token(Token = "0x4009827")]
    [FieldOffset(Offset = "0x10")]
    public SkillParameterData skillParam;
    [Token(Token = "0x4009828")]
    [FieldOffset(Offset = "0x18")]
    public SkillModel skillModel;
    [Token(Token = "0x4009829")]
    [FieldOffset(Offset = "0x20")]
    public int selectId;
    [Token(Token = "0x400982A")]
    [FieldOffset(Offset = "0x24")]
    public bool isTargetEffective;
    [Token(Token = "0x400982B")]
    [FieldOffset(Offset = "0x25")]
    public bool canUse;
    [Token(Token = "0x400982C")]
    [FieldOffset(Offset = "0x26")]
    public bool isRangeOut;

    [Token(Token = "0x600DA80")]
    [Address(RVA = "0x22D9CE8", Offset = "0x22D9CE8", VA = "0x22D9CE8")]
    public SkillButtonInfo()
    {
    }
  }
}
