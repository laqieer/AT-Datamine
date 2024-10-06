// Decompiled with JetBrains decompiler
// Type: StaqData.IOptionEffect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x2002024")]
  public interface IOptionEffect
  {
    [Token(Token = "0x17002815")]
    string Name { [Token(Token = "0x600C01C")] get; }

    [Token(Token = "0x17002816")]
    float EffectValue { [Token(Token = "0x600C01D")] get; }

    [Token(Token = "0x17002817")]
    int Grade { [Token(Token = "0x600C01E")] get; }

    [Token(Token = "0x17002818")]
    int IconSpriteId { [Token(Token = "0x600C01F")] get; }
  }
}
