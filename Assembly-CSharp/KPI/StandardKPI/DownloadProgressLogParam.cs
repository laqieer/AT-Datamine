// Decompiled with JetBrains decompiler
// Type: KPI.StandardKPI.DownloadProgressLogParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace KPI.StandardKPI
{
  [Token(Token = "0x2000A68")]
  [Serializable]
  public class DownloadProgressLogParam : StandardKPILogParam<DownloadProgressLogParam.Body>
  {
    [Token(Token = "0x17000870")]
    public override string LogFormatType
    {
      [Token(Token = "0x6003B3A"), Address(RVA = "0x331C568", Offset = "0x331C568", VA = "0x331C568", Slot = "5")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6003B3B")]
    [Address(RVA = "0x331C5A8", Offset = "0x331C5A8", VA = "0x331C5A8")]
    public DownloadProgressLogParam()
    {
    }

    [Token(Token = "0x2000A69")]
    [Serializable]
    public class Body : IStandardKPILogBodyParam
    {
      [Token(Token = "0x400304D")]
      [FieldOffset(Offset = "0x10")]
      public string download_type;
      [Token(Token = "0x400304E")]
      [FieldOffset(Offset = "0x18")]
      public string download_id;
      [Token(Token = "0x400304F")]
      [FieldOffset(Offset = "0x20")]
      public long progress;
      [Token(Token = "0x4003050")]
      [FieldOffset(Offset = "0x28")]
      public long target;
      [Token(Token = "0x4003051")]
      [FieldOffset(Offset = "0x30")]
      public int progress_percent;

      [Token(Token = "0x6003B3C")]
      [Address(RVA = "0x331C5F0", Offset = "0x331C5F0", VA = "0x331C5F0")]
      public Body()
      {
      }
    }
  }
}
