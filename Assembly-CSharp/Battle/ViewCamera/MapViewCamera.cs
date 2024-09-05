// Decompiled with JetBrains decompiler
// Type: Battle.ViewCamera.MapViewCamera
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
  [Token(Token = "0x2002619")]
  public sealed class MapViewCamera : MonoBehaviour, IMapViewCamera, IStepUpdate
  {
    [Token(Token = "0x400A385")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Transform por;
    [Token(Token = "0x400A386")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Transform rotationRoot;
    [Token(Token = "0x400A387")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Camera mapGridCamera;
    [Token(Token = "0x400A388")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Camera mapUiCamera;
    [Token(Token = "0x400A395")]
    [FieldOffset(Offset = "0x90")]
    private Vector3Curve moveLerp;
    [Token(Token = "0x400A396")]
    [FieldOffset(Offset = "0x98")]
    private Vector3Curve rotateLerp;
    [Token(Token = "0x400A397")]
    [FieldOffset(Offset = "0xA0")]
    private FloatCurve distanceLerp;
    [Token(Token = "0x400A399")]
    [FieldOffset(Offset = "0xA9")]
    private bool OcculudeForce;

    [Token(Token = "0x17003231")]
    public Camera MapStageCamera
    {
      [Token(Token = "0x600EB49"), Address(RVA = "0x4B9A5E8", Offset = "0x4B9A5E8", VA = "0x4B9A5E8", Slot = "20")] get
      {
        return (Camera) null;
      }
    }

    [Token(Token = "0x17003232")]
    public Camera MapStageUICamera
    {
      [Token(Token = "0x600EB4A"), Address(RVA = "0x4B9A5F0", Offset = "0x4B9A5F0", VA = "0x4B9A5F0", Slot = "21")] get
      {
        return (Camera) null;
      }
    }

    [Token(Token = "0x17003233")]
    public int Id
    {
      [Token(Token = "0x600EB4B"), Address(RVA = "0x4B9A5F8", Offset = "0x4B9A5F8", VA = "0x4B9A5F8", Slot = "4")] get
      {
        return new int();
      }
      [Token(Token = "0x600EB4C"), Address(RVA = "0x4B9A600", Offset = "0x4B9A600", VA = "0x4B9A600", Slot = "5")] set
      {
      }
    }

    [Token(Token = "0x17003234")]
    public Vector3 CurrentPorPosition
    {
      [Token(Token = "0x600EB4D"), Address(RVA = "0x4B9A608", Offset = "0x4B9A608", VA = "0x4B9A608", Slot = "6")] get
      {
        return new Vector3();
      }
    }

    [Token(Token = "0x17003235")]
    public float CurrentDistance
    {
      [Token(Token = "0x600EB4E"), Address(RVA = "0x4B9A660", Offset = "0x4B9A660", VA = "0x4B9A660", Slot = "7")] get
      {
        return new float();
      }
      [Token(Token = "0x600EB4F"), Address(RVA = "0x4B9A668", Offset = "0x4B9A668", VA = "0x4B9A668")] private set
      {
      }
    }

    [Token(Token = "0x17003236")]
    public Vector3 CurrentEulerAngles
    {
      [Token(Token = "0x600EB50"), Address(RVA = "0x4B9A670", Offset = "0x4B9A670", VA = "0x4B9A670", Slot = "12")] get
      {
        return new Vector3();
      }
    }

    [Token(Token = "0x17003237")]
    public Quaternion CurrentRotation
    {
      [Token(Token = "0x600EB51"), Address(RVA = "0x4B9A6C8", Offset = "0x4B9A6C8", VA = "0x4B9A6C8", Slot = "13")] get
      {
        return new Quaternion();
      }
    }

    [Token(Token = "0x17003238")]
    public float HeightOffset
    {
      [Token(Token = "0x600EB52"), Address(RVA = "0x4B9A720", Offset = "0x4B9A720", VA = "0x4B9A720", Slot = "14")] get
      {
        return new float();
      }
      [Token(Token = "0x600EB53"), Address(RVA = "0x4B9A728", Offset = "0x4B9A728", VA = "0x4B9A728", Slot = "15")] set
      {
      }
    }

    [Token(Token = "0x17003239")]
    public Vector3 MinMovePosition
    {
      [Token(Token = "0x600EB54"), Address(RVA = "0x4B9A730", Offset = "0x4B9A730", VA = "0x4B9A730", Slot = "16")] get
      {
        return new Vector3();
      }
      [Token(Token = "0x600EB55"), Address(RVA = "0x4B9A73C", Offset = "0x4B9A73C", VA = "0x4B9A73C", Slot = "17")] set
      {
      }
    }

    [Token(Token = "0x1700323A")]
    public Vector3 MaxMovePosition
    {
      [Token(Token = "0x600EB56"), Address(RVA = "0x4B9A748", Offset = "0x4B9A748", VA = "0x4B9A748", Slot = "18")] get
      {
        return new Vector3();
      }
      [Token(Token = "0x600EB57"), Address(RVA = "0x4B9A754", Offset = "0x4B9A754", VA = "0x4B9A754", Slot = "19")] set
      {
      }
    }

    [Token(Token = "0x1700323B")]
    public float MinDistance
    {
      [Token(Token = "0x600EB58"), Address(RVA = "0x4B9A760", Offset = "0x4B9A760", VA = "0x4B9A760", Slot = "8")] get
      {
        return new float();
      }
      [Token(Token = "0x600EB59"), Address(RVA = "0x4B9A768", Offset = "0x4B9A768", VA = "0x4B9A768", Slot = "9")] set
      {
      }
    }

    [Token(Token = "0x1700323C")]
    public float MaxDistance
    {
      [Token(Token = "0x600EB5A"), Address(RVA = "0x4B9A770", Offset = "0x4B9A770", VA = "0x4B9A770", Slot = "10")] get
      {
        return new float();
      }
      [Token(Token = "0x600EB5B"), Address(RVA = "0x4B9A778", Offset = "0x4B9A778", VA = "0x4B9A778", Slot = "11")] set
      {
      }
    }

    [Token(Token = "0x1400013F")]
    public event Action<float> OnUpdateDistance
    {
      [Token(Token = "0x600EB5C"), Address(RVA = "0x4B9A780", Offset = "0x4B9A780", VA = "0x4B9A780", Slot = "22")] add
      {
      }
      [Token(Token = "0x600EB5D"), Address(RVA = "0x4B9A830", Offset = "0x4B9A830", VA = "0x4B9A830", Slot = "23")] remove
      {
      }
    }

    [Token(Token = "0x14000140")]
    public event Action<float> OnCompleteUpdateDistance
    {
      [Token(Token = "0x600EB5E"), Address(RVA = "0x4B9A8E0", Offset = "0x4B9A8E0", VA = "0x4B9A8E0", Slot = "24")] add
      {
      }
      [Token(Token = "0x600EB5F"), Address(RVA = "0x4B9A990", Offset = "0x4B9A990", VA = "0x4B9A990", Slot = "25")] remove
      {
      }
    }

    [Token(Token = "0x14000141")]
    public event Action<Vector3> OnUpdatePosition
    {
      [Token(Token = "0x600EB60"), Address(RVA = "0x4B9AA40", Offset = "0x4B9AA40", VA = "0x4B9AA40", Slot = "26")] add
      {
      }
      [Token(Token = "0x600EB61"), Address(RVA = "0x4B9AAF0", Offset = "0x4B9AAF0", VA = "0x4B9AAF0", Slot = "27")] remove
      {
      }
    }

    [Token(Token = "0x14000142")]
    public event Action<Quaternion> OnUpdateRotation
    {
      [Token(Token = "0x600EB62"), Address(RVA = "0x4B9ABA0", Offset = "0x4B9ABA0", VA = "0x4B9ABA0", Slot = "28")] add
      {
      }
      [Token(Token = "0x600EB63"), Address(RVA = "0x4B9AC50", Offset = "0x4B9AC50", VA = "0x4B9AC50", Slot = "29")] remove
      {
      }
    }

    [Token(Token = "0x14000143")]
    public event Action<int> OnCompleteRotation
    {
      [Token(Token = "0x600EB64"), Address(RVA = "0x4B9AD00", Offset = "0x4B9AD00", VA = "0x4B9AD00")] add
      {
      }
      [Token(Token = "0x600EB65"), Address(RVA = "0x4B9ADB0", Offset = "0x4B9ADB0", VA = "0x4B9ADB0")] remove
      {
      }
    }

    [Token(Token = "0x1700323D")]
    public bool IsBusy
    {
      [Token(Token = "0x600EB66"), Address(RVA = "0x4B9AE60", Offset = "0x4B9AE60", VA = "0x4B9AE60", Slot = "40")] get
      {
        return new bool();
      }
      [Token(Token = "0x600EB67"), Address(RVA = "0x4B9AE68", Offset = "0x4B9AE68", VA = "0x4B9AE68")] private set
      {
      }
    }

    [Token(Token = "0x600EB68")]
    [Address(RVA = "0x4B9AE74", Offset = "0x4B9AE74", VA = "0x4B9AE74", Slot = "30")]
    public void ChangeTo(
      Vector3 moveWorldPositionTo,
      float distanceTo,
      Vector3 angleTo,
      float duration = 0.0f)
    {
    }

    [Token(Token = "0x600EB69")]
    [Address(RVA = "0x4B9B3DC", Offset = "0x4B9B3DC", VA = "0x4B9B3DC", Slot = "31")]
    public void MoveTo(GridObject grid, float duration = 0.0f)
    {
    }

    [Token(Token = "0x600EB6A")]
    [Address(RVA = "0x4B9B428", Offset = "0x4B9B428", VA = "0x4B9B428", Slot = "32")]
    public void MoveTo(Transform targetTransform, float duration = 0.0f)
    {
    }

    [Token(Token = "0x600EB6B")]
    [Address(RVA = "0x4B9AEDC", Offset = "0x4B9AEDC", VA = "0x4B9AEDC", Slot = "33")]
    public void MoveTo(Vector3 worldPosition, float duration = 0.0f)
    {
    }

    [Token(Token = "0x600EB6C")]
    [Address(RVA = "0x4B9B090", Offset = "0x4B9B090", VA = "0x4B9B090", Slot = "34")]
    public void MoveDistance(float distance, float duration = 0.0f)
    {
    }

    [Token(Token = "0x600EB6D")]
    [Address(RVA = "0x4B9B540", Offset = "0x4B9B540", VA = "0x4B9B540", Slot = "35")]
    public void RotateTo(float x, float y, float z, float duration = 0.0f)
    {
    }

    [Token(Token = "0x600EB6E")]
    [Address(RVA = "0x4B9B208", Offset = "0x4B9B208", VA = "0x4B9B208", Slot = "36")]
    public void RotateTo(Vector3 eulerAndgles, float duration = 0.0f)
    {
    }

    [Token(Token = "0x600EB6F")]
    [Address(RVA = "0x4B9B544", Offset = "0x4B9B544", VA = "0x4B9B544", Slot = "43")]
    public void Step(float delta)
    {
    }

    [Token(Token = "0x600EB70")]
    [Address(RVA = "0x4B9B5B4", Offset = "0x4B9B5B4", VA = "0x4B9B5B4")]
    private bool UpdateMovePosition(float delta) => new bool();

    [Token(Token = "0x600EB71")]
    [Address(RVA = "0x4B9B688", Offset = "0x4B9B688", VA = "0x4B9B688")]
    private bool UpdateDistance(float delta) => new bool();

    [Token(Token = "0x600EB72")]
    [Address(RVA = "0x4B9B7C8", Offset = "0x4B9B7C8", VA = "0x4B9B7C8")]
    private bool UpdateRotation(float delta) => new bool();

    [Token(Token = "0x600EB73")]
    [Address(RVA = "0x4B9B4D4", Offset = "0x4B9B4D4", VA = "0x4B9B4D4")]
    private void ClampMovePosition(ref Vector3 pos)
    {
    }

    [Token(Token = "0x600EB74")]
    [Address(RVA = "0x4B9B8D8", Offset = "0x4B9B8D8", VA = "0x4B9B8D8", Slot = "37")]
    public Vector3 ConvertScreenPosToPORWorldPos(Vector2 screenPosition) => new Vector3();

    [Token(Token = "0x600EB75")]
    [Address(RVA = "0x4B9B8FC", Offset = "0x4B9B8FC", VA = "0x4B9B8FC", Slot = "38")]
    public Vector3 ScreenToWorldPoint(Vector3 point) => new Vector3();

    [Token(Token = "0x600EB76")]
    [Address(RVA = "0x4B9B918", Offset = "0x4B9B918", VA = "0x4B9B918", Slot = "39")]
    public Vector3 WorldToScreenPoint(Vector3 point) => new Vector3();

    [Token(Token = "0x600EB77")]
    [Address(RVA = "0x4B9B934", Offset = "0x4B9B934", VA = "0x4B9B934", Slot = "41")]
    public void SetClearFlag(CameraClearFlags flag)
    {
    }

    [Token(Token = "0x600EB78")]
    [Address(RVA = "0x4B9B8A8", Offset = "0x4B9B8A8", VA = "0x4B9B8A8", Slot = "42")]
    public void SetOccludeDotForced(int id)
    {
    }

    [Token(Token = "0x600EB79")]
    [Address(RVA = "0x4B9B950", Offset = "0x4B9B950", VA = "0x4B9B950")]
    private void SetOccludeDotForced(bool b)
    {
    }

    [Token(Token = "0x600EB7A")]
    [Address(RVA = "0x4B9B9F4", Offset = "0x4B9B9F4", VA = "0x4B9B9F4")]
    private void OnCompleteAction()
    {
    }

    [Token(Token = "0x600EB7B")]
    [Address(RVA = "0x4B9B9FC", Offset = "0x4B9B9FC", VA = "0x4B9B9FC")]
    public MapViewCamera()
    {
    }
  }
}
