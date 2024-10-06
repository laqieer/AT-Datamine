// Decompiled with JetBrains decompiler
// Type: DuelMarker.Shot_Base
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

#nullable disable
namespace DuelMarker
{
  [Token(Token = "0x20021E7")]
  public class Shot_Base : Marker, INotification, INotificationOptionProvider
  {
    [Token(Token = "0x4008F3A")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private bool m_Retroactive;
    [Token(Token = "0x4008F3B")]
    [FieldOffset(Offset = "0x29")]
    [SerializeField]
    private bool m_EmitOnce;
    [Token(Token = "0x4008F3D")]
    [FieldOffset(Offset = "0x30")]
    public GameObject prefab;
    [Token(Token = "0x4008F3E")]
    [FieldOffset(Offset = "0x38")]
    public DuelElementEffectSettingsAsset elementPrefabList;
    [Token(Token = "0x4008F3F")]
    [FieldOffset(Offset = "0x40")]
    public ElementEffectItem.ElementType elementType;
    [Token(Token = "0x4008F40")]
    [FieldOffset(Offset = "0x48")]
    public string fromCharacterObjectName;
    [Token(Token = "0x4008F41")]
    [FieldOffset(Offset = "0x50")]
    public string fromBodyPartName;
    [Token(Token = "0x4008F42")]
    [FieldOffset(Offset = "0x58")]
    public string toCharacterObjectName;
    [Token(Token = "0x4008F43")]
    [FieldOffset(Offset = "0x60")]
    public string toBodyPartName;
    [Token(Token = "0x4008F44")]
    [FieldOffset(Offset = "0x68")]
    [HideInInspector]
    public DuelManager.DuelHitStatus hitType;
    [Token(Token = "0x4008F45")]
    [FieldOffset(Offset = "0x6C")]
    [Tooltip("単位：m / s")]
    public float speed;
    [Token(Token = "0x4008F46")]
    [FieldOffset(Offset = "0x70")]
    public float destroyDelay;

    [Token(Token = "0x17002D12")]
    public PropertyName id
    {
      [Token(Token = "0x600CEB8"), Address(RVA = "0x4B65AB4", Offset = "0x4B65AB4", VA = "0x4B65AB4", Slot = "9")] get
      {
        return new PropertyName();
      }
    }

    [Token(Token = "0x17002D13")]
    public bool retroactive
    {
      [Token(Token = "0x600CEB9"), Address(RVA = "0x4B65ABC", Offset = "0x4B65ABC", VA = "0x4B65ABC")] get
      {
        return new bool();
      }
      [Token(Token = "0x600CEBA"), Address(RVA = "0x4B65AC4", Offset = "0x4B65AC4", VA = "0x4B65AC4")] set
      {
      }
    }

    [Token(Token = "0x17002D14")]
    public bool emitOnce
    {
      [Token(Token = "0x600CEBB"), Address(RVA = "0x4B65AD0", Offset = "0x4B65AD0", VA = "0x4B65AD0")] get
      {
        return new bool();
      }
      [Token(Token = "0x600CEBC"), Address(RVA = "0x4B65AD8", Offset = "0x4B65AD8", VA = "0x4B65AD8")] set
      {
      }
    }

    [Token(Token = "0x17002D15")]
    private NotificationFlags UnityEngine\u002ETimeline\u002EINotificationOptionProvider\u002Eflags
    {
      [Token(Token = "0x600CEBD"), Address(RVA = "0x4B65AE4", Offset = "0x4B65AE4", VA = "0x4B65AE4", Slot = "10")] get
      {
        return new NotificationFlags();
      }
    }

    [Token(Token = "0x600CEBE")]
    [Address(RVA = "0x4B65AA4", Offset = "0x4B65AA4", VA = "0x4B65AA4")]
    public Shot_Base()
    {
    }
  }
}
