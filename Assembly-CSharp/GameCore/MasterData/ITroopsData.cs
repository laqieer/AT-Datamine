// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ITroopsData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20013EC")]
  public interface ITroopsData
  {
    [Token(Token = "0x170010CD")]
    int Troops { [Token(Token = "0x6006FC7")] get; }

    [Token(Token = "0x170010CE")]
    bool IsInitial { [Token(Token = "0x6006FC8")] get; }

    [Token(Token = "0x170010CF")]
    bool IsQuick { [Token(Token = "0x6006FC9")] get; }
  }
}
