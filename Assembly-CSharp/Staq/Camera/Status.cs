// Decompiled with JetBrains decompiler
// Type: staq.Camera.Status
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace staq.Camera
{
  [Token(Token = "0x2003D79")]
  public class Status
  {
    [Token(Token = "0x4010DFA")]
    [FieldOffset(Offset = "0x10")]
    private Vector3 position;
    [Token(Token = "0x4010DFB")]
    [FieldOffset(Offset = "0x1C")]
    private Quaternion rotate;
    [Token(Token = "0x4010DFC")]
    [FieldOffset(Offset = "0x2C")]
    protected bool positionDirty;
    [Token(Token = "0x4010DFD")]
    [FieldOffset(Offset = "0x2D")]
    protected bool rotateDirty;
    [Token(Token = "0x4010DFE")]
    [FieldOffset(Offset = "0x30")]
    private float fieldOfView;
    [Token(Token = "0x4010DFF")]
    [FieldOffset(Offset = "0x34")]
    protected bool fieldOfViewDirty;

    [Token(Token = "0x6018B9F")]
    [Address(RVA = "0x264728C", Offset = "0x264728C", VA = "0x264728C")]
    public Status()
    {
    }

    [Token(Token = "0x6018BA0")]
    [Address(RVA = "0x26472B4", Offset = "0x26472B4", VA = "0x26472B4", Slot = "4")]
    public virtual void GetRotate(out Quaternion outputRotate)
    {
    }

    [Token(Token = "0x6018BA1")]
    [Address(RVA = "0x26472C0", Offset = "0x26472C0", VA = "0x26472C0", Slot = "5")]
    public virtual void GetPosition(out Vector3 outputPosition)
    {
    }

    [Token(Token = "0x6018BA2")]
    [Address(RVA = "0x26472D4", Offset = "0x26472D4", VA = "0x26472D4", Slot = "6")]
    public virtual float GetFieldOfView() => new float();

    [Token(Token = "0x6018BA3")]
    [Address(RVA = "0x26472DC", Offset = "0x26472DC", VA = "0x26472DC")]
    public void SetRotate(ref Quaternion inputRotate)
    {
    }

    [Token(Token = "0x6018BA4")]
    [Address(RVA = "0x26472EC", Offset = "0x26472EC", VA = "0x26472EC")]
    public void SetPosition(ref Vector3 inputPosition)
    {
    }

    [Token(Token = "0x6018BA5")]
    [Address(RVA = "0x2647304", Offset = "0x2647304", VA = "0x2647304")]
    public void SetFieldOfView(float inputFieldOfView)
    {
    }

    [Token(Token = "0x6018BA6")]
    [Address(RVA = "0x2647310", Offset = "0x2647310", VA = "0x2647310", Slot = "7")]
    public virtual void Update(float deltaTime)
    {
    }

    [Token(Token = "0x6018BA7")]
    [Address(RVA = "0x2647314", Offset = "0x2647314", VA = "0x2647314", Slot = "8")]
    public virtual void SetFocusPosition(Vector3Base position, bool move)
    {
    }

    [Token(Token = "0x6018BA8")]
    [Address(RVA = "0x2647318", Offset = "0x2647318", VA = "0x2647318", Slot = "9")]
    public virtual void StartSwipe(Vector3Base position)
    {
    }

    [Token(Token = "0x6018BA9")]
    [Address(RVA = "0x264731C", Offset = "0x264731C", VA = "0x264731C", Slot = "10")]
    public virtual bool GetWaitIdle() => new bool();

    [Token(Token = "0x6018BAA")]
    [Address(RVA = "0x2647324", Offset = "0x2647324", VA = "0x2647324", Slot = "11")]
    public virtual bool GetDirty() => new bool();

    [Token(Token = "0x6018BAB")]
    [Address(RVA = "0x264734C", Offset = "0x264734C", VA = "0x264734C", Slot = "12")]
    public virtual void SetDirty(bool value)
    {
    }

    [Token(Token = "0x6018BAC")]
    [Address(RVA = "0x2647360", Offset = "0x2647360", VA = "0x2647360", Slot = "13")]
    public virtual void GetCamera(ref UnityEngine.Camera camera)
    {
    }
  }
}
