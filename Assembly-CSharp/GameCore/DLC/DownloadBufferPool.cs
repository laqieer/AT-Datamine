// Decompiled with JetBrains decompiler
// Type: GameCore.DLC.DownloadBufferPool
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace GameCore.DLC
{
  [Token(Token = "0x20014B8")]
  public class DownloadBufferPool
  {
    [Token(Token = "0x4005F22")]
    public const int DOWNLOAD_BUFFER_SIZE = 65536;
    [Token(Token = "0x4005F23")]
    public const int MAX_CONNECTION = 6;
    [Token(Token = "0x4005F24")]
    [FieldOffset(Offset = "0x10")]
    private List<byte[]> buffers;
    [Token(Token = "0x4005F25")]
    [FieldOffset(Offset = "0x18")]
    private List<int> freeList;

    [Token(Token = "0x60074A7")]
    [Address(RVA = "0x43F138C", Offset = "0x43F138C", VA = "0x43F138C")]
    public DownloadBufferPool()
    {
    }

    [Token(Token = "0x60074A8")]
    [Address(RVA = "0x43F15C4", Offset = "0x43F15C4", VA = "0x43F15C4")]
    public byte[] Get(int index) => (byte[]) null;

    [Token(Token = "0x60074A9")]
    [Address(RVA = "0x43F161C", Offset = "0x43F161C", VA = "0x43F161C")]
    public int Alloc() => new int();

    [Token(Token = "0x60074AA")]
    [Address(RVA = "0x43F16C8", Offset = "0x43F16C8", VA = "0x43F16C8")]
    public void Free(int index)
    {
    }
  }
}
