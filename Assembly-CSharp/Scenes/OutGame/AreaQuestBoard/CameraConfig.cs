// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.AreaQuestBoard.CameraConfig
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.AreaQuestBoard
{
  [Token(Token = "0x20038C4")]
  public class CameraConfig : MonoBehaviour
  {
    [Token(Token = "0x400F835")]
    [FieldOffset(Offset = "0x18")]
    [Min(1f)]
    [Tooltip("カメラの距離")]
    public float CameraDistance;
    [Token(Token = "0x400F836")]
    [FieldOffset(Offset = "0x1C")]
    [Min(0.0f)]
    [Tooltip("ホールド判定時間")]
    public float HoldCount;
    [Token(Token = "0x400F837")]
    [FieldOffset(Offset = "0x20")]
    [Min(0.0f)]
    [Tooltip("カメラタップ判定閾値")]
    public float TapThreshold;
    [Token(Token = "0x400F838")]
    [FieldOffset(Offset = "0x24")]
    [Min(1f)]
    [Tooltip("スクロール量に対するカメラの移動時間")]
    public float CameraStep;
    [Token(Token = "0x400F839")]
    [FieldOffset(Offset = "0x28")]
    [Tooltip("カメラ強制移動にかかる時間")]
    [Min(0.0f)]
    public float ForcedCameraMoveTime;
    [Token(Token = "0x400F83A")]
    [FieldOffset(Offset = "0x2C")]
    [Tooltip("カメラ移動開始時間")]
    [Min(0.0f)]
    public float ForcedCameraDelayMoveTime;
    [Token(Token = "0x400F83B")]
    [FieldOffset(Offset = "0x30")]
    public Action OnChangeAction;

    [Token(Token = "0x60164FF")]
    [Address(RVA = "0x2077AB0", Offset = "0x2077AB0", VA = "0x2077AB0")]
    private void OnValidate()
    {
    }

    [Token(Token = "0x6016500")]
    [Address(RVA = "0x2077ACC", Offset = "0x2077ACC", VA = "0x2077ACC")]
    public CameraConfig()
    {
    }
  }
}
