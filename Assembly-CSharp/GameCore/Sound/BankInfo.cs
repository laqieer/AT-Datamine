// Decompiled with JetBrains decompiler
// Type: GameCore.Sound.BankInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace GameCore.Sound
{
  [Token(Token = "0x2000C40")]
  public class BankInfo
  {
    [Token(Token = "0x4003786")]
    [FieldOffset(Offset = "0x10")]
    public uint bankID;
    [Token(Token = "0x4003787")]
    [FieldOffset(Offset = "0x18")]
    public IntPtr ptr;
    [Token(Token = "0x4003788")]
    [FieldOffset(Offset = "0x20")]
    public int referenceCounter;
    [Token(Token = "0x4003789")]
    [FieldOffset(Offset = "0x24")]
    public bool isReside;

    [Token(Token = "0x600466E")]
    [Address(RVA = "0x3516C7C", Offset = "0x3516C7C", VA = "0x3516C7C")]
    public BankInfo()
    {
    }
  }
}
