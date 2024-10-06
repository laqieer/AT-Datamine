// Decompiled with JetBrains decompiler
// Type: GameCore.DLC.DLCProgress
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace GameCore.DLC
{
  [Token(Token = "0x20014D2")]
  [Serializable]
  public class DLCProgress
  {
    [Token(Token = "0x4005FCE")]
    [FieldOffset(Offset = "0x10")]
    private readonly string PROGRESS_TEXT_ACCURACY;

    [Token(Token = "0x1700120F")]
    public int DownloadTargetCnt
    {
      [Token(Token = "0x600755F"), Address(RVA = "0x43F9580", Offset = "0x43F9580", VA = "0x43F9580")] get
      {
        return new int();
      }
      [Token(Token = "0x6007560"), Address(RVA = "0x43F9588", Offset = "0x43F9588", VA = "0x43F9588")] set
      {
      }
    }

    [Token(Token = "0x17001210")]
    public int DownloadCompleteCnt
    {
      [Token(Token = "0x6007561"), Address(RVA = "0x43F9590", Offset = "0x43F9590", VA = "0x43F9590")] get
      {
        return new int();
      }
      [Token(Token = "0x6007562"), Address(RVA = "0x43F9598", Offset = "0x43F9598", VA = "0x43F9598")] set
      {
      }
    }

    [Token(Token = "0x17001211")]
    public long DownloadBytes
    {
      [Token(Token = "0x6007563"), Address(RVA = "0x43F95A0", Offset = "0x43F95A0", VA = "0x43F95A0")] get
      {
        return new long();
      }
      [Token(Token = "0x6007564"), Address(RVA = "0x43F95A8", Offset = "0x43F95A8", VA = "0x43F95A8")] set
      {
      }
    }

    [Token(Token = "0x17001212")]
    public long DownloadedBytes
    {
      [Token(Token = "0x6007565"), Address(RVA = "0x43F95B0", Offset = "0x43F95B0", VA = "0x43F95B0")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x17001213")]
    public long DownloadedFileBytes
    {
      [Token(Token = "0x6007566"), Address(RVA = "0x43F95BC", Offset = "0x43F95BC", VA = "0x43F95BC")] get
      {
        return new long();
      }
      [Token(Token = "0x6007567"), Address(RVA = "0x43F95C4", Offset = "0x43F95C4", VA = "0x43F95C4")] set
      {
      }
    }

    [Token(Token = "0x17001214")]
    public long DownloadingFileBytes
    {
      [Token(Token = "0x6007568"), Address(RVA = "0x43F95CC", Offset = "0x43F95CC", VA = "0x43F95CC")] get
      {
        return new long();
      }
      [Token(Token = "0x6007569"), Address(RVA = "0x43F95D4", Offset = "0x43F95D4", VA = "0x43F95D4")] set
      {
      }
    }

    [Token(Token = "0x17001215")]
    public bool HideDownloadingBytesText
    {
      [Token(Token = "0x600756A"), Address(RVA = "0x43F95DC", Offset = "0x43F95DC", VA = "0x43F95DC")] get
      {
        return new bool();
      }
      [Token(Token = "0x600756B"), Address(RVA = "0x43F95E4", Offset = "0x43F95E4", VA = "0x43F95E4")] set
      {
      }
    }

    [Token(Token = "0x600756C")]
    [Address(RVA = "0x43F1B2C", Offset = "0x43F1B2C", VA = "0x43F1B2C")]
    public void Init(int targetCnt, long downloadBytes, bool hide = false)
    {
    }

    [Token(Token = "0x600756D")]
    [Address(RVA = "0x43F95F0", Offset = "0x43F95F0", VA = "0x43F95F0")]
    public float GetProgressALL() => new float();

    [Token(Token = "0x600756E")]
    [Address(RVA = "0x43F961C", Offset = "0x43F961C", VA = "0x43F961C")]
    public string GetProgressALLToString() => (string) null;

    [Token(Token = "0x600756F")]
    [Address(RVA = "0x43F2D24", Offset = "0x43F2D24", VA = "0x43F2D24")]
    public DLCProgress()
    {
    }
  }
}
