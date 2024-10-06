// Decompiled with JetBrains decompiler
// Type: StaqData.HomeCharacterSettings
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x2002009")]
  public class HomeCharacterSettings
  {
    [Token(Token = "0x400888B")]
    [FieldOffset(Offset = "0x10")]
    public int StyleIdMain;
    [Token(Token = "0x400888C")]
    [FieldOffset(Offset = "0x14")]
    public int StyleIdSub1;
    [Token(Token = "0x400888D")]
    [FieldOffset(Offset = "0x18")]
    public int StyleIdSub2;
    [Token(Token = "0x400888E")]
    [FieldOffset(Offset = "0x1C")]
    public int StyleIdSub3;

    [Token(Token = "0x600BEBC")]
    [Address(RVA = "0x2002F58", Offset = "0x2002F58", VA = "0x2002F58")]
    public void Setup(PlayerHomeSettingType setting)
    {
    }

    [Token(Token = "0x600BEBD")]
    [Address(RVA = "0x2002F74", Offset = "0x2002F74", VA = "0x2002F74")]
    public HomeCharacterSettings()
    {
    }
  }
}
