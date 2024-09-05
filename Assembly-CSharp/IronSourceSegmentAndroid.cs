// Decompiled with JetBrains decompiler
// Type: IronSourceSegmentAndroid
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000073")]
public class IronSourceSegmentAndroid : AndroidJavaProxy, IUnitySegment
{
  [Token(Token = "0x14000095")]
  public event Action<string> OnSegmentRecieved
  {
    [Token(Token = "0x60003ED"), Address(RVA = "0x44AD1A8", Offset = "0x44AD1A8", VA = "0x44AD1A8", Slot = "9")] add
    {
    }
    [Token(Token = "0x60003EE"), Address(RVA = "0x44AD258", Offset = "0x44AD258", VA = "0x44AD258", Slot = "10")] remove
    {
    }
  }

  [Token(Token = "0x60003EF")]
  [Address(RVA = "0x44AD308", Offset = "0x44AD308", VA = "0x44AD308")]
  public IronSourceSegmentAndroid()
  {
  }

  [Token(Token = "0x60003F0")]
  [Address(RVA = "0x44AD794", Offset = "0x44AD794", VA = "0x44AD794")]
  public void onSegmentRecieved(string segmentName)
  {
  }
}
