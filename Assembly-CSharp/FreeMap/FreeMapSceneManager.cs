// Decompiled with JetBrains decompiler
// Type: FreeMap.FreeMapSceneManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Area.MovableMob.Scriptable;
using FreeMap.Loader;
using FreeMap.Parameter;
using FreeMap.Scriptable;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace FreeMap
{
  [Token(Token = "0x20015E5")]
  public class FreeMapSceneManager
  {
    [Token(Token = "0x40063F6")]
    [FieldOffset(Offset = "0x10")]
    private FreeMapAssetHolder<FreeMapPlacementObject> placementLoader;
    [Token(Token = "0x40063F7")]
    [FieldOffset(Offset = "0x18")]
    private FreeMapAssetHolder<MovableRouteObject> movableRouteLoader;
    [Token(Token = "0x40063F8")]
    [FieldOffset(Offset = "0x20")]
    private FreeMapAssetHolder<GameObject> environmentalSoundLoader;

    [Token(Token = "0x17001319")]
    public FreeMapSceneHolder MapLoader
    {
      [Token(Token = "0x6007BEA"), Address(RVA = "0x22A5ED4", Offset = "0x22A5ED4", VA = "0x22A5ED4")] get
      {
        return (FreeMapSceneHolder) null;
      }
      [Token(Token = "0x6007BEB"), Address(RVA = "0x22A5EDC", Offset = "0x22A5EDC", VA = "0x22A5EDC")] private set
      {
      }
    }

    [Token(Token = "0x1700131A")]
    public FreeMapSceneHolder CameraFieldLoader
    {
      [Token(Token = "0x6007BEC"), Address(RVA = "0x22A5EE4", Offset = "0x22A5EE4", VA = "0x22A5EE4")] get
      {
        return (FreeMapSceneHolder) null;
      }
      [Token(Token = "0x6007BED"), Address(RVA = "0x22A5EEC", Offset = "0x22A5EEC", VA = "0x22A5EEC")] private set
      {
      }
    }

    [Token(Token = "0x1700131B")]
    public FreeMapSceneHolder TransitionAreaLoader
    {
      [Token(Token = "0x6007BEE"), Address(RVA = "0x22A5EF4", Offset = "0x22A5EF4", VA = "0x22A5EF4")] get
      {
        return (FreeMapSceneHolder) null;
      }
      [Token(Token = "0x6007BEF"), Address(RVA = "0x22A5EFC", Offset = "0x22A5EFC", VA = "0x22A5EFC")] private set
      {
      }
    }

    [Token(Token = "0x1700131C")]
    public FreeMapPlacementObject PlacementObject
    {
      [Token(Token = "0x6007BF0"), Address(RVA = "0x22A5DAC", Offset = "0x22A5DAC", VA = "0x22A5DAC")] get
      {
        return (FreeMapPlacementObject) null;
      }
    }

    [Token(Token = "0x1700131D")]
    public MovableRouteObject MovableObject
    {
      [Token(Token = "0x6007BF1"), Address(RVA = "0x22A5DF4", Offset = "0x22A5DF4", VA = "0x22A5DF4")] get
      {
        return (MovableRouteObject) null;
      }
    }

    [Token(Token = "0x1700131E")]
    public GameObject EnvironmentalSoundObject
    {
      [Token(Token = "0x6007BF2"), Address(RVA = "0x22A5E3C", Offset = "0x22A5E3C", VA = "0x22A5E3C")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x6007BF3")]
    [Address(RVA = "0x22A3B4C", Offset = "0x22A3B4C", VA = "0x22A3B4C")]
    public FreeMapSceneManager()
    {
    }

    [Token(Token = "0x6007BF4")]
    [Address(RVA = "0x22A3E9C", Offset = "0x22A3E9C", VA = "0x22A3E9C")]
    public void SetupScenes(FreeMapResourceLoader resourceLoader, FreeMapScenesParam param)
    {
    }

    [Token(Token = "0x6007BF5")]
    [Address(RVA = "0x22A44E0", Offset = "0x22A44E0", VA = "0x22A44E0")]
    public void UnloadScenes()
    {
    }

    [Token(Token = "0x6007BF6")]
    [Address(RVA = "0x22A4884", Offset = "0x22A4884", VA = "0x22A4884")]
    public void Destroy()
    {
    }

    [Token(Token = "0x6007BF7")]
    [Address(RVA = "0x22A5F0C", Offset = "0x22A5F0C", VA = "0x22A5F0C")]
    private void OnBuildEnvironmentalSoundObject(GameObject obj)
    {
    }
  }
}
