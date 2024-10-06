// Decompiled with JetBrains decompiler
// Type: GlobalBackground.GlobalBackgroundManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.DesignPattern;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace GlobalBackground
{
  [Token(Token = "0x2000BAA")]
  public class GlobalBackgroundManager : SingletonMonoBehaviour<GlobalBackgroundManager>
  {
    [Token(Token = "0x4003535")]
    private const string ASSETBUNDLE_NAME = "ui_common_prefabs";
    [Token(Token = "0x4003536")]
    private const string ASSET_NAME = "Com_GlobalBackGround_Canvas";
    [Token(Token = "0x4003537")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Camera targetCamera;
    [Token(Token = "0x4003538")]
    [FieldOffset(Offset = "0x28")]
    private GlobalBackground.GlobalBackground globalBackground;
    [Token(Token = "0x4003539")]
    [FieldOffset(Offset = "0x30")]
    private bool isShow;

    [Token(Token = "0x600428E")]
    [Address(RVA = "0x363AE28", Offset = "0x363AE28", VA = "0x363AE28")]
    public void Setup()
    {
    }

    [Token(Token = "0x600428F")]
    [Address(RVA = "0x363AECC", Offset = "0x363AECC", VA = "0x363AECC")]
    public void Load(AssetCachedSpawner spawner)
    {
    }

    [Token(Token = "0x6004290")]
    [Address(RVA = "0x363AFA4", Offset = "0x363AFA4", VA = "0x363AFA4")]
    public void PlayInAnim()
    {
    }

    [Token(Token = "0x6004291")]
    [Address(RVA = "0x363AFD4", Offset = "0x363AFD4", VA = "0x363AFD4")]
    public void PlayOutAnim()
    {
    }

    [Token(Token = "0x6004292")]
    [Address(RVA = "0x363B000", Offset = "0x363B000", VA = "0x363B000")]
    public GlobalBackgroundManager()
    {
    }
  }
}
