// Decompiled with JetBrains decompiler
// Type: Direction.Subtitles.SubtitlesSettings
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Direction.Subtitles
{
  [Token(Token = "0x2001F27")]
  [CreateAssetMenu(menuName = "Movie/SubtitleSettings")]
  public class SubtitlesSettings : ScriptableObject
  {
    [Token(Token = "0x40085A0")]
    [FieldOffset(Offset = "0x18")]
    public SubtitleData[] DataList;

    [Token(Token = "0x600B8FF")]
    [Address(RVA = "0x2138AFC", Offset = "0x2138AFC", VA = "0x2138AFC")]
    public SubtitlesSettings()
    {
    }
  }
}
