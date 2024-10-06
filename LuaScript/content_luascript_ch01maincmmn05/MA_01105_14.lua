-- このluaスクリプトは、MA_01105_14.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110191_01","110191_01_h")
Include("content_adv_advsmall_110191_01","Template110191_01_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110191_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110191_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110191_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_004)
	InitializeTemplateRandomCamera110191_01()
	InitializeTemplate110191_01()
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
-- ▲直接出力
-- ▼直接出力
se_play("SE_ADV_MA_01C111_20_Bell")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110191)
	Actor001 = InitializeCharacter_3D("101016","001","101016001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor003")
	template1()
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★ギネヴィア★★:ついてこないでね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01105_140002")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Sad")

	--★★ギネマウア★★:ですが殿下──
	Talk(Actor001,"NPCNAME_0070","speech","L","MA_01105_140003")

-- ▼直接出力
lookat_delay_weight(Actor002, 0.7, 0.03, 0.7, 0.2,1.0)
keep_ik_lookat(Actor002,Actor001,"J_Head")
PlayActionDirect(Actor002,"to  Std_Angry")
turn_chara(Actor002,140,0.3)
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ギネヴィア★★:侍女はついてくるの！<br>ノワールはついてこないで！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01105_140004")

-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor003,"J_Head",1)
-- ▲直接出力

	--★★ギネマウア★★:ノワール様…<br>殿下をおとめいただけませんか
	Talk(Actor001,"NPCNAME_0070","speech","L","MA_01105_140006")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor003,"Normal","MA_01105_140008","MA_01105_140009","MA_01105_140010")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
keep_delay_ik_lookat(Actor003,Actor002,"J_Head",1.0)
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ノワール★★:待てよギネヴィア<br>なにをそんなに急いで…？
	Talk(Actor003,"CHRNAME_NOIR","speech","L","MA_01105_140012")

	change_face(Actor002,"Anger")

	--★★ギネヴィア★★:ほっといて
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01105_140013")

	change_face(Actor002,"Anger")

	--★★ギネヴィア★★:もう我慢の限界なの<br>わたしひとりでも行くんだから
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01105_140014")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
keep_delay_ik_lookat(Actor003,Actor002,"J_Head",1.0)
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ノワール★★:ついていくよ
	Talk(Actor003,"CHRNAME_NOIR","speech","L","MA_01105_140016")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor003,"J_Head",1.0)
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ギネヴィア★★:なんでついてくるのよ！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01105_140017")

-- ▼直接出力
keep_ik_lookat(Actor001,Actor002,"J_Head",1.0)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ギネマウア★★:殿下が雇われた傭兵殿でしょう
	Talk(Actor001,"NPCNAME_0070","speech","L","MA_01105_140018")

	change_face(Actor002,"Shy")

	--★★ギネヴィア★★:………それなら、しょうがないわね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01105_140020")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	change_face(Actor003,"Normal")

	--★★ノワール★★:じゃあ俺、授業があるから
	Talk(Actor003,"CHRNAME_NOIR","speech","L","MA_01105_140022")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor003,"J_Head",1.0)
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ギネヴィア★★:わたしもあるわよ！<br>なにそれ、わたしをほうっておく気…！？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01105_140023")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Sad02")
-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor003,"J_Head",1.0)
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ギネマウア★★:ノワール様…申し訳ございません<br>殿下の行動があべこべでして、誠に…！
	Talk(Actor001,"NPCNAME_0070","speech","L","MA_01105_140024")

	PlayAction(Actor002,"to  Std_Angry")
	open_cutin(1,2)
	on_cutin(1,Actor002,"Anger")
	change_face(Actor002,"Anger")

	--★★ギネヴィア★★:ついてきてよォッ！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","N","MA_01105_140025")

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
	load_area_scene_preload(110191)
	InitializeCharacter_3D_Preload("101016","001","101016001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor003")
MobsNo = 0
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110191_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
