// Decompiled with JetBrains decompiler
// Type: StaqData.GuildEmblemInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x2002006")]
  public class GuildEmblemInfo
  {
    [Token(Token = "0x4008884")]
    [FieldOffset(Offset = "0x10")]
    private IReadOnlyCollection<int> emblemIds;

    [Token(Token = "0x600BEA2")]
    [Address(RVA = "0x20027D4", Offset = "0x20027D4", VA = "0x20027D4")]
    public void ResetEmblemIds(IEnumerable<int> emblemIds)
    {
    }

    [Token(Token = "0x600BEA3")]
    [Address(RVA = "0x200288C", Offset = "0x200288C", VA = "0x200288C")]
    public IEnumerable<int> GetEmblemIds() => (IEnumerable<int>) null;

    [Token(Token = "0x600BEA4")]
    [Address(RVA = "0x2002894", Offset = "0x2002894", VA = "0x2002894")]
    public GuildEmblemInfo()
    {
    }
  }
}
