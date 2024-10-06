-- このluaスクリプトは、CO_101061_0202.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_02","110071_02_h")
Include("content_adv_advsmall_110071_02","Template110071_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",-140,CharaPos110071_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110071_02,CameraPos110071_02_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110071_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_011_01_StdController","to Std_Loop",CameraAssetBundleName110071_02,CameraPos110071_02_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110071_02_008,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleName110071_02,CameraPos110071_02_008)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110071_02_007,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110071_02,CameraPos110071_02_007)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110071_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110071_02,CameraPos110071_02_004)
	InitializeTemplateRandomCamera110071_02()
	InitializeTemplate110071_02()
-- ▼直接出力
PlayActionDirect(Actor003,"to  Std_Yes")
PlayActionDirect(Actor004,"to  Std_Talk")
PlayActionDirect(Actor005,"to  Std_Worry")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110071)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101061","001","101061001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401008","001","401008001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401005","001","401005001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401007","001","401007001","content_animationpack__common","FacialPack","Actor005")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラロゥ", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ラロゥ★★:へえ、こんな感じになってるんだ
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_02020002")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ラロゥ★★:もっと堅苦しい場所を想像してたけど<br>思ったより解放的じゃん
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_02020003")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:学長のアーサーの影響で<br>そういう校風になってるんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_02020004")

-- ▼直接出力
setup_small_camera_start()
PlayActionDirect(Actor003,"to  Std_Talk")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ラロゥ", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ラロゥ★★:なんか聞きなれない音が聞こえてくる<br>あっちからはおいしそうな匂いも
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_02020006")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101061_02020008","CO_101061_02020009","CO_101061_02020010")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:音楽サークルの様子でも見に行くか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_02020012")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラロゥ", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ラロゥ★★:サークル活動ってやつ？<br>じゃ、それで
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_02020013")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_ラロゥ_ランクアップ2_3")
-- ▲直接出力
	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:食堂に行ってみるか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_02020016")

-- ▼直接出力
PlayPartVoice("ラロゥ", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ラロゥ★★:学園の中に<br>ご飯食べられるところがあんの？
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_02020017")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_ラロゥ_ランクアップ2_4")
-- ▲直接出力
	goto Block1end

::Block1_3::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:屋上に上がって景色を見てみるか？<br>高い場所から見るログレスは印象が違うかも
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_02020020")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラロゥ", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ラロゥ★★:いいね、興味あるよ
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_02020021")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_ラロゥ_ランクアップ2_5")
-- ▲直接出力
	goto Block1end

::Block1end::
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110071)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101061","001","101061001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401008","001","401008001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401005","001","401005001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401007","001","401007001","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110071_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
