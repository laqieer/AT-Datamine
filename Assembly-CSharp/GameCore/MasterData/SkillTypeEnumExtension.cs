// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.SkillTypeEnumExtension
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001402")]
  public static class SkillTypeEnumExtension
  {
    [Token(Token = "0x4005CF1")]
    [FieldOffset(Offset = "0x0")]
    public static readonly List<SkillTypeEnum> SortSkillType;

    [Token(Token = "0x60070EB")]
    [Address(RVA = "0x421C66C", Offset = "0x421C66C", VA = "0x421C66C")]
    public static string DisplayName(this SkillTypeEnum skillType) => (string) null;

    [Token(Token = "0x60070EC")]
    [Address(RVA = "0x421C744", Offset = "0x421C744", VA = "0x421C744")]
    static SkillTypeEnumExtension()
    {
    }
  }
}
