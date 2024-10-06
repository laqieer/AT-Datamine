// Decompiled with JetBrains decompiler
// Type: WindAnimation.WindSettingsAsset
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace WindAnimation
{
  [Token(Token = "0x2003F1A")]
  [CreateAssetMenu(menuName = "Wind/Wind Settings Asset")]
  public class WindSettingsAsset : ScriptableObject
  {
    [Token(Token = "0x40114A4")]
    [FieldOffset(Offset = "0x18")]
    public WindPowerParameterRange windPowerParamRange;

    [Token(Token = "0x60197F2")]
    [Address(RVA = "0x3744C70", Offset = "0x3744C70", VA = "0x3744C70")]
    public WindSettingsAsset()
    {
    }
  }
}
