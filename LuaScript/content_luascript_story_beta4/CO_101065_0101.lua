-- このluaスクリプトは、CO_101065_0101.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110191_01","110191_01_h")
Include("content_adv_advsmall_110191_01","Template110191_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110191_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_002)
	Camera002 = SetTemplate("Actor002",-130,CharaPos110191_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_004)
	InitializeTemplateRandomCamera110191_01()
	InitializeTemplate110191_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110191)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ケイ", "挨拶")
-- ▲直接出力

	--★★ケイ★★:少しいいかね、ノワール
	Talk(Actor002,"CHRNAME_KAY","speech","L","CO_101065_01010002")

	open_select_window_tag(Actor001,"Normal","CO_101065_01010004","CO_101065_01010005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:なんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_01010007")

-- ▼直接出力
PlayPartVoice("ケイ", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ケイ★★:貴公への依頼だ手を貸したまえ
	Talk(Actor002,"CHRNAME_KAY","speech","L","CO_101065_01010008")

	PlayAction(Actor002,"to  Std_Worry")
	change_face(Actor002,"Normal")

	--★★ケイ★★:私はまったくもって本意ではないが
	Talk(Actor002,"CHRNAME_KAY","speech","L","CO_101065_01010009")

	change_face(Actor002,"Normal")

	--★★ケイ★★:王は貴公を我が国の騎士として迎えるというのだいつまでも傭兵気分でいられては困る
	Talk(Actor002,"CHRNAME_KAY","speech","L","CO_101065_01010010")

-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:俺から騎士にしてくれって頼んだ覚えはないんだけどな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_01010011")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:今はよくない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_01010013")

-- ▼直接出力
PlayPartVoice("ケイ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ケイ★★:これは王命である貴公に拒否権はない
	Talk(Actor002,"CHRNAME_KAY","speech","L","CO_101065_01010015")

-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:だったらいちいち確認をとらなくてよかったじゃないか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_01010016")

-- ▼直接出力
PlayPartVoice("ケイ", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ケイ★★:…なにか？
	Talk(Actor002,"CHRNAME_KAY","speech","L","CO_101065_01010017")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:いいえなんでもありません
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_01010018")

	goto Block1end

::Block1end::
	change_face(Actor001,"Normal")

	--★★ノワール★★:それで、なんの用なんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_01010020")

-- ▼直接出力
PlayPartVoice("ケイ", "悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ケイ★★:最近、バルバロイを信奉するという妙な集団の噂が街に流れている
	Talk(Actor002,"CHRNAME_KAY","speech","L","CO_101065_01010021")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ケイ★★:それについて調べてほしい
	Talk(Actor002,"CHRNAME_KAY","speech","L","CO_101065_01010022")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:バルバロイを信奉する？そんな連中がいるのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_01010023")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ケイ", "落胆")
-- ▲直接出力

	--★★ケイ★★:信じがたい気持ちは分かるがこんな時世だ
	Talk(Actor002,"CHRNAME_KAY","speech","L","CO_101065_01010024")


	--★★ケイ★★:己より強大な力を前にしたときその力に救いを求めてしまう者もいるのだろう
	Talk(Actor002,"CHRNAME_KAY","speech","L","CO_101065_01010025")

-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力

	--★★ノワール★★:なるほどな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_01010026")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ケイ", "肯定")
-- ▲直接出力

	--★★ケイ★★:幸い、今はまだ一部の者が面白がって話しているだけのようだが
	Talk(Actor002,"CHRNAME_KAY","speech","L","CO_101065_01010027")


	--★★ケイ★★:なにかをきっかけに爆発的に広まり大きな混乱を巻き起こす可能性もある
	Talk(Actor002,"CHRNAME_KAY","speech","L","CO_101065_01010028")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:わかった街に行って調べてみる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_01010029")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ケイ", "肯定2")
-- ▲直接出力

	--★★ケイ★★:任せたぞ。貴公を学園へ招き入れた王の期待を裏切らぬようにな
	Talk(Actor002,"CHRNAME_KAY","speech","L","CO_101065_01010030")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ひとこと多いな本当…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_01010031")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_キッス_ランクアップ1_2")
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110191)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110191_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
