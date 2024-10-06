// Decompiled with JetBrains decompiler
// Type: Story.KizunaQuest.CommuSkillTempLevelContainer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Story.KizunaQuest
{
  [Token(Token = "0x2000681")]
  public class CommuSkillTempLevelContainer
  {
    [Token(Token = "0x4001F42")]
    [FieldOffset(Offset = "0x10")]
    private Dictionary<int, int> commuSkillLevelTemp;

    [Token(Token = "0x6002531")]
    [Address(RVA = "0x2F36F24", Offset = "0x2F36F24", VA = "0x2F36F24")]
    public CommuSkillTempLevelContainer()
    {
    }

    [Token(Token = "0x6002532")]
    [Address(RVA = "0x2F36FA0", Offset = "0x2F36FA0", VA = "0x2F36FA0")]
    public void InitDataWithRuntime()
    {
    }

    [Token(Token = "0x6002533")]
    [Address(RVA = "0x2F37188", Offset = "0x2F37188", VA = "0x2F37188")]
    public int IncreaseAndGetTempLevel(int commuSkillId) => new int();
  }
}
