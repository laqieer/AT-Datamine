// Decompiled with JetBrains decompiler
// Type: DuelFlyingObjectController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000129")]
public class DuelFlyingObjectController : MonoBehaviour
{
  [Token(Token = "0x4000638")]
  [FieldOffset(Offset = "0x1C")]
  private Vector3 velocity;
  [Token(Token = "0x4000639")]
  [FieldOffset(Offset = "0x28")]
  private Vector3 fromPosition;
  [Token(Token = "0x400063A")]
  [FieldOffset(Offset = "0x34")]
  private Vector3 toPosition;
  [Token(Token = "0x400063B")]
  [FieldOffset(Offset = "0x40")]
  private float destroyDelay;

  [Token(Token = "0x17000076")]
  public bool IsFlying
  {
    [Token(Token = "0x6000816"), Address(RVA = "0x485D9F0", Offset = "0x485D9F0", VA = "0x485D9F0")] private set
    {
    }
    [Token(Token = "0x6000817"), Address(RVA = "0x485D9FC", Offset = "0x485D9FC", VA = "0x485D9FC")] get
    {
      return new bool();
    }
  }

  [Token(Token = "0x6000818")]
  [Address(RVA = "0x485DA04", Offset = "0x485DA04", VA = "0x485DA04")]
  public void Throw(Vector3 fromPosition, Vector3 toPosition, float speed, float destroyDelay)
  {
  }

  [Token(Token = "0x6000819")]
  [Address(RVA = "0x485DC60", Offset = "0x485DC60", VA = "0x485DC60")]
  private void Start()
  {
  }

  [Token(Token = "0x600081A")]
  [Address(RVA = "0x485DC64", Offset = "0x485DC64", VA = "0x485DC64")]
  private void FixedUpdate()
  {
  }

  [Token(Token = "0x600081B")]
  [Address(RVA = "0x485DD88", Offset = "0x485DD88", VA = "0x485DD88")]
  private IEnumerator DestroyFlyingObjectWithDelay() => (IEnumerator) null;

  [Token(Token = "0x600081C")]
  [Address(RVA = "0x485DB94", Offset = "0x485DB94", VA = "0x485DB94")]
  public void PlayParticleEffect()
  {
  }

  [Token(Token = "0x600081D")]
  [Address(RVA = "0x485DE18", Offset = "0x485DE18", VA = "0x485DE18")]
  public DuelFlyingObjectController()
  {
  }
}
