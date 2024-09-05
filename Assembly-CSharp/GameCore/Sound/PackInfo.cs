// Decompiled with JetBrains decompiler
// Type: GameCore.Sound.PackInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace GameCore.Sound
{
  [Token(Token = "0x2000C41")]
  public class PackInfo
  {
    [Token(Token = "0x400378A")]
    [FieldOffset(Offset = "0x10")]
    public uint packID;
    [Token(Token = "0x400378B")]
    [FieldOffset(Offset = "0x14")]
    public int referenceCounter;
    [Token(Token = "0x400378C")]
    [FieldOffset(Offset = "0x18")]
    public bool isReside;

    [Token(Token = "0x600466F")]
    [Address(RVA = "0x3516C84", Offset = "0x3516C84", VA = "0x3516C84")]
    public PackInfo()
    {
    }
  }
}
