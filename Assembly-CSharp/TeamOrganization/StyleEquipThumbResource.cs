// Decompiled with JetBrains decompiler
// Type: TeamOrganization.StyleEquipThumbResource
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using StaqData;
using System;
using UnityEngine.Events;

#nullable disable
namespace TeamOrganization
{
  [Token(Token = "0x2000808")]
  public class StyleEquipThumbResource
  {
    [Token(Token = "0x4002600")]
    [FieldOffset(Offset = "0x10")]
    public AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x4002601")]
    [FieldOffset(Offset = "0x18")]
    public Style styleData;
    [Token(Token = "0x4002602")]
    [FieldOffset(Offset = "0x20")]
    public bool IsLost;
    [Token(Token = "0x4002603")]
    [FieldOffset(Offset = "0x21")]
    public bool Isorganized;
    [Token(Token = "0x4002604")]
    [FieldOffset(Offset = "0x22")]
    public bool IsSelected;
    [Token(Token = "0x4002605")]
    [FieldOffset(Offset = "0x23")]
    public bool AlreadyDispatched;
    [Token(Token = "0x4002606")]
    [FieldOffset(Offset = "0x28")]
    public Action<StyleEquipThumbResource> OnClickThumbnail;
    [Token(Token = "0x4002607")]
    [FieldOffset(Offset = "0x30")]
    public UnityEvent<bool> OnChangeOrganization;
    [Token(Token = "0x4002608")]
    [FieldOffset(Offset = "0x38")]
    public UnityEvent<bool> OnChangeSelect;
    [Token(Token = "0x4002609")]
    [FieldOffset(Offset = "0x40")]
    public Action OnClickRemove;

    [Token(Token = "0x6002E21")]
    [Address(RVA = "0x3A8DB80", Offset = "0x3A8DB80", VA = "0x3A8DB80")]
    public StyleEquipThumbResource()
    {
    }
  }
}
