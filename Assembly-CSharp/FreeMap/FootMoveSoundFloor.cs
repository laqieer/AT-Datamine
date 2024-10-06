// Decompiled with JetBrains decompiler
// Type: FreeMap.FootMoveSoundFloor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace FreeMap
{
  [Token(Token = "0x20015DF")]
  public class FootMoveSoundFloor : MonoBehaviour
  {
    [Token(Token = "0x40063C5")]
    [FieldOffset(Offset = "0x18")]
    [NonSerialized]
    public bool showGizmos;
    [Token(Token = "0x40063C6")]
    [FieldOffset(Offset = "0x1C")]
    [NonSerialized]
    public Color gizmosColor;

    [Token(Token = "0x17001303")]
    public string SoundName
    {
      [Token(Token = "0x6007B9F"), Address(RVA = "0x22A3164", Offset = "0x22A3164", VA = "0x22A3164")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6007BA0")]
    [Address(RVA = "0x22A2DC8", Offset = "0x22A2DC8", VA = "0x22A2DC8")]
    public void SwitchAudioGameObject(GameObject sourceGo)
    {
    }

    [Token(Token = "0x6007BA1")]
    [Address(RVA = "0x22A3208", Offset = "0x22A3208", VA = "0x22A3208")]
    private void OnDrawGizmos()
    {
    }

    [Token(Token = "0x6007BA2")]
    [Address(RVA = "0x22A3430", Offset = "0x22A3430", VA = "0x22A3430")]
    public FootMoveSoundFloor()
    {
    }
  }
}
