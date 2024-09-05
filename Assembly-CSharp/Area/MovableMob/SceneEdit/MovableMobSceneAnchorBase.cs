// Decompiled with JetBrains decompiler
// Type: Area.MovableMob.SceneEdit.MovableMobSceneAnchorBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Area.MovableMob.Data;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Area.MovableMob.SceneEdit
{
  [Token(Token = "0x2002832")]
  public abstract class MovableMobSceneAnchorBase : MonoBehaviour
  {
    [Token(Token = "0x400AB6F")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    protected float fadeRadius;
    [Token(Token = "0x400AB70")]
    private const float ArrowAngle = 30f;
    [Token(Token = "0x400AB71")]
    private const float AnchorRadius = 0.1f;

    [Token(Token = "0x1700379C")]
    public float FadeRadius
    {
      [Token(Token = "0x600FD04"), Address(RVA = "0x442B714", Offset = "0x442B714", VA = "0x442B714")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x1700379D")]
    public Vector3 AnchorPosition
    {
      [Token(Token = "0x600FD05"), Address(RVA = "0x442B448", Offset = "0x442B448", VA = "0x442B448")] get
      {
        return new Vector3();
      }
    }

    [Token(Token = "0x600FD06")]
    public abstract IMovableMobAnchorData CreateAnchorData();

    [Token(Token = "0x600FD07")]
    public abstract void DrawRouteGizmos(MovableMobSceneAnchorBase nextAnchor, Color color);

    [Token(Token = "0x600FD08")]
    [Address(RVA = "0x442B71C", Offset = "0x442B71C", VA = "0x442B71C")]
    public void DrawFadeSphere(Color color)
    {
    }

    [Token(Token = "0x600FD09")]
    [Address(RVA = "0x442B7B4", Offset = "0x442B7B4", VA = "0x442B7B4")]
    public void DrawAnchorSphere(Color color)
    {
    }

    [Token(Token = "0x600FD0A")]
    [Address(RVA = "0x442B468", Offset = "0x442B468", VA = "0x442B468")]
    protected void DrawAnchorArrow(Vector3 endPos, Vector3 direction, Color color)
    {
    }

    [Token(Token = "0x600FD0B")]
    [Address(RVA = "0x442B70C", Offset = "0x442B70C", VA = "0x442B70C")]
    protected MovableMobSceneAnchorBase()
    {
    }
  }
}
