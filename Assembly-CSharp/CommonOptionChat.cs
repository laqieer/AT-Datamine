// Decompiled with JetBrains decompiler
// Type: CommonOptionChat
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x2000292")]
public class CommonOptionChat : MonoBehaviour
{
  [Token(Token = "0x4000F2F")]
  [FieldOffset(Offset = "0x18")]
  private bool isLoadedAssetBundle;
  [Token(Token = "0x4000F30")]
  [FieldOffset(Offset = "0x20")]
  private GameObject optionChatFixedPhraseItem;
  [Token(Token = "0x4000F31")]
  [FieldOffset(Offset = "0x28")]
  [SerializeField]
  private ScrollRect scrollRect;
  [Token(Token = "0x4000F32")]
  [FieldOffset(Offset = "0x30")]
  [SerializeField]
  private Toggle chatSystemToggle;
  [Token(Token = "0x4000F33")]
  [FieldOffset(Offset = "0x38")]
  public Action OnFixedPhraseSettingFinnish;
  [Token(Token = "0x4000F34")]
  public const string SubSceneAssetBundleName = "2dassets_ui_common";
  [Token(Token = "0x4000F35")]
  public const string LOAD_PREFAB_FIXED_PHRASE_LIST_ITEM = "Common_Option_Chat_FixedPhrase_Item";

  [Token(Token = "0x6000FF6")]
  [Address(RVA = "0x1BE4150", Offset = "0x1BE4150", VA = "0x1BE4150")]
  public void Initialize()
  {
  }

  [Token(Token = "0x6000FF7")]
  [Address(RVA = "0x1BE41D8", Offset = "0x1BE41D8", VA = "0x1BE41D8")]
  private IEnumerator LoadWaitByAssetBundle(string label, Action<string, bool> successAction)
  {
    return (IEnumerator) null;
  }

  [Token(Token = "0x6000FF8")]
  [Address(RVA = "0x1BE4170", Offset = "0x1BE4170", VA = "0x1BE4170")]
  private IEnumerator InitializeAsync() => (IEnumerator) null;

  [Token(Token = "0x6000FF9")]
  [Address(RVA = "0x1BE42A4", Offset = "0x1BE42A4", VA = "0x1BE42A4")]
  public void SetPlayerStampList()
  {
  }

  [Token(Token = "0x6000FFA")]
  [Address(RVA = "0x1BE466C", Offset = "0x1BE466C", VA = "0x1BE466C")]
  public void SetScrollBarState(bool state)
  {
  }

  [Token(Token = "0x6000FFB")]
  [Address(RVA = "0x1BE46D4", Offset = "0x1BE46D4", VA = "0x1BE46D4")]
  public CommonOptionChat()
  {
  }
}
