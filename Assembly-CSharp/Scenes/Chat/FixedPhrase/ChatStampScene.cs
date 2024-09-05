// Decompiled with JetBrains decompiler
// Type: Scenes.Chat.FixedPhrase.ChatStampScene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.OutGame.ChatInfo;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Chat.FixedPhrase
{
  [Token(Token = "0x20030D3")]
  public class ChatStampScene : MonoBehaviour
  {
    [Token(Token = "0x400CFAB")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ScrollRect scrollRect;
    [Token(Token = "0x400CFAC")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Button canclebtn;
    [Token(Token = "0x400CFAD")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Button sendbtn;
    [Token(Token = "0x400CFAE")]
    [FieldOffset(Offset = "0x30")]
    private bool isLoadedAssetBundle;
    [Token(Token = "0x400CFAF")]
    [FieldOffset(Offset = "0x38")]
    private ChatFixedPhraseSceneManager fixedPhraseScene;
    [Token(Token = "0x400CFB0")]
    [FieldOffset(Offset = "0x40")]
    private GameObject chatStampItem;
    [Token(Token = "0x400CFB1")]
    [FieldOffset(Offset = "0x48")]
    private int currStampID;
    [Token(Token = "0x400CFB2")]
    [FieldOffset(Offset = "0x50")]
    private ChatInfoLoader infoLoader;
    [Token(Token = "0x400CFB3")]
    public const string SubSceneAssetBundleName = "page_chat_chatdialog";
    [Token(Token = "0x400CFB4")]
    public const string LOAD_PREFAB_CHAT_LIST_ITEM = "ChatStampItem";

    [Token(Token = "0x601311A")]
    [Address(RVA = "0x45D5B5C", Offset = "0x45D5B5C", VA = "0x45D5B5C")]
    public void Show(ChatFixedPhraseSceneManager mainScene)
    {
    }

    [Token(Token = "0x601311B")]
    [Address(RVA = "0x45D5C20", Offset = "0x45D5C20", VA = "0x45D5C20")]
    public IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x601311C")]
    [Address(RVA = "0x45D5CB0", Offset = "0x45D5CB0", VA = "0x45D5CB0")]
    public void SetPlayerStampList()
    {
    }

    [Token(Token = "0x601311D")]
    [Address(RVA = "0x45D6028", Offset = "0x45D6028", VA = "0x45D6028")]
    public ChatStampScene()
    {
    }
  }
}
