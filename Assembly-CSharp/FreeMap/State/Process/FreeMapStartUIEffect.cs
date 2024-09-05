// Decompiled with JetBrains decompiler
// Type: FreeMap.State.Process.FreeMapStartUIEffect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using UI.Direction;
using UnityEngine;

#nullable disable
namespace FreeMap.State.Process
{
  [Token(Token = "0x20017DA")]
  public class FreeMapStartUIEffect : FreeMapProcess
  {
    [Token(Token = "0x40068D0")]
    [FieldOffset(Offset = "0x38")]
    private AssetCachedSpawner spawner;
    [Token(Token = "0x40068D1")]
    [FieldOffset(Offset = "0x40")]
    private GameObject spawnerObj;
    [Token(Token = "0x40068D2")]
    [FieldOffset(Offset = "0x48")]
    private GameObject objectRoot;
    [Token(Token = "0x40068D3")]
    [FieldOffset(Offset = "0x50")]
    private UITimelineController uiTimelineController;
    [Token(Token = "0x40068D4")]
    [FieldOffset(Offset = "0x58")]
    private bool skip;
    [Token(Token = "0x40068D5")]
    private const string ASSETBUNDLE_NAME = "ui_page_areaui_freetime_prefab";
    [Token(Token = "0x40068D6")]
    private const string ASSET_NAME = "Container_FreeTIme";

    [Token(Token = "0x6008702")]
    [Address(RVA = "0x43D376C", Offset = "0x43D376C", VA = "0x43D376C")]
    public FreeMapStartUIEffect(FreeMapStateManager entity)
    {
    }

    [Token(Token = "0x6008703")]
    [Address(RVA = "0x43D3770", Offset = "0x43D3770", VA = "0x43D3770", Slot = "4")]
    public override void Begin()
    {
    }

    [Token(Token = "0x6008704")]
    [Address(RVA = "0x43D3994", Offset = "0x43D3994", VA = "0x43D3994")]
    private void PlayUIEffect(GameObject loaded, Transform parent)
    {
    }

    [Token(Token = "0x6008705")]
    [Address(RVA = "0x43D3CB8", Offset = "0x43D3CB8", VA = "0x43D3CB8", Slot = "5")]
    protected override void OnUpdate()
    {
    }
  }
}
