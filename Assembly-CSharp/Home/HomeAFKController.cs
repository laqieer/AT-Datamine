// Decompiled with JetBrains decompiler
// Type: Home.HomeAFKController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Home
{
  [Token(Token = "0x2000B1C")]
  public class HomeAFKController
  {
    [Token(Token = "0x40032A0")]
    private const float Threshold = 15f;
    [Token(Token = "0x40032A1")]
    [FieldOffset(Offset = "0x10")]
    private float timer;

    [Token(Token = "0x6003F36")]
    [Address(RVA = "0x2C1AC30", Offset = "0x2C1AC30", VA = "0x2C1AC30")]
    public HomeAFKController()
    {
    }

    [Token(Token = "0x6003F37")]
    [Address(RVA = "0x2C1AC38", Offset = "0x2C1AC38", VA = "0x2C1AC38")]
    public void Update()
    {
    }

    [Token(Token = "0x6003F38")]
    [Address(RVA = "0x2C1AC64", Offset = "0x2C1AC64", VA = "0x2C1AC64")]
    public void Reset()
    {
    }

    [Token(Token = "0x6003F39")]
    [Address(RVA = "0x2C1AC6C", Offset = "0x2C1AC6C", VA = "0x2C1AC6C")]
    public bool CanSpeakAfkVoice() => new bool();
  }
}
