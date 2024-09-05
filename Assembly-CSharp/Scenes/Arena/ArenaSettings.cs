// Decompiled with JetBrains decompiler
// Type: Scenes.Arena.ArenaSettings
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Scenes.Arena
{
  [Token(Token = "0x2003132")]
  [Serializable]
  public class ArenaSettings
  {
    [Token(Token = "0x601332C")]
    [Address(RVA = "0x45E69A4", Offset = "0x45E69A4", VA = "0x45E69A4")]
    public ArenaSettings()
    {
    }

    [Token(Token = "0x2003133")]
    public enum Type
    {
      [Token(Token = "0x400D17E")] GridView,
      [Token(Token = "0x400D17F")] FastMode,
      [Token(Token = "0x400D180")] DuelSkip,
    }
  }
}
