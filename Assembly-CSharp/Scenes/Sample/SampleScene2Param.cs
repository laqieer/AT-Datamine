// Decompiled with JetBrains decompiler
// Type: Scenes.Sample.SampleScene2Param
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Scene;
using Il2CppDummyDll;

#nullable disable
namespace Scenes.Sample
{
  [Token(Token = "0x20028B7")]
  public class SampleScene2Param : ChangeSceneParameter
  {
    [Token(Token = "0x400ADC1")]
    [FieldOffset(Offset = "0x18")]
    private string _Name;

    [Token(Token = "0x17003842")]
    public string Name
    {
      [Token(Token = "0x6010050"), Address(RVA = "0x4166948", Offset = "0x4166948", VA = "0x4166948")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6010051"), Address(RVA = "0x4166950", Offset = "0x4166950", VA = "0x4166950")] set
      {
      }
    }

    [Token(Token = "0x6010052")]
    [Address(RVA = "0x4166958", Offset = "0x4166958", VA = "0x4166958")]
    public SampleScene2Param()
    {
    }
  }
}
