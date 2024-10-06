// Decompiled with JetBrains decompiler
// Type: Battle.ViewCamera.IMapViewCamera
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Grid;
using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Battle.ViewCamera
{
  [Token(Token = "0x2002616")]
  public interface IMapViewCamera : IStepUpdate
  {
    [Token(Token = "0x17003221")]
    int Id { [Token(Token = "0x600EB17")] get; [Token(Token = "0x600EB18")] set; }

    [Token(Token = "0x17003222")]
    Vector3 CurrentPorPosition { [Token(Token = "0x600EB19")] get; }

    [Token(Token = "0x17003223")]
    float CurrentDistance { [Token(Token = "0x600EB1A")] get; }

    [Token(Token = "0x17003224")]
    float MinDistance { [Token(Token = "0x600EB1B")] get; [Token(Token = "0x600EB1C")] set; }

    [Token(Token = "0x17003225")]
    float MaxDistance { [Token(Token = "0x600EB1D")] get; [Token(Token = "0x600EB1E")] set; }

    [Token(Token = "0x17003226")]
    Vector3 CurrentEulerAngles { [Token(Token = "0x600EB1F")] get; }

    [Token(Token = "0x17003227")]
    Quaternion CurrentRotation { [Token(Token = "0x600EB20")] get; }

    [Token(Token = "0x17003228")]
    float HeightOffset { [Token(Token = "0x600EB21")] get; [Token(Token = "0x600EB22")] set; }

    [Token(Token = "0x17003229")]
    Vector3 MinMovePosition { [Token(Token = "0x600EB23")] get; [Token(Token = "0x600EB24")] set; }

    [Token(Token = "0x1700322A")]
    Vector3 MaxMovePosition { [Token(Token = "0x600EB25")] get; [Token(Token = "0x600EB26")] set; }

    [Token(Token = "0x1700322B")]
    Camera MapStageCamera { [Token(Token = "0x600EB27")] get; }

    [Token(Token = "0x1700322C")]
    Camera MapStageUICamera { [Token(Token = "0x600EB28")] get; }

    [Token(Token = "0x1400013B")]
    event Action<float> OnUpdateDistance;

    [Token(Token = "0x1400013C")]
    event Action<float> OnCompleteUpdateDistance;

    [Token(Token = "0x1400013D")]
    event Action<Vector3> OnUpdatePosition;

    [Token(Token = "0x1400013E")]
    event Action<Quaternion> OnUpdateRotation;

    [Token(Token = "0x600EB31")]
    void ChangeTo(Vector3 moveWorldPositionTo, float distanceTo, Vector3 angleTo, float duration = 0.0f);

    [Token(Token = "0x600EB32")]
    void MoveTo(GridObject grid, float duration = 0.0f);

    [Token(Token = "0x600EB33")]
    void MoveTo(Transform targetTransform, float duration = 0.0f);

    [Token(Token = "0x600EB34")]
    void MoveTo(Vector3 worldPosition, float duration = 0.0f);

    [Token(Token = "0x600EB35")]
    void MoveDistance(float distance, float duration = 0.0f);

    [Token(Token = "0x600EB36")]
    void RotateTo(float x, float y, float z, float duration = 0.0f);

    [Token(Token = "0x600EB37")]
    void RotateTo(Vector3 eulerAngles, float duration = 0.0f);

    [Token(Token = "0x600EB38")]
    Vector3 ConvertScreenPosToPORWorldPos(Vector2 screenPosition);

    [Token(Token = "0x600EB39")]
    Vector3 ScreenToWorldPoint(Vector3 point);

    [Token(Token = "0x600EB3A")]
    Vector3 WorldToScreenPoint(Vector3 point);

    [Token(Token = "0x1700322D")]
    bool IsBusy { [Token(Token = "0x600EB3B")] get; }

    [Token(Token = "0x600EB3C")]
    void SetClearFlag(CameraClearFlags flag);

    [Token(Token = "0x600EB3D")]
    void SetOccludeDotForced(int id);
  }
}
