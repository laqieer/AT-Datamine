// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Battle.IParameterDifference`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Scenes.OutGame.Battle
{
  [Token(Token = "0x2003741")]
  public interface IParameterDifference<T>
  {
    [Token(Token = "0x170047F3")]
    T Before { [Token(Token = "0x6015C32")] get; }

    [Token(Token = "0x170047F4")]
    T After { [Token(Token = "0x6015C33")] get; }

    [Token(Token = "0x6015C34")]
    bool HasDiff(out T diff);
  }
}
