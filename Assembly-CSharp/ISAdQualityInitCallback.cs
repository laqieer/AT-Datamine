// Decompiled with JetBrains decompiler
// Type: ISAdQualityInitCallback
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
[Token(Token = "0x200008C")]
public interface ISAdQualityInitCallback
{
  [Token(Token = "0x60004F2")]
  void adQualitySdkInitSuccess();

  [Token(Token = "0x60004F3")]
  void adQualitySdkInitFailed(ISAdQualityInitError adQualityInitError, string errorMessage);
}
