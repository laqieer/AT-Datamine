-- このluaスクリプトは、PT5_01_0035_2.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_03","110011_03_h")
Include("content_adv_advsmall_110011_03","Template110011_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_03_005,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110011_03_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110011_03_015,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_015)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110011_03_016,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_016)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110011_03_017,"content_motion3d_advarea_common_adv_templatecontroller","Npc_013_01_StdController","to Std_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_017)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110011_03_011,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_011)
	InitializeTemplateRandomCamera110011_03()
	InitializeTemplate110011_03()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101063","001","101063001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401006","001","401006001","content_animationpack__common","FacialPack","Actor006")
	template1()
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("クリスティーナ", "肯定2")
-- ▲直接出力

	--★★クリスティーナ★★:それじゃ、地理学の授業をはじめるわよ♪<br>テキストを開いて
	Talk(Actor005,"CHRNAME_CHRISTINA","speech","L","PT5_01_00350002")

	change_face(Actor005,"Smile")

	--★★クリスティーナ★★:今日は…そうね<br>コルベニック王国について勉強しましょうか♪
	Talk(Actor005,"CHRNAME_CHRISTINA","speech","L","PT5_01_00350003")

	change_face(Actor005,"Normal")

	--★★クリスティーナ★★:コルベニック王国は、ブリテン島の北<br>アイルランド島の中央に位置する国よ
	Talk(Actor005,"CHRNAME_CHRISTINA","speech","L","PT5_01_00350004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クリスティーナ", "肯定")
-- ▲直接出力

	--★★クリスティーナ★★:領土はとても広くて城や城下町もあるんだけど<br>総人口はログレスに比べるととても少ないわ
	Talk(Actor005,"CHRNAME_CHRISTINA","speech","L","PT5_01_00350005")


	--★★クリスティーナ★★:ノワールちゃん<br>なぜだと思う？
	Talk(Actor005,"CHRNAME_CHRISTINA","speech","L","PT5_01_00350006")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","PT5_01_00350007","PT5_01_00350008","PT5_01_00350009")
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
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:アイルランド島は山や森が多く<br>人が住むに適した場所がそれほど多くないんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT5_01_00350010")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クリスティーナ", "照れ")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★クリスティーナ★★:正解<br>ノワールちゃん、ずいぶんと詳しい口ぶりね
	Talk(Actor005,"CHRNAME_CHRISTINA","speech","L","PT5_01_00350011")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:コルベニック城は<br>別名を聖杯城というんだけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT5_01_00350012")

	change_face(Actor001,"Normal")

	--★★ノワール★★:その名のとおり<br>聖杯や妖精の伝説にまつわる地らしくてさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT5_01_00350013")

	change_face(Actor001,"Normal")

	--★★ノワール★★:コルベニック城の城主が<br>人が足を踏み入れないようにしていると聞いた
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT5_01_00350014")

-- ▼直接出力
PlayPartVoice("クリスティーナ", "驚き")
-- ▲直接出力
	change_face(Actor005,"Surprise")

	--★★クリスティーナ★★:あらあら。私が説明しようと思っていたことを<br>全部言われちゃったわ…
	Talk(Actor005,"CHRNAME_CHRISTINA","speech","L","PT5_01_00350015")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:コルベニック王国は…えーっと、そうだな…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT5_01_00350016")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:………
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT5_01_00350017")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ごめん、わからない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT5_01_00350018")

-- ▼直接出力
PlayPartVoice("クリスティーナ", "悩む")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★クリスティーナ★★:なにか知っていそうな感じだけど…<br>まあいいわ
	Talk(Actor005,"CHRNAME_CHRISTINA","speech","L","PT5_01_00350019")

	goto Block1end

::Block1end::
	change_face(Actor005,"Normal")

	--★★クリスティーナ★★:ガラハッドちゃんが<br>旅のついでに立ち寄ったように
	Talk(Actor005,"CHRNAME_CHRISTINA","speech","L","PT5_01_00350020")


	--★★クリスティーナ★★:ログレスとコルベニック王国は<br>昔から交流があるわ
	Talk(Actor005,"CHRNAME_CHRISTINA","speech","L","PT5_01_00350021")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クリスティーナ", "笑い")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★クリスティーナ★★:そのあたりのお話については…<br>また次回ということにしましょう♪
	Talk(Actor005,"CHRNAME_CHRISTINA","speech","L","PT5_01_00350022")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110011)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101063","001","101063001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("401006","001","401006001","content_animationpack__common","FacialPack","Actor006")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110011_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
