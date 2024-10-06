-- このluaスクリプトは、CO_101034_0503.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_03","110071_03_h")
Include("content_adv_advsmall_110071_03","Template110071_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",40,CharaPos110071_03_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110071_03,CameraPos110071_03_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110071_03_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_510_01_StdController","to Std_Loop",CameraAssetBundleName110071_03,CameraPos110071_03_003)
	InitializeTemplateRandomCamera110071_03()
	InitializeTemplate110071_03()
-- ▼直接出力
DontChangeRandomCamera(true)
set_pos(Actor002,{3.7,0.13,18.5})
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor001,Actor002,"J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110071)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101034","001","101034001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力

	--★★ノワール★★:さっきの報告、よくまとまってたな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_05030002")

-- ▼直接出力
setup_small_camera_start(RndCamera004)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to  Std_Talk")
turn_chara(Actor002,160,0.5)
PlayPartVoice("エクセリア", "肯定2")
-- ▲直接出力

	--★★エクセリア★★:相手の情報を調べ上げ先手を打つことは戦術の基本中の基本よ
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_05030003")


	--★★エクセリア★★:アダンからそう教わってきたわ
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_05030004")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101034_05030006","CO_101034_05030007","CO_101034_05030008")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:どのくらいの時期からバルバロイの目撃情報をまとめてたんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_05030010")

	change_face(Actor002,"Normal")

	--★★エクセリア★★:この学園に来てからずっとよ
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_05030011")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:えっ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_05030012")

	change_face(Actor002,"Normal")

	--★★エクセリア★★:ノワールもなにかデータが必要になったら言ってちょうだい
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_05030013")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Surprise")

	--★★ノワール★★:あ、ああ…それは助かるよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_05030014")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:この作戦でみんなを助けられるんじゃないかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_05030016")

-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:お手柄だよ、エクセリア
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_05030017")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エクセリア", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★エクセリア★★:特別なことはなにもしていないからそう言われても返事に困るわ
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_05030018")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:いいや十分に特別なことだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_05030019")

-- ▼直接出力
PlayPartVoice("エクセリア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★エクセリア★★:そうなの？…ありがとう
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_05030020")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:防備体制のことまで考えていたとはさすがだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_05030022")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ただ情報を集めていただけじゃない集めた情報を活かす方法を考える…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_05030023")

	change_face(Actor001,"Normal")

	--★★ノワール★★:これはそうカンタンにできることじゃないよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_05030024")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("エクセリア", "照れ")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★エクセリア★★:なんだかむず痒い感じね
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_05030025")

	change_face(Actor002,"Shy")

	--★★エクセリア★★:私はアダンから学んだことを実践しているだけなのに
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_05030026")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ところでさ。さっき言ってた中心地って前に俺たちが行った森だよな？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_05030028")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エクセリア", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エクセリア★★:そうね
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_05030029")

	PlayAction(Actor001,"to  Std_Worry")

	--★★ノワール★★:このあいだの木こりたちの村が近いよな心配だ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_05030030")


	--★★エクセリア★★:心配？どうして？
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_05030031")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:どうしてって…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_05030032")


	--★★エクセリア★★:自分の記憶のなかにいる人にひどい目に遭ってほしくない…
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_05030034")


	--★★エクセリア★★:そういうこと？
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_05030036")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:あ、あぁ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_05030037")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エクセリア", "肯定")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★エクセリア★★:そうね、そういう視点で考えるとたしかに…
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_05030038")

	PlayAction(Actor002,"to  Std_Sad01")

	--★★エクセリア★★:ひどい目に遭って欲しくない、と私も思うわ
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_05030039")

-- ▼直接出力
local trustParam = set_communication_rankup("エクセリア_コミュランク", "エクセリア_親密度")
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
-- ▲直接出力
-- ▼直接出力
open_trust_rank_up(Actor002, trustParam)
-- ▲直接出力
-- ▼直接出力
 --open_trust_gauge(Actor002, trustParam)
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
	load_area_scene_preload(110071)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101034","001","101034001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110071_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
