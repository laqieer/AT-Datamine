// Decompiled with JetBrains decompiler
// Type: FreeMap.Parameter.UIParam.FreeMapUICircleParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace FreeMap.Parameter.UIParam
{
  [Token(Token = "0x2001876")]
  public class FreeMapUICircleParam
  {
    [Token(Token = "0x17001616")]
    public int Range
    {
      [Token(Token = "0x6008AB1"), Address(RVA = "0x4523084", Offset = "0x4523084", VA = "0x4523084")] get
      {
        return new int();
      }
      [Token(Token = "0x6008AB2"), Address(RVA = "0x452308C", Offset = "0x452308C", VA = "0x452308C")] private set
      {
      }
    }

    [Token(Token = "0x17001617")]
    public string AssetName
    {
      [Token(Token = "0x6008AB3"), Address(RVA = "0x4523094", Offset = "0x4523094", VA = "0x4523094")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6008AB4"), Address(RVA = "0x452309C", Offset = "0x452309C", VA = "0x452309C")] private set
      {
      }
    }

    [Token(Token = "0x17001618")]
    public Vector3 OffsetPos
    {
      [Token(Token = "0x6008AB5"), Address(RVA = "0x45230A4", Offset = "0x45230A4", VA = "0x45230A4")] get
      {
        return new Vector3();
      }
    }

    [Token(Token = "0x6008AB6")]
    [Address(RVA = "0x45230B0", Offset = "0x45230B0", VA = "0x45230B0")]
    public FreeMapUICircleParam(int range, int effectID)
    {
    }

    [Token(Token = "0x6008AB7")]
    [Address(RVA = "0x45231E0", Offset = "0x45231E0", VA = "0x45231E0")]
    public FreeMapUICircleParam(int range, int effectID, Vector3 offsetPos)
    {
    }
  }
}
