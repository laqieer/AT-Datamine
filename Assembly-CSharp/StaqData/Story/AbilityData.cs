// Decompiled with JetBrains decompiler
// Type: StaqData.Story.AbilityData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace StaqData.Story
{
  [Token(Token = "0x200215E")]
  public class AbilityData
  {
    [Token(Token = "0x4008D65")]
    [FieldOffset(Offset = "0x10")]
    private StoryAbilityData master;

    [Token(Token = "0x17002CD7")]
    public int ID
    {
      [Token(Token = "0x600CC8F"), Address(RVA = "0x1BB019C", Offset = "0x1BB019C", VA = "0x1BB019C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002CD8")]
    public string Name
    {
      [Token(Token = "0x600CC90"), Address(RVA = "0x1BB01B8", Offset = "0x1BB01B8", VA = "0x1BB01B8")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600CC91")]
    [Address(RVA = "0x1BB0174", Offset = "0x1BB0174", VA = "0x1BB0174")]
    public AbilityData(StoryAbilityData master)
    {
    }
  }
}
