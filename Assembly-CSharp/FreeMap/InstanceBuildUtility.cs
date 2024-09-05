// Decompiled with JetBrains decompiler
// Type: FreeMap.InstanceBuildUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Data;
using FreeMap.Instance;
using FreeMap.Loader;
using FreeMap.Parameter.UIParam;
using FreeMap.UI.Data;
using FreeMap.UI.Element;
using FreeMap.UI.Entity;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace FreeMap
{
  [Token(Token = "0x20015EE")]
  public static class InstanceBuildUtility
  {
    [Token(Token = "0x4006411")]
    [FieldOffset(Offset = "0x0")]
    public static readonly ActionIconUIAssetData DefaultActionIconAssetData;
    [Token(Token = "0x4006412")]
    [FieldOffset(Offset = "0x8")]
    public static readonly TransitionUIAssetData DefaultTransitionAssetData;
    [Token(Token = "0x4006413")]
    [FieldOffset(Offset = "0x10")]
    public static readonly ActionIconUIAssetData MapActionIconAssetData;
    [Token(Token = "0x4006414")]
    [FieldOffset(Offset = "0x18")]
    public static readonly ActionIconUIAssetData MapCharaActionIconAssetData;

    [Token(Token = "0x6007C27")]
    [Address(RVA = "0x219E324", Offset = "0x219E324", VA = "0x219E324")]
    public static List<FreeMapInstanceDirector> CreateTransitionIconInstance(
      FreeMapCommonElement commonElement,
      FreeMapResourceLoader resourceLoader,
      LocationData locationData,
      FreeMapIconEventControlElement iconEventElement,
      IReadOnlyList<FreeMapTransitionEventUIParam> purposeUIList,
      List<string> activeTransAreaAnchorsRefIfNeed)
    {
      return (List<FreeMapInstanceDirector>) null;
    }

    [Token(Token = "0x6007C28")]
    [Address(RVA = "0x219E7C0", Offset = "0x219E7C0", VA = "0x219E7C0")]
    public static List<FreeMapInstanceDirector> CreateInstance(
      FreeMapCommonElement commonElement,
      FreeMapResourceLoader resourceLoader,
      LocationData locationData,
      FreeMapIconEventControlElement iconEventElement)
    {
      return (List<FreeMapInstanceDirector>) null;
    }

    [Token(Token = "0x6007C29")]
    [Address(RVA = "0x219E858", Offset = "0x219E858", VA = "0x219E858")]
    public static List<FreeMapInstanceDirector> CreateInstance(
      FreeMapCommonElement commonElement,
      FreeMapResourceLoader resourceLoader,
      LocationData locationData,
      FreeMapIconEventControlElement iconEventElement,
      IEnumerable<IFreeMapInstanceBuilder> builders)
    {
      return (List<FreeMapInstanceDirector>) null;
    }

    [Token(Token = "0x6007C2A")]
    [Address(RVA = "0x219EE5C", Offset = "0x219EE5C", VA = "0x219EE5C")]
    public static FreeMapInstanceDirector BuildDirector(
      FreeMapCommonElement commonElement,
      FreeMapIconEventControlElement iconEventElement,
      IFreeMapInstanceBuilder builder,
      params FreeMapUIParamBase[] uiParams)
    {
      return (FreeMapInstanceDirector) null;
    }

    [Token(Token = "0x6007C2B")]
    [Address(RVA = "0x219F040", Offset = "0x219F040", VA = "0x219F040")]
    static InstanceBuildUtility()
    {
    }
  }
}
