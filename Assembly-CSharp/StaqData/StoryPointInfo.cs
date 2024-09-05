// Decompiled with JetBrains decompiler
// Type: StaqData.StoryPointInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using System.Collections.Generic;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x20020DE")]
  public class StoryPointInfo
  {
    [Token(Token = "0x4008B4D")]
    [FieldOffset(Offset = "0x10")]
    private Dictionary<int, int> StoryPointData;

    [Token(Token = "0x600C71F")]
    [Address(RVA = "0x1CDAB08", Offset = "0x1CDAB08", VA = "0x1CDAB08")]
    public StoryPointInfo()
    {
    }

    [Token(Token = "0x600C720")]
    [Address(RVA = "0x1CDC638", Offset = "0x1CDC638", VA = "0x1CDC638")]
    public int Get(int storypointID) => new int();

    [Token(Token = "0x600C721")]
    [Address(RVA = "0x1CDB410", Offset = "0x1CDB410", VA = "0x1CDB410")]
    public void Apply(IEnumerable<PlayerStoryPointType> storyPointType)
    {
    }

    [Token(Token = "0x600C722")]
    [Address(RVA = "0x1CD7180", Offset = "0x1CD7180", VA = "0x1CD7180")]
    public void ResetOnEnding()
    {
    }
  }
}
