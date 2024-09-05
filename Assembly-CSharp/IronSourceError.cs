// Decompiled with JetBrains decompiler
// Type: IronSourceError
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
[Token(Token = "0x2000023")]
public class IronSourceError
{
  [Token(Token = "0x4000099")]
  [FieldOffset(Offset = "0x10")]
  private string description;
  [Token(Token = "0x400009A")]
  [FieldOffset(Offset = "0x18")]
  private int code;

  [Token(Token = "0x6000125")]
  [Address(RVA = "0x2049A58", Offset = "0x2049A58", VA = "0x2049A58")]
  public int getErrorCode() => new int();

  [Token(Token = "0x6000126")]
  [Address(RVA = "0x2049A60", Offset = "0x2049A60", VA = "0x2049A60")]
  public string getDescription() => (string) null;

  [Token(Token = "0x6000127")]
  [Address(RVA = "0x2049A68", Offset = "0x2049A68", VA = "0x2049A68")]
  public int getCode() => new int();

  [Token(Token = "0x6000128")]
  [Address(RVA = "0x204794C", Offset = "0x204794C", VA = "0x204794C")]
  public IronSourceError(int errorCode, string errorDescription)
  {
  }

  [Token(Token = "0x6000129")]
  [Address(RVA = "0x2049A70", Offset = "0x2049A70", VA = "0x2049A70", Slot = "3")]
  public override string ToString() => (string) null;
}
