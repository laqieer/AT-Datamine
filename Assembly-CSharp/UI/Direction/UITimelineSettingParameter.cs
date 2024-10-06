// Decompiled with JetBrains decompiler
// Type: UI.Direction.UITimelineSettingParameter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

#nullable disable
namespace UI.Direction
{
  [Token(Token = "0x200090B")]
  [Serializable]
  public class UITimelineSettingParameter
  {
    [Token(Token = "0x4002A3C")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    [Tooltip("キー名\n空文字の場合、警告ログを表示してタイムラインアセット名に置き換えます")]
    public string keyName;
    [Token(Token = "0x4002A3D")]
    [FieldOffset(Offset = "0x18")]
    [Tooltip("演出タイプ\nIn「フェードイン」/Out「フェードアウト」/General「汎用」")]
    [SerializeField]
    public UITimelineSettingParameter.DirectionType type;
    [Token(Token = "0x4002A3E")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    [Tooltip("PlayableDirectorのオブジェクト名\nPlayableDirectorが複数ある場合に識別するので、単体の場合は空文字で問題ありません")]
    public string playableDirectorName;
    [Token(Token = "0x4002A3F")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    [Tooltip("UITimelineBindingAssetのAssetBundle情報")]
    [ResourceType(typeof (UITimelineBindingAsset))]
    public AssetBundleLoadData bindSettingAssetBundleLoad;
    [Token(Token = "0x4002A40")]
    [FieldOffset(Offset = "0x30")]
    [Tooltip("タイムラインアセットに関するAssetBundle情報")]
    [SerializeField]
    [ResourceType(typeof (TimelineAsset))]
    public AssetBundleLoadData timelineAssetBundleLoad;
    [Token(Token = "0x4002A41")]
    [FieldOffset(Offset = "0x38")]
    [ResourceType(typeof (UITimelineBindingAsset))]
    [Tooltip("UITimelineBindingAssetのResources情報")]
    [SerializeField]
    public ResourceLoadData bindSettingResourcesLoad;
    [Token(Token = "0x4002A42")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    [ResourceType(typeof (TimelineAsset))]
    [Tooltip("タイムラインアセットに関するResources情報")]
    public ResourceLoadData timelineResourcesLoad;
    [Token(Token = "0x4002A43")]
    [FieldOffset(Offset = "0x48")]
    [Tooltip("タイムラインアセットのWrapMode")]
    [SerializeField]
    public DirectorWrapMode wrapMode;

    [Token(Token = "0x600330E")]
    [Address(RVA = "0x3624078", Offset = "0x3624078", VA = "0x3624078")]
    public UITimelineSettingParameter()
    {
    }

    [Token(Token = "0x200090C")]
    public enum DirectionType
    {
      [Token(Token = "0x4002A45")] In,
      [Token(Token = "0x4002A46")] Out,
      [Token(Token = "0x4002A47")] General,
    }
  }
}
