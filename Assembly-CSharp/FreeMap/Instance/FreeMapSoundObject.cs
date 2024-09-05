// Decompiled with JetBrains decompiler
// Type: FreeMap.Instance.FreeMapSoundObject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Scriptable;
using FreeMap.Sound;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace FreeMap.Instance
{
  [Token(Token = "0x20018ED")]
  public class FreeMapSoundObject : FreeMapInstance, IFreeMapVisibleObject
  {
    [Token(Token = "0x4006BEB")]
    [FieldOffset(Offset = "0x50")]
    private GameObject soundObject;
    [Token(Token = "0x4006BEC")]
    [FieldOffset(Offset = "0x58")]
    private AkTriggerHandler[] akTriggerHandlers;

    [Token(Token = "0x170016B1")]
    private FreeMapSoundResourceManager.Handler resourceHandler
    {
      [Token(Token = "0x6008DA0"), Address(RVA = "0x4AFB6D8", Offset = "0x4AFB6D8", VA = "0x4AFB6D8")] set
      {
      }
      [Token(Token = "0x6008DA1"), Address(RVA = "0x4AFB6E0", Offset = "0x4AFB6E0", VA = "0x4AFB6E0")] get
      {
        return (FreeMapSoundResourceManager.Handler) null;
      }
    }

    [Token(Token = "0x6008DA2")]
    [Address(RVA = "0x4AFB6E8", Offset = "0x4AFB6E8", VA = "0x4AFB6E8")]
    public void SetupInstance(GameObject soundObject, AkTriggerHandler[] akTriggerHandlers)
    {
    }

    [Token(Token = "0x6008DA3")]
    [Address(RVA = "0x4AFB6F0", Offset = "0x4AFB6F0", VA = "0x4AFB6F0", Slot = "8")]
    public override void InstanceUpdate()
    {
    }

    [Token(Token = "0x6008DA4")]
    [Address(RVA = "0x4AFB6F4", Offset = "0x4AFB6F4", VA = "0x4AFB6F4", Slot = "7")]
    public override void PlaceInMap(FreeMapPlacementObject placementObject)
    {
    }

    [Token(Token = "0x6008DA5")]
    [Address(RVA = "0x4AFB77C", Offset = "0x4AFB77C", VA = "0x4AFB77C")]
    public void SetHandle(FreeMapSoundResourceManager.Handler handler)
    {
    }

    [Token(Token = "0x6008DA6")]
    [Address(RVA = "0x4AFB784", Offset = "0x4AFB784", VA = "0x4AFB784")]
    public void PlaySE()
    {
    }

    [Token(Token = "0x6008DA7")]
    [Address(RVA = "0x4AFB824", Offset = "0x4AFB824", VA = "0x4AFB824", Slot = "10")]
    public override void ReleaseInstance()
    {
    }

    [Token(Token = "0x6008DA8")]
    [Address(RVA = "0x4AFB8C4", Offset = "0x4AFB8C4", VA = "0x4AFB8C4", Slot = "11")]
    public void Show()
    {
    }

    [Token(Token = "0x6008DA9")]
    [Address(RVA = "0x4AFB8DC", Offset = "0x4AFB8DC", VA = "0x4AFB8DC", Slot = "12")]
    public void Hide()
    {
    }

    [Token(Token = "0x6008DAA")]
    [Address(RVA = "0x4AFB8F4", Offset = "0x4AFB8F4", VA = "0x4AFB8F4")]
    public FreeMapSoundObject()
    {
    }
  }
}
