// Decompiled with JetBrains decompiler
// Type: WindAnimation.WindViewer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace WindAnimation
{
  [Token(Token = "0x2003F1C")]
  public class WindViewer : MonoBehaviour
  {
    [Token(Token = "0x40114AB")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private WindSettingsAsset windSetting;
    [Token(Token = "0x40114AC")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject environmentalMarkObj;
    [Token(Token = "0x40114AD")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject circularSpreadMarkObj;
    [Token(Token = "0x40114AE")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private List<GameObject> targetModel;
    [Token(Token = "0x40114AF")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Transform windDirectionObject;
    [Token(Token = "0x40114B0")]
    [FieldOffset(Offset = "0x40")]
    private List<WindAffectedBone> windAffectedBoneList;
    [Token(Token = "0x40114B1")]
    [FieldOffset(Offset = "0x48")]
    private WindCommonParameter windParameter;
    [Token(Token = "0x40114B2")]
    [FieldOffset(Offset = "0x50")]
    private bool dynamicBoneEdit;
    [Token(Token = "0x40114B3")]
    [FieldOffset(Offset = "0x51")]
    private bool gravityEnable;
    [Token(Token = "0x40114B4")]
    [FieldOffset(Offset = "0x54")]
    private Vector3 gravity;
    [Token(Token = "0x40114B5")]
    [FieldOffset(Offset = "0x60")]
    private WindViewer.WindType windMode;
    [Token(Token = "0x40114B6")]
    [FieldOffset(Offset = "0x64")]
    private float power;
    [Token(Token = "0x40114B7")]
    [FieldOffset(Offset = "0x68")]
    private float fluctuationPower;
    [Token(Token = "0x40114B8")]
    [FieldOffset(Offset = "0x6C")]
    private float fluctuationFrequency;
    [Token(Token = "0x40114B9")]
    [FieldOffset(Offset = "0x70")]
    private float directionCoefficient;
    [Token(Token = "0x40114BA")]
    [FieldOffset(Offset = "0x74")]
    private Rect windowRect;
    [Token(Token = "0x40114BB")]
    [FieldOffset(Offset = "0x84")]
    private float windPower;

    [Token(Token = "0x60197F4")]
    [Address(RVA = "0x3744C78", Offset = "0x3744C78", VA = "0x3744C78")]
    private void ViewGravityWindow(int windowID)
    {
    }

    [Token(Token = "0x60197F5")]
    [Address(RVA = "0x3744FAC", Offset = "0x3744FAC", VA = "0x3744FAC")]
    public void OnGUI()
    {
    }

    [Token(Token = "0x60197F6")]
    [Address(RVA = "0x3745938", Offset = "0x3745938", VA = "0x3745938")]
    private void Start()
    {
    }

    [Token(Token = "0x60197F7")]
    [Address(RVA = "0x3745B78", Offset = "0x3745B78", VA = "0x3745B78")]
    private void Update()
    {
    }

    [Token(Token = "0x60197F8")]
    [Address(RVA = "0x3745CC8", Offset = "0x3745CC8", VA = "0x3745CC8")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x60197F9")]
    [Address(RVA = "0x37458A4", Offset = "0x37458A4", VA = "0x37458A4")]
    private Vector3 Rotation2UnitDirectionVector(Quaternion target, float dirPower)
    {
      return new Vector3();
    }

    [Token(Token = "0x60197FA")]
    [Address(RVA = "0x3745E10", Offset = "0x3745E10", VA = "0x3745E10")]
    public WindViewer()
    {
    }

    [Token(Token = "0x2003F1D")]
    private enum WindType
    {
      [Token(Token = "0x40114BD")] Environmental,
      [Token(Token = "0x40114BE")] CircularSpread,
    }
  }
}
