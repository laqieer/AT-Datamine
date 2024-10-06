// Decompiled with JetBrains decompiler
// Type: IUnityImpressionData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
[Token(Token = "0x2000077")]
public interface IUnityImpressionData
{
  [Token(Token = "0x1400009C")]
  event Action<IronSourceImpressionData> OnImpressionDataReady;

  [Token(Token = "0x1400009D")]
  event Action<IronSourceImpressionData> OnImpressionSuccess;
}
