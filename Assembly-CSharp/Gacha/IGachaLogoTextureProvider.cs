// Decompiled with JetBrains decompiler
// Type: Gacha.IGachaLogoTextureProvider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Gacha
{
  [Token(Token = "0x2001517")]
  internal interface IGachaLogoTextureProvider
  {
    [Token(Token = "0x6007765")]
    void FindLogoTextureResource(int gachaId, Action<BGTextureResource> onFound);
  }
}
