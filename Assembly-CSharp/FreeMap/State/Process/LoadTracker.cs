// Decompiled with JetBrains decompiler
// Type: FreeMap.State.Process.LoadTracker
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Loader;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace FreeMap.State.Process
{
  [Token(Token = "0x20017E0")]
  public class LoadTracker : FreeMapProcess
  {
    [Token(Token = "0x40068DC")]
    [FieldOffset(Offset = "0x38")]
    private FreeMapAssetHolder<GameObject> trackerAssetHolder;

    [Token(Token = "0x6008714")]
    [Address(RVA = "0x43D0E64", Offset = "0x43D0E64", VA = "0x43D0E64")]
    public LoadTracker(FreeMapStateManager entity)
    {
    }

    [Token(Token = "0x6008715")]
    [Address(RVA = "0x43D4330", Offset = "0x43D4330", VA = "0x43D4330", Slot = "4")]
    public override void Begin()
    {
    }

    [Token(Token = "0x6008716")]
    [Address(RVA = "0x43D4468", Offset = "0x43D4468", VA = "0x43D4468")]
    private void OnBuild(GameObject loaded)
    {
    }
  }
}
