// Decompiled with JetBrains decompiler
// Type: Test
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

#nullable disable
[Token(Token = "0x200031F")]
public class Test : MonoBehaviour
{
  [Token(Token = "0x400129B")]
  [FieldOffset(Offset = "0x18")]
  [SerializeField]
  private VideoPlayer videoPlayer;

  [Token(Token = "0x60012BA")]
  [Address(RVA = "0x285D2A4", Offset = "0x285D2A4", VA = "0x285D2A4")]
  private void Start()
  {
  }

  [Token(Token = "0x60012BB")]
  [Address(RVA = "0x285D698", Offset = "0x285D698", VA = "0x285D698")]
  private void LoadAssetError(string message)
  {
  }

  [Token(Token = "0x60012BC")]
  [Address(RVA = "0x285D69C", Offset = "0x285D69C", VA = "0x285D69C")]
  private void LoadComplete(
    List<string> successList,
    Dictionary<string, string> loadErrorAssetBundleDic)
  {
  }

  [Token(Token = "0x60012BD")]
  [Address(RVA = "0x285D51C", Offset = "0x285D51C", VA = "0x285D51C")]
  private void PlayMovie()
  {
  }

  [Token(Token = "0x60012BE")]
  [Address(RVA = "0x285D7B8", Offset = "0x285D7B8", VA = "0x285D7B8")]
  public Test()
  {
  }
}
