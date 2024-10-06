-- このluaスクリプトは、CO_101035_0504.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",-40,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera002 = SetTemplate("Actor002",50,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_511_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_515_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	Camera005 = SetTemplate("Actor005",160,CharaPosDuelCommonFormation01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_007)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
DontChangeRandomCamera(true)
set_pos(Actor005,{-2.1,0,4.9})
change_face(Actor002,"Sad")
change_face(Actor004,"Sad")
set_enable_auto_lookat(Actor001,false)
lookat_weight(Actor001,0.45,0.1,0.8,0.2)
set_enable_auto_lookat(Actor002,false)
set_common_look_at(Actor001,Actor002)
set_common_look_at(Actor003,Actor002)
Hide(Actor003)
Hide(Actor005)
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Speculation")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101060011)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101035","001","101035001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101025","001","101025001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101017","001","101017001","content_animationpack__common","FacialPack","Actor005")
	template1()
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	change_face(Actor004,"Sad")

	--★★ディナタン★★:リリアーナ…
	Talk(Actor004,"CHRNAME_DINATAN","speech","L","CO_101035_05040001")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
set_enable_auto_lookat(Actor001,true)
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:同じことが起こらないように柵を作ったほうがいいかもしれない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_05040002")

-- ▼直接出力
DontChangeRandomCamera(false)
manager.CloseupUpExclusiveCamera(Actor004)
-- ▲直接出力
	play_head_motion(Actor004, "No", 0.3, 1.0, false)
-- ▼直接出力
lookat_weight(Actor001,0.7,0.03,0.7,0)
PlayPartVoice("ディナタン", "悩む")
-- ▲直接出力

	--★★ディナタン★★:相手は人間でしょ？柵くらいじゃ効果は薄いんじゃないかな
	Talk(Actor004,"CHRNAME_DINATAN","speech","L","CO_101035_05040003")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:それはそうだけどあるに越したことはないだろ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_05040004")

-- ▼直接出力
CloseTalkWindow()
EntryWalk(Actor003,Camera003,EntryDataDuelCommonFormation01_02,CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_102)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002,true)
PlayActionDirect(Actor001,"to Wlk")
turn_chara(Actor001,-20,0.2)
wait_time(0.2)
PlayActionDirect(Actor001,"to Std_Loop")
PlayPartVoice("クレア", "挨拶")
-- ▲直接出力

	--★★クレア★★:詳しく調べてみたのだけれどなんだかおかしな足跡なの
	Talk(Actor003,"CHRNAME_CLARE","speech","L","CO_101035_05040006")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")

	--★★クレア★★:左右の大きさに差があって足跡の横に棒か何かを刺した跡もあるの
	Talk(Actor003,"CHRNAME_CLARE","speech","L","CO_101035_05040007")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
set_enable_auto_lookat(Actor001,false)
PlayPartVoice("リリアーナ", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★リリアーナ★★:どっ、どういうことでしょう…？
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_05040008")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★クレア★★:足跡が続いているほうを見てくる
	Talk(Actor003,"CHRNAME_CLARE","speech","L","CO_101035_05040009")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101035_05040011","CO_101035_05040012")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_No")
-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:クレア、待った俺も一緒に行くよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_05040014")

	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
PlayPartVoice("リリアーナ", "怒り")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★リリアーナ★★:ノワールさん、クレア！調べてくれるのは嬉しいけど、危険ですよ…
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_05040015")

-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",1)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:たとえばだけどもしここで放っておいたとして
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_05040016")

	change_face(Actor001,"Normal")

	--★★ノワール★★:次にリリアーナがひとりで畑に来たときに犯人が現れたらどうする？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_05040017")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:そのほうが危険だよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_05040018")

	PlayAction(Actor002,"to  Std_Sad01")
	change_face(Actor002,"Sad")

	--★★リリアーナ★★:それは、そうかもしれませんけど…
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_05040019")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor001,"to Greet_one")
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:気を付けてな、クレア
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_05040021")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クレア", "怒り")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★クレア★★:…なにを言っているのあなたも行くのよ。着いてきて
	Talk(Actor003,"CHRNAME_CLARE","speech","L","CO_101035_05040022")

-- ▼直接出力
PlayActionDirect(Actor001,"to Std_Loop")
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:え？あ、ああ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_05040023")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",1)
PlayPartVoice("リリアーナ", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★リリアーナ★★:わ、私も――
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_05040025")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_MidFade")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor001,false)
PlayPartVoice("クレア", "否定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★クレア★★:あなた、戦える？
	Talk(Actor003,"CHRNAME_CLARE","speech","L","CO_101035_05040027")

-- ▼直接出力
bgm_play("BGM_ADV_Speculation")
PlayPartVoice("リリアーナ", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★リリアーナ★★:えっ？
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_05040028")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("クレア", "挨拶")
-- ▲直接出力

	--★★クレア★★:もしも戦いが起きたときあなたは人間と戦える？
	Talk(Actor003,"CHRNAME_CLARE","speech","L","CO_101035_05040029")

-- ▼直接出力
PlayPartVoice("ディナタン", "驚き")
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★ディナタン★★:戦い？どうしてそんな話になるの？
	Talk(Actor004,"CHRNAME_DINATAN","speech","L","CO_101035_05040030")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)

	--★★クレア★★:もしもの話よ
	Talk(Actor003,"CHRNAME_CLARE","speech","L","CO_101035_05040031")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to  Std_Sad01")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★リリアーナ★★:…戦うのは、怖いです
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_05040032")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クレア", "肯定2")
-- ▲直接出力

	--★★クレア★★:それならここで待っていなさいディナタン、リリアーナを守ってあげて
	Talk(Actor003,"CHRNAME_CLARE","speech","L","CO_101035_05040033")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
	change_face(Actor004,"Sad")

	--★★ディナタン★★:う、うん
	Talk(Actor004,"CHRNAME_DINATAN","speech","L","CO_101035_05040034")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
set_common_look_at(Actor002,Actor003)
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★リリアーナ★★:…いいえ、行きます私だってみんなの役に立ちたい、です
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_05040035")

-- ▼直接出力
setup_small_camera_start(Camera004)
set_rot(Actor001,{0,-40,0})
set_rot(Actor002,{0,20,0})
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★ディナタン★★:リリアーナ…
	Talk(Actor004,"CHRNAME_DINATAN","speech","L","CO_101035_05040037")

-- ▼直接出力
setup_small_camera_start()
Appear(Actor005)
PlayActionDirect(Actor005,"to Run")
slidemove(Actor005,{-0.7,0,1.2},1)
wait_time(0.8)
PlayActionDirect(Actor005,"to Std_Loop")
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Angry")
-- ▼直接出力
set_enable_auto_lookat_all(false)
PlayPartVoice("マルディサント", "挨拶")
-- ▲直接出力
	change_face(Actor005,"Anger")

	--★★マルディサント★★:ディーナ、ディーナ！緊急事態だ！…って、クレアにリリア―ナもいるのか？
	Talk(Actor005,"CHRNAME_MALADISANT","speech","L","CO_101035_05040039")

-- ▼直接出力
PlayActionDirect(Actor004,"to  Std_Surp")
turn_chara(Actor004,40,0.3)
keep_delay_ik_lookat(Actor004,Actor005,"J_Head",1)
keep_delay_ik_lookat(Actor001,Actor004,"J_Head",1)
keep_delay_ik_lookat(Actor002,Actor005,"J_Head",1)
keep_delay_ik_lookat(Actor003,Actor005,"J_Head",1)
PlayPartVoice("ディナタン", "驚き")
-- ▲直接出力

	--★★ディナタン★★:マァル！どうしたの？
	Talk(Actor004,"CHRNAME_DINATAN","speech","L","CO_101035_05040041")

-- ▼直接出力
set_enable_auto_lookat(Actor005, true)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:なにかあったのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_05040042")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("マルディサント", "肯定")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★マルディサント★★:街の近くでバルバロイが出てさ学連の連中何人かで対応にあたったんだ
	Talk(Actor005,"CHRNAME_MALADISANT","speech","L","CO_101035_05040043")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:それは大変だ俺たちもすぐ現場に行く
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_05040044")

	play_head_motion(Actor005, "No", 0.3, 1.0, false)

	--★★マルディサント★★:いや、もうバルバロイは撃退されたよ現場のほうは心配いらない
	Talk(Actor005,"CHRNAME_MALADISANT","speech","L","CO_101035_05040046")

-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:え？緊急事態なんじゃないのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_05040047")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("マルディサント", "肯定")
-- ▲直接出力

	--★★マルディサント★★:戦闘で負傷者が出たんだよ<br>そいつらの手当てができる人間が必要なんだ
	Talk(Actor005,"CHRNAME_MALADISANT","speech","L","CO_101035_05040048")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディナタン", "肯定3")
-- ▲直接出力
	change_face(Actor004,"Anger")

	--★★ディナタン★★:わかった、すぐに戻るわ
	Talk(Actor004,"CHRNAME_DINATAN","speech","L","CO_101035_05040049")

-- ▼直接出力
set_enable_auto_lookat_all(true)
PlayActionDirect(Actor002,"to  Std_Talk")
turn_chara(Actor002,50,0.3)
PlayPartVoice("リリアーナ", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★リリアーナ★★:今日のところは私たちも戻りましょう少しでもお手伝いしないと
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_05040050")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
DontChangeRandomCamera(false)
PlayPartVoice("クレア", "肯定")
-- ▲直接出力

	--★★クレア★★:そうね<br>足跡はまた別の日に調べに来ましょう
	Talk(Actor003,"CHRNAME_CLARE","speech","L","CO_101035_05040051")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★クレア★★:リリアーナ。それまではなるべくここにひとりで来ないようにして
	Talk(Actor003,"CHRNAME_CLARE","speech","L","CO_101035_05040052")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★リリアーナ★★:は、はいわかりました…
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_05040053")

-- ▼直接出力
local trustParam = set_communication_rankup("リリアーナ_コミュランク", "リリアーナ_親密度")
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
preload_sound("BGM_ADV_Speculation")
	InitializeLoad_Preload()
	load_duel_scene_preload(101060011)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101035","001","101035001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101025","001","101025001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101017","001","101017001","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
