-- このluaスクリプトは、MA_01C111_24.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110111_01","110111_01_h")
Include("content_adv_advsmall_110111_01","Template110111_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110111_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110111_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_506_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_006)
	InitializeTemplateRandomCamera110111_01()
	InitializeTemplate110111_01()
-- ▼直接出力
set_enable_auto_lookat_all(false)
turn_lookat(Actor001,Actor002,0)
turn_lookat(Actor002,Actor001,0)
-- ▲直接出力
-- ▼直接出力
	-- 背景移動回転スケール
	local bg = get_object("BG")
	set_pos(bg,{0,0,24})

	-- 固定モブ移動回転スケール
	local pro = get_object("Pro_1101_45")
	set_pos(pro,{0,0,24})
-- ▲直接出力
-- ▼直接出力
BgProp = setup_prop_object(10102010)
set_pos(BgProp,{0,0,24})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115117)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101023","001","101023001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("クラリス","挨拶")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★クラリス★★:信じられます～？
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","MA_01C111_240002")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:クラリス？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_240003")

-- ▼直接出力
setup_small_camera_start(RndCamera005)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("クラリス","落胆")
-- ▲直接出力

	--★★クラリス★★:モルくんがいなくなってしまいました～
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","MA_01C111_240004")


	--★★クラリス★★:わたし、モルくんに目を離されると<br>すぐこうなってしまいます
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","MA_01C111_240005")

-- ▼直接出力
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to  Std_Sad02")
-- ▲直接出力

	--★★クラリス★★:こまったものですねえ
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","MA_01C111_240007")

	PlayAction(Actor001,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("ノワール","照れ")
-- ▲直接出力

	--★★ノワール★★:それは…モルドレッドからすれば<br>クラリスが「いなくなってしまった」側では
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_240008")

-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
 --PlayPartVoice("クラリス","笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★クラリス★★:そうともいいますね<br>なんとも手を焼く女ですねえ
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","MA_01C111_240009")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★クラリス★★:そうやってモルくんは<br>わたしの意志を尊重してくれているんですねえ
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","MA_01C111_240010")

-- ▼直接出力
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor001,"to  Std_Worry")
 --PlayPartVoice("ノワール","悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ど、どうだろう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_240011")

-- ▼直接出力
 --PlayPartVoice("クラリス","挨拶")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★クラリス★★:ノワールくんはどうですか～？
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","MA_01C111_240012")

-- ▼直接出力
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力

	--★★ノワール★★:え？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_240013")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★クラリス★★:ディナタンちゃんに<br>手を焼いていますか～？
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","MA_01C111_240014")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(Camera001)
change_face(Actor001,"Surprise")
wait_time(2)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(RndCamera005)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("クラリス","喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★クラリス★★:う～ん<br>良いお兄さんですね
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","MA_01C111_240016")

	change_face(Actor002,"Normal")

	--★★クラリス★★:お話することも大切です
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","MA_01C111_240017")


	--★★クラリス★★:だけどたまには目を離してあげても<br>いいのかもしれませんね～
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","MA_01C111_240018")

-- ▼直接出力
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to  Std_Worry")
-- ▲直接出力

	--★★クラリス★★:もしかしたら<br>ふらふらしたり
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","MA_01C111_240020")


	--★★クラリス★★:いけないことを<br>したくなることもありますからね～
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","MA_01C111_240021")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
 --PlayPartVoice("クラリス","笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★クラリス★★:信じてもらいたいものですね？?
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","MA_01C111_240023")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
setup_prop_object_preload(10102010)
	InitializeLoad_Preload()
	load_area_scene_preload(115117)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101023","001","101023001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110111_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
