// Decompiled with JetBrains decompiler
// Type: ChangeSceneButton
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Scene;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x200020E")]
[RequireComponent(typeof (Image))]
[AddComponentMenu("UI/Change Scene Button", 34)]
public class ChangeSceneButton : CommonButton
{
  [Token(Token = "0x4000C3F")]
  [FieldOffset(Offset = "0x17C")]
  [SerializeField]
  private ChangeSceneButton.ChangeSceneButtonType m_changeSceneButtonType;
  [Token(Token = "0x4000C40")]
  [FieldOffset(Offset = "0x180")]
  [SerializeField]
  private string m_sceneName;
  [Token(Token = "0x4000C41")]
  [FieldOffset(Offset = "0x188")]
  [SerializeField]
  private string m_subSceneAssetbundleName;
  [Token(Token = "0x4000C42")]
  [FieldOffset(Offset = "0x190")]
  [SerializeField]
  private string m_subSceneName;
  [Token(Token = "0x4000C43")]
  [FieldOffset(Offset = "0x198")]
  [SerializeField]
  private SceneHandler.LoadingPanelType m_loadingPanelType;
  [Token(Token = "0x4000C44")]
  [FieldOffset(Offset = "0x1A0")]
  private Button.ButtonClickedEvent onClick;

  [Token(Token = "0x6000CF9")]
  [Address(RVA = "0x4C7F2D8", Offset = "0x4C7F2D8", VA = "0x4C7F2D8", Slot = "41")]
  public override void OnPointerClick(PointerEventData eventData)
  {
  }

  [Token(Token = "0x6000CFA")]
  [Address(RVA = "0x4C7F4D0", Offset = "0x4C7F4D0", VA = "0x4C7F4D0")]
  public ChangeSceneButton()
  {
  }

  [Token(Token = "0x200020F")]
  public enum ChangeSceneButtonType
  {
    [Token(Token = "0x4000C46")] ChangeSceneButton,
    [Token(Token = "0x4000C47")] ChangeSubSceneButton,
  }
}
