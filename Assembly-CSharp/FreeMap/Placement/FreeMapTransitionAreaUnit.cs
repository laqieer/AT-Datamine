// Decompiled with JetBrains decompiler
// Type: FreeMap.Placement.FreeMapTransitionAreaUnit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace FreeMap.Placement
{
  [Token(Token = "0x200185B")]
  [RequireComponent(typeof (Rigidbody))]
  public class FreeMapTransitionAreaUnit : MonoBehaviour
  {
    [Token(Token = "0x4006A27")]
    [FieldOffset(Offset = "0x20")]
    private IFreeMapTransitionAreaFxController[] fxControllers;
    [Token(Token = "0x4006A28")]
    [FieldOffset(Offset = "0x28")]
    public UnityAction<string, Collider> OnEnterCollision;
    [Token(Token = "0x4006A29")]
    [FieldOffset(Offset = "0x30")]
    public UnityAction<string, Collider> OnStayCollision;
    [Token(Token = "0x4006A2A")]
    [FieldOffset(Offset = "0x38")]
    public UnityAction<string, Collider> OnExitCollision;

    [Token(Token = "0x170015BD")]
    public bool IsViewFx
    {
      [Token(Token = "0x60089BB"), Address(RVA = "0x451D5C0", Offset = "0x451D5C0", VA = "0x451D5C0")] private set
      {
      }
      [Token(Token = "0x60089BC"), Address(RVA = "0x451D5CC", Offset = "0x451D5CC", VA = "0x451D5CC")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x60089BD")]
    [Address(RVA = "0x451D5D4", Offset = "0x451D5D4", VA = "0x451D5D4")]
    public static void InitializeRigidbody(Rigidbody rigidbody)
    {
    }

    [Token(Token = "0x60089BE")]
    [Address(RVA = "0x451D668", Offset = "0x451D668", VA = "0x451D668")]
    public void SetViewFx(bool isView, bool isTransition, bool isForce)
    {
    }

    [Token(Token = "0x60089BF")]
    [Address(RVA = "0x451D7C8", Offset = "0x451D7C8", VA = "0x451D7C8")]
    public void SetActiveFreeMapTransitionAreaUnit(bool active)
    {
    }

    [Token(Token = "0x60089C0")]
    [Address(RVA = "0x451DAC0", Offset = "0x451DAC0", VA = "0x451DAC0")]
    private void Awake()
    {
    }

    [Token(Token = "0x60089C1")]
    [Address(RVA = "0x451DB3C", Offset = "0x451DB3C", VA = "0x451DB3C")]
    private void OnTriggerEnter(Collider other)
    {
    }

    [Token(Token = "0x60089C2")]
    [Address(RVA = "0x451DB98", Offset = "0x451DB98", VA = "0x451DB98")]
    private void OnTriggerStay(Collider other)
    {
    }

    [Token(Token = "0x60089C3")]
    [Address(RVA = "0x451DBF4", Offset = "0x451DBF4", VA = "0x451DBF4")]
    private void OnTriggerExit(Collider other)
    {
    }

    [Token(Token = "0x60089C4")]
    [Address(RVA = "0x451DC50", Offset = "0x451DC50", VA = "0x451DC50")]
    public FreeMapTransitionAreaUnit()
    {
    }
  }
}
