// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.UnitDetail.AI.AIDescriptionItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.UnitDetail.AI
{
  [Token(Token = "0x20032EB")]
  public class AIDescriptionItem : MonoBehaviour
  {
    [Token(Token = "0x400DBCD")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private RectTransform rectTransform;
    [Token(Token = "0x400DBCE")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text title;
    [Token(Token = "0x400DBCF")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text description;
    [Token(Token = "0x400DBD0")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Toggle toggle;
    [Token(Token = "0x400DBD3")]
    [FieldOffset(Offset = "0x48")]
    private Action<int> onValueChangeAction;

    [Token(Token = "0x17004322")]
    public RectTransform RectTransform
    {
      [Token(Token = "0x601401D"), Address(RVA = "0x234B3CC", Offset = "0x234B3CC", VA = "0x234B3CC")] get
      {
        return (RectTransform) null;
      }
    }

    [Token(Token = "0x17004323")]
    public int AiTypeID
    {
      [Token(Token = "0x601401E"), Address(RVA = "0x234B3D4", Offset = "0x234B3D4", VA = "0x234B3D4")] get
      {
        return new int();
      }
      [Token(Token = "0x601401F"), Address(RVA = "0x234B3DC", Offset = "0x234B3DC", VA = "0x234B3DC")] private set
      {
      }
    }

    [Token(Token = "0x17004324")]
    public AIRoleData Role
    {
      [Token(Token = "0x6014020"), Address(RVA = "0x234B3E4", Offset = "0x234B3E4", VA = "0x234B3E4")] get
      {
        return (AIRoleData) null;
      }
      [Token(Token = "0x6014021"), Address(RVA = "0x234B3EC", Offset = "0x234B3EC", VA = "0x234B3EC")] private set
      {
      }
    }

    [Token(Token = "0x6014022")]
    [Address(RVA = "0x234B3F4", Offset = "0x234B3F4", VA = "0x234B3F4")]
    public void Initialize(AITypeData aiType, AIRoleData role, Action<int> onValueChange)
    {
    }

    [Token(Token = "0x6014023")]
    [Address(RVA = "0x234B470", Offset = "0x234B470", VA = "0x234B470")]
    public void InitializeToggle(bool isOn)
    {
    }

    [Token(Token = "0x6014024")]
    [Address(RVA = "0x234B4B8", Offset = "0x234B4B8", VA = "0x234B4B8")]
    public void SetupCallback()
    {
    }

    [Token(Token = "0x6014025")]
    [Address(RVA = "0x234B560", Offset = "0x234B560", VA = "0x234B560")]
    public void OnValueChange(bool isOn)
    {
    }

    [Token(Token = "0x6014026")]
    [Address(RVA = "0x234B584", Offset = "0x234B584", VA = "0x234B584")]
    public AIDescriptionItem()
    {
    }
  }
}
