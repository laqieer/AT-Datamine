// Decompiled with JetBrains decompiler
// Type: Scenes.Chat.Log.ChatLogScene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.Chat.FixedPhrase;
using Scenes.OutGame.ChatInfo;
using staq.SaveData;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Chat.Log
{
  [Token(Token = "0x20030BE")]
  public class ChatLogScene : MonoBehaviour
  {
    [Token(Token = "0x400CF57")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ScrollRect scrollRect;
    [Token(Token = "0x400CF58")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Button canclebtn;
    [Token(Token = "0x400CF59")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Button sendbtn;
    [Token(Token = "0x400CF5A")]
    [FieldOffset(Offset = "0x30")]
    private bool isLoadedAssetBundle;
    [Token(Token = "0x400CF5B")]
    [FieldOffset(Offset = "0x38")]
    private List<ChatSaveData.ChatSaveLog> chatLogList;
    [Token(Token = "0x400CF5C")]
    [FieldOffset(Offset = "0x40")]
    private ChatFixedPhraseSceneManager fixedPhraseScene;
    [Token(Token = "0x400CF5D")]
    [FieldOffset(Offset = "0x48")]
    private GameObject chatStampItem;
    [Token(Token = "0x400CF5E")]
    [FieldOffset(Offset = "0x50")]
    private string currLogContent;
    [Token(Token = "0x400CF5F")]
    [FieldOffset(Offset = "0x58")]
    private int currLogType;
    [Token(Token = "0x400CF60")]
    [FieldOffset(Offset = "0x60")]
    private ChatInfoLoader infoLoader;
    [Token(Token = "0x400CF61")]
    public const string SubSceneAssetBundleName = "page_chat_chatdialog";
    [Token(Token = "0x400CF62")]
    public const string LOAD_PREFAB_CHAT_LIST_ITEM = "ChatLogItem";

    [Token(Token = "0x60130B2")]
    [Address(RVA = "0x432E00C", Offset = "0x432E00C", VA = "0x432E00C")]
    public void Show(ChatFixedPhraseSceneManager mainScene)
    {
    }

    [Token(Token = "0x60130B3")]
    [Address(RVA = "0x432E0D0", Offset = "0x432E0D0", VA = "0x432E0D0")]
    public IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x60130B4")]
    [Address(RVA = "0x432E160", Offset = "0x432E160", VA = "0x432E160")]
    public void SetLogList()
    {
    }

    [Token(Token = "0x60130B5")]
    [Address(RVA = "0x432E5C8", Offset = "0x432E5C8", VA = "0x432E5C8")]
    public ChatLogScene()
    {
    }
  }
}
