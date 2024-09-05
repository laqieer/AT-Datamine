// Decompiled with JetBrains decompiler
// Type: staq.Camera.Vector3Base
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace staq.Camera
{
  [Token(Token = "0x2003D7B")]
  public class Vector3Base : Geometry
  {
    [Token(Token = "0x4010E06")]
    [FieldOffset(Offset = "0x10")]
    protected Vector3 vectorValue;
    [Token(Token = "0x4010E07")]
    [FieldOffset(Offset = "0x1C")]
    private bool valueDirty;

    [Token(Token = "0x6018BBD")]
    [Address(RVA = "0x2647E24", Offset = "0x2647E24", VA = "0x2647E24")]
    public Vector3Base()
    {
    }

    [Token(Token = "0x6018BBE")]
    [Address(RVA = "0x2647E8C", Offset = "0x2647E8C", VA = "0x2647E8C", Slot = "7")]
    public virtual void GetValue(out Vector3 outputValue)
    {
    }

    [Token(Token = "0x6018BBF")]
    [Address(RVA = "0x2647EA0", Offset = "0x2647EA0", VA = "0x2647EA0")]
    public void SetValue(ref Vector3 inputValue)
    {
    }

    [Token(Token = "0x6018BC0")]
    [Address(RVA = "0x2647EB8", Offset = "0x2647EB8", VA = "0x2647EB8", Slot = "8")]
    public virtual bool GetDirty() => new bool();

    [Token(Token = "0x6018BC1")]
    [Address(RVA = "0x2647EC0", Offset = "0x2647EC0", VA = "0x2647EC0", Slot = "5")]
    public override void SetDirty(bool dirty)
    {
    }

    [Token(Token = "0x6018BC2")]
    [Address(RVA = "0x2647ECC", Offset = "0x2647ECC", VA = "0x2647ECC", Slot = "9")]
    public virtual Vector3Base GetDestination() => (Vector3Base) null;

    [Token(Token = "0x6018BC3")]
    [Address(RVA = "0x2647ED0", Offset = "0x2647ED0", VA = "0x2647ED0", Slot = "10")]
    public virtual bool CompareEqual(Vector3Base other) => new bool();

    [Token(Token = "0x6018BC4")]
    [Address(RVA = "0x2647ED8", Offset = "0x2647ED8", VA = "0x2647ED8", Slot = "11")]
    public virtual bool GetWaitIdle() => new bool();

    [Token(Token = "0x6018BC5")]
    [Address(RVA = "0x2647EE0", Offset = "0x2647EE0", VA = "0x2647EE0", Slot = "12")]
    public virtual void SetOnMoveFinish(Action<Vector3> onMoveFinish)
    {
    }
  }
}
