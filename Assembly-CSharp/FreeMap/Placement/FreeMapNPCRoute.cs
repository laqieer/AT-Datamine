// Decompiled with JetBrains decompiler
// Type: FreeMap.Placement.FreeMapNPCRoute
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace FreeMap.Placement
{
  [Token(Token = "0x2001855")]
  public class FreeMapNPCRoute : MonoBehaviour
  {
    [Token(Token = "0x4006A10")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private List<Transform> naviPoints;
    [Token(Token = "0x4006A11")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private bool enableLoop;
    [Token(Token = "0x4006A12")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private float maxDistance;

    [Token(Token = "0x170015B2")]
    public bool EnableLoop
    {
      [Token(Token = "0x600898C"), Address(RVA = "0x43E5CB8", Offset = "0x43E5CB8", VA = "0x43E5CB8")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170015B3")]
    public int MaxLength
    {
      [Token(Token = "0x600898D"), Address(RVA = "0x43E5CC0", Offset = "0x43E5CC0", VA = "0x43E5CC0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600898E")]
    [Address(RVA = "0x43E5D08", Offset = "0x43E5D08", VA = "0x43E5D08")]
    public bool GetArrival(int index, Vector3 nowPos) => new bool();

    [Token(Token = "0x600898F")]
    [Address(RVA = "0x43E5E08", Offset = "0x43E5E08", VA = "0x43E5E08")]
    public Transform GetNaviPoint(int index) => (Transform) null;

    [Token(Token = "0x6008990")]
    [Address(RVA = "0x43E5E90", Offset = "0x43E5E90", VA = "0x43E5E90")]
    public FreeMapNPCRoute()
    {
    }
  }
}
