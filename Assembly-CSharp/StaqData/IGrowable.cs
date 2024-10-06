// Decompiled with JetBrains decompiler
// Type: StaqData.IGrowable
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x200200A")]
  public interface IGrowable
  {
    [Token(Token = "0x17002789")]
    int Exp { [Token(Token = "0x600BEBE")] get; }

    [Token(Token = "0x1700278A")]
    int Level { [Token(Token = "0x600BEBF")] get; }

    [Token(Token = "0x1700278B")]
    int NextLevelExp { [Token(Token = "0x600BEC0")] get; }

    [Token(Token = "0x1700278C")]
    float NextLevelExpRate { [Token(Token = "0x600BEC1")] get; }

    [Token(Token = "0x600BEC2")]
    (int, int) GetPredictExperience(int value);
  }
}
