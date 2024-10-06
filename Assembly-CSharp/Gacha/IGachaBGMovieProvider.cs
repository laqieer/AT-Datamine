// Decompiled with JetBrains decompiler
// Type: Gacha.IGachaBGMovieProvider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Gacha
{
  [Token(Token = "0x2001519")]
  internal interface IGachaBGMovieProvider
  {
    [Token(Token = "0x6007768")]
    void FindBGMovieResource(string url, Action<BGMovieResource> onFound);
  }
}
