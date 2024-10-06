// Decompiled with JetBrains decompiler
// Type: FreeMap.AkTriggerEventList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

#nullable disable
namespace FreeMap
{
  [Token(Token = "0x20015F2")]
  public class AkTriggerEventList : MonoBehaviour
  {
    [Token(Token = "0x400641B")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private List<AkTriggerBase> akTriggerList;

    [Token(Token = "0x6007C31")]
    [Address(RVA = "0x219F58C", Offset = "0x219F58C", VA = "0x219F58C")]
    [Conditional("UNITY_EDITOR")]
    public void SetAkTrigerList(IEnumerable<AkTriggerBase> akTriggerList)
    {
    }

    [Token(Token = "0x6007C32")]
    [Address(RVA = "0x219F610", Offset = "0x219F610", VA = "0x219F610")]
    public void SetPlayerObject(GameObject playerObj)
    {
    }

    [Token(Token = "0x6007C33")]
    [Address(RVA = "0x219F8E8", Offset = "0x219F8E8", VA = "0x219F8E8")]
    public AkTriggerEventList()
    {
    }
  }
}
