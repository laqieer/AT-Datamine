// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.Builder.FreeMapInstanceUIBuilder`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Instance;
using FreeMap.Instance.Element;
using FreeMap.Loader;
using FreeMap.UI.Element;
using FreeMap.UI.Entity;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace FreeMap.UI.Builder
{
  [Token(Token = "0x2001775")]
  public abstract class FreeMapInstanceUIBuilder<T> : IFreeMapInstanceUIBuilder where T : FreeMapUIBase, new()
  {
    [Token(Token = "0x40067F9")]
    private const string iconParent3DName = "parent3D";
    [Token(Token = "0x40067FA")]
    [FieldOffset(Offset = "0x0")]
    protected T uiInstance;

    [Token(Token = "0x170014F7")]
    protected virtual Vector3 OffsetPos
    {
      [Token(Token = "0x60084E1")] get => new Vector3();
    }

    [Token(Token = "0x60084E2")]
    public void InitializeBuilder(IFreeMapResourceLoader loader)
    {
    }

    [Token(Token = "0x60084E3")]
    protected virtual void InitializeInternal(IFreeMapResourceLoader loader)
    {
    }

    [Token(Token = "0x60084E4")]
    public FreeMapUIBase Build(
      Transform uiParent,
      FreeMapInstance target,
      FreeMapCommonElement commonElement,
      FreeMapIconEventControlElement iconEventElement)
    {
      return (FreeMapUIBase) null;
    }

    [Token(Token = "0x60084E5")]
    protected virtual void BuildInternal(
      Transform uiParent,
      FreeMapInstance target,
      FreeMapUITransformHolder holder,
      FreeMapCommonElement commonElement,
      FreeMapIconEventControlElement iconEventElement)
    {
    }

    [Token(Token = "0x60084E6")]
    public FreeMapUIBase AddBuild(
      Transform uiParent,
      FreeMapInstance target,
      FreeMapCommonElement commonElement,
      FreeMapUITransformHolder holder,
      FreeMapIconEventControlElement iconEventElement)
    {
      return (FreeMapUIBase) null;
    }

    [Token(Token = "0x60084E7")]
    protected virtual void AddBuildInternal(
      Transform uiParent,
      FreeMapInstance target,
      FreeMapUITransformHolder holder,
      FreeMapCommonElement commonElement,
      FreeMapIconEventControlElement iconEventElement)
    {
    }

    [Token(Token = "0x60084E8")]
    public void FinalizeBuilder()
    {
    }

    [Token(Token = "0x60084E9")]
    protected virtual void FinalizeInternal()
    {
    }

    [Token(Token = "0x60084EA")]
    protected virtual FreeMapMovePosition GetMovePoint(FreeMapInstance target)
    {
      return (FreeMapMovePosition) null;
    }

    [Token(Token = "0x60084EB")]
    protected FreeMapUITransformHolder CreateUITransformHolder(
      FreeMapInstance instance,
      Vector3 iconOffset,
      FreeMapMovePosition movePoint)
    {
      return (FreeMapUITransformHolder) null;
    }

    [Token(Token = "0x60084EC")]
    protected FreeMapInstanceUIBuilder()
    {
    }
  }
}
