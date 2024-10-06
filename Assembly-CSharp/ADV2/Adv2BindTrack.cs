// Decompiled with JetBrains decompiler
// Type: ADV2.Adv2BindTrack
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

#nullable disable
namespace ADV2
{
  [Token(Token = "0x2003E60")]
  [DisallowMultipleComponent]
  public class Adv2BindTrack : MonoBehaviour
  {
    [Token(Token = "0x40111C5")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private List<string> additiveSceneList;
    [Token(Token = "0x40111C6")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private List<Adv2BindTrack.BindData> bindDataList;

    [Token(Token = "0x60191B5")]
    [Address(RVA = "0x2CF0D70", Offset = "0x2CF0D70", VA = "0x2CF0D70")]
    public void BindGameObject(PlayableDirector playable)
    {
    }

    [Token(Token = "0x60191B6")]
    [Address(RVA = "0x2CF12F4", Offset = "0x2CF12F4", VA = "0x2CF12F4")]
    public Adv2BindTrack()
    {
    }

    [Token(Token = "0x2003E61")]
    [Serializable]
    public class BindData
    {
      [Token(Token = "0x40111C7")]
      [FieldOffset(Offset = "0x10")]
      public string trackName;
      [Token(Token = "0x40111C8")]
      [FieldOffset(Offset = "0x18")]
      public string ObjectName;

      [Token(Token = "0x60191B7")]
      [Address(RVA = "0x2CF13B4", Offset = "0x2CF13B4", VA = "0x2CF13B4")]
      public BindData()
      {
      }
    }
  }
}
