-- このluaスクリプトは、MA_01A112_18.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_111012_01","111012_01_h")
Include("content_adv_advsmall_111012_01","Template111012_01_h")
Include("content_adv_advsmall_111012_08","111012_08_h")
Include("content_adv_advsmall_111012_08","Template111012_08_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",-60,CharaPos111012_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_525_01_StdController","to Std_Loop",CameraAssetBundleName111012_01,CameraPos111012_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos111012_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_019_01_StdController","to Std_Loop",CameraAssetBundleName111012_01,CameraPos111012_01_006)
	Camera003 = SetTemplate("Actor003",nil,CharaPos111012_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName111012_01,CameraPos111012_01_002)
	Camera004 = SetTemplate("Actor004",nil,CharaPos111012_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName111012_01,CameraPos111012_01_001)
	Camera005 = SetTemplate("Actor005",nil,CharaPos111012_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName111012_01,CameraPos111012_01_003)
	Camera006 = SetTemplate("Actor006",nil,CharaPos111012_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleName111012_01,CameraPos111012_01_004)
	Camera007 = SetTemplate("Actor007",nil,CharaPos111012_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Emy_001_00_Controller","to Std_Loop",CameraAssetBundleName111012_01,CameraPos111012_01_007)
	Camera008 = SetTemplate("Actor008",nil,CharaPos111012_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Emy_001_00_Controller","to Std_Loop",CameraAssetBundleName111012_01,CameraPos111012_01_008)
	InitializeTemplateRandomCamera111012_01()
	InitializeTemplate111012_01()
-- ▼直接出力
load_image("10302001", "content_still_10302001_image", "103020010_StillImage")
show_image("10302001", 0.0, 0.0, STILL_SWITCH_TIME ,true,false)
DontChangeRandomCamera(true)
set_enable_auto_lookat_all(false)
set_pos(Actor007,{1,0,-9})
set_rot(Actor007,{0,120,0})
set_pos(Actor008,{-1,0,-4})
set_rot(Actor008,{0,-140,0})
Hide(Actor003)
Hide(Actor004)
Hide(Actor005)
Hide(Actor006)
-- ▲直接出力
end
function template2()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos111012_08_012,"content_motion3d_advarea_common_adv_templatecontroller","Chr_525_01_StdController","to Std_Loop",CameraAssetBundleName111012_08,CameraPos111012_08_012)
	Camera002 = SetTemplate("Actor002",nil,CharaPos111012_08_011,"content_motion3d_advarea_common_adv_templatecontroller","Chr_019_01_StdController","to Std_Loop",CameraAssetBundleName111012_08,CameraPos111012_08_011)
	Camera003 = SetTemplate("Actor003",nil,CharaPos111012_08_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName111012_08,CameraPos111012_08_001)
	Camera004 = SetTemplate("Actor004",nil,CharaPos111012_08_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName111012_08,CameraPos111012_08_004)
	Camera005 = SetTemplate("Actor005",nil,CharaPos111012_08_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName111012_08,CameraPos111012_08_002)
	Camera006 = SetTemplate("Actor006",nil,CharaPos111012_08_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleName111012_08,CameraPos111012_08_003)
	Camera007 = SetTemplate("Actor007",nil,CharaPos111012_08_011,"content_motion3d_advarea_common_adv_templatecontroller","Emy_001_00_Controller","to Std_Loop",CameraAssetBundleName111012_08,CameraPos111012_08_011)
	Camera008 = SetTemplate("Actor008",nil,CharaPos111012_08_012,"content_motion3d_advarea_common_adv_templatecontroller","Emy_001_00_Controller","to Std_Loop",CameraAssetBundleName111012_08,CameraPos111012_08_012)
	InitializeTemplateRandomCamera111012_08()
	InitializeTemplate111012_08()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(111012)
	Actor001 = InitializeCharacter_3D("101037","001","101037001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101052","001","101052001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("201001","001","201001001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("201001","001","201001001","content_animationpack__common","FacialPack","Actor008")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
wait_time(STILL_SWITCH_TIME + STILL_ACTIVE_AFTER)
hide_image(STILL_SWITCH_TIME) 
wait_time(STILL_SWITCH_TIME + STILL_PASSIVE_AFTER )
-- ▲直接出力

	--★★ラシア★★:ローマの片田舎で<br>乳絞りばかり得意で
	Talk(Actor001,"CHRNAME_RASIA","speech","R","MA_01A112_180002")

	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Smile")

	--★★ラシア★★:あの姉妹とも、よく遊んでいました<br>ヨーグルトを作ったり、穏やかで楽しかった
	Talk(Actor001,"CHRNAME_RASIA","speech","R","MA_01A112_180003")

-- ▼直接出力
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ラシア★★:あのころには戻れませんね
	Talk(Actor001,"CHRNAME_RASIA","speech","R","MA_01A112_180004")

	PlayAction(Actor001,"to  Std_Sad01")

	--★★ラシア★★:勝利を収めたところで<br>私たちの行く末は──
	Talk(Actor001,"CHRNAME_RASIA","speech","R","MA_01A112_180005")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ラシア★★:ヴェルナ叔父様、私は迷惑でしたか？
	Talk(Actor001,"CHRNAME_RASIA","speech","R","MA_01A112_180007")


	--★★ヴェルナルス大将軍★★:なに？
	Talk(Actor002,"CHRNAME_VERNARTH","speech","R","MA_01A112_180008")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")

	--★★ラシア★★:私がついてきてしまったおかげで<br>身動きが取れなくなってしまったのでは
	Talk(Actor001,"CHRNAME_RASIA","speech","R","MA_01A112_180009")


	--★★ラシア★★:本当ならこのような事態になる前に<br>大陸へ戻ることもできたのでは──
	Talk(Actor001,"CHRNAME_RASIA","speech","R","MA_01A112_180010")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ヴェルナルス大将軍★★:言ったはずだ、ラシア<br>私はルーシャス様が創るローマが見たいと
	Talk(Actor002,"CHRNAME_VERNARTH","speech","R","MA_01A112_180011")


	--★★ヴェルナルス大将軍★★:あの御方は<br>眠るのを恐れていらっしゃる
	Talk(Actor002,"CHRNAME_VERNARTH","speech","R","MA_01A112_180012")

	PlayAction(Actor002,"to  Std_Worry")

	--★★ヴェルナルス大将軍★★:必定であることも理解できる<br>分裂と反乱を繰り返す大帝国の頂きで
	Talk(Actor002,"CHRNAME_VERNARTH","speech","R","MA_01A112_180013")


	--★★ヴェルナルス大将軍★★:裏切りの凶刃を忌み<br>眠る暇なく歩みを続けている
	Talk(Actor002,"CHRNAME_VERNARTH","speech","R","MA_01A112_180014")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ヴェルナルス大将軍★★:あの御方の行いについて擁護する気はない<br>だが、仕えるのをやめる気もない
	Talk(Actor002,"CHRNAME_VERNARTH","speech","R","MA_01A112_180015")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★ヴェルナルス大将軍★★:ローマに生かされたのだから
	Talk(Actor002,"CHRNAME_VERNARTH","speech","R","MA_01A112_180016")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ラシア★★:苦言を呈させてください<br>ヴェルナ叔父様
	Talk(Actor001,"CHRNAME_RASIA","speech","R","MA_01A112_180017")

	change_face(Actor002,"Surprise")

	--★★ヴェルナルス大将軍★★:苦言？
	Talk(Actor002,"CHRNAME_VERNARTH","speech","R","MA_01A112_180018")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Smile")

	--★★ラシア★★:叔父様の目は曇っています
	Talk(Actor001,"CHRNAME_RASIA","speech","R","MA_01A112_180020")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★ヴェルナルス大将軍★★:かもしれん
	Talk(Actor002,"CHRNAME_VERNARTH","speech","R","MA_01A112_180022")

	change_face(Actor002,"Normal")

	--★★ヴェルナルス大将軍★★:だが…あの御方の腹の底まではわからんが<br>ローマが至る平和を本当に成せるのなら
	Talk(Actor002,"CHRNAME_VERNARTH","speech","R","MA_01A112_180023")

-- ▼直接出力
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor001,"to  Std_Sad01")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ラシア★★:『ローマの平和』…<br>ルーシャス様は何を目指して──…？
	Talk(Actor001,"CHRNAME_RASIA","speech","R","MA_01A112_180024")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_2")
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
se_play("SE_ADV_MA_01A112_18_Door")
fadeout(0,0,0,1.0,0.5)
wait_time(0.5)
Appear(Actor003)
Appear(Actor004)
Appear(Actor005)
Appear(Actor006)
template2()
PlayActionDirect(Actor001,"to Std_Loop")
PlayActionDirect(Actor002,"to Std_Loop")
set_pos(Actor007,{-2.12,0,-8.45})
set_rot(Actor007,{0,20.5,0})
set_pos(Actor008,{2.38,0,-8.8})
set_rot(Actor008,{0,-42,0})
setup_small_camera_start()
wait_time(TIME_ELAPSED + 0.5)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Anger")

	--★★ラシア★★:奇襲、幼稚な
	Talk(Actor001,"CHRNAME_RASIA","speech","R","MA_01A112_180026")

	PlayAction(Actor002,"to  Std_Surp")

	--★★ヴェルナルス大将軍★★:…外の攻撃は陽動<br>こちらが本命か
	Talk(Actor002,"CHRNAME_VERNARTH","speech","R","MA_01A112_180027")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
setup_small_camera_start(Camera004)
-- ▲直接出力

	--★★ギネヴィア★★:ただいま
	Talk(Actor004,"CHRNAME_GUINEVERE","speech","L","MA_01A112_180028")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("10302001", "content_still_10302001_image", "103020010_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(111012)
	InitializeCharacter_3D_Preload("101037","001","101037001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101052","001","101052001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("201001","001","201001001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("201001","001","201001001","content_animationpack__common","FacialPack","Actor008")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName111012_01)
	system.PreLoadRequest(CameraAssetBundleName111012_08)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
