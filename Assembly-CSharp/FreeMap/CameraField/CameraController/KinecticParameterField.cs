// Decompiled with JetBrains decompiler
// Type: FreeMap.CameraField.CameraController.KinecticParameterField
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.CameraField.TrackingParameter;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace FreeMap.CameraField.CameraController
{
  [Token(Token = "0x2001966")]
  public class KinecticParameterField : MonoBehaviour
  {
    [Token(Token = "0x4006D2E")]
    public const string PrefabPath = "Assets/Work/FreeMap/Prefab/CameraField/KineticParameterField.prefab";
    [Token(Token = "0x4006D2F")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private TrackingKineticParameter kinecticParameter;

    [Token(Token = "0x17001756")]
    public TrackingKineticParameter KinecticParam
    {
      [Token(Token = "0x60090E3"), Address(RVA = "0x4D06128", Offset = "0x4D06128", VA = "0x4D06128")] get
      {
        return (TrackingKineticParameter) null;
      }
    }

    [Token(Token = "0x60090E4")]
    [Address(RVA = "0x4D06130", Offset = "0x4D06130", VA = "0x4D06130")]
    public KinecticParameterField()
    {
    }
  }
}
