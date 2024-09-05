// Decompiled with JetBrains decompiler
// Type: Area.AreaMoveSpeedCorrection
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Area
{
  [Token(Token = "0x2002821")]
  public class AreaMoveSpeedCorrection : MonoBehaviour
  {
    [Token(Token = "0x400AB3B")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    protected float playerSpeedMagnification;
    [Token(Token = "0x400AB3C")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    protected float playerWalkAnimationSpeed;
    [Token(Token = "0x400AB3D")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    protected float playerRunAnimationSpeed;

    [Token(Token = "0x1700377C")]
    public float PlayerSpeedMagnification
    {
      [Token(Token = "0x600FC93"), Address(RVA = "0x4425174", Offset = "0x4425174", VA = "0x4425174")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x1700377D")]
    public float PlayerWalkAnimationSpeed
    {
      [Token(Token = "0x600FC94"), Address(RVA = "0x442517C", Offset = "0x442517C", VA = "0x442517C")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x1700377E")]
    public float PlayerRunAnimationSpeed
    {
      [Token(Token = "0x600FC95"), Address(RVA = "0x4425184", Offset = "0x4425184", VA = "0x4425184")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x600FC96")]
    [Address(RVA = "0x442518C", Offset = "0x442518C", VA = "0x442518C")]
    public AreaMoveSpeedCorrection()
    {
    }
  }
}
