// Decompiled with JetBrains decompiler
// Type: FreeMap.Instance.FreeMapInstanceHolder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Loader;
using FreeMap.Scriptable;
using FreeMap.UI.Entity;
using FreeMap.UI.Manager;
using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace FreeMap.Instance
{
  [Token(Token = "0x20018E0")]
  public class FreeMapInstanceHolder : IFreeMapRegistBackgroundCamera
  {
    [Token(Token = "0x4006BCE")]
    [FieldOffset(Offset = "0x0")]
    public static string ObjectAccessName;
    [Token(Token = "0x4006BCF")]
    [FieldOffset(Offset = "0x10")]
    private List<FreeMapInstance> instanceList;
    [Token(Token = "0x4006BD0")]
    [FieldOffset(Offset = "0x18")]
    private FreeMapPlayerInstance playerRef;

    [Token(Token = "0x170016AC")]
    public FreeMapPlayerInstance PlayerInstance
    {
      [Token(Token = "0x6008D48"), Address(RVA = "0x4533810", Offset = "0x4533810", VA = "0x4533810")] get
      {
        return (FreeMapPlayerInstance) null;
      }
    }

    [Token(Token = "0x6008D49")]
    [Address(RVA = "0x45334E8", Offset = "0x45334E8", VA = "0x45334E8")]
    public void RegistInstance(FreeMapInstance instance)
    {
    }

    [Token(Token = "0x6008D4A")]
    [Address(RVA = "0x4533818", Offset = "0x4533818", VA = "0x4533818")]
    public void RegistPlayer(FreeMapPlayerInstance player)
    {
    }

    [Token(Token = "0x6008D4B")]
    [Address(RVA = "0x4533820", Offset = "0x4533820", VA = "0x4533820")]
    public void RegistInstanceRange(IEnumerable<FreeMapInstance> list)
    {
    }

    [Token(Token = "0x6008D4C")]
    [Address(RVA = "0x4533AF8", Offset = "0x4533AF8", VA = "0x4533AF8")]
    public bool Release(FreeMapInstance instance) => new bool();

    [Token(Token = "0x6008D4D")]
    [Address(RVA = "0x4533BD8", Offset = "0x4533BD8", VA = "0x4533BD8")]
    public bool Release(
      InstanceID instanceID,
      List<IFreeMapUIManager> uiManagerList,
      out FreeMapUIBase deleteUI)
    {
      return new bool();
    }

    [Token(Token = "0x6008D4E")]
    [Address(RVA = "0x4533EC8", Offset = "0x4533EC8", VA = "0x4533EC8")]
    public void ReleaseAll()
    {
    }

    [Token(Token = "0x6008D4F")]
    [Address(RVA = "0x4533BB8", Offset = "0x4533BB8", VA = "0x4533BB8")]
    private void ReleaseInstance(FreeMapInstance target)
    {
    }

    [Token(Token = "0x6008D50")]
    [Address(RVA = "0x45340E4", Offset = "0x45340E4", VA = "0x45340E4")]
    public void ShowVisibleObjectAll()
    {
    }

    [Token(Token = "0x6008D51")]
    [Address(RVA = "0x45342A8", Offset = "0x45342A8", VA = "0x45342A8")]
    public void HideVisibleObjectAll()
    {
    }

    [Token(Token = "0x6008D52")]
    [Address(RVA = "0x4534470", Offset = "0x4534470", VA = "0x4534470")]
    public GameObject GetAreaObjectModelRef(string objAccessName) => (GameObject) null;

    [Token(Token = "0x6008D53")]
    [Address(RVA = "0x45347F8", Offset = "0x45347F8", VA = "0x45347F8")]
    public GameObject GetPlayerObjectModelRef() => (GameObject) null;

    [Token(Token = "0x6008D54")]
    [Address(RVA = "0x45348A4", Offset = "0x45348A4", VA = "0x45348A4")]
    public IEnumerable<FreeMapInstance> GetAllInstances() => (IEnumerable<FreeMapInstance>) null;

    [Token(Token = "0x6008D55")]
    [Address(RVA = "0x4534950", Offset = "0x4534950", VA = "0x4534950")]
    public IEnumerable<InstanceID> GetAllInstancesIDs() => (IEnumerable<InstanceID>) null;

    [Token(Token = "0x6008D56")]
    [Address(RVA = "0x4534A68", Offset = "0x4534A68", VA = "0x4534A68")]
    public FreeMapCharacter[] GetFreeMapCharacterByNpc() => (FreeMapCharacter[]) null;

    [Token(Token = "0x6008D57")]
    [Address(RVA = "0x4534C08", Offset = "0x4534C08", VA = "0x4534C08")]
    public FreeMapInstance[] GetFreeMapInstanceByIcon() => (FreeMapInstance[]) null;

    [Token(Token = "0x6008D58")]
    [Address(RVA = "0x4534DD0", Offset = "0x4534DD0", VA = "0x4534DD0")]
    public void SetUpFreeMap(Camera usingCamera, FreeMapPlacementObject placement)
    {
    }

    [Token(Token = "0x6008D59")]
    [Address(RVA = "0x453511C", Offset = "0x453511C", VA = "0x453511C")]
    public IEnumerator WaitCoroutineList(List<Coroutine> list) => (IEnumerator) null;

    [Token(Token = "0x6008D5A")]
    [Address(RVA = "0x4535184", Offset = "0x4535184", VA = "0x4535184")]
    public void UpdateInstanceList()
    {
    }

    [Token(Token = "0x6008D5B")]
    [Address(RVA = "0x4535268", Offset = "0x4535268", VA = "0x4535268")]
    public void LateUpdateInstanceList()
    {
    }

    [Token(Token = "0x6008D5C")]
    [Address(RVA = "0x453534C", Offset = "0x453534C", VA = "0x453534C")]
    public bool TryGetInstanceForAccessName(string objAccessName, out FreeMapInstance instance)
    {
      return new bool();
    }

    [Token(Token = "0x6008D5D")]
    [Address(RVA = "0x4535470", Offset = "0x4535470", VA = "0x4535470")]
    public bool TryGetInstanceForAnchor(string anchorName, out FreeMapInstance instance)
    {
      return new bool();
    }

    [Token(Token = "0x6008D5E")]
    [Address(RVA = "0x4535594", Offset = "0x4535594", VA = "0x4535594")]
    public bool TryGetInstanceForInstanceID(InstanceID instanceID, out FreeMapInstance instance)
    {
      return new bool();
    }

    [Token(Token = "0x6008D5F")]
    public bool TryGetInstanceForInstanceID<TInstance>(
      InstanceID instanceID,
      out TInstance instance)
      where TInstance : FreeMapInstance
    {
      return new bool();
    }

    [Token(Token = "0x6008D60")]
    [Address(RVA = "0x4534ECC", Offset = "0x4534ECC", VA = "0x4534ECC")]
    public void SetupBonesLOD(GameObject target)
    {
    }

    [Token(Token = "0x6008D61")]
    [Address(RVA = "0x4533F8C", Offset = "0x4533F8C", VA = "0x4533F8C")]
    private void ForeachInstanceListAction(Action<FreeMapInstance> action)
    {
    }

    [Token(Token = "0x6008D62")]
    [Address(RVA = "0x45355F4", Offset = "0x45355F4", VA = "0x45355F4", Slot = "4")]
    public void RegistCamera(Camera camera)
    {
    }

    [Token(Token = "0x6008D63")]
    [Address(RVA = "0x4535620", Offset = "0x4535620", VA = "0x4535620", Slot = "5")]
    public void ExcludeCamera()
    {
    }

    [Token(Token = "0x6008D64")]
    [Address(RVA = "0x453563C", Offset = "0x453563C", VA = "0x453563C")]
    public FreeMapInstanceHolder()
    {
    }

    [Token(Token = "0x6008D65")]
    [Address(RVA = "0x45356B8", Offset = "0x45356B8", VA = "0x45356B8")]
    static FreeMapInstanceHolder()
    {
    }
  }
}
