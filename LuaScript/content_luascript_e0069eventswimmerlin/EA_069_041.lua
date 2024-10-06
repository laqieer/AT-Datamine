-- このluaスクリプトは、EA_069_041.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera002 = SetTemplate("Actor002",90,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101040011)
	Actor001 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101016","004","101016004","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア","0013")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ギネヴィア★★:足跡を追って来てみたら…<br>森の中にこんな洞窟があるなんて
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_069_0410003")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ギネヴィア★★:ここ、イノシシの巣穴かしら<br>かなり大きいけど…
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_069_0410004")

	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoiceDirect("ギネマウア","0025")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネマウア★★:はぁ…アーサー様たちになにも言わずに<br>こんなところまで来てしまうなんて
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0410005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★ギネマウア★★:ふたりに心配をかける前に<br>早く戻りましょう、ギネヴィア
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0410006")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア","swim_0017")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ギネヴィア★★:駄目よ。まだ、なんであの子たちの様子が<br>変だった理由がわかってないじゃない
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_069_0410007")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Anger")

	--★★ギネマウア★★:あのねぇ…
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0410008")

	PlayAction(Actor001,"to  Std_Sad01")
-- ▼直接出力
SkipDefaultMotion(Actor001)
-- ▲直接出力
	change_face(Actor001,"Pain")

	--★★ギネヴィア★★:だってあの怯え方は普通じゃなかった<br>まるで――
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_069_0410009")

	change_face(Actor002,"Sad")

	--★★ギネマウア★★:………
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0410011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor002,"Sad","EA_069_0410013","EA_069_0410014")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
voice_play("VO_101016_sp_0003_3")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネマウア★★:ギネヴィア、大丈夫？
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0410017")

	PlayAction(Actor001,"to Std_Loop")
-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア","0028")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ギネヴィア★★:…え？
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_069_0410018")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ギネマウア★★:なんだか、辛そうな顔をしているから
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0410019")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Sad")

	--★★ギネヴィア★★:…大丈夫。ただ、ちょっと<br>変なこと考えちゃっただけだから
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_069_0410020")


	--★★ギネマウア★★:………
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0410021")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ギネマウア_004","0046")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネマウア★★:…確かに、あのイノシシたちの様子は<br>普通じゃなかったわ
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0410024")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ギネマウア★★:もしなにかしらの脅威があるとするなら<br>放っておくわけにはいかない
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0410025")

	PlayAction(Actor001,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア","0049")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ギネヴィア★★:…！だよね、だよね！
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_069_0410026")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
voice_play("VO_101016_sp_0003_2")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ギネマウア★★:…それはそれとして、あなたが危険に<br>首を突っ込んでいい理由にはならないわ
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0410027")


	--★★ギネマウア★★:今のあなたは王妃という立場なのだから
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0410028")

	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Sad")

	--★★ギネヴィア★★:むう…
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_069_0410029")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
PlayPartVoiceDirect("ギネマウア_004","0009")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ギネマウア★★:…まぁ、ここまで来てしまったんだし<br>気が済むまで調べてみましょうか
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0410031")

	PlayAction(Actor001,"to  Std_Joy")
-- ▼直接出力
voice_play("VO_101011_sp_0003_1")
-- ▲直接出力
	open_cutin(1,1)
	on_cutin(1,Actor001,"Smile")

	--★★ギネヴィア★★:お姉ちゃん…！
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","N","EA_069_0410033")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	close_cutin()

	--★★ギネマウア★★:
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0410034")

-- ▼直接出力
setup_small_camera_end()
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
	load_duel_scene_preload(101040011)
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101016","004","101016004","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
