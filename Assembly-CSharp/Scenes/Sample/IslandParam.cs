// Decompiled with JetBrains decompiler
// Type: Scenes.Sample.IslandParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Scene;
using Il2CppDummyDll;

#nullable disable
namespace Scenes.Sample
{
  [Token(Token = "0x20028B2")]
  public class IslandParam : ChangeSceneParameter
  {
    [Token(Token = "0x400ADBB")]
    [FieldOffset(Offset = "0x18")]
    private string _Name;

    [Token(Token = "0x1700383D")]
    public string Name
    {
      [Token(Token = "0x6010035"), Address(RVA = "0x41666BC", Offset = "0x41666BC", VA = "0x41666BC")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6010036"), Address(RVA = "0x41666C4", Offset = "0x41666C4", VA = "0x41666C4")] set
      {
      }
    }

    [Token(Token = "0x6010037")]
    [Address(RVA = "0x41666CC", Offset = "0x41666CC", VA = "0x41666CC")]
    public IslandParam()
    {
    }
  }
}
