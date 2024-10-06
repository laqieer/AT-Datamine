-- このluaスクリプトは、MA_01A111_18.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation04","DuelCommonFormation04_h")
Include("content_adv_advsmall_duelcommonformation04","TemplateDuelCommonFormation04_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_526_02_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
-- ▲直接出力
-- ▼直接出力
Hide(Actor003)
-- ▲直接出力
end
function template2()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation04_013,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation04,CameraPosDuelCommonFormation04_013)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation04_011,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation04,CameraPosDuelCommonFormation04_011)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation04_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_526_02_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation04,CameraPosDuelCommonFormation04_001)
	InitializeTemplateRandomCameraDuelCommonFormation04()
	InitializeTemplateDuelCommonFormation04()
-- ▼直接出力
load_sound("BGM_Battle_AfterGinevia_General1_Start")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101060011)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101042","001","101042001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("アーサー", "挨拶")
-- ▲直接出力

	--★★アーサー★★:どうだ。楽しいか。学園は。ん？
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A111_180002")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:楽しいよ。アーサー
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_180003")

-- ▼直接出力
 --PlayPartVoice("アーサー", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:そうか！楽しいか！！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A111_180004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:思えば父さんがいなくなってから<br>傭兵だったときも、この学園に入るまでは──
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_180005")


	--★★ノワール★★:安心して笑えたことが<br>あまりなかった
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_180006")


	--★★ノワール★★:同じ立場で、同じ気持ちを持った誰かと<br>こうして肩を並べて何かを学ぶのは…楽しい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_180007")

-- ▼直接出力
 --PlayPartVoice("アーサー", "悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★アーサー★★:昔、ランスとは<br>そうだったんじゃないのか？
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A111_180008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:ああ。だからそのときのことを思い出して…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_180009")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("アーサー", "肯定")
-- ▲直接出力

	--★★アーサー★★:いま笑えているなら、良かったよ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A111_180010")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:なんかさっきの…<br>不器用な父親みたいな聞きかただったな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_180011")


	--★★アーサー★★:まぁ、良い父親にはなれんだろうな！<br>義姉さんにすら手を焼かせている俺では
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A111_180012")

	PlayAction(Actor002,"to  Std_Talk")

	--★★アーサー★★:そうだ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A111_180014")


	--★★アーサー★★:…どうして俺が義姉さんを困らせているか<br>聞いてもらいたいな。ノワール
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A111_180016")

	open_select_window_tag(Actor001,"Normal","MA_01A111_180018","MA_01A111_180019")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:どうして今？<br>興味ないな…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_180021")

-- ▼直接出力
 --PlayPartVoice("アーサー", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★アーサー★★:そう言うな
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A111_180022")

	change_face(Actor002,"Normal")

	--★★アーサー★★:王様のプライベートなんて<br>そうそう聞けんぞ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A111_180023")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:弱みを握れるかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_180025")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("アーサー", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★アーサー★★:俺の弱みでもあり<br>義姉さんの恥でもある
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A111_180026")

	change_face(Actor002,"Normal")

	--★★アーサー★★:聞いておいて損はないぞ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A111_180027")

	goto Block1end

::Block1end::
	change_face(Actor002,"Normal")

	--★★アーサー★★:義姉さんは俺の乳母だ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A111_180029")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
	open_cutin(1,1)
	on_cutin(1,Actor001,"Surprise")
-- ▼直接出力
wait_time(1.5)
-- ▲直接出力
	close_cutin()

	--★★アーサー★★:我が母イグレーヌ付きの侍女として城に入り<br>イグレーヌは義姉さんを娘のように可愛がり…
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A111_180031")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "納得")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:そのうちにモルガン先生は<br>アーサーの養育に乳母として携わった…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_180032")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("アーサー", "肯定")
-- ▲直接出力

	--★★アーサー★★:俺を戦場から遠ざけるべく<br>孤児院に預けてからも…
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A111_180034")

	PlayAction(Actor002,"to  Std_Worry")

	--★★アーサー★★:彼女は『姉』として通いつめ<br>家族として暖かく接してくれた
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A111_180035")

-- ▼直接出力
 --PlayPartVoice("アーサー", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:ただ小さいころの俺は<br>どうしようもなく甘ったれでな
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A111_180036")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
se_play("SE_ADV_MA_01A111_04_Witch_BlackFeather")
Appear(Actor003)
bgm_play("Stop_BGM_Bus_2")
show_image("101010140", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("モーロノエー", "喜び")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★モーロノエー★★:それは今も昔も変わらず、でしょう？
	Talk(Actor003,"CHRNAME_NAMELES","speech","N","MA_01A111_180038")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
hide_image(0)
template2()
--モーロノエー,CHRNAME_SISTERS_1 @名前変更
setup_small_camera_start(RndCamera001)
set_enable_auto_lookat(Actor001, false)
set_enable_auto_lookat(Actor002, false)
change_face(Actor001,"Serious")
change_face(Actor002,"Serious")
keep_ik_lookat(Actor001,Actor003,"J_Head")
keep_ik_lookat(Actor002,Actor003,"J_Head")
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
bgm_play("BGM_Battle_AfterGinevia_General1_Start")
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("モーロノエー", "笑い")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★モーロノエー★★:味見をしに来たわ<br>アーサー
	Talk(Actor003,"CHRNAME_SISTERS_1","speech","R","MA_01A111_180040")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("アーサー", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Serious")

	--★★アーサー★★:…ログレスの勢力圏へ<br>こうも無謀に足を踏み入れるか。魔女
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A111_180041")

-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("モーロノエー", "肯定2")
-- ▲直接出力

	--★★モーロノエー★★:あまりオオゴトにしたくないの<br>今日は確かめに来ただけ
	Talk(Actor003,"CHRNAME_SISTERS_1","speech","R","MA_01A111_180042")

	PlayAction(Actor003,"to  Std_Talk")

	--★★モーロノエー★★:アーサー<br>貴方が健やかに生きているかどうか
	Talk(Actor003,"CHRNAME_SISTERS_1","speech","R","MA_01A111_180043")


	--★★モーロノエー★★:そうなれば我ら魔女の矛先はどこへ向くべきか<br>『当初の目的』を果たすべきか、否か──
	Talk(Actor003,"CHRNAME_SISTERS_1","speech","R","MA_01A111_180044")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Serious")

	--★★ノワール★★:なにを言っている…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_180046")

-- ▼直接出力
 --PlayPartVoice("モーロノエー", "肯定")
-- ▲直接出力

	--★★モーロノエー★★:変わっていくのは悲しいことね
	Talk(Actor003,"CHRNAME_SISTERS_1","speech","R","MA_01A111_180048")


	--★★モーロノエー★★:昔と今で、自分すら
	Talk(Actor003,"CHRNAME_SISTERS_1","speech","R","MA_01A111_180049")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
preload_sound("BGM_Battle_AfterGinevia_General1_Start")
	InitializeLoad_Preload()
	load_duel_scene_preload(101060011)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101042","001","101042001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation04)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
