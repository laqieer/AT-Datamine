// Decompiled with JetBrains decompiler
// Type: FreeMap.Placement.Tools.SceneObject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace FreeMap.Placement.Tools
{
  [Token(Token = "0x200185D")]
  [Serializable]
  public class SceneObject
  {
    [Token(Token = "0x4006A2B")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private UnityEngine.Object sceneAsset;
    [Token(Token = "0x4006A2C")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private string subID;
    [Token(Token = "0x4006A2D")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private string comment;

    [Token(Token = "0x170015BE")]
    public UnityEngine.Object SceneAsset
    {
      [Token(Token = "0x60089C7"), Address(RVA = "0x451DC58", Offset = "0x451DC58", VA = "0x451DC58")] get
      {
        return (UnityEngine.Object) null;
      }
    }

    [Token(Token = "0x170015BF")]
    public string SubID
    {
      [Token(Token = "0x60089C8"), Address(RVA = "0x451DC60", Offset = "0x451DC60", VA = "0x451DC60")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170015C0")]
    public string Comment
    {
      [Token(Token = "0x60089C9"), Address(RVA = "0x451DC68", Offset = "0x451DC68", VA = "0x451DC68")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x60089CA")]
    [Address(RVA = "0x451DC70", Offset = "0x451DC70", VA = "0x451DC70")]
    public string GetPlacementFileName() => (string) null;

    [Token(Token = "0x60089CB")]
    [Address(RVA = "0x451DD7C", Offset = "0x451DD7C", VA = "0x451DD7C")]
    public string GetTransitionFileName() => (string) null;

    [Token(Token = "0x60089CC")]
    [Address(RVA = "0x451DE88", Offset = "0x451DE88", VA = "0x451DE88", Slot = "3")]
    public override string ToString() => (string) null;

    [Token(Token = "0x60089CD")]
    [Address(RVA = "0x451E080", Offset = "0x451E080", VA = "0x451E080")]
    public SceneObject()
    {
    }
  }
}
