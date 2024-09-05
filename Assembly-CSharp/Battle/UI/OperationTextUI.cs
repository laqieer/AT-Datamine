// Decompiled with JetBrains decompiler
// Type: Battle.UI.OperationTextUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x20022FD")]
  public class OperationTextUI : MonoBehaviour
  {
    [Token(Token = "0x4009410")]
    [FieldOffset(Offset = "0x18")]
    private OperationTextView view;
    [Token(Token = "0x4009411")]
    [FieldOffset(Offset = "0x20")]
    private AssetCachedSpawner spawner;
    [Token(Token = "0x4009412")]
    private const string AssetBundleLabel = "ui_page_ingame_battlecommand_prefab";
    [Token(Token = "0x4009413")]
    private const string AssetName = "Container_Info_Title";
    [Token(Token = "0x4009414")]
    [FieldOffset(Offset = "0x28")]
    private bool isOpenPrefab;

    [Token(Token = "0x600D5DF")]
    [Address(RVA = "0x1D192DC", Offset = "0x1D192DC", VA = "0x1D192DC")]
    public void Initialize(Transform uiRoot, AssetCachedSpawner spawner)
    {
    }

    [Token(Token = "0x600D5E0")]
    [Address(RVA = "0x1D19300", Offset = "0x1D19300", VA = "0x1D19300")]
    public IEnumerator InitializeCoroutine(Transform uiRoot) => (IEnumerator) null;

    [Token(Token = "0x600D5E1")]
    [Address(RVA = "0x1D1939C", Offset = "0x1D1939C", VA = "0x1D1939C")]
    public void Open(string key)
    {
    }

    [Token(Token = "0x600D5E2")]
    [Address(RVA = "0x1D1945C", Offset = "0x1D1945C", VA = "0x1D1945C")]
    public void Close()
    {
    }

    [Token(Token = "0x600D5E3")]
    [Address(RVA = "0x1D194E4", Offset = "0x1D194E4", VA = "0x1D194E4")]
    private void OnCompleted(UnityAction action)
    {
    }

    [Token(Token = "0x600D5E4")]
    [Address(RVA = "0x1D19508", Offset = "0x1D19508", VA = "0x1D19508")]
    public OperationTextUI()
    {
    }
  }
}
