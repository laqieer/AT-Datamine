-- このluaスクリプトは、CO_101035_0502.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112021_01","112021_01_h")
Include("content_adv_advsmall_112021_01","Template112021_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos112021_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos112021_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_511_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPos112021_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_515_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_006)
	Camera004 = SetTemplate("Actor004",nil,CharaPos112021_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_008)
	InitializeTemplateRandomCamera112021_01()
	InitializeTemplate112021_01()
-- ▼直接出力
DontChangeRandomCamera(true)
Hide(Actor003)
Hide(Actor004)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(112021)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101035","001","101035001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101025","001","101025001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("リリアーナ", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★リリアーナ★★:すみません想像していたよりも時間がかかってしまいました
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_05020002")

-- ▼直接出力
DontChangeRandomCamera(false)
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101035_05020004","CO_101035_05020005","CO_101035_05020006")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:なんてことないよ、これくらい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_05020008")

	change_face(Actor002,"Normal")

	--★★リリアーナ★★:お待たせしたうえにたくさん荷物を持ってもらうことになっちゃって
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_05020009")

	PlayAction(Actor001,"to  Std_No")
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:そのために着いてきた気にしなくていいって
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_05020010")

	change_face(Actor001,"Normal")

	--★★ノワール★★:それに今日からお手伝いが増えるんだ道具がたくさん必要になるのも理解してるさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_05020011")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to  Std_Talk")
PlayPartVoice("リリアーナ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★リリアーナ★★:ありがとうございます本当に助かります
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_05020012")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:女性の買い物って長いよな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_05020014")

	change_face(Actor001,"Normal")

	--★★ノワール★★:たまにディナタンの買い物に付き合うけど１時間、２時間は当たり前に待たされる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_05020015")

-- ▼直接出力
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to  Std_No")
PlayPartVoice("リリアーナ", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★リリアーナ★★:う…ご、ごめんなさい…お待たせしちゃいましたよね…
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_05020016")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_No")
-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:いやいや、ディナタンに比べればかわいいもんさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_05020017")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:気にしないでくれその代わりと言ってはなんだけど…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_05020019")

-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:今度、機会があったら俺の買い物に付き合ってもらおうかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_05020020")

	change_face(Actor001,"Sad")

	--★★ノワール★★:俺との買い物なんて退屈かもしれないけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_05020021")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to  Std_Surp")
PlayPartVoice("リリアーナ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★リリアーナ★★:私なんかでよければいつでも！ふふっ、楽しみにしていますね
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_05020022")

	goto Block1end

::Block1end::
-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start()
 --入場演出挿入
EntryWalk_2P(Actor004,Camera004,EntryData112021_01_08,CameraAssetBundleName112021_01,CameraPos112021_01_108,Actor003,CharaPos112021_01_006,CharaPos112021_01_106)
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,-10,0.5)
slidemove(Actor002,{0.3,0,0},0.5)
set_common_look_at(Actor002,Actor004)
change_face(Actor002,"Normal")
change_face(Actor001,"Normal")
setup_small_camera_start()
wait_time(0.5)
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
	PlayAction(Actor004,"to Greet_one")
-- ▼直接出力
PlayPartVoice("ディナタン", "照れ")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★ディナタン★★:ごめんごめん！授業のあとかたづけに手間取っちゃって
	Talk(Actor004,"CHRNAME_DINATAN","speech","L","CO_101035_05020024")

	PlayAction(Actor003,"to Greet_one")
-- ▼直接出力
PlayPartVoice("クレア", "肯定")
-- ▲直接出力

	--★★クレア★★:お待たせ
	Talk(Actor003,"CHRNAME_CLARE","speech","L","CO_101035_05020025")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ディナタンとクレアもちょうどいいタイミングで来たな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_05020026")

-- ▼直接出力
PlayActionDirect(Actor002,"to  Std_Talk")
turn_chara(Actor002,40,0.3)
PlayPartVoice("リリアーナ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★リリアーナ★★:じゃあ、行きましょう！
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_05020027")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_リリアーナ_ランクアップ5_3")
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
	load_area_scene_preload(112021)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101035","001","101035001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101025","001","101025001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName112021_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
