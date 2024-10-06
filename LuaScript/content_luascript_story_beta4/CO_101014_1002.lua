-- このluaスクリプトは、CO_101014_1002.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_505_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_001)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_510_02_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera005 = SetTemplate("Actor005",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_504_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	Camera006 = SetTemplate("Actor006",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_017_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera007 = SetTemplate("Actor007",nil,CharaPosDuelCommonFormation01_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_007_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_001)
	Camera008 = SetTemplate("Actor008",nil,CharaPosDuelCommonFormation01_007,"content_motion3d_advarea_common_adv_templatecontroller","Npc_007_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_007)
	Camera009 = SetTemplate("Actor009",nil,CharaPosDuelCommonFormation01_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_005_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_001)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
Hide(Actor004)
-- ▲直接出力
-- ▼直接出力
Hide(Actor005)
-- ▲直接出力
-- ▼直接出力
Hide(Actor009)
-- ▲直接出力
-- ▼直接出力
Hide(Actor008)
-- ▲直接出力
-- ▼直接出力
isu = setup_prop_object(10112001)
set_pos(isu,{0.298, 0, -1.002,   0})
off_active(isu)
-- ▲直接出力
-- ▼直接出力
harp = setup_prop_object(10101017)
off_active(harp)
-- ▲直接出力
-- ▼直接出力
Hide(Actor007)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002,false)
set_enable_auto_lookat(Actor004,false)
set_enable_auto_lookat(Actor005,false)
set_enable_auto_lookat(Actor009,false)
set_enable_auto_lookat(Actor008,false)

-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101010111)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101019","001","101019001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401026","001","401026001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401012","001","401012001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401030","001","401030001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("401021","001","401021001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("401019","001","401019001","content_animationpack__common","FacialPack","Actor008")
	Actor009 = InitializeCharacter_3D("401013","001","401013001","content_animationpack__common","FacialPack","Actor009")
	Actor010 = InitializeCharacter_2DOnly("101009","001","101009001")
	Actor011 = InitializeCharacter_2DOnly("101019","001","101019001")
	template1()
	load_head_animation(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor006,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("王様", "肯定")
-- ▲直接出力

	--★★汎用王様★★:あれほどお助けいただいたと言うのに<br>更に慰労の催しまで、ですと…！？
	Talk(Actor006,"NPCNAME_0292","speech","N","CO_101014_10020002")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("トリスタン", "肯定")
-- ▲直接出力

	--★★トリスタン★★:いつもやってることだから気にしないで<br>みんなを集めてもらえる？
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_10020003")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)

	--★★汎用王様★★:わかりました<br>すぐに声をかけてまいります
	Talk(Actor006,"NPCNAME_0292","speech","N","CO_101014_10020004")

-- ▼直接出力
 --時間経過（黒）
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
Hide(Actor003)
Hide(Actor001)
Hide(Actor006)
Appear(Actor004)
Appear(Actor005)
Appear(Actor009)
Appear(Actor008)
set_animationcontroller(Actor002,"Chr_004_01_SitController","to Sit01_Loop")
on_active(isu)
turn_chara(Actor002,-10,0)
on_active(harp)
harp_offset = {0,0,0,0,0,0}
on_parent(harp,Actor002, "Loc_weapon_constrint_R", harp_offset)
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to hurpplay_loop")
turn_lookat(Actor004,Actor002,0)
turn_lookat(Actor005,Actor002,0)
turn_lookat(Actor007,Actor002,0)
turn_lookat(Actor009,Actor002,0)

se_play("SE_ADV_CO_101014_1002_Harp_Arp")

wait_time(CHARA_IN_OUT + FADE_AFTER_TIME )
setup_small_camera_start()
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("イゾルデ","0010")
-- ▲直接出力
	change_face(Actor011,"Laugh")

	--★★イゾルデ2D★★:トリスタンの竪琴は聞いた者の心を慰め<br>安らぎをもたらすの
	Talk(Actor011,"CHRNAME_ISOLDE","speech","L","CO_101014_10020006")


	--★★イゾルデ2D★★:トリスタンの想いが乗せられた<br>優しい優しい調べ
	Talk(Actor011,"CHRNAME_ISOLDE","speech","L","CO_101014_10020007")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor010,"Laugh")

	--★★ノワール2D★★:綺麗な音色だな
	Talk(Actor010,"CHRNAME_NOIR","speech","L","CO_101014_10020008")

-- ▼直接出力
PlayPartVoice("イゾルデ", "肯定")
-- ▲直接出力
	change_face(Actor011,"Smile")

	--★★イゾルデ2D★★:ええ
	Talk(Actor011,"CHRNAME_ISOLDE","speech","L","CO_101014_10020009")

-- ▼直接出力
 --時間経過（黒）
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
set_chara_pos_resetting(Actor004,CharaPosDuelCommonFormation01_006)
set_chara_pos_resetting(Actor007,CharaPosDuelCommonFormation01_008)
PlayActionDirect(Actor002,"to Sit01_Loop")
set_animationcontroller(Actor002,"Chr_004_01_StdController","to Std_Loop") 

se_play("SE_ADV_Loop_Stop")

off_parent(harp)
off_active(harp)
off_active(isu)
Hide(Actor009)
Hide(Actor005)
Appear(Actor001)
Appear(Actor003)
Appear(Actor006)
Appear(Actor007)
turn_chara(Actor002,-60,0)
set_enable_auto_lookat(Actor002,true)
wait_time(CHARA_IN_OUT + FADE_AFTER_TIME )
setup_small_camera_start()
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
	PlayAction(Actor006,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("王様", "喜び")
-- ▲直接出力

	--★★汎用王様★★:お三方にはいくら感謝してもしきれません<br>町の者全員でお礼の品をお持ちしました
	Talk(Actor006,"NPCNAME_0292","speech","N","CO_101014_10020011")


	--★★汎用王様★★:復興途中で大したものはご用意できませんしたが<br>ぜひ受け取ってください
	Talk(Actor006,"NPCNAME_0292","speech","N","CO_101014_10020012")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★トリスタン★★:ボクは、別に…
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_10020014")

	open_select_window_tag(Actor001,"Normal","CO_101014_10020016","CO_101014_10020017")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:トリスタンがいらないなら<br>俺がもらおうかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_10020019")

	change_face(Actor001,"Smile")

	--★★ノワール★★:受け取ってもらえないのもかわいそうだし
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_10020020")

-- ▼直接出力
PlayPartVoiceDirect("イゾルデ","0015")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★イゾルデ★★:知ってるかしら？<br>冗談には２種類あるの
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","CO_101014_10020022")

	change_face(Actor003,"Normal")

	--★★イゾルデ★★:笑える冗談と笑えない冗談
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","CO_101014_10020023")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:笑えない冗談だったな、ごめん…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_10020024")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:それはトリスタンがもらうべきだ<br>受け取っておけよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_10020026")

	change_face(Actor001,"Laugh")

	--★★ノワール★★:お前が一番頑張ったんだからさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_10020027")

	PlayAction(Actor002,"to  Std_Worry")
	change_face(Actor002,"Sad")

	--★★トリスタン★★:そう、かな…
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_10020028")

	goto Block1end

::Block1end::
-- ▼直接出力
CloseTalkWindow()
wait_time(1.5)
-- ▲直接出力
-- ▼直接出力
voice_play("VO_101019_sp_0002_1")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★イゾルデ★★:この土地の者からのお前への想いよ<br>トリスタン、しっかり受け止めるべきだわ
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","CO_101014_10020030")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Laugh")

	--★★イゾルデ★★:皆が差し伸べてくれた手よ<br>握り返してあげなさい
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","CO_101014_10020031")

	change_face(Actor002,"Normal")

	--★★トリスタン★★:イゾルデ…
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_10020032")

-- ▼直接出力
set_common_look_at(Actor002,Actor006)
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("トリスタン", "肯定")
-- ▲直接出力

	--★★トリスタン★★:わかったよ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_10020033")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("トリスタン","0036")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★トリスタン★★:ありがとう、大事にします
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_10020034")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_トリスタン_ランクアップ10_3")
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
setup_prop_object_preload(10112001)
setup_prop_object_preload(10101017)
	InitializeLoad_Preload()
	load_duel_scene_preload(101010111)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101019","001","101019001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401026","001","401026001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401012","001","401012001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("401030","001","401030001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("401021","001","401021001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("401019","001","401019001","content_animationpack__common","FacialPack","Actor008")
	InitializeCharacter_3D_Preload("401013","001","401013001","content_animationpack__common","FacialPack","Actor009")
	InitializeCharacter_2DOnly_Preload("101009","001","101009001")
	InitializeCharacter_2DOnly_Preload("101019","001","101019001")
	load_head_animation_preload(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
