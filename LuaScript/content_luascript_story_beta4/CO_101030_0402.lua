-- このluaスクリプトは、CO_101030_0402.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_008)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_520_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_009_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_004)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_009_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera005 = SetTemplate("Actor005",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_505_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
set_enable_auto_lookat(Actor001,false)
lookat_delay_weight(Actor001, {0.5, 0.08, 0.8, 0.6} , 1)
keep_ik_lookat(Actor001,Actor004,"J_Head")
keep_ik_lookat(Actor002,Actor004,"J_Head")
keep_ik_lookat(Actor004,Actor002,"J_Head")
keep_ik_lookat(Actor005,Actor002,"J_Head")
-- ▲直接出力
-- ▼直接出力
set_pos(Actor005,{-0.77, 0, -0.05,   95})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101010111)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101030","001","101030001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101031","001","101031001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401015","001","401015001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401016","001","401016001","content_animationpack__common","FacialPack","Actor005")
	template1()
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoiceDirect("エレイン","0007")
-- ▲直接出力

	--★★エレイン★★:…それでね。この前の事件のとき
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_04020002")

	PlayAction(Actor002,"to  Std_Talk")

	--★★エレイン★★:トビーくんになにが起きたのか<br>知っていることがあったら教えてほしいの
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_04020003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("子供_男1", "悩む")
-- ▲直接出力

	--★★子供（男）★★:トビーの家はさ。お父さんとお母さんと<br>あいつの３人家族だったんだけど
	Talk(Actor004,"NPCNAME_0140","speech","L","CO_101030_04020005")


	--★★子供（男）★★:お父さんは兵隊さんで<br>家にいないことが多くてさ
	Talk(Actor004,"NPCNAME_0140","speech","L","CO_101030_04020006")

	PlayAction(Actor004,"to  Std_Talk")

	--★★子供（男）★★:だからあいつ<br>いつもお母さんにべったりくっついてた
	Talk(Actor004,"NPCNAME_0140","speech","L","CO_101030_04020007")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:…トビーの両親は<br>今どこにいるんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_04020008")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)

	--★★子供（男）★★:お父さんのほうがわかんないけど
	Talk(Actor004,"NPCNAME_0140","speech","L","CO_101030_04020009")

	PlayAction(Actor004,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("子供_男1", "悲しみ")
-- ▲直接出力

	--★★子供（男）★★:…お母さんはこないだ死んじゃったんだ
	Talk(Actor004,"NPCNAME_0140","speech","L","CO_101030_04020010")

	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:えっ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_04020011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Sad02")

	--★★子供（男）★★:トビーをかばって<br>ローマの兵士に殺されたんだって
	Talk(Actor004,"NPCNAME_0140","speech","L","CO_101030_04020012")

-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力

	--★★ノワール★★:ひょっとしてトビーは<br>それを目の前で見ていた…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_04020014")

-- ▼直接出力
setup_small_camera_start()
CloseTalkWindow()
set_enable_auto_lookat(Actor002,false)
lookat_delay_weight(Actor002, {0.4, 0.08, 0.7, 0.2} , 1)
keep_delay_ik_lookat(Actor002,Actor004,"J_Head",0.5)
wait_time(WAIT_TIME_SHORT)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("エレイン_005","0036")
-- ▲直接出力

	--★★エレイン★★:話してくれてありがとう
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_04020016")

-- ▼直接出力
PlayPartVoice("子供_男1", "挨拶")
-- ▲直接出力

	--★★子供（男）★★:ねえ、お姉ちゃん<br>トビーの目は治るよね？
	Talk(Actor004,"NPCNAME_0140","speech","L","CO_101030_04020017")

	PlayAction(Actor004,"to  Std_Talk")

	--★★子供（男）★★:俺、またあいつと遊びたいよ！
	Talk(Actor004,"NPCNAME_0140","speech","L","CO_101030_04020018")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エレイン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★エレイン★★:うん、大丈夫<br>お姉ちゃんに任せておいて
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_04020019")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
se_play("SE_ADV_CO_101030_0303_Foot_2_Peaple")
turn_chara(Actor002,0,0)
wait_time(1.1)

Hide(Actor004)
Hide(Actor005)
change_face(Actor002,"Sad")
set_enable_auto_lookat(Actor002,true)
lookat_delay_weight_reset(Actor002,0.6)
set_enable_auto_lookat(Actor001,true)
lookat_delay_weight_reset(Actor001,0.6)
Camera005 = setup_small_camera_resetting(Actor001,CharaPosDuelCommonFormation01_005,CameraPosDuelCommonFormation01_005)
Camera002 = setup_small_camera_resetting(Actor003,CharaPosDuelCommonFormation01_002,CameraPosDuelCommonFormation01_002)
setup_small_camera_start()
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT + FADE_AFTER_TIME)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:トビーのお母さんは<br>あのときの戦いで亡くなっていたのか…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_04020021")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("エレイン", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★エレイン★★:まだあんなに小さいのに…
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_04020022")


	--★★エレイン★★:お母さんが目の前で亡くなられたらショックだったでしょうね…
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_04020023")

	PlayAction(Actor003,"to  Std_Worry")

	--★★ラヴェイン★★:父親は留守にしていたと言っていましたね私のほうで居場所をさぐってみます
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","CO_101030_04020024")

-- ▼直接出力
PlayPartVoice("ラヴェイン", "悩む")
-- ▲直接出力

	--★★ラヴェイン★★:ロンディニウムで起きた事件についてはおそらく聞き及んでいるでしょうが
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","CO_101030_04020025")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)

	--★★ラヴェイン★★:この情勢です戻ってこられないのかもしれない
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","CO_101030_04020026")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:頼む
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_04020027")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
se_play("SE_ADV_CO_101030_0303_Foot_1_Person")
turn_chara(Actor002,-47.04,0)
wait_time(1.1)
Hide(Actor003)
setup_small_camera_start()
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT + FADE_AFTER_TIME)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("エレイン", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エレイン★★:先輩私、これからトビーくんに会ってきます
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_04020029")


	--★★エレイン★★:しばらく行ってなかったから元気づけてあげないと
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_04020030")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:それなら俺も…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_04020031")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★エレイン★★:いえ、大丈夫です今日はひとりで行かせてください
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_04020032")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101030_04020034","CO_101030_04020035")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:心配だ俺もついていくよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_04020037")

	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
PlayPartVoiceDirect("エレイン_005","0019")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★エレイン★★:本当に…ひとりで大丈夫ですから…
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_04020038")

	change_face(Actor002,"Sad")

	--★★エレイン★★:先輩はやらなければならないこともあるでしょうし…
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_04020039")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0008")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:…わかった
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_04020040")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0038")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:わかったじゃあ、俺は先に学園に戻っておく
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_04020042")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:気を付けて行ってきてくれそれから…トビーによろしく
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_04020043")

	goto Block1end

::Block1end::
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エレイン", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エレイン★★:では、先輩今日はここで失礼します
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_04020045")

-- ▼直接出力
local trustParam = set_communication_rankup("エレイン_コミュランク", "エレイン_親密度")
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
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
	load_duel_scene_preload(101010111)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101030","001","101030001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101031","001","101031001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401015","001","401015001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401016","001","401016001","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
