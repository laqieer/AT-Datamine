// Decompiled with JetBrains decompiler
// Type: Scenes.Sample.SampleSceneParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Scene;
using Il2CppDummyDll;

#nullable disable
namespace Scenes.Sample
{
  [Token(Token = "0x20028BA")]
  public class SampleSceneParam : ChangeSceneParameter
  {
    [Token(Token = "0x400ADC5")]
    [FieldOffset(Offset = "0x18")]
    private string _Name;

    [Token(Token = "0x17003845")]
    public string Name
    {
      [Token(Token = "0x6010060"), Address(RVA = "0x4166AA0", Offset = "0x4166AA0", VA = "0x4166AA0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6010061"), Address(RVA = "0x4166AA8", Offset = "0x4166AA8", VA = "0x4166AA8")] set
      {
      }
    }

    [Token(Token = "0x6010062")]
    [Address(RVA = "0x4166AB0", Offset = "0x4166AB0", VA = "0x4166AB0")]
    public SampleSceneParam()
    {
    }
  }
}
