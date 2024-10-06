-- このluaスクリプトは、MA_01A109_37.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_111013_03","111013_03_h")
Include("content_adv_advsmall_111013_03","Template111013_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos111013_03_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName111013_03,CameraPos111013_03_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos111013_03_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_019_01_StdController","to Std_Loop",CameraAssetBundleName111013_03,CameraPos111013_03_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos111013_03_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_526_02_StdController","to Std_Loop",CameraAssetBundleName111013_03,CameraPos111013_03_008)
	Camera004 = SetTemplate("Actor004",nil,CharaPos111013_03_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_513_01_StdController","to Std_Loop",CameraAssetBundleName111013_03,CameraPos111013_03_005)
	Camera005 = SetTemplate("Actor005",nil,CharaPos111013_03_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_514_01_StdController","to Std_Loop",CameraAssetBundleName111013_03,CameraPos111013_03_004)
	Camera006 = SetTemplate("Actor006",nil,CharaPos111013_03_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_526_02_StdController","to Std_Loop",CameraAssetBundleName111013_03,CameraPos111013_03_007)
	Camera007 = SetTemplate("Actor007",nil,CharaPos111013_03_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_525_01_StdController","to Std_Loop",CameraAssetBundleName111013_03,CameraPos111013_03_003)
	Camera008 = SetTemplate("Actor008",nil,CharaPos111013_03_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_526_02_StdController","to Std_Loop",CameraAssetBundleName111013_03,CameraPos111013_03_006)
	InitializeTemplateRandomCamera111013_03()
	InitializeTemplate111013_03()
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor004, true)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor005, true)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor007, true)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(111013)
	Actor001 = InitializeCharacter_3D("101051","001","101051001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101052","001","101052001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101045","001","101045001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101038","001","101038001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101039","001","101039001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101042","001","101042001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101037","001","101037001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("101044","001","101044001","content_animationpack__common","FacialPack","Actor008")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	change_face(Actor001,"Surprise")

	--★★ルーシャス★★:すこし醜い寝屋だが
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A109_370002")


	--★★ヴェルナルス★★:…
	Talk(Actor002,"CHRNAME_VERNARTH","speech","L","MA_01A109_370003")

	change_face(Actor001,"Normal")

	--★★ルーシャス★★:ようこそ、歓迎するよ
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A109_370004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★グリートーネア★★:跪いたら？
	Talk(Actor003,"CHRNAME_SISTERS_4","speech","L","MA_01A109_370005")


	--★★ルーシャス★★:いいよ。おともだちでね
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A109_370006")


	--★★ルーシャス★★:まさかローマに<br>忠誠を誓いに来たわけではなかろう？
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A109_370008")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Smile")

	--★★ルーシャス★★:いいんだよ、それでいい
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A109_370009")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
set_common_look_at(Actor004,Actor005,0.6)
-- ▲直接出力

	--★★ローラ★★:お姉ちゃん、私がついてるから
	Talk(Actor004,"CHRNAME_LOLA","speech","L","MA_01A109_370010")

	play_head_motion(Actor005, "No", 0.3, 1.0, false)
	change_face(Actor005,"Sad")

	--★★フレン★★:ローラ…貴方はどうしていつも──
	Talk(Actor005,"CHRNAME_FREN","speech","L","MA_01A109_370011")


	--★★モーロノエー★★:嗚呼、考えなしの児戯ね
	Talk(Actor006,"CHRNAME_SISTERS_1","speech","L","MA_01A109_370012")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
set_common_look_at(Actor007,Actor002,0.3)
set_common_look_at(Actor005,Actor001,0.3)
set_enable_auto_lookat(Actor005, false)
wait_time(0.5)
-- ▲直接出力
	PlayAction(Actor007,"to  Std_Sad01")
	change_face(Actor007,"Sad")

	--★★ラシア★★:…叔父様
	Talk(Actor007,"CHRNAME_RASIA","speech","L","MA_01A109_370013")

	change_face(Actor002,"Sad")

	--★★ヴェルナルス★★:後悔するぞ。ラシア
	Talk(Actor002,"CHRNAME_VERNARTH","speech","L","MA_01A109_370014")

-- ▼直接出力
set_common_look_at(Actor001,Actor002,0.5)
set_enable_auto_lookat(Actor002, true)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ルーシャス★★:物事を悔やむのはね<br>暇を持て余す者がすることだよ、将軍
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A109_370015")

-- ▼直接出力
lookat_delay_weight_reset(Actor001,0.3)
wait_time(0.5)
-- ▲直接出力

	--★★ルーシャス★★:諸君には充実した日々が待っている<br>退屈はさせないよ
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A109_370016")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ヴェルナルス★★:…仰せのままに
	Talk(Actor002,"CHRNAME_VERNARTH","speech","L","MA_01A109_370017")

-- ▼直接出力
lookat_delay_weight_reset(Actor002,0.3)
set_enable_auto_lookat(Actor002, false)
-- ▲直接出力

	--★★ルーシャス★★:師弟愛
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A109_370019")


	--★★ルーシャス★★:家族愛
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A109_370021")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ルーシャス★★:そしてそなたは──
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A109_370023")

-- ▼直接出力
set_enable_auto_lookat(Actor004, false)
set_enable_auto_lookat(Actor007, false)
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Talk")

	--★★フレン★★:ルーシャスくん…
	Talk(Actor005,"CHRNAME_FREN","speech","L","MA_01A109_370024")

	change_face(Actor008,"Smile")

	--★★グリーテン★★:「くん」だってぇ、あはは、あははは♪
	Talk(Actor008,"CHRNAME_SISTERS_3","speech","L","MA_01A109_370025")


	--★★ルーシャス★★:──愛しき小鳥
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A109_370026")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Sad01")
	change_face(Actor005,"Anger")

	--★★フレン★★:…馬鹿にするんだね
	Talk(Actor005,"CHRNAME_FREN","speech","L","MA_01A109_370028")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ルーシャス★★:うすら寒いが、それこそが夢だ
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A109_370029")


	--★★ルーシャス★★:さあ、愛で世界を平和にしようか
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A109_370030")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(111013)
	InitializeCharacter_3D_Preload("101051","001","101051001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101052","001","101052001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101045","001","101045001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101038","001","101038001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101039","001","101039001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101042","001","101042001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101037","001","101037001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("101044","001","101044001","content_animationpack__common","FacialPack","Actor008")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName111013_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
