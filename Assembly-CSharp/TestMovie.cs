// Decompiled with JetBrains decompiler
// Type: TestMovie
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

#nullable disable
[Token(Token = "0x200031E")]
public class TestMovie : MonoBehaviour
{
  [Token(Token = "0x4001299")]
  [FieldOffset(Offset = "0x18")]
  [SerializeField]
  private VideoPlayer videoPlayer;
  [Token(Token = "0x400129A")]
  private const string ConstMovieName = "3Title_ending_movie.mp4";

  [Token(Token = "0x60012B5")]
  [Address(RVA = "0x285CE90", Offset = "0x285CE90", VA = "0x285CE90")]
  private void Start()
  {
  }

  [Token(Token = "0x60012B6")]
  [Address(RVA = "0x285D020", Offset = "0x285D020", VA = "0x285D020")]
  private void LoadAssetError(string message)
  {
  }

  [Token(Token = "0x60012B7")]
  [Address(RVA = "0x285D024", Offset = "0x285D024", VA = "0x285D024")]
  private void LoadComplete(
    List<string> successList,
    Dictionary<string, string> loadErrorAssetBundleDic)
  {
  }

  [Token(Token = "0x60012B8")]
  [Address(RVA = "0x285D140", Offset = "0x285D140", VA = "0x285D140")]
  private void OnGUI()
  {
  }

  [Token(Token = "0x60012B9")]
  [Address(RVA = "0x285D29C", Offset = "0x285D29C", VA = "0x285D29C")]
  public TestMovie()
  {
  }
}
