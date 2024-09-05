// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.IMasterDataReader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20013E2")]
  public interface IMasterDataReader
  {
    [Token(Token = "0x6006F8B")]
    int PeekChar();

    [Token(Token = "0x6006F8C")]
    uint ReadUInt32();

    [Token(Token = "0x6006F8D")]
    int ReadInt32();

    [Token(Token = "0x6006F8E")]
    string ReadStringEx();

    [Token(Token = "0x6006F8F")]
    DateTime ReadDateTime();

    [Token(Token = "0x6006F90")]
    float ReadSingle();

    [Token(Token = "0x6006F91")]
    double ReadDouble();

    [Token(Token = "0x6006F92")]
    bool ReadBoolean();

    [Token(Token = "0x6006F93")]
    void ReadIntArray(int size, ref int[] dst);
  }
}
