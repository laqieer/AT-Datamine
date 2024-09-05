// Decompiled with JetBrains decompiler
// Type: IronSourceImpressionDataAndroid
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000049")]
public class IronSourceImpressionDataAndroid : AndroidJavaProxy, IUnityImpressionData
{
  [Token(Token = "0x1400004D")]
  public event Action<IronSourceImpressionData> OnImpressionSuccess
  {
    [Token(Token = "0x6000283"), Address(RVA = "0x2059CB8", Offset = "0x2059CB8", VA = "0x2059CB8", Slot = "11")] add
    {
    }
    [Token(Token = "0x6000284"), Address(RVA = "0x2059D68", Offset = "0x2059D68", VA = "0x2059D68", Slot = "12")] remove
    {
    }
  }

  [Token(Token = "0x1400004E")]
  public event Action<IronSourceImpressionData> OnImpressionDataReady
  {
    [Token(Token = "0x6000285"), Address(RVA = "0x2059E18", Offset = "0x2059E18", VA = "0x2059E18", Slot = "9")] add
    {
    }
    [Token(Token = "0x6000286"), Address(RVA = "0x2059EC8", Offset = "0x2059EC8", VA = "0x2059EC8", Slot = "10")] remove
    {
    }
  }

  [Token(Token = "0x6000287")]
  [Address(RVA = "0x2051EB4", Offset = "0x2051EB4", VA = "0x2051EB4")]
  public IronSourceImpressionDataAndroid()
  {
  }

  [Token(Token = "0x6000288")]
  [Address(RVA = "0x2059F78", Offset = "0x2059F78", VA = "0x2059F78")]
  public void onImpressionSuccess(string data)
  {
  }

  [Token(Token = "0x6000289")]
  [Address(RVA = "0x205A004", Offset = "0x205A004", VA = "0x205A004")]
  public void onImpressionDataReady(string data)
  {
  }
}
