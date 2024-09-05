// Decompiled with JetBrains decompiler
// Type: StaqData.GuildTitleInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x2002007")]
  public class GuildTitleInfo
  {
    [Token(Token = "0x4008885")]
    [FieldOffset(Offset = "0x10")]
    private ICollection<int> unlockedTitleIds;

    [Token(Token = "0x600BEA5")]
    [Address(RVA = "0x2002920", Offset = "0x2002920", VA = "0x2002920")]
    public void ResetUnlockedTitleIds(IEnumerable<int> titleIds)
    {
    }

    [Token(Token = "0x600BEA6")]
    [Address(RVA = "0x2002978", Offset = "0x2002978", VA = "0x2002978")]
    public void AddUnlockedTitleIds(IEnumerable<int> titleIds)
    {
    }

    [Token(Token = "0x600BEA7")]
    [Address(RVA = "0x2002CD4", Offset = "0x2002CD4", VA = "0x2002CD4")]
    public bool IsUnlocked(int titleId) => new bool();

    [Token(Token = "0x600BEA8")]
    [Address(RVA = "0x2002D80", Offset = "0x2002D80", VA = "0x2002D80")]
    public GuildTitleInfo()
    {
    }
  }
}
