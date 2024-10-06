// Decompiled with JetBrains decompiler
// Type: IronSourceInitializationAndroid
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
[Token(Token = "0x200004B")]
public class IronSourceInitializationAndroid : AndroidJavaProxy, IUnityInitialization
{
  [Token(Token = "0x1400004F")]
  public event Action OnSdkInitializationCompletedEvent
  {
    [Token(Token = "0x600028E"), Address(RVA = "0x205A104", Offset = "0x205A104", VA = "0x205A104", Slot = "9")] add
    {
    }
    [Token(Token = "0x600028F"), Address(RVA = "0x205A1A0", Offset = "0x205A1A0", VA = "0x205A1A0", Slot = "10")] remove
    {
    }
  }

  [Token(Token = "0x6000290")]
  [Address(RVA = "0x204E510", Offset = "0x204E510", VA = "0x204E510")]
  public IronSourceInitializationAndroid()
  {
  }

  [Token(Token = "0x6000291")]
  [Address(RVA = "0x205A23C", Offset = "0x205A23C", VA = "0x205A23C")]
  private void onSdkInitializationCompleted()
  {
  }
}
