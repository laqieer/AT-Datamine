// Decompiled with JetBrains decompiler
// Type: Scenes.DebugViewer.AreaMap.DebugAreaMapPlayer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Instance;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Scenes.DebugViewer.AreaMap
{
  [Token(Token = "0x2002F2E")]
  public class DebugAreaMapPlayer : FreeMapPlayerInstance
  {
    [Token(Token = "0x400CA61")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    private DebugAreaMapPlayer.ControllType controllType;
    [Token(Token = "0x400CA62")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    private GameObject debugModel;
    [Token(Token = "0x400CA63")]
    [FieldOffset(Offset = "0xD0")]
    [SerializeField]
    private RuntimeAnimatorController debugAnimatorController;
    [Token(Token = "0x400CA64")]
    [FieldOffset(Offset = "0xD8")]
    private bool VectorLock;
    [Token(Token = "0x400CA65")]
    [FieldOffset(Offset = "0xDC")]
    private Vector3 lockFoward;
    [Token(Token = "0x400CA66")]
    [FieldOffset(Offset = "0xE8")]
    private Vector3 lockRight;
    [Token(Token = "0x400CA67")]
    [FieldOffset(Offset = "0xF4")]
    private float maxRatio;

    [Token(Token = "0x6012712")]
    [Address(RVA = "0x2116FBC", Offset = "0x2116FBC", VA = "0x2116FBC")]
    public void SetControllType(DebugAreaMapPlayer.ControllType type)
    {
    }

    [Token(Token = "0x6012713")]
    [Address(RVA = "0x2116FC4", Offset = "0x2116FC4", VA = "0x2116FC4")]
    public void DebugPlayerInitialize()
    {
    }

    [Token(Token = "0x6012714")]
    [Address(RVA = "0x2117080", Offset = "0x2117080", VA = "0x2117080")]
    public DebugAreaMapPlayer()
    {
    }

    [Token(Token = "0x2002F2F")]
    public enum ControllType
    {
      [Token(Token = "0x400CA69")] CameraFixed,
      [Token(Token = "0x400CA6A")] SwipeFixed,
    }
  }
}
