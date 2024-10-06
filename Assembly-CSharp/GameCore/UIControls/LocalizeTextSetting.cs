// Decompiled with JetBrains decompiler
// Type: GameCore.UIControls.LocalizeTextSetting
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace GameCore.UIControls
{
  [Token(Token = "0x2000C03")]
  public class LocalizeTextSetting
  {
    [Token(Token = "0x60044EB")]
    [Address(RVA = "0x364D454", Offset = "0x364D454", VA = "0x364D454")]
    public LocalizeTextSetting()
    {
    }

    [Token(Token = "0x2000C04")]
    public enum ComponentType
    {
      [Token(Token = "0x4003689")] None,
      [Token(Token = "0x400368A")] Text,
      [Token(Token = "0x400368B")] RubyTextMeshPro,
      [Token(Token = "0x400368C")] RubyTextMeshProUGUI,
      [Token(Token = "0x400368D")] TextMeshPro,
      [Token(Token = "0x400368E")] TextMeshProUGUI,
      [Token(Token = "0x400368F")] End,
    }
  }
}
