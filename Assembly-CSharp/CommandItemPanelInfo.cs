// Decompiled with JetBrains decompiler
// Type: CommandItemPanelInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Il2CppDummyDll;

#nullable disable
[Token(Token = "0x20001C2")]
public class CommandItemPanelInfo
{
  [Token(Token = "0x4000AB1")]
  [FieldOffset(Offset = "0x10")]
  public UnitParameterData ownerUnit;
  [Token(Token = "0x4000AB2")]
  [FieldOffset(Offset = "0x18")]
  public SkillParameterData skillParam;
  [Token(Token = "0x4000AB3")]
  [FieldOffset(Offset = "0x20")]
  public int selectIndex;
  [Token(Token = "0x4000AB4")]
  [FieldOffset(Offset = "0x24")]
  public bool isEmphasis;

  [Token(Token = "0x6000B8A")]
  [Address(RVA = "0x4BCA144", Offset = "0x4BCA144", VA = "0x4BCA144")]
  public CommandItemPanelInfo()
  {
  }
}
