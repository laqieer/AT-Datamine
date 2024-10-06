// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.Builder.IFreeMapInstanceUIBuilder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Instance;
using FreeMap.Loader;
using FreeMap.UI.Element;
using FreeMap.UI.Entity;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace FreeMap.UI.Builder
{
  [Token(Token = "0x2001779")]
  public interface IFreeMapInstanceUIBuilder
  {
    [Token(Token = "0x600850A")]
    void InitializeBuilder(IFreeMapResourceLoader loader);

    [Token(Token = "0x600850B")]
    FreeMapUIBase Build(
      Transform parent,
      FreeMapInstance target,
      FreeMapCommonElement commonElement,
      FreeMapIconEventControlElement iconEventElement);

    [Token(Token = "0x600850C")]
    FreeMapUIBase AddBuild(
      Transform uiParent,
      FreeMapInstance target,
      FreeMapCommonElement commonElement,
      FreeMapUITransformHolder holder,
      FreeMapIconEventControlElement iconEventElement);

    [Token(Token = "0x600850D")]
    void FinalizeBuilder();
  }
}
