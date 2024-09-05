// Decompiled with JetBrains decompiler
// Type: UI.Direction.UITimelineSettingAsset
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace UI.Direction
{
  [Token(Token = "0x200090A")]
  [CreateAssetMenu(menuName = "staq/UITimeline/Settings Asset")]
  public class UITimelineSettingAsset : ScriptableObject
  {
    [Token(Token = "0x4002A3A")]
    [FieldOffset(Offset = "0x18")]
    public List<UITimelineSettingParameter> parameters;
    [Token(Token = "0x4002A3B")]
    [FieldOffset(Offset = "0x20")]
    public bool isResources;

    [Token(Token = "0x600330D")]
    [Address(RVA = "0x3624070", Offset = "0x3624070", VA = "0x3624070")]
    public UITimelineSettingAsset()
    {
    }
  }
}
