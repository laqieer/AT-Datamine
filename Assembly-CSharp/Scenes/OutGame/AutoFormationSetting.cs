// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.AutoFormationSetting
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Scenes.OutGame
{
  [Token(Token = "0x2003286")]
  public class AutoFormationSetting
  {
    [Token(Token = "0x400D84B")]
    [FieldOffset(Offset = "0x10")]
    public int OrganizationSlotNum;
    [Token(Token = "0x400D84C")]
    [FieldOffset(Offset = "0x14")]
    public bool LostStyleOut;
    [Token(Token = "0x400D84D")]
    [FieldOffset(Offset = "0x18")]
    public List<int> InCharacterIdList;
    [Token(Token = "0x400D84E")]
    [FieldOffset(Offset = "0x20")]
    public List<int> OutCharacterIdList;
    [Token(Token = "0x400D84F")]
    [FieldOffset(Offset = "0x28")]
    public List<int> InStyleIdList;
    [Token(Token = "0x400D850")]
    [FieldOffset(Offset = "0x30")]
    public List<int> OutStyleIdList;
    [Token(Token = "0x400D851")]
    [FieldOffset(Offset = "0x38")]
    public ElementTypeEnum StageElementType;
    [Token(Token = "0x400D852")]
    [FieldOffset(Offset = "0x3C")]
    public bool AutoFormationStyleOnly;

    [Token(Token = "0x6013B49")]
    [Address(RVA = "0x18573D4", Offset = "0x18573D4", VA = "0x18573D4")]
    public AutoFormationSetting()
    {
    }
  }
}
