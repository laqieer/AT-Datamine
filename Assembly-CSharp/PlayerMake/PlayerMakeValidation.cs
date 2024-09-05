// Decompiled with JetBrains decompiler
// Type: PlayerMake.PlayerMakeValidation
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace PlayerMake
{
  [Token(Token = "0x20009A3")]
  public class PlayerMakeValidation
  {
    [Token(Token = "0x4002CDA")]
    [FieldOffset(Offset = "0x10")]
    public PlayerMakeValidation.ValidationPlayerMaking OnValidation;

    [Token(Token = "0x60036EA")]
    [Address(RVA = "0x3539304", Offset = "0x3539304", VA = "0x3539304")]
    public void Validation(
      MakingData making,
      Action accept,
      Action<PlayerMakeValidation.InvalidType> deny)
    {
    }

    [Token(Token = "0x60036EB")]
    [Address(RVA = "0x3539728", Offset = "0x3539728", VA = "0x3539728")]
    public PlayerMakeValidation()
    {
    }

    [Token(Token = "0x20009A4")]
    public enum InvalidType
    {
      [Token(Token = "0x4002CDC")] None,
      [Token(Token = "0x4002CDD")] UnExpected,
      [Token(Token = "0x4002CDE")] NgWord,
      [Token(Token = "0x4002CDF")] InvalidAvaterID,
      [Token(Token = "0x4002CE0")] NameEmpty,
    }

    [Token(Token = "0x20009A5")]
    public delegate void ResultReceptor(
      bool result,
      PlayerMakeValidation.InvalidType resultInvalidType);

    [Token(Token = "0x20009A6")]
    public delegate void ValidationPlayerMaking(
      MakingData making,
      PlayerMakeValidation.ResultReceptor receptor);
  }
}
