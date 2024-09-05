// Decompiled with JetBrains decompiler
// Type: Area.AreaComponentAccessor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Area.FadeContent;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Area
{
  [Token(Token = "0x2002820")]
  public class AreaComponentAccessor : MonoBehaviour
  {
    [Token(Token = "0x400AB37")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    protected Camera linkCamera;
    [Token(Token = "0x400AB38")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    protected AreaFadeContentManager fadeContentManager;
    [Token(Token = "0x400AB39")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private AreaMoveSpeedCorrection moveSpeedCorrection;
    [Token(Token = "0x400AB3A")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject globalVolumeGameObject;

    [Token(Token = "0x17003778")]
    public Camera LinkCamera
    {
      [Token(Token = "0x600FC8D"), Address(RVA = "0x4425118", Offset = "0x4425118", VA = "0x4425118")] get
      {
        return (Camera) null;
      }
    }

    [Token(Token = "0x17003779")]
    public AreaFadeContentManager FadeContentManager
    {
      [Token(Token = "0x600FC8E"), Address(RVA = "0x4425120", Offset = "0x4425120", VA = "0x4425120")] get
      {
        return (AreaFadeContentManager) null;
      }
    }

    [Token(Token = "0x1700377A")]
    public AreaMoveSpeedCorrection MoveSpeedCorrection
    {
      [Token(Token = "0x600FC8F"), Address(RVA = "0x4425128", Offset = "0x4425128", VA = "0x4425128")] get
      {
        return (AreaMoveSpeedCorrection) null;
      }
    }

    [Token(Token = "0x1700377B")]
    public GameObject GlobalVolumeGameObject
    {
      [Token(Token = "0x600FC90"), Address(RVA = "0x4425130", Offset = "0x4425130", VA = "0x4425130")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x600FC91")]
    [Address(RVA = "0x4425138", Offset = "0x4425138", VA = "0x4425138")]
    private void Awake()
    {
    }

    [Token(Token = "0x600FC92")]
    [Address(RVA = "0x442516C", Offset = "0x442516C", VA = "0x442516C")]
    public AreaComponentAccessor()
    {
    }
  }
}
