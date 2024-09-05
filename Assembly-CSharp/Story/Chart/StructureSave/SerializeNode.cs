// Decompiled with JetBrains decompiler
// Type: Story.Chart.StructureSave.SerializeNode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Story.Chart.StructureSave
{
  [Token(Token = "0x200071A")]
  [Serializable]
  public class SerializeNode
  {
    [Token(Token = "0x40020FA")]
    [FieldOffset(Offset = "0x10")]
    public int sequenceID;
    [Token(Token = "0x40020FB")]
    [FieldOffset(Offset = "0x14")]
    public int Depth;
    [Token(Token = "0x40020FC")]
    [FieldOffset(Offset = "0x18")]
    public int Index;
    [Token(Token = "0x40020FD")]
    [FieldOffset(Offset = "0x1C")]
    public int Height;

    [Token(Token = "0x60027FD")]
    [Address(RVA = "0x3671CE0", Offset = "0x3671CE0", VA = "0x3671CE0")]
    public SerializeNode()
    {
    }
  }
}
