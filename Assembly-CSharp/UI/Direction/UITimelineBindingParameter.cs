// Decompiled with JetBrains decompiler
// Type: UI.Direction.UITimelineBindingParameter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace UI.Direction
{
  [Token(Token = "0x20008ED")]
  [Serializable]
  public class UITimelineBindingParameter
  {
    [Token(Token = "0x40029C4")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    [Tooltip("PlayableDirectorから対象オブジェクトまでの相対パス名\n未アタッチの場合\"None\"の識別子を自動入力します")]
    public string objectPath;
    [Token(Token = "0x40029C5")]
    [FieldOffset(Offset = "0x18")]
    [Tooltip("トラックの種類")]
    [SerializeField]
    public UITimelineBindingParameter.TrackType type;
    [Token(Token = "0x40029C6")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    [Tooltip("トラックのオブジェクトにアタッチしているアセットの情報")]
    public List<UITimelineBindingComponentAssetBundle> componentAsset;

    [Token(Token = "0x600327B")]
    [Address(RVA = "0x3C22FD8", Offset = "0x3C22FD8", VA = "0x3C22FD8")]
    public UITimelineBindingParameter()
    {
    }

    [Token(Token = "0x20008EE")]
    public enum TrackType
    {
      [Token(Token = "0x40029C8")] AnimationTrack,
      [Token(Token = "0x40029C9")] UIShaderTrack,
      [Token(Token = "0x40029CA")] RendererShaderTrack,
      [Token(Token = "0x40029CB")] ActivationTrack,
      [Token(Token = "0x40029CC")] SignalTrack,
      [Token(Token = "0x40029CD")] UnnecessaryTrack,
    }
  }
}
