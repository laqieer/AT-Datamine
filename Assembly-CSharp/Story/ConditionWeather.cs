// Decompiled with JetBrains decompiler
// Type: Story.ConditionWeather
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace Story
{
  [Token(Token = "0x2000534")]
  public struct ConditionWeather
  {
    [Token(Token = "0x4001B69")]
    [FieldOffset(Offset = "0x0")]
    public int ID;

    [Token(Token = "0x6001E2E")]
    [Address(RVA = "0x29FC0FC", Offset = "0x29FC0FC", VA = "0x29FC0FC")]
    public ConditionWeather(int id)
    {
    }

    [Token(Token = "0x6001E2F")]
    [Address(RVA = "0x29FC104", Offset = "0x29FC104", VA = "0x29FC104")]
    public bool IsMatch(StoryWeatherTypeEnum weather) => new bool();

    [Token(Token = "0x17000413")]
    public bool IsContainSunny
    {
      [Token(Token = "0x6001E30"), Address(RVA = "0x29FC12C", Offset = "0x29FC12C", VA = "0x29FC12C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000414")]
    public bool IsContainRainy
    {
      [Token(Token = "0x6001E31"), Address(RVA = "0x29FC138", Offset = "0x29FC138", VA = "0x29FC138")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000415")]
    public bool IsContainSnowy
    {
      [Token(Token = "0x6001E32"), Address(RVA = "0x29FC144", Offset = "0x29FC144", VA = "0x29FC144")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000416")]
    public bool IsContainCloudy
    {
      [Token(Token = "0x6001E33"), Address(RVA = "0x29FC150", Offset = "0x29FC150", VA = "0x29FC150")] get
      {
        return new bool();
      }
    }
  }
}
