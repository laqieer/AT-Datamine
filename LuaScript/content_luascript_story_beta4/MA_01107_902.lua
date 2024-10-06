-- このluaスクリプトは、MA_01107_902.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",60,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera002 = SetTemplate("Actor002",40,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_521_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
set_pos(Actor001,{-3.05,0,-1.62})
PlayActionDirect(Actor002,"to  Std_Joy")
Hide(Actor003)
-- ▲直接出力
-- ▼直接出力
set_common_look_at(Actor001,Actor002)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101060013)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101001","001","101001001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101016","001","101016001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
wait_time(2)
PlayActionDirect(Actor001,"to Wlk")
slidemove(Actor001,{-0.8,0,-0.8},1.5)
wait_time(1.3)
PlayActionDirect(Actor001,"to Std_Loop")
wait_time(0.5)
set_common_look_at(Actor002,Actor001)
PlayActionDirect(Actor002,"to Std_Loop")
wait_time(0.5)
turn_chara(Actor002,-50,0.8)
-- ▲直接出力

	--★★ティルフィング★★:…マスター
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","MA_01107_9020002")

	change_face(Actor001,"Sad")

	--★★ノワール★★:休まなくていいのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_9020003")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_No")

	--★★ティルフィング★★:私は大丈夫です<br>皆さんとはその…少し、違いますから
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","MA_01107_9020004")

	change_face(Actor002,"Sad")

	--★★ティルフィング★★:私にもう少し力があったなら<br>あのまま封としていられたのなら
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","MA_01107_9020005")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to  Std_Sad01")
-- ▲直接出力

	--★★ティルフィング★★:キャメリアードの地が<br>蹂躙されることはなかったのでしょうか
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","MA_01107_9020006")

-- ▼直接出力
set_enable_auto_lookat_all(false)
Appear(Actor003)
-- ▲直接出力

	--★★ギネマウア★★:それは違うと思いますよ
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","MA_01107_9020007")

-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力
-- ▼直接出力
set_common_look_at(Actor002,Actor003)
PlayActionDirect(Actor002,"to Std_Loop")
set_common_look_at(Actor001,Actor003)
PlayActionDirect(Actor001,"to  Std_Surp")
turn_chara(Actor001,0,0.5)
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ギネマウアさん…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_9020008")

	PlayAction(Actor003,"to  Std_Talk")

	--★★ギネマウア★★:あなたがノワール様を呼んでくれたから<br>被害を最小限に食い止められたのです
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","MA_01107_9020009")


	--★★ギネマウア★★:ですから<br>自分を卑下などなさらないでください
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","MA_01107_9020010")


	--★★ギネマウア★★:それに、このあとあなたとノワール様が<br>バルバロイを滅ぼし
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","MA_01107_9020011")

	change_face(Actor003,"Smile")

	--★★ギネマウア★★:キャメリアードを再び昔のような<br>豊かな国に戻してくださるのでしょう？
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","MA_01107_9020012")

	change_face(Actor001,"Sad")

	--★★ノワール★★:それは…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_9020013")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ティルフィング★★:はい、マスターならば、きっと
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","MA_01107_9020014")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★ギネマウア★★:よろしくお願いいたします<br>私も微力ながらお役に立てるよう努めますので
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","MA_01107_9020015")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Normal")

	--★★ギネマウア★★:それよりも、明日はきっと大変な１日になります<br>ゆっくりお休みになられたほうがよろしいかと
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","MA_01107_9020016")

-- ▼直接出力
set_enable_auto_lookat(Actor002,true)
PlayActionDirect(Actor001,"to  Std_Talk")
set_common_look_at(Actor001,Actor002)
turn_chara(Actor001,25,0.5)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:そうですね<br>ティルフィング、キミも少し休んだほうがいい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_9020017")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Laugh")

	--★★ティルフィング★★:…では、お言葉に甘えて
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","MA_01107_9020018")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_duel_scene_preload(101060013)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101001","001","101001001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101016","001","101016001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
