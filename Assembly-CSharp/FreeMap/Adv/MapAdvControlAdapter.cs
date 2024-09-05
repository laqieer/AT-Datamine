// Decompiled with JetBrains decompiler
// Type: FreeMap.Adv.MapAdvControlAdapter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Area.MovableMob;
using FreeMap.Instance;
using FreeMap.Sound;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace FreeMap.Adv
{
  [Token(Token = "0x2001973")]
  public class MapAdvControlAdapter : IFreeMapAdvControl
  {
    [Token(Token = "0x4006D69")]
    [FieldOffset(Offset = "0x10")]
    private FreeMapInstanceHolder holderRef;
    [Token(Token = "0x4006D6A")]
    [FieldOffset(Offset = "0x18")]
    private MovableMobManager mobManager;
    [Token(Token = "0x4006D6B")]
    [FieldOffset(Offset = "0x20")]
    private AudioListenerConrtol audioListenerRef;

    [Token(Token = "0x6009127")]
    [Address(RVA = "0x4D08AC8", Offset = "0x4D08AC8", VA = "0x4D08AC8")]
    public MapAdvControlAdapter(
      FreeMapInstanceHolder holderRef,
      AudioListenerConrtol audioListenerRef,
      MovableMobManager mobManager)
    {
    }

    [Token(Token = "0x6009128")]
    [Address(RVA = "0x4D08B04", Offset = "0x4D08B04", VA = "0x4D08B04", Slot = "4")]
    public GameObject GetAreaObjectModelRef(string objectAccessName) => (GameObject) null;

    [Token(Token = "0x6009129")]
    [Address(RVA = "0x4D08B20", Offset = "0x4D08B20", VA = "0x4D08B20", Slot = "5")]
    public GameObject GetPlayerObjectModelRef() => (GameObject) null;

    [Token(Token = "0x600912A")]
    [Address(RVA = "0x4D08B3C", Offset = "0x4D08B3C", VA = "0x4D08B3C", Slot = "6")]
    public void ShowVisibleObjectAll()
    {
    }

    [Token(Token = "0x600912B")]
    [Address(RVA = "0x4D08B78", Offset = "0x4D08B78", VA = "0x4D08B78", Slot = "7")]
    public void HideVisibleObjectAll()
    {
    }

    [Token(Token = "0x600912C")]
    [Address(RVA = "0x4D08BB4", Offset = "0x4D08BB4", VA = "0x4D08BB4", Slot = "8")]
    public void ChangeAudioListener(bool enableAreaListener)
    {
    }
  }
}
