// Decompiled with JetBrains decompiler
// Type: Area.CameraEditor.AreaCameraEditor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Area.CameraEditor.Model;
using FreeMap;
using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace Area.CameraEditor
{
  [Token(Token = "0x2002855")]
  public class AreaCameraEditor : MonoBehaviour
  {
    [Token(Token = "0x400ABE4")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject rootObject;
    [Token(Token = "0x400ABE5")]
    [FieldOffset(Offset = "0x20")]
    private GameObject cacheObject;
    [Token(Token = "0x400ABE8")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    protected PositionData positionData;
    [Token(Token = "0x400ABE9")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    protected CameraData cameraData;

    [Token(Token = "0x170037EE")]
    public FreeMapCommonElement Element
    {
      [Token(Token = "0x600FE04"), Address(RVA = "0x44339C0", Offset = "0x44339C0", VA = "0x44339C0")] private set
      {
      }
      [Token(Token = "0x600FE05"), Address(RVA = "0x44339C8", Offset = "0x44339C8", VA = "0x44339C8")] get
      {
        return (FreeMapCommonElement) null;
      }
    }

    [Token(Token = "0x170037EF")]
    public InstanceManager InstanceManager
    {
      [Token(Token = "0x600FE06"), Address(RVA = "0x44339D0", Offset = "0x44339D0", VA = "0x44339D0")] private set
      {
      }
      [Token(Token = "0x600FE07"), Address(RVA = "0x44339D8", Offset = "0x44339D8", VA = "0x44339D8")] get
      {
        return (InstanceManager) null;
      }
    }

    [Token(Token = "0x170037F0")]
    public PositionData PositionData
    {
      [Token(Token = "0x600FE08"), Address(RVA = "0x44339E0", Offset = "0x44339E0", VA = "0x44339E0")] get
      {
        return (PositionData) null;
      }
    }

    [Token(Token = "0x170037F1")]
    public CameraData CameraData
    {
      [Token(Token = "0x600FE09"), Address(RVA = "0x44339E8", Offset = "0x44339E8", VA = "0x44339E8")] get
      {
        return (CameraData) null;
      }
    }

    [Token(Token = "0x600FE0A")]
    [Address(RVA = "0x44339F0", Offset = "0x44339F0", VA = "0x44339F0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600FE0B")]
    [Address(RVA = "0x4433C54", Offset = "0x4433C54", VA = "0x4433C54")]
    private IEnumerator Start() => (IEnumerator) null;

    [Token(Token = "0x600FE0C")]
    [Address(RVA = "0x4433CE4", Offset = "0x4433CE4", VA = "0x4433CE4")]
    private void Update()
    {
    }

    [Token(Token = "0x600FE0D")]
    [Address(RVA = "0x4433D48", Offset = "0x4433D48", VA = "0x4433D48")]
    public AreaCameraEditor()
    {
    }
  }
}
